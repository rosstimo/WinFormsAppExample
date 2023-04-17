<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        AboutLabel = New Label()
        OKButton = New Button()
        SuspendLayout()
        ' 
        ' AboutLabel
        ' 
        AboutLabel.Location = New Point(12, 9)
        AboutLabel.Name = "AboutLabel"
        AboutLabel.Size = New Size(527, 263)
        AboutLabel.TabIndex = 0
        AboutLabel.Text = "Windows Form Application v0.0.02" & vbCrLf & vbCrLf & "ACME llc" & vbCrLf & vbCrLf & "123 Wabbit Woad" & vbCrLf & "Beverly Hills CA 90210"
        ' 
        ' OKButton
        ' 
        OKButton.Location = New Point(307, 275)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(232, 72)
        OKButton.TabIndex = 1
        OKButton.Text = "&OK"
        OKButton.UseVisualStyleBackColor = True
        ' 
        ' AboutForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(571, 386)
        Controls.Add(OKButton)
        Controls.Add(AboutLabel)
        Name = "AboutForm"
        Text = "AboutForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents AboutLabel As Label
    Friend WithEvents OKButton As Button
End Class
