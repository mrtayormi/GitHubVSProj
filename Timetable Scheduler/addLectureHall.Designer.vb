<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addLectureHall
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
        Me.BaWGUIButton1 = New Timetable_Scheduler.BaWGUIButton()
        Me.BaWGUITextBox2 = New Timetable_Scheduler.BaWGUITextBox()
        Me.BaWGUITextBox1 = New Timetable_Scheduler.BaWGUITextBox()
        Me.BaWGUIThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaWGUIThemeContainer1
        '
        Me.BaWGUIThemeContainer1.BackColor = System.Drawing.Color.White
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUITextBox2)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUITextBox1)
        Me.BaWGUIThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaWGUIThemeContainer1.DrawButtonStrings = True
        Me.BaWGUIThemeContainer1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaWGUIThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.BaWGUIThemeContainer1.Name = "BaWGUIThemeContainer1"
        Me.BaWGUIThemeContainer1.Size = New System.Drawing.Size(777, 368)
        Me.BaWGUIThemeContainer1.TabIndex = 0
        Me.BaWGUIThemeContainer1.Text = "Add Lecture Hall"
        '
        'BaWGUIButton1
        '
        Me.BaWGUIButton1.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BaWGUIButton1.Location = New System.Drawing.Point(93, 261)
        Me.BaWGUIButton1.Name = "BaWGUIButton1"
        Me.BaWGUIButton1.Size = New System.Drawing.Size(530, 71)
        Me.BaWGUIButton1.TabIndex = 2
        Me.BaWGUIButton1.Text = "Save"
        '
        'BaWGUITextBox2
        '
        Me.BaWGUITextBox2.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUITextBox2.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.BaWGUITextBox2.Image = Global.Timetable_Scheduler.My.Resources.Resources.doc_lines_stright_icon_48
        Me.BaWGUITextBox2.Location = New System.Drawing.Point(93, 161)
        Me.BaWGUITextBox2.MaxLength = 32767
        Me.BaWGUITextBox2.Multiline = False
        Me.BaWGUITextBox2.Name = "BaWGUITextBox2"
        Me.BaWGUITextBox2.ReadOnly = False
        Me.BaWGUITextBox2.Size = New System.Drawing.Size(530, 53)
        Me.BaWGUITextBox2.TabIndex = 1
        Me.BaWGUITextBox2.Text = "Room"
        Me.BaWGUITextBox2.UseSystemPasswordChar = False
        '
        'BaWGUITextBox1
        '
        Me.BaWGUITextBox1.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUITextBox1.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.BaWGUITextBox1.Image = Global.Timetable_Scheduler.My.Resources.Resources._2x2_grid_icon_48
        Me.BaWGUITextBox1.Location = New System.Drawing.Point(93, 80)
        Me.BaWGUITextBox1.MaxLength = 32767
        Me.BaWGUITextBox1.Multiline = False
        Me.BaWGUITextBox1.Name = "BaWGUITextBox1"
        Me.BaWGUITextBox1.ReadOnly = False
        Me.BaWGUITextBox1.Size = New System.Drawing.Size(530, 53)
        Me.BaWGUITextBox1.TabIndex = 0
        Me.BaWGUITextBox1.Text = "Block Name"
        Me.BaWGUITextBox1.UseSystemPasswordChar = False
        '
        'addLectureHall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 368)
        Me.Controls.Add(Me.BaWGUIThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addLectureHall"
        Me.Text = "addLectureHall"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BaWGUIThemeContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaWGUIThemeContainer1 As Timetable_Scheduler.BaWGUIThemeContainer
    Friend WithEvents BaWGUITextBox2 As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents BaWGUITextBox1 As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents BaWGUIButton1 As Timetable_Scheduler.BaWGUIButton
End Class
