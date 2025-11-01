Public Class Libro
    Private Sub Libro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuprin.Enabled = False
        menuprin.Visible = False

        consulta = New ADODB.Recordset
        consulta = conexion.Execute("select nolib from libro order by nolib")

        While Not consulta.EOF
            nolib.Items.Add(consulta.Fields(0).Value())
            consulta.MoveNext()
        End While
        estado.Text = "0"
        significado.Text = "Disponible"

    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub

    Private Sub Insertar_Click(sender As Object, e As EventArgs) Handles Insertar.Click
        ban = New ADODB.Parameter

        comando = New ADODB.Command
        With comando
            .CommandText = "INSERTLIB"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, titulo.Text))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, autor.Text))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, edit.Text))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, edic.Text))
            .Parameters.Append(.CreateParameter("4", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, pais.Text))
            .Parameters.Append(.CreateParameter("5", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 12, proced.Text))
            .Parameters.Append(.CreateParameter("6", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 7, observ.Text))
            .Parameters.Append(.CreateParameter("7", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 17, isbn.Text))
            .Parameters.Append(.CreateParameter("8", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(nolib.Text)))
            .Parameters.Append(.CreateParameter("9", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(9).Value
        End With
        If ban.Value = 1 Then
            MSGError.mensaje("EL NUMERO DEL LIBRO" + vbCr + "NO PUEDE SER 0")
            MSGError.Show()
        Else
            If ban.Value = 2 Then
                MSGError.mensaje("EL TITULO DEL LIBRO NO" + vbCr + "PUEDE QUEDAR VACIO")
                MSGError.Show()
            Else
                If ban.Value = 3 Then
                    MSGError.mensaje("EL AUTOR NO PUEDE" + vbCr + "QUEDAR VACIO")
                    MSGError.Show()
                Else
                    If ban.Value = 4 Then
                        MSGError.mensaje("LA EDITORIAL NO PUEDE" + vbCr + "QUEDAR VACIA")
                        MSGError.Show()
                    Else
                        If ban.Value = 5 Then
                            MSGError.mensaje("EL NO. DE EDICION" + vbCr + "NO PUEDE QUEDAR VACIO")
                            MSGError.Show()
                        Else
                            If ban.Value = 6 Then
                                MSGError.mensaje("EL PAIS NO PUEDE " + vbCr + "QUEDAR VACIO")
                                MSGError.Show()
                            Else
                                If ban.Value = 7 Then
                                    MSGError.mensaje("PROCEDENCIA NO " + vbCr + "PUEDE QUEDAR VACIA")
                                    MSGError.Show()
                                Else
                                    If ban.Value = 8 Then
                                        MSGError.mensaje("LAS OBSERVACIONES NO" + vbCr + "PUEDEN ESTAR VACIAS")
                                        MSGError.Show()
                                    Else
                                        If ban.Value = 9 Then
                                            MSGError.mensaje("EL ISBN NO PUEDE" + vbCr + "QUEDAR VACIO")
                                            MSGError.Show()
                                        Else
                                            If ban.Value = 10 Then
                                                MSGError.mensaje("EL ISBN YA EXISTE")
                                                MSGError.Show()
                                            Else
                                                If ban.Value = 11 Then
                                                    MSGError.mensaje("LAS OBSERVACIONES  " + vbCr + "DEBEN SER: 'BUENO', 'MALO'" + vbCr + " O 'REGULAR'")
                                                    MSGError.Show()
                                                Else
                                                    If ban.Value = 12 Then
                                                        MSGError.mensaje("LA PROCEDENCIA DEBE " + vbCr + "SER: 'DIR. GENERAL', " + vbCr + "'CAMBIO' O  'DONACIÓN")
                                                        MSGError.Show()
                                                    Else
                                                        If ban.Value = 13 Then
                                                            MSGError.mensaje("EL TITULO DEL LIBRO" + vbCr + "YA EXISTE")
                                                            MSGError.Show()
                                                        Else
                                                            If ban.Value = 14 Then
                                                                MSGError.mensaje("EL NUMERO DEL LIBRO" + vbCr + "YA EXISTE")
                                                                MSGError.Show()
                                                            Else
                                                                titulo.Text = ""
                                                                autor.Text = ""
                                                                edit.Text = ""
                                                                edic.Text = ""
                                                                pais.Text = ""
                                                                proced.Text = ""
                                                                observ.Text = ""
                                                                isbn.Text = ""
                                                                estado.Text = ""
                                                                nolib.Text = ""
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        consulta2 = New ADODB.Recordset
        consulta2 = conexion.Execute("select titulo,autor,edit,edic,pais,proced,observ,isbn,estado,nolib from libro where nolib=" & nolib.Text)

        If Not consulta2.EOF Then
            titulo.Text = consulta2.Fields(0).Value
            autor.Text = consulta2.Fields(1).Value
            edit.Text = consulta2.Fields(2).Value
            edic.Text = consulta2.Fields(3).Value
            Pais.Text = consulta2.Fields(4).Value
            proced.Text = consulta2.Fields(5).Value
            observ.Text = consulta2.Fields(6).Value
            isbn.Text = consulta2.Fields(7).Value
            estado.Text = consulta2.Fields(8).Value
            nolib.Text = consulta2.Fields(9).Value
            If consulta2.Fields(8).Value = 1 Then
                significado.Text = "Ocupado"
            Else
                significado.Text = "Disponible"
            End If

        Else
            MSGError.mensaje("LA CLAVE DEL LIBRO NO" + vbCr + "EXISTE O ESTÁ DADA DE " + vbCr + "BAJA")
            MSGError.Show()
        End If
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        ban = New ADODB.Parameter
        comando = New ADODB.Command
        With comando
            .CommandText = "MODIFICALIB"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, titulo.Text))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, autor.Text))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, edit.Text))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, edic.Text))
            .Parameters.Append(.CreateParameter("4", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, Pais.Text))
            .Parameters.Append(.CreateParameter("5", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 12, proced.Text))
            .Parameters.Append(.CreateParameter("6", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 7, observ.Text))
            .Parameters.Append(.CreateParameter("7", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 17, isbn.Text))
            .Parameters.Append(.CreateParameter("8", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(estado.Text)))
            .Parameters.Append(.CreateParameter("9", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(nolib.Text)))
            .Parameters.Append(.CreateParameter("10", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(10).Value
        End With
        If ban.Value = 1 Then
            MSGError.mensaje("EL NUMERO DEL LIBRO" + vbCr + "NO PUEDE SER 0")
            MSGError.Show()
        Else
            If ban.Value = 2 Then
                MSGError.mensaje("EL TITULO DEL LIBRO NO" + vbCr + "PUEDE QUEDAR VACIO")
                MSGError.Show()
            Else
                If ban.Value = 3 Then
                    MSGError.mensaje("EL AUTOR NO PUEDE" + vbCr + "QUEDAR VACIO")
                    MSGError.Show()
                Else
                    If ban.Value = 4 Then
                        MSGError.mensaje("LA EDITORIAL NO PUEDE" + vbCr + "QUEDAR VACIA")
                        MSGError.Show()
                    Else
                        If ban.Value = 5 Then
                            MSGError.mensaje("EL NO. DE EDICION" + vbCr + "NO PUEDE QUEDAR VACIO")
                            MSGError.Show()
                        Else
                            If ban.Value = 6 Then
                                MSGError.mensaje("EL PAIS NO PUEDE " + vbCr + "QUEDAR VACIO")
                                MSGError.Show()
                            Else
                                If ban.Value = 7 Then
                                    MSGError.mensaje("PROCEDENCIA NO " + vbCr + "PUEDE QUEDAR VACIA")
                                    MSGError.Show()
                                Else
                                    If ban.Value = 8 Then
                                        MSGError.mensaje("LAS OBSERVACIONES NO" + vbCr + "PUEDEN ESTAR VACIAS")
                                        MSGError.Show()
                                    Else
                                        If ban.Value = 9 Then
                                            MSGError.mensaje("EL ISBN NO PUEDE" + vbCr + "QUEDAR VACIO")
                                            MSGError.Show()
                                        Else
                                            If ban.Value = 10 Then
                                                MSGError.mensaje("EL ISBN YA EXISTE")
                                                MSGError.Show()
                                            Else
                                                If ban.Value = 11 Then
                                                    MSGError.mensaje("LAS OBSERVACIONES  " + vbCr + "DEBEN SER: 'BUENO', 'MALO'" + vbCr + " O 'REGULAR'")
                                                    MSGError.Show()
                                                Else
                                                    If ban.Value = 12 Then
                                                        MSGError.mensaje("LA PROCEDENCIA DEBE " + vbCr + "SER: 'DIR. GENERAL', " + vbCr + "'CAMBIO' O  'DONACIÓN")
                                                        MSGError.Show()
                                                Else
                                                    If ban.Value = 13 Then
                                                        MSGError.mensaje("EL TITULO DEL LIBRO" + vbCr + "YA EXISTE")
                                                        MSGError.Show()
                                                    Else
                                                        If ban.Value = 14 Then
                                                            MSGError.mensaje("EL NUMERO DEL LIBRO" + vbCr + "YA EXISTE")
                                                            MSGError.Show()
                                                        Else
                                                                If ban.Value = 15 Then
                                                                    MSGError.mensaje("EL ESTADO NO SE" + vbCr + "PUEDE MODIFICAR")
                                                                    MSGError.Show()
                                                                Else
                                                                    MSGError.mensaje("MODIFICACIÓN REALIZADA" + vbCr + "CORRECTAMENTE")
                                                                    MSGError.Show()
                                                                    titulo.Text = ""
                                                                    autor.Text = ""
                                                                    edit.Text = ""
                                                                    edic.Text = ""
                                                                    Pais.Text = ""
                                                                    proced.Text = ""
                                                                    observ.Text = ""
                                                                    isbn.Text = ""
                                                                    estado.Text = ""
                                                                    nolib.Text = ""
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click

        ban = New ADODB.Parameter
        comando = New ADODB.Command
        With comando
            .CommandText = "ELIMINALIBRO"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(nolib.Text)))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
            .ActiveConnection = conexion
            .Execute()
            ban.Value = .Parameters(1).Value
        End With

        If ban.Value = 1 Then
            MSGError.mensaje("EL NUMERO DEL LIBRO" + vbCr + "NO EXISTE")
            MSGError.Show()
        Else
            MSGError.mensaje("LIBRO ELIMINADO" + vbCr + "CORRECTAMENTE")
            MSGError.Show()
            titulo.Text = ""
            autor.Text = ""
            edit.Text = ""
            edic.Text = ""
            Pais.Text = ""
            proced.Text = ""
            observ.Text = ""
            isbn.Text = ""
            estado.Text = ""
            nolib.Text = ""

        End If
    End Sub
End Class