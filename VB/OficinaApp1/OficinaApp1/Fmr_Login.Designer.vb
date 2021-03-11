<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fmr_Login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fmr_Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.Cadastro_Button = New System.Windows.Forms.Button()
        Me.Nome_Label = New System.Windows.Forms.Label()
        Me.Senha_Label = New System.Windows.Forms.Label()
        Me.Nome_TextBox = New System.Windows.Forms.TextBox()
        Me.Senha_TextBox = New System.Windows.Forms.TextBox()
        Me.Email_Label = New System.Windows.Forms.Label()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.OficinaApp1.My.Resources.Resources.wp2730030
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(690, 347)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Login_Button
        '
        Me.Login_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Login_Button.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Login_Button.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Login_Button.Location = New System.Drawing.Point(394, 227)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(174, 74)
        Me.Login_Button.TabIndex = 1
        Me.Login_Button.Text = "Logar"
        Me.Login_Button.UseVisualStyleBackColor = False
        '
        'Cadastro_Button
        '
        Me.Cadastro_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cadastro_Button.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Cadastro_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cadastro_Button.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cadastro_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cadastro_Button.Location = New System.Drawing.Point(115, 227)
        Me.Cadastro_Button.Name = "Cadastro_Button"
        Me.Cadastro_Button.Size = New System.Drawing.Size(174, 74)
        Me.Cadastro_Button.TabIndex = 2
        Me.Cadastro_Button.Text = "Cadastrar"
        Me.Cadastro_Button.UseVisualStyleBackColor = False
        '
        'Nome_Label
        '
        Me.Nome_Label.AutoSize = True
        Me.Nome_Label.BackColor = System.Drawing.SystemColors.MenuText
        Me.Nome_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Nome_Label.Location = New System.Drawing.Point(155, 45)
        Me.Nome_Label.Name = "Nome_Label"
        Me.Nome_Label.Size = New System.Drawing.Size(86, 31)
        Me.Nome_Label.TabIndex = 3
        Me.Nome_Label.Text = "Nome"
        '
        'Senha_Label
        '
        Me.Senha_Label.AutoSize = True
        Me.Senha_Label.BackColor = System.Drawing.SystemColors.MenuText
        Me.Senha_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Senha_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Senha_Label.Location = New System.Drawing.Point(432, 45)
        Me.Senha_Label.Name = "Senha_Label"
        Me.Senha_Label.Size = New System.Drawing.Size(92, 31)
        Me.Senha_Label.TabIndex = 4
        Me.Senha_Label.Text = "Senha"
        '
        'Nome_TextBox
        '
        Me.Nome_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_TextBox.Location = New System.Drawing.Point(115, 79)
        Me.Nome_TextBox.Name = "Nome_TextBox"
        Me.Nome_TextBox.Size = New System.Drawing.Size(174, 31)
        Me.Nome_TextBox.TabIndex = 5
        '
        'Senha_TextBox
        '
        Me.Senha_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Senha_TextBox.Location = New System.Drawing.Point(394, 79)
        Me.Senha_TextBox.Name = "Senha_TextBox"
        Me.Senha_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Senha_TextBox.Size = New System.Drawing.Size(174, 31)
        Me.Senha_TextBox.TabIndex = 6
        '
        'Email_Label
        '
        Me.Email_Label.AutoSize = True
        Me.Email_Label.BackColor = System.Drawing.SystemColors.MenuText
        Me.Email_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Email_Label.Location = New System.Drawing.Point(295, 97)
        Me.Email_Label.Name = "Email_Label"
        Me.Email_Label.Size = New System.Drawing.Size(81, 31)
        Me.Email_Label.TabIndex = 7
        Me.Email_Label.Text = "Email"
        '
        'Email_TextBox
        '
        Me.Email_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_TextBox.Location = New System.Drawing.Point(250, 131)
        Me.Email_TextBox.Name = "Email_TextBox"
        Me.Email_TextBox.Size = New System.Drawing.Size(174, 31)
        Me.Email_TextBox.TabIndex = 8
        '
        'Fmr_Login
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(675, 335)
        Me.Controls.Add(Me.Email_TextBox)
        Me.Controls.Add(Me.Email_Label)
        Me.Controls.Add(Me.Senha_TextBox)
        Me.Controls.Add(Me.Nome_TextBox)
        Me.Controls.Add(Me.Senha_Label)
        Me.Controls.Add(Me.Nome_Label)
        Me.Controls.Add(Me.Cadastro_Button)
        Me.Controls.Add(Me.Login_Button)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fmr_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Login_Button As Button
    Friend WithEvents Cadastro_Button As Button
    Friend WithEvents Nome_Label As Label
    Friend WithEvents Senha_Label As Label
    Friend WithEvents Nome_TextBox As TextBox
    Friend WithEvents Senha_TextBox As TextBox
    Friend WithEvents Email_Label As Label
    Friend WithEvents Email_TextBox As TextBox
End Class
