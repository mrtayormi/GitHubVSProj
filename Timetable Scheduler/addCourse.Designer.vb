<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addCourse
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
        Me.ctitletb = New Timetable_Scheduler.BaWGUITextBox()
        Me.ccodetb = New Timetable_Scheduler.BaWGUITextBox()
        Me.lecturercb = New Timetable_Scheduler.BaWGUIComboBox()
        Me.savebtn = New Timetable_Scheduler.BaWGUIButton()
        Me.BaWGUIButton2 = New Timetable_Scheduler.BaWGUIButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.levelcb = New Timetable_Scheduler.BaWGUIComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hourscb = New Timetable_Scheduler.BaWGUIComboBox()
        Me.cunittb = New Timetable_Scheduler.BaWGUITextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BaWGUIThemeContainer1 = New Timetable_Scheduler.BaWGUIThemeContainer()
        Me.BaWGUIThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctitletb
        '
        Me.ctitletb.BackColor = System.Drawing.Color.Transparent
        Me.ctitletb.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.ctitletb.Image = Global.Timetable_Scheduler.My.Resources.Resources.pencil_icon_48
        Me.ctitletb.Location = New System.Drawing.Point(45, 83)
        Me.ctitletb.MaxLength = 32767
        Me.ctitletb.Multiline = False
        Me.ctitletb.Name = "ctitletb"
        Me.ctitletb.ReadOnly = False
        Me.ctitletb.Size = New System.Drawing.Size(350, 53)
        Me.ctitletb.TabIndex = 0
        Me.ctitletb.Text = "Course Title"
        Me.ctitletb.UseSystemPasswordChar = False
        '
        'ccodetb
        '
        Me.ccodetb.BackColor = System.Drawing.Color.Transparent
        Me.ccodetb.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.ccodetb.Image = Global.Timetable_Scheduler.My.Resources.Resources.pencil_icon_48
        Me.ccodetb.Location = New System.Drawing.Point(46, 172)
        Me.ccodetb.MaxLength = 32767
        Me.ccodetb.Multiline = False
        Me.ccodetb.Name = "ccodetb"
        Me.ccodetb.ReadOnly = False
        Me.ccodetb.Size = New System.Drawing.Size(349, 53)
        Me.ccodetb.TabIndex = 1
        Me.ccodetb.Text = "Course Code"
        Me.ccodetb.UseSystemPasswordChar = False
        '
        'lecturercb
        '
        Me.lecturercb.BackColor = System.Drawing.Color.Transparent
        Me.lecturercb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lecturercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lecturercb.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lecturercb.ForeColor = System.Drawing.Color.Black
        Me.lecturercb.FormattingEnabled = True
        Me.lecturercb.ItemHeight = 39
        Me.lecturercb.Location = New System.Drawing.Point(45, 265)
        Me.lecturercb.Name = "lecturercb"
        Me.lecturercb.Size = New System.Drawing.Size(350, 45)
        Me.lecturercb.TabIndex = 3
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.Transparent
        Me.savebtn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.savebtn.Location = New System.Drawing.Point(45, 360)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(172, 45)
        Me.savebtn.TabIndex = 4
        Me.savebtn.Text = "Save"
        '
        'BaWGUIButton2
        '
        Me.BaWGUIButton2.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BaWGUIButton2.Location = New System.Drawing.Point(223, 360)
        Me.BaWGUIButton2.Name = "BaWGUIButton2"
        Me.BaWGUIButton2.Size = New System.Drawing.Size(172, 45)
        Me.BaWGUIButton2.TabIndex = 5
        Me.BaWGUIButton2.Text = "Reset"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(177, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Lecturer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(165, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Course Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(165, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Course Title"
        '
        'levelcb
        '
        Me.levelcb.BackColor = System.Drawing.Color.Transparent
        Me.levelcb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.levelcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.levelcb.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.levelcb.ForeColor = System.Drawing.Color.Black
        Me.levelcb.FormattingEnabled = True
        Me.levelcb.ItemHeight = 39
        Me.levelcb.Items.AddRange(New Object() {"100", "200", "300", "400"})
        Me.levelcb.Location = New System.Drawing.Point(454, 91)
        Me.levelcb.Name = "levelcb"
        Me.levelcb.Size = New System.Drawing.Size(350, 45)
        Me.levelcb.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(593, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Level"
        '
        'hourscb
        '
        Me.hourscb.BackColor = System.Drawing.Color.Transparent
        Me.hourscb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.hourscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hourscb.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.hourscb.ForeColor = System.Drawing.Color.Black
        Me.hourscb.FormattingEnabled = True
        Me.hourscb.ItemHeight = 39
        Me.hourscb.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.hourscb.Location = New System.Drawing.Point(454, 265)
        Me.hourscb.Name = "hourscb"
        Me.hourscb.Size = New System.Drawing.Size(350, 45)
        Me.hourscb.TabIndex = 12
        '
        'cunittb
        '
        Me.cunittb.BackColor = System.Drawing.Color.Transparent
        Me.cunittb.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.cunittb.Image = Global.Timetable_Scheduler.My.Resources.Resources.pencil_icon_48
        Me.cunittb.Location = New System.Drawing.Point(455, 172)
        Me.cunittb.MaxLength = 5
        Me.cunittb.Multiline = False
        Me.cunittb.Name = "cunittb"
        Me.cunittb.ReadOnly = False
        Me.cunittb.Size = New System.Drawing.Size(349, 53)
        Me.cunittb.TabIndex = 13
        Me.cunittb.Text = "Course unit"
        Me.cunittb.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(571, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Credit Unit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(593, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Hours"
        '
        'BaWGUIThemeContainer1
        '
        Me.BaWGUIThemeContainer1.BackColor = System.Drawing.Color.White
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label6)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label5)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.cunittb)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.hourscb)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label2)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.levelcb)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label4)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label3)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton2)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.savebtn)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.lecturercb)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.ccodetb)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.ctitletb)
        Me.BaWGUIThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaWGUIThemeContainer1.DrawButtonStrings = True
        Me.BaWGUIThemeContainer1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaWGUIThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.BaWGUIThemeContainer1.Name = "BaWGUIThemeContainer1"
        Me.BaWGUIThemeContainer1.Size = New System.Drawing.Size(883, 442)
        Me.BaWGUIThemeContainer1.TabIndex = 0
        Me.BaWGUIThemeContainer1.Text = "Add Course"
        '
        'addCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 442)
        Me.Controls.Add(Me.BaWGUIThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addCourse"
        Me.Text = "addCourse"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BaWGUIThemeContainer1.ResumeLayout(False)
        Me.BaWGUIThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ctitletb As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents ccodetb As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents lecturercb As Timetable_Scheduler.BaWGUIComboBox
    Friend WithEvents savebtn As Timetable_Scheduler.BaWGUIButton
    Friend WithEvents BaWGUIButton2 As Timetable_Scheduler.BaWGUIButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents levelcb As Timetable_Scheduler.BaWGUIComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents hourscb As Timetable_Scheduler.BaWGUIComboBox
    Friend WithEvents cunittb As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BaWGUIThemeContainer1 As Timetable_Scheduler.BaWGUIThemeContainer
End Class
