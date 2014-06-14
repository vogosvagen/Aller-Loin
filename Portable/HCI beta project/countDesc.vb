Public Class countDesc
    Dim position As Integer = 0
    Public speed As Integer = 3000
    Public country As String
    Dim liked As Boolean = False
    Dim dislike As Boolean = False
    Dim rate As String

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer2.Start()
        GroupBox1.Hide()

        Me.Text = "Aller Loin- " & country
        If home.signedin Then
            If country = "South Africa" Then
                rate = conModule.checkRate(home.username, "SArate")
                If rate = "null" Then
                    liked = False
                    dislike = False
                ElseIf rate = "true" Then
                    liked = True
                    dislike = False
                ElseIf rate = "false" Then
                    liked = False
                    dislike = True
                End If
            End If
            If country = "France" Then
                rate = conModule.checkRate(home.username, "FRArate")
                If rate = "null" Then
                    liked = False
                    dislike = False
                ElseIf rate = "true" Then
                    liked = True
                    dislike = False
                ElseIf rate = "false" Then
                    liked = False
                    dislike = True
                End If
            End If
            If country = "Canada" Then
                rate = conModule.checkRate(home.username, "CANArate")
                If rate = "null" Then
                    liked = False
                    dislike = False
                ElseIf rate = "true" Then
                    liked = True
                    dislike = False
                ElseIf rate = "false" Then
                    liked = False
                    dislike = True
                End If
            End If

            If country = "Brazil" Then
                rate = conModule.checkRate(home.username, "BRArate")
                If rate = "null" Then
                    liked = False
                    dislike = False
                ElseIf rate = "true" Then
                    liked = True
                    dislike = False
                ElseIf rate = "false" Then
                    liked = False
                    dislike = True
                End If
            End If
        End If

        If liked Then
            PictureBox6.Image = System.Drawing.Image.FromFile("upvotef.png")
        Else
            PictureBox6.Image = System.Drawing.Image.FromFile("upvotee.png")
        End If

        If dislike Then
            PictureBox10.Image = System.Drawing.Image.FromFile("downvotef.png")
        Else
            PictureBox10.Image = System.Drawing.Image.FromFile("downvotee.png")
        End If

        If main.slider Then
            Timer1.Interval = speed
        End If
        'AFRICA CONNECTION
        If country = "South Africa" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("SAbacg.jpg")
            If checkfave(home.username, "SA") Then
                PictureBox9.Image = System.Drawing.Image.FromFile("star on.png")
            Else
                PictureBox9.Image = System.Drawing.Image.FromFile("star off.png")
            End If
            Label2.Text = conModule.countups("SArate")
            Label3.Text = conModule.countdowns("SArate")
        End If

        'MALAY CONNECTION
        If country = "Malaysia" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("MALYbaci.jpg")
            If checkfave(home.username, "MALY") Then
                PictureBox9.Image = System.Drawing.Image.FromFile("star on.png")
            Else
                PictureBox9.Image = System.Drawing.Image.FromFile("star off.png")
            End If
        End If

        'FRANCE CONNECTION
        If country = "France" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("FRbackg.jpg")
            If checkfave(home.username, "FRA") Then
                PictureBox9.Image = System.Drawing.Image.FromFile("star on.png")
            Else
                PictureBox9.Image = System.Drawing.Image.FromFile("star off.png")
            End If
            Label2.Text = conModule.countups("FRArate")
            Label3.Text = conModule.countdowns("FRArate")
        End If

        'CANADA CONNECTION
        If country = "Canada" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("CAbckg2.jpg")
            If checkfave(home.username, "CANA") Then
                PictureBox9.Image = System.Drawing.Image.FromFile("star on.png")
            Else
                PictureBox9.Image = System.Drawing.Image.FromFile("star off.png")
            End If
        End If
        If country = "Brazil" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("brazil bckg.jpg")
            If checkfave(home.username, "BRA") Then
                PictureBox9.Image = System.Drawing.Image.FromFile("star on.png")
            Else
                PictureBox9.Image = System.Drawing.Image.FromFile("star off.png")
            End If
        End If
        Timer1.Start()


        Label1.Text = country
        p0.Hide()
        p1.Hide()
        p2.Hide()
        p3.Hide()

        'SA PICS
        If country = "South Africa" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("SAhmpg1Big.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("SAhmpg1.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("SAhmpg2.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("SAhmpg3.jpg")
            PictureBox5.Image = System.Drawing.Image.FromFile("SAhmpg4Big.jpg")

            RichTextBox1.Text = "South Africa is a popular tourist destination, with around 860 000 arrivals per month (March 2008) of which around 210 000 are from outside the African continent. Revenue adding up to between 1% and 3% of GDP is generated by the tourism industry. Among the main attractions are the diverse and picturesque culture, the game reserves and the highly regarded wines."
            RichTextBox1.Width = 450
        End If
        'BRAZIL PICS
        If country = "Brazil" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("BRA1.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("BRA1.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("BRA2.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("BRA3.jpg")
            PictureBox5.Image = System.Drawing.Image.FromFile("BRA4.jpg")

            RichTextBox1.Text = "Tourism in Brazil is a growing sector and key to the economy of several regions of the country. The country had 5.7 million visitors in 2012, ranking in terms of the international tourist arrivals as the first main destination in South America, and second in Latin America after Mexico. Revenues from international tourists reached US$6.6 billion in 2012, continuing a recovery trend from the 2008-2009 economic crisis."
        End If
        'MALAY PICS
        If country = "Malaysia" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("MALAYhmpg1.png")
            PictureBox2.Image = System.Drawing.Image.FromFile("MALAYhmpg1s.png")
            PictureBox3.Image = System.Drawing.Image.FromFile("MALAYhmpg2s.png")
            PictureBox4.Image = System.Drawing.Image.FromFile("MALAYhmpg3s.png")
            PictureBox5.Image = System.Drawing.Image.FromFile("MALAYhmpg4s.png")

            RichTextBox1.Text = "Malaysia is a federal constitutional monarchy in Asia. It consists of thirteen states and three federal territories and has a total landmass of 329,847 square kilometres (127,350 sq mi) separated by the South China Sea into two similarly sized regions, Peninsular Malaysia and Malaysian Borneo. Land borders are shared with Thailand, Indonesia, and Brunei, and maritime borders exist with Singapore, Vietnam, and the Philippines. The capital city is Kuala Lumpur, while Putrajaya is the seat of the federal government. In 2010 the population was 28.33 million, with 22.6 million living on the Peninsula. The southernmost point of continental Eurasia, Tanjung Piai is in Malaysia, located in the tropics. It is one of 17 megadiverse countries on earth, with large numbers of endemic species."

        End If

        'FRANCE PICS
        If country = "France" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("FR1.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("FR1s.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("FR2s.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("FR3s.jpg")
            PictureBox5.Image = System.Drawing.Image.FromFile("FR4.jpg")

            RichTextBox1.Text = "France attracted 83 million foreign tourists in 2012, making it the most popular tourist destination in the world.[1] It is third in income from tourism due to briefer visits. 20% more tourists spent less than half as much as they did in the United States.France has 37 sites inscribed in UNESCO's World Heritage List and features cities of high cultural interest (Paris being the foremost, but also Toulouse, Strasbourg, Bordeaux, Lyon, and others), beaches and seaside resorts, ski resorts, and rural regions that many enjoy for their beauty and tranquillity (green tourism). Small and picturesque French villages of quality heritage (such as Collonges-la-Rouge or Locronan) are promoted through the association Les Plus Beaux Villages de France (litt.The Most Beautiful Villages of France). The Remarkable Gardens label is a list of the over two hundred gardens classified by the French Ministry of Culture. This label is intended to protect and promote remarkable gardens and parks."
        End If

        If country = "Canada" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("ca1.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("ca1.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("ca2.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("ca3.jpg")
            PictureBox5.Image = System.Drawing.Image.FromFile("ca4.jpg")

            RichTextBox1.Text = "Canada has a large domestic and foreign tourism industry. The second largest country in the world, Canada's incredible geographical variety is a significant tourist attractor. Much of the country's tourism is centered around Canada's four largest metropolitan areas, Toronto, Montreal, Vancouver, and Ottawa, well known for their culture, diversity, as well as the many national parks and historic sites. "

        End If
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        position += 1
        If position = 4 Then
            position = 0
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        position = position - 1
        If position = -1 Then
            position = 3
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If position = 0 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("SAhmpg1Big.jpg")
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("MALAYhmpg1.png")
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("FR1.jpg")
            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("CA1.jpg")
            ElseIf country = "Brazil" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("BRA1.jpg")
            End If
            p0.Show()
            p1.Hide()
            p2.Hide()
            p3.Hide()
        ElseIf position = 1 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("SAhmpg2Big.jpg")
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("MALAYhmpg2.png")
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("FR2.jpg")
            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("ca2.jpg")
            ElseIf country = "Brazil" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("BRA2.jpg")
            End If
            p1.Show()
            p0.Hide()
            p3.Hide()
            p2.Hide()
        ElseIf position = 2 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("SAhmpg3Big.jpg")
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("MALAYhmpg3.png")
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("FR3.jpg")
            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("CA3.jpg")
            ElseIf country = "Brazil" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("BRA3.jpg")
            End If
            p2.Show()
            p3.Hide()
            p0.Hide()
            p1.Hide()
        ElseIf position = 3 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("SAhmpg4Big.jpg")
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("MALAYhmpg4.png")
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("FR4.jpg")
            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("CA4.jpg")
            ElseIf country = "Brazil" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("BRA4.jpg")
            End If
            p3.Show()
            p0.Hide()
            p1.Hide()
            p2.Hide()
        End If

        If main.slider Then
            position += 1
            If position = -1 Then
                position = 3
            End If
            If position = 4 Then
                position = 0
            End If
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        position = 0
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        position = 1
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        position = 2
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        position = 3
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GroupBox1.Visible = True Then
            GroupBox1.Hide()
        Else
            GroupBox1.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'If country = "South Africa" Then
        '    countHot.Close()
        '    countHot.country = "South Africa"
        '    countHot.Show()
        'ElseIf country = "Malaysia" Then
        '    countHot.Close()
        '    countHot.country = "Malaysia"
        '    countHot.Show()
        'ElseIf country = "France" Then
        '    countHot.Close()
        '    countHot.country = "France"
        '    countHot.Show()
        'End If

        countHot.Close()
        countHot.country = country
        countHot.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'TIME
        If country = "South Africa" Then
            Label4.Text = DateTime.Now.AddHours(-1).ToShortTimeString & " (-1)"
        ElseIf country = "France" Then
            Label4.Text = DateTime.Now.AddHours(-1).ToShortTimeString & " (-1)"
        ElseIf country = "Malaysia" Then
            Label4.Text = DateTime.Now.AddHours(+5).ToShortTimeString & " (+5)"
        ElseIf country = "Canada" Then
            Label4.Text = DateTime.Now.AddHours(-7).ToShortTimeString & " (-7)"
            Label4.ForeColor = Color.Black
        ElseIf country = "Brazil" Then
            Label4.Text = DateTime.Now.AddHours(-7).ToShortTimeString & " (-6)"
            Label4.ForeColor = Color.Black
        End If
        'FAVORITE RT CHECK
        If home.signedin Then
            If country = "South Africa" Then
                If checkfave(home.username, "SA") Then
                    PictureBox9.Image = System.Drawing.Image.FromFile("star on.png")
                Else
                    PictureBox9.Image = System.Drawing.Image.FromFile("star off.png")
                End If
            ElseIf country = "Malaysia" Then
                If checkfave(home.username, "MALY") Then
                    PictureBox9.Image = System.Drawing.Image.FromFile("star on.png")
                Else
                    PictureBox9.Image = System.Drawing.Image.FromFile("star off.png")
                End If
            ElseIf country = "France" Then
                If checkfave(home.username, "FRA") Then
                    PictureBox9.Image = System.Drawing.Image.FromFile("star on.png")
                Else
                    PictureBox9.Image = System.Drawing.Image.FromFile("star off.png")
                End If
            ElseIf country = "Canada" Then
                If checkfave(home.username, "CANA") Then
                    PictureBox9.Image = System.Drawing.Image.FromFile("star on.png")
                Else
                    PictureBox9.Image = System.Drawing.Image.FromFile("star off.png")
                End If
            ElseIf country = "Brazil" Then
                If checkfave(home.username, "BRA") Then
                    PictureBox9.Image = System.Drawing.Image.FromFile("star on.png")
                Else
                    PictureBox9.Image = System.Drawing.Image.FromFile("star off.png")
                End If
            End If
        End If
        'RATE

        If home.signedin Then
            If country = "South Africa" Then
                If liked Then
                    conModule.rateup(home.username, "SArate")
                ElseIf dislike Then
                    conModule.ratedown(home.username, "SArate")
                Else
                    conModule.ratenull(home.username, "SArate")
                End If
            End If

            If country = "France" Then
                If liked Then
                    conModule.rateup(home.username, "FRArate")
                ElseIf dislike Then
                    conModule.ratedown(home.username, "FRArate")
                Else
                    conModule.ratenull(home.username, "FRArate")
                End If
            End If

            If country = "Canada" Then
                If liked Then
                    conModule.rateup(home.username, "CANArate")
                ElseIf dislike Then
                    conModule.ratedown(home.username, "CANArate")
                Else
                    conModule.ratenull(home.username, "CANArate")
                End If
            End If

            If country = "Brazil" Then
                If liked Then
                    conModule.rateup(home.username, "BRArate")
                ElseIf dislike Then
                    conModule.ratedown(home.username, "BRArate")
                Else
                    conModule.ratenull(home.username, "BRArate")
                End If
            End If
        End If
        'TIMER

        If country = "South Africa" Then
            Label2.Text = conModule.countups("SArate")
            Label3.Text = conModule.countdowns("SArate")
        End If

        If country = "France" Then
            Label2.Text = conModule.countups("FRArate")
            Label3.Text = conModule.countdowns("FRArate")
        End If

        If country = "Canada" Then
            Label2.Text = conModule.countups("CANArate")
            Label3.Text = conModule.countdowns("CANArate")
        End If

        If country = "Brazil" Then
            Label2.Text = conModule.countups("BRArate")
            Label3.Text = conModule.countdowns("BRArate")
        End If
        'If Form1.signedin Then
        '    If country = "South Africa" Then
        '        If checkfave(Form1.username, "SA") Then
        '            Button1.Text = "un Fave"
        '        Else
        '            Button1.Text = "fave"
        '        End If
        '    End If

        '    If country = "Malaysia" Then
        '        If checkfave(Form1.username, "MALY") Then
        '            Button1.Text = "un Fave"
        '        Else
        '            Button1.Text = "fave"
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        position = position - 1
        If position = -1 Then
            position = 3
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        position += 1
        If position = 4 Then
            position = 0
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If home.signedin Then
            If country = "South Africa" Then
                If checkfave(home.username, "SA") Then
                    unfave(home.username, "SA")
                Else
                    fave(home.username, "SA")
                End If

            End If

            If country = "Malaysia" Then
                If checkfave(home.username, "MALY") Then
                    unfave(home.username, "MALY")
                Else
                    fave(home.username, "MALY")
                End If

            End If

            If country = "France" Then
                If checkfave(home.username, "FRA") Then
                    unfave(home.username, "FRA")
                Else
                    fave(home.username, "FRA")
                End If
            End If
            If country = "Canada" Then
                If checkfave(home.username, "CANA") Then
                    unfave(home.username, "CANA")
                Else
                    fave(home.username, "CANA")
                End If
            End If

            If country = "Brazil" Then
                If checkfave(home.username, "BRA") Then
                    unfave(home.username, "BRA")
                Else
                    fave(home.username, "BRA")
                End If
            End If
        Else
            MessageBox.Show("please sign in")
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Timer1.Stop()
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            COuntRest.Close()
        COuntRest.country = country
            COuntRest.Show()
    End Sub

    Private Sub PictureBox6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseHover
        If liked And dislike Then
            PictureBox6.Image = System.Drawing.Image.FromFile("upvotee.png")
        ElseIf liked And Not dislike Then
            PictureBox6.Image = System.Drawing.Image.FromFile("upvotee.png")
        Else
            PictureBox6.Image = System.Drawing.Image.FromFile("upvotef.png")
        End If
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        If liked Then
            PictureBox6.Image = System.Drawing.Image.FromFile("upvotef.png")
        Else
            PictureBox6.Image = System.Drawing.Image.FromFile("upvotee.png")
        End If
    End Sub

    Private Sub PictureBox10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseHover
        If dislike And Not liked Then
            PictureBox10.Image = System.Drawing.Image.FromFile("downvotee.png")
        Else
            PictureBox10.Image = System.Drawing.Image.FromFile("downvotef.png")
        End If
    End Sub

    Private Sub PictureBox10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseLeave
        If dislike And Not liked Then
            PictureBox10.Image = System.Drawing.Image.FromFile("downvotef.png")
        Else
            PictureBox10.Image = System.Drawing.Image.FromFile("downvotee.png")
        End If
    End Sub

    Private Sub PictureBox6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If home.signedin Then

            If liked And Not dislike Then
                PictureBox6.Image = System.Drawing.Image.FromFile("upvotee.png")
                liked = False
            ElseIf Not liked And dislike Then
                PictureBox6.Image = System.Drawing.Image.FromFile("upvotef.png")
                PictureBox10.Image = System.Drawing.Image.FromFile("downvotee.png")
                liked = True
                dislike = False
            ElseIf Not liked And Not dislike Then
                PictureBox6.Image = System.Drawing.Image.FromFile("upvotef.png")
                liked = True
            End If
        Else
            MessageBox.Show("please sign in")
        End If
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        If home.signedin Then
            If dislike And Not liked Then
                PictureBox10.Image = System.Drawing.Image.FromFile("downvotee.png")
                dislike = False
            ElseIf Not dislike And liked Then
                PictureBox10.Image = System.Drawing.Image.FromFile("downvotef.png")
                PictureBox6.Image = System.Drawing.Image.FromFile("upvotee.png")
                dislike = True
                liked = False
            ElseIf Not dislike And Not liked Then
                PictureBox10.Image = System.Drawing.Image.FromFile("downvotef.png")
                dislike = True
            End If
        Else
            MessageBox.Show("please sign in")
        End If
    End Sub

    Private Sub Form4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        GroupBox1.Hide()
    End Sub


End Class