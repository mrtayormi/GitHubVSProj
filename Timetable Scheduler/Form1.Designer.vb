<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BaWGUIButton4 = New Timetable_Scheduler.BaWGUIButton()
        Me.BaWGUIButton3 = New Timetable_Scheduler.BaWGUIButton()
        Me.BaWGUIButton2 = New Timetable_Scheduler.BaWGUIButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BaWGUIButton1 = New Timetable_Scheduler.BaWGUIButton()
        Me.BaWGUIThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaWGUIThemeContainer1
        '
        Me.BaWGUIThemeContainer1.BackColor = System.Drawing.Color.White
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton4)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton3)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton2)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.Label1)
        Me.BaWGUIThemeContainer1.Controls.Add(Me.BaWGUIButton1)
        Me.BaWGUIThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaWGUIThemeContainer1.DrawButtonStrings = True
        Me.BaWGUIThemeContainer1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaWGUIThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.BaWGUIThemeContainer1.Name = "BaWGUIThemeContainer1"
        Me.BaWGUIThemeContainer1.Size = New System.Drawing.Size(987, 472)
        Me.BaWGUIThemeContainer1.TabIndex = 0
        Me.BaWGUIThemeContainer1.Text = "Federal University Time Table Generator"
        '
        'BaWGUIButton4
        '
        Me.BaWGUIButton4.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BaWGUIButton4.Location = New System.Drawing.Point(685, 162)
        Me.BaWGUIButton4.Name = "BaWGUIButton4"
        Me.BaWGUIButton4.Size = New System.Drawing.Size(193, 60)
        Me.BaWGUIButton4.TabIndex = 4
        Me.BaWGUIButton4.Text = "Add Lecturer"
        '
        'BaWGUIButton3
        '
        Me.BaWGUIButton3.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BaWGUIButton3.Location = New System.Drawing.Point(685, 75)
        Me.BaWGUIButton3.Name = "BaWGUIButton3"
        Me.BaWGUIButton3.Size = New System.Drawing.Size(193, 60)
        Me.BaWGUIButton3.TabIndex = 3
        Me.BaWGUIButton3.Text = "Add Lecture Hall"
        '
        'BaWGUIButton2
        '
        Me.BaWGUIButton2.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BaWGUIButton2.Location = New System.Drawing.Point(454, 162)
        Me.BaWGUIButton2.Name = "BaWGUIButton2"
        Me.BaWGUIButton2.Size = New System.Drawing.Size(193, 60)
        Me.BaWGUIButton2.TabIndex = 2
        Me.BaWGUIButton2.Text = "Generate Timetable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(64, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FUL TIME TABLE GENERATOR"
        '
        'BaWGUIButton1
        '
        Me.BaWGUIButton1.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUIButton1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.BaWGUIButton1.Location = New System.Drawing.Point(454, 75)
        Me.BaWGUIButton1.Name = "BaWGUIButton1"
        Me.BaWGUIButton1.Size = New System.Drawing.Size(193, 60)
        Me.BaWGUIButton1.TabIndex = 0
        Me.BaWGUIButton1.Text = "Add Courses"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 472)
        Me.Controls.Add(Me.BaWGUIThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BaWGUIThemeContainer1.ResumeLayout(False)
        Me.BaWGUIThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaWGUIThemeContainer1 As Timetable_Scheduler.BaWGUIThemeContainer
    Friend WithEvents BaWGUIButton1 As Timetable_Scheduler.BaWGUIButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BaWGUIButton3 As Timetable_Scheduler.BaWGUIButton
    Friend WithEvents BaWGUIButton2 As Timetable_Scheduler.BaWGUIButton
    Friend WithEvents BaWGUIButton4 As Timetable_Scheduler.BaWGUIButton

End Class
