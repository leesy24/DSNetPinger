Option Explicit On

Imports System.IO
Imports System.IO.File
Imports System.Reflection
Imports System.Text
''//Log File Path ??? Write Error Check??

Structure LogTxt
    <VBFixedString(17)> Public ipText As String
End Structure

Public Class clsLogFile

    Public FilePath As String
    Public FilePath1 As String
    Public sPname As String


    Public Sub LogDataSave1(ByVal LogData As String, ByVal fName As String, ByVal ipStr As String)
        ''//log save!! 1. data 2.name
        Dim fw As StreamWriter
        ''Dim fs As FileStream
        Dim FileName As String

        Dim logIP As LogTxt  ''//Character 17 Fixing

        logIP.ipText = ipStr.ToString

        ''//file full path
        sPname = Assembly.GetExecutingAssembly.GetName.CodeBase
        ''//FilePath = Path.GetDirectoryName(sPname.Replace("file:///", "")) & "\" & DateTime.Now.ToString("yyyyMMdd") & ".Log" ''app.path
        FilePath1 = "C:\WMS_Log"

        If System.IO.Directory.Exists(FilePath1) = False Then
            My.Computer.FileSystem.CreateDirectory(FilePath1)
        End If

        FilePath = FilePath1 & "\" & DateTime.Now.ToString("yyyyMMdd") & ".Log"

        FileName = FilePath + "\" + fName + "-" + DateTime.Now.ToString("yyyyMMdd") + ".txt"

        ''//folder check!
        If System.IO.Directory.Exists(FilePath) = False Then
            My.Computer.FileSystem.CreateDirectory(FilePath)
        End If

        ''//file check!!
        If File.Exists(FileName) = False Then
            fw = File.CreateText(FileName)
        Else
            fw = File.AppendText(FileName)
        End If

        fw.WriteLine(Format(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")) & " [" & logIP.ipText.ToString & "] " & LogData.ToString) ''& vbCrLf)
        fw.Flush()

        fw.Close()

        'fs = New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        'fs.Position = fs.Length

        'fw = New StreamWriter(fs, Encoding.Default)
        'fw.Write(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") & " " & LogData & vbCrLf)

        'fs.Close()

        ''Debug.Print(FilePath)
    End Sub


End Class
