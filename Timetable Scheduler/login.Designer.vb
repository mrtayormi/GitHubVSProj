<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.BaWGUIThemeContainer1 = New Timetable_Scheduler.BaWGUIThemeContainer()
        Me.password = New Timetable_Scheduler.BaWGUITextBox()
        Me.username = New Timetable_Scheduler.BaWGUITextBox()
        Me.btnlogin = New Timetable_Scheduler.BaWGUIButton()
        Me.BaWGUIThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaWGUIThemeContainer1
        '
        Me.BaWGUIThemeContainer1.BackColor = System.Drawing.Color.White
        Me.BaWGUIThemeContainer1.Controls.Add(Me.password)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.username)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.btnlogin)
        Me.BaWGUIThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaWGUIThemeContainer1.DrawButtonStrings = True
        Me.BaWGUIThemeContainer1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaWGUIThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.BaWGUIThemeContainer1.Name = "BaWGUIThemeContainer1"
        Me.BaWGUIThemeContainer1.Size = New System.Drawing.Size(309, 304)
        Me.BaWGUIThemeContainer1.TabIndex = 0
        Me.BaWGUIThemeContainer1.Text = "Login"
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.Transparent
        Me.password.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.password.Image = Global.Timetable_Scheduler.My.Resources.Resources.key_icon_48
        Me.password.Location = New System.Drawing.Point(29, 150)
        Me.password.MaxLength = 32767
        Me.password.Multiline = False
        Me.password.Name = "password"
        Me.password.ReadOnly = False
        Me.password.Size = New System.Drawing.Size(255, 53)
        Me.password.TabIndex = 2
        Me.password.Text = "Password"
        Me.password.UseSystemPasswordChar = True
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.Transparent
        Me.username.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.username.Image = Global.Timetable_Scheduler.My.Resources.Resources.user_icon_48
        Me.username.Location = New System.Drawing.Point(29, 75)
        Me.username.MaxLength = 32767
        Me.username.Multiline = False
        Me.username.Name = "username"
        Me.username.ReadOnly = False
        Me.username.Size = New System.Drawing.Size(255, 53)
        Me.username.TabIndex = 1
        Me.username.Text = "Username"
        Me.username.UseSystemPasswordChar = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnlogin.Location = New System.Drawing.Point(29, 233)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(255, 49)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "Login"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 304)
        Me.Controls.Add(Me.BaWGUIThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.Text = "login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BaWGUIThemeContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaWGUIThemeContainer1 As Timetable_Scheduler.BaWGUIThemeContainer
    Friend WithEvents password As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents username As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents btnlogin As Timetable_Scheduler.BaWGUIButton
End Class
