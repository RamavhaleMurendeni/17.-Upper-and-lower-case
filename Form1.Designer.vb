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
        txtWord = New TextBox()
        lstWords = New ListBox()
        btnAdd = New Button()
        btnToUpperCase = New Button()
        btnToLowerCase = New Button()
        Label1 = New Label()
        btnDelete = New Button()
        btnClear = New Button()
        Button1 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtWord
        ' 
        txtWord.BackColor = SystemColors.MenuHighlight
        txtWord.Location = New Point(411, 72)
        txtWord.Name = "txtWord"
        txtWord.Size = New Size(100, 23)
        txtWord.TabIndex = 0
        ' 
        ' lstWords
        ' 
        lstWords.BackColor = SystemColors.MenuHighlight
        lstWords.FormattingEnabled = True
        lstWords.ItemHeight = 15
        lstWords.Location = New Point(37, 58)
        lstWords.Name = "lstWords"
        lstWords.Size = New Size(190, 304)
        lstWords.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.MenuHighlight
        btnAdd.Location = New Point(271, 132)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(240, 37)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add Word"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnToUpperCase
        ' 
        btnToUpperCase.BackColor = Color.Cyan
        btnToUpperCase.Location = New Point(271, 189)
        btnToUpperCase.Name = "btnToUpperCase"
        btnToUpperCase.Size = New Size(111, 47)
        btnToUpperCase.TabIndex = 3
        btnToUpperCase.Text = "UpperCase"
        btnToUpperCase.UseVisualStyleBackColor = False
        ' 
        ' btnToLowerCase
        ' 
        btnToLowerCase.BackColor = Color.Cyan
        btnToLowerCase.Location = New Point(405, 189)
        btnToLowerCase.Name = "btnToLowerCase"
        btnToLowerCase.Size = New Size(106, 47)
        btnToLowerCase.TabIndex = 4
        btnToLowerCase.Text = "LoweCase"
        btnToLowerCase.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(263, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 15)
        Label1.TabIndex = 5
        Label1.Text = "Enter your Word here"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnDelete.Location = New Point(271, 260)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(111, 49)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Red
        btnClear.Location = New Point(405, 260)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 49)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Location = New Point(273, 325)
        Button1.Name = "Button1"
        Button1.Size = New Size(238, 37)
        Button1.TabIndex = 8
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(110, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(503, 47)
        Label2.TabIndex = 9
        Label2.Text = "Convert Upper or Lower Case"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(Label1)
        Controls.Add(btnToLowerCase)
        Controls.Add(btnToUpperCase)
        Controls.Add(btnAdd)
        Controls.Add(lstWords)
        Controls.Add(txtWord)
        Name = "Form1"
        Text = "Upper and Lower Case"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtWord As TextBox
    Friend WithEvents lstWords As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnToUpperCase As Button
    Friend WithEvents btnToLowerCase As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
