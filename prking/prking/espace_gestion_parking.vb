Public Class espace_gestion_parking
    Private Sub espace_gestion_parking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim GV As New gestion_voitures
        GV.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim GC As New gestion_camion
        GC.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim GU As New gestion_utilisateur
        GU.show()
        Me.Hide()
    End Sub
End Class