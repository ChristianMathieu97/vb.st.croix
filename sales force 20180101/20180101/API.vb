Option Strict Off
Option Explicit On
Module API
	
	' API.bas
	' -------
	
	Public Declare Function SetLayeredWindowAttributes Lib "user32" (ByVal hwnd As Integer, ByVal color As Integer, ByVal x As Byte, ByVal alpha As Integer) As Boolean
	Public Declare Function SetWindowLong Lib "user32"  Alias "SetWindowLongA"(ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
	Public Declare Function GetWindowLong Lib "user32"  Alias "GetWindowLongA"(ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
	
	' basGeneralProcedures
	' --------------------
	
	Public Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpfile As String, ByVal lpParmeters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	Public Const SW_SHOWNORMAL As Short = 1
	
	Public Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As Integer, ByVal bInheritHandle As Integer, ByVal dwProcessId As Integer) As Integer
	
	Public Declare Function GetExitCodeProcess Lib "kernel32" (ByVal hProcess As Integer, ByRef lpExitCode As Integer) As Integer
	
	Public Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer
	
	Public Declare Function InternetGetConnectedState Lib "Wininet" (ByRef lpdwFlags As Integer, ByVal dwReserved As Integer) As Integer
	
	Public Declare Function SetForegroundWindow Lib "user32" (ByVal hwnd As Integer) As Integer
	
	Public Const PROCESS_QUERY_INFORMATION As Integer = &H400
	Public Const STATUS_PENDING As Integer = &H103
	Public Const SW_RESTORE As Short = 9
	Declare Function FindWindow Lib "user32"  Alias "FindWindowA"(ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
	
	Public Declare Function ShowWindow Lib "user32" (ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
	
	Public Const SW_SHOW As Short = 5
	
	Public Declare Function GetWindowThreadProcessId Lib "user32" (ByVal hwnd As Integer, ByRef lpdwProcessId As Integer) As Integer
	
	Public Declare Function TerminateProcess Lib "kernel32" (ByVal hProcess As Integer, ByVal uExitCode As Integer) As Integer
	
	'Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd _
	''As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	
	Public Const CB_FINDSTRING As Integer = &H14C
	Public Const CB_SELECTSTRING As Integer = &H14D
	Public Const WM_SETREDRAW As Integer = &HB
End Module