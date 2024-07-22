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
        Label1 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        MenuStrip1 = New MenuStrip()
        RegistroToolStripMenuItem = New ToolStripMenuItem()
        DepartamentosToolStripMenuItem = New ToolStripMenuItem()
        LibrosToolStripMenuItem = New ToolStripMenuItem()
        LibrosToolStripMenuItem1 = New ToolStripMenuItem()
        ConsultarLibroToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(75, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 15)
        Label1.TabIndex = 1
        Label1.Text = "Elige el lugar al que accederás"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(23, 18)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(129, 19)
        RadioButton1.TabIndex = 2
        RadioButton1.TabStop = True
        RadioButton1.Text = "Centro de cómputo"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(23, 43)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(67, 19)
        RadioButton2.TabIndex = 3
        RadioButton2.TabStop = True
        RadioButton2.Text = "Idiomas"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(483, 237)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(101, 19)
        RadioButton3.TabIndex = 4
        RadioButton3.TabStop = True
        RadioButton3.Text = "Sala de lectura"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Location = New Point(75, 68)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(86, 199)
        Button1.Name = "Button1"
        Button1.Size = New Size(168, 42)
        Button1.TabIndex = 6
        Button1.Text = "Conexion a BD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(346, 199)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(363, 162)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {RegistroToolStripMenuItem, LibrosToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(826, 24)
        MenuStrip1.TabIndex = 9
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' RegistroToolStripMenuItem
        ' 
        RegistroToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DepartamentosToolStripMenuItem, LibrosToolStripMenuItem})
        RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        RegistroToolStripMenuItem.Size = New Size(62, 20)
        RegistroToolStripMenuItem.Text = "Registro"
        ' 
        ' DepartamentosToolStripMenuItem
        ' 
        DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        DepartamentosToolStripMenuItem.Size = New Size(155, 22)
        DepartamentosToolStripMenuItem.Text = "Departamentos"
        ' 
        ' LibrosToolStripMenuItem
        ' 
        LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        LibrosToolStripMenuItem.Size = New Size(155, 22)
        LibrosToolStripMenuItem.Text = "Libros"
        ' 
        ' LibrosToolStripMenuItem1
        ' 
        LibrosToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ConsultarLibroToolStripMenuItem})
        LibrosToolStripMenuItem1.Name = "LibrosToolStripMenuItem1"
        LibrosToolStripMenuItem1.Size = New Size(51, 20)
        LibrosToolStripMenuItem1.Text = "Libros"
        ' 
        ' ConsultarLibroToolStripMenuItem
        ' 
        ConsultarLibroToolStripMenuItem.Name = "ConsultarLibroToolStripMenuItem"
        ConsultarLibroToolStripMenuItem.Size = New Size(180, 22)
        ConsultarLibroToolStripMenuItem.Text = "Consultar libro"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(826, 444)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(RadioButton3)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "BIBLIOTECA UTESC"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultarLibroToolStripMenuItem As ToolStripMenuItem

End Class
