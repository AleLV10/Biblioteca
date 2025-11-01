Public Class menuprin
    Private Sub menuprin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
        Form1.Visible = False
    End Sub

    Private Sub INSERTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSERTARToolStripMenuItem.Click
        lector.Show()
        lector.nombre.Enabled = True
        lector.grupo.Enabled = True
        lector.clvlec.Enabled = True

        lector.Insertar.Enabled = True
        lector.Eliminar.Enabled = False
        lector.Modificar.Enabled = False
        lector.Consultar.Enabled = False

    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        lector.Show()
        lector.nombre.Enabled = False
        lector.grupo.Enabled = False
        lector.clvlec.Enabled = True

        lector.Insertar.Enabled = False
        lector.Eliminar.Enabled = True
        lector.Modificar.Enabled = False
        lector.Consultar.Enabled = True
    End Sub

    Private Sub MODIFICARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem.Click
        lector.Show()
        lector.nombre.Enabled = True
        lector.grupo.Enabled = True
        lector.clvlec.Enabled = True

        lector.Insertar.Enabled = False
        lector.Eliminar.Enabled = False
        lector.Modificar.Enabled = True
        lector.Consultar.Enabled = True
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        lector.Show()
        lector.nombre.Enabled = False
        lector.grupo.Enabled = False
        lector.clvlec.Enabled = True

        lector.Insertar.Enabled = False
        lector.Eliminar.Enabled = False
        lector.Modificar.Enabled = False
        lector.Consultar.Enabled = True
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Form1.Enabled = True
        Form1.Visible = True
        Form1.mensaje()
        Close()
    End Sub
    Private Sub CONSULTAGENERALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTAGENERALToolStripMenuItem.Click
        consultagral.Show()
    End Sub

    Private Sub INSERTARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles INSERTARToolStripMenuItem1.Click
        Libro.Show()
        Libro.titulo.Enabled = True
        Libro.autor.Enabled = True
        Libro.edit.Enabled = True
        Libro.edic.Enabled = True
        Libro.pais.Enabled = True
        Libro.proced.Enabled = True
        Libro.observ.Enabled = True
        Libro.isbn.Enabled = True
        Libro.estado.Enabled = False
        Libro.nolib.Enabled = True
        Libro.significado.Enabled = False

        Libro.Insertar.Enabled = True
        Libro.Eliminar.Enabled = False
        Libro.Modificar.Enabled = False
        Libro.Consultar.Enabled = False
    End Sub

    Private Sub ELIMINARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem1.Click
        Libro.Show()
        Libro.titulo.Enabled = False
        Libro.autor.Enabled = False
        Libro.edit.Enabled = False
        Libro.edic.Enabled = False
        Libro.pais.Enabled = False
        Libro.proced.Enabled = False
        Libro.observ.Enabled = False
        Libro.isbn.Enabled = False
        Libro.estado.Enabled = False
        Libro.nolib.Enabled = True
        Libro.significado.Enabled = False

        Libro.Insertar.Enabled = False
        Libro.Eliminar.Enabled = True
        Libro.Modificar.Enabled = False
        Libro.Consultar.Enabled = True

    End Sub

    Private Sub MODIFICARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem1.Click
        Libro.Show()
        Libro.titulo.Enabled = True
        Libro.autor.Enabled = True
        Libro.edit.Enabled = True
        Libro.edic.Enabled = True
        Libro.pais.Enabled = True
        Libro.proced.Enabled = True
        Libro.observ.Enabled = True
        Libro.isbn.Enabled = True
        Libro.estado.Enabled = True
        Libro.nolib.Enabled = True
        Libro.significado.Enabled = False

        Libro.Insertar.Enabled = False
        Libro.Eliminar.Enabled = False
        Libro.Modificar.Enabled = True
        Libro.Consultar.Enabled = True
    End Sub

    Private Sub CONSULTARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem1.Click
        Libro.Show()
        Libro.titulo.Enabled = False
        Libro.autor.Enabled = False
        Libro.edit.Enabled = False
        Libro.edic.Enabled = False
        Libro.pais.Enabled = False
        Libro.proced.Enabled = False
        Libro.observ.Enabled = False
        Libro.isbn.Enabled = False
        Libro.estado.Enabled = False
        Libro.nolib.Enabled = True
        Libro.significado.Enabled = False

        Libro.Insertar.Enabled = False
        Libro.Eliminar.Enabled = False
        Libro.Modificar.Enabled = False
        Libro.Consultar.Enabled = True
    End Sub

    Private Sub CONSULTAGENERALToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CONSULTAGENERALToolStripMenuItem1.Click
        ConsultaLibro.Show()
    End Sub

    Private Sub INSERTARToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles INSERTARToolStripMenuItem2.Click
        Prestamo.Show()
        Prestamo.clvprest.Enabled = False
        Prestamo.fprest.Enabled = False
        Prestamo.fdev.Enabled = True
        Prestamo.nolib.Enabled = True
        Prestamo.clvlec.Enabled = True

        Prestamo.Insertar.Enabled = True
        Prestamo.Consultar.Enabled = False
    End Sub

    Private Sub MODIFICARToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        Prestamo.Show()
        Prestamo.clvprest.Enabled = True
        Prestamo.fprest.Enabled = False
        Prestamo.fdev.Enabled = True
        Prestamo.nolib.Enabled = False
        Prestamo.clvlec.Enabled = False

        Prestamo.Insertar.Enabled = False
        Prestamo.Consultar.Enabled = True
    End Sub

    Private Sub MODIFICARToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem2.Click
        Prestamo.Show()
        Prestamo.clvprest.Enabled = True
        Prestamo.fprest.Enabled = False
        Prestamo.fdev.Enabled = False
        Prestamo.nolib.Enabled = False
        Prestamo.clvlec.Enabled = False

        Prestamo.Insertar.Enabled = False
        Prestamo.Consultar.Enabled = True
    End Sub

    Private Sub CONSULTAGENERALToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CONSULTAGENERALToolStripMenuItem2.Click
        ConsultaPrestamo.Show()
    End Sub
End Class