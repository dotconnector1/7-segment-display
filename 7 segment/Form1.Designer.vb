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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Reset = New System.Windows.Forms.Button()
        Me.setNum = New System.Windows.Forms.TextBox()
        Me.stap = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SplitContainer1.Panel1.Controls.Add(Me.Reset)
        Me.SplitContainer1.Panel1.Controls.Add(Me.setNum)
        Me.SplitContainer1.Panel1.Controls.Add(Me.stap)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Start)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Size = New System.Drawing.Size(600, 366)
        Me.SplitContainer1.SplitterDistance = 199
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(131, 111)
        Me.Reset.Margin = New System.Windows.Forms.Padding(2)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(56, 28)
        Me.Reset.TabIndex = 3
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'setNum
        '
        Me.setNum.Location = New System.Drawing.Point(11, 68)
        Me.setNum.Margin = New System.Windows.Forms.Padding(2)
        Me.setNum.Name = "setNum"
        Me.setNum.Size = New System.Drawing.Size(176, 20)
        Me.setNum.TabIndex = 2
        '
        'stap
        '
        Me.stap.Location = New System.Drawing.Point(71, 111)
        Me.stap.Margin = New System.Windows.Forms.Padding(2)
        Me.stap.Name = "stap"
        Me.stap.Size = New System.Drawing.Size(56, 28)
        Me.stap.TabIndex = 1
        Me.stap.Text = "Stop"
        Me.stap.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(11, 111)
        Me.Start.Margin = New System.Windows.Forms.Padding(2)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(56, 28)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Red
        Me.Button7.Location = New System.Drawing.Point(358, 36)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(40, 140)
        Me.Button7.TabIndex = 5
        Me.Button7.UseVisualStyleBackColor = False
        Me.Button7.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Red
        Me.Button6.Location = New System.Drawing.Point(358, 175)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 152)
        Me.Button6.TabIndex = 3
        Me.Button6.UseVisualStyleBackColor = False
        Me.Button6.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.Location = New System.Drawing.Point(0, 326)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(398, 40)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(0, 175)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 152)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(0, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(398, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(0, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 140)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(398, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "7 Segment Display"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents setNum As TextBox
    Friend WithEvents stap As Button
    Friend WithEvents Start As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Reset As Button
    Friend WithEvents Timer1 As Timer
End Class
