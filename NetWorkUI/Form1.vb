Imports NetWorkBackEnd
Imports System.IO
Imports System.Threading.Tasks
Imports System.Runtime.InteropServices
Imports Windows.Win32.System

Public Class Form1

#Region "Classes and objects"

    Dim taskNet As New NetTask()
    Dim file As New ValueHolder()
    Dim proxy As New ProxySetter()
#End Region
    <DllImport("user32.dll")>
    Public Shared Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SetParent(hWndChild As IntPtr, hWndNewParent As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Public Shared Function FindWindowEx(hWndParent As IntPtr, hWndChildAfter As IntPtr, lpszClass As String, lpszWindow As String) As IntPtr
    End Function


    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub init()
        Dim nWinHandle As IntPtr = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", Nothing)
        nWinHandle = FindWindowEx(nWinHandle, IntPtr.Zero, "SHELLDLL_DefView", Nothing)
        SetParent(Handle, nWinHandle)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.8
        Me.FormBorderStyle = FormBorderStyle.None

        Centering()
        startupInit()
        StatusChecker()
        LoadDgv()


    End Sub


    Private Sub Centering()
        Dim screenC = Screen.PrimaryScreen.WorkingArea
        Me.Location = New Point((screenC.Width - Me.Width) \ 2, 0)
    End Sub


    Private Async Sub DgvNet_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvNet.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row = DgvNet.Rows(e.RowIndex)
            Dim adapterName = row.Cells("name").Value.ToString

            taskNet.ToggleAdapterStatus(adapterName)
            Await Threading.Tasks.Task.Delay(10000)
            LoadDgv()

        End If
    End Sub
    Private Sub Tb_script_KeyDown(sender As Object, e As KeyEventArgs) Handles Tb_script.KeyDown
        If e.KeyValue = Keys.Enter Then
            If String.IsNullOrWhiteSpace(Tb_script.Text) Then
                MsgBox("Zadaj adresu scriptu")
            Else
                Dim value As String = Tb_script.Text.Trim()
                file.WriteScript(value)
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ProxyStatus()
    End Sub

#Region "aditional methods"
    Private Sub startupInit()
        If taskNet.IsScriptAllowed Then
            Dim values = taskNet.FirstBoot()
            file.WriteScript(values)
        End If
    End Sub

    Private Sub StatusChecker()
        If taskNet.IsScriptAllowed() Then
            CheckBox1.Checked = True
            Tb_script.Font = New Font(Tb_script.Font, FontStyle.Regular)
            Tb_script.ReadOnly = False
        Else
            CheckBox1.Checked = False
            Tb_script.ReadOnly = True
            Tb_script.Font = New Font(Tb_script.Font, FontStyle.Strikeout)
        End If
    End Sub

    Private Sub ProxyStatus()
        If CheckBox1.Checked Then
            proxy.EnableProxyScript()
            Tb_script.Font = New Font(Tb_script.Font, FontStyle.Regular)
        Else
            Tb_script.Font = New Font(Tb_script.Font, FontStyle.Strikeout)
            proxy.DisableProxyScript()
        End If
    End Sub

    Private Sub LoadDgv()
        Dim cards = taskNet.GetNetWorkCards()
        DgvNet.DataSource = cards
        Tb_script.Text = file.ReadScript()
    End Sub

#End Region

End Class
