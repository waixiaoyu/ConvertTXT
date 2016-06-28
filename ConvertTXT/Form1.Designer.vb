Imports System.IO
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTN_Convert = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TB_InputPath = New System.Windows.Forms.TextBox()
        Me.BTN_ChooseFilePath = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TB_OutputPath = New System.Windows.Forms.TextBox()
        Me.BTN_ChooseOutputPath = New System.Windows.Forms.Button()
        Me.TB_OutputName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_Convert
        '
        Me.BTN_Convert.Location = New System.Drawing.Point(184, 100)
        Me.BTN_Convert.Name = "BTN_Convert"
        Me.BTN_Convert.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Convert.TabIndex = 0
        Me.BTN_Convert.Text = "开始转换"
        Me.BTN_Convert.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TB_InputPath
        '
        Me.TB_InputPath.Location = New System.Drawing.Point(107, 12)
        Me.TB_InputPath.Name = "TB_InputPath"
        Me.TB_InputPath.Size = New System.Drawing.Size(240, 21)
        Me.TB_InputPath.TabIndex = 1
        '
        'BTN_ChooseFilePath
        '
        Me.BTN_ChooseFilePath.Location = New System.Drawing.Point(353, 12)
        Me.BTN_ChooseFilePath.Name = "BTN_ChooseFilePath"
        Me.BTN_ChooseFilePath.Size = New System.Drawing.Size(62, 23)
        Me.BTN_ChooseFilePath.TabIndex = 2
        Me.BTN_ChooseFilePath.Text = "浏览"
        Me.BTN_ChooseFilePath.UseVisualStyleBackColor = True
        '
        'TB_OutputPath
        '
        Me.TB_OutputPath.Location = New System.Drawing.Point(107, 39)
        Me.TB_OutputPath.Name = "TB_OutputPath"
        Me.TB_OutputPath.Size = New System.Drawing.Size(240, 21)
        Me.TB_OutputPath.TabIndex = 3
        '
        'BTN_ChooseOutputPath
        '
        Me.BTN_ChooseOutputPath.Location = New System.Drawing.Point(353, 37)
        Me.BTN_ChooseOutputPath.Name = "BTN_ChooseOutputPath"
        Me.BTN_ChooseOutputPath.Size = New System.Drawing.Size(62, 23)
        Me.BTN_ChooseOutputPath.TabIndex = 4
        Me.BTN_ChooseOutputPath.Text = "浏览"
        Me.BTN_ChooseOutputPath.UseVisualStyleBackColor = True
        '
        'TB_OutputName
        '
        Me.TB_OutputName.Location = New System.Drawing.Point(107, 66)
        Me.TB_OutputName.Name = "TB_OutputName"
        Me.TB_OutputName.Size = New System.Drawing.Size(96, 21)
        Me.TB_OutputName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "输出文件名："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = ".txt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "选择输入文件："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "选择输出路径："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 135)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_OutputName)
        Me.Controls.Add(Me.BTN_ChooseOutputPath)
        Me.Controls.Add(Me.TB_OutputPath)
        Me.Controls.Add(Me.BTN_ChooseFilePath)
        Me.Controls.Add(Me.TB_InputPath)
        Me.Controls.Add(Me.BTN_Convert)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "文本转换工具"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_Convert As System.Windows.Forms.Button

    Dim MyString
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Convert.Click
        Dim InputName As String
        Dim OutputName As String
        InputName = OpenFileDialog1.FileName
        If InputName = "OpenFileDialog1" Then
            InputName = TB_InputPath.Text
        End If
        OutputName = FolderBrowserDialog1.SelectedPath
        If InputName = "" Then
            MessageBox.Show("please choose file first!")
            Exit Sub
        End If
        If OutputName = "" Then
            MessageBox.Show("Output file name should not be empty!")
            Exit Sub
        End If
        If TB_OutputName.Text = "" Then
            TB_OutputName.Text = Split(OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1), ".")(0)
            OutputName = FolderBrowserDialog1.SelectedPath + "\" + TB_OutputName.Text + "_new" + ".txt"
        Else
            OutputName = FolderBrowserDialog1.SelectedPath + "\" + TB_OutputName.Text + ".txt"
        End If
        If InputName = OutputName Or File.Exists(OutputName) Then
            MessageBox.Show("there exists a same file in same path, please choose another path or rename the file.")
            Exit Sub
        End If
        'MessageBox.Show(InputName)
        'MessageBox.Show(OutputName)

        Dim reader As TextReader = File.OpenText(InputName)
        Dim fn As New IO.FileStream(OutputName, FileMode.Append)
        Dim fr As New IO.BinaryWriter(fn)

        Dim strResult As String = ""
        Dim line As String = reader.ReadToEnd
        If line = "" Then
            MessageBox.Show("the file is empty")
        Else
            Dim lines() As String = Split(line, ",")
            Dim i As Integer
            For i = 0 To UBound(lines)
                If lines(i) <> "" Then

                    strResult += ParseString(Trim(lines(i)))
                    ' MessageBox.Show(strResult)

                End If
            Next
            Dim bytes() As Byte = System.Text.Encoding.Unicode.GetBytes(strResult)
            fr.Write(bytes)
            fr.Close()
            fn.Close()
            reader.Close()

            MessageBox.Show("转换完毕")
        End If

    End Sub
    Function ParseString(ByVal line As String)
        Dim index As Integer
        Dim i As Integer
        For i = 1 To Len(line)
            If IsNumeric(Mid(line, i, 1)) = True Then '解析遇到数字，根据数字的位置解析字符串
                index = i
                Exit For
            End If
            If i = Len(line) Then '如果只有人名，就将人名直接输出
                Return line + ";"
            End If
        Next
        'MessageBox.Show(index)
        Return Mid(line, 1, 1) + Mid(line, index, 8) + ";"
    End Function
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TB_InputPath As System.Windows.Forms.TextBox
    Friend WithEvents BTN_ChooseFilePath As System.Windows.Forms.Button

    Private Sub BTN_ChooseFilePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ChooseFilePath.Click
        OpenFileDialog1.ShowDialog()
        TB_InputPath.Text = OpenFileDialog1.FileName
    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TB_OutputPath As System.Windows.Forms.TextBox
    Friend WithEvents BTN_ChooseOutputPath As System.Windows.Forms.Button

    Private Sub BTN_ChooseOutputPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ChooseOutputPath.Click
        FolderBrowserDialog1.ShowDialog()
        TB_OutputPath.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Friend WithEvents TB_OutputName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
