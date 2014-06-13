Public Class options

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        If main.slider Then
            Button1.Text = "on"
        Else
            Button1.Text = "off"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim temp As String
        If countDesc.Visible = True Then
            MessageBox.Show("Reseting " & countDesc.country & " page")
            temp = countDesc.country
            countDesc.Close()
            If main.slider Then
                main.slider = False
            Else
                main.slider = True
            End If
            countDesc.country = temp
            countDesc.Show()
        Else
            If main.slider Then
                main.slider = False
            Else
                main.slider = True
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If main.slider Then
            Button1.Text = "on"
        Else
            Button1.Text = "off"
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim temp As String
        If countDesc.Visible = True Then
            MessageBox.Show("Reseting " & countDesc.country & " page")
            temp = countDesc.country
            countDesc.Close()
            If main.slider Then
                main.slider = False
            Else
                main.slider = True
            End If
            countDesc.country = temp
            countDesc.Show()
        Else
            If main.slider Then
                main.slider = False
            Else
                main.slider = True
            End If
        End If
    End Sub
End Class