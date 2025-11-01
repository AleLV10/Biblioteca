Public Class ConsultaPrestamo
    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub
    Private Sub ConsultaPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuprin.Enabled = False
        menuprin.Visible = False
        llenarDatos(DGV)
    End Sub
End Class