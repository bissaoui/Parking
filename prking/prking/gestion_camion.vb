Public Class gestion_camion
    Dim cnp As Integer = 10
    Private Sub gestion_camion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("Chauffeur")
        ListView1.Columns.Add("Immatriculation")
        ListView1.Columns.Add("Nombre de places")
        ListView1.Columns.Add("Marques")
        ListView1.Columns.Add("Date d'entree")
        ListView1.Columns.Add("Date de sortie")
        id_erreur.Visible = False
        id_autre.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cnp = 0 Then
            id_erreur.Visible = True
            id_autre.Enabled = False
            id_chauf.Enabled = False
            id_datE.Enabled = False
            id_dateS.Enabled = False
            id_imm.Enabled = False
            id_ndp.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
        Else
            Dim chauffeur As String = id_chauf.Text
            Dim imma As String = id_imm.Text
            Dim nbAssure As String = id_ndp.Text
            Dim marque As String
            If RadioButton1.Checked Then
                marque = "MAN"
            ElseIf RadioButton2.Checked Then
                marque = "VOLVO"
            ElseIf RadioButton4.Checked Then
                marque = "MERCEDES BENZ"
            Else
                marque = id_autre.Text
            End If
            Dim dateEntree As String = id_datE.Value
            Dim dateSortie As String = "-"
            Dim element_camion As New ListViewItem(chauffeur)
            element_camion.SubItems.Add(imma)
            element_camion.SubItems.Add(nbAssure)
            element_camion.SubItems.Add(marque)
            element_camion.SubItems.Add(dateEntree)
            element_camion.SubItems.Add(dateSortie)
            ListView1.Items.Add(element_camion)
            id_autre.Text = ""
            id_imm.Text = ""
            id_chauf.Text = ""
            cnp = cnp - 1
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        id_autre.Visible = True

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        id_autre.Visible = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        id_autre.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        id_autre.Visible = False

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            id_chauf.Text = ListView1.SelectedItems(0).SubItems.Item(0).Text
            id_imm.Text = ListView1.SelectedItems(0).SubItems.Item(1).Text
            If RadioButton1.Text =
           ListView1.SelectedItems(0).SubItems.Item(3).Text Then
                RadioButton1.Checked = True
            ElseIf RadioButton2.Text =
           ListView1.SelectedItems(0).SubItems.Item(3).Text Then
                RadioButton2.Checked = True
            Else
                RadioButton3.Checked = True
                id_autre.Text =
               ListView1.SelectedItems(0).SubItems.Item(3).Text
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim chauffeur As String = id_chauf.Text
            Dim imma As String = id_imm.Text
            Dim nbAssure As String = id_ndp.Text
            Dim marque As String
            If RadioButton1.Checked Then
                marque = "MAN"
            ElseIf RadioButton2.Checked Then
                marque = "VOLVO"
            ElseIf RadioButton4.Checked Then
                marque = "MERCEDES BENZ"
            Else
                marque = id_autre.Text
            End If
            Dim dateEntree As String = id_datE.Value
            Dim dateSortie As String = "-"
            Dim element_camion As New ListViewItem(chauffeur)
            element_camion.SubItems.Add(imma)
            element_camion.SubItems.Add(nbAssure)
            element_camion.SubItems.Add(marque)
            element_camion.SubItems.Add(dateEntree)
            element_camion.SubItems.Add(dateSortie)
            ListView1.Items(ListView1.SelectedIndices(0)) = element_camion
            id_autre.Text = ""
            id_imm.Text = ""
            id_chauf.Text = ""
            cnp = cnp - 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim DateDeSortie As String = id_dateS.Value
            ListView1.Items(ListView1.SelectedIndices(0)).SubItems.Item(5).Text = DateDeSortie
            cnp = cnp + 1
            id_chauf.Text = ""
            id_imm.Text = ""
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListView1.SelectedItems.Count > 0 Then
            MessageBox.Show(" Vous voulez supprimer le camion!")
            ListView1.Items(ListView1.SelectedIndices(0)).Remove()
            id_chauf.Text = ""
            id_imm.Text = ""
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim EGP As New espace_gestion_parking
        EGP.Show()
        Me.Hide()
    End Sub
End Class