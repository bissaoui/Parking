Public Class gestion_utilisateur
    Dim cpn As Integer = 7
    Private Sub gestion_utilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("Nom")
        ListView1.Columns.Add("E-mail", 100)
        ListView1.Columns.Add("mot de passe", 100)
        ListView1.Columns.Add("Confirmation de mot de passe", 160)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cpn = 0 Then
            id_nom.Enabled = False
            id_mail.Enabled = False
            id_mp.Enabled = False
            id_cmp.Enabled = False
        Else
            Dim nom As String = id_nom.Text
            Dim email As String = id_mail.Text
            Dim motdepasse As String = id_mp.Text
            Dim confirmationMP As String = id_cmp.Text
            Dim utilisateur As New ListViewItem(nom)
            utilisateur.SubItems.Add(email)
            ListView1.Items.Add(utilisateur)
            id_nom.Text = ""
            id_mail.Text = ""
            id_mp.Text = ""
            id_cmp.Text = ""
            cpn = cpn - 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        id_nom.Text = ""
        id_mail.Text = ""
        id_mp.Text = ""
        id_cmp.Text = ""
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            id_nom.Text = ListView1.SelectedItems(0).SubItems.Item(0).Text
            id_mail.Text = ListView1.SelectedItems(0).SubItems.Item(1).Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim nom As String = id_nom.Text
            Dim email As String = id_mail.Text
            Dim motdepasse As String = id_mp.Text
            Dim confirmationMP As String = id_cmp.Text
            Dim utilisateur As New ListViewItem(nom)
            utilisateur.SubItems.Add(email)
            ListView1.Items(ListView1.SelectedIndices(0)) = utilisateur
            id_nom.Text = ""
            id_mail.Text = ""
            id_mp.Text = ""
            id_cmp.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListView1.SelectedItems.Count > 0 Then
            MessageBox.Show("Voulez-vous supprimer l'element ?")
            ListView1.Items(ListView1.SelectedIndices(0)).Remove()
            id_nom.Text = ""
            id_mail.Text = ""
            id_mp.Text = ""
            id_cmp.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim EGP As New espace_gestion_parking
        EGP.Show()
        Me.Hide()
    End Sub
End Class