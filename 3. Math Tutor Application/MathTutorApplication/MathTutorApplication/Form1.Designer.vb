<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMathTutor
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
        Me.txtMathProblem = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.btnExitApp = New System.Windows.Forms.Button()
        Me.txtAnswer2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtMathProblem
        '
        Me.txtMathProblem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtMathProblem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMathProblem.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMathProblem.Location = New System.Drawing.Point(51, 104)
        Me.txtMathProblem.Name = "txtMathProblem"
        Me.txtMathProblem.Size = New System.Drawing.Size(142, 30)
        Me.txtMathProblem.TabIndex = 0
        Me.txtMathProblem.Text = "18 + 64 ="
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswer.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(210, 99)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(23, 36)
        Me.txtAnswer.TabIndex = 1
        Me.txtAnswer.Text = "?"
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(29, 205)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(94, 28)
        Me.btnShowAnswer.TabIndex = 2
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'btnExitApp
        '
        Me.btnExitApp.Location = New System.Drawing.Point(176, 205)
        Me.btnExitApp.Name = "btnExitApp"
        Me.btnExitApp.Size = New System.Drawing.Size(82, 28)
        Me.btnExitApp.TabIndex = 3
        Me.btnExitApp.Text = "Exit"
        Me.btnExitApp.UseVisualStyleBackColor = True
        '
        'txtAnswer2
        '
        Me.txtAnswer2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswer2.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer2.Location = New System.Drawing.Point(199, 99)
        Me.txtAnswer2.Name = "txtAnswer2"
        Me.txtAnswer2.Size = New System.Drawing.Size(100, 36)
        Me.txtAnswer2.TabIndex = 4
        Me.txtAnswer2.Text = "82"
        Me.txtAnswer2.Visible = False
        '
        'formMathTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtAnswer2)
        Me.Controls.Add(Me.btnExitApp)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtMathProblem)
        Me.Name = "formMathTutor"
        Me.Text = "Math Tutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMathProblem As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents btnShowAnswer As System.Windows.Forms.Button
    Friend WithEvents btnExitApp As System.Windows.Forms.Button
    Friend WithEvents txtAnswer2 As System.Windows.Forms.TextBox

End Class
