Imports System.Data.SqlClient
Imports System.Data.Sql
Module Modulo
    Public consulta As Recordset
    Public consulta1 As Recordset
    Public consulta2 As Recordset
    Public consulta3 As Recordset
    Public consulta4 As Recordset
    Public ban As ADODB.Parameter
    Public comando As ADODB.Command
    Public conexion As ADODB.Connection
    Public consql As String
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Public Sub conectar()
        conexion = New ADODB.Connection
        With conexion
            .Provider = "sqloledb"
            .ConnectionString = "INITIAL CATALOG=BIBLIOTECA;SERVER=MIEQUIPO\SQLSERVER19;INTEGRATED SECURITY=SSPI;PERSIST SECURITY INFO=TRUE"
            Try
                .Open()
                ' MessageBox.Show("Conexión correcta")

            Catch ex As Exception
                MessageBox.Show("Conexión fallida" + ex.ToString())
            End Try

        End With
    End Sub
    Sub llenarDatos(ByVal dvg As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select PRES.CLVPREST, LIB.NOLIB, LIB.Titulo, LEC.CLVLEC, LEC.Nombre, LEC.Grupo, PRES.FPREST, PRES.FDEV from prestamo PRES
					LEFT OUTER JOIN DLECPREST DETP ON PRES.CLVPREST = DETP.CLVPREST
					LEFT OUTER JOIN DLIBPREST DLIP ON PRES.CLVPREST = DLIP.CLVPREST
					LEFT OUTER  JOIN Lector LEC ON DETP.CLVLEC = LEC.CLVLEC
					LEFT OUTER JOIN Libro LIB ON DLIP.NOLIB = LIB.NOLIB", "INITIAL CATALOG=BIBLIOTECA;SERVER=MIEQUIPO\SQLSERVER19;INTEGRATED SECURITY=SSPI;PERSIST SECURITY INFO=TRUE"
                                                                         )
            dt = New DataTable
            adaptador.Fill(dt)
            dvg.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
End Module
