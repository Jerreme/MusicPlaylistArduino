﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.title3 = New System.Windows.Forms.Label()
        Me.artist3 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.title2 = New System.Windows.Forms.Label()
        Me.artist2 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.title1 = New System.Windows.Forms.Label()
        Me.artist1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.comportLabel = New System.Windows.Forms.Label()
        Me.artist = New System.Windows.Forms.Label()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.comListener = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        Me.Label1.UseMnemonic = False
        Me.Label1.UseWaitCursor = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Controls.Add(Me.CheckBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        resources.ApplyResources(Me.Guna2Panel1, "Guna2Panel1")
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        '
        'Guna2Panel5
        '
        resources.ApplyResources(Me.Guna2Panel5, "Guna2Panel5")
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel5.Controls.Add(Me.title3)
        Me.Guna2Panel5.Controls.Add(Me.artist3)
        Me.Guna2Panel5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        '
        'title3
        '
        Me.title3.BackColor = System.Drawing.Color.Transparent
        Me.title3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.title3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.title3, "title3")
        Me.title3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.title3.Name = "title3"
        Me.title3.UseMnemonic = False
        Me.title3.UseWaitCursor = True
        '
        'artist3
        '
        Me.artist3.BackColor = System.Drawing.Color.Transparent
        Me.artist3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.artist3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.artist3, "artist3")
        Me.artist3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.artist3.Name = "artist3"
        Me.artist3.UseMnemonic = False
        Me.artist3.UseWaitCursor = True
        '
        'Guna2Panel4
        '
        resources.ApplyResources(Me.Guna2Panel4, "Guna2Panel4")
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.title2)
        Me.Guna2Panel4.Controls.Add(Me.artist2)
        Me.Guna2Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        '
        'title2
        '
        Me.title2.BackColor = System.Drawing.Color.Transparent
        Me.title2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.title2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.title2, "title2")
        Me.title2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.title2.Name = "title2"
        Me.title2.UseMnemonic = False
        Me.title2.UseWaitCursor = True
        '
        'artist2
        '
        Me.artist2.BackColor = System.Drawing.Color.Transparent
        Me.artist2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.artist2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.artist2, "artist2")
        Me.artist2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.artist2.Name = "artist2"
        Me.artist2.UseMnemonic = False
        Me.artist2.UseWaitCursor = True
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.title1)
        Me.Guna2Panel3.Controls.Add(Me.artist1)
        Me.Guna2Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.Guna2Panel3, "Guna2Panel3")
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        '
        'title1
        '
        Me.title1.BackColor = System.Drawing.Color.Transparent
        Me.title1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.title1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.title1, "title1")
        Me.title1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.title1.Name = "title1"
        Me.title1.UseMnemonic = False
        Me.title1.UseWaitCursor = True
        '
        'artist1
        '
        Me.artist1.BackColor = System.Drawing.Color.Transparent
        Me.artist1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.artist1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.artist1, "artist1")
        Me.artist1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.artist1.Name = "artist1"
        Me.artist1.UseMnemonic = False
        Me.artist1.UseWaitCursor = True
        '
        'Guna2Panel2
        '
        resources.ApplyResources(Me.Guna2Panel2, "Guna2Panel2")
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.comportLabel)
        Me.Guna2Panel2.Controls.Add(Me.artist)
        Me.Guna2Panel2.Controls.Add(Me.Guna2GradientButton2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2GradientButton3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        '
        'comportLabel
        '
        Me.comportLabel.BackColor = System.Drawing.Color.Transparent
        Me.comportLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.comportLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.comportLabel, "comportLabel")
        Me.comportLabel.ForeColor = System.Drawing.Color.Gray
        Me.comportLabel.Name = "comportLabel"
        Me.comportLabel.UseMnemonic = False
        Me.comportLabel.UseWaitCursor = True
        '
        'artist
        '
        Me.artist.BackColor = System.Drawing.Color.Transparent
        Me.artist.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.artist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.artist, "artist")
        Me.artist.ForeColor = System.Drawing.Color.Gray
        Me.artist.Name = "artist"
        Me.artist.UseMnemonic = False
        Me.artist.UseWaitCursor = True
        '
        'Guna2GradientButton2
        '
        resources.ApplyResources(Me.Guna2GradientButton2, "Guna2GradientButton2")
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Image = Global.Arduino1.My.Resources.Resources.Prev
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        '
        'Guna2GradientButton3
        '
        resources.ApplyResources(Me.Guna2GradientButton3, "Guna2GradientButton3")
        Me.Guna2GradientButton3.CheckedState.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.CustomImages.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Guna2GradientButton3.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton3.HoverState.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.Image = Global.Arduino1.My.Resources.Resources._Stop
        Me.Guna2GradientButton3.Name = "Guna2GradientButton3"
        Me.Guna2GradientButton3.ShadowDecoration.Parent = Me.Guna2GradientButton3
        '
        'Guna2GradientButton1
        '
        resources.ApplyResources(Me.Guna2GradientButton1, "Guna2GradientButton1")
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Image = Global.Arduino1.My.Resources.Resources._next
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        '
        'comListener
        '
        Me.comListener.Enabled = True
        Me.comListener.Interval = 200
        '
        'CheckBox1
        '
        resources.ApplyResources(Me.CheckBox1, "CheckBox1")
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Arduino1.My.Resources.Resources.rickroll_4k
        Me.CancelButton = Me.Guna2GradientButton1
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents title1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents artist1 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents title3 As Label
    Friend WithEvents artist3 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents title2 As Label
    Friend WithEvents artist2 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents artist As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents comListener As Timer
    Friend WithEvents comportLabel As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
