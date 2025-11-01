Public Class MSGError
    Public mesj As String
    Public Sub mensaje(ByVal texto As String)
        mesj = texto
    End Sub


    Private Sub MSGError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msj.Text = mesj
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Close()
    End Sub
End Class