<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pet))
        Me.btnVote = New System.Windows.Forms.Button()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.picCat = New System.Windows.Forms.PictureBox()
        Me.picFish = New System.Windows.Forms.PictureBox()
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVote
        '
        Me.btnVote.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVote.Location = New System.Drawing.Point(148, 487)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(175, 34)
        Me.btnVote.TabIndex = 0
        Me.btnVote.Text = "VOTE"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'lstOut
        '
        Me.lstOut.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 21
        Me.lstOut.Location = New System.Drawing.Point(12, 534)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(436, 67)
        Me.lstOut.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(125, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(219, 37)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "The Pet Contest"
        '
        'picDog
        '
        Me.picDog.Image = CType(resources.GetObject("picDog.Image"), System.Drawing.Image)
        Me.picDog.Location = New System.Drawing.Point(464, 12)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(357, 645)
        Me.picDog.TabIndex = 3
        Me.picDog.TabStop = False
        Me.picDog.Visible = False
        '
        'picCat
        '
        Me.picCat.Image = CType(resources.GetObject("picCat.Image"), System.Drawing.Image)
        Me.picCat.Location = New System.Drawing.Point(464, 137)
        Me.picCat.Name = "picCat"
        Me.picCat.Size = New System.Drawing.Size(357, 334)
        Me.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCat.TabIndex = 4
        Me.picCat.TabStop = False
        Me.picCat.Visible = False
        '
        'picFish
        '
        Me.picFish.Image = CType(resources.GetObject("picFish.Image"), System.Drawing.Image)
        Me.picFish.Location = New System.Drawing.Point(464, 179)
        Me.picFish.Name = "picFish"
        Me.picFish.Size = New System.Drawing.Size(357, 272)
        Me.picFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFish.TabIndex = 5
        Me.picFish.TabStop = False
        Me.picFish.Visible = False
        '
        'picBird
        '
        Me.picBird.Image = CType(resources.GetObject("picBird.Image"), System.Drawing.Image)
        Me.picBird.Location = New System.Drawing.Point(484, 159)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(321, 292)
        Me.picBird.TabIndex = 6
        Me.picBird.TabStop = False
        Me.picBird.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "WELCOME TO THE PET CONTEST!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 210)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "A : DOG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(286, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "B : CAT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 439)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 32)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "C : FISH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 439)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 32)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "D : BIRD"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(50, 617)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 40)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(291, 617)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 40)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Pet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(833, 659)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picCat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBird)
        Me.Controls.Add(Me.picFish)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.picDog)
        Me.Name = "Pet"
        Me.Text = "The Pet Project"
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVote As Button
    Friend WithEvents lstOut As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents picDog As PictureBox
    Friend WithEvents picCat As PictureBox
    Friend WithEvents picFish As PictureBox
    Friend WithEvents picBird As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
