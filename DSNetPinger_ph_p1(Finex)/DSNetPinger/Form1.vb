﻿Imports System.Threading
Imports System.IO
Imports System.IO.File
Imports System.Reflection

Public Class Form1
    Public ipdBuf(100) As String
    Public RowValue() As String
    Public Litem As New ListViewItem ''listview
    Public ListD(6) As String        ''listview

    ''//controll
    Public ucMc1 As New UserControl1
    Public ucMC2 As New UserControl1
    Public ucMC3 As New UserControl1
    Public ucMC4 As New UserControl1
    Public ucMC5 As New UserControl1
    Public ucMC6 As New UserControl1
    Public ucMC7 As New UserControl1
    Public ucMC8 As New UserControl1
    Public ucMC9 As New UserControl1
    Public ucMC10 As New UserControl1
    Public ucMC11 As New UserControl1
    Public ucMC12 As New UserControl1
    Public ucMC13 As New UserControl1

    Public pTime As Integer  ''//timeout
    Public upTime As Long

    ''//upTime
    Public upSec As Integer = 0
    Public upMin As Integer = 0
    Public upHou As Integer = 0
    Public upDay As Long = 0

    Public fmMonSize As Integer = Screen.PrimaryScreen.Bounds.Width

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ''//Window Full Size
        Me.WindowState = FormWindowState.Maximized

        If Process.GetProcessesByName(Application.ProductName).Length > 1 Then
            ''//run duplicate ben
            MsgBox("The Program is running")

            End
        End If

        ''//MsgBox(Convert.ToInt32("1234567890"))

        'upTimer.Enabled = True

        ''//Control Setup
        ControlPosition()

        ''//UserControl 
        ucMcSetup()

        ''//IP Load ==> ListView
        LoadIPList()

    End Sub

    Public Sub LoadIPList()
        ''//
        ''//File iplist.ini Read~~
        Dim fPath As String
        Dim strLine As String
        Dim Cpo As Integer

        Dim fileReader As System.IO.StreamReader
        Dim i As Integer

        Dim LastColumnSize As Integer

        i = 0

        fPath = System.Reflection.Assembly.GetExecutingAssembly.Location
        Cpo = InStrRev(fPath, "\")
        fPath = fPath.Substring(0, Cpo)

        fileReader = New System.IO.StreamReader(fPath & "\iplist.ini") ''My.Computer.FileSystem.OpenTextFileReader()

        strLine = fileReader.ReadLine

        lvMainIPList1.CheckBoxes = True

        Do While Not strLine Is Nothing

            RowValue = strLine.Split(",")

            If RowValue(0).ToString <> "" Then

                If RowValue(0).ToString = "TIMEOUT" Then
                    pTime = RowValue(1) ''//timeout

                    strLine = fileReader.ReadLine
                Else


                    ListD(0) = ""
                    ListD(1) = RowValue(0)
                    ListD(2) = RowValue(1)
                    ListD(3) = RowValue(2)
                    ListD(4) = "No Message!!"
                    ListD(5) = " "

                    ipdBuf(i) = RowValue(2)

                    ''//UserControl 
                    If ucMc1.Tag = RowValue(0).ToString Then ucMc1.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC2.Tag = RowValue(0).ToString Then ucMC2.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC3.Tag = RowValue(0).ToString Then ucMC3.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC4.Tag = RowValue(0).ToString Then ucMC4.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC5.Tag = RowValue(0).ToString Then ucMC5.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC6.Tag = RowValue(0).ToString Then ucMC6.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC7.Tag = RowValue(0).ToString Then ucMC7.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC8.Tag = RowValue(0).ToString Then ucMC8.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC9.Tag = RowValue(0).ToString Then ucMC9.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC10.Tag = RowValue(0).ToString Then ucMC10.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC11.Tag = RowValue(0).ToString Then ucMC11.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC12.Tag = RowValue(0).ToString Then ucMC12.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)
                    If ucMC13.Tag = RowValue(0).ToString Then ucMC13.carIPReceive(RowValue(0), RowValue(1), RowValue(2), i)

                    lvMainIPList1.CheckBoxes = True

                    Litem = New ListViewItem(ListD)
                    Litem.Checked = True

                    lvMainIPList1.Items.Add(Litem)

                    strLine = fileReader.ReadLine

                    i = i + 1
                End If
            Else
                strLine = fileReader.ReadLine
            End If
        Loop

        fileReader.Close()

        ''//Last Column Size
        LastColumnSize = lvMainIPList1.Width - (lvMainIPList1.Columns(0).Width + lvMainIPList1.Columns(1).Width + _
                                                lvMainIPList1.Columns(2).Width + lvMainIPList1.Columns(3).Width + lvMainIPList1.Columns(4).Width)
        lvMainIPList1.Columns(5).Width = LastColumnSize

        ''Thread.Sleep(2000)

        ucMc1.carStart(True, pTime)
        ucMC2.carStart(True, pTime)
        ucMC3.carStart(True, pTime)
        ucMC4.carStart(True, pTime)
        ucMC5.carStart(True, pTime)
        ucMC6.carStart(True, pTime)
        ucMC7.carStart(True, pTime)
        ucMC8.carStart(True, pTime)
        ucMC9.carStart(True, pTime)
        ucMC10.carStart(True, pTime)
        ucMC11.carStart(True, pTime)
        ucMC12.carStart(True, pTime)
        ucMC13.carStart(True, pTime)


    End Sub

    Private Sub upTimer_Tick(sender As System.Object, e As System.EventArgs) Handles upTimer.Tick

        upSec = upSec + 1

        If upSec = 60 Then
            upMin = upMin + 1
            upSec = 0
        End If

        If upMin = 60 Then
            upHou = upHou + 1
            upMin = 0
        End If

        If upHou = 24 Then
            upDay = upDay + 1
            upHou = 0
        End If

        lblUpTime.Text = "[ UP TIME - " & upDay.ToString & " Day " & upHou.ToString & ":" & upMin.ToString & ":" & upSec.ToString & " ]"

        'lblUpTime.Text = "UP TIME : " & DateTime.FromFileTime(upTime, "yyyyMMdd-HH:mm:ss")

    End Sub

    Private Sub cmdFolder_Click(sender As System.Object, e As System.EventArgs) Handles cmdFolder.Click
        ''//
        Dim fsPath As String
        ''//Dim fPname As String

        ''//fPname = Assembly.GetExecutingAssembly.GetName.CodeBase
        ''//fsPath = Path.GetDirectoryName(fPname.Replace("file:///", ""))

        fsPath = "C:\WMS_Log"

        Shell("explorer.exe " & fsPath, AppWinStyle.NormalFocus)
    End Sub

    Private Sub cmdIPListOpen_Click(sender As System.Object, e As System.EventArgs) Handles cmdIPListOpen.Click
        Dim fsPath As String
        Dim fPname As String

        ''//messagebox 확인 여부
        If MessageBox.Show("IP List 파일를 여시겠습니까? " & vbCrLf & vbCrLf & "** 파일을 여시면 현재 실행 중인 프로그램을 종료합니다. **" _
                            & vbCrLf & vbCrLf & "** 장비명 또는 IP 수정시 해당 담당자와 협의 후 수정 바랍니다. **", "<< iplist.ini File Open >>", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ''//MessageBox.Show("YES")

            fPname = Assembly.GetExecutingAssembly.GetName.CodeBase
            fsPath = Path.GetDirectoryName(fPname.Replace("file:///", ""))

            fsPath = fsPath & "\iplist.ini"

            Shell("Notepad.exe " & fsPath, AppWinStyle.NormalFocus)
            ''//Shell("Notepad.exe" + Application.StartupPath + "\iplist.ini", AppWinStyle.NormalFocus)

            ''//종료
            Application.Exit()


            ''//Else ' Yes가 아닌 경우 No로 간주
            ''//MessageBox.Show("No")
        End If


    End Sub

    Public Sub ControlPosition()

        ''//Main top group 
        picMainTop.Top = 0
        picMainTop.Left = 2

        If fmMonSize < 1400 Then
            picMainTop.Width = Me.Width - 25
        Else
            picMainTop.Width = Me.Width - 20
        End If
        ''picMainTop.Width = Me.Width - 40
        picMainTop.Height = imgPosco.Height + 10

        imgPosco.Top = 5
        imgPosco.Left = picMainTop.Left + 5

        lblUpTime.Left = imgPosco.Left + imgPosco.Width + 10
        lblUpTime.Top = (imgPosco.Top + imgPosco.Height) - lblUpTime.Height
        lblUpTime.BackColor = Color.Transparent
        lblUpTime.Parent = picMainTop
        lblUpTime.Text = ""
        ''//Command Position
        'cmdStart.Height = imgPosco.Height
        'cmdStart.Top = imgPosco.Top
        'cmdStart.Left = picMainTop.Width - (cmdMCR.Width * 1.5)

        'cmdStop.Height = imgPosco.Height
        'cmdStop.Top = imgPosco.Top
        'cmdStop.Left = cmdStart.Left + cmdStart.Width + 10

        cmdFolder.Top = imgPosco.Top
        cmdFolder.Height = imgPosco.Height
        cmdFolder.Left = picMainTop.Width - (cmdFolder.Width * 1.2)

        cmdIPListOpen.Top = cmdFolder.Top
        cmdIPListOpen.Height = cmdFolder.Height
        cmdIPListOpen.Left = cmdFolder.Left - cmdIPListOpen.Width - 2


        ''//Main Top Title Label!!
        lblMainTitle.Text = "FINEX WIRELESS NETWORK MONITERING SYSTEM"
        lblMainTitle.Top = (picMainTop.Top + (picMainTop.Height / 2)) - (lblMainTitle.Height / 1.3)
        lblMainTitle.Left = picMainTop.Left + (picMainTop.Width / 2) - (lblMainTitle.Width / 2)
        lblMainTitle.BackColor = Color.Transparent
        lblMainTitle.Parent = picMainTop

        ''//group setup
        grMainLeft1.Top = picMainTop.Top + picMainTop.Height
        grMainLeft1.Left = picMainTop.Left
        grMainLeft1.Width = picMainTop.Width / 3

        ''//???????????? Moniter Size???
        If fmMonSize < 1400 Then ''monsize
            grMainLeft1.Height = (Me.Height - picMainTop.Height) * 0.94
        Else
            grMainLeft1.Height = (Me.Height - picMainTop.Height) * 0.957
        End If



        grMainRight1.Top = grMainLeft1.Top
        grMainRight1.Left = grMainLeft1.Left + grMainLeft1.Width + 5
        grMainRight1.Width = (picMainTop.Width - grMainLeft1.Width) * 0.995 ''(picMainTop.Width / 2.5) * 1.99
        grMainRight1.Height = grMainLeft1.Height

        '//grleft1 =====
        lblLeftTitle1.Text = "[ Network IP List ]"
        lblLeftTitle1.Top = 10
        lblLeftTitle1.Left = (grMainLeft1.Width / 2) - (lblLeftTitle1.Width / 2)

        lvMainIPList1.Top = lblLeftTitle1.Top + lblLeftTitle1.Height + 5
        lvMainIPList1.Left = 5
        lvMainIPList1.Width = grMainLeft1.Width - 10 ''* 0.495
        lvMainIPList1.Height = (grMainLeft1.Height / 3) * 2.35

        picBackGround.Top = lvMainIPList1.Top + lvMainIPList1.Height + 5
        picBackGround.Left = lvMainIPList1.Left
        picBackGround.Width = lvMainIPList1.Width
        picBackGround.Height = grMainLeft1.Height - (lvMainIPList1.Top + lvMainIPList1.Height + 10)

        cmdStart.Visible = False
        cmdStop.Visible = False

    End Sub

    Public Sub ucMcSetup()
        ''//
        Dim mcTopVal As Integer
        'Me.Controls.Add(ucMc1)
        'Me.Controls.Add(ucMC2)
        grMainRight1.Controls.Add(ucMc1)
        grMainRight1.Controls.Add(ucMC2)
        grMainRight1.Controls.Add(ucMC3)
        grMainRight1.Controls.Add(ucMC4)
        grMainRight1.Controls.Add(ucMC5)
        grMainRight1.Controls.Add(ucMC6)
        grMainRight1.Controls.Add(ucMC7)
        grMainRight1.Controls.Add(ucMC8)
        grMainRight1.Controls.Add(ucMC9)
        grMainRight1.Controls.Add(ucMC10)
        grMainRight1.Controls.Add(ucMC11)
        grMainRight1.Controls.Add(ucMC12)
        grMainRight1.Controls.Add(ucMC13)


        mcTopVal = ((grMainRight1.Height - (ucMc1.Height * 7)) / 5) - 9

        ''2공장 =====================================================================================================
        ''//position edit 2018-06-05
        ''ucMc1.Width = 580 ''grMainRight1.Width / 1.3
        ''//FORWARD 
        ucMc1.Height = grMainRight1.Height / 10.3 ''9.64
        ucMc1.Top = 35  ''12    ''Location = New Point(500, 15)
        ''//ucMc1.Left = (grMainRight1.Width - ucMc1.Width) * 0.977
        ucMc1.Left = 10 ''//(grMainRight1.Width - ucMc1.Width) * 0.544  ''0.888
        ucMc1.carPosition(1) ''위치
        ucMc1.carInput("FORWARD", 1) ''//, "M115", "G115") '//machine, server, ap FORWARD
        ucMc1.Tag = "ST801"
        ucMc1.Refresh()

        ucMC2.Width = ucMc1.Width ''grMainRight1.Width
        ucMC2.Height = ucMc1.Height ''grMainRight1.Height
        ucMC2.Left = ucMc1.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC2.Top = ucMc1.Top + ucMc1.Height + mcTopVal   ''//5     ''Location = New Point(500, 15)
        ucMC2.carPosition(2)
        ucMC2.carInput("FORWARD", 1) ''//, "M104", "G104") '//machine, server, ap
        ucMC2.Tag = "ST802"
        ucMC2.Refresh()

        ucMC3.Width = ucMc1.Width ''grMainRight1.Width
        ucMC3.Height = ucMc1.Height ''grMainRight1.Height
        ucMC3.Left = ucMc1.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC3.Top = ucMC2.Top + ucMC2.Height + mcTopVal     ''Location = New Point(500, 15)
        ucMC3.carPosition(1)
        ucMC3.carInput("FORWARD", 1) ''//, "M114", "G114") '//machine, server, ap
        ucMC3.Tag = "RE811"
        ucMC3.Refresh()

        ucMC4.Width = ucMc1.Width ''grMainRight1.Width
        ucMC4.Height = ucMc1.Height ''grMainRight1.Height
        ucMC4.Left = ucMc1.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC4.Top = ucMC3.Top + ucMC3.Height + mcTopVal     ''Location = New Point(500, 15)
        ucMC4.carPosition(2)
        ucMC4.carInput("FORWARD", 1) ''//, "M103", "G103") '//machine, server, ap
        ucMC4.Tag = "RE812"
        ucMC4.Refresh()

        ucMC5.Width = ucMc1.Width ''grMainRight1.Width
        ucMC5.Height = ucMc1.Height ''grMainRight1.Height
        ucMC5.Left = ucMc1.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC5.Top = ucMC4.Top + ucMC4.Height + mcTopVal     ''Location = New Point(500, 15)
        ucMC5.carPosition(1)
        ucMC5.carInput("FORWARD", 1) ''//, "M113", "G113") '//machine, server, ap
        ucMC5.Tag = "SR813"
        ucMC5.Refresh()

        ucMC6.Width = ucMc1.Width ''grMainRight1.Width
        ucMC6.Height = ucMc1.Height ''grMainRight1.Height
        ucMC6.Left = ucMc1.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC6.Top = ucMC5.Top + ucMC5.Height + mcTopVal     ''Location = New Point(500, 15)
        ucMC6.carPosition(2)
        ucMC6.carInput("FORWARD", 1) ''//, "M112", "G112") '//machine, server, ap
        ucMC6.Tag = "SR814"
        ucMC6.Refresh()

        ucMC7.Width = ucMc1.Width ''grMainRight1.Width
        ucMC7.Height = ucMc1.Height ''grMainRight1.Height
        ucMC7.Left = ucMc1.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC7.Top = ucMC6.Top + ucMC6.Height + mcTopVal     ''Location = New Point(500, 15)
        ucMC7.carPosition(2)
        ucMC7.carInput("FORWARD", 1) ''//, "M112", "G112") '//machine, server, ap
        ucMC7.Tag = "SR815"
        ucMC7.Refresh()


        ''1공장=========================================================================================================================
        ''//REVERSE

        ucMC8.Width = ucMc1.Width ''grMainRight1.Width
        ucMC8.Height = ucMc1.Height ''grMainRight1.Height
        ucMC8.Left = grMainRight1.Width - ucMC8.Width - 10 ''//ucMc1.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC8.Top = 35 ''//ucMC6.Top + ucMC6.Height + 5     ''Location = New Point(500, 15)
        ucMC8.carPosition(1)
        ucMC8.carInput("REVERSE", 1) ''//, "M111", "G111") '//machine, server, ap
        ucMC8.Tag = "ST701"
        ucMC8.Refresh()

        ucMC9.Width = ucMc1.Width ''grMainRight1.Width
        ucMC9.Height = ucMc1.Height ''grMainRight1.Height
        ucMC9.Left = ucMC8.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC9.Top = ucMC8.Top + ucMC8.Height + mcTopVal     ''Location = New Point(500, 15)
        ucMC9.carPosition(2)
        ucMC9.carInput("REVERSE", 1) ''//, "M102", "G102") '//machine, server, ap
        ucMC9.Tag = "ST702"
        ucMC9.Refresh()

        ucMC10.Width = ucMc1.Width ''grMainRight1.Width
        ucMC10.Height = ucMc1.Height ''grMainRight1.Height
        ucMC10.Left = ucMC8.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC10.Top = ucMC9.Top + ucMC9.Height + mcTopVal     ''Location = New Point(500, 15)
        ucMC10.carPosition(1)
        ucMC10.carInput("REVERSE", 1) ''//, "M101", "G101") '//machine, server, ap
        ucMC10.Tag = "RE711"
        ucMC10.Refresh()

        ucMC11.Width = ucMc1.Width ''grMainRight1.Width
        ucMC11.Height = ucMc1.Height ''grMainRight1.Height
        ucMC11.Left = ucMC8.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC11.Top = ucMC10.Top + ucMC10.Height + mcTopVal     ''Location = New Point(500, 15)
        ucMC11.carPosition(2)
        ucMC11.carInput("REVERSE", 1) ''//, "M101", "G101") '//machine, server, ap
        ucMC11.Tag = "RE712"
        ucMC11.Refresh()

        ucMC12.Width = ucMc1.Width ''grMainRight1.Width
        ucMC12.Height = ucMc1.Height ''grMainRight1.Height
        ucMC12.Left = ucMC8.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC12.Top = ucMC11.Top + ucMC11.Height + mcTopVal     ''Location = New Point(500, 15)
        ucMC12.carPosition(2)
        ucMC12.carInput("REVERSE", 1) ''//, "M101", "G101") '//machine, server, ap
        ucMC12.Tag = "RE713"
        ucMC12.Refresh()

        ucMC13.Width = 20 ''//ucMc1.Width ''grMainRight1.Width
        ucMC13.Height = 20 ''// ucMc1.Height ''grMainRight1.Height
        ucMC13.Left = cmdMCR.Left ''(grMainRight1.Width - ucMachine2.Width) * 0.977
        ucMC13.Top = cmdMCR.Top ''+ ucMC12.Height + mcTopVal     ''Location = New Point(500, 15)
        ucMC13.carPosition(1)
        ucMC13.carInput("REVERSE", 1) ''//, "M101", "G101") '//machine, server, ap
        ucMC13.Tag = "HUB"
        ucMC13.Refresh()

        ''//CMD MCR 2015-12-29 ===========================================================
        'cmdMCR.Top = nLine3.Top - (cmdMCR.Height / 2) ''grMainRight1.Height / 5
        'If fmMonSize < 1400 Then
        '    cmdMCR.Left = 20
        'Else
        '    cmdMCR.Left = 60
        'End If
        cmdMCR.Left = (grMainRight1.Width / 2) - (cmdMCR.Width / 2)
        cmdMCR.Top = ucMC2.Top + ucMC2.Height  ''+ (ucMC3.Height / 2)

        cmdNO1.Left = cmdMCR.Left ''//grMainRight1.Width - cmdNO1.Width - 5
        cmdNO1.Top = ucMC4.Top ''//(ucMC8.Top + (ucMC8.Height / 2)) - (cmdNO1.Height / 1.5)
        cmdNO2.Left = cmdNO1.Left
        cmdNO2.Top = cmdNO1.Top + cmdNO1.Height - 5

        cmdNO7.Top = ucMC6.Top + ucMC6.Height
        cmdNO7.Left = ucMC12.Left  ''cmdNO1.Left + cmdNO1.Width + 30

        ''//Line Left 2016-08-10 ===============================================================================
        ''//ST801 Line
        nLine1.Width = (cmdMCR.Left - (ucMc1.Left + ucMc1.Width)) / 2
        nLine1.Top = ucMc1.Top + (ucMc1.Height / 2)  ''//cmdMCR.Top + (cmdMCR.Height / 1.5)
        nLine1.Left = ucMc1.Left + ucMc1.Width ''ucMc1.Left - nLine1.Width
        nLine1.BackColor = Color.RoyalBlue  ''Color.DarkGreen
        nLine1.Height = 4

        ''//ST802 Line
        Dim nLine2 As New Panel
        grMainRight1.Controls.Add(nLine2)
        nLine2.Top = ucMC2.Top + (ucMC2.Height / 2)
        nLine2.Left = nLine1.Left
        nLine2.Height = nLine1.Height
        nLine2.Width = nLine1.Width
        nLine2.BackColor = nLine1.BackColor
        nLine2.Visible = True

        ''//RE811 left Line
        Dim nLine3 As New Panel
        grMainRight1.Controls.Add(nLine3)
        nLine3.Top = ucMC3.Top + (ucMC3.Height / 2)
        nLine3.Height = nLine1.Height ''// (ucMC9.Top + ucMC9.Height + 10) - nLine3.Top   ''nLine1.Height
        nLine3.Width = nLine1.Width
        nLine3.Left = nLine1.Left ''//(nLine1.Left + nLine1.Width) - nLine3.Width
        nLine3.BackColor = nLine1.BackColor
        nLine3.Visible = True

        ''//RE812 Line
        Dim nLine4 As New Panel
        grMainRight1.Controls.Add(nLine4)
        nLine4.Top = ucMC4.Top + (ucMC4.Height / 2)
        nLine4.Height = nLine1.Height ''// (ucMC9.Top + ucMC9.Height + 10) - nLine3.Top   ''nLine1.Height
        nLine4.Width = nLine1.Width
        nLine4.Left = nLine1.Left ''//(nLine1.Left + nLine1.Width) - nLine3.Width
        nLine4.BackColor = nLine1.BackColor
        nLine4.Visible = True

        ''//SR813 Line
        Dim nLine5 As New Panel
        grMainRight1.Controls.Add(nLine5)
        nLine5.Top = ucMC5.Top + (ucMC5.Height / 2)
        nLine5.Height = nLine1.Height ''// (ucMC9.Top + ucMC9.Height + 10) - nLine3.Top   ''nLine1.Height
        nLine5.Width = nLine1.Width
        nLine5.Left = nLine1.Left ''//(nLine1.Left + nLine1.Width) - nLine3.Width
        nLine5.BackColor = nLine1.BackColor
        nLine5.Visible = True

        ''//SR814 Line
        Dim nLine6 As New Panel
        grMainRight1.Controls.Add(nLine6)
        nLine6.Top = ucMC6.Top + (ucMC6.Height / 2)
        nLine6.Height = nLine1.Height ''// (ucMC9.Top + ucMC9.Height + 10) - nLine3.Top   ''nLine1.Height
        nLine6.Width = nLine1.Width
        nLine6.Left = nLine1.Left ''//(nLine1.Left + nLine1.Width) - nLine3.Width
        nLine6.BackColor = nLine1.BackColor
        nLine6.Visible = True

        ''//SR815 Line
        Dim nLine7 As New Panel
        grMainRight1.Controls.Add(nLine7)
        nLine7.Top = ucMC7.Top + (ucMC7.Height / 2)
        nLine7.Height = nLine1.Height ''// (ucMC9.Top + ucMC9.Height + 10) - nLine3.Top   ''nLine1.Height
        nLine7.Width = nLine1.Width
        nLine7.Left = nLine1.Left ''//(nLine1.Left + nLine1.Width) - nLine3.Width
        nLine7.BackColor = nLine1.BackColor
        nLine7.Visible = True


        ''//height left Line
        Dim nLine8 As New Panel
        grMainRight1.Controls.Add(nLine8)
        nLine8.Top = nLine1.Top ''nLine16.Top
        nLine8.Height = (nLine7.Top - nLine1.Top) + 4  ''//(nLine14.Top - nLine19.Top) - (cmdNO1.Height / 3) ''- nLine1.Height - 37
        nLine8.Width = nLine1.Height
        nLine8.Left = nLine1.Left + nLine1.Width ''//) - nLine19.Width
        nLine8.BackColor = nLine1.BackColor
        nLine8.Visible = True

        ''//MCR Line1
        Dim nLine9 As New Panel
        grMainRight1.Controls.Add(nLine9)
        nLine9.Top = cmdNO1.Top + (cmdNO1.Height / 2) ''nLine8.Top + (nLine8.Height / 2)
        nLine9.Height = nLine1.Height ''// (ucMC9.Top + ucMC9.Height + 10) - nLine3.Top   ''nLine1.Height
        nLine9.Width = nLine1.Width + (cmdMCR.Width / 4)
        nLine9.Left = nLine8.Left  ''//(nLine1.Left + nLine1.Width) - nLine3.Width
        nLine9.BackColor = nLine1.BackColor
        nLine9.Visible = True

        ''//MCR Line2 Height
        Dim nLine10 As New Panel
        grMainRight1.Controls.Add(nLine10)
        nLine10.Top = cmdMCR.Top + cmdMCR.Height
        nLine10.Height = (nLine9.Top + nLine9.Height) - (cmdMCR.Top + cmdMCR.Height) ''//nLine1.Height ''// (ucMC9.Top + ucMC9.Height + 10) - nLine3.Top   ''nLine1.Height
        nLine10.Width = nLine8.Width ''//+ (cmdMCR.Width / 4)
        nLine10.Left = cmdMCR.Left + (cmdMCR.Width / 2)
        nLine10.BackColor = Color.Brown
        nLine10.Visible = True
        ''//Line Left end   ==================================================================================

        ''//Line right      ==================================================================================
        '//ST701 Line 
        Dim nLine11 As New Panel
        grMainRight1.Controls.Add(nLine11)
        nLine11.Top = ucMC8.Top + (ucMC8.Height / 2)
        nLine11.Left = ucMC8.Left - ((ucMC8.Left - (cmdMCR.Left + cmdMCR.Width)) / 2)      ''//nLine4.Left + nLine4.Width
        nLine11.Height = nLine1.Height     ''- nLine1.Top
        nLine11.Width = (ucMC8.Left - (cmdMCR.Left + cmdMCR.Width)) / 2
        nLine11.BackColor = Color.Black
        nLine11.Visible = True

        ''//ST702 Line 
        Dim nLine12 As New Panel
        grMainRight1.Controls.Add(nLine12)
        nLine12.Top = ucMC9.Top + (ucMC9.Height / 2)
        nLine12.Left = nLine11.Left
        nLine12.Height = nLine1.Height    ''- nLine1.Top
        nLine12.Width = nLine11.Width
        nLine12.BackColor = nLine11.BackColor
        nLine12.Visible = True

        ''//RE711 Line
        Dim nLine13 As New Panel
        grMainRight1.Controls.Add(nLine13)
        nLine13.Top = ucMC10.Top + (ucMC10.Height / 2)
        nLine13.Left = nLine12.Left
        nLine13.Height = nLine1.Height    ''- nLine1.Top
        nLine13.Width = nLine12.Width
        nLine13.BackColor = nLine11.BackColor
        nLine13.Visible = True

        ' ''//RE712 Line
        Dim nLine14 As New Panel
        grMainRight1.Controls.Add(nLine14)
        nLine14.Top = ucMC11.Top + (ucMC11.Height / 2)
        nLine14.Left = nLine13.Left
        nLine14.Height = nLine1.Height    ''- nLine1.Top
        nLine14.Width = nLine13.Width
        nLine14.BackColor = nLine11.BackColor
        nLine14.Visible = True

        ' ''//RE713 Line
        Dim nLine15 As New Panel
        grMainRight1.Controls.Add(nLine15)
        nLine15.Top = ucMC12.Top + (ucMC12.Height / 2)
        nLine15.Left = nLine14.Left
        nLine15.Height = nLine1.Height    ''- nLine1.Top
        nLine15.Width = nLine14.Width
        nLine15.BackColor = nLine11.BackColor
        nLine15.Visible = True


        ''//NO1 ~ NO7 Line
        'Dim nLine16 As New Panel
        'grMainRight1.Controls.Add(nLine16)
        'nLine16.Top = cmdNO1.Top + cmdNO1.Height
        'nLine16.Left = nLine15.Left
        'nLine16.Height = nLine1.Height
        'nLine16.Width = nLine15.Width + (cmdNO7.Left - cmdNO1.Left)
        'nLine16.BackColor = nLine11.BackColor
        'nLine16.Visible = True

        ''//No2  ==> No7 Line2 Height
        Dim nLine17 As New Panel
        grMainRight1.Controls.Add(nLine17)
        nLine17.Top = cmdNO2.Top + cmdNO2.Height ''cmdMCR.Top + cmdMCR.Height
        nLine17.Height = (cmdNO7.Top + (cmdNO7.Height / 2)) - (cmdNO2.Top + cmdNO2.Height)
        nLine17.Width = nLine8.Width ''//+ (cmdMCR.Width / 4)
        nLine17.Left = cmdNO2.Left + (cmdNO2.Width / 2)
        nLine17.BackColor = Color.Brown
        nLine17.Visible = True

        ''//ucMC8 ===> ucMC13 height right Line
        Dim nLine18 As New Panel
        grMainRight1.Controls.Add(nLine18)
        nLine18.Top = nLine11.Top ''nLine16.Top
        nLine18.Height = (nLine15.Top - nLine11.Top) + 4  ''//(nLine14.Top - nLine19.Top) - (cmdNO1.Height / 3) ''- nLine1.Height - 37
        nLine18.Width = nLine1.Height
        nLine18.Left = nLine11.Left ''//+ nLine10.Width ''//) - nLine19.Width
        nLine18.BackColor = nLine11.BackColor
        nLine18.Visible = True

        ''//MCR right Line1 (1공장)
        Dim nLine19 As New Panel
        grMainRight1.Controls.Add(nLine19)
        nLine19.Top = cmdMCR.Top + (cmdMCR.Height / 2) ''nLine17.Top + nLine17.Height
        nLine19.Height = nLine1.Height ''// (ucMC10.Top + ucMC10.Height + 10) - nLine3.Top   ''nLine1.Height
        nLine19.Width = nLine14.Left - nLine17.Left ''//nLine1.Width + (cmdMCR.Width / 4)
        nLine19.Left = nLine17.Left  ''//(nLine1.Left + nLine1.Width) - nLine3.Width
        nLine19.BackColor = nLine11.BackColor
        nLine19.Visible = True

        ''//no2 ===> no7(EWS) Line
        Dim nLine20 As New Panel
        grMainRight1.Controls.Add(nLine20)
        nLine20.Top = nLine17.Top + nLine17.Height
        nLine20.Height = nLine1.Height ''// (ucMC10.Top + ucMC10.Height + 10) - nLine3.Top   ''nLine1.Height
        nLine20.Width = cmdNO7.Left - nLine17.Left ''//nLine1.Width + (cmdMCR.Width / 4)
        nLine20.Left = nLine17.Left  ''//(nLine1.Left + nLine1.Width) - nLine3.Width
        nLine20.BackColor = nLine17.BackColor
        nLine20.Visible = True
        ''//Line right end   ==================================================================================


        ' ''//label text design 2015-12-29 ============================================================
        lblEtctxt1.Top = nLine8.Top + nLine8.Height
        lblEtctxt1.Left = nLine8.Left + 10

        lblEtctxt2.Top = nLine15.Top + nLine15.Height
        lblEtctxt2.Left = (nLine15.Left + (nLine15.Width / 2)) - (lblEtctxt2.Width)




    End Sub


End Class
