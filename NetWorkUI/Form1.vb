Imports NetWorkBackEnd
Imports System.Threading.Tasks

Public Class Form1

    ' datagridviewname DgvNet 


    Dim task As New NetTask()
    Dim file As New ValueHolder()
    Dim proxy As New ProxySetter()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.5
        Me.FormBorderStyle = FormBorderStyle.None

        startupInit() 'ak user prvy krat spusta apku tak mu skopiruje jeho script ak je
        '
        LoadTb()
        StatusChecker()
        LoadDgv()

    End Sub

    Private Sub startupInit()
        If task.IsScriptAllowed Then
            Dim values = task.FirstBoot()
            file.WriteScript(values)
        End If
    End Sub
    Private Sub LoadTb()
        Tb_script.Text = file.ReadScript()
    End Sub

    'zisti ci je pri zaupnti script povolene
    Private Sub StatusChecker()
        If task.IsScriptAllowed() Then
            CheckBox1.Checked = True

        Else
            CheckBox1.Checked = False
        End If
        InitDisabler()
    End Sub

    Private Sub InitDisabler()
        If CheckBox1.Checked Then
            Tb_script.Font = New Font(Tb_script.Font, FontStyle.Regular)
            Tb_script.ReadOnly = False
        Else
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
        Dim cards = task.GetNetWorkCards()
        DgvNet.DataSource = cards
    End Sub



    Private Async Sub DgvNet_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvNet.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row = DgvNet.Rows(e.RowIndex)
            Dim adapterName = row.Cells("name").Value.ToString

            task.ToggleAdapterStatus(adapterName)

            'MsgBox("TESTOVANIE")
            Await Threading.Tasks.Task.Delay(10000)
            LoadDgv()

        End If
    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click

        Me.Close()

    End Sub

    Private Sub Tb_script_KeyDown(sender As Object, e As KeyEventArgs) Handles Tb_script.KeyDown

        If e.KeyValue = Keys.Enter Then

            If Tb_script.Text = "" Then
                MsgBox("Zadaj adresu scriptu")
            Else
                Dim value As String = Tb_script.Text.Trim()
                'funkcia na ulozenie hodnoty do suboru
                file.WriteScript(value)
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ProxyStatus()
    End Sub
End Class
