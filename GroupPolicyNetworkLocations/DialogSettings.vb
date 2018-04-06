Imports System.DirectoryServices
Imports System.Windows.Forms

Public Class DialogSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ComboBoxGroupPolicies_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxGroupPolicies.SelectedValueChanged
        Try
            If ComboBoxGroupPolicies.SelectedValue.GetType = System.Type.GetType("System.String") Then
                TextBoxGroupPolicyUID.Text = ComboBoxGroupPolicies.SelectedValue.ToString
            End If
        Catch
            TextBoxGroupPolicyUID.Clear()
        End Try
    End Sub

    Private Sub ButtonNoMADHomeSharesAddOption_Click(sender As Object, e As EventArgs) Handles ButtonNoMADHomeSharesAddOption.Click
        Dim result As DialogResult = DialogAddOption.ShowDialog()
        If result = DialogResult.OK Then
            Dim NewOption As String = DialogAddOption.ComboBoxOptionList.SelectedItem("Option").ToString
            If Not ListBoxNoMADHomeSharesOptions.Items.Contains(NewOption) Then
                ListBoxNoMADHomeSharesOptions.Items.Add(NewOption)
            End If
        End If
    End Sub

    Private Sub ButtonNoMADDefaultsAddOption_Click(sender As Object, e As EventArgs) Handles ButtonNoMADDefaultsAddOption.Click
        Dim result As DialogResult = DialogAddOption.ShowDialog()
        If result = DialogResult.OK Then
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
End Class
