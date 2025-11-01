Public Class lector
    Private Sub lector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuprin.Enabled = False
        menuprin.Visible = False

        consulta = New ADODB.Recordset
        consulta = conexion.Execute("select clvlec from lector order by clvlec")

        While Not consulta.EOF
            clvlec.Items.Add(consulta.Fields(0).Value())
            consulta.MoveNext()
        End While
    End Sub

    Private Sub salir_Click_1(sender As Object, e As EventArgs) Handles Salir.Click
        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub
    Private Sub inserta_Click(sender As Object, e As EventArgs) Handles Insertar.Click
        ban = New ADODB.Parameter

        comando = New ADODB.Command
        With comando
            .CommandText = "INSLECTOR"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 45, nombre.Text))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 7, grupo.Text))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(clvlec.Text)))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(3).Value
        End With
        If ban.Value = 1 Then
            MSGError.mensaje("EL NO. DE CONTROL NO" + vbCr + "PUEDE QUEDAR VACIO")
            MSGError.Show()
        Else
            If ban.Value = 2 Then
                MSGError.mensaje("EL NUMERO DE CONTROL" + vbCr + "YA EXISTE")
                MSGError.Show()
            Else
                If ban.Value = 3 Then
                    MSGError.mensaje("EL GRUPO NO PUEDE" + vbCr + "QUEDAR VACIO")
                    MSGError.Show()
                Else
                    If ban.Value = 4 Then
                        MSGError.mensaje("EL GRUPO DEBE SER" + vbCr + "'DOCENTE' O '101' '102'" + vbCr + "'103' '201'...")
                        MSGError.Show()
                    Else
                        If ban.Value = 5 Then
                            MSGError.mensaje("EL NOMBRE DEL LECTOR" + vbCr + "NO PUEDE QUEDAR VACIO")
                            MSGError.Show()
                        Else
                            If ban.Value = 6 Then
                                MSGError.mensaje("EL NOMBRE DEL LECTOR YA " + vbCr + "EXISTE")
                                MSGError.Show()
                            Else

                                nombre.Text = ""
                                grupo.Text = ""
                                clvlec.Text = ""

                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Elimina_Click(sender As Object, e As EventArgs) Handles Eliminar.Click

        ban = New ADODB.Parameter
        comando = New ADODB.Command
        With comando
            .CommandText = "ELIMINALECTOR"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(clvlec.Text)))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(1).Value
        End With

        If ban.Value = 1 Then
            MSGError.mensaje("LA CLAVE DEL LECTOR " + vbCr + "NO EXISTE")
            MSGError.Show()
        Else
            MSGError.mensaje("LECTOR ELIMINADO " + vbCr + "CORRECTAMENTE")
            MSGError.Show()
            clvlec.Text = ""
            nombre.Text = ""
            grupo.Text = ""

        End If
    End Sub

    Private Sub Modifica_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        ban = New ADODB.Parameter
        comando = New ADODB.Command
        With comando
            .CommandText = "MODIFICALEC"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 45, nombre.Text))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 7, grupo.Text))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(clvlec.Text)))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(3).Value
        End With
        If ban.Value = 1 Then
            MSGError.mensaje("EL NUMERO DE CONTROL" + vbCr + "NO PUEDE ESTAR" + vbCr + "VACIO")
            MSGError.Show()
        Else
            If ban.Value = 2 Then
                MSGError.mensaje("EL NUMERO DE CONTROL" + vbCr + "NO EXISTE")
                MSGError.Show()
            Else
                If ban.Value = 3 Then
                    MSGError.mensaje("EL GRUPO NO PUEDE" + vbCr + "QUEDAR VACIO")
                    MSGError.Show()
                Else
                    If ban.Value = 4 Then
                        MSGError.mensaje("EL GRUPO DEBE SER" + vbCr + "'DOCENTE' O '101' '102'" + vbCr + "'103' '201'...")
                        MSGError.Show()
                    Else
                        If ban.Value = 5 Then
                            MSGError.mensaje("EL NOMBRE DEL LECTOR" + vbCr + "NO PUEDE QUEDAR VACIO")
                            MSGError.Show()
                        Else
                            If ban.Value = 6 Then
                                MSGError.mensaje("EL NOMBRE DEL LECTOR YA " + vbCr + "EXISTE")
                                MSGError.Show()
                            Else
                                MSGError.mensaje("MODIFICACIÓN REALIZADA" + vbCr + "CORRECTAMENTE")
                                MSGError.Show()
                                nombre.Text = ""
                                grupo.Text = ""
                                clvlec.Text = ""
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Consultacion_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        consulta2 = New ADODB.Recordset
        consulta2 = conexion.Execute("select nombre,grupo,clvlec from lector where clvlec=" & clvlec.Text)

        If Not consulta2.EOF Then
            nombre.Text = consulta2.Fields(0).Value
            grupo.Text = consulta2.Fields(1).Value
            clvlec.Text = consulta2.Fields(2).Value

        Else
            MSGError.mensaje("EL NO. CONTROL NO" + vbCr + "EXISTE O ESTÁ DADA " + vbCr + "DE BAJA")
            MSGError.Show()
        End If
    End Sub

    Private Sub Sal_Click(sender As Object, e As EventArgs) Handles Salir.Click
        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub
End Class