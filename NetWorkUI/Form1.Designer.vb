<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        DgvNet = New DataGridView()
        TableLayoutPanel3 = New TableLayoutPanel()
        Btn_close = New Button()
        Tb_script = New TextBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(DgvNet, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(370, 190)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(DgvNet, 0, 1)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel4, 0, 2)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(2, 2)
        TableLayoutPanel2.Margin = New Padding(2)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 18.0769234F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 81.92308F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel2.Size = New Size(366, 186)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' DgvNet
        ' 
        DgvNet.AllowUserToAddRows = False
        DgvNet.AllowUserToDeleteRows = False
        DgvNet.AllowUserToResizeColumns = False
        DgvNet.AllowUserToResizeRows = False
        DgvNet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvNet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvNet.BackgroundColor = SystemColors.ButtonFace
        DgvNet.BorderStyle = BorderStyle.None
        DgvNet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvNet.ColumnHeadersVisible = False
        DgvNet.Dock = DockStyle.Fill
        DgvNet.Location = New Point(2, 30)
        DgvNet.Margin = New Padding(2)
        DgvNet.Name = "DgvNet"
        DgvNet.RowHeadersVisible = False
        DgvNet.RowHeadersWidth = 62
        DgvNet.Size = New Size(362, 123)
        DgvNet.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 85.07752F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.9224806F))
        TableLayoutPanel3.Controls.Add(Btn_close, 1, 0)
        TableLayoutPanel3.Controls.Add(Tb_script, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(2, 2)
        TableLayoutPanel3.Margin = New Padding(2)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(362, 24)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Btn_close
        ' 
        Btn_close.Dock = DockStyle.Fill
        Btn_close.FlatStyle = FlatStyle.Flat
        Btn_close.Font = New Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        Btn_close.Location = New Point(309, 2)
        Btn_close.Margin = New Padding(2)
        Btn_close.Name = "Btn_close"
        Btn_close.Size = New Size(51, 20)
        Btn_close.TabIndex = 0
        Btn_close.Text = "x"
        Btn_close.UseVisualStyleBackColor = True
        ' 
        ' Tb_script
        ' 
        Tb_script.Dock = DockStyle.Fill
        Tb_script.Location = New Point(4, 3)
        Tb_script.Margin = New Padding(4, 3, 4, 3)
        Tb_script.Name = "Tb_script"
        Tb_script.Size = New Size(299, 23)
        Tb_script.TabIndex = 1
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.007752F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 93.99225F))
        TableLayoutPanel4.Controls.Add(CheckBox1, 0, 0)
        TableLayoutPanel4.Controls.Add(Label1, 1, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(2, 157)
        TableLayoutPanel4.Margin = New Padding(2)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(362, 27)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Dock = DockStyle.Fill
        CheckBox1.Location = New Point(2, 2)
        CheckBox1.Margin = New Padding(2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(17, 23)
        CheckBox1.TabIndex = 0
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(23, 0)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(337, 27)
        Label1.TabIndex = 1
        Label1.Text = "Proxy script "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 190)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        ImeMode = ImeMode.Off
        Margin = New Padding(2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ShowIcon = False
        ShowInTaskbar = False
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        CType(DgvNet, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DgvNet As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Btn_close As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Tb_script As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label

End Class
