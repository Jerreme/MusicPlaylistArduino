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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.comportLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.comListener = New System.Windows.Forms.Timer(Me.components)
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
        Me.Guna2Panel5.Controls.Add(Me.Label6)
        Me.Guna2Panel5.Controls.Add(Me.Label7)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Name = "Label6"
        Me.Label6.UseMnemonic = False
        Me.Label6.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Name = "Label7"
        Me.Label7.UseMnemonic = False
        Me.Label7.UseWaitCursor = True
        '
        'Guna2Panel4
        '
        resources.ApplyResources(Me.Guna2Panel4, "Guna2Panel4")
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.Label3)
        Me.Guna2Panel4.Controls.Add(Me.Label4)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Name = "Label3"
        Me.Label3.UseMnemonic = False
        Me.Label3.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Name = "Label4"
        Me.Label4.UseMnemonic = False
        Me.Label4.UseWaitCursor = True
        '
        'Guna2Panel3
        '
        resources.ApplyResources(Me.Guna2Panel3, "Guna2Panel3")
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.Label2)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Name = "Label2"
        Me.Label2.UseMnemonic = False
        Me.Label2.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Name = "Label5"
        Me.Label5.UseMnemonic = False
        Me.Label5.UseWaitCursor = True
        '
        'Guna2Panel2
        '
        resources.ApplyResources(Me.Guna2Panel2, "Guna2Panel2")
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.comportLabel)
        Me.Guna2Panel2.Controls.Add(Me.Label8)
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
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Name = "Label8"
        Me.Label8.UseMnemonic = False
        Me.Label8.UseWaitCursor = True
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
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents comListener As Timer
    Friend WithEvents comportLabel As Label
End Class
