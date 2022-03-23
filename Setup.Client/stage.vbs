s = Session.Property("CustomActionData") 

Set fso = CreateObject("Scripting.FileSystemObject")
fso.CopyFile s & "\Stage.config", s & "\it.dedagroup.GVC.Client.exe.config",TRUE
