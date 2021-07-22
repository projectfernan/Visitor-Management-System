Imports System.IO.Path
Imports System.Drawing.Imaging

Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Diagnostics

Imports System.Drawing.Drawing2D
Imports WacomMTDN
Imports WintabDN

Public Class frmSigna

    Private Class FingerAttributesMap
        Inherits Dictionary(Of Int32, FingerRenderAttributes)
    End Class

    Public PicTimes As String

    Private mFingerAttributesMap As New FingerAttributesMap()

    Public Delegate Sub UpdateUIDelegate(ByRef fingerCollection As WacomMTFingerCollection)
    Public mUpdateUIDelegate As UpdateUIDelegate

    Public Delegate Sub UpdateUIControlsDelegate(ByVal enable As Boolean)
    Public mUpdateUIControlsDelegate As UpdateUIControlsDelegate

    Private mWacomMTConfig As New CWacomMTConfig()
    Private mWacomMTFingerClient As CWacomMTFingerClient
    Private mFingerCallback As WacomMTFingerCallback
    Private mAttachCallback As WacomMTAttachCallback
    Private mDetachCallback As WacomMTDetachCallback
    Private mUserDataString As [String] = "User data returned to client..."
    Private mUserDataStringReturned As [String] = ""
    Private mUserDataIntPtr As IntPtr = IntPtr.Zero
    Private mClientProcessingMode As WacomMTProcessingMode = WacomMTConstants.CONSUMER_CLIENT
    Private mRegisterClientByHitRect As Boolean = True
    Private mCheckFingerConfidence As Boolean = True
    Private mNumFingers As UInt32 = 0
    Private m_logContext As CWintabContext = Nothing
    Private m_wtData As CWintabData = Nothing
    Private m_pkX As Int32 = 0
    Private m_pkY As Int32 = 0
    Private m_pressure As UInt32 = 0
    Private m_pkTime As UInt32 = 0
    Private m_pkTimeLast As UInt32 = 0
    Private Const m_TABEXTX As Int32 = 10000
    Private Const m_TABEXTY As Int32 = 10000
    Private m_lastPoint As Point = Point.Empty

    Private m_graphics As Graphics = Nothing
    Private m_pen As Pen
    Private m_backPen As Pen

    Private Sub DoAttachCallback(ByVal deviceCapability_I As WacomMTCapability, ByVal userData_I As IntPtr)
        Try
            mWacomMTConfig.AddDevice(deviceCapability_I)

            If mWacomMTFingerClient Is Nothing Then
                CreateNewClient(deviceCapability_I.DeviceID, mClientProcessingMode)
            End If

            If mRegisterClientByHitRect Then
                mWacomMTFingerClient.RegisterHitRectClient(deviceCapability_I.DeviceID, GetHitRectForClient(deviceCapability_I.DeviceID), mFingerCallback, mUserDataIntPtr)
            Else
                Dim hwnd As WacomMTDN.HWND = Me.Handle
                mWacomMTFingerClient.RegisterHWNDClient(deviceCapability_I.DeviceID, hwnd)
            End If

            Invoke(mUpdateUIControlsDelegate, True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub DoDetachCallback(ByVal deviceID_I As Int32, ByVal userData_I As IntPtr)
        Try
            UnregisterClient()
            mWacomMTConfig.RemoveDevice(deviceID_I)

            Invoke(mUpdateUIControlsDelegate, False)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Function DoFingerUpdateCallback(ByVal fingerPacket_I As IntPtr, ByVal userData_I As IntPtr) As UInt32
        Try
            Dim fingerCollection As WacomMTFingerCollection = WacomMTDN.CMemUtils.PtrToStructure(Of WacomMTFingerCollection)(fingerPacket_I)
            mUserDataStringReturned = WacomMTDN.CMemUtils.PtrToManagedString(userData_I)

            mNumFingers = fingerCollection.FingerCount

#If TRACE_FINGER_DATA Then
				DumpFingerCollection(fingerCollection_I)
				Trace.WriteLine("Userdata: " & userDataString)
#End If

            Invoke(mUpdateUIDelegate, fingerCollection)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        Return 0
    End Function
    Private Sub DoUpdateUI(ByRef fingerCollection_I As WacomMTFingerCollection)
#If TRACE_UI_UPDATE Then
			Trace.WriteLine("DoUpdateUI ...")
			DumpFingerCollection(fingerCollection_I)
#End If
        Dim allFingersUp__1 As Boolean = AllFingersUp(fingerCollection_I)

        '       UpdateUIStatusBarUserData(mUserDataStringReturned, allFingersUp__1)
        '   UpdateUIStatusBarFingerCount(mNumFingers, allFingersUp__1)
        For idx As Integer = 0 To CInt(fingerCollection_I.FingerCount) - 1
            Dim finger As WacomMTFinger = fingerCollection_I.GetFingerByIndex(idx)
            RenderFinger(idx, finger)
        Next
    End Sub

    Private Sub RenderFinger(ByVal fingerIndex_I As Int32, ByRef finger_I As WacomMTFinger)
        If fingerIndex_I >= WacomMTConstants.MAX_NUMBER_FINGERS Then
            Trace.WriteLine("RenderFinger bailing due to large finger index: " & fingerIndex_I)
            Return
        End If
        If mCheckFingerConfidence AndAlso Not finger_I.Confidence Then
            Return
        End If

        Dim panelGraphics As Graphics = Fingerpanel.CreateGraphics()
        Dim myPen As Pen = Nothing
        Dim myBrush As SolidBrush = Nothing
        Dim clientPoint As New Point(0, 0)

        If mWacomMTConfig.IsDisplayTablet(mWacomMTFingerClient.DeviceID) Then
            clientPoint = PointToClient(New Point(CInt(finger_I.X), CInt(finger_I.Y)))
        Else
            clientPoint = New Point(CInt(Me.ClientRectangle.Left + finger_I.X * Me.ClientRectangle.Width), CInt(Me.ClientRectangle.Top + finger_I.Y * Me.ClientRectangle.Height))
        End If

        Try
            Dim attribs As FingerRenderAttributes = mFingerAttributesMap(fingerIndex_I)
            Dim radius As Int32 = CType(attribs.Length, Int32)
            myPen = New Pen(attribs.Color, attribs.PenWidth)

            Select Case attribs.Shape
                Case FingerShape.Square
                    If True Then
                        panelGraphics.DrawRectangle(myPen, New Rectangle(clientPoint.X - radius, clientPoint.Y - radius, 2 * radius, 2 * radius))
                    End If
                    Exit Select

                Case FingerShape.Cross
                    If True Then
                        panelGraphics.DrawLine(myPen, New Point(clientPoint.X - radius, clientPoint.Y), New Point(clientPoint.X + radius, clientPoint.Y))
                        panelGraphics.DrawLine(myPen, New Point(clientPoint.X, clientPoint.Y - radius), New Point(clientPoint.X, clientPoint.Y + radius))
                    End If
                    Exit Select

                Case FingerShape.HorzBar
                    If True Then
                        panelGraphics.DrawLine(myPen, New Point(clientPoint.X - radius, clientPoint.Y), New Point(clientPoint.X + radius, clientPoint.Y))
                        panelGraphics.DrawLine(myPen, New Point(clientPoint.X - radius, clientPoint.Y - 2), New Point(clientPoint.X - radius, clientPoint.Y + 2))
                        panelGraphics.DrawLine(myPen, New Point(clientPoint.X + radius, clientPoint.Y - 2), New Point(clientPoint.X + radius, clientPoint.Y + 2))
                    End If
                    Exit Select

                Case FingerShape.VertBar
                    If True Then
                        panelGraphics.DrawLine(myPen, New Point(clientPoint.X, clientPoint.Y - radius), New Point(clientPoint.X, clientPoint.Y + radius))
                        panelGraphics.DrawLine(myPen, New Point(clientPoint.X - 2, clientPoint.Y - radius), New Point(clientPoint.X + 2, clientPoint.Y - radius))
                        panelGraphics.DrawLine(myPen, New Point(clientPoint.X - 2, clientPoint.Y + radius), New Point(clientPoint.X + 2, clientPoint.Y + radius))
                    End If
                    Exit Select

                Case FingerShape.Circle ', Else
                    If True Then
                        panelGraphics.DrawEllipse(myPen, New Rectangle(clientPoint.X - radius, clientPoint.Y - radius, 2 * radius, 2 * radius))
                    End If
                    Exit Select
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            panelGraphics.Dispose()

            If myPen IsNot Nothing Then
                myPen.Dispose()
            End If
            If myBrush IsNot Nothing Then
                myBrush.Dispose()
            End If
        End Try
    End Sub



    Private Sub DoUpdateUIControls(ByVal enable As Boolean)
        UpdateUIStatus()
        'UpdateUIControls(enable)
    End Sub

    Public Sub DumpFingerCollection(ByRef fingerCollection_I As WacomMTFingerCollection)
        Try
            Dim numFingers As Integer = CInt(fingerCollection_I.FingerCount)

            If numFingers > 0 Then
                For idx As Integer = 0 To numFingers - 1
                    Dim finger As WacomMTFinger = fingerCollection_I.GetFingerByIndex(idx)

                    Trace.WriteLine("Finger ID:     " + finger.FingerID)
                    Trace.WriteLine("  X:           " + finger.X)
                    Trace.WriteLine("  Y:           " + finger.Y)
                    Trace.WriteLine("  Width:       " + finger.Width)
                    Trace.WriteLine("  Height:      " + finger.Height)
                    Trace.WriteLine("  Sensitivity: " + finger.Sensitivity)
                    Trace.WriteLine("  Orientation: " + finger.Orientation)
                    Trace.WriteLine("  Confidence:  " + finger.Confidence)
                    Trace.WriteLine("  TouchState:  " + finger.TouchState)
                Next
            Else
                Trace.WriteLine("WacomMTDN Test: WARNING: no fingers in fingerCollection!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Enable_Scribble(Optional ByVal enable As Boolean = False)
        If enable Then
            m_graphics = Fingerpanel.CreateGraphics()
            m_graphics.SmoothingMode = SmoothingMode.AntiAlias

            m_pen = New Pen(Color.Black)
            m_backPen = New Pen(Color.Black)
        Else
            CloseCurrentContext()
            If m_graphics IsNot Nothing Then
                Fingerpanel.Invalidate()
                m_graphics.Dispose()
                m_graphics = Nothing
            End If
        End If
    End Sub
    Private Function GetHitRectForClient(ByVal deviceID_I As Int32) As WacomMTHitRect
        If mWacomMTConfig.IsDisplayTablet(deviceID_I) Then
            Return New WacomMTHitRect(Me.Location.X, Me.Location.Y, Me.ClientRectangle.Width, Me.ClientRectangle.Height)
        Else
            Return New WacomMTHitRect(0, 0, 1, 1)
        End If
    End Function
    Private Function OpenSystemContext(Optional ByVal width_I As Integer = m_TABEXTX, Optional ByVal height_I As Integer = m_TABEXTY, Optional ByVal ctrlSysCursor As Boolean = True) As CWintabContext
        Dim status As Boolean = False
        Dim logContext As CWintabContext = Nothing
        Try
            logContext = CWintabInfo.GetDefaultSystemContext(ECTXOptionValues.CXO_MESSAGES)
            If ctrlSysCursor Then
                logContext.Options = logContext.Options Or CUInt(ECTXOptionValues.CXO_SYSTEM)
            Else
                logContext.Options = logContext.Options And Not CUInt(ECTXOptionValues.CXO_SYSTEM)
            End If

            If logContext Is Nothing Then
                Trace.WriteLine("FAILED to get default digitizing context.")
                Return Nothing
            End If
            logContext.Name = "WintabDN Event Data Context"
            Dim tabletX As WintabAxis = CWintabInfo.GetTabletAxis(EAxisDimension.AXIS_X)
            Dim tabletY As WintabAxis = CWintabInfo.GetTabletAxis(EAxisDimension.AXIS_Y)
            logContext.InOrgX = 0
            logContext.InOrgY = 0
            logContext.InExtX = tabletX.axMax
            logContext.InExtY = tabletY.axMax
            logContext.OutOrgX = CInt(System.Windows.Forms.SystemInformation.VirtualScreen.Left)
            logContext.OutOrgY = CInt(System.Windows.Forms.SystemInformation.VirtualScreen.Top)
            logContext.OutExtX = CInt(System.Windows.Forms.SystemInformation.VirtualScreen.Width)
            logContext.OutExtY = -CInt(System.Windows.Forms.SystemInformation.VirtualScreen.Height)
            status = logContext.Open()
            Trace.WriteLine("Context Open: " & (If(status, "PASSED [ctx=" + logContext.HCtx.ToString & "]", "FAILED")))
        Catch ex As Exception
            Trace.WriteLine("OpenTestDigitizerContext ERROR: " & ex.ToString())
        End Try
        Return logContext
    End Function


    Private Sub InitDataCapture(Optional ByVal ctxHeight_I As Integer = m_TABEXTX, Optional ByVal ctxWidth_I As Integer = m_TABEXTY, Optional ByVal ctrlSysCursor_I As Boolean = True)
        Try
            CloseCurrentContext()
            m_logContext = OpenSystemContext(ctxWidth_I, ctxHeight_I, ctrlSysCursor_I)

            If m_logContext Is Nothing Then
                Return
            End If
            m_wtData = New CWintabData(m_logContext)
            m_wtData.SetWTPacketEventHandler(AddressOf MyWTPacketEventHandler)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub InitWintab()
        ClearDisplay()
        Enable_Scribble(True)
        Dim controlSystemCursor As Boolean = True
        InitDataCapture(m_TABEXTX, m_TABEXTY, controlSystemCursor)
    End Sub

    Public Sub New()
        InitializeComponent()
        mUpdateUIDelegate = New UpdateUIDelegate(AddressOf Me.DoUpdateUI)
        mUpdateUIControlsDelegate = New UpdateUIControlsDelegate(AddressOf Me.DoUpdateUIControls)
        mFingerAttributesMap.Add(0, New FingerRenderAttributes(Color.Blue, FingerShape.Circle, 2, 10))
        mFingerAttributesMap.Add(1, New FingerRenderAttributes(Color.Green, FingerShape.Square, 2, 10))
        mFingerAttributesMap.Add(2, New FingerRenderAttributes(Color.Red, FingerShape.Cross, 2, 10))
        mFingerAttributesMap.Add(3, New FingerRenderAttributes(Color.Violet, FingerShape.VertBar, 2, 10))
        mFingerAttributesMap.Add(4, New FingerRenderAttributes(Color.Orange, FingerShape.HorzBar, 2, 10))
        mFingerAttributesMap.Add(5, New FingerRenderAttributes(Color.DarkBlue, FingerShape.Circle, 2, 10))
        mFingerAttributesMap.Add(6, New FingerRenderAttributes(Color.DarkGreen, FingerShape.Square, 2, 10))
        mFingerAttributesMap.Add(7, New FingerRenderAttributes(Color.DarkRed, FingerShape.Cross, 2, 10))
        mFingerAttributesMap.Add(8, New FingerRenderAttributes(Color.DarkViolet, FingerShape.VertBar, 2, 10))
        mFingerAttributesMap.Add(9, New FingerRenderAttributes(Color.DarkOrange, FingerShape.HorzBar, 2, 10))
        UpdateUIStatus()
        Try
            mUserDataIntPtr = WacomMTDN.CMemUtils.AllocateUnmanagedString(mUserDataString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub TestAppForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            UnregisterClient()
            If mWacomMTConfig IsNot Nothing Then
                mWacomMTConfig.Quit()
                mWacomMTConfig = Nothing
            End If
            If mUserDataIntPtr <> IntPtr.Zero Then
                WacomMTDN.CMemUtils.FreeUnmanagedString(mUserDataIntPtr)
                mUserDataIntPtr = IntPtr.Zero
            End If
            If m_graphics IsNot Nothing Then
                m_graphics.Dispose()
                m_graphics = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    <System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")> _
    Protected Overrides Sub WndProc(ByRef message_I As Message)
        Select Case message_I.Msg
            Case WacomMTConstants.WM_FINGERDATA
                If True Then
                    Try
                        Dim fingerCollection As WacomMTFingerCollection = WacomMTDN.CMemUtils.PtrToStructure(Of WacomMTFingerCollection)(CType(message_I.LParam, IntPtr))

                        DoUpdateUI(fingerCollection)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString())
                    End Try
                End If
                Exit Select
        End Select
        MyBase.WndProc(message_I)
    End Sub
    Private Function AllFingersUp(ByRef fingerCollection_I As WacomMTFingerCollection) As Boolean
        For idx As Int32 = 0 To fingerCollection_I.FingerCount - 1
            If fingerCollection_I.GetFingerByIndex(idx).TouchState <> WacomMTFingerState.WMTFingerStateUp Then
                Return False
            End If
        Next

        Return True
    End Function
    Sub ClearDisplay()
        Fingerpanel.Invalidate()
    End Sub
    Private Sub CloseCurrentContext()
        Try
            If m_logContext IsNot Nothing Then
                m_logContext.Close()
                m_logContext = Nothing
                m_wtData = Nothing
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub UnregisterClient()
        Try
            If mWacomMTFingerClient IsNot Nothing Then
                If mRegisterClientByHitRect Then
                    mWacomMTFingerClient.UnregisterHitRectClient()
                Else
                    mWacomMTFingerClient.UnregisterHWNDClient()
                End If
                mWacomMTFingerClient = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub CreateNewClient(ByVal deviceID_I As Int32, ByVal mode_I As WacomMTProcessingMode)
        Try
            UnregisterClient()
            mClientProcessingMode = mode_I
            mWacomMTFingerClient = New CWacomMTFingerClient(mClientProcessingMode)

            If mRegisterClientByHitRect Then
                mWacomMTFingerClient.RegisterHitRectClient(deviceID_I, GetHitRectForClient(deviceID_I), mFingerCallback, mUserDataIntPtr)
            Else
                Dim hwnd As WacomMTDN.HWND = Me.Handle
                mWacomMTFingerClient.RegisterHWNDClient(deviceID_I, hwnd)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub UpdateUIStatus()
        '  UpdateUIStatusBarClientMode()
        '  UpdateUIStatusBarUserData()
        ' UpdateUIStatusBarFingerCount()
        ' UpdateUIStatusBarConfidenceBitsEnabled()
    End Sub

    Public Sub MyWTPacketEventHandler(ByVal sender_I As [Object], ByVal eventArgs_I As MessageReceivedEventArgs)
here:   If m_wtData Is Nothing OrElse m_graphics Is Nothing Then
            Exit Sub
        End If

        Try
            Dim pktID As UInteger = CUInt(eventArgs_I.Message.WParam)
            Dim pkt As WintabPacket = m_wtData.GetDataPacket(CUInt(eventArgs_I.Message.LParam), pktID)
            If pkt.pkContext <> 0 Then
                m_pkX = pkt.pkX
                m_pkY = pkt.pkY
                m_pressure = pkt.pkNormalPressure

                Trace.Write("pkX,PkY: [" & m_pkX & "," & m_pkY & "]; ")

                m_pkTime = pkt.pkTime
                Dim clientPoint As Point = Fingerpanel.PointToClient(New Point(m_pkX, m_pkY))
                Trace.WriteLine("clientPoint: [" & clientPoint.X & "," & clientPoint.Y & "]")

                If m_lastPoint.Equals(Point.Empty) Then
                    m_lastPoint = clientPoint
                    m_pkTimeLast = m_pkTime
                End If

                m_pen.Width = CSng(m_pressure \ 200)

                If m_pressure > 0 Then
                    Try
                        If m_pkTime - m_pkTimeLast < 5 Then
                            m_graphics.DrawRectangle(m_pen, clientPoint.X, clientPoint.Y, 1, 1)
                        Else
                            m_graphics.DrawLine(m_pen, clientPoint, m_lastPoint)
                        End If
                    Catch ex As Exception
                        GoTo here
                    End Try
                End If

                m_lastPoint = clientPoint
                m_pkTimeLast = m_pkTime
            End If

        Catch ex As Exception
            Throw New Exception("FAILED to get packet data: " & ex.ToString())
        End Try
    End Sub

    Sub LoadSignaPad()
        Dim userDataBuf As IntPtr = IntPtr.Zero

        Try
            mWacomMTConfig.Init()
            mFingerCallback = New WacomMTFingerCallback(AddressOf Me.DoFingerUpdateCallback)
            mAttachCallback = New WacomMTAttachCallback(AddressOf Me.DoAttachCallback)
            CWacomMTInterface.WacomMTRegisterAttachCallback(mAttachCallback, IntPtr.Zero)
            mDetachCallback = New WacomMTDetachCallback(AddressOf Me.DoDetachCallback)
            CWacomMTInterface.WacomMTRegisterDetachCallback(mDetachCallback, IntPtr.Zero)
            If mWacomMTConfig.GetNumAttachedTouchDevices() > 0 Then
                'UpdateUIControls(True)
                Dim deviceID As Int32 = mWacomMTConfig.GetAttachedDeviceID(0)
                'UpdateUIDeviceIDList()
                InitWintab()
            Else

                'UpdateUIControls(False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub frmSigna_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterSigna()
        End If

        If e.KeyCode = Keys.Back Then
            ClearDisplay()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Sub EnterSigna()
        Dim area As Rectangle = Fingerpanel.Parent.RectangleToScreen(Fingerpanel.Bounds)
        Dim capture As System.Drawing.Bitmap
        Dim graph As Graphics
        capture = New System.Drawing.Bitmap(Fingerpanel.Bounds.Width, Fingerpanel.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(capture)
        graph.CopyFromScreen(area.X, area.Y, 0, 0, area.Size, CopyPixelOperation.SourceCopy)
        MainForm.PictureBox1.Image = capture

        ClearDisplay()
        Me.Close()
    End Sub

    Private Sub frmSigna_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        InitWintab()
        ' LoadSignaPad()
    End Sub

    Private Sub cmdAccept_Click(sender As System.Object, e As System.EventArgs) Handles cmdAccept.Click
        EnterSigna()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ClearDisplay()
    End Sub

    Private Sub Button1_GotFocus(sender As Object, e As System.EventArgs) Handles Button1.GotFocus
        Fingerpanel.Focus()
    End Sub

    Private Sub frmSigna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class