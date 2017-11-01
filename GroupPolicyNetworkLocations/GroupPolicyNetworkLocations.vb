
Imports System.Xml
Imports System.DirectoryServices
Imports Tulpep.ActiveDirectoryObjectPicker
Imports System.Text
Imports System.IO
Imports Microsoft.Win32

Public Class GroupPolicyNetworkLocations

    ' ******************************************************* '
    ' *           Global Constants Declared Below           * '
    ' ******************************************************* '

    ' Used in Ini Folder and Shortcut
    Const ShareImage = "2"
    Const ShareUserContext = "1"
    Const ShareBypassErrors = "1"

    ' Used in Ini Folder and Shortcut Properties
    Const SharePropAction = "U"

    ' Used in Ini 1 and 2
    Const IniClsid = "{EEFACE84-D3D8-4680-8D4B-BF103E759448}"

    ' Used in Ini 1
    Const Ini1Name = "CLSID2"
    Const Ini1Status = Ini1Name

    ' Used in Ini 2
    Const Ini2Name = "Flags"
    Const Ini2Status = Ini2Name

    ' Used in Ini Properties 1 and 2
    Const IniPropPath1 = "%APPDATA%\Microsoft\Windows\Network Shortcuts\"
    Const IniPropPath3 = "\desktop.ini"
    Const IniPropSection = ".ShellClassInfo"

    ' Used in Ini Properties 1
    Const Ini1PropValue = "{0AFACED1-E828-11D1-9187-B532F1E9575D}"
    Const Ini1PropProperty = "CLSID2"

    ' Used in Ini Properties 2
    Const Ini2PropValue = "2"
    Const Ini2PropProperty = "Flags"

    ' Used in Folder
    Const FolderClsid = "{07DA02F5-F9CD-4397-A550-4AE21B6B4BD3}"
    Const FolderDisabled = "0"

    ' Used in Folder Properties
    Const FolderPropDeleteFolder = "0"
    Const FolderPropDeleteSubFolders = "0"
    Const FolderPropDeleteFiles = "0"
    Const FolderPropDeleteReadOnly = "0"
    Const FolderPropDeleteIgnoreErrors = "0"
    Const FolderPropPath1 = "%APPDATA%\Microsoft\Windows\Network Shortcuts\"
    Const FolderPropReadOnly = "1"
    Const FolderPropArchive = "0"
    Const FolderPropHidden = "0"

    ' Used in Shortcut
    Const ShortcutClsid = "{4F2F7C55-2790-433e-8127-0739D1CFA327}"
    Const ShortcutName = "target"
    Const ShortcutStatus = "target"

    ' Used in Shortcut Properties
    Const ShortcutPropPid1 = ""
    Const ShortcutPropTargetType = "FILESYSTEM"
    Const ShortcutPropComment = ""
    Const ShortcutPropShortcutKey = "0"
    Const ShortcutPropStartIn = ""
    Const ShortcutPropArguments = ""
    Const ShortcutPropIconIndex = "0"
    Const ShortcutPropIconPath = ""
    Const ShortcutPropWindow = ""
    Const ShortcutPropShortcutPath1 = "%APPDATA%\Microsoft\Windows\Network Shortcuts\"
    Const ShortcutPropShortcutPath3 = "\target"

    ' Used in FilterGroup
    Const FilterGroupBool = "OR"
    Const FilterGroupNot = "0"
    Const FilterGroupUserContext = "1"
    Const FilterGroupPrimaryGroup = "0"
    Const FilterGroupLocalGroup = "0"

    ' ******************************************************* '
    ' *           Global Variables Declared Below           * '
    ' ******************************************************* '

    ' Use the Active Directory domain that the computer is joined to
    Dim objDomain As ActiveDirectory.Domain = ActiveDirectory.Domain.GetComputerDomain()
    Dim strDomainName As String = objDomain.Name

    Dim regUserSettings As RegistryKey
    Dim XMLIniFiles, XMLFolders, XMLShortcuts As New XmlDocument()
    Dim tableNetworkLocations, tableFilterGroups, tableGroupPolicies As New DataTable()
    Dim ADPicker As New DirectoryObjectPickerDialog
    Dim changesSaved As Boolean = True
    Dim strGPUID, strGPPath, strIniFilesXML, strFoldersXML, strShortcutsXML As String

    Private Sub MakeDataTables()

        ' Temporary column variable declaration
        Dim column As DataColumn

        ' Creates a data table that looks something like this for storing variables related to the share folders
        ' -------------------------------------------------------------------------------------------------
        ' |    ShareName    | ShareTarget | Last Modified | Ini1UID | Ini2UID | FoldersUID | ShortcutsUID |
        ' |-----------------|-------------|---------------|---------|---------|------------|--------------|
        ' | * Unique String |   String    |   DateTime    | String  | String  |   String   |    String    |
        ' -------------------------------------------------------------------------------------------------

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "ShareName"
        column.ReadOnly = False
        column.Unique = True
        tableNetworkLocations.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "ShareTarget"
        column.ReadOnly = False
        column.Unique = False
        tableNetworkLocations.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.DateTime")
        column.ColumnName = "LastModified"
        column.ReadOnly = False
        column.Unique = False
        tableNetworkLocations.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Ini1UID"
        column.ReadOnly = False
        column.Unique = False
        tableNetworkLocations.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Ini2UID"
        column.ReadOnly = False
        column.Unique = False
        tableNetworkLocations.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "FoldersUID"
        column.ReadOnly = False
        column.Unique = False
        tableNetworkLocations.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "ShortcutsUID"
        column.ReadOnly = False
        column.Unique = False
        tableNetworkLocations.Columns.Add(column)

        ' Creates a data table that looks something like this for storing Share folder and Filter Group connections
        ' ------------------------------------
        ' | ShareName | GroupName | GroupSID |
        ' |-----------|-----------|----------|
        ' |  String   |  String   |  String  |
        ' ------------------------------------

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "ShareName"
        column.ReadOnly = False
        column.Unique = False
        tableFilterGroups.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "GroupName"
        column.ReadOnly = False
        column.Unique = False
        tableFilterGroups.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "GroupSID"
        column.ReadOnly = False
        column.Unique = False
        tableFilterGroups.Columns.Add(column)

        ' Creates a data table that looks something like this for storing a list of Group Policy Objects in the domain
        ' -----------------------------------------------------------------------------------
        ' |   PolicyGUID    | PolicyName | IniFilesExists | FoldersExists | ShortcutsExists |
        ' |-----------------|------------|----------------|---------------|-----------------|
        ' | * Unique String |   String   |    Boolean     |    Boolean    |     Boolean     |
        ' -----------------------------------------------------------------------------------


        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "PolicyGUID"
        column.ReadOnly = False
        column.Unique = True
        tableGroupPolicies.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "PolicyName"
        column.ReadOnly = False
        column.Unique = False
        tableGroupPolicies.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Boolean")
        column.ColumnName = "IniFilesExists"
        column.ReadOnly = False
        column.Unique = False
        tableGroupPolicies.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Boolean")
        column.ColumnName = "FoldersExists"
        column.ReadOnly = False
        column.Unique = False
        tableGroupPolicies.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Boolean")
        column.ColumnName = "ShortcutsExists"
        column.ReadOnly = False
        column.Unique = False
        tableGroupPolicies.Columns.Add(column)

        ' Temporary primary key column
        Dim PrimaryKeyColumns(0) As DataColumn

        ' Set primary key to ShareName for Network Locations table
        PrimaryKeyColumns(0) = tableNetworkLocations.Columns("ShareName")
        tableNetworkLocations.PrimaryKey = PrimaryKeyColumns

        ' Set primary key to PolicyGUID for Group Policy table
        PrimaryKeyColumns(0) = tableGroupPolicies.Columns("PolicyGUID")
        tableGroupPolicies.PrimaryKey = PrimaryKeyColumns
    End Sub

    Private Sub RefreshView()
        If ListBoxShareNames.SelectedItems.Count <> 1 Or tableNetworkLocations.Rows.Count = 0 Then
            ' Clear all fields if there is not ONLY ONE item selected, or if there are no items available to select
            TextBoxIni1UID.Clear()
            TextBoxIni2UID.Clear()
            TextBoxFoldersUID.Clear()
            TextBoxShortcutsUID.Clear()
            TextBoxLastModified.Clear()
            TextBoxLocationName.Clear()
            TextBoxTargetPath.Clear()
            ' Then quit trying to update the view, there's nothing to update from
            Exit Sub
        End If

        ' Set the filter for the table so that the Gridview only shows group for the selected share
        tableFilterGroups.DefaultView.RowFilter = String.Format("ShareName = '{0}'", ListBoxShareNames.SelectedValue)
        DataGridViewGroups.AutoResizeColumns()

        ' Find the rows where the share name matches the selected share (There should only be one)
        Dim rows() As DataRow = tableNetworkLocations.Select(String.Format("ShareName = '{0}'", ListBoxShareNames.SelectedValue.ToString))
        If rows.Count > 0 Then
            ' If a row is found set the form fields based on the values in that row
            TextBoxIni1UID.Text = rows(0)("Ini1UID").ToString
            TextBoxIni2UID.Text = rows(0)("Ini2UID").ToString
            TextBoxFoldersUID.Text = rows(0)("FoldersUID").ToString
            TextBoxShortcutsUID.Text = rows(0)("ShortcutsUID").ToString
            TextBoxLastModified.Text = rows(0)("LastModified").ToString
            TextBoxLocationName.Text = rows(0)("ShareName").ToString
            TextBoxTargetPath.Text = rows(0)("ShareTarget").ToString
        Else
            ' If no row is found, blank the form fields
            TextBoxIni1UID.Clear()
            TextBoxIni2UID.Clear()
            TextBoxFoldersUID.Clear()
            TextBoxShortcutsUID.Clear()
            TextBoxLastModified.Clear()
            TextBoxLocationName.Clear()
            TextBoxTargetPath.Clear()
        End If
    End Sub

    Private Sub LaunchSettings()
        ' Check if policies have changed
        RefreshPolicyList()

        ' Set the settings dropdown list to show the found policy names, but return the guid of the selected policy
        DialogSettings.ComboBoxGroupPolicies.DataSource = tableGroupPolicies
        DialogSettings.ComboBoxGroupPolicies.DisplayMember = "PolicyName"
        DialogSettings.ComboBoxGroupPolicies.ValueMember = "PolicyGUID"

        ' Preselect the current policy, if there is one
        If strGPUID <> Nothing And strGPUID <> String.Empty Then DialogSettings.ComboBoxGroupPolicies.SelectedValue = strGPUID

        ' Show the dialog, but only make changes if OK is pressed
        If DialogSettings.ShowDialog() = DialogResult.OK Then

            strGPUID = DialogSettings.ComboBoxGroupPolicies.SelectedValue
            strGPPath = "\\" + strDomainName + "\SYSVOL\" + strDomainName + "\Policies\" + strGPUID + "\User\Preferences"

            ' Save this to the registry for the next time the program is openned
            regUserSettings.SetValue("GPUID", strGPUID)

            ' Set the Policy Name and GUID text boxes on the main form
            TextBoxPolicyName.Text = tableGroupPolicies.Select(String.Format("PolicyGUID = '{0}'", strGPUID))(0)("PolicyName")
            TextBoxPolicyGUID.Text = strGPUID

            ' Load the policy preferences from the XML Files
            ReloadData()
        End If
    End Sub

    Private Sub MakeXMLStrings()
        ' This whole thing is a mess, but it works. I'm open to suggestions.

        ' Initialize temporary string builders
        Dim sbIniFilesXML, sbFoldersXML, sbShortcutsXML As New StringBuilder()

        ' Start with the standard xml definition
        sbIniFilesXML.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")
        sbFoldersXML.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")
        sbShortcutsXML.AppendLine("<?xml version=""1.0"" encoding=""utf-8""?>")

        ' Open up the XML with the main group
        sbIniFilesXML.AppendLine("<IniFiles clsid=""{694C651A-08F2-47fa-A427-34C4F62BA207}"">")
        sbFoldersXML.AppendLine("<Folders clsid=""{77CC39E7-3D16-4f8f-AF86-EC0BBEE2C861}"">")
        sbShortcutsXML.AppendLine("<Shortcuts clsid=""{872ECB34-B2EC-401b-A585-D32574AA90EE}"">")

        ' Run through all of the shares in the table
        For Each shareRow In tableNetworkLocations.Rows

            ' This is really obnoxious to look at, and I pretty much hate myself for doing it this way.
            ' The above comment applies to specifically the next 13 lines and this program in general.
            sbIniFilesXML.AppendLine(String.Format("  <Ini clsid=""{0}"" name=""{1}"" status=""{2}"" image=""{3}"" changed=""{4:yyyy-MM-dd HH:mm:ss}"" uid=""{5}"" userContext=""{6}"" bypassErrors=""{7}"">",
                                                       IniClsid, Ini1Name, Ini1Status, ShareImage, shareRow("LastModified"), shareRow("Ini1UID"), ShareUserContext, ShareBypassErrors))
            sbFoldersXML.AppendLine(String.Format("  <Folder clsid=""{0}"" name=""{1}"" status=""{2}"" image=""{3}"" changed=""{4:yyyy-MM-dd HH:mm:ss}"" uid=""{5}"" disabled=""{6}"" userContext=""{7}"" bypassErrors=""{8}"">",
                                                           FolderClsid, shareRow("ShareName"), shareRow("ShareName"), ShareImage, shareRow("LastModified"), shareRow("FoldersUID"), FolderDisabled, ShareUserContext, ShareBypassErrors))
            sbShortcutsXML.AppendLine(String.Format("  <Shortcut clsid=""{0}"" name=""{1}"" status=""{2}"" image=""{3}"" changed=""{4:yyyy-MM-dd HH:mm:ss}"" uid=""{5}"" userContext=""{6}"" bypassErrors=""{7}"">",
                                                    ShortcutClsid, ShortcutName, ShortcutStatus, ShareImage, shareRow("LastModified"), shareRow("ShortcutsUID"), ShareUserContext, ShareBypassErrors))

            sbIniFilesXML.AppendLine(String.Format("    <Properties path=""{0}{1}{2}"" section=""{3}"" value=""{4}"" property=""{5}"" action=""{6}""/>",
                                               IniPropPath1, shareRow("ShareName"), IniPropPath3, IniPropSection, Ini1PropValue, Ini1PropProperty, SharePropAction))
            sbFoldersXML.AppendLine(String.Format("    <Properties deleteFolder=""{0}"" deleteSubFolders=""{1}"" deleteFiles=""{2}"" deleteReadOnly=""{3}"" deleteIgnoreErrors=""{4}"" action=""{5}"" path=""{6}{7}"" readOnly=""{8}"" archive=""{9}"" hidden=""{10}""/>",
                                                 FolderPropDeleteFolder, FolderPropDeleteSubFolders, FolderPropDeleteFiles, FolderPropDeleteReadOnly, FolderPropDeleteIgnoreErrors, SharePropAction, FolderPropPath1, shareRow("ShareName"), FolderPropReadOnly, FolderPropArchive, FolderPropHidden))
            sbShortcutsXML.AppendLine(String.Format("    <Properties pidl=""{0}"" targetType=""{1}"" action=""{2}"" comment=""{3}"" shortcutKey=""{4}"" startIn=""{5}"" arguments=""{6}"" iconIndex=""{7}"" targetPath=""{8}"" iconPath=""{9}"" window=""{10}"" shortcutPath=""{11}{12}{13}""/>",
                                                   ShortcutPropPid1, ShortcutPropTargetType, SharePropAction, ShortcutPropComment, ShortcutPropShortcutKey, ShortcutPropStartIn, ShortcutPropArguments, ShortcutPropIconIndex, shareRow("ShareTarget"), ShortcutPropIconPath, ShortcutPropWindow, ShortcutPropShortcutPath1, shareRow("ShareName"), ShortcutPropShortcutPath3))

            ' Group for filters.
            ' TODO: Maybe check to see if there are any filters before just throwing them in there...
            sbIniFilesXML.AppendLine("    <Filters>")
            sbFoldersXML.AppendLine("    <Filters>")
            sbShortcutsXML.AppendLine("    <Filters>")

            Dim i As Integer = 1 ' A counter, even though I only need to know which is the first
            For Each groupRow In tableFilterGroups.Select(String.Format("ShareName = '{0}'", shareRow("ShareName")))
                Dim strBool As String = "AND"
                If i > 1 Then strBool = FilterGroupBool ' The first filter is always AND
                ' Create a string, because all of them get the same thing
                Dim strFilterGroup As String = String.Format("      <FilterGroup bool=""{0}"" not=""{1}"" name=""{2}"" sid=""{3}"" userContext=""{4}"" primaryGroup=""{5}"" localGroup=""{6}""/>",
                                                             strBool, FilterGroupNot, groupRow("GroupName"), groupRow("GroupSID"), FilterGroupUserContext, FilterGroupPrimaryGroup, FilterGroupLocalGroup)
                ' Write it to all of them
                sbIniFilesXML.AppendLine(strFilterGroup)
                sbFoldersXML.AppendLine(strFilterGroup)
                sbShortcutsXML.AppendLine(strFilterGroup)

                i += 1 ' Increase the counter
            Next

            ' Close filter group
            sbIniFilesXML.AppendLine("    </Filters>")
            sbFoldersXML.AppendLine("    </Filters>")
            sbShortcutsXML.AppendLine("    </Filters>")

            ' close the groups
            sbIniFilesXML.AppendLine("  </Ini>")
            sbFoldersXML.AppendLine("  </Folder>")
            sbShortcutsXML.AppendLine("  </Shortcut>")

            ' Do it again for the second IniFile setting
            sbIniFilesXML.AppendLine(String.Format("  <Ini clsid=""{0}"" name=""{1}"" status=""{2}"" image=""{3}"" changed=""{4:yyyy-MM-dd HH:mm:ss}"" uid=""{5}"" userContext=""{6}"" bypassErrors=""{7}"">",
                                                       IniClsid, Ini2Name, Ini2Status, ShareImage, shareRow("LastModified"), shareRow("Ini2UID"), ShareUserContext, ShareBypassErrors))
            sbIniFilesXML.AppendLine(String.Format("    <Properties path=""{0}{1}{2}"" section=""{3}"" value=""{4}"" property=""{5}"" action=""{6}""/>",
                                               IniPropPath1, shareRow("ShareName"), IniPropPath3, IniPropSection, Ini2PropValue, Ini2PropProperty, SharePropAction))
            sbIniFilesXML.AppendLine("    <Filters>")
            i = 1
            For Each groupRow In tableFilterGroups.Select(String.Format("ShareName = '{0}'", shareRow("ShareName")))
                Dim strBool As String = "AND"
                If i > 1 Then strBool = "OR"
                Dim strFilterGroup As String = String.Format("      <FilterGroup bool=""{0}"" not=""0"" name=""{1}"" sid=""{2}"" userContext=""1"" primaryGroup=""0"" localGroup=""0""/>",
                                                             strBool, groupRow("GroupName"), groupRow("GroupSID"))
                sbIniFilesXML.AppendLine(strFilterGroup)
                i += 1
            Next
            sbIniFilesXML.AppendLine("    </Filters>")
            sbIniFilesXML.AppendLine("  </Ini>")
        Next

        ' Close the main group
        sbIniFilesXML.AppendLine("</IniFiles>")
        sbFoldersXML.AppendLine("</Folders>")
        sbShortcutsXML.AppendLine("</Shortcuts>")

        ' Write the values to strings
        strIniFilesXML = sbIniFilesXML.ToString
        strFoldersXML = sbFoldersXML.ToString
        strShortcutsXML = sbShortcutsXML.ToString
    End Sub

    Private Sub ReloadData()

        ' Clear out the tables
        tableNetworkLocations.Clear()
        tableFilterGroups.Clear()

        If File.Exists(strGPPath + "\IniFiles\IniFiles.xml") Then
            ' Load the file if it exists
            XMLIniFiles.Load(strGPPath + "\IniFiles\IniFiles.xml")
            For Each Ini As XmlNode In XMLIniFiles.SelectNodes("/IniFiles/Ini")
                ' Get values from Ini Items
                Dim strUID As String = Ini.Attributes("uid").Value
                Dim timeModified As DateTime = Ini.Attributes("changed").Value
                Dim strIniProp As String = Ini.Attributes("name").Value
                Dim strPath As String = Ini.SelectSingleNode("Properties").Attributes("path").Value
                Dim arrPath() As String = strPath.Split("\")
                Dim strShareName As String
                If arrPath.Count >= 2 Then
                    strShareName = arrPath(arrPath.Count - 2)
                Else
                    strShareName = arrPath(0)
                End If
                Dim strRowName As String
                ' Determine which Ini item to use
                If strIniProp = "CLSID2" Then
                    strRowName = "Ini1UID"
                ElseIf strIniProp = "Flags" Then
                    strRowName = "Ini2UID"
                End If
                If Not strRowName Is Nothing Then
                    Dim row As DataRow
                    ' Add data to row
                    Try
                        row = tableNetworkLocations.Select(String.Format("ShareName = '{0}'", strShareName))(0)
                        row(strRowName) = strUID.ToUpper
                        ' Only update time modified if it is later
                        If timeModified > row("LastModified") Then row("LastModified") = timeModified
                    Catch
                        ' Row doesn't exist, create it now
                        row = tableNetworkLocations.NewRow
                        row("ShareName") = strShareName
                        row(strRowName) = strUID.ToUpper
                        row("LastModified") = timeModified
                        tableNetworkLocations.Rows.Add(row)
                    End Try
                    If Ini.ChildNodes.Count > 1 Then
                        ' Add all Filters to filter table
                        For Each FilterGroup As XmlNode In Ini.SelectSingleNode("Filters").SelectNodes("FilterGroup")
                            Dim strGroupName As String = FilterGroup.Attributes("name").Value
                            Dim strGroupSID As String = FilterGroup.Attributes("sid").Value
                            Try
                                row = tableFilterGroups.Select(String.Format("ShareName = '{0}' And GroupName = '{1}' And GroupSID = '{2}'", strShareName, strGroupName, strGroupSID))(0)
                            Catch
                                row = tableFilterGroups.NewRow
                                row("ShareName") = strShareName
                                row("GroupName") = strGroupName
                                row("GroupSID") = strGroupSID
                                tableFilterGroups.Rows.Add(row)
                            End Try
                        Next
                    End If
                End If
            Next
        End If

        If File.Exists(strGPPath + "\Folders\Folders.xml") Then
            XMLFolders.Load(strGPPath + "\Folders\Folders.xml")
            For Each Folder As XmlNode In XMLFolders.SelectNodes("/Folders/Folder")
                Dim strUID As String = Folder.Attributes("uid").Value
                Dim timeModified As DateTime = Folder.Attributes("changed").Value
                Dim strShareName As String = Folder.Attributes("name").Value
                Dim row As DataRow
                ' Add data to row
                Try
                    row = tableNetworkLocations.Select(String.Format("ShareName = '{0}'", strShareName))(0)
                    row("FoldersUID") = strUID.ToUpper
                    ' Only update time modified if it is later
                    If timeModified > row("LastModified") Then row("LastModified") = timeModified
                Catch
                    ' Row doesn't exist, create it now
                    row = tableNetworkLocations.NewRow
                    row("ShareName") = strShareName
                    row("FoldersUID") = strUID.ToUpper
                    row("LastModified") = timeModified
                    tableNetworkLocations.Rows.Add(row)
                End Try
                ' Add all Filters to filter table
                If Folder.ChildNodes.Count > 1 Then
                    For Each FilterGroup As XmlNode In Folder.SelectSingleNode("Filters").SelectNodes("FilterGroup")
                        Dim strGroupName As String = FilterGroup.Attributes("name").Value
                        Dim strGroupSID As String = FilterGroup.Attributes("sid").Value
                        Try
                            row = tableFilterGroups.Select(String.Format("ShareName = '{0}' And GroupName = '{1}' And GroupSID = '{2}'", strShareName, strGroupName, strGroupSID))(0)
                        Catch
                            row = tableFilterGroups.NewRow
                            row("ShareName") = strShareName
                            row("GroupName") = strGroupName
                            row("GroupSID") = strGroupSID
                            tableFilterGroups.Rows.Add(row)
                        End Try
                    Next
                End If
            Next
        End If

        If File.Exists(strGPPath + "\Shortcuts\Shortcuts.xml") Then
            XMLShortcuts.Load(strGPPath + "\Shortcuts\Shortcuts.xml")
            For Each Shortcut As XmlNode In XMLShortcuts.SelectNodes("/Shortcuts/Shortcut")
                Dim strUID As String = Shortcut.Attributes("uid").Value
                Dim timeModified As DateTime = Shortcut.Attributes("changed").Value
                Dim strTargetPath As String = Shortcut.SelectSingleNode("Properties").Attributes("targetPath").Value
                Dim strPath As String = Shortcut.SelectSingleNode("Properties").Attributes("shortcutPath").Value
                Dim arrPath() As String = strPath.Split("\")
                Dim strShareName As String
                If arrPath.Count >= 2 Then
                    strShareName = arrPath(arrPath.Count - 2)
                Else
                    strShareName = arrPath(0)
                End If
                Dim row As DataRow
                ' Add data to row
                Try
                    row = tableNetworkLocations.Select(String.Format("ShareName = '{0}'", strShareName))(0)
                    row("ShortcutsUID") = strUID.ToUpper
                    row("ShareTarget") = strTargetPath
                    ' Only update time modified if it is later
                    If timeModified > row("LastModified") Then row("LastModified") = timeModified
                Catch
                    ' Row doesn't exist, create it now
                    row = tableNetworkLocations.NewRow
                    row("ShareName") = strShareName
                    row("ShortcutsUID") = strUID.ToUpper
                    row("ShareTarget") = strTargetPath
                    row("LastModified") = timeModified
                    tableNetworkLocations.Rows.Add(row)
                End Try
                ' Add all Filters to filter table
                If Shortcut.ChildNodes.Count > 1 Then
                    For Each FilterGroup As XmlNode In Shortcut.SelectSingleNode("Filters").SelectNodes("FilterGroup")
                        Dim strGroupName As String = FilterGroup.Attributes("name").Value
                        Dim strGroupSID As String = FilterGroup.Attributes("sid").Value
                        Try
                            row = tableFilterGroups.Select(String.Format("ShareName = '{0}' And GroupName = '{1}' And GroupSID = '{2}'", strShareName, strGroupName, strGroupSID))(0)
                        Catch
                            row = tableFilterGroups.NewRow
                            row("ShareName") = strShareName
                            row("GroupName") = strGroupName
                            row("GroupSID") = strGroupSID
                            tableFilterGroups.Rows.Add(row)
                        End Try
                    Next
                End If
            Next
        End If

        ' Run through the table and create any missing UIDs
        For Each row In tableNetworkLocations.Rows
            If row("Ini1UID").ToString.Length = 0 Then row("Ini1UID") = "{" + Guid.NewGuid.ToString.ToUpper + "}"
            If row("Ini2UID").ToString.Length = 0 Then row("Ini2UID") = "{" + Guid.NewGuid.ToString.ToUpper + "}"
            If row("FoldersUID").ToString.Length = 0 Then row("FoldersUID") = "{" + Guid.NewGuid.ToString.ToUpper + "}"
            If row("ShortcutsUID").ToString.Length = 0 Then row("ShortcutsUID") = "{" + Guid.NewGuid.ToString.ToUpper + "}"
        Next

        ' Set listbox source
        tableNetworkLocations.DefaultView.Sort = "ShareName ASC"
        ListBoxShareNames.DataSource = tableNetworkLocations
        ListBoxShareNames.DisplayMember = "ShareName"
        ListBoxShareNames.ValueMember = "ShareName"

        ' Set source for data grid view and filter
        DataGridViewGroups.DataSource = tableFilterGroups
        tableFilterGroups.DefaultView.RowFilter = String.Format("ShareName = '{0}'", ListBoxShareNames.SelectedValue)
        DataGridViewGroups.Columns("ShareName").Visible = False
        DataGridViewGroups.AutoResizeColumns()

        ' Load info into form
        RefreshView()

    End Sub

    Private Sub RefreshPolicyList()
        ' Remove any old polices from the table
        tableGroupPolicies.Clear()

        ' Populate the group policy table with all group policies in the domain
        Using searcher = New DirectorySearcher(objDomain.GetDirectoryEntry, "(&(objectClass=groupPolicyContainer))", {"displayName", "name"}, SearchScope.Subtree)
            Dim results As SearchResultCollection = searcher.FindAll
            For Each result As SearchResult In results
                Dim directoryEntry As DirectoryEntry = result.GetDirectoryEntry
                Dim row As DataRow
                Try
                    row = tableGroupPolicies.Select(String.Format("PolicyGUID = '{0}'", directoryEntry.Properties("name").Value))(0)
                Catch
                    row = tableGroupPolicies.NewRow
                    Dim strTempGPPath As String = "\\" + strDomainName + "\SYSVOL\" + strDomainName + "\Policies\" + directoryEntry.Properties("name").Value + "\User\Preferences"
                    row("PolicyGUID") = directoryEntry.Properties("name").Value
                    row("PolicyName") = directoryEntry.Properties("displayName").Value
                    ' Check if the needed group policy settings files already exist
                    row("IniFilesExists") = File.Exists(strTempGPPath + "\IniFiles\IniFiles.xml")
                    row("FoldersExists") = File.Exists(strTempGPPath + "\Folders\Folders.xml")
                    row("ShortcutsExists") = File.Exists(strTempGPPath + "\Shortcuts\Shortcuts.xml")
                    tableGroupPolicies.Rows.Add(row)
                End Try
            Next
        End Using

        tableGroupPolicies.DefaultView.RowFilter = "IniFilesExists = TRUE AND FoldersExists = TRUE AND ShortcutsExists = TRUE"
        tableGroupPolicies.DefaultView.Sort = "PolicyName ASC"
    End Sub

    Private Sub GroupPolicyNetworkLocations_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not changesSaved Then
            ' Ask if they really want to quit, their changes haven't been saved
            If MessageBox.Show("Are you sure you want to quit?" + vbCrLf + "Your changes will Not be saved.", "Are you sure?", MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub GroupPolicyNetworkLocations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set preferences for AD Object picker
        ADPicker.AllowedObjectTypes = ObjectTypes.Groups
        ADPicker.DefaultObjectTypes = ObjectTypes.Groups
        ADPicker.AllowedLocations = Locations.JoinedDomain
        ADPicker.DefaultLocations = Locations.JoinedDomain

        ' Create the data tables
        MakeDataTables()

        ' Load list of all policies in domain
        RefreshPolicyList()

        ' Open the registry settings for the application
        regUserSettings = Registry.CurrentUser.OpenSubKey("Software\GroupPolicyNetworkLocations", True)

        If regUserSettings Is Nothing Then
            ' Create the registry settings if they do not exist
            regUserSettings = Registry.CurrentUser.CreateSubKey("Software\GroupPolicyNetworkLocations")
        ElseIf strGPUID Is Nothing Or strGPUID = String.Empty Then
            Try
                ' Attempt to set the current policy guid from the registry
                strGPUID = regUserSettings.GetValue("GPUID").ToString()
                strGPPath = "\\" + strDomainName + "\SYSVOL\" + strDomainName + "\Policies\" + strGPUID + "\User\Preferences"
                TextBoxPolicyName.Text = tableGroupPolicies.Select(String.Format("PolicyGUID = '{0}'", strGPUID))(0)("PolicyName")
                TextBoxPolicyGUID.Text = strGPUID
            Catch
            End Try
        Else
            ' Set the registry setting to the current policy UID
            regUserSettings.SetValue("GPUID", strGPUID)
        End If

        Do While strGPUID Is Nothing Or strGPUID = String.Empty
            ' Force user to select a group policy
            LaunchSettings()
            If strGPUID Is Nothing Or strGPUID = String.Empty Then
                MessageBox.Show("You must select a group policy on your first launch.", "First Launch", MessageBoxButtons.OK)
            End If
        Loop

        ' Load data from the group policy
        ReloadData()

    End Sub

    Private Sub ListBoxShareNames_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBoxShareNames.SelectedValueChanged
        ' Load share information
        RefreshView()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ButtonDiscardChanges_Click(sender As Object, e As EventArgs) Handles ButtonDiscardChanges.Click
        Dim rows() As DataRow = tableNetworkLocations.Select(String.Format("ShareName = '{0}'", ListBoxShareNames.SelectedValue.ToString))
        If rows.Count > 0 Then
            ' Reset to values in data table
            TextBoxLocationName.Text = rows(0)("ShareName")
            TextBoxTargetPath.Text = rows(0)("ShareTarget")
        Else
            ' Clear values, share not found
            TextBoxLocationName.Clear()
            TextBoxTargetPath.Clear()
        End If
    End Sub

    Private Sub ButtonSaveChanges_Click(sender As Object, e As EventArgs) Handles ButtonSaveChanges.Click
        Dim rows() As DataRow = tableNetworkLocations.Select(String.Format("ShareName = '{0}'", ListBoxShareNames.SelectedValue.ToString))
        If rows.Count > 0 Then
            If rows(0)("ShareTarget") <> TextBoxTargetPath.Text.ToString Then
                ' Update ShareTarget only if it changed
                rows(0)("ShareTarget") = TextBoxTargetPath.Text.ToString
                rows(0)("LastModified") = Now
                changesSaved = False
            End If
            If rows(0)("ShareName") <> TextBoxLocationName.Text.ToString Then
                ' Update ShareName only if it changed
                Dim groupRows() As DataRow = tableFilterGroups.Select(String.Format("ShareName = '{0}'", ListBoxShareNames.SelectedValue.ToString))
                If groupRows.Count > 0 Then
                    For Each row As DataRow In groupRows
                        ' Update the ShareName for all filter Groups as well
                        row("ShareName") = TextBoxLocationName.Text.ToString
                    Next
                End If
                rows(0)("ShareName") = TextBoxLocationName.Text.ToString
                rows(0)("LastModified") = Now
                changesSaved = False
            End If
        End If
    End Sub

    Private Sub ButtonAddNewShare_Click(sender As Object, e As EventArgs) Handles ButtonAddNewShare.Click
        Dim boolRetry As Boolean = True
        While boolRetry
            ' Show the new share dialog
            Dim result As DialogResult = DialogNewShare.ShowDialog()
            If result = DialogResult.OK Then
                ' Only add if OK is pressed
                Dim newShareName As String = DialogNewShare.TextBoxShareName.Text
                Dim newSharePath As String = DialogNewShare.TextBoxSharePath.Text
                If newShareName.Trim.Length > 0 And newSharePath.Trim.Length > 0 Then
                    ' Only add if Share Name and Path are populated with non-blank strings
                    Dim rows() As DataRow = tableNetworkLocations.Select(String.Format("ShareName = '{0}'", newShareName))
                    If rows.Count > 0 Then
                        If Not MsgBox("A share with this name already exists." + vbCrLf + "Would you like to try again?", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
                            ' No pressed, don't show the dialog again
                            boolRetry = False
                        End If
                    Else
                        ' Add the row with new UIDs
                        Dim row As DataRow = tableNetworkLocations.NewRow
                        row("ShareName") = newShareName
                        row("ShareTarget") = newSharePath
                        row("LastModified") = Now
                        row("Ini1UID") = "{" + Guid.NewGuid.ToString.ToUpper + "}"
                        row("Ini2UID") = "{" + Guid.NewGuid.ToString.ToUpper + "}"
                        row("FoldersUID") = "{" + Guid.NewGuid.ToString.ToUpper + "}"
                        row("ShortcutsUID") = "{" + Guid.NewGuid.ToString.ToUpper + "}"
                        tableNetworkLocations.Rows.Add(row)
                        ListBoxShareNames.Update()
                        ListBoxShareNames.SelectedValue = newShareName
                        RefreshView()
                        changesSaved = False
                        ' Row added, don't show the dialog again
                        boolRetry = False
                    End If
                Else
                    If Not MsgBox("Both Share Name and Share Path are required." + vbCrLf + "Would you like to try again?", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
                        ' No pressed, don't show the dialog again
                        boolRetry = False
                    End If
                End If
            Else
                ' Cancel pressed, don't show the dialog again
                boolRetry = False
            End If
        End While
        ' Clear New Share Dialog's text boxes
        DialogNewShare.TextBoxShareName.Clear()
        DialogNewShare.TextBoxSharePath.Clear()
    End Sub

    Private Sub ButtonDeleteShare_Click(sender As Object, e As EventArgs) Handles ButtonDeleteShare.Click
        Dim rows() As DataRow = tableNetworkLocations.Select(String.Format("ShareName = '{0}'", ListBoxShareNames.SelectedValue.ToString))
        If rows.Count > 0 Then
            ' You can only delete a row that exists
            If MsgBox("Are you sure you want to delete the share " + ListBoxShareNames.SelectedValue.ToString + "?" + vbCrLf + "This action can not be undone.", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
                ' Yes pressed, apparently they want to delete this row.
                Dim groupRows() As DataRow = tableFilterGroups.Select(String.Format("ShareName = '{0}'", ListBoxShareNames.SelectedValue.ToString))
                If groupRows.Count > 0 Then
                    For Each row As DataRow In groupRows
                        ' Also delete all rows in the filters that have this share name
                        tableFilterGroups.Rows.Remove(row)
                    Next
                End If
                ' Actually delete the row
                tableNetworkLocations.Rows.Remove(rows(0))

                changesSaved = False

                ' Clear form data
                TextBoxLastModified.Clear()
                TextBoxFoldersUID.Clear()
                TextBoxIni1UID.Clear()
                TextBoxIni2UID.Clear()
                TextBoxShortcutsUID.Clear()
                TextBoxLocationName.Clear()
                TextBoxTargetPath.Clear()

                ' reload form data
                RefreshView()
            End If
        End If

    End Sub

    Private Sub ButtonAddGroup_Click(sender As Object, e As EventArgs) Handles ButtonAddGroup.Click
        If ADPicker.ShowDialog = DialogResult.OK Then
            For Each SelectedObject In ADPicker.SelectedObjects
                Dim objGroup As DirectoryEntry = New DirectoryEntry(SelectedObject.Path)
                Dim strNP1, strNP2 As String
                For Each part In objGroup.Properties.Item("distinguishedName").Value.ToString.Split(",")
                    ' Use distinguishedName to find group name with short domain name
                    If part.StartsWith("CN=") And strNP2 Is Nothing Then
                        strNP2 = part.Remove(0, 3)
                    ElseIf part.StartsWith("DC=") And strNP1 Is Nothing Then
                        strNP1 = part.Remove(0, 3)
                    End If
                    If strNP2 <> Nothing And strNP1 <> Nothing Then Exit For
                Next
                Dim strShareName As String = ListBoxShareNames.SelectedValue.ToString
                Dim strGroupName As String = strNP1.ToUpper + "\" + strNP2
                Dim strGroupSID As String = (New Security.Principal.SecurityIdentifier(objGroup.Properties.Item("objectSid").Value, 0)).Value
                Dim groupRow As DataRow
                ' Add the row if it doesn't already exist
                Try
                    groupRow = tableFilterGroups.Select(String.Format("ShareName = '{0}' And GroupName = '{1}' And GroupSID = '{2}'", strShareName, strGroupName, strGroupSID))(0)
                Catch
                    groupRow = tableFilterGroups.NewRow
                    groupRow("ShareName") = strShareName
                    groupRow("GroupName") = strGroupName
                    groupRow("GroupSID") = strGroupSID
                    tableFilterGroups.Rows.Add(groupRow)
                    Dim rows() As DataRow = tableNetworkLocations.Select(String.Format("ShareName = '{0}'", ListBoxShareNames.SelectedValue.ToString))
                    rows(0)("LastModified") = Now
                    changesSaved = False
                End Try

            Next
        End If
    End Sub

    Private Sub GenerateXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateXMLToolStripMenuItem.Click
        ' Populate xml strings
        MakeXMLStrings()

        ' Populate xml objects from strings
        XMLIniFiles.LoadXml(strIniFilesXML)
        XMLFolders.LoadXml(strFoldersXML)
        XMLShortcuts.LoadXml(strShortcutsXML)

        ' Create folder if it doesn't already exist (the group policy will likely not work if this is the case)
        If Not Directory.Exists(strGPPath + "\IniFiles") Then Directory.CreateDirectory(strGPPath + "\IniFiles")
        If Not Directory.Exists(strGPPath + "\Folders") Then Directory.CreateDirectory(strGPPath + "\Folders")
        If Not Directory.Exists(strGPPath + "\Shortcuts") Then Directory.CreateDirectory(strGPPath + "\Shortcuts")

        ' Create the file if it does not exist (the group policy will likely not work if this is the case)
        If Not File.Exists(strGPPath + "\IniFiles\IniFiles.xml") Then File.Create(strGPPath + "\IniFiles\IniFiles.xml").Dispose()
        If Not File.Exists(strGPPath + "\Folders\Folders.xml") Then File.Create(strGPPath + "\Folders\Folders.xml").Dispose()
        If Not File.Exists(strGPPath + "\Shortcuts\Shortcuts.xml") Then File.Create(strGPPath + "\Shortcuts\Shortcuts.xml").Dispose()

        ' Save the xml objects to the files
        XMLIniFiles.Save(strGPPath + "\IniFiles\IniFiles.xml")
        XMLFolders.Save(strGPPath + "\Folders\Folders.xml")
        XMLShortcuts.Save(strGPPath + "\Shortcuts\Shortcuts.xml")

        ' Show saved message
        MsgBox("Changes saved to Group Policy.")
        changesSaved = True
    End Sub

    Private Sub ReadFromGroupPolicyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadFromGroupPolicyToolStripMenuItem.Click
        ' TODO: Prompt about saving changes if necessary

        ' Reload data from policy xml files
        ReloadData()
        changesSaved = True
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        LaunchSettings()
    End Sub

    Private Sub ButtonDeleteGroup_Click(sender As Object, e As EventArgs) Handles ButtonDeleteGroup.Click
        Dim strShareName As String = DataGridViewGroups.SelectedRows(0).Cells("ShareName").Value
        Dim strGroupName As String = DataGridViewGroups.SelectedRows(0).Cells("GroupName").Value
        Dim strGroupSID As String = DataGridViewGroups.SelectedRows(0).Cells("GroupSID").Value
        Dim groupRow As DataRow = tableFilterGroups.Select(String.Format("ShareName = '{0}' And GroupName = '{1}' And GroupSID = '{2}'", strShareName, strGroupName, strGroupSID))(0)
        ' Remove group from table
        tableFilterGroups.Rows.Remove(groupRow)
        Dim rows() As DataRow = tableNetworkLocations.Select(String.Format("ShareName = '{0}'", ListBoxShareNames.SelectedValue.ToString))
        ' Update share modified time
        rows(0)("LastModified") = Now
        changesSaved = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub
End Class
