Imports MySql.Data.MySqlClient
Public Class ConsultaLibros
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub ConsultaLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=82.165.213.75;user=root;password=Laotra_1340;database=biblioteca"
            conexion.Open()
        Catch ex As Exception
            MsgBox("Sin conexión a la base de datos")
            MsgBox(ex.Message)
        End Try

        'MOSTRAR DATOS EN DATAGRID
        Dim consulta As String
        consulta = "Select folio as Folio from books"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "registros")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "registros"
    End Sub
End Class