# UAC Bypass Using eventvwr.exe and Registry Hijacking

This technique differs from the other public techniques by having a few handy benefits::

 * This technique does not require dropping a traditional file to the file system. Most (if not all) public UAC bypasses currently require dropping a file (typically a DLL) to the file system. Doing so increases the risk of the attacker getting caught. Since this technique doesn’t drop a traditional file, that extra risk to the attacker is mitigated.
 
 
 * This technique does not require any process injection, meaning the attack won’t get flagged by security solutions that monitor for this type of behavior. 


 * There is no privileged file copy required. Most UAC bypasses require some sort of privileged file copy in order to get a malicious DLL into a secure location to setup a DLL hijack. Since it is possible to replace what executable “eventvwr.exe” starts to load the required Snap-in, it is possible to simply use an existing, trusted Microsoft binary to execute code in memory instead.


This particular technique can be remediated or fixed by setting the UAC level to “Always Notify” or by removing the current user from the Local Administrators group. Further, if you would like to monitor for this attack, you could utilize methods/signatures to look for and alert on new registry entries in HKCU\Software\Classes\.

Example:

```vb.net
'Run file("D:\test.exe") as Background....
Bypass_UAC("D:\test.exe")
```
 

#### This code Based:

 * [enigma0x3](https://enigma0x3.net/2016/08/15/fileless-uac-bypass-using-eventvwr-exe-and-registry-hijacking/) “Fileless” UAC Bypass Using eventvwr.exe and Registry Hijacking
