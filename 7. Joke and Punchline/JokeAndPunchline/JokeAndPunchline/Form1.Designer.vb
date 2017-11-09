<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formJokeTime
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
        Me.txtJokeTime = New System.Windows.Forms.TextBox()
        Me.btnSure = New System.Windows.Forms.Button()
        Me.txtJokePrompt = New System.Windows.Forms.TextBox()
        Me.btnShowPunchline = New System.Windows.Forms.Button()
        Me.txtPunchline = New System.Windows.Forms.TextBox()
        Me.btnExitApp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtJokeTime
        '
        Me.txtJokeTime.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtJokeTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJokeTime.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJokeTime.Location = New System.Drawing.Point(21, 94)
        Me.txtJokeTime.Name = "txtJokeTime"
        Me.txtJokeTime.ReadOnly = True
        Me.txtJokeTime.Size = New System.Drawing.Size(241, 26)
        Me.txtJokeTime.TabIndex = 0
        Me.txtJokeTime.Text = "Wanna' hear a joke?"
        '
        'btnSure
        '
        Me.btnSure.Location = New System.Drawing.Point(98, 183)
        Me.btnSure.Name = "btnSure"
        Me.btnSure.Size = New System.Drawing.Size(89, 35)
        Me.btnSure.TabIndex = 1
        Me.btnSure.Text = "I guess..."
        Me.btnSure.UseVisualStyleBackColor = True
        '
        'txtJokePrompt
        '
        Me.txtJokePrompt.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtJokePrompt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJokePrompt.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJokePrompt.Location = New System.Drawing.Point(31, 47)
        Me.txtJokePrompt.Multiline = True
        Me.txtJokePrompt.Name = "txtJokePrompt"
        Me.txtJokePrompt.ReadOnly = True
        Me.txtJokePrompt.Size = New System.Drawing.Size(231, 41)
        Me.txtJokePrompt.TabIndex = 2
        Me.txtJokePrompt.Text = "Did you hear about the guy who invented Velcro?"
        Me.txtJokePrompt.Visible = False
        '
        'btnShowPunchline
        '
        Me.btnShowPunchline.Location = New System.Drawing.Point(88, 183)
        Me.btnShowPunchline.Name = "btnShowPunchline"
        Me.btnShowPunchline.Size = New System.Drawing.Size(108, 35)
        Me.btnShowPunchline.TabIndex = 3
        Me.btnShowPunchline.Text = "Punchline please."
        Me.btnShowPunchline.UseVisualStyleBackColor = True
        Me.btnShowPunchline.Visible = False
        '
        'txtPunchline
        '
        Me.txtPunchline.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtPunchline.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPunchline.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPunchline.Location = New System.Drawing.Point(31, 126)
        Me.txtPunchline.Multiline = True
        Me.txtPunchline.Name = "txtPunchline"
        Me.txtPunchline.ReadOnly = True
        Me.txtPunchline.Size = New System.Drawing.Size(231, 41)
        Me.txtPunchline.TabIndex = 4
        Me.txtPunchline.Text = "I heard he was a huge rip-off."
        Me.txtPunchline.Visible = False
        '
        'btnExitApp
        '
        Me.btnExitApp.Location = New System.Drawing.Point(88, 183)
        Me.btnExitApp.Name = "btnExitApp"
        Me.btnExitApp.Size = New System.Drawing.Size(108, 35)
        Me.btnExitApp.TabIndex = 5
        Me.btnExitApp.Text = "Ha."
        Me.btnExitApp.UseVisualStyleBackColor = True
        Me.btnExitApp.Visible = False
        '
        'formJokeTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExitApp)
        Me.Controls.Add(Me.txtPunchline)
        Me.Controls.Add(Me.btnShowPunchline)
        Me.Controls.Add(Me.txtJokePrompt)
        Me.Controls.Add(Me.btnSure)
        Me.Controls.Add(Me.txtJokeTime)
        Me.Name = "formJokeTime"
        Me.Text = "Wanna Hear a Joke?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtJokeTime As System.Windows.Forms.TextBox
    Friend WithEvents btnSure As System.Windows.Forms.Button
    Friend WithEvents txtJokePrompt As System.Windows.Forms.TextBox
    Friend WithEvents btnShowPunchline As System.Windows.Forms.Button
    Friend WithEvents txtPunchline As System.Windows.Forms.TextBox
    Friend WithEvents btnExitApp As System.Windows.Forms.Button

End Class
