Public Class Fmr_Login
    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        Dim login As Boolean
        If Me.Nome_TextBox.Text = "" Or Me.Senha_TextBox.Text = "" Then
            MsgBox("Preencha nome ou senha")
        Else
            Dim c As New Connect
            If c.Conect() = True Then
                If c.Login(Me.Nome_TextBox.Text, Me.Senha_TextBox.Text) = True Then
                    login = True
                End If
                c.FechaConect()
            End If
        End If
    End Sub

    Private Sub Cadastro_Button_Click(sender As Object, e As EventArgs) Handles Cadastro_Button.Click

    End Sub
End Class
