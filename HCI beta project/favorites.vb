Public Class favorites

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        LinkLabel1.Hide()
        LinkLabel2.Hide()
        LinkLabel3.Hide()
        LinkLabel4.Hide()
        LinkLabel5.Hide()
        If home.signedin Then
            If checkfave(home.username, "SA") Then
                LinkLabel1.Show()
                LinkLabel1.Text = "South Africa"
            Else
                LinkLabel1.Hide()
            End If

            If checkfave(home.username, "MALY") Then
                LinkLabel2.Show()
                LinkLabel2.Text = "Malaysia"
            Else
                LinkLabel2.Hide()
            End If

            If checkfave(home.username, "FRA") Then
                LinkLabel3.Show()
                LinkLabel3.Text = "France"
            Else
                LinkLabel3.Hide()
            End If

            If checkfave(home.username, "CANA") Then
                LinkLabel4.Show()
                LinkLabel4.Text = "Canada"
            Else
                LinkLabel4.Hide()
            End If

            If checkfave(home.username, "BRA") Then
                LinkLabel5.Show()
                LinkLabel5.Text = "Brazil"
            Else
                LinkLabel5.Hide()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If home.signedin Then
            If checkfave(home.username, "SA") Then
                LinkLabel1.Show()
                LinkLabel1.Text = "South Africa"
            Else
                LinkLabel1.Hide()
            End If

            If checkfave(home.username, "MALY") Then
                LinkLabel2.Show()
                LinkLabel2.Text = "Malaysia"
            Else
                LinkLabel2.Hide()
            End If

            If checkfave(home.username, "FRA") Then
                LinkLabel3.Show()
                LinkLabel3.Text = "France"
            Else
                LinkLabel3.Hide()
            End If

            If checkfave(home.username, "CANA") Then
                LinkLabel4.Show()
                LinkLabel4.Text = "Canada"
            Else
                LinkLabel4.Hide()
            End If

            If checkfave(home.username, "BRA") Then
                LinkLabel5.Show()
                LinkLabel5.Text = "Brazil"
            Else
                LinkLabel5.Hide()
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        countDesc.Close()
        countDesc.country = LinkLabel1.Text
        countDesc.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        countDesc.Close()
        countDesc.country = LinkLabel2.Text
        countDesc.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        countDesc.Close()
        countDesc.country = LinkLabel3.Text
        countDesc.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        countDesc.Close()
        countDesc.country = LinkLabel4.Text
        countDesc.Show()
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        countDesc.Close()
        countDesc.country = LinkLabel5.Text
        countDesc.Show()
    End Sub
End Class