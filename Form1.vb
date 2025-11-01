Public Class Form1
    Public con As String
    Public usus As String
    Public ban As Boolean
    Public Sub mensaje()
        con = "CONTRASEÑA"
        usus = "Usuario"
        Usuario.Text = usus
        Contrasena.Text = con
    End Sub
    Private Sub entrar_Click(sender As Object, e As EventArgs) Handles entrar.Click
        Dim usu As String
        Dim cont As String

        usu = "Fulanito"
        cont = "123"
        If (usu = Usuario.Text) Then
            If (cont = Contrasena.Text) Then
                Call conectar()
                menuprin.Show()
                ban = True
            Else
                MSGError.mensaje("USUARIO O CONTRASEÑA" + vbCr + "INCORRECTA")
                MSGError.Show()
            End If
        Else
            MSGError.mensaje("USUARIO O CONTRASEÑA" + vbCr + "INCORRECTA")
            MSGError.Show()
        End If


    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        If (ban) Then
            conexion.Close()
        End If

        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MSGError.mensaje("LLAME AL ADMIN PARA" + vbCr + "CAMBIAR CONTRASEÑA" + vbCr + "AL 351 184 0736")
        MSGError.Show()
    End Sub


End Class
