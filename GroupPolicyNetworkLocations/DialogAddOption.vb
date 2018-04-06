Imports System.Windows.Forms

Public Class DialogAddOption

    Dim TableOptions As New DataTable
    Dim boolTableLoaded As Boolean = False


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ComboBoxOptionList_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxOptionList.SelectedValueChanged
        LabelDescription.Text = ComboBoxOptionList.SelectedValue.ToString
    End Sub

    Private Sub DialogAddOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not boolTableLoaded Then
            TableOptions.Columns.Add("Option", GetType(String))
            TableOptions.Columns.Add("Description", GetType(String))

            TableOptions.Rows.Add("MNT_RDONLY", "Mounts the share read only")
            TableOptions.Rows.Add("MNT_SYNCHRONOUS", "All I/O to the file system should be done synchronously")
            TableOptions.Rows.Add("MNT_NOEXEC", "Prohibts execution of code from the share")
            TableOptions.Rows.Add("MNT_NOSUID", "Do not allow set-user-identifier or set-group-identifier bits to take effect")
            TableOptions.Rows.Add("MNT_NODEV", "Do not interpret character or block special devices on the file system")
            TableOptions.Rows.Add("MNT_UNION", "Causes the namespace to appear as the union of directories of the mounted filesystem with corresponding directories in the underlying filesystem")
            TableOptions.Rows.Add("MNT_ASYNC", "All I/O to the file system should be done asynchronously")
            TableOptions.Rows.Add("MNT_CPROTECT", "")
            TableOptions.Rows.Add("MNT_EXPORTED", "Filesystem is exported")
            TableOptions.Rows.Add("MNT_QUARANTINE", "File system is quarantined")
            TableOptions.Rows.Add("MNT_LOCAL", "File system is stored locally")
            TableOptions.Rows.Add("MNT_QUOTA", "Quotas are enabled")
            TableOptions.Rows.Add("MNT_ROOTFS", "Identifies the root filesystem")
            TableOptions.Rows.Add("MNT_DOVOLFS", "Filesystem supports volfs (deprecated flag in Mac OS X 10.5)")
            TableOptions.Rows.Add("MNT_DONTBROWSE", "Does not display the share in the Finder")
            TableOptions.Rows.Add("MNT_IGNORE_OWNERSHIP", "Ignore ownership information on file system objects")
            TableOptions.Rows.Add("MNT_AUTOMOUNTED", "Set flags on the mountpoint to indicate that the volume has been mounted by the automounter")
            TableOptions.Rows.Add("MNT_JOURNALED", "Mount filesystem journaled")
            TableOptions.Rows.Add("MNT_NOUSERXATTR", "User extended attributes not allowed")
            TableOptions.Rows.Add("MNT_DEFWRITE", "Filesystem should defer writes")
            TableOptions.Rows.Add("MNT_MULTILABEL", "Support for individual labels")
            TableOptions.Rows.Add("MNT_NOATIME", "Do not update the file access time when reading from a file")

            ComboBoxOptionList.DataSource = TableOptions
            ComboBoxOptionList.DisplayMember = "Option"
            ComboBoxOptionList.ValueMember = "Description"

            boolTableLoaded = True
        End If

    End Sub
End Class
