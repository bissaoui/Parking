<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inscription
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inscription))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.id_nom = New System.Windows.Forms.TextBox()
        Me.id_email = New System.Windows.Forms.TextBox()
        Me.id_mdp = New System.Windows.Forms.TextBox()
        Me.id_cmdp = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.id_sexe = New System.Windows.Forms.ComboBox()
        Me.id_ddn = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenue sur la page inscription"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(293, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "E-Mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(293, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sexe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(293, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date de naissance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(293, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mot de passe "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(293, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "confirmation"
        '
        'id_nom
        '
        Me.id_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_nom.Location = New System.Drawing.Point(426, 99)
        Me.id_nom.Name = "id_nom"
        Me.id_nom.Size = New System.Drawing.Size(230, 23)
        Me.id_nom.TabIndex = 7
        '
        'id_email
        '
        Me.id_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_email.Location = New System.Drawing.Point(426, 133)
        Me.id_email.Name = "id_email"
        Me.id_email.Size = New System.Drawing.Size(230, 23)
        Me.id_email.TabIndex = 8
        '
        'id_mdp
        '
        Me.id_mdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_mdp.Location = New System.Drawing.Point(426, 238)
        Me.id_mdp.Name = "id_mdp"
        Me.id_mdp.Size = New System.Drawing.Size(230, 23)
        Me.id_mdp.TabIndex = 11
        '
        'id_cmdp
        '
        Me.id_cmdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_cmdp.Location = New System.Drawing.Point(426, 270)
        Me.id_cmdp.Name = "id_cmdp"
        Me.id_cmdp.Size = New System.Drawing.Size(230, 23)
        Me.id_cmdp.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(558, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 37)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(426, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 37)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Retour"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'id_sexe
        '
        Me.id_sexe.FormattingEnabled = True
        Me.id_sexe.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.id_sexe.Location = New System.Drawing.Point(428, 175)
        Me.id_sexe.Name = "id_sexe"
        Me.id_sexe.Size = New System.Drawing.Size(103, 21)
        Me.id_sexe.TabIndex = 15
        '
        'id_ddn
        '
        Me.id_ddn.Location = New System.Drawing.Point(434, 205)
        Me.id_ddn.Name = "id_ddn"
        Me.id_ddn.Size = New System.Drawing.Size(221, 20)
        Me.id_ddn.TabIndex = 16
        '
        'inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(967, 501)
        Me.Controls.Add(Me.id_ddn)
        Me.Controls.Add(Me.id_sexe)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.id_cmdp)
        Me.Controls.Add(Me.id_mdp)
        Me.Controls.Add(Me.id_email)
        Me.Controls.Add(Me.id_nom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "inscription"
        Me.Text = "inscription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents id_nom As System.Windows.Forms.TextBox
    Friend WithEvents id_email As System.Windows.Forms.TextBox
    Friend WithEvents id_mdp As System.Windows.Forms.TextBox
    Friend WithEvents id_cmdp As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents id_sexe As System.Windows.Forms.ComboBox
    Friend WithEvents id_ddn As System.Windows.Forms.DateTimePicker
End Class
