<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.wnAP2 = New System.Windows.Forms.Label()
        Me.wnAP1 = New System.Windows.Forms.Label()
        Me.mcTitle = New System.Windows.Forms.Label()
        Me.tmrPing1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPing2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPing3 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.wnCar1 = New System.Windows.Forms.Button()
        Me.cnLine1 = New System.Windows.Forms.Panel()
        Me.wnPLC1 = New System.Windows.Forms.Button()
        Me.picCar1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wnAP2
        '
        Me.wnAP2.BackColor = System.Drawing.Color.DarkGray
        Me.wnAP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wnAP2.Font = New System.Drawing.Font("맑은 고딕", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.wnAP2.ForeColor = System.Drawing.Color.Black
        Me.wnAP2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.wnAP2.Location = New System.Drawing.Point(2, 52)
        Me.wnAP2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.wnAP2.Name = "wnAP2"
        Me.wnAP2.Size = New System.Drawing.Size(76, 23)
        Me.wnAP2.TabIndex = 9
        Me.wnAP2.Text = "WBP-G115 AP2"
        Me.wnAP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'wnAP1
        '
        Me.wnAP1.BackColor = System.Drawing.Color.DarkGray
        Me.wnAP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wnAP1.Font = New System.Drawing.Font("맑은 고딕", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.wnAP1.ForeColor = System.Drawing.Color.Black
        Me.wnAP1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.wnAP1.Location = New System.Drawing.Point(2, 18)
        Me.wnAP1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.wnAP1.Name = "wnAP1"
        Me.wnAP1.Size = New System.Drawing.Size(76, 23)
        Me.wnAP1.TabIndex = 8
        Me.wnAP1.Text = "WBP-G115 AP1"
        Me.wnAP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mcTitle
        '
        Me.mcTitle.AutoSize = True
        Me.mcTitle.BackColor = System.Drawing.Color.Transparent
        Me.mcTitle.Font = New System.Drawing.Font("맑은 고딕", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.mcTitle.ForeColor = System.Drawing.Color.Black
        Me.mcTitle.Location = New System.Drawing.Point(118, 5)
        Me.mcTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.mcTitle.Name = "mcTitle"
        Me.mcTitle.Size = New System.Drawing.Size(206, 20)
        Me.mcTitle.TabIndex = 10
        Me.mcTitle.Text = "WIRELESS MACHINE RE115"
        Me.mcTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrPing1
        '
        Me.tmrPing1.Interval = 2000
        '
        'tmrPing2
        '
        Me.tmrPing2.Interval = 2000
        '
        'tmrPing3
        '
        Me.tmrPing3.Interval = 2000
        '
        'BackgroundWorker1
        '
        '
        'wnCar1
        '
        Me.wnCar1.BackColor = System.Drawing.Color.DarkGray
        Me.wnCar1.Font = New System.Drawing.Font("맑은 고딕", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.wnCar1.Location = New System.Drawing.Point(204, 32)
        Me.wnCar1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.wnCar1.Name = "wnCar1"
        Me.wnCar1.Size = New System.Drawing.Size(81, 30)
        Me.wnCar1.TabIndex = 14
        Me.wnCar1.Text = "M115 SEVER"
        Me.wnCar1.UseVisualStyleBackColor = False
        '
        'cnLine1
        '
        Me.cnLine1.BackColor = System.Drawing.Color.Black
        Me.cnLine1.Location = New System.Drawing.Point(284, 44)
        Me.cnLine1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cnLine1.Name = "cnLine1"
        Me.cnLine1.Size = New System.Drawing.Size(23, 3)
        Me.cnLine1.TabIndex = 16
        '
        'wnPLC1
        '
        Me.wnPLC1.BackColor = System.Drawing.Color.DarkGray
        Me.wnPLC1.Font = New System.Drawing.Font("맑은 고딕", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.wnPLC1.Location = New System.Drawing.Point(304, 32)
        Me.wnPLC1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.wnPLC1.Name = "wnPLC1"
        Me.wnPLC1.Size = New System.Drawing.Size(65, 30)
        Me.wnPLC1.TabIndex = 15
        Me.wnPLC1.Text = "M115-PLC"
        Me.wnPLC1.UseVisualStyleBackColor = False
        '
        'picCar1
        '
        Me.picCar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picCar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCar1.Location = New System.Drawing.Point(194, 26)
        Me.picCar1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picCar1.Name = "picCar1"
        Me.picCar1.Size = New System.Drawing.Size(185, 42)
        Me.picCar1.TabIndex = 13
        Me.picCar1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.DSNetPinger.My.Resources.Resources.BR_Net_Image_c01
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cnLine1)
        Me.Controls.Add(Me.wnPLC1)
        Me.Controls.Add(Me.wnCar1)
        Me.Controls.Add(Me.picCar1)
        Me.Controls.Add(Me.mcTitle)
        Me.Controls.Add(Me.wnAP2)
        Me.Controls.Add(Me.wnAP1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(413, 100)
        CType(Me.picCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents wnAP2 As System.Windows.Forms.Label
    Friend WithEvents wnAP1 As System.Windows.Forms.Label
    Friend WithEvents mcTitle As System.Windows.Forms.Label
    Friend WithEvents tmrPing1 As System.Windows.Forms.Timer
    Friend WithEvents tmrPing2 As System.Windows.Forms.Timer
    Friend WithEvents tmrPing3 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents picCar1 As System.Windows.Forms.PictureBox
    Friend WithEvents wnCar1 As System.Windows.Forms.Button
    Friend WithEvents cnLine1 As System.Windows.Forms.Panel
    Friend WithEvents wnPLC1 As System.Windows.Forms.Button

End Class
