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
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtWolfe = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtCityState = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Location = New System.Drawing.Point(26, 205)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnShowInfo.TabIndex = 0
        Me.btnShowInfo.Text = "Show Info."
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 205)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtWolfe
        '
        Me.txtWolfe.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtWolfe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWolfe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWolfe.Location = New System.Drawing.Point(92, 41)
        Me.txtWolfe.Name = "txtWolfe"
        Me.txtWolfe.Size = New System.Drawing.Size(98, 19)
        Me.txtWolfe.TabIndex = 2
        Me.txtWolfe.Text = "William Wolfe"
        Me.txtWolfe.Visible = False
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStreetAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetAddress.Location = New System.Drawing.Point(67, 91)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(157, 19)
        Me.txtStreetAddress.TabIndex = 3
        Me.txtStreetAddress.Text = "888 South Main Street"
        Me.txtStreetAddress.Visible = False
        '
        'txtCityState
        '
        Me.txtCityState.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCityState.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCityState.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCityState.Location = New System.Drawing.Point(62, 142)
        Me.txtCityState.Name = "txtCityState"
        Me.txtCityState.Size = New System.Drawing.Size(162, 19)
        Me.txtCityState.TabIndex = 4
        Me.txtCityState.Text = "Waynesville, NC 28786"
        Me.txtCityState.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtCityState)
        Me.Controls.Add(Me.txtStreetAddress)
        Me.Controls.Add(Me.txtWolfe)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowInfo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtWolfe As System.Windows.Forms.TextBox
    Friend WithEvents txtStreetAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCityState As System.Windows.Forms.TextBox

End Class
