Public Class ConsultaLibro
    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub

    Private Sub ConsultaLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuprin.Enabled = False
        menuprin.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'BIBLIOTECADataSet1.LIBRO' Puede moverla o quitarla según sea necesario.
        Me.LIBROTableAdapter.Fill(Me.BIBLIOTECADataSet1.LIBRO)

    End Sub
End Class