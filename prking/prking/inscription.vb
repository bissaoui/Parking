Public Class inscription

    Private Sub inscription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f1 As New Form1
        f1.Show()
        Me.Hide()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_ddn.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_nom.TextChanged
        id_nom.BackColor = Color.PowderBlue
    End Sub

    Private Sub id_mail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_email.TextChanged
        id_email.BackColor = Color.PowderBlue
    End Sub

    Private Sub id_mdp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_mdp.TextChanged
        id_mdp.BackColor = Color.PowderBlue
    End Sub

    Private Sub id_conf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_cmdp.TextChanged
        id_cmdp.BackColor = Color.PowderBlue
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nom As String = id_nom.Text
        Dim email As String = id_email.Text
        Dim dateDeNaissance As String = id_ddn.Value.ToShortDateString
        Dim motdepasse As String = id_mdp.Text
        Dim confirmation As String = id_cmdp.Text
        If nom = "" Or email = "" Or motdepasse = "" Or confirmation = "" Then
            MessageBox.Show("remplire les champs obligatoires")
        ElseIf motdepasse <> confirmation Then
            MessageBox.Show("les deux mots de passes ne sont pas validés ")
        Else
            If id_sexe.Text = "Homme" Then
                MessageBox.Show("Mr" + nom + " votre inscription est en cours de traitement ")
            Else
                MessageBox.Show("Mme/Mlle" + nom + " votre inscription est en cours de traitement ")
            End If
        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f1 As New Form1
        f1.Show()
        Me.Hide()


    End Sub
End Class