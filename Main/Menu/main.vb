Public Class main
    Public slider As Boolean = False
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Hide()
        Timer1.Start()
        TextBox2.Hide()
        TextBox3.Hide()
        Button4.Hide()
        ComboBox1.Hide()
        LinkLabel2.Hide()
        LinkLabel3.Hide()
        LinkLabel4.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()

    End Sub

    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        home.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.Show()
        Button1.Hide()
        Button5.Hide()
        Button6.Hide()
        LinkLabel4.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        PictureBox1.Hide()
        If ComboBox1.SelectedItem = "Africa" Then
            LinkLabel2.Show()
            LinkLabel2.Text = "South Africa"
            LinkLabel3.Show()
            LinkLabel3.Text = "Egypt"
            Label2.Show()
            Label2.Text = "Morocco"
            Label3.Show()
            Label3.Text = "Tunisia"
            Label4.Show()
            Label4.Text = "Mali"
            Label5.Show()
            Label5.Text = "Madagascar"
            Label6.Show()
            Label6.Text = "Mozambique"
        End If

        If ComboBox1.SelectedItem = "Asia" Then
            LinkLabel2.Show()
            LinkLabel2.Text = "Malaysia"
            LinkLabel3.Show()
            LinkLabel3.Text = "Japan"
            Label2.Show()
            Label2.Text = "China"
            Label3.Show()
            Label3.Text = "Russia"
            Label4.Show()
            Label4.Text = "South Korea"
            Label5.Show()
            Label5.Text = "India"
            Label6.Hide()
            'Label6.Text = "Mozambique"
        End If

        If ComboBox1.SelectedItem = "Europe" Then
            LinkLabel2.Show()
            LinkLabel2.Text = "France"
            LinkLabel3.Show()
            LinkLabel3.Text = "Germany"
            Label2.Show()
            Label2.Text = "Spain"
            Label3.Show()
            Label3.Text = "Italy"
            Label4.Show()
            Label4.Text = "Portugal"
            Label5.Show()
            Label5.Text = "England"
            Label6.Show()
            Label6.Text = "Turkey"
        End If

        If ComboBox1.SelectedItem = "North America" Then
            LinkLabel2.Show()
            LinkLabel2.Text = "Canada"
            LinkLabel3.Show()
            LinkLabel3.Text = "USA"
            Label2.Show()
            Label2.Text = "Mexico"
            Label3.Show()
            Label3.Text = "Jamaica"
            Label4.Show()
            Label4.Text = "Cuba"
            Label5.Show()
            Label5.Text = "Dominican Republic"
            Label6.Show()
            Label6.Text = "El Salvador"
        End If

        If ComboBox1.SelectedItem = "South America" Then
            LinkLabel2.Show()
            LinkLabel2.Text = "Brazil"
            LinkLabel3.Show()
            LinkLabel3.Text = "Argentina"
            Label2.Show()
            Label2.Text = "Bolivia"
            Label3.Show()
            Label3.Text = "Uruguay"
            Label4.Show()
            Label4.Text = "Paraguay"
            Label5.Show()
            Label5.Text = "Chile"
            Label6.Show()
            Label6.Text = "Colombia"
        End If
    End Sub

    Private Sub LinkLabel2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel2.MouseHover

        If LinkLabel2.Text = "South Africa" Then
            PictureBox1.Show()
            PictureBox1.Image = System.Drawing.Image.FromFile("SAFm.jpg")

        End If
    End Sub

    Private Sub LinkLabel3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel3.MouseHover

        If LinkLabel3.Text = "Egypt" Then
            PictureBox1.Show()
            PictureBox1.Image = System.Drawing.Image.FromFile("EGPm.jpg")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If home.signedin Then
            home.signedin = False
            home.admin = False
            LinkLabel1.Text = "sign in"
            LinkLabel1.Show()
        Else
            Label1.Hide()
            TextBox2.Show()
            TextBox3.Show()
            Button4.Show()
            LinkLabel1.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label7.Text = DateTime.Now.ToShortTimeString
        If home.signedin Then
            Label1.Text = "Welcome back, " & home.username
            Label1.Show()
            If home.admin Then
                Label1.Text = "admin: " & home.username


            End If
            LinkLabel1.Text = "sign out"
            LinkLabel1.Show()
        Else
            Label1.Hide()
            LinkLabel1.Text = "sign in"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If conModule.make_con(TextBox2.Text) And conModule.make_pcon(TextBox3.Text) Then
            home.signedin = True
            home.username = TextBox2.Text
            If home.username = "v" Then
                home.admin = True
            End If
            TextBox2.Text = ""
            TextBox2.Hide()
            TextBox3.Hide()
            TextBox3.Text = ""
            Button4.Hide()
        Else
            MsgBox("Username or Password is incorrect", vbCritical)
        End If
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        ComboBox1.Hide()
        ComboBox1.SelectedIndex = -1
        ComboBox1.Text = "Country Select"
        LinkLabel2.Hide()
        LinkLabel3.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        LinkLabel4.Hide()
        Button1.Show()
        Button5.Show()
        Button6.Show()
        PictureBox1.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        countDesc.Close()
        countDesc.country = LinkLabel2.Text
        countDesc.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MessageBox.Show("Will be added soon!")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        favorites.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        options.Show()
    End Sub

    Private Sub LinkLabel2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel2.MouseLeave
        PictureBox1.Hide()
    End Sub

    Private Sub LinkLabel3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel3.MouseLeave
        PictureBox1.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "South Africa" Or TextBox1.Text = "Africa" Or TextBox1.Text = "africa" Or TextBox1.Text = "south africa" Or TextBox1.Text = "southafrica" Or TextBox1.Text = "south" Then
            countDesc.Close()
            countDesc.country = "South Africa"
            countDesc.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "France" Or TextBox1.Text = "france" Then
            countDesc.Close()
            countDesc.country = "France"
            countDesc.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Malaysia" Or TextBox1.Text = "malaysia" Or TextBox1.Text = "malysia" Or TextBox1.Text = "Malysia" Then
            countDesc.Close()
            countDesc.country = "Malaysia"
            countDesc.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Canada" Or TextBox1.Text = "canada" Then
            countDesc.Close()
            countDesc.country = "Canada"
            countDesc.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Brazil" Or TextBox1.Text = "brazil" Or TextBox1.Text = "Brasil" Or TextBox1.Text = "brasil" Then
            countDesc.Close()
            countDesc.country = "Brazil"
            countDesc.Show()
            TextBox1.Text = ""
        Else
            MsgBox("Country Not Found", vbCritical)
        End If
    End Sub

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Search Country" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        If home.signedin Then
            If MsgBox("Sign out?", vbYesNo) = vbYes Then
                home.signedin = False
                home.username = ""
                home.admin = False
                home.Show()
                Hide()
            End If
        Else
            home.Show()
            Hide()
        End If


    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Button4_Click(sender, e)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.PasswordChar = "*"
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Button3_Click(sender, e)
            e.Handled = True
        End If
    End Sub
End Class