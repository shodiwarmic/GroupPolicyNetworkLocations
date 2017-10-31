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

End Class
