<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestion_utilisateur
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.id_mp = New System.Windows.Forms.TextBox()
        Me.id_mail = New System.Windows.Forms.TextBox()
        Me.id_nom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_cmp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(506, 354)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Supprimer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(406, 354)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Modifier"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(288, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Entrer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Initialiser"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(327, 102)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(461, 201)
        Me.ListView1.TabIndex = 31
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'id_mp
        '
        Me.id_mp.Location = New System.Drawing.Point(155, 191)
        Me.id_mp.Name = "id_mp"
        Me.id_mp.Size = New System.Drawing.Size(160, 20)
        Me.id_mp.TabIndex = 28
        '
        'id_mail
        '
        Me.id_mail.Location = New System.Drawing.Point(155, 155)
        Me.id_mail.Name = "id_mail"
        Me.id_mail.Size = New System.Drawing.Size(160, 20)
        Me.id_mail.TabIndex = 27
        '
        'id_nom
        '
        Me.id_nom.Location = New System.Drawing.Point(155, 122)
        Me.id_nom.Name = "id_nom"
        Me.id_nom.Size = New System.Drawing.Size(160, 20)
        Me.id_nom.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Mot de passe :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Liste d'utilisation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "E-mail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nom :"
        '
        'id_cmp
        '
        Me.id_cmp.Location = New System.Drawing.Point(155, 223)
        Me.id_cmp.Name = "id_cmp"
        Me.id_cmp.Size = New System.Drawing.Size(160, 20)
        Me.id_cmp.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Confirmation Mot de passe :"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(17, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 36)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Retour"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'gestion_utilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.id_cmp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.id_mp)
        Me.Controls.Add(Me.id_mail)
        Me.Controls.Add(Me.id_nom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "gestion_utilisateur"
        Me.Text = "gestion_utilisateur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents id_mp As TextBox
    Friend WithEvents id_mail As TextBox
    Friend WithEvents id_nom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents id_cmp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
End Class
