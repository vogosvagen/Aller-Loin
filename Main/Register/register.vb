Public Class register

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            If TextBox2.Text = TextBox3.Text Then
                If conModule.setdata(TextBox1.Text, TextBox2.Text) Then
                    MsgBox("Added.", vbInformation)
                    Close()
                Else

                    MsgBox("Error.", vbCritical)
                End If
            Else
                MsgBox("password does not match confirm password.", vbCritical)
            End If
        Else

            MsgBox("Please fill both fields.", vbCritical)
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.PasswordChar = "*"
    End Sub
End Class