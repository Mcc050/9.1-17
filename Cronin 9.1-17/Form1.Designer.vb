<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstBox
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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.lstboxNumbers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(12, 85)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(75, 23)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Click me!"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'lstboxNumbers
        '
        Me.lstboxNumbers.FormattingEnabled = True
        Me.lstboxNumbers.Location = New System.Drawing.Point(121, 30)
        Me.lstboxNumbers.Name = "lstboxNumbers"
        Me.lstboxNumbers.Size = New System.Drawing.Size(152, 173)
        Me.lstboxNumbers.TabIndex = 1
        '
        'lstBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 263)
        Me.Controls.Add(Me.lstboxNumbers)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "lstBox"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClick As System.Windows.Forms.Button
    Friend WithEvents lstboxNumbers As System.Windows.Forms.ListBox

End Class
