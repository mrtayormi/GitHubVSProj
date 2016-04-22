<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addLecturer
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.savebtn = New Timetable_Scheduler.BaWGUIButton()
        Me.resetbtn = New Timetable_Scheduler.BaWGUIButton()
        Me.staffidtb = New Timetable_Scheduler.BaWGUITextBox()
        Me.lnametb = New Timetable_Scheduler.BaWGUITextBox()
        Me.fnametb = New Timetable_Scheduler.BaWGUITextBox()
        Me.BaWGUIThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaWGUIThemeContainer1
        '
        Me.BaWGUIThemeContainer1.BackColor = System.Drawing.Color.White
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label3)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label2)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.savebtn)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.resetbtn)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.staffidtb)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.lnametb)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.fnametb)
        Me.BaWGUIThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaWGUIThemeContainer1.DrawButtonStrings = True
        Me.BaWGUIThemeContainer1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaWGUIThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.BaWGUIThemeContainer1.Name = "BaWGUIThemeContainer1"
        Me.BaWGUIThemeContainer1.Size = New System.Drawing.Size(867, 403)
        Me.BaWGUIThemeContainer1.TabIndex = 0
        Me.BaWGUIThemeContainer1.Text = "Add Lecturer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(40, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Staff ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(444, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(40, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "First Name"
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.Transparent
        Me.savebtn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.savebtn.Location = New System.Drawing.Point(253, 294)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(154, 51)
        Me.savebtn.TabIndex = 8
        Me.savebtn.Text = "Save"
        '
        'resetbtn
        '
        Me.resetbtn.BackColor = System.Drawing.Color.Transparent
        Me.resetbtn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.resetbtn.Location = New System.Drawing.Point(40, 294)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(154, 51)
        Me.resetbtn.TabIndex = 7
        Me.resetbtn.Text = "Reset"
        '
        'staffidtb
        '
        Me.staffidtb.BackColor = System.Drawing.Color.Transparent
        Me.staffidtb.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.staffidtb.Image = Global.Timetable_Scheduler.My.Resources.Resources.paper_airplane_icon_48
        Me.staffidtb.Location = New System.Drawing.Point(40, 190)
        Me.staffidtb.MaxLength = 32767
        Me.staffidtb.Multiline = False
        Me.staffidtb.Name = "staffidtb"
        Me.staffidtb.ReadOnly = False
        Me.staffidtb.Size = New System.Drawing.Size(367, 53)
        Me.staffidtb.TabIndex = 2
        Me.staffidtb.Text = "Staff ID"
        Me.staffidtb.UseSystemPasswordChar = False
        '
        'lnametb
        '
        Me.lnametb.BackColor = System.Drawing.Color.Transparent
        Me.lnametb.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lnametb.Image = Global.Timetable_Scheduler.My.Resources.Resources.users_icon_48
        Me.lnametb.Location = New System.Drawing.Point(448, 93)
        Me.lnametb.MaxLength = 32767
        Me.lnametb.Multiline = False
        Me.lnametb.Name = "lnametb"
        Me.lnametb.ReadOnly = False
        Me.lnametb.Size = New System.Drawing.Size(358, 53)
        Me.lnametb.TabIndex = 1
        Me.lnametb.Text = "Last Name"
        Me.lnametb.UseSystemPasswordChar = False
        '
        'fnametb
        '
        Me.fnametb.BackColor = System.Drawing.Color.Transparent
        Me.fnametb.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.fnametb.Image = Global.Timetable_Scheduler.My.Resources.Resources.users_icon_48
        Me.fnametb.Location = New System.Drawing.Point(44, 93)
        Me.fnametb.MaxLength = 32767
        Me.fnametb.Multiline = False
        Me.fnametb.Name = "fnametb"
        Me.fnametb.ReadOnly = False
        Me.fnametb.Size = New System.Drawing.Size(363, 53)
        Me.fnametb.TabIndex = 0
        Me.fnametb.Text = "First Name"
        Me.fnametb.UseSystemPasswordChar = False
        '
        'addLecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 403)
        Me.Controls.Add(Me.BaWGUIThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addLecturer"
        Me.Text = "addLecturer"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BaWGUIThemeContainer1.ResumeLayout(False)
        Me.BaWGUIThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaWGUIThemeContainer1 As Timetable_Scheduler.BaWGUIThemeContainer
    Friend WithEvents staffidtb As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents lnametb As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents fnametb As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents savebtn As Timetable_Scheduler.BaWGUIButton
    Friend WithEvents resetbtn As Timetable_Scheduler.BaWGUIButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
