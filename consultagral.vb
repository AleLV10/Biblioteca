Public Class consultagral
    Private Sub consultagral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuprin.Enabled = False
        menuprin.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'BIBLIOTECADataSet.LECTOR' Puede moverla o quitarla según sea necesario.
        Me.LECTORTableAdapter.Fill(Me.BIBLIOTECADataSet.LECTOR)
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub

End Class