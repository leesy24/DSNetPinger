Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Threading

''//============================================================================================================
''// - 2015-12-26 Machine Name Logfile add
''// - 2015-12-28 ping.Send ping check error code edit
''//============================================================================================================

Public Class UserControl1

    Public ping As New Ping
    Public rp(3) As PingReply

    Public car1 As Integer
    Public cIndex As Integer
    Public aIndex1 As Integer
    Public aindex2 As Integer
    Public aindex3 As Integer

    Public wnTimeOut As Integer
    Public pDateTime(3) As DateTime
    Public pSuccess(3) As Boolean ''= False
    Public pSuccessDateTime(3) As DateTime
    Public pFail(3) As Boolean ''= False
    Public pFailCnt(3) As ULong
    Public pFailDayCnt(3) As Long

    Public LanErr As Boolean

    Public logFile As New clsLogFile ''//Log Class1

    Private Sub UserControl1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PictureBox1.Width = Me.Width
        PictureBox1.Height = Me.Height
        ''//Label1.BackColor = Color.Transparent

        'mcTitle.Parent = PictureBox1
        'mcTitle.Top = 0
        'mcTitle.Left = (PictureBox1.Width / 2) - (mcTitle.Width / 2)

        pDateTime(0) = DateTime.Now
        pDateTime(1) = DateTime.Now
        pDateTime(2) = DateTime.Now
        pDateTime(3) = DateTime.Now

        pSuccess(0) = True
        pSuccess(1) = True
        pSuccess(2) = True
        pSuccess(3) = True

        pSuccessDateTime(0) = DateTime.Now
        pSuccessDateTime(1) = DateTime.Now
        pSuccessDateTime(2) = DateTime.Now
        pSuccessDateTime(3) = DateTime.Now

        pFail(0) = True
        pFail(1) = True
        pFail(2) = True
        pFail(3) = True

        pFailCnt(0) = 0
        pFailCnt(1) = 0
        pFailCnt(2) = 0
        pFailCnt(3) = 0

        pFailDayCnt(0) = 0
        pFailDayCnt(1) = 0
        pFailDayCnt(2) = 0
        pFailDayCnt(3) = 0

        LanErr = True

    End Sub

    Public Sub carPosition(cGubun As Integer)
        ''//Position
        ''car1 = cGubun
        If cGubun = 1 Then
            wnCar1.Left = (PictureBox1.Width / 3) ''- (wnCar1.Width / 2)
        Else
            wnCar1.Left = (PictureBox1.Width / 3) + (PictureBox1.Width / 4)
        End If
        ''//2014-07-30 Code
        wnCar1.Height = PictureBox1.Height / 3

        wnPLC1.Height = wnCar1.Height
        wnPLC1.Top = wnCar1.Top
        wnPLC1.Left = wnCar1.Left + wnPLC1.Width + 40

        cnLine1.Top = wnCar1.Top + ((wnCar1.Height / 2) - (cnLine1.Height / 2))
        cnLine1.Left = wnCar1.Left + wnCar1.Width
        cnLine1.Width = wnPLC1.Left - (wnCar1.Width + wnCar1.Left)

        picCar1.Height = wnCar1.Height + 5
        picCar1.Top = (PictureBox1.Height / 2) - (picCar1.Height / 2)
        picCar1.Width = wnCar1.Width + cnLine1.Width + wnPLC1.Width + 20
        picCar1.Left = wnCar1.Left - 10

        ''//mc title position
        mcTitle.Parent = PictureBox1
        mcTitle.Top = 0
        mcTitle.Left = picCar1.Left + ((picCar1.Width - mcTitle.Width) / 2) ''//(PictureBox1.Width / 2) - (mcTitle.Width / 2)



    End Sub

    Private Sub UserControl1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        ''//Position!
        PictureBox1.Width = Me.Width
        PictureBox1.Height = Me.Height

        'If car1 = 1 Then
        '    wnCar1.Left = (PictureBox1.Width / 3) - wnCar1.Width
        'Else
        '    wnCar1.Left = (PictureBox1.Width / 3) + (PictureBox1.Width / 4)
        'End If
        ''//2014-07-30 Code
        wnCar1.Height = PictureBox1.Height / 3

        wnCar1.Top = (PictureBox1.Height / 2) - (wnCar1.Height / 2)

        wnPLC1.Height = wnCar1.Height
        wnPLC1.Top = wnCar1.Top
        ''wnPLC1.Left = wnCar1.Left + wnPLC1.Width + 40

        cnLine1.Top = wnCar1.Top + ((wnCar1.Height / 2) - (cnLine1.Height / 2))
        ''cnLine1.Left = wnCar1.Left + wnCar1.Width
        cnLine1.Width = wnPLC1.Left - (wnCar1.Width + wnCar1.Left)

        picCar1.Height = wnCar1.Height + 5
        picCar1.Top = (PictureBox1.Height / 2) - (picCar1.Height / 2)
        picCar1.Width = wnCar1.Width + cnLine1.Width + wnPLC1.Width + 20
        ''picCar1.Left = wnCar1.Left - 10

        ''//mc title position
        mcTitle.Parent = PictureBox1
        mcTitle.Top = 0
        ''mcTitle.Left = picCar1.Left + ((picCar1.Width - mcTitle.Width) / 2) ''//(PictureBox1.Width / 2) - (mcTitle.Width / 2)

        wnAP1.Height = PictureBox1.Height / 4
        wnAP2.Height = PictureBox1.Height / 4
        wnAP1.Top = (PictureBox1.Height / 2) - wnAP1.Height - 1 ''- 10
        wnAP2.Top = (PictureBox1.Height / 2) + 1 ''+ 10

        mcTitle.Left = (PictureBox1.Width / 2) - (mcTitle.Width / 2)

    End Sub

    Public Sub carInput(msPosition As String, msGubun As Integer) ''//, apName As String)

        ''//Name Setup
        ''//HRE113 Reverse
        ''H/RE113, H/RE111, ST/RE101,
        ''1 = Server, 2 = AP1, 3 = AP2, 4 = PLC
        'If InStr(msName, "HRE111") > 0 Then
        '    mcTitle.Text = "WIRELESS MACHINE H/RE111" '& msName.ToString()
        'ElseIf InStr(msName, "HRE113") > 0 Then
        '    mcTitle.Text = "WIRELESS MACHINE H/RE113" '& msName.ToString()
        'ElseIf InStr(msName, "STRE101") > 0 Then
        '    mcTitle.Text = "WIRELESS MACHINE ST/RE101" '& msName.ToString()
        'Else
        '    mcTitle.Text = "WIRELESS MACHINE " & msName.ToString()
        'End If


        ''// 2015-12-28===========================================================
        If InStr(msPosition, "REVERSE") > 0 Then
            ''//HRE113 position edit 2015-12-28
            wnAP1.Left = 2
            wnAP2.Left = 2

            wnCar1.Left = (PictureBox1.Width / 2)
            wnPLC1.Left = wnCar1.Left + wnPLC1.Width + 40
            cnLine1.Left = wnCar1.Left + wnCar1.Width
            picCar1.Left = wnCar1.Left - 10
            mcTitle.Left = (PictureBox1.Width / 2) - (mcTitle.Width / 2) ''//(PictureBox1.Width / 2) - (mcTitle.Width / 2)

        Else ''//Left
            ''//position edit 2015-12-28
            wnAP1.Left = PictureBox1.Width - wnAP1.Width - 2
            wnAP2.Left = PictureBox1.Width - wnAP2.Width - 2

            ''wnCar1.Left = (PictureBox1.Width / 6)
            ''wnPLC1.Left = wnCar1.Left + wnPLC1.Width + 40
            ''cnLine1.Left = wnCar1.Left + wnCar1.Width

            wnPLC1.Left = (PictureBox1.Width / 6)
            cnLine1.Left = wnPLC1.Left + wnPLC1.Width
            wnCar1.Left = cnLine1.Left + cnLine1.Width '' + 40

            picCar1.Left = wnPLC1.Left - 10
            mcTitle.Left = (PictureBox1.Width / 2) - (mcTitle.Width / 2) ''//picCar1.Left + ((picCar1.Width - mcTitle.Width) / 2) ''//(PictureBox1.Width / 2) - (mcTitle.Width / 2)
        End If
        ''//=====================================================================

        'wnCar1.Text = svrName.ToString() & "-SERVER"
        'wnAP1.Text = apName.ToString() & "-BRIDGE"
        'wnAP2.Text = apName.ToString() & "-FO-HUB"
        ' ''//plc
        'wnPLC1.Text = svrName.ToString() & "-PLC"

        wnCar1.Text = "SERVER"
        wnAP1.Text = "AP1"
        wnAP2.Text = "AP2"
        ''//plc
        wnPLC1.Text = "PLC"

    End Sub

    Public Sub carIPReceive(strMC As String, strEQ As String, strIP As String, wnIndex As Integer)
        ''//Machine IP Receive

        mcTitle.Text = "WIRELESS MACHINE " & strMC.ToString()

        If InStr(strEQ, wnCar1.Text) > 0 Then
            wnCar1.Tag = strIP.ToString()
            cIndex = wnIndex
        End If

        If InStr(strEQ, wnAP1.Text) > 0 Then
            wnAP1.Tag = strIP.ToString()
            aIndex1 = wnIndex
        End If

        If InStr(strEQ, wnAP2.Text) > 0 Then
            wnAP2.Tag = strIP.ToString()
            aindex2 = wnIndex
        End If

        If InStr(strEQ, wnPLC1.Text) > 0 Then
            wnPLC1.Tag = strIP.ToString()
            aindex3 = wnIndex
        End If

        ''///////////////// Main HUB ===============
        If InStr(strEQ, "FINEX1") > 0 Then
            wnCar1.Tag = strIP.ToString()
            cIndex = wnIndex
        End If

        If InStr(strEQ, "FINEX2-1") > 0 Then
            wnAP1.Tag = strIP.ToString()
            aIndex1 = wnIndex
        End If

        If InStr(strEQ, "FINEX2-2") > 0 Then
            wnAP2.Tag = strIP.ToString()
            aindex2 = wnIndex
        End If

        If InStr(strEQ, "EWS") > 0 Then
            wnPLC1.Tag = strIP.ToString()
            aindex3 = wnIndex
        End If
        ''///////////////// Main HUB end ============

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ''// ping check time~~
        Thread.Sleep(wnTimeOut)

        Try
            LanErr = True

            ''If Form1.lvMainIPList1.Items(cIndex).Checked = True Then rp(0) = ping.Send(wnCar1.Tag, 100)
            ''If Form1.lvMainIPList1.Items(aIndex1).Checked = True Then rp(1) = ping.Send(wnAP1.Tag, 100)
            ''If Form1.lvMainIPList1.Items(aindex2).Checked = True Then rp(2) = ping.Send(wnAP2.Tag, 100)
            ''If Form1.lvMainIPList1.Items(aindex3).Checked = True Then rp(3) = ping.Send(wnPLC1.Tag, 100)

            rp(0) = ping.Send(wnCar1.Tag, 100)
            rp(1) = ping.Send(wnAP1.Tag, 100)
            rp(2) = ping.Send(wnAP2.Tag, 100)
            rp(3) = ping.Send(wnPLC1.Tag, 100)

        Catch ex As Exception
            ''//MessageBox.Show(e.ToString)
            LanErr = False

        End Try

    End Sub

    ''//Ping Data & Log Data
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Try
            If LanErr = True Then
                ''//Machine Server
                If rp(0).Status = IPStatus.Success Then

                    If InStr(mcTitle.Text, "HUB") > 0 Then
                        Form1.cmdMCR.BackColor = Color.Lime
                    Else
                        wnCar1.BackColor = Color.Lime
                    End If


                    ''Form1.lvMainIPList1.Items(cIndex).SubItems(4).Text = "IP " & IPStatus.Success.ToString & "   " & rp(0).RoundtripTime & " ms" ''& DateTime.Now.ToString("HH:mm:ss")
                    Form1.lvMainIPList1.Items(cIndex).SubItems(4).Text = "IP Ping Success " & rp(0).RoundtripTime & " ms" ''& DateTime.Now.ToString("HH:mm:ss")
                    Form1.lvMainIPList1.Items(cIndex).ForeColor = Color.DarkGreen

                    If pSuccess(0) = True Then
                        logFile.LogDataSave1(Form1.lvMainIPList1.Items(cIndex).SubItems(4).Text & " " & CInt((DateTime.Now - pSuccessDateTime(0)).TotalSeconds) & " secs", _
                                             Form1.lvMainIPList1.Items(cIndex).SubItems(1).Text & "-" & Form1.lvMainIPList1.Items(cIndex).SubItems(2).Text, _
                                             Form1.lvMainIPList1.Items(cIndex).SubItems(3).Text)
                        pSuccess(0) = False
                        pFail(0) = True
                    End If

                    If DateTime.Now.Day <> pDateTime(0).Day Then
                        pFailDayCnt(0) = 0
                    End If

                Else
                    ''//wnCar1.BackColor = Color.Red
                    If InStr(mcTitle.Text, "HUB") > 0 Then
                        Form1.cmdMCR.BackColor = Color.Red
                    Else
                        wnCar1.BackColor = Color.Red
                    End If

                    If DateTime.Now.Day <> pDateTime(0).Day Then
                        If pFail(0) = True Then
                            pFailDayCnt(0) = 0
                        Else
                            pFail(0) = True
                            pFailCnt(0) = pFailCnt(0) - 1
                            pFailDayCnt(0) = -1
                        End If
                    End If

                    Form1.lvMainIPList1.Items(cIndex).SubItems(4).Text = "IP Fail TimeOut " & rp(0).RoundtripTime & " ms " & pFailCnt(0) + 1 & ", " & pFailDayCnt(0) + 1 & " cnt"

                    If Form1.lvMainIPList1.Items(cIndex).Checked = True Then
                        ''//fail count 100000 --> 0   2015-12-08
                        'If Convert.ToInt32(Form1.lvMainIPList1.Items(cIndex).SubItems(5).Text) = 10 Then
                        '    Form1.lvMainIPList1.Items(cIndex).SubItems(5).Text = "0"
                        'End If

                        'Form1.lvMainIPList1.Items(cIndex).SubItems(5).Text = Convert.ToString(Convert.ToInt32(Form1.lvMainIPList1.Items(cIndex).SubItems(5).Text) + 1)
                        Form1.lvMainIPList1.Items(cIndex).ForeColor = Color.Red
                        ''log
                        If pFail(0) = True Then
                            logFile.LogDataSave1(Form1.lvMainIPList1.Items(cIndex).SubItems(4).Text, _
                                                 Form1.lvMainIPList1.Items(cIndex).SubItems(1).Text & "-" & Form1.lvMainIPList1.Items(cIndex).SubItems(2).Text, _
                                                 Form1.lvMainIPList1.Items(cIndex).SubItems(3).Text)
                            pFail(0) = False
                            If pFailDayCnt(0) <> -1 Then
                                pSuccessDateTime(0) = DateTime.Now
                            End If
                            pFailCnt(0) = pFailCnt(0) + 1
                            pFailDayCnt(0) = pFailDayCnt(0) + 1
                        End If
                    Else
                        Form1.lvMainIPList1.Items(cIndex).ForeColor = Color.Black
                    End If

                    pSuccess(0) = True

                End If

                pDateTime(0) = DateTime.Now

                ''//Machine AP1
                If rp(1).Status = IPStatus.Success Then

                    If InStr(mcTitle.Text, "HUB") > 0 Then
                        Form1.cmdNO1.BackColor = Color.Lime
                    Else
                        wnAP1.BackColor = Color.Lime
                    End If



                    ''Form1.lvMainIPList1.Items(aIndex1).SubItems(4).Text = "IP " & IPStatus.TimedOut.ToString & "   " & rp(1).RoundtripTime & " ms"
                    Form1.lvMainIPList1.Items(aIndex1).SubItems(4).Text = "IP Ping Success " & rp(1).RoundtripTime & " ms" ''& DateTime.Now.ToString("HH:mm:ss")
                    Form1.lvMainIPList1.Items(aIndex1).ForeColor = Color.DarkGreen

                    If pSuccess(1) = True Then
                        logFile.LogDataSave1(Form1.lvMainIPList1.Items(aIndex1).SubItems(4).Text & " " & CInt((DateTime.Now - pSuccessDateTime(1)).TotalSeconds) & " secs", _
                                             Form1.lvMainIPList1.Items(aIndex1).SubItems(1).Text & "-" & Form1.lvMainIPList1.Items(aIndex1).SubItems(2).Text, _
                                             Form1.lvMainIPList1.Items(aIndex1).SubItems(3).Text)
                        pSuccess(1) = False
                        pFail(1) = True
                    End If

                    If DateTime.Now.Day <> pDateTime(1).Day Then
                        pFailDayCnt(1) = 0
                    End If

                Else
                    If InStr(mcTitle.Text, "HUB") > 0 Then
                        Form1.cmdNO1.BackColor = Color.Red
                    Else
                        wnAP1.BackColor = Color.Red
                    End If

                    If DateTime.Now.Day <> pDateTime(1).Day Then
                        If pFail(1) = True Then
                            pFailDayCnt(1) = 0
                        Else
                            pFail(1) = True
                            pFailCnt(1) = pFailCnt(1) - 1
                            pFailDayCnt(1) = -1
                        End If
                    End If

                    ''Form1.lvMainIPList1.Items(aIndex1).SubItems(4).Text = "IP " & IPStatus.TimedOut.ToString & "  " & rp(1).RoundtripTime & " ms"
                    Form1.lvMainIPList1.Items(aIndex1).SubItems(4).Text = "IP Fail TimeOut " & rp(1).RoundtripTime & " ms " & pFailCnt(1) + 1 & ", " & pFailDayCnt(1) + 1 & " cnt"

                    If Form1.lvMainIPList1.Items(aIndex1).Checked = True Then
                        ''//fail count 100000 --> 0   2015-12-08
                        'If Convert.ToInt32(Form1.lvMainIPList1.Items(aIndex1).SubItems(5).Text) = 10 Then
                        '    Form1.lvMainIPList1.Items(aIndex1).SubItems(5).Text = "0"
                        'End If

                        'Form1.lvMainIPList1.Items(aIndex1).SubItems(5).Text = Convert.ToString(Convert.ToInt32(Form1.lvMainIPList1.Items(aIndex1).SubItems(5).Text) + 1)
                        Form1.lvMainIPList1.Items(aIndex1).ForeColor = Color.Red
                        ''log
                        If pFail(1) = True Then
                            logFile.LogDataSave1(Form1.lvMainIPList1.Items(aIndex1).SubItems(4).Text, _
                                                 Form1.lvMainIPList1.Items(aIndex1).SubItems(1).Text & "-" & Form1.lvMainIPList1.Items(aIndex1).SubItems(2).Text, _
                                                 Form1.lvMainIPList1.Items(aIndex1).SubItems(3).Text)
                            pFail(1) = False
                            If pFailDayCnt(1) <> -1 Then
                                pSuccessDateTime(1) = DateTime.Now
                            End If
                            pFailCnt(1) = pFailCnt(1) + 1
                            pFailDayCnt(1) = pFailDayCnt(1) + 1
                        End If
                    Else
                        Form1.lvMainIPList1.Items(aIndex1).ForeColor = Color.Black
                    End If

                    pSuccess(1) = True
                End If

                pDateTime(1) = DateTime.Now

                    ''//Machine AP2
                If rp(2).Status = IPStatus.Success Then

                    If InStr(mcTitle.Text, "HUB") > 0 Then
                        Form1.cmdNO2.BackColor = Color.Lime
                    Else
                        wnAP2.BackColor = Color.Lime
                    End If

                    ''//wnAP2.BackColor = Color.Lime

                    ''Form1.lvMainIPList1.Items(aindex2).SubItems(4).Text = "IP " & IPStatus.TimedOut.ToString & "   " & rp(1).RoundtripTime & " ms"
                    Form1.lvMainIPList1.Items(aindex2).SubItems(4).Text = "IP Ping Success " & rp(2).RoundtripTime & " ms" ''& DateTime.Now.ToString("HH:mm:ss")
                    Form1.lvMainIPList1.Items(aindex2).ForeColor = Color.DarkGreen

                    If pSuccess(2) = True Then
                        logFile.LogDataSave1(Form1.lvMainIPList1.Items(aindex2).SubItems(4).Text & " " & CInt((DateTime.Now - pSuccessDateTime(2)).TotalSeconds) & " secs", _
                                             Form1.lvMainIPList1.Items(aindex2).SubItems(1).Text & "-" & Form1.lvMainIPList1.Items(aindex2).SubItems(2).Text, _
                                             Form1.lvMainIPList1.Items(aindex2).SubItems(3).Text)
                        pSuccess(2) = False
                        pFail(2) = True
                    End If

                    If DateTime.Now.Day <> pDateTime(2).Day Then
                        pFailDayCnt(2) = 0
                    End If

                Else

                    If InStr(mcTitle.Text, "HUB") > 0 Then
                        Form1.cmdNO2.BackColor = Color.Red
                    Else
                        wnAP2.BackColor = Color.Red
                    End If

                    ''//wnAP2.BackColor = Color.Red

                    If DateTime.Now.Day <> pDateTime(2).Day Then
                        If pFail(2) = True Then
                            pFailDayCnt(2) = 0
                        Else
                            pFail(2) = True
                            pFailCnt(2) = pFailCnt(2) - 1
                            pFailDayCnt(2) = -1
                        End If
                    End If

                    ''Form1.lvMainIPList1.Items(aindex2).SubItems(4).Text = "IP " & IPStatus.TimedOut.ToString & "  " & rp(1).RoundtripTime & " ms"
                    Form1.lvMainIPList1.Items(aindex2).SubItems(4).Text = "IP Fail TimeOut " & rp(2).RoundtripTime & " ms " & pFailCnt(2) + 1 & ", " & pFailDayCnt(2) + 1 & " cnt"

                    If Form1.lvMainIPList1.Items(aindex2).Checked = True Then
                        ''//fail count 100000 --> 0   2015-12-08
                        'If Convert.ToInt32(Form1.lvMainIPList1.Items(aindex2).SubItems(5).Text) = 10 Then
                        '    Form1.lvMainIPList1.Items(aindex2).SubItems(5).Text = "0"
                        'End If

                        'Form1.lvMainIPList1.Items(aindex2).SubItems(5).Text = Convert.ToString(Convert.ToInt32(Form1.lvMainIPList1.Items(aindex2).SubItems(5).Text) + 1)
                        Form1.lvMainIPList1.Items(aindex2).ForeColor = Color.Red
                        ''log
                        If pFail(2) = True Then
                            logFile.LogDataSave1(Form1.lvMainIPList1.Items(aindex2).SubItems(4).Text, _
                                                 Form1.lvMainIPList1.Items(aindex2).SubItems(1).Text & "-" & Form1.lvMainIPList1.Items(aindex2).SubItems(2).Text, _
                                                 Form1.lvMainIPList1.Items(aindex2).SubItems(3).Text)
                            pFail(2) = False
                            If pFailDayCnt(2) <> -1 Then
                                pSuccessDateTime(2) = DateTime.Now
                            End If
                            pFailCnt(2) = pFailCnt(2) + 1
                            pFailDayCnt(2) = pFailDayCnt(2) + 1
                        End If
                    Else
                        Form1.lvMainIPList1.Items(aindex2).ForeColor = Color.Black
                    End If
                    pSuccess(2) = True
                End If

                pDateTime(2) = DateTime.Now

                    ''//Machine PLC
                If rp(3).Status = IPStatus.Success Then

                    If InStr(mcTitle.Text, "HUB") > 0 Then
                        Form1.cmdNO7.BackColor = Color.Lime
                    Else
                        wnPLC1.BackColor = Color.Lime
                    End If

                    ''//wnPLC1.BackColor = Color.Lime

                    ''Form1.lvMainIPList1.Items(aindex3).SubItems(4).Text = "IP " & IPStatus.TimedOut.ToString & "   " & rp(1).RoundtripTime & " ms"
                    Form1.lvMainIPList1.Items(aindex3).SubItems(4).Text = "IP Ping Success " & rp(3).RoundtripTime & " ms" ''& DateTime.Now.ToString("HH:mm:ss")
                    Form1.lvMainIPList1.Items(aindex3).ForeColor = Color.DarkGreen

                    If pSuccess(3) = True Then
                        logFile.LogDataSave1(Form1.lvMainIPList1.Items(aindex3).SubItems(4).Text & " " & CInt((DateTime.Now - pSuccessDateTime(3)).TotalSeconds) & " secs", _
                                             Form1.lvMainIPList1.Items(aindex3).SubItems(1).Text & "-" & Form1.lvMainIPList1.Items(aindex3).SubItems(2).Text, _
                                             Form1.lvMainIPList1.Items(aindex3).SubItems(3).Text)
                        pSuccess(3) = False
                        pFail(3) = True
                    End If

                    If DateTime.Now.Day <> pDateTime(3).Day Then
                        pFailDayCnt(3) = 0
                    End If

                Else

                    If InStr(mcTitle.Text, "HUB") > 0 Then
                        Form1.cmdNO7.BackColor = Color.Red
                    Else
                        wnPLC1.BackColor = Color.Red
                    End If

                    ''//wnPLC1.BackColor = Color.Red

                    If DateTime.Now.Day <> pDateTime(3).Day Then
                        If pFail(3) = True Then
                            pFailDayCnt(3) = 0
                        Else
                            pFail(3) = True
                            pFailCnt(3) = pFailCnt(3) - 1
                            pFailDayCnt(3) = -1
                        End If
                    End If

                    ''Form1.lvMainIPList1.Items(aindex3).SubItems(4).Text = "IP " & IPStatus.TimedOut.ToString & "  " & rp(1).RoundtripTime & " ms"
                    Form1.lvMainIPList1.Items(aindex3).SubItems(4).Text = "IP Fail TimeOut " & rp(3).RoundtripTime & " ms " & pFailCnt(3) + 1 & ", " & pFailDayCnt(3) + 1 & " cnt"

                    If Form1.lvMainIPList1.Items(aindex3).Checked = True Then
                        ''//fail count 100000 --> 0   2015-12-08
                        'If Convert.ToInt32(Form1.lvMainIPList1.Items(aindex3).SubItems(5).Text) = 10 Then
                        '    Form1.lvMainIPList1.Items(aindex3).SubItems(5).Text = "0"
                        'End If

                        'Form1.lvMainIPList1.Items(aindex3).SubItems(5).Text = Convert.ToString(Convert.ToInt32(Form1.lvMainIPList1.Items(aindex3).SubItems(5).Text) + 1)
                        Form1.lvMainIPList1.Items(aindex3).ForeColor = Color.Red
                        ''log
                        If pFail(3) = True Then
                            logFile.LogDataSave1(Form1.lvMainIPList1.Items(aindex3).SubItems(4).Text, _
                                                 Form1.lvMainIPList1.Items(aindex3).SubItems(1).Text & "-" & Form1.lvMainIPList1.Items(aindex3).SubItems(2).Text, _
                                                 Form1.lvMainIPList1.Items(aindex3).SubItems(3).Text)
                            pFail(3) = False
                            If pFailDayCnt(3) <> -1 Then
                                pSuccessDateTime(3) = DateTime.Now
                            End If
                            pFailCnt(3) = pFailCnt(3) + 1
                            pFailDayCnt(3) = pFailDayCnt(3) + 1
                        End If
                    Else
                        Form1.lvMainIPList1.Items(aindex3).ForeColor = Color.Black
                    End If
                    pSuccess(3) = True
                End If

                pDateTime(3) = DateTime.Now

            Else '' of If LanErr = True Then
                ''//error ?????????????
                LanErr = True

                Form1.lvMainIPList1.Items(cIndex).SubItems(4).Text = "WMS System Error LAN Cable Check."
                Form1.lvMainIPList1.Items(aIndex1).SubItems(4).Text = "WMS System Error LAN Cable Check."
                Form1.lvMainIPList1.Items(aindex2).SubItems(4).Text = "WMS System Error LAN Cable Check."
                Form1.lvMainIPList1.Items(aindex3).SubItems(4).Text = "WMS System Error LAN Cable Check."

                Form1.lvMainIPList1.Items(cIndex).ForeColor = Color.Red
                Form1.lvMainIPList1.Items(aIndex1).ForeColor = Color.Red
                Form1.lvMainIPList1.Items(aindex2).ForeColor = Color.Red
                Form1.lvMainIPList1.Items(aindex3).ForeColor = Color.Red

            End If
            BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception

            ''//MessageBox.Show(e.ToString)

            ''//2015-12-28 Err Check~???????????????
            ''logFile.LogDataSave1(e.ToString, _
            ''        Form1.lvMainIPList1.Items(cIndex).SubItems(1).Text & "-" & Form1.lvMainIPList1.Items(cIndex).SubItems(2).Text, _
            ''        Form1.lvMainIPList1.Items(cIndex).SubItems(3).Text)

            ''Form1.lvMainIPList1.Items(cIndex).SubItems(4).Text = e.ToString
            ''Form1.lvMainIPList1.Items(aIndex1).SubItems(4).Text = e.ToString
            ''Form1.lvMainIPList1.Items(aindex2).SubItems(4).Text = e.ToString
            ''Form1.lvMainIPList1.Items(aindex3).SubItems(4).Text = e.ToString

            ''Form1.lvMainIPList1.Items(cIndex).ForeColor = Color.RosyBrown
            ''Form1.lvMainIPList1.Items(aIndex1).ForeColor = Color.RosyBrown
            ''Form1.lvMainIPList1.Items(aindex2).ForeColor = Color.RosyBrown
            ''Form1.lvMainIPList1.Items(aindex3).ForeColor = Color.RosyBrown


        End Try
    End Sub

    Public Sub carStart(wnStart As Boolean, wnTime As Integer)

        wnTimeOut = wnTime

        If wnStart = True Then
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

End Class
