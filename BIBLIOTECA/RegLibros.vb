Public Class RegLibros
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtFechaPub.Text = DateTimePicker1.Text


    End Sub

    Private Sub RegLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaPub.Text = DateTimePicker1.Text
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
End Class