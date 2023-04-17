<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        components = New ComponentModel.Container()
        ExitButton = New Button()
        MenuStrip = New MenuStrip()
        FileTopMenuItem = New ToolStripMenuItem()
        ExitTopMenuItem = New ToolStripMenuItem()
        HelpTopMenuItem = New ToolStripMenuItem()
        AboutTopMenuItem = New ToolStripMenuItem()
        ContextMenuStrip = New ContextMenuStrip(components)
        HelpContextMenuItem = New ToolStripMenuItem()
        AboutContextMenuItem = New ToolStripMenuItem()
        GroupBox = New GroupBox()
        MenuStrip.SuspendLayout()
        ContextMenuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(827, 540)
        ExitButton.Margin = New Padding(4, 5, 4, 5)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(303, 162)
        ExitButton.TabIndex = 0
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip
        ' 
        MenuStrip.ImageScalingSize = New Size(24, 24)
        MenuStrip.Items.AddRange(New ToolStripItem() {FileTopMenuItem, HelpTopMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Size = New Size(1143, 33)
        MenuStrip.TabIndex = 1
        MenuStrip.Text = "MenuStrip1"
        ' 
        ' FileTopMenuItem
        ' 
        FileTopMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitTopMenuItem})
        FileTopMenuItem.Name = "FileTopMenuItem"
        FileTopMenuItem.Size = New Size(54, 29)
        FileTopMenuItem.Text = "&File"
        ' 
        ' ExitTopMenuItem
        ' 
        ExitTopMenuItem.Name = "ExitTopMenuItem"
        ExitTopMenuItem.Size = New Size(141, 34)
        ExitTopMenuItem.Text = "E&xit"
        ' 
        ' HelpTopMenuItem
        ' 
        HelpTopMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutTopMenuItem})
        HelpTopMenuItem.Name = "HelpTopMenuItem"
        HelpTopMenuItem.Size = New Size(65, 29)
        HelpTopMenuItem.Text = "&Help"
        ' 
        ' AboutTopMenuItem
        ' 
        AboutTopMenuItem.Name = "AboutTopMenuItem"
        AboutTopMenuItem.Size = New Size(164, 34)
        AboutTopMenuItem.Text = "&About"
        ' 
        ' ContextMenuStrip
        ' 
        ContextMenuStrip.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip.Items.AddRange(New ToolStripItem() {HelpContextMenuItem, AboutContextMenuItem})
        ContextMenuStrip.Name = "ContextMenuStrip"
        ContextMenuStrip.Size = New Size(135, 68)
        ' 
        ' HelpContextMenuItem
        ' 
        HelpContextMenuItem.Name = "HelpContextMenuItem"
        HelpContextMenuItem.Size = New Size(134, 32)
        HelpContextMenuItem.Text = "Help"
        ' 
        ' AboutContextMenuItem
        ' 
        AboutContextMenuItem.Name = "AboutContextMenuItem"
        AboutContextMenuItem.Size = New Size(134, 32)
        AboutContextMenuItem.Text = "About"
        ' 
        ' GroupBox
        ' 
        GroupBox.ContextMenuStrip = ContextMenuStrip
        GroupBox.Location = New Point(12, 36)
        GroupBox.Name = "GroupBox"
        GroupBox.Size = New Size(1119, 496)
        GroupBox.TabIndex = 2
        GroupBox.TabStop = False
        GroupBox.Text = "GroupBox1"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 718)
        ContextMenuStrip = ContextMenuStrip
        Controls.Add(GroupBox)
        Controls.Add(ExitButton)
        Controls.Add(MenuStrip)
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 5, 4, 5)
        Name = "MainForm"
        Text = "Form1"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ContextMenuStrip.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents ExitTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents HelpContextMenuItem As ToolStripMenuItem
    Friend WithEvents AboutContextMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox As GroupBox
End Class
