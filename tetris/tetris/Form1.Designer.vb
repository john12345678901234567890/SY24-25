<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Timer1 = New Timer(components)
        Avatar = New PictureBox()
        coin = New PictureBox()
        ENEMY = New PictureBox()
        enemy2 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(coin, ComponentModel.ISupportInitialize).BeginInit()
        CType(ENEMY, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(375, 142)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(130, 142)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' coin
        ' 
        coin.Image = CType(resources.GetObject("coin.Image"), Image)
        coin.Location = New Point(28, 184)
        coin.Name = "coin"
        coin.Size = New Size(125, 62)
        coin.SizeMode = PictureBoxSizeMode.StretchImage
        coin.TabIndex = 1
        coin.TabStop = False
        ' 
        ' ENEMY
        ' 
        ENEMY.Image = CType(resources.GetObject("ENEMY.Image"), Image)
        ENEMY.Location = New Point(660, 91)
        ENEMY.Name = "ENEMY"
        ENEMY.Size = New Size(121, 155)
        ENEMY.SizeMode = PictureBoxSizeMode.StretchImage
        ENEMY.TabIndex = 2
        ENEMY.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = CType(resources.GetObject("enemy2.Image"), Image)
        enemy2.Location = New Point(505, 197)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(121, 155)
        enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        enemy2.TabIndex = 3
        enemy2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1130, 548)
        Controls.Add(enemy2)
        Controls.Add(ENEMY)
        Controls.Add(coin)
        Controls.Add(Avatar)
        Name = "Form1"
        Text = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(coin, ComponentModel.ISupportInitialize).EndInit()
        CType(ENEMY, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Avatar As PictureBox
    Friend WithEvents coin As PictureBox
    Friend WithEvents ENEMY As PictureBox
    Friend WithEvents enemy2 As PictureBox

End Class
