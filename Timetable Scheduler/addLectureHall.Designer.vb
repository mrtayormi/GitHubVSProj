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
        Me.rmtb = New Timetable_Scheduler.BaWGUITextBox()
        Me.blktb = New Timetable_Scheduler.BaWGUITextBox()
        Me.BaWGUIThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaWGUIThemeContainer1
        '
        Me.BaWGUIThemeContainer1.BackColor = System.Drawing.Color.White
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.rmtb)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.blktb)
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
        'rmtb
        '
        Me.rmtb.BackColor = System.Drawing.Color.Transparent
        Me.rmtb.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.rmtb.Image = Global.Timetable_Scheduler.My.Resources.Resources.doc_lines_stright_icon_48
        Me.rmtb.Location = New System.Drawing.Point(93, 161)
        Me.rmtb.MaxLength = 32767
        Me.rmtb.Multiline = False
        Me.rmtb.Name = "rmtb"
        Me.rmtb.ReadOnly = False
        Me.rmtb.Size = New System.Drawing.Size(530, 53)
        Me.rmtb.TabIndex = 1
        Me.rmtb.Text = "Room"
        Me.rmtb.UseSystemPasswordChar = False
        '
        'blktb
        '
        Me.blktb.BackColor = System.Drawing.Color.Transparent
        Me.blktb.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.blktb.Image = Global.Timetable_Scheduler.My.Resources.Resources._2x2_grid_icon_48
        Me.blktb.Location = New System.Drawing.Point(93, 80)
        Me.blktb.MaxLength = 32767
        Me.blktb.Multiline = False
        Me.blktb.Name = "blktb"
        Me.blktb.ReadOnly = False
        Me.blktb.Size = New System.Drawing.Size(530, 53)
        Me.blktb.TabIndex = 0
        Me.blktb.Text = "Block Name"
        Me.blktb.UseSystemPasswordChar = False
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
    Friend WithEvents rmtb As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents blktb As Timetable_Scheduler.BaWGUITextBox
    Friend WithEvents BaWGUIButton1 As Timetable_Scheduler.BaWGUIButton
End Class
