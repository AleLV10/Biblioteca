Public Class Prestamo
    Private Sub Prestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuprin.Enabled = False
        menuprin.Visible = False

        consulta = New ADODB.Recordset
        consulta = conexion.Execute("select clvprest from prestamo order by clvprest")

        While Not consulta.EOF
            clvprest.Items.Add(consulta.Fields(0).Value())
            consulta.MoveNext()
        End While
        consulta = conexion.Execute("select clvlec from lector order by clvlec")

        While Not consulta.EOF
            clvlec.Items.Add(consulta.Fields(0).Value())
            consulta.MoveNext()
        End While
        consulta = conexion.Execute("select nolib from libro order by nolib")

        While Not consulta.EOF
            nolib.Items.Add(consulta.Fields(0).Value())
            consulta.MoveNext()
        End While
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub
    Private Sub Insertar_Click(sender As Object, e As EventArgs) Handles Insertar.Click
        ban = New ADODB.Parameter
        Dim clave As Integer
        clave = 0

        Dim mes As String
        If (fdev.Value.Month.ToString().Length = 1) Then
            mes = "0" + fdev.Value.Month.ToString()
        Else
            mes = fdev.Value.Month.ToString()
        End If
        comando = New ADODB.Command
        With comando
            .CommandText = "INSERTATODO"
            .CommandType = CommandType.StoredProcedure

            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adDate, ParameterDirectionEnum.adParamInput, , Date.Parse(fdev.Value.Year.ToString() + "-" + mes + "-" + fdev.Value.Day.ToString())))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(clvlec.Text)))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(nolib.Text)))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(3).Value

        End With
        If ban.Value = 1 Then
            MSGError.mensaje("LA FECHA DE ENTREGA NO" + vbCr + "PUEDE QUEDAR VACIA")
            MSGError.Show()
        Else
            If ban.Value = 2 Then
                MSGError.mensaje("LA FECHA DE ENTREGA DEBE " + vbCr + "SER POSTERIOR A LA " + vbCr + "FECHA DE PRESTAMO")
                MSGError.Show()
            Else
                If ban.Value = 3 Then
                    MSGError.mensaje("EL LECTOR NO EXISTE")
                    MSGError.Show()
                Else
                    If ban.Value = 4 Then
                        MSGError.mensaje("EL LIBRO YA SE ENCUENTRA " + vbCr + "PRESTADO")
                        MSGError.Show()

                    Else
                        If ban.Value = 5 Then
                            MSGError.mensaje("EL NO. DEL LIBRO NO SE " + vbCr + "ENCUENTRA INSERTADA")
                            MSGError.Show()

                        Else

                            consql = ("select max(clvprest)from prestamo")
                                consulta1 = New ADODB.Recordset
                                consulta1 = conexion.Execute(consql)

                                If Not consulta1.EOF Then
                                    clave = consulta1.Fields(0).Value
                                End If
                                MSGError.mensaje("LA CLAVE DEL PRESTAMO " + vbCr + "ES " + clave.ToString())
                                MSGError.Show()


                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        consulta2 = New ADODB.Recordset
        consulta2 = conexion.Execute("select fprest,fdev,clvprest from prestamo where clvprest=" & clvprest.Text)

        If Not consulta2.EOF Then
            fprest.Text = consulta2.Fields(0).Value
            fdev.Text = consulta2.Fields(1).Value
            clvprest.Text = consulta2.Fields(2).Value

            consulta3 = New ADODB.Recordset
            consulta3 = conexion.Execute("select nolib from DLIBPREST where clvprest=" & clvprest.Text)

            If Not consulta3.EOF Then
                nolib.Text = consulta3.Fields(0).Value
            End If

            consulta4 = New ADODB.Recordset
            consulta4 = conexion.Execute("select clvlec from DLECPREST where clvprest=" & clvprest.Text)

            If Not consulta4.EOF Then
                clvlec.Text = consulta4.Fields(0).Value
            End If
        Else
            MSGError.mensaje("LA CLAVE DEL PRESTAMO NO" + vbCr + "EXISTE O ESTÁ DADA DE" + vbCr + "BAJA")
            MSGError.Show()
        End If
    End Sub
End Class
