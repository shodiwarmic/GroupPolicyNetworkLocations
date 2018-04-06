<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogSettings
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxGroupPolicyUID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxGroupPolicies = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBoxNoMADHomeSharesOptions = New System.Windows.Forms.ListBox()
        Me.ButtonNoMADHomeSharesDeleteOption = New System.Windows.Forms.Button()
        Me.ButtonNoMADHomeSharesAddOption = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonNoMADHomeSharesDeleteGroup = New System.Windows.Forms.Button()
        Me.ButtonNoMADHomeShareAddGroup = New System.Windows.Forms.Button()
        Me.ListBoxNoMADHomeSharesGroups = New System.Windows.Forms.ListBox()
        Me.CheckBoxNoMADHomeShareAutoMount = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBoxNoMADDefaultsOptions = New System.Windows.Forms.ListBox()
        Me.ButtonNoMADDefaultsDeleteOption = New System.Windows.Forms.Button()
        Me.ButtonNoMADDefaultsAddOption = New System.Windows.Forms.Button()
        Me.CheckBoxNoMADDefaultsAutoMount = New System.Windows.Forms.CheckBox()
        Me.CheckBoxNoMADDefaultsConnectedOnly = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAllGroups = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(260, 230)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Group Policy UID"
        '
        'TextBoxGroupPolicyUID
        '
        Me.TextBoxGroupPolicyUID.Enabled = False
        Me.TextBoxGroupPolicyUID.Location = New System.Drawing.Point(101, 34)
        Me.TextBoxGroupPolicyUID.Name = "TextBoxGroupPolicyUID"
        Me.TextBoxGroupPolicyUID.Size = New System.Drawing.Size(298, 20)
        Me.TextBoxGroupPolicyUID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Group Policy"
        '
        'ComboBoxGroupPolicies
        '
        Me.ComboBoxGroupPolicies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGroupPolicies.FormattingEnabled = True
        Me.ComboBoxGroupPolicies.Location = New System.Drawing.Point(101, 6)
        Me.ComboBoxGroupPolicies.Name = "ComboBoxGroupPolicies"
        Me.ComboBoxGroupPolicies.Size = New System.Drawing.Size(298, 21)
        Me.ComboBoxGroupPolicies.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(420, 224)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBoxGroupPolicyUID)
        Me.TabPage1.Controls.Add(Me.ComboBoxGroupPolicies)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(412, 198)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Group Policy"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.CheckBoxNoMADHomeShareAutoMount)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(412, 198)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "NoMAD HomeShare"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBoxNoMADHomeSharesOptions)
        Me.GroupBox2.Controls.Add(Me.ButtonNoMADHomeSharesDeleteOption)
        Me.GroupBox2.Controls.Add(Me.ButtonNoMADHomeSharesAddOption)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 162)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'ListBoxNoMADHomeSharesOptions
        '
        Me.ListBoxNoMADHomeSharesOptions.FormattingEnabled = True
        Me.ListBoxNoMADHomeSharesOptions.Location = New System.Drawing.Point(6, 16)
        Me.ListBoxNoMADHomeSharesOptions.Name = "ListBoxNoMADHomeSharesOptions"
        Me.ListBoxNoMADHomeSharesOptions.Size = New System.Drawing.Size(177, 108)
        Me.ListBoxNoMADHomeSharesOptions.TabIndex = 2
        '
        'ButtonNoMADHomeSharesDeleteOption
        '
        Me.ButtonNoMADHomeSharesDeleteOption.Location = New System.Drawing.Point(98, 130)
        Me.ButtonNoMADHomeSharesDeleteOption.Name = "ButtonNoMADHomeSharesDeleteOption"
        Me.ButtonNoMADHomeSharesDeleteOption.Size = New System.Drawing.Size(85, 23)
        Me.ButtonNoMADHomeSharesDeleteOption.TabIndex = 1
        Me.ButtonNoMADHomeSharesDeleteOption.Text = "Delete Option"
        Me.ButtonNoMADHomeSharesDeleteOption.UseVisualStyleBackColor = True
        '
        'ButtonNoMADHomeSharesAddOption
        '
        Me.ButtonNoMADHomeSharesAddOption.Location = New System.Drawing.Point(6, 130)
        Me.ButtonNoMADHomeSharesAddOption.Name = "ButtonNoMADHomeSharesAddOption"
        Me.ButtonNoMADHomeSharesAddOption.Size = New System.Drawing.Size(85, 23)
        Me.ButtonNoMADHomeSharesAddOption.TabIndex = 0
        Me.ButtonNoMADHomeSharesAddOption.Text = "Add Option"
        Me.ButtonNoMADHomeSharesAddOption.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxAllGroups)
        Me.GroupBox1.Controls.Add(Me.ButtonNoMADHomeSharesDeleteGroup)
        Me.GroupBox1.Controls.Add(Me.ButtonNoMADHomeShareAddGroup)
        Me.GroupBox1.Controls.Add(Me.ListBoxNoMADHomeSharesGroups)
        Me.GroupBox1.Location = New System.Drawing.Point(203, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 185)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Groups"
        '
        'ButtonNoMADHomeSharesDeleteGroup
        '
        Me.ButtonNoMADHomeSharesDeleteGroup.Location = New System.Drawing.Point(104, 152)
        Me.ButtonNoMADHomeSharesDeleteGroup.Name = "ButtonNoMADHomeSharesDeleteGroup"
        Me.ButtonNoMADHomeSharesDeleteGroup.Size = New System.Drawing.Size(90, 23)
        Me.ButtonNoMADHomeSharesDeleteGroup.TabIndex = 2
        Me.ButtonNoMADHomeSharesDeleteGroup.Text = "Delete Group"
        Me.ButtonNoMADHomeSharesDeleteGroup.UseVisualStyleBackColor = True
        '
        'ButtonNoMADHomeShareAddGroup
        '
        Me.ButtonNoMADHomeShareAddGroup.Location = New System.Drawing.Point(6, 153)
        Me.ButtonNoMADHomeShareAddGroup.Name = "ButtonNoMADHomeShareAddGroup"
        Me.ButtonNoMADHomeShareAddGroup.Size = New System.Drawing.Size(90, 23)
        Me.ButtonNoMADHomeShareAddGroup.TabIndex = 1
        Me.ButtonNoMADHomeShareAddGroup.Text = "Add Group"
        Me.ButtonNoMADHomeShareAddGroup.UseVisualStyleBackColor = True
        '
        'ListBoxNoMADHomeSharesGroups
        '
        Me.ListBoxNoMADHomeSharesGroups.FormattingEnabled = True
        Me.ListBoxNoMADHomeSharesGroups.Location = New System.Drawing.Point(6, 38)
        Me.ListBoxNoMADHomeSharesGroups.Name = "ListBoxNoMADHomeSharesGroups"
        Me.ListBoxNoMADHomeSharesGroups.Size = New System.Drawing.Size(188, 108)
        Me.ListBoxNoMADHomeSharesGroups.TabIndex = 0
        '
        'CheckBoxNoMADHomeShareAutoMount
        '
        Me.CheckBoxNoMADHomeShareAutoMount.AutoSize = True
        Me.CheckBoxNoMADHomeShareAutoMount.Location = New System.Drawing.Point(8, 6)
        Me.CheckBoxNoMADHomeShareAutoMount.Name = "CheckBoxNoMADHomeShareAutoMount"
        Me.CheckBoxNoMADHomeShareAutoMount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxNoMADHomeShareAutoMount.Size = New System.Drawing.Size(81, 17)
        Me.CheckBoxNoMADHomeShareAutoMount.TabIndex = 0
        Me.CheckBoxNoMADHomeShareAutoMount.Text = "Auto Mount"
        Me.CheckBoxNoMADHomeShareAutoMount.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CheckBoxNoMADDefaultsConnectedOnly)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.CheckBoxNoMADDefaultsAutoMount)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(412, 198)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "NoMAD Defaults"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBoxNoMADDefaultsOptions)
        Me.GroupBox3.Controls.Add(Me.ButtonNoMADDefaultsDeleteOption)
        Me.GroupBox3.Controls.Add(Me.ButtonNoMADDefaultsAddOption)
        Me.GroupBox3.Location = New System.Drawing.Point(217, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 186)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'ListBoxNoMADDefaultsOptions
        '
        Me.ListBoxNoMADDefaultsOptions.FormattingEnabled = True
        Me.ListBoxNoMADDefaultsOptions.Location = New System.Drawing.Point(6, 16)
        Me.ListBoxNoMADDefaultsOptions.Name = "ListBoxNoMADDefaultsOptions"
        Me.ListBoxNoMADDefaultsOptions.Size = New System.Drawing.Size(177, 134)
        Me.ListBoxNoMADDefaultsOptions.TabIndex = 2
        '
        'ButtonNoMADDefaultsDeleteOption
        '
        Me.ButtonNoMADDefaultsDeleteOption.Location = New System.Drawing.Point(98, 157)
        Me.ButtonNoMADDefaultsDeleteOption.Name = "ButtonNoMADDefaultsDeleteOption"
        Me.ButtonNoMADDefaultsDeleteOption.Size = New System.Drawing.Size(85, 23)
        Me.ButtonNoMADDefaultsDeleteOption.TabIndex = 1
        Me.ButtonNoMADDefaultsDeleteOption.Text = "Delete Option"
        Me.ButtonNoMADDefaultsDeleteOption.UseVisualStyleBackColor = True
        '
        'ButtonNoMADDefaultsAddOption
        '
        Me.ButtonNoMADDefaultsAddOption.Location = New System.Drawing.Point(6, 157)
        Me.ButtonNoMADDefaultsAddOption.Name = "ButtonNoMADDefaultsAddOption"
        Me.ButtonNoMADDefaultsAddOption.Size = New System.Drawing.Size(85, 23)
        Me.ButtonNoMADDefaultsAddOption.TabIndex = 0
        Me.ButtonNoMADDefaultsAddOption.Text = "Add Option"
        Me.ButtonNoMADDefaultsAddOption.UseVisualStyleBackColor = True
        '
        'CheckBoxNoMADDefaultsAutoMount
        '
        Me.CheckBoxNoMADDefaultsAutoMount.AutoSize = True
        Me.CheckBoxNoMADDefaultsAutoMount.Location = New System.Drawing.Point(8, 6)
        Me.CheckBoxNoMADDefaultsAutoMount.Name = "CheckBoxNoMADDefaultsAutoMount"
        Me.CheckBoxNoMADDefaultsAutoMount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxNoMADDefaultsAutoMount.Size = New System.Drawing.Size(81, 17)
        Me.CheckBoxNoMADDefaultsAutoMount.TabIndex = 3
        Me.CheckBoxNoMADDefaultsAutoMount.Text = "Auto Mount"
        Me.CheckBoxNoMADDefaultsAutoMount.UseVisualStyleBackColor = True
        '
        'CheckBoxNoMADDefaultsConnectedOnly
        '
        Me.CheckBoxNoMADDefaultsConnectedOnly.AutoSize = True
        Me.CheckBoxNoMADDefaultsConnectedOnly.Location = New System.Drawing.Point(8, 29)
        Me.CheckBoxNoMADDefaultsConnectedOnly.Name = "CheckBoxNoMADDefaultsConnectedOnly"
        Me.CheckBoxNoMADDefaultsConnectedOnly.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxNoMADDefaultsConnectedOnly.Size = New System.Drawing.Size(102, 17)
        Me.CheckBoxNoMADDefaultsConnectedOnly.TabIndex = 5
        Me.CheckBoxNoMADDefaultsConnectedOnly.Text = "Connected Only"
        Me.CheckBoxNoMADDefaultsConnectedOnly.UseVisualStyleBackColor = True
        '
        'CheckBoxAllGroups
        '
        Me.CheckBoxAllGroups.AutoSize = True
        Me.CheckBoxAllGroups.Location = New System.Drawing.Point(7, 15)
        Me.CheckBoxAllGroups.Name = "CheckBoxAllGroups"
        Me.CheckBoxAllGroups.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxAllGroups.TabIndex = 3
        Me.CheckBoxAllGroups.Text = "All Groups"
        Me.CheckBoxAllGroups.UseVisualStyleBackColor = True
        '
        'DialogSettings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(418, 271)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Group Policy Network Locations Editor"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxGroupPolicyUID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxGroupPolicies As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CheckBoxNoMADHomeShareAutoMount As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonNoMADHomeSharesDeleteOption As Button
    Friend WithEvents ButtonNoMADHomeSharesAddOption As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonNoMADHomeSharesDeleteGroup As Button
    Friend WithEvents ButtonNoMADHomeShareAddGroup As Button
    Friend WithEvents ListBoxNoMADHomeSharesGroups As ListBox
    Friend WithEvents ListBoxNoMADHomeSharesOptions As ListBox
    Friend WithEvents CheckBoxNoMADDefaultsConnectedOnly As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListBoxNoMADDefaultsOptions As ListBox
    Friend WithEvents ButtonNoMADDefaultsDeleteOption As Button
    Friend WithEvents ButtonNoMADDefaultsAddOption As Button
    Friend WithEvents CheckBoxNoMADDefaultsAutoMount As CheckBox
    Friend WithEvents CheckBoxAllGroups As CheckBox
End Class
