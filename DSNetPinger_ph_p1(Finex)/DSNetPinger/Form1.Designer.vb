<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.grMainLeft1 = New System.Windows.Forms.GroupBox()
        Me.picBackGround = New System.Windows.Forms.PictureBox()
        Me.lvMainIPList1 = New System.Windows.Forms.ListView()
        Me.Main_CHK = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Main_Machine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Main_Network = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Main_IP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Main_Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Main_Cnt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblLeftTitle1 = New System.Windows.Forms.Label()
        Me.grMainRight1 = New System.Windows.Forms.GroupBox()
        Me.cmdNO7 = New System.Windows.Forms.Button()
        Me.cmdNO2 = New System.Windows.Forms.Button()
        Me.lblEtctxt2 = New System.Windows.Forms.Label()
        Me.lblEtctxt1 = New System.Windows.Forms.Label()
        Me.cmdNO1 = New System.Windows.Forms.Button()
        Me.cmdMCR = New System.Windows.Forms.Button()
        Me.nLine1 = New System.Windows.Forms.Panel()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.imgPosco = New System.Windows.Forms.PictureBox()
        Me.picMainTop = New System.Windows.Forms.PictureBox()
        Me.upTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblUpTime = New System.Windows.Forms.Label()
        Me.cmdFolder = New System.Windows.Forms.Button()
        Me.cmdIPListOpen = New System.Windows.Forms.Button()
        Me.grMainLeft1.SuspendLayout()
        CType(Me.picBackGround, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grMainRight1.SuspendLayout()
        CType(Me.imgPosco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMainTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.Font = New System.Drawing.Font("맑은 고딕", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblMainTitle.Location = New System.Drawing.Point(241, 26)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(166, 45)
        Me.lblMainTitle.TabIndex = 4
        Me.lblMainTitle.Text = "Main Top"
        '
        'grMainLeft1
        '
        Me.grMainLeft1.Controls.Add(Me.picBackGround)
        Me.grMainLeft1.Controls.Add(Me.lvMainIPList1)
        Me.grMainLeft1.Controls.Add(Me.lblLeftTitle1)
        Me.grMainLeft1.Location = New System.Drawing.Point(1, 84)
        Me.grMainLeft1.Name = "grMainLeft1"
        Me.grMainLeft1.Size = New System.Drawing.Size(358, 445)
        Me.grMainLeft1.TabIndex = 5
        Me.grMainLeft1.TabStop = False
        '
        'picBackGround
        '
        Me.picBackGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picBackGround.Image = Global.DSNetPinger.My.Resources.Resources.etc_image01
        Me.picBackGround.Location = New System.Drawing.Point(10, 211)
        Me.picBackGround.Name = "picBackGround"
        Me.picBackGround.Size = New System.Drawing.Size(332, 181)
        Me.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackGround.TabIndex = 7
        Me.picBackGround.TabStop = False
        '
        'lvMainIPList1
        '
        Me.lvMainIPList1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Main_CHK, Me.Main_Machine, Me.Main_Network, Me.Main_IP, Me.Main_Data, Me.Main_Cnt})
        Me.lvMainIPList1.Font = New System.Drawing.Font("돋움체", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lvMainIPList1.ForeColor = System.Drawing.Color.Black
        Me.lvMainIPList1.GridLines = True
        Me.lvMainIPList1.Location = New System.Drawing.Point(10, 50)
        Me.lvMainIPList1.Name = "lvMainIPList1"
        Me.lvMainIPList1.Size = New System.Drawing.Size(333, 155)
        Me.lvMainIPList1.TabIndex = 6
        Me.lvMainIPList1.UseCompatibleStateImageBehavior = False
        Me.lvMainIPList1.View = System.Windows.Forms.View.Details
        '
        'Main_CHK
        '
        Me.Main_CHK.Text = "CHK"
        Me.Main_CHK.Width = 20
        '
        'Main_Machine
        '
        Me.Main_Machine.Text = "Machine"
        Me.Main_Machine.Width = 65
        '
        'Main_Network
        '
        Me.Main_Network.Text = "NetWork Name"
        Me.Main_Network.Width = 100
        '
        'Main_IP
        '
        Me.Main_IP.Text = "IP NO."
        Me.Main_IP.Width = 110
        '
        'Main_Data
        '
        Me.Main_Data.Text = "DATA"
        Me.Main_Data.Width = 180
        '
        'Main_Cnt
        '
        Me.Main_Cnt.Text = "Etc"
        Me.Main_Cnt.Width = 175
        '
        'lblLeftTitle1
        '
        Me.lblLeftTitle1.AutoSize = True
        Me.lblLeftTitle1.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLeftTitle1.Location = New System.Drawing.Point(89, 17)
        Me.lblLeftTitle1.Name = "lblLeftTitle1"
        Me.lblLeftTitle1.Size = New System.Drawing.Size(55, 30)
        Me.lblLeftTitle1.TabIndex = 5
        Me.lblLeftTitle1.Text = "LIST"
        '
        'grMainRight1
        '
        Me.grMainRight1.BackColor = System.Drawing.Color.Transparent
        Me.grMainRight1.Controls.Add(Me.cmdNO7)
        Me.grMainRight1.Controls.Add(Me.cmdNO2)
        Me.grMainRight1.Controls.Add(Me.lblEtctxt2)
        Me.grMainRight1.Controls.Add(Me.lblEtctxt1)
        Me.grMainRight1.Controls.Add(Me.cmdNO1)
        Me.grMainRight1.Controls.Add(Me.cmdMCR)
        Me.grMainRight1.Controls.Add(Me.nLine1)
        Me.grMainRight1.Location = New System.Drawing.Point(428, 84)
        Me.grMainRight1.Name = "grMainRight1"
        Me.grMainRight1.Size = New System.Drawing.Size(539, 445)
        Me.grMainRight1.TabIndex = 6
        Me.grMainRight1.TabStop = False
        '
        'cmdNO7
        '
        Me.cmdNO7.BackColor = System.Drawing.Color.DarkGray
        Me.cmdNO7.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cmdNO7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNO7.Location = New System.Drawing.Point(39, 257)
        Me.cmdNO7.Name = "cmdNO7"
        Me.cmdNO7.Size = New System.Drawing.Size(196, 51)
        Me.cmdNO7.TabIndex = 15
        Me.cmdNO7.Text = "EWS HUB"
        Me.cmdNO7.UseVisualStyleBackColor = False
        '
        'cmdNO2
        '
        Me.cmdNO2.BackColor = System.Drawing.Color.DarkGray
        Me.cmdNO2.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cmdNO2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNO2.Location = New System.Drawing.Point(39, 200)
        Me.cmdNO2.Name = "cmdNO2"
        Me.cmdNO2.Size = New System.Drawing.Size(196, 43)
        Me.cmdNO2.TabIndex = 14
        Me.cmdNO2.Text = "2공장 HUB2"
        Me.cmdNO2.UseVisualStyleBackColor = False
        '
        'lblEtctxt2
        '
        Me.lblEtctxt2.AutoSize = True
        Me.lblEtctxt2.Font = New System.Drawing.Font("맑은 고딕", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblEtctxt2.Location = New System.Drawing.Point(360, 297)
        Me.lblEtctxt2.Name = "lblEtctxt2"
        Me.lblEtctxt2.Size = New System.Drawing.Size(90, 11)
        Me.lblEtctxt2.TabIndex = 11
        Me.lblEtctxt2.Text = "Fiber Optic Cable Line "
        '
        'lblEtctxt1
        '
        Me.lblEtctxt1.AutoSize = True
        Me.lblEtctxt1.Font = New System.Drawing.Font("맑은 고딕", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblEtctxt1.Location = New System.Drawing.Point(360, 337)
        Me.lblEtctxt1.Name = "lblEtctxt1"
        Me.lblEtctxt1.Size = New System.Drawing.Size(90, 11)
        Me.lblEtctxt1.TabIndex = 10
        Me.lblEtctxt1.Text = "Fiber Optic Cable Line "
        '
        'cmdNO1
        '
        Me.cmdNO1.BackColor = System.Drawing.Color.DarkGray
        Me.cmdNO1.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cmdNO1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNO1.Location = New System.Drawing.Point(39, 143)
        Me.cmdNO1.Name = "cmdNO1"
        Me.cmdNO1.Size = New System.Drawing.Size(196, 43)
        Me.cmdNO1.TabIndex = 8
        Me.cmdNO1.Text = "2공장 HUB1"
        Me.cmdNO1.UseVisualStyleBackColor = False
        '
        'cmdMCR
        '
        Me.cmdMCR.BackColor = System.Drawing.Color.DarkGray
        Me.cmdMCR.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cmdMCR.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdMCR.Location = New System.Drawing.Point(39, 79)
        Me.cmdMCR.Name = "cmdMCR"
        Me.cmdMCR.Size = New System.Drawing.Size(196, 49)
        Me.cmdMCR.TabIndex = 7
        Me.cmdMCR.Text = "1공장 HUB"
        Me.cmdMCR.UseVisualStyleBackColor = False
        '
        'nLine1
        '
        Me.nLine1.BackColor = System.Drawing.Color.RoyalBlue
        Me.nLine1.Location = New System.Drawing.Point(233, 257)
        Me.nLine1.Name = "nLine1"
        Me.nLine1.Size = New System.Drawing.Size(59, 5)
        Me.nLine1.TabIndex = 6
        '
        'cmdStart
        '
        Me.cmdStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdStart.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cmdStart.Location = New System.Drawing.Point(803, 26)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 40)
        Me.cmdStart.TabIndex = 8
        Me.cmdStart.Text = "START"
        Me.cmdStart.UseVisualStyleBackColor = False
        '
        'cmdStop
        '
        Me.cmdStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdStop.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cmdStop.Location = New System.Drawing.Point(884, 26)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 40)
        Me.cmdStop.TabIndex = 9
        Me.cmdStop.Text = "STOP"
        Me.cmdStop.UseVisualStyleBackColor = False
        '
        'imgPosco
        '
        Me.imgPosco.Image = Global.DSNetPinger.My.Resources.Resources.posco_logo
        Me.imgPosco.Location = New System.Drawing.Point(12, 12)
        Me.imgPosco.Name = "imgPosco"
        Me.imgPosco.Size = New System.Drawing.Size(161, 54)
        Me.imgPosco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPosco.TabIndex = 3
        Me.imgPosco.TabStop = False
        '
        'picMainTop
        '
        Me.picMainTop.BackColor = System.Drawing.Color.Lavender
        Me.picMainTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMainTop.Location = New System.Drawing.Point(1, 3)
        Me.picMainTop.Name = "picMainTop"
        Me.picMainTop.Size = New System.Drawing.Size(966, 75)
        Me.picMainTop.TabIndex = 0
        Me.picMainTop.TabStop = False
        '
        'upTimer
        '
        Me.upTimer.Enabled = True
        Me.upTimer.Interval = 1000
        '
        'lblUpTime
        '
        Me.lblUpTime.AutoSize = True
        Me.lblUpTime.BackColor = System.Drawing.Color.Transparent
        Me.lblUpTime.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpTime.ForeColor = System.Drawing.Color.Blue
        Me.lblUpTime.Location = New System.Drawing.Point(178, 54)
        Me.lblUpTime.Name = "lblUpTime"
        Me.lblUpTime.Size = New System.Drawing.Size(89, 17)
        Me.lblUpTime.TabIndex = 10
        Me.lblUpTime.Text = "UP 00:00:00"
        '
        'cmdFolder
        '
        Me.cmdFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdFolder.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cmdFolder.Location = New System.Drawing.Point(692, 26)
        Me.cmdFolder.Name = "cmdFolder"
        Me.cmdFolder.Size = New System.Drawing.Size(131, 40)
        Me.cmdFolder.TabIndex = 11
        Me.cmdFolder.Text = "Open Log Folder"
        Me.cmdFolder.UseVisualStyleBackColor = False
        '
        'cmdIPListOpen
        '
        Me.cmdIPListOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdIPListOpen.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cmdIPListOpen.Location = New System.Drawing.Point(532, 26)
        Me.cmdIPListOpen.Name = "cmdIPListOpen"
        Me.cmdIPListOpen.Size = New System.Drawing.Size(131, 40)
        Me.cmdIPListOpen.TabIndex = 13
        Me.cmdIPListOpen.Text = "Open IP List File"
        Me.cmdIPListOpen.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1048, 558)
        Me.Controls.Add(Me.cmdIPListOpen)
        Me.Controls.Add(Me.cmdFolder)
        Me.Controls.Add(Me.lblUpTime)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.grMainRight1)
        Me.Controls.Add(Me.grMainLeft1)
        Me.Controls.Add(Me.lblMainTitle)
        Me.Controls.Add(Me.imgPosco)
        Me.Controls.Add(Me.picMainTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "FINEX WIRELESS NETWORK MONITERING SYSTEM v1.06"
        Me.grMainLeft1.ResumeLayout(False)
        Me.grMainLeft1.PerformLayout()
        CType(Me.picBackGround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grMainRight1.ResumeLayout(False)
        Me.grMainRight1.PerformLayout()
        CType(Me.imgPosco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMainTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMainTop As System.Windows.Forms.PictureBox
    Friend WithEvents imgPosco As System.Windows.Forms.PictureBox
    Friend WithEvents lblMainTitle As System.Windows.Forms.Label
    Friend WithEvents grMainLeft1 As System.Windows.Forms.GroupBox
    Friend WithEvents grMainRight1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLeftTitle1 As System.Windows.Forms.Label
    Friend WithEvents lvMainIPList1 As System.Windows.Forms.ListView
    Friend WithEvents Main_CHK As System.Windows.Forms.ColumnHeader
    Friend WithEvents Main_Machine As System.Windows.Forms.ColumnHeader
    Friend WithEvents Main_Network As System.Windows.Forms.ColumnHeader
    Friend WithEvents Main_IP As System.Windows.Forms.ColumnHeader
    Friend WithEvents Main_Data As System.Windows.Forms.ColumnHeader
    Friend WithEvents nLine1 As System.Windows.Forms.Panel
    Friend WithEvents cmdMCR As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents Main_Cnt As System.Windows.Forms.ColumnHeader
    Friend WithEvents picBackGround As System.Windows.Forms.PictureBox
    Friend WithEvents upTimer As System.Windows.Forms.Timer
    Friend WithEvents lblUpTime As System.Windows.Forms.Label
    Friend WithEvents cmdFolder As System.Windows.Forms.Button
    Friend WithEvents cmdNO1 As System.Windows.Forms.Button
    Friend WithEvents lblEtctxt1 As System.Windows.Forms.Label
    Friend WithEvents lblEtctxt2 As System.Windows.Forms.Label
    Friend WithEvents cmdNO7 As System.Windows.Forms.Button
    Friend WithEvents cmdNO2 As System.Windows.Forms.Button
    Friend WithEvents cmdIPListOpen As System.Windows.Forms.Button

End Class
