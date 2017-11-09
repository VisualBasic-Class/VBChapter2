<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLatinTranslator
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
        Me.txtLatin = New System.Windows.Forms.TextBox()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.txtSinister = New System.Windows.Forms.TextBox()
        Me.txtDexter = New System.Windows.Forms.TextBox()
        Me.txtMedium = New System.Windows.Forms.TextBox()
        Me.btnShowEnglish = New System.Windows.Forms.Button()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.txtRight = New System.Windows.Forms.TextBox()
        Me.txtCenter = New System.Windows.Forms.TextBox()
        Me.btnExitApp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLatin
        '
        Me.txtLatin.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtLatin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLatin.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatin.Location = New System.Drawing.Point(23, 34)
        Me.txtLatin.Name = "txtLatin"
        Me.txtLatin.ReadOnly = True
        Me.txtLatin.Size = New System.Drawing.Size(75, 26)
        Me.txtLatin.TabIndex = 0
        Me.txtLatin.Text = "Latin"
        '
        'txtEnglish
        '
        Me.txtEnglish.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtEnglish.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEnglish.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnglish.Location = New System.Drawing.Point(194, 34)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.ReadOnly = True
        Me.txtEnglish.Size = New System.Drawing.Size(100, 26)
        Me.txtEnglish.TabIndex = 1
        Me.txtEnglish.Text = "English"
        '
        'txtSinister
        '
        Me.txtSinister.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtSinister.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSinister.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSinister.Location = New System.Drawing.Point(23, 66)
        Me.txtSinister.Name = "txtSinister"
        Me.txtSinister.ReadOnly = True
        Me.txtSinister.Size = New System.Drawing.Size(50, 16)
        Me.txtSinister.TabIndex = 2
        Me.txtSinister.Text = "sinister"
        '
        'txtDexter
        '
        Me.txtDexter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtDexter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDexter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDexter.Location = New System.Drawing.Point(23, 105)
        Me.txtDexter.Name = "txtDexter"
        Me.txtDexter.ReadOnly = True
        Me.txtDexter.Size = New System.Drawing.Size(50, 16)
        Me.txtDexter.TabIndex = 3
        Me.txtDexter.Text = "dexter"
        '
        'txtMedium
        '
        Me.txtMedium.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtMedium.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMedium.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedium.Location = New System.Drawing.Point(23, 146)
        Me.txtMedium.Name = "txtMedium"
        Me.txtMedium.ReadOnly = True
        Me.txtMedium.Size = New System.Drawing.Size(50, 16)
        Me.txtMedium.TabIndex = 4
        Me.txtMedium.Text = "medium"
        '
        'btnShowEnglish
        '
        Me.btnShowEnglish.Location = New System.Drawing.Point(23, 203)
        Me.btnShowEnglish.Name = "btnShowEnglish"
        Me.btnShowEnglish.Size = New System.Drawing.Size(90, 23)
        Me.btnShowEnglish.TabIndex = 5
        Me.btnShowEnglish.Text = "Show English"
        Me.btnShowEnglish.UseVisualStyleBackColor = True
        '
        'txtLeft
        '
        Me.txtLeft.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtLeft.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLeft.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeft.Location = New System.Drawing.Point(220, 66)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.ReadOnly = True
        Me.txtLeft.Size = New System.Drawing.Size(50, 16)
        Me.txtLeft.TabIndex = 6
        Me.txtLeft.Text = "left"
        Me.txtLeft.Visible = False
        '
        'txtRight
        '
        Me.txtRight.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtRight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRight.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRight.Location = New System.Drawing.Point(220, 105)
        Me.txtRight.Name = "txtRight"
        Me.txtRight.ReadOnly = True
        Me.txtRight.Size = New System.Drawing.Size(50, 16)
        Me.txtRight.TabIndex = 7
        Me.txtRight.Text = "right"
        Me.txtRight.Visible = False
        '
        'txtCenter
        '
        Me.txtCenter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCenter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCenter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCenter.Location = New System.Drawing.Point(220, 146)
        Me.txtCenter.Name = "txtCenter"
        Me.txtCenter.ReadOnly = True
        Me.txtCenter.Size = New System.Drawing.Size(50, 16)
        Me.txtCenter.TabIndex = 8
        Me.txtCenter.Text = "center"
        Me.txtCenter.Visible = False
        '
        'btnExitApp
        '
        Me.btnExitApp.Location = New System.Drawing.Point(195, 203)
        Me.btnExitApp.Name = "btnExitApp"
        Me.btnExitApp.Size = New System.Drawing.Size(75, 23)
        Me.btnExitApp.TabIndex = 9
        Me.btnExitApp.Text = "Exit"
        Me.btnExitApp.UseVisualStyleBackColor = True
        '
        'formLatinTranslator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(306, 262)
        Me.Controls.Add(Me.btnExitApp)
        Me.Controls.Add(Me.txtCenter)
        Me.Controls.Add(Me.txtRight)
        Me.Controls.Add(Me.txtLeft)
        Me.Controls.Add(Me.btnShowEnglish)
        Me.Controls.Add(Me.txtMedium)
        Me.Controls.Add(Me.txtDexter)
        Me.Controls.Add(Me.txtSinister)
        Me.Controls.Add(Me.txtEnglish)
        Me.Controls.Add(Me.txtLatin)
        Me.Name = "formLatinTranslator"
        Me.Text = "Latin Translator (Ad Latina Latine)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLatin As System.Windows.Forms.TextBox
    Friend WithEvents txtEnglish As System.Windows.Forms.TextBox
    Friend WithEvents txtSinister As System.Windows.Forms.TextBox
    Friend WithEvents txtDexter As System.Windows.Forms.TextBox
    Friend WithEvents txtMedium As System.Windows.Forms.TextBox
    Friend WithEvents btnShowEnglish As System.Windows.Forms.Button
    Friend WithEvents txtLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtRight As System.Windows.Forms.TextBox
    Friend WithEvents txtCenter As System.Windows.Forms.TextBox
    Friend WithEvents btnExitApp As System.Windows.Forms.Button

End Class
