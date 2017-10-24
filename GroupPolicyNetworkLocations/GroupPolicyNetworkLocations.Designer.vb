<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GroupPolicyNetworkLocations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroupPolicyNetworkLocations))
        Me.ListBoxShareNames = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadFromGroupPolicyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxIni1UID = New System.Windows.Forms.TextBox()
        Me.TextBoxFoldersUID = New System.Windows.Forms.TextBox()
        Me.TextBoxShortcutsUID = New System.Windows.Forms.TextBox()
        Me.ButtonAddNewShare = New System.Windows.Forms.Button()
        Me.ButtonDeleteShare = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewGroups = New System.Windows.Forms.DataGridView()
        Me.ButtonAddGroup = New System.Windows.Forms.Button()
        Me.ButtonDeleteGroup = New System.Windows.Forms.Button()
        Me.TextBoxLastModified = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxIni2UID = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonSaveChanges = New System.Windows.Forms.Button()
        Me.ButtonDiscardChanges = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxTargetPath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxLocationName = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPolicyName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxPolicyGUID = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxShareNames
        '
        Me.ListBoxShareNames.FormattingEnabled = True
        Me.ListBoxShareNames.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxShareNames.Name = "ListBoxShareNames"
        Me.ListBoxShareNames.Size = New System.Drawing.Size(172, 394)
        Me.ListBoxShareNames.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReadFromGroupPolicyToolStripMenuItem, Me.GenerateXMLToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ReadFromGroupPolicyToolStripMenuItem
        '
        Me.ReadFromGroupPolicyToolStripMenuItem.Name = "ReadFromGroupPolicyToolStripMenuItem"
        Me.ReadFromGroupPolicyToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ReadFromGroupPolicyToolStripMenuItem.Text = "Read from Group Policy"
        '
        'GenerateXMLToolStripMenuItem
        '
        Me.GenerateXMLToolStripMenuItem.Name = "GenerateXMLToolStripMenuItem"
        Me.GenerateXMLToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.GenerateXMLToolStripMenuItem.Text = "Save to Group Policy"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.QuitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ini1 UID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Folders UID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Shortcuts UID"
        '
        'TextBoxIni1UID
        '
        Me.TextBoxIni1UID.Enabled = False
        Me.TextBoxIni1UID.Location = New System.Drawing.Point(95, 19)
        Me.TextBoxIni1UID.Name = "TextBoxIni1UID"
        Me.TextBoxIni1UID.Size = New System.Drawing.Size(321, 20)
        Me.TextBoxIni1UID.TabIndex = 5
        '
        'TextBoxFoldersUID
        '
        Me.TextBoxFoldersUID.Enabled = False
        Me.TextBoxFoldersUID.Location = New System.Drawing.Point(95, 72)
        Me.TextBoxFoldersUID.Name = "TextBoxFoldersUID"
        Me.TextBoxFoldersUID.Size = New System.Drawing.Size(321, 20)
        Me.TextBoxFoldersUID.TabIndex = 6
        '
        'TextBoxShortcutsUID
        '
        Me.TextBoxShortcutsUID.Enabled = False
        Me.TextBoxShortcutsUID.Location = New System.Drawing.Point(95, 98)
        Me.TextBoxShortcutsUID.Name = "TextBoxShortcutsUID"
        Me.TextBoxShortcutsUID.Size = New System.Drawing.Size(321, 20)
        Me.TextBoxShortcutsUID.TabIndex = 7
        '
        'ButtonAddNewShare
        '
        Me.ButtonAddNewShare.Location = New System.Drawing.Point(6, 419)
        Me.ButtonAddNewShare.Name = "ButtonAddNewShare"
        Me.ButtonAddNewShare.Size = New System.Drawing.Size(83, 23)
        Me.ButtonAddNewShare.TabIndex = 8
        Me.ButtonAddNewShare.Text = "Add Share"
        Me.ButtonAddNewShare.UseVisualStyleBackColor = True
        '
        'ButtonDeleteShare
        '
        Me.ButtonDeleteShare.Location = New System.Drawing.Point(95, 419)
        Me.ButtonDeleteShare.Name = "ButtonDeleteShare"
        Me.ButtonDeleteShare.Size = New System.Drawing.Size(83, 23)
        Me.ButtonDeleteShare.TabIndex = 9
        Me.ButtonDeleteShare.Text = "Delete Share"
        Me.ButtonDeleteShare.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewGroups)
        Me.GroupBox1.Controls.Add(Me.ButtonAddGroup)
        Me.GroupBox1.Controls.Add(Me.ButtonDeleteGroup)
        Me.GroupBox1.Location = New System.Drawing.Point(184, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 160)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deployed Groups"
        '
        'DataGridViewGroups
        '
        Me.DataGridViewGroups.AllowUserToAddRows = False
        Me.DataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewGroups.Location = New System.Drawing.Point(7, 19)
        Me.DataGridViewGroups.Name = "DataGridViewGroups"
        Me.DataGridViewGroups.ReadOnly = True
        Me.DataGridViewGroups.RowHeadersVisible = False
        Me.DataGridViewGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewGroups.Size = New System.Drawing.Size(406, 106)
        Me.DataGridViewGroups.TabIndex = 13
        '
        'ButtonAddGroup
        '
        Me.ButtonAddGroup.Location = New System.Drawing.Point(210, 131)
        Me.ButtonAddGroup.Name = "ButtonAddGroup"
        Me.ButtonAddGroup.Size = New System.Drawing.Size(100, 23)
        Me.ButtonAddGroup.TabIndex = 12
        Me.ButtonAddGroup.Text = "Add Group"
        Me.ButtonAddGroup.UseVisualStyleBackColor = True
        '
        'ButtonDeleteGroup
        '
        Me.ButtonDeleteGroup.Location = New System.Drawing.Point(316, 131)
        Me.ButtonDeleteGroup.Name = "ButtonDeleteGroup"
        Me.ButtonDeleteGroup.Size = New System.Drawing.Size(100, 23)
        Me.ButtonDeleteGroup.TabIndex = 11
        Me.ButtonDeleteGroup.Text = "Delete Group"
        Me.ButtonDeleteGroup.UseVisualStyleBackColor = True
        '
        'TextBoxLastModified
        '
        Me.TextBoxLastModified.Enabled = False
        Me.TextBoxLastModified.Location = New System.Drawing.Point(279, 19)
        Me.TextBoxLastModified.Name = "TextBoxLastModified"
        Me.TextBoxLastModified.Size = New System.Drawing.Size(321, 20)
        Me.TextBoxLastModified.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Last Modified"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxIni2UID)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxIni1UID)
        Me.GroupBox2.Controls.Add(Me.TextBoxFoldersUID)
        Me.GroupBox2.Controls.Add(Me.TextBoxShortcutsUID)
        Me.GroupBox2.Location = New System.Drawing.Point(184, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 124)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Unique IDs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Ini2 UID"
        '
        'TextBoxIni2UID
        '
        Me.TextBoxIni2UID.Enabled = False
        Me.TextBoxIni2UID.Location = New System.Drawing.Point(95, 46)
        Me.TextBoxIni2UID.Name = "TextBoxIni2UID"
        Me.TextBoxIni2UID.Size = New System.Drawing.Size(321, 20)
        Me.TextBoxIni2UID.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonSaveChanges)
        Me.GroupBox3.Controls.Add(Me.ButtonDiscardChanges)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBoxTargetPath)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBoxLocationName)
        Me.GroupBox3.Location = New System.Drawing.Point(185, 175)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 101)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Location Information"
        '
        'ButtonSaveChanges
        '
        Me.ButtonSaveChanges.Location = New System.Drawing.Point(209, 72)
        Me.ButtonSaveChanges.Name = "ButtonSaveChanges"
        Me.ButtonSaveChanges.Size = New System.Drawing.Size(100, 23)
        Me.ButtonSaveChanges.TabIndex = 5
        Me.ButtonSaveChanges.Text = "Save Changes"
        Me.ButtonSaveChanges.UseVisualStyleBackColor = True
        '
        'ButtonDiscardChanges
        '
        Me.ButtonDiscardChanges.Location = New System.Drawing.Point(315, 72)
        Me.ButtonDiscardChanges.Name = "ButtonDiscardChanges"
        Me.ButtonDiscardChanges.Size = New System.Drawing.Size(100, 23)
        Me.ButtonDiscardChanges.TabIndex = 4
        Me.ButtonDiscardChanges.Text = "Discard Changes"
        Me.ButtonDiscardChanges.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Location Target"
        '
        'TextBoxTargetPath
        '
        Me.TextBoxTargetPath.Location = New System.Drawing.Point(94, 46)
        Me.TextBoxTargetPath.Name = "TextBoxTargetPath"
        Me.TextBoxTargetPath.Size = New System.Drawing.Size(321, 20)
        Me.TextBoxTargetPath.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Location Name"
        '
        'TextBoxLocationName
        '
        Me.TextBoxLocationName.Location = New System.Drawing.Point(94, 20)
        Me.TextBoxLocationName.Name = "TextBoxLocationName"
        Me.TextBoxLocationName.Size = New System.Drawing.Size(321, 20)
        Me.TextBoxLocationName.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.ListBoxShareNames)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.ButtonAddNewShare)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.ButtonDeleteShare)
        Me.GroupBox4.Controls.Add(Me.TextBoxLastModified)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(612, 448)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Network Locations"
        '
        'TextBoxPolicyName
        '
        Me.TextBoxPolicyName.Enabled = False
        Me.TextBoxPolicyName.Location = New System.Drawing.Point(84, 28)
        Me.TextBoxPolicyName.Name = "TextBoxPolicyName"
        Me.TextBoxPolicyName.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxPolicyName.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Policy Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Policy GUID"
        '
        'TextBoxPolicyGUID
        '
        Me.TextBoxPolicyGUID.Enabled = False
        Me.TextBoxPolicyGUID.Location = New System.Drawing.Point(318, 28)
        Me.TextBoxPolicyGUID.Name = "TextBoxPolicyGUID"
        Me.TextBoxPolicyGUID.Size = New System.Drawing.Size(294, 20)
        Me.TextBoxPolicyGUID.TabIndex = 20
        '
        'GroupPolicyNetworkLocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(636, 514)
        Me.Controls.Add(Me.TextBoxPolicyGUID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxPolicyName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GroupPolicyNetworkLocations"
        Me.Text = "Group Policy Network Locations Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxShareNames As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxIni1UID As TextBox
    Friend WithEvents TextBoxFoldersUID As TextBox
    Friend WithEvents TextBoxShortcutsUID As TextBox
    Friend WithEvents ButtonAddNewShare As Button
    Friend WithEvents ButtonDeleteShare As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonAddGroup As Button
    Friend WithEvents ButtonDeleteGroup As Button
    Friend WithEvents DataGridViewGroups As DataGridView
    Friend WithEvents TextBoxLastModified As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxTargetPath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxLocationName As TextBox
    Friend WithEvents ButtonSaveChanges As Button
    Friend WithEvents ButtonDiscardChanges As Button
    Friend WithEvents GenerateXMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxIni2UID As TextBox
    Friend WithEvents ReadFromGroupPolicyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBoxPolicyName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxPolicyGUID As TextBox
End Class
