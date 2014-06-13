Public Class COuntRest
    Public country As String
    Public restaurant As String
    Dim pos As Integer = 0
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Aller Loin- " & country & " Restaurants"
        p1.Hide()
        p2.Hide()
        'p3.Hide()
        Timer1.Start()
        If country = "South Africa" Then
            Label1.Text = "Restaurants in South Africa"
            Me.BackgroundImage = System.Drawing.Image.FromFile("SAbacg.jpg")
            PictureBox1.Image = System.Drawing.Image.FromFile("SArestaurant1.jpg")
            RichTextBox1.Text = "1.The Test Kitchen." & Environment.NewLine & Environment.NewLine & "Shop 104 A / The Old Biscuit Mill | 375 Albert Road, Cape Town Central, South Africa (Woodstock)" & Environment.NewLine & Environment.NewLine & "Cuisines: Contemporary" & Environment.NewLine & "Good for: Romantic, Business, Special Occasion Dining, Entertaining clientsDining options: Breakfast/Brunch, Lunch Spot, Dinner, Reservations, After-hoursNeighbourhood:  Woodstock()" & Environment.NewLine & Environment.NewLine & "http://www.thetestkitchen.co.za/"
            PictureBox2.Image = System.Drawing.Image.FromFile("SArestaurant1s.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("SArestaurant2s.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("SArestaurant3s.jpg")
        ElseIf country = "Canada" Then
            Label1.Text = "Restaurants in Canada"
            Me.BackgroundImage = System.Drawing.Image.FromFile("CAbckg2.jpg")
            PictureBox1.Image = System.Drawing.Image.FromFile("CAr1.jpg")
            RichTextBox1.Text = "CAr1 Station" & Environment.NewLine & Environment.NewLine & "1 CAr1 St. West, Toronto, Ontario, Canada Tel: (647) 748-1444" & Environment.NewLine & Environment.NewLine & "Cuisines: Eclectic" & Environment.NewLine & Environment.NewLine & "Dining options: Late Night " & Environment.NewLine & Environment.NewLine & "http://CAr1station.ca/"
            PictureBox2.Image = System.Drawing.Image.FromFile("CAr1.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("CAr2.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("CAr3.jpg")
        ElseIf country = "France" Then
            Label1.Text = "Restaurants in France"
            Me.BackgroundImage = System.Drawing.Image.FromFile("FRbackg.jpg")
            PictureBox1.Image = System.Drawing.Image.FromFile("epicure.jpg")
            RichTextBox1.Text = "Epicure" & Environment.NewLine & Environment.NewLine & "112 rue du Faubourg Saint-Honore, 75008 Paris, France Tel: +33 (0)1 53 43 43 40" & Environment.NewLine & Environment.NewLine & "Cuisines: French" & Environment.NewLine & Environment.NewLine & "Dining options: Breakfast/Brunch, Lunch, Dinner, Reservations, Delivery, Late Night" & Environment.NewLine & Environment.NewLine & "Good for: Romance, Doing business, Local cuisine, Outdoor seating, Special occasions, Entertaining clients" & Environment.NewLine & Environment.NewLine & "Description: Epicure, Le Bristol's triple Michelin-starred gastronomic restaurant, is located next to the hotel's magnificent French-style garden, and its bay windows allow diners to make the most of this lovely setting. Architect Pierre-Yves Rochon, in collaboration with Mrs Maja Oetker, has transformed the hotel's former summer restaurant into an exceptional, light-filled dining room, dedicated to the art of living, and the pleasure of savouring Eric Frechon's cuisine. Epicure is open every day for breakfast, lunch and dinner." & Environment.NewLine & Environment.NewLine & "http://CAr1station.ca/"
            PictureBox2.Image = System.Drawing.Image.FromFile("epicure s.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("seze s.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("pata s.jpg")
            'PictureBox5.Image = System.Drawing.Image.FromFile("don s.jpg")
        ElseIf country = "Brazil" Then
            Label1.Text = "Restaurants in Brazil"
            RichTextBox1.Text = "Restaurante Figueira Rubaiyat" & Environment.NewLine & Environment.NewLine & "A large and elegant restaurant where you get to eat outdoors, indoors! The dining room is built around an enormous fig tree and huge branches have been glassed in. Inventive architecture and interesting food. Very good fish and seafood (including Brazilian fish like the Tucunaré, Tambaqui and Pirarucu) plus serious steaks. A traditional feijoada - the heavy pork and black bean stew that is the national dish - is the special on Wednesdays and Saturdays. Very slick service and upper-middling prices."
            Me.BackgroundImage = System.Drawing.Image.FromFile("brazil bckg.jpg")
            PictureBox1.Image = System.Drawing.Image.FromFile("BRAr1.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("BRAr1s.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("BRAr2s.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("BRAr3s.jpg")
        ElseIf country = "Malaysia" Then
            Label1.Text = "Restaurants in Malaysia"
            Me.BackgroundImage = System.Drawing.Image.FromFile("MALYbaci.jpg")
            PictureBox1.Image = System.Drawing.Image.FromFile("MALr1.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("MALr1s.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("MALr2s.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("MALr3s.jpg")

        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        pos = pos - 1
        If pos = -1 Then
            pos = 2
        End If
        checkpos()
        
    End Sub

    Private Sub checkpos()
        If pos = 0 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("SArestaurant1.jpg")
                RichTextBox1.Text = "1.The Test Kitchen." & Environment.NewLine & Environment.NewLine & "Shop 104 A / The Old Biscuit Mill | 375 Albert Road, Cape Town Central, South Africa (Woodstock)" & Environment.NewLine & Environment.NewLine & "Cuisines: Contemporary" & Environment.NewLine & "Good for: Romantic, Business, Special Occasion Dining, Entertaining clientsDining options: Breakfast/Brunch, Lunch Spot, Dinner, Reservations, After-hoursNeighbourhood:  Woodstock()" & Environment.NewLine & Environment.NewLine & "http://www.thetestkitchen.co.za/"
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("epicure.jpg")
                RichTextBox1.Text = "Epicure" & Environment.NewLine & Environment.NewLine & "112 rue du Faubourg Saint-Honore, 75008 Paris, France Tel: +33 (0)1 53 43 43 40" & Environment.NewLine & Environment.NewLine & "Cuisines: French" & Environment.NewLine & Environment.NewLine & "Dining options: Breakfast/Brunch, Lunch, Dinner, Reservations, Delivery, Late Night" & Environment.NewLine & Environment.NewLine & "Good for: Romance, Doing business, Local cuisine, Outdoor seating, Special occasions, Entertaining clients" & Environment.NewLine & Environment.NewLine & "Description: Epicure, Le Bristol's triple Michelin-starred gastronomic restaurant, is located next to the hotel's magnificent French-style garden, and its bay windows allow diners to make the most of this lovely setting. Architect Pierre-Yves Rochon, in collaboration with Mrs Maja Oetker, has transformed the hotel's former summer restaurant into an exceptional, light-filled dining room, dedicated to the art of living, and the pleasure of savouring Eric Frechon's cuisine. Epicure is open every day for breakfast, lunch and dinner." & Environment.NewLine & Environment.NewLine & "http://CAr1station.ca/"
            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("CAr1.jpg")
                RichTextBox1.Text = "Richmond Station" & Environment.NewLine & Environment.NewLine & "1 Richmond St. West, Toronto, Ontario, Canada Tel: (647) 748-1444" & Environment.NewLine & Environment.NewLine & "Cuisines: Eclectic" & Environment.NewLine & Environment.NewLine & "Dining options: Late Night " & Environment.NewLine & Environment.NewLine & "http://richmondstation.ca/"
            ElseIf country = "Brazil" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("BRAr1.jpg")
                RichTextBox1.Text = "Restaurante Figueira Rubaiyat" & Environment.NewLine & Environment.NewLine & "A large and elegant restaurant where you get to eat outdoors, indoors! The dining room is built around an enormous fig tree and huge branches have been glassed in. Inventive architecture and interesting food. Very good fish and seafood (including Brazilian fish like the Tucunaré, Tambaqui and Pirarucu) plus serious steaks. A traditional feijoada - the heavy pork and black bean stew that is the national dish - is the special on Wednesdays and Saturdays. Very slick service and upper-middling prices."
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("MALr1.jpg")
                RichTextBox1.Text = "Frontera Sol of Mexico " & Environment.NewLine & Environment.NewLine & "72A Jalan Universiti | 72A Jalan Universiti, Petaling Jaya 46200, Malaysia " & Environment.NewLine & Environment.NewLine & "Tel: +60379588515" & Environment.NewLine & Environment.NewLine & "Web: http://www.fronterabar.com/"
            End If
            ' p3.Hide()
            p1.Hide()
            p0.Show()
            p2.Hide()
        ElseIf pos = 1 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("SArestaurant2.jpg")
                RichTextBox1.Text = "8.The Tasting Room at Le Quartier Français" & Environment.NewLine & Environment.NewLine & "Le Quartier Francais | 16 Huguenot Road, Franschhoek, South AfricaCuisines:       African, Contemporary, International" & Environment.NewLine & Environment.NewLine & "Good for: Romantic, Special Occasion Dining, Entertaining clients " & Environment.NewLine & Environment.NewLine & "Dining options: Lunch Spot, Dinner, Reservations, After-hours " & Environment.NewLine & Environment.NewLine & "http://www.lqf.co.za/restaurants/the-tasting-room.htm"
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("seze.jpg")
                RichTextBox1.Text = "Le Gourmet de Seze" & Environment.NewLine & Environment.NewLine & "129 Rue de Seze, Lyon, France (Marechal Lyautey - Vitton)  Tel: +33(0)478242342" & Environment.NewLine & Environment.NewLine & "Cuisines: French" & Environment.NewLine & Environment.NewLine & "Dining options: Lunch, Dinner, Reservations, Late Night" & Environment.NewLine & Environment.NewLine & "Good for: : Romance, Special occasions " & Environment.NewLine & Environment.NewLine & "Description: This restaurant, recommended by all the culinary guides and which received its first star from the Michelin Red Guide in February 2002, has opted for an intimate and convivial atmosphere with a deliberately small restaurant capacity. The nine tables, widely-spaced for the patrons' well-being, await you in a decor blending a contemporary style and warm tones." & Environment.NewLine & Environment.NewLine & "http://www.le-gourmet-de-seze.com/"
            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("CAr2.jpg")
                RichTextBox1.Text = "Restaurant Sel Gras" & Environment.NewLine & Environment.NewLine & "5245 Boulevard Saint Laurent, Montreal, Quebec H2T 1S4, Canada Tel: +1 514-564-1090" & Environment.NewLine & Environment.NewLine & "Cuisines: Mediterranean, Portuguese, Canadian, Fusion, Wine Bar, Oyster Bar " & Environment.NewLine & Environment.NewLine & "Dining options: Reservations, Late Night " & Environment.NewLine & Environment.NewLine & "http://www.selgras-montreal.com/"
            ElseIf country = "Brazil" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("BRAr2.jpg")
                RichTextBox1.Text = ". Speranza" & Environment.NewLine & Environment.NewLine & "It is said that every day a million pizzas are eaten in São Paulo and when you've seen the number and variety of pizza houses it rings true. Speranza opened its doors over 50 years ago and is still the pizza place of choice for discerning Paulistas. The margherita is the house speciality but everything stands up - good value and good pizzas fresh from the ovens."
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("MALr2.jpg")
                RichTextBox1.Text = "Madam Bee's Kitchen " & Environment.NewLine & Environment.NewLine & "177 Jalan Kampung Cina, Kuala Terengganu 21100, Malaysia " & Environment.NewLine & Environment.NewLine & "Tel: +6012-9216995"

            End If
            p0.Hide()
            p2.Hide()
            p1.Show()
        ElseIf pos = 2 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("SArestaurant3.jpg")
                RichTextBox1.Text = "The Place on the Bay." & Environment.NewLine & Environment.NewLine & "4 stars Hotel   |   Victoria Rd, Camps Bay 8001, South Africa." & Environment.NewLine & Environment.NewLine & "Web: http://placeonthebay.co.za/" & Environment.NewLine & Environment.NewLine & "Tel: +27 21 437 8500" & Environment.NewLine & Environment.NewLine & "Place on the Bay Hotel was built in 1989 and quickly became known as a holiday hot spot along the Camps Bay strip. As the hotel aged, it became evident that the property needed a lift. Knowing that self-catering accommodation in one of Cape Town’s trendiest suburbs could be a winning recipe, Louis Group Hotels, Spas & Vineyards saw the property as a great investment and became a majority shareholder in January 2008. After extensive renovations and refurbishments to the building, Place on the Bay Hotel has now been restored to its former glory and is enjoyed by guests from all over the world."
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("pata.jpg")
                RichTextBox1.Text = "La Maison du Pata Negra" & Environment.NewLine & Environment.NewLine & "Place des Capucins | Marche des Capucins, 33000 Bordeaux, France (Capucins) Tel: + (33) 5 56 88 59 92" & Environment.NewLine & Environment.NewLine & "Cuisines: Spanish, Tapas" & Environment.NewLine & Environment.NewLine & "Dining options: Breakfast/Brunch, Lunch, Takeout " & Environment.NewLine & Environment.NewLine & "Description: Our restaurant is located at the famous market place ‘marche des Capucins’. We are opened for lunch on Saturday and Sunday. We offer a huge variety of tapas (like you can find in several bars in Spain), and good and affordable Spanish Rioja red wine." & Environment.NewLine & Environment.NewLine & "http://www.maisondupatanegra.com/"
            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("CAr3.jpg")
                RichTextBox1.Text = "Continental Treat Fine Bistro" & Environment.NewLine & Environment.NewLine & "10560 82 Avenue, Edmonton, Alberta T6A 4T2, Canada (Strathcona) Tel: +1 780-433-7432" & Environment.NewLine & Environment.NewLine & "Cuisines: Mediterranean, Portuguese, Canadian, Fusion, Wine Bar, Oyster Bar " & Environment.NewLine & Environment.NewLine & "Dining options: Reservations, Late Night " & Environment.NewLine & Environment.NewLine & "http://www.selgras-montreal.com/"
            ElseIf country = "Brazil" Then
                RichTextBox1.Text = "Tenda do Nilo" & Environment.NewLine & Environment.NewLine & "This place is very much off the beaten track, a small family-run restaurant serving Arabic food. Good dips. Good bread. Good chopped salads. The most amazing falafel - impressively light and digestible. Also fatte, a Lebanese dish combining mince, chick peas, bread and yoghurt. Accompany these delicacies with a cold beer. Charmingly bossy service from the lady of the house, and great value."
                PictureBox1.Image = System.Drawing.Image.FromFile("BRAr3.jpg")
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("MALr3.jpg")
                RichTextBox1.Text = "Chez Nous Cafe " & Environment.NewLine & Environment.NewLine & "17, Lorong Seckchuan, Georgetown, Penang Island 10200, Malaysia " & Environment.NewLine & Environment.NewLine & "Tel: +60 4-261 3499"
            End If
            p1.Hide()
            p0.Hide()
            'p3.Hide()
            p2.Show()
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        pos += 1
        If pos = 3 Then
            pos = 0
        End If

        checkpos()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub RichTextBox1_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        Process.Start(e.LinkText)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        pos = 0
        checkpos()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        pos = 1
        checkpos()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        pos = 2
        checkpos()

    End Sub
End Class