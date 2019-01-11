# Group Policy Network Locations Editor

I started this project to make it easier for my team and I to change Network Locations deployed by group policy.

Each Network Location requires four policy items in three categories
- 2 IniFile settings (User Configuration>Preferences>Windows Settings>IniFiles)
- 1 Folder setting (User Configuration>Preferences>Windows Settings>Folders)
- 1 Shortcut setting (User Configuration>Preferences>Windows Settings>Shortcuts)

In order to use this program you must create at least one setting for each of these using the group policy management console for your desired policy object, otherwise the settings made here will not be reflected in the policy.

See [Getting Started](https://github.com/jperryNPS/GroupPolicyNetworkLocations/wiki/Getting-Started) in the [Wiki](https://github.com/jperryNPS/GroupPolicyNetworkLocations/wiki) for more info.

If you have any questions, suggestion, tips, or contributions please let me know.

You can see more about Network Locations here: http://bartdesmet.net/blogs/bart/archive/2005/09/23/3554.aspx

Inspiration for this application was found here: https://community.spiceworks.com/topic/681289-how-get-unc-network-drive-to-appear-under-computer-in-windows-explorer
