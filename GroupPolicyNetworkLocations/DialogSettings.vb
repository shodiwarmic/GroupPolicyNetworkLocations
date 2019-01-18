Imports System.DirectoryServices
Imports System.Windows.Forms
Imports GPMGMTLib
Imports System.IO
Imports System.IO.Compression

Public Class DialogSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ComboBoxGroupPolicies_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxGroupPolicies.SelectedValueChanged
        Try
            If ComboBoxGroupPolicies.SelectedValue.GetType = Type.GetType("System.String") Then
                TextBoxGroupPolicyUID.Text = ComboBoxGroupPolicies.SelectedValue.ToString
            End If
        Catch
            TextBoxGroupPolicyUID.Clear()
        End Try
    End Sub

    Private Sub ButtonNoMADHomeSharesAddOption_Click(sender As Object, e As EventArgs) Handles ButtonNoMADHomeSharesAddOption.Click
        If DialogAddOption.ShowDialog() = DialogResult.OK Then
            Dim NewOption As String = DialogAddOption.ComboBoxOptionList.SelectedItem("Option").ToString
            If Not ListBoxNoMADHomeSharesOptions.Items.Contains(NewOption) Then
                ListBoxNoMADHomeSharesOptions.Items.Add(NewOption)
            End If
        End If
    End Sub

    Private Sub ButtonNoMADDefaultsAddOption_Click(sender As Object, e As EventArgs) Handles ButtonNoMADDefaultsAddOption.Click
        If DialogAddOption.ShowDialog() = DialogResult.OK Then
            Dim NewOption As String = DialogAddOption.ComboBoxOptionList.SelectedItem("Option").ToString
            If Not ListBoxNoMADDefaultsOptions.Items.Contains(NewOption) Then
                ListBoxNoMADDefaultsOptions.Items.Add(NewOption)
            End If
        End If
    End Sub

    Private Sub ButtonNoMADHomeSharesDeleteOption_Click(sender As Object, e As EventArgs) Handles ButtonNoMADHomeSharesDeleteOption.Click
        ListBoxNoMADHomeSharesOptions.Items.Remove(ListBoxNoMADHomeSharesOptions.SelectedItem)
    End Sub

    Private Sub ButtonNoMADDefaultsDeleteOption_Click(sender As Object, e As EventArgs) Handles ButtonNoMADDefaultsDeleteOption.Click
        ListBoxNoMADDefaultsOptions.Items.Remove(ListBoxNoMADDefaultsOptions.SelectedItem)
    End Sub

    Private Sub ButtonNoMADHomeShareAddGroup_Click(sender As Object, e As EventArgs) Handles ButtonNoMADHomeShareAddGroup.Click
        If GroupPolicyNetworkLocations.ADPicker.ShowDialog = DialogResult.OK Then
            For Each SelectedObject In GroupPolicyNetworkLocations.ADPicker.SelectedObjects
                ListBoxNoMADHomeSharesGroups.Items.Add(SelectedObject.Name)
            Next
        End If
    End Sub

    Private Sub ButtonNoMADHomeSharesDeleteGroup_Click(sender As Object, e As EventArgs) Handles ButtonNoMADHomeSharesDeleteGroup.Click
        ListBoxNoMADHomeSharesGroups.Items.Remove(ListBoxNoMADHomeSharesGroups.SelectedItem)
    End Sub

    Private Sub CheckBoxAllGroups_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAllGroups.CheckedChanged
        ListBoxNoMADHomeSharesGroups.Enabled = Not CheckBoxAllGroups.Checked
        ButtonNoMADHomeShareAddGroup.Enabled = Not CheckBoxAllGroups.Checked
        ButtonNoMADHomeSharesDeleteGroup.Enabled = Not CheckBoxAllGroups.Checked

        If CheckBoxAllGroups.Checked Then
            ListBoxNoMADHomeSharesGroups.Items.Clear()
            ListBoxNoMADHomeSharesGroups.Items.Add("All")
        Else
            ListBoxNoMADHomeSharesGroups.Items.Remove("All")
        End If
    End Sub

    Private Sub ButtonCreateNewPolicy_Click(sender As Object, e As EventArgs) Handles ButtonCreateNewPolicy.Click
        If DialogNewPolicy.ShowDialog() = DialogResult.OK Then
            Dim strGPOName As String = DialogNewPolicy.TextBoxPolicyName.Text
            Dim strBackupID As String = "{81002162-2BD8-4088-9B10-A626FBF65A90}"

            Dim gpm As New GPM
            Dim gpc As GPMConstants = gpm.GetConstants
            Dim gpd As GPMDomain = gpm.GetDomain(GroupPolicyNetworkLocations.strDomainName, "", gpc.UseAnyDC)

            Dim policy As GPMGPO = gpd.CreateGPO()
            policy.DisplayName = strGPOName

            Dim strGPOBackupPath As String = Environment.GetEnvironmentVariable("TEMP") + "\NewGPO\"

            If (Directory.Exists(strGPOBackupPath)) Then
                Directory.Delete(strGPOBackupPath, True)
                Do While Directory.Exists(strGPOBackupPath)
                    Threading.Thread.Sleep(500)
                Loop
            End If

            If (Not Directory.Exists(strGPOBackupPath)) Then
                Directory.CreateDirectory(strGPOBackupPath)
            End If

            File.WriteAllBytes(strGPOBackupPath + "\SampleGPO.zip", My.Resources.SampleGPO)

            ZipFile.ExtractToDirectory(strGPOBackupPath + "\SampleGPO.zip", strGPOBackupPath)

            Dim policyBackupDir As GPMBackupDir = gpm.GetBackupDir(strGPOBackupPath + "\SampleGPO")
            Dim policyBackup As GPMBackup = policyBackupDir.GetBackup(strBackupID)

            policy.Import(0, policyBackup)

            GroupPolicyNetworkLocations.RefreshPolicyList()

            ComboBoxGroupPolicies.SelectedValue = policy.ID
        End If
    End Sub
End Class
