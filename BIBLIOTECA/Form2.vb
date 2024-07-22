Imports System.Diagnostics.Eventing
Imports System.Windows.Markup
Imports MySql.Data.MySqlClient
Imports Mysqlx.Resultset
Imports Org.BouncyCastle.Crypto.Engines
Public Class Form2
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=82.165.213.75;user=root;password=Laotra_1340;database=bitacora"
            conexion.Open()


        Catch ex As Exception
            MsgBox("Sin conexión a la base de datos")
            MsgBox(ex.Message)
        End Try

        'MOSTRAR DATOS EN DATAGRID
        Dim consulta As String
        consulta = "Select departamento as Departamento from departamentos"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "registros")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "registros"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mensajerror = "Advertencia"
        If txtInDepto.Text = "" Then
            mensajerror = mensajerror & "Falta ingresar dato"
            MsgBox("Ingrese el nombre del departamento")
        ElseIf mensajerror <> "" Then
            Dim query = "insert into departamentos " &
            "(departamento) values " &
            "('" & txtInDepto.Text & "');"
            'DataGridView1.Refresh()
            Dim comando = New MySqlCommand(query, conexion)
            'DataGridView1.Refresh()
            Try
                Dim reader = comando.ExecuteReader()
                reader.Close()

            Catch ex As Exception

            End Try

            txtInDepto.Text = ""
            DataGridView1.Refresh()

            'MOSTRAR DATOS EN DATAGRID
            Dim consulta As String
            consulta = "Select departamento as Departamento from departamentos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "registros")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "registros"

        Else
            MessageBox.Show(mensajerror)
            DataGridView1.Refresh()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class