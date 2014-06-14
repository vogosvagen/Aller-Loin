Public Class home
    Public signedin As Boolean = False
    Public username As String
    Public admin As Boolean = False
    Dim a(100) As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If conModule.make_con(TextBox1.Text) And conModule.make_pcon(TextBox2.Text) Then
            signedin = True
            username = TextBox1.Text
            If username = "v" Then
                admin = True
            Else
                admin = False
            End If
            main.Show()

            Hide()
            TextBox1.Text = "Username"
            TextBox2.Text = "Password"
        Else
            MessageBox.Show("Username or password is incorrect")
            signedin = False
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getdata()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        register.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Hide()
        TextBox1.Text = "Username"
        TextBox2.Text = "Password"
        main.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim i As Integer = 0
        a(0) = "Welcome"
        a(1) = "Bienvenue"
        a(2) = "歓迎"
        a(3) = "أهلا وسهلا"
        a(4) = "에 오신 것을 환영합니다!"
        Dim generator As System.Random = New System.Random()
        Dim randomnumber = generator.Next(5)
        Label1.Text = a(randomnumber)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("5od")
    End Sub


    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Username" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Click
        If TextBox2.Text = "Password" Then
            TextBox2.Text = ""
            TextBox2.PasswordChar = "*"
        End If
        'TextBox2.PasswordChar = "*"
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Button2_Click(sender, e)
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub
End Class
