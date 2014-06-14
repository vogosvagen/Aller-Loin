Public Class countHot
    Public country As String
    Dim pos As Integer

    Dim p As Object
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Aller Loin- " & country & " Hotels"
        p = System.Drawing.Image.FromFile("SAhmpg1Big.jpg")
        pos = 0
        p1.Hide()
        p2.Hide()
        p3.Hide()
        If country = "South Africa" Then
            'Me.BackgroundImage = System.Drawing.Image.FromFile("SAhotbkg.jpg")
            Label1.Text = "Hotels in South Africa: "
            Me.BackgroundImage = System.Drawing.Image.FromFile("SAbacg.jpg")
            PictureBox1.Image = System.Drawing.Image.FromFile("Coopmanhuijs Boutique Hotel & Spa.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("Coopmanhuijs Boutique Hotel & Spas.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("Skukuza Restcamps.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("The Place on the Bays.jpg")
            PictureBox5.Image = System.Drawing.Image.FromFile("Tsala Treetop Lodges.jpg")
            RichTextBox1.Text = "Coopmanhuijs Boutique Hotel." & Environment.NewLine & Environment.NewLine & "Spa 5 stars Hotel." & Environment.NewLine & "33 Church Street, Stellenbosch 7599, South Africa Tel: +27 (0)21 883-8207" & Environment.NewLine & "Web: http://www.coopmanhuijs.co.za/" & Environment.NewLine & "Built in 1713 as one of the first grand residences in Stellenbosch, the iconic Coopmanhuijs at 33 Church Street underwent three years' painstaking renovation before emerging as the 5-star Coopmanhuijs Boutique Hotel & Spa in 2010. Since then, it has consistently ranked #1 on www.tripadvisor.com among all hotels in Stellenbosch. Coopmanhuijs was also awarded a TripAdvisor 2013 Certificate of Excellence, placing it in the top 10% of hotels world-wide."
        ElseIf country = "Malaysia" Then
            Label1.Text = "Hotels in Malaysia: "
            Me.BackgroundImage = System.Drawing.Image.FromFile("MALYbaci.jpg")
            PictureBox1.Image = System.Drawing.Image.FromFile("MALh1.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("MALh1s.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("MALh2s.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("MALh3s.jpg")
            PictureBox5.Image = System.Drawing.Image.FromFile("MALh4s.jpg")
            RichTextBox1.Text = "72A Jalan Universiti |" & Environment.NewLine & Environment.NewLine & "72A Jalan Universiti, Petaling Jaya 46200, Malaysia " & Environment.NewLine & Environment.NewLine & "Tel: +60379588515" & Environment.NewLine & Environment.NewLine & "Web: http://www.fronterabar.com/"
        ElseIf country = "Canada" Then
            Label1.Text = "Hotels in Canada: "
            Me.BackgroundImage = System.Drawing.Image.FromFile("CAbckg2.jpg")
            PictureBox1.Image = System.Drawing.Image.FromFile("marriott.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("marriott.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("Trump.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("Rosewood.jpg")
            PictureBox5.Image = System.Drawing.Image.FromFile("Le Square.jpg")
            RichTextBox1.Text = "Marriott Niagara Falls Fallsview Hotel & Spa." & Environment.NewLine & Environment.NewLine & "4 stars Hotel." & Environment.NewLine & Environment.NewLine & "6740 Fallsview Boulevard, Niagara Falls, Ontario L2G 3W6, Canada Tel: 1-855-297-1426" & Environment.NewLine & "Web: http://www.marriott.com/" & Environment.NewLine & Environment.NewLine & "Just moments away from area attractions, casinos and the Scotiabank Convention Centre, Niagara Falls Marriott Fallsview Hotel & Spa has the enviable distinction of being the closest hotel to Niagara Falls. Experience striking views in one of our 432 luxury Niagara Falls hotel’s guest rooms, overlooking the majestic falls with 207 suites, a lobby lounge, Starbucks, indoor pool, two whirlpools, sauna and steam room. One of the top luxury hotels in Niagara Falls, Canada, we offer gourmet cuisine at the award-winning Terrapin Grille Fallsview Restaurant. Each mouth-watering menu was created to reflect our regional harvests. Take time to relax, refresh and revive in our full-service Serenity Spa By The Falls. Delight your senses while enjoying our rejuvenating treatments. The impressive Niagara Falls hotel and spa boasts more than 10,000 square feet of banquet and meeting space with natural lighting and a full view of Niagara Falls, making us the ideal hotel in Niagara Falls for any special event or function."
        ElseIf country = "France" Then
            Label1.Text = "Hotels in France: "
            Me.BackgroundImage = System.Drawing.Image.FromFile("FRbackg.jpg")
            PictureBox1.Image = System.Drawing.Image.FromFile("FRAh1.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("FRAh1.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("FRAh2.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("FRAh3.jpg")
            PictureBox5.Image = System.Drawing.Image.FromFile("FRAh4.jpg")
            RichTextBox1.Text = "Hotel Galileo  ." & Environment.NewLine & Environment.NewLine & "3 stars Hotel." & Environment.NewLine & Environment.NewLine & "54 rue Galilee | 08 Arr., 75008 Paris, France   Tel: 00 33 1 47 20 66 06" & Environment.NewLine & "Web: http://www.galileo-paris-hotel.com/en/" & Environment.NewLine & Environment.NewLine & "A chic Parisian ambiance is combined with a homey atmosphere to create a new type of contemporary luxury. Heritage of the past (17th century fireplace) is flawlessly combined with a touch of Art Deco designed by our interior decorator, Natasha Stojkovic. You are sure to enjoy Les Jeux de Miroirs, a striking yet elegant work by Tamara de Lempicka, as well as the different walls and surfaces of this unique place."
        ElseIf country = "Brazil" Then
            Label1.Text = "Hotels in Brazil: "
            Me.BackgroundImage = System.Drawing.Image.FromFile("brazil bckg.jpg")
            PictureBox1.Image = System.Drawing.Image.FromFile("BRAh1.jpg")
            PictureBox2.Image = System.Drawing.Image.FromFile("BRAh1s.jpg")
            PictureBox3.Image = System.Drawing.Image.FromFile("BRAh2s.jpg")
            PictureBox4.Image = System.Drawing.Image.FromFile("BRAh3s.jpg")
            PictureBox5.Image = System.Drawing.Image.FromFile("BRAh4s.jpg")
            RichTextBox1.Text = "Emiliano is Brazil's finest example of world class luxury hospitality. Located on Oscar Freire Street, in the heart of the exclusive Jardins neighborhood of Sao Paulo, the Emiliano Hotel sets the pace for a new age of luxury travel in Brazil. Guests experience authentic and modern Brazilian sophistication through contemporary ambiance, refined cuisine and singularly warm service. "
        End If
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'If pos = 0 Then
        '    If country = "South Africa" Then
        '        PictureBox1.Image = System.Drawing.Image.FromFile("Coopmanhuijs Boutique Hotel & Spa.jpg")
        '        RichTextBox1.Text = "Coopmanhuijs Boutique Hotel." & Environment.NewLine & Environment.NewLine & "Spa 5 stars Hotel." & Environment.NewLine & Environment.NewLine & "33 Church Street, Stellenbosch 7599, South Africa Tel: +27 (0)21 883-8207" & Environment.NewLine & "Web: http://www.coopmanhuijs.co.za/" & Environment.NewLine & Environment.NewLine & "Built in 1713 as one of the first grand residences in Stellenbosch, the iconic Coopmanhuijs at 33 Church Street underwent three years' painstaking renovation before emerging as the 5-star Coopmanhuijs Boutique Hotel & Spa in 2010. Since then, it has consistently ranked #1 on www.tripadvisor.com among all hotels in Stellenbosch. Coopmanhuijs was also awarded a TripAdvisor 2013 Certificate of Excellence, placing it in the top 10% of hotels world-wide."
        '    ElseIf country = "France" Then
        '        PictureBox1.Image = System.Drawing.Image.FromFile("FRAh1.jpg")
        '        RichTextBox1.Text = "Hotel Galileo  ." & Environment.NewLine & Environment.NewLine & "3 stars Hotel." & Environment.NewLine & Environment.NewLine & "54 rue Galilee | 08 Arr., 75008 Paris, France   Tel: 00 33 1 47 20 66 06" & Environment.NewLine & "Web: http://www.galileo-paris-hotel.com/en/" & Environment.NewLine & Environment.NewLine & "A chic Parisian ambiance is combined with a homey atmosphere to create a new type of contemporary luxury. Heritage of the past (17th century fireplace) is flawlessly combined with a touch of Art Deco designed by our interior decorator, Natasha Stojkovic. You are sure to enjoy Les Jeux de Miroirs, a striking yet elegant work by Tamara de Lempicka, as well as the different walls and surfaces of this unique place."
        '    End If
        '    p3.Hide()
        '    p1.Hide()
        '    p0.Show()


        'ElseIf pos = 1 Then
        '    If country = "South Africa" Then
        '        PictureBox1.Image = System.Drawing.Image.FromFile("Skukuza Restcamp.jpg")
        '        RichTextBox1.Text = "Skukuza Restcamp." & Environment.NewLine & Environment.NewLine & " 2 stars Hotel   |   12 km from Paul Kruger Gate, 39 km from Phabeni Gate | Sabie River, Kruger National Park, South Africa " & Environment.NewLine & Environment.NewLine & "Tel: +27 (0)13 735 4030 / 4031 / 4184 / 4371" & Environment.NewLine & Environment.NewLine & "Skukuza is the Kruger National Park's largest rest camp and administrative headquarters." & Environment.NewLine & Environment.NewLine & "It is situated on the southern banks of the Sabie River. The camp is well foliaged and there are some lofty trees along the river’s edge.  Activities and facilities are diverse, as are the animals and plants found both within the camp and in the surrounding areas."
        '    End If
        '    p0.Hide()
        '    p2.Hide()
        '    p1.Show()

        '    ElseIf pos = 2 Then
        '        If country = "South Africa" Then
        '        PictureBox1.Image = System.Drawing.Image.FromFile("The Place on the Bay.jpg")
        '        RichTextBox1.Text = "The Place on the Bay." & Environment.NewLine & Environment.NewLine & "4 stars Hotel   |   Victoria Rd, Camps Bay 8001, South Africa." & Environment.NewLine & Environment.NewLine & "Web: http://placeonthebay.co.za/" & Environment.NewLine & Environment.NewLine & "Tel: +27 21 437 8500" & Environment.NewLine & Environment.NewLine & "Place on the Bay Hotel was built in 1989 and quickly became known as a holiday hot spot along the Camps Bay strip. As the hotel aged, it became evident that the property needed a lift. Knowing that self-catering accommodation in one of Cape Town’s trendiest suburbs could be a winning recipe, Louis Group Hotels, Spas & Vineyards saw the property as a great investment and became a majority shareholder in January 2008. After extensive renovations and refurbishments to the building, Place on the Bay Hotel has now been restored to its former glory and is enjoyed by guests from all over the world."
        '    End If
        '    p1.Hide()
        '    p3.Hide()
        '    p2.Show()

        'ElseIf pos = 3 Then
        '    If country = "South Africa" Then
        '        PictureBox1.Image = System.Drawing.Image.FromFile("Tsala Treetop Lodge.jpg")
        '        RichTextBox1.Text = "Tsala Treetop Lodge." & Environment.NewLine & Environment.NewLine & "5 stars Hotel   |   PO Box 454, Harkerville, Plettenberg Bay 6600, South Africa " & Environment.NewLine & Environment.NewLine & "Tel: +27 (0) 44 532 8228" & Environment.NewLine & Environment.NewLine & "Web: www.tsala.com" & Environment.NewLine & Environment.NewLine & "Like the monumental ruins of an ancient central African civilisation, Tsala’s impressive stone-masonry entrance flanked by water features leads to a magnificent foyer supported by Blackwood columns. The elaborate afro-baroque décor’s earthy colours, rich textures and handcrafted fittings are inspired by the diverse cultures of Africa, with the sophistication of the Western World. The views are breathtaking, whether from the exotic dining room, intimate glassed-in lounge, or large open decks high above the forest floor. Tsala is a magical place, encircled by lush forests extending across rolling valleys, towards the distant hills."
        '    End If
        '    p2.Hide()
        '    p0.Hide()
        '    p3.Show()

        '            End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        pos = 0
        checkpos()
        'If country = "South Africa" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("Coopmanhuijs Boutique Hotel & Spa.jpg")
        '    RichTextBox1.Text = "Coopmanhuijs Boutique Hotel." & Environment.NewLine & Environment.NewLine & "Spa 5 stars Hotel." & Environment.NewLine & Environment.NewLine & "33 Church Street, Stellenbosch 7599, South Africa Tel: +27 (0)21 883-8207" & Environment.NewLine & "Web: http://www.coopmanhuijs.co.za/" & Environment.NewLine & Environment.NewLine & "Built in 1713 as one of the first grand residences in Stellenbosch, the iconic Coopmanhuijs at 33 Church Street underwent three years' painstaking renovation before emerging as the 5-star Coopmanhuijs Boutique Hotel & Spa in 2010. Since then, it has consistently ranked #1 on www.tripadvisor.com among all hotels in Stellenbosch. Coopmanhuijs was also awarded a TripAdvisor 2013 Certificate of Excellence, placing it in the top 10% of hotels world-wide."

        'ElseIf country = "Canada" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("marriott.jpg")
        '    RichTextBox1.Text = "Marriott Niagara Falls Fallsview Hotel & Spa." & Environment.NewLine & Environment.NewLine & "4 stars Hotel." & Environment.NewLine & Environment.NewLine & "6740 Fallsview Boulevard, Niagara Falls, Ontario L2G 3W6, Canada Tel: 1-855-297-1426" & Environment.NewLine & "Web: http://www.marriott.com/" & Environment.NewLine & Environment.NewLine & "Just moments away from area attractions, casinos and the Scotiabank Convention Centre, Niagara Falls Marriott Fallsview Hotel & Spa has the enviable distinction of being the closest hotel to Niagara Falls. Experience striking views in one of our 432 luxury Niagara Falls hotel’s guest rooms, overlooking the majestic falls with 207 suites, a lobby lounge, Starbucks, indoor pool, two whirlpools, sauna and steam room. One of the top luxury hotels in Niagara Falls, Canada, we offer gourmet cuisine at the award-winning Terrapin Grille Fallsview Restaurant. Each mouth-watering menu was created to reflect our regional harvests. Take time to relax, refresh and revive in our full-service Serenity Spa By The Falls. Delight your senses while enjoying our rejuvenating treatments. The impressive Niagara Falls hotel and spa boasts more than 10,000 square feet of banquet and meeting space with natural lighting and a full view of Niagara Falls, making us the ideal hotel in Niagara Falls for any special event or function."
        'ElseIf country = "France" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("FRAh1.jpg")
        '    RichTextBox1.Text = "Hotel Galileo  ." & Environment.NewLine & Environment.NewLine & "3 stars Hotel." & Environment.NewLine & Environment.NewLine & "54 rue Galilee | 08 Arr., 75008 Paris, France   Tel: 00 33 1 47 20 66 06" & Environment.NewLine & "Web: http://www.galileo-paris-hotel.com/en/" & Environment.NewLine & Environment.NewLine & "A chic Parisian ambiance is combined with a homey atmosphere to create a new type of contemporary luxury. Heritage of the past (17th century fireplace) is flawlessly combined with a touch of Art Deco designed by our interior decorator, Natasha Stojkovic. You are sure to enjoy Les Jeux de Miroirs, a striking yet elegant work by Tamara de Lempicka, as well as the different walls and surfaces of this unique place."
        'ElseIf country = "Malaysia" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("Coopmanhuijs Boutique Hotel & Spa.jpg")
        'End If

        'p3.Hide()
        'p1.Hide()
        'p0.Show()
    End Sub
    Private Sub checkpos()
        If pos = 0 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("Coopmanhuijs Boutique Hotel & Spa.jpg")
                RichTextBox1.Text = "Coopmanhuijs Boutique Hotel." & Environment.NewLine & Environment.NewLine & "Spa 5 stars Hotel." & Environment.NewLine & Environment.NewLine & "33 Church Street, Stellenbosch 7599, South Africa Tel: +27 (0)21 883-8207" & Environment.NewLine & "Web: http://www.coopmanhuijs.co.za/" & Environment.NewLine & Environment.NewLine & "Built in 1713 as one of the first grand residences in Stellenbosch, the iconic Coopmanhuijs at 33 Church Street underwent three years' painstaking renovation before emerging as the 5-star Coopmanhuijs Boutique Hotel & Spa in 2010. Since then, it has consistently ranked #1 on www.tripadvisor.com among all hotels in Stellenbosch. Coopmanhuijs was also awarded a TripAdvisor 2013 Certificate of Excellence, placing it in the top 10% of hotels world-wide."

            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("marriott.jpg")
                RichTextBox1.Text = "Marriott Niagara Falls Fallsview Hotel & Spa." & Environment.NewLine & Environment.NewLine & "4 stars Hotel." & Environment.NewLine & Environment.NewLine & "6740 Fallsview Boulevard, Niagara Falls, Ontario L2G 3W6, Canada Tel: 1-855-297-1426" & Environment.NewLine & "Web: http://www.marriott.com/" & Environment.NewLine & Environment.NewLine & "Just moments away from area attractions, casinos and the Scotiabank Convention Centre, Niagara Falls Marriott Fallsview Hotel & Spa has the enviable distinction of being the closest hotel to Niagara Falls. Experience striking views in one of our 432 luxury Niagara Falls hotel’s guest rooms, overlooking the majestic falls with 207 suites, a lobby lounge, Starbucks, indoor pool, two whirlpools, sauna and steam room. One of the top luxury hotels in Niagara Falls, Canada, we offer gourmet cuisine at the award-winning Terrapin Grille Fallsview Restaurant. Each mouth-watering menu was created to reflect our regional harvests. Take time to relax, refresh and revive in our full-service Serenity Spa By The Falls. Delight your senses while enjoying our rejuvenating treatments. The impressive Niagara Falls hotel and spa boasts more than 10,000 square feet of banquet and meeting space with natural lighting and a full view of Niagara Falls, making us the ideal hotel in Niagara Falls for any special event or function."
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("FRAh1.jpg")
                RichTextBox1.Text = "Hotel Galileo  ." & Environment.NewLine & Environment.NewLine & "3 stars Hotel." & Environment.NewLine & Environment.NewLine & "54 rue Galilee | 08 Arr., 75008 Paris, France   Tel: 00 33 1 47 20 66 06" & Environment.NewLine & "Web: http://www.galileo-paris-hotel.com/en/" & Environment.NewLine & Environment.NewLine & "A chic Parisian ambiance is combined with a homey atmosphere to create a new type of contemporary luxury. Heritage of the past (17th century fireplace) is flawlessly combined with a touch of Art Deco designed by our interior decorator, Natasha Stojkovic. You are sure to enjoy Les Jeux de Miroirs, a striking yet elegant work by Tamara de Lempicka, as well as the different walls and surfaces of this unique place."
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("MALh1.jpg")
                RichTextBox1.Text = "Shangri-La Hotel Kuala Lumpur 5 stars Hotel   |" & Environment.NewLine & Environment.NewLine & "   11 Jalan Sultan Ismail, Kuala Lumpur 50250, Malaysia" & Environment.NewLine & Environment.NewLine & " Tel: (60 3) 2032 2388"
            ElseIf country = "Brazil" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("BRAh1.jpg")
                RichTextBox1.Text = "Emiliano is Brazil's finest example of world class luxury hospitality. Located on Oscar Freire Street, in the heart of the exclusive Jardins neighborhood of Sao Paulo, the Emiliano Hotel sets the pace for a new age of luxury travel in Brazil. Guests experience authentic and modern Brazilian sophistication through contemporary ambiance, refined cuisine and singularly warm service. "
            End If
            p3.Hide()
            p1.Hide()
            p0.Show()
        End If


        If pos = 1 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("Skukuza Restcamp.jpg")
                RichTextBox1.Text = "Skukuza Restcamp." & Environment.NewLine & Environment.NewLine & " 2 stars Hotel   |   12 km from Paul Kruger Gate, 39 km from Phabeni Gate | Sabie River, Kruger National Park, South Africa " & Environment.NewLine & Environment.NewLine & "Tel: +27 (0)13 735 4030 / 4031 / 4184 / 4371" & Environment.NewLine & Environment.NewLine & "Skukuza is the Kruger National Park's largest rest camp and administrative headquarters." & Environment.NewLine & Environment.NewLine & "It is situated on the southern banks of the Sabie River. The camp is well foliaged and there are some lofty trees along the river’s edge.  Activities and facilities are diverse, as are the animals and plants found both within the camp and in the surrounding areas."
            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("Trump.jpg")
                RichTextBox1.Text = "Trump International Hotel & Tower Toronto." & Environment.NewLine & Environment.NewLine & "5 stars Hotel." & Environment.NewLine & Environment.NewLine & "325 Bay St, Toronto, Ontario M5H 4G3, Canada (Downtown Toronto) Tel: 855.888.7867" & Environment.NewLine & "Web: http://www.trumphotelcollection.com/toronto/" & Environment.NewLine & Environment.NewLine & "Trump International Hotel & Tower Toronto is the city’s leading luxury hotel, pampering guests with outstanding, award-winning service. The 65-storey tower includes 261 luxurious rooms and suites featuring floor-to-ceiling windows with stunning views of Toronto’s skyline, stone-accented bathrooms, in-mirror bathroom TVs, Nespresso coffee machines and much more."
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("FRAh2.jpg")
                RichTextBox1.Text = "Hotel du Chateau." & Environment.NewLine & Environment.NewLine & "4 stars Hotel." & Environment.NewLine & Environment.NewLine & "|   2, rue Camille Saint Saens | Montée Gaston Combéléran, 11000 Carcassonne, France  Tel: 00 33 4 68 11 38 38 " & Environment.NewLine & "Web: : http://www.hotelduchateau.net/" & Environment.NewLine & Environment.NewLine & "The elegant guest rooms at the Hotel Du Chateau have air conditioning and a flat-screen TV, and each has a private bathroom. Free Wi-Fi access is available. You can enjoy a drink in the panoramic bar, which offers view of the city. The hotel also has a 24-hour front desk and private parking. The Hotel Du Chateau is easily accessible from the N113 highway and the Basilica of Saint Nazaire and Saint Celse is just a 5-minute walk away."
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("MALh2.jpg")
                RichTextBox1.Text = "Coffee Atelier " & Environment.NewLine & Environment.NewLine & "4 stars hotel      47 - 55 Lorong Stewart,, Georgetown, Penang Island 10300, Malaysia" & Environment.NewLine & Environment.NewLine & " Tel: 00 60 4-261 2261"
            ElseIf country = "Brazil" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("BRAh2.jpg")
                RichTextBox1.Text = "Opened in 1923, this impressive stucco-fashioned edifice is Rio's most traditional and luxurious hotel. This landmark was designed by the French architect Joseph Gire who was inspired by two hotels, the Negresco in Nice and the Carlton in Cannes. Since opening the hotel has had only two owners, the Guinle family of Rio de Janeiro and from 1989, Orient-Express Hotels, Trains & Cruises. "
            End If
            p0.Hide()
            p2.Hide()
            p1.Show()
        End If

        If pos = 2 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("The Place on the Bay.jpg")
                RichTextBox1.Text = "The Place on the Bay." & Environment.NewLine & Environment.NewLine & "4 stars Hotel   |   Victoria Rd, Camps Bay 8001, South Africa." & Environment.NewLine & Environment.NewLine & "Web: http://placeonthebay.co.za/" & Environment.NewLine & Environment.NewLine & "Tel: +27 21 437 8500" & Environment.NewLine & Environment.NewLine & "Place on the Bay Hotel was built in 1989 and quickly became known as a holiday hot spot along the Camps Bay strip. As the hotel aged, it became evident that the property needed a lift. Knowing that self-catering accommodation in one of Cape Town’s trendiest suburbs could be a winning recipe, Louis Group Hotels, Spas & Vineyards saw the property as a great investment and became a majority shareholder in January 2008. After extensive renovations and refurbishments to the building, Place on the Bay Hotel has now been restored to its former glory and is enjoyed by guests from all over the world."
            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("Rosewood.jpg")
                RichTextBox1.Text = "Rosewood Hotel Georgia ." & Environment.NewLine & Environment.NewLine & "5 stars Hotel." & Environment.NewLine & Environment.NewLine & "801 West Georgia Street, Vancouver, British Columbia V6C 1P7, Canada  Tel: 00 1 888-767-3966" & Environment.NewLine & "Web: http://www.rosewoodhotels.com/en/hotel-georgia-vancouver" & Environment.NewLine & Environment.NewLine & "The associates at Rosewood Hotel Georgia have a passion for impeccable service and Canadian hospitality to make guests feel at home. To stay at this luxury hotel is to experience one of life's finest rewards."
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("FRAh3.jpg")
                RichTextBox1.Text = "Hotel Le Cavendish." & Environment.NewLine & Environment.NewLine & "4 stars Hotel." & Environment.NewLine & Environment.NewLine & "11 Boulevard Carnot, 06400 Cannes, France   Tel: 00 33 4 97 06 26 00" & Environment.NewLine & "Web: http://www.cavendish-cannes.com/en" & Environment.NewLine & Environment.NewLine & "This boutique hotel provides soundproofed rooms equipped with satellite TV, air conditioning and free Wi-Fi access. Some rooms at the Cavendish also have a private balcony. The homemade buffet breakfast is made on site and features freshly juices and jams. Guests are invited to relax in the Lounge Bar, which has a selection of self-service aperitifs between 18:00 and 21:00. Le Cavendish is a 5-minute walk from the Palais des Festivals et des Congres and just 300 meters from SNCF Cannes Train Station. It is located on Boulevard Carnot which provides direct access to the E80 and A8 motorways."
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("MALh3.jpg")
                RichTextBox1.Text = "5 stars Resort   |" & Environment.NewLine & Environment.NewLine & "   Jalan Pantai Dato Syed Omar, Langkawi 07000, Malaysia " & Environment.NewLine & Environment.NewLine & "Tel: 00 60 4-960 8888"
            ElseIf country = "Brazil" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("BRAh3.jpg")
                RichTextBox1.Text = "Hotel das Cataratas by Orient-Express is the only hotel located within the Iguassu National Park, with the world famous Iguassu Falls just a two minute stroll away. " & Environment.NewLine & Environment.NewLine & "As the only hotel within the national park, guests are able to enjoy exclusive access to the falls each morning before the park opens. "
            End If
            p1.Hide()
            p3.Hide()
            p2.Show()
        End If
        If pos = 3 Then
            If country = "South Africa" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("Tsala Treetop Lodge.jpg")
                RichTextBox1.Text = "Tsala Treetop Lodge." & Environment.NewLine & Environment.NewLine & "5 stars Hotel   |   PO Box 454, Harkerville, Plettenberg Bay 6600, South Africa " & Environment.NewLine & Environment.NewLine & "Tel: +27 (0) 44 532 8228" & Environment.NewLine & Environment.NewLine & "Web: www.tsala.com" & Environment.NewLine & Environment.NewLine & "Like the monumental ruins of an ancient central African civilisation, Tsala’s impressive stone-masonry entrance flanked by water features leads to a magnificent foyer supported by Blackwood columns. The elaborate afro-baroque décor’s earthy colours, rich textures and handcrafted fittings are inspired by the diverse cultures of Africa, with the sophistication of the Western World. The views are breathtaking, whether from the exotic dining room, intimate glassed-in lounge, or large open decks high above the forest floor. Tsala is a magical place, encircled by lush forests extending across rolling valleys, towards the distant hills."
            ElseIf country = "Canada" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("Le Square.jpg")
                RichTextBox1.Text = "Le Square Phillips Hotel & Suites." & Environment.NewLine & Environment.NewLine & "3 stars Hotel." & Environment.NewLine & Environment.NewLine & "1193 Place Phillips, Montreal, Quebec H3B 3C9, Canada (Ville-Marie)  Tel: (514) 393-1193" & Environment.NewLine & "Web: http://www.squarephillips.com/" & Environment.NewLine & Environment.NewLine & "Spacious and refined accommodations that redefine hotel standards, bonds with personalized services and let you enter a new era. A short walk from La Maison du Festival Rio Tinto Alcan and Place des Festivals stands on Place Phillips Street, Le Square Phillips Hôtel & Suites. This historical building from renowned architect Ernest Cormier was completely restored, harmonized with the present and is now prompted by a new vocation; one hundred sixty grand studios and suites were created to make you discover a new art of living downtown. On the roof you have it all, indoor swimming pool, exercise room, sundeck and a view of Phillips Square that you will remember for a long time. To start your day on the right note, the hotel offers complimentary breakfast that you can enjoy in our private breakfast lounge or take and savour in the intimacy of your room. For a short or extended stay, if you happen to be with us for business or simply to enjoy being in the centre of the second largest French speaking city in the world, you will be steps away from some of Montreal's most prestigious addresses and its premier entertainment district, Le Quartier des Spectacle."
            ElseIf country = "France" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("FRAh4.jpg")
                RichTextBox1.Text = "Hyatt Regency Nice Palais de la Mediterranee." & Environment.NewLine & Environment.NewLine & "5 stars Hotel." & Environment.NewLine & Environment.NewLine & "13 Promenade des Anglais, 06000 Nice, France Tel: 00 33 4 93 27 12 34" & Environment.NewLine & "Web: http://nice.regency.hyatt.com/" & Environment.NewLine & Environment.NewLine & "Free Wi-Fi, a minibar and an LCD TV are provided in the air-conditioned guest rooms. Most of the elegant rooms have a furnished terrace with views of the sea or of the town. Regional cuisine and Mediterranean dishes are served in the hotel restaurant, Le 3e. You can enjoy drinks in the Lounge Bar Le 3e at Hyatt Regency Nice Palais de la Méditerranée. The fitness center at the Hyatt Regency Nice Palais de la Méditerranée has cardio-training gym equipment. Nice Train Station is a 5-minute walk away. Nice-Cote d’Azur Airport is just 6km away."
            ElseIf country = "Malaysia" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("Tsala Treetop Lodge.jpg")
                RichTextBox1.Text = "Campbell House " & Environment.NewLine & Environment.NewLine & "3.5 stars Hotel   |   106, Lebuh Campbell, Georgetown, Penang Island 10100, Malaysia " & Environment.NewLine & Environment.NewLine & "Tel: 00 60 4-261 8290"
            ElseIf country = "Brazil" Then
                PictureBox1.Image = System.Drawing.Image.FromFile("BRAh4.jpg")
                RichTextBox1.Text = "Ponta dos Ganchos Exclusive Resort is located on a privately-owned peninsula, surrounded by the exuberant Emerald Coast. Known as one of the most exclusive beach resorts in Brazil, the property enjoys direct flights from São Paulo, Rio de Janeiro or Buenos Aires. Here the waters of the Emerald coast meet the lush rainforest vegetation in a dazzling display of colour and light. 25-sophisticated and charming bungalows lay in perfect harmony with the breathtaking scenery. "

            End If
            p2.Hide()
            p0.Hide()
            p3.Show()
        End If
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        pos = 1
        checkpos()
        'If country = "South Africa" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("Skukuza Restcamp.jpg")
        '    RichTextBox1.Text = "Skukuza Restcamp." & Environment.NewLine & Environment.NewLine & " 2 stars Hotel   |   12 km from Paul Kruger Gate, 39 km from Phabeni Gate | Sabie River, Kruger National Park, South Africa " & Environment.NewLine & Environment.NewLine & "Tel: +27 (0)13 735 4030 / 4031 / 4184 / 4371" & Environment.NewLine & Environment.NewLine & "Skukuza is the Kruger National Park's largest rest camp and administrative headquarters." & Environment.NewLine & Environment.NewLine & "It is situated on the southern banks of the Sabie River. The camp is well foliaged and there are some lofty trees along the river’s edge.  Activities and facilities are diverse, as are the animals and plants found both within the camp and in the surrounding areas."
        'ElseIf country = "Canada" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("Trump.jpg")
        '    RichTextBox1.Text = "Trump International Hotel & Tower Toronto." & Environment.NewLine & Environment.NewLine & "5 stars Hotel." & Environment.NewLine & Environment.NewLine & "325 Bay St, Toronto, Ontario M5H 4G3, Canada (Downtown Toronto) Tel: 855.888.7867" & Environment.NewLine & "Web: http://www.trumphotelcollection.com/toronto/" & Environment.NewLine & Environment.NewLine & "Trump International Hotel & Tower Toronto is the city’s leading luxury hotel, pampering guests with outstanding, award-winning service. The 65-storey tower includes 261 luxurious rooms and suites featuring floor-to-ceiling windows with stunning views of Toronto’s skyline, stone-accented bathrooms, in-mirror bathroom TVs, Nespresso coffee machines and much more."
        'ElseIf country = "France" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("FRAh2.jpg")
        '    RichTextBox1.Text = "Hotel du Chateau." & Environment.NewLine & Environment.NewLine & "4 stars Hotel." & Environment.NewLine & Environment.NewLine & "|   2, rue Camille Saint Saens | Montée Gaston Combéléran, 11000 Carcassonne, France  Tel: 00 33 4 68 11 38 38 " & Environment.NewLine & "Web: : http://www.hotelduchateau.net/" & Environment.NewLine & Environment.NewLine & "The elegant guest rooms at the Hotel Du Chateau have air conditioning and a flat-screen TV, and each has a private bathroom. Free Wi-Fi access is available. You can enjoy a drink in the panoramic bar, which offers view of the city. The hotel also has a 24-hour front desk and private parking. The Hotel Du Chateau is easily accessible from the N113 highway and the Basilica of Saint Nazaire and Saint Celse is just a 5-minute walk away."
        'ElseIf country = "Malaysia" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("Skukuza Restcamp.jpg")
        'End If
        'p0.Hide()
        'p2.Hide()
        'p1.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        pos = 2
        checkpos()
        'If country = "South Africa" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("The Place on the Bay.jpg")
        '    RichTextBox1.Text = "The Place on the Bay." & Environment.NewLine & Environment.NewLine & "4 stars Hotel   |   Victoria Rd, Camps Bay 8001, South Africa." & Environment.NewLine & Environment.NewLine & "Web: http://placeonthebay.co.za/" & Environment.NewLine & Environment.NewLine & "Tel: +27 21 437 8500" & Environment.NewLine & Environment.NewLine & "Place on the Bay Hotel was built in 1989 and quickly became known as a holiday hot spot along the Camps Bay strip. As the hotel aged, it became evident that the property needed a lift. Knowing that self-catering accommodation in one of Cape Town’s trendiest suburbs could be a winning recipe, Louis Group Hotels, Spas & Vineyards saw the property as a great investment and became a majority shareholder in January 2008. After extensive renovations and refurbishments to the building, Place on the Bay Hotel has now been restored to its former glory and is enjoyed by guests from all over the world."
        'ElseIf country = "Canada" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("Rosewood.jpg")
        '    RichTextBox1.Text = "Rosewood Hotel Georgia ." & Environment.NewLine & Environment.NewLine & "5 stars Hotel." & Environment.NewLine & Environment.NewLine & "801 West Georgia Street, Vancouver, British Columbia V6C 1P7, Canada  Tel: 00 1 888-767-3966" & Environment.NewLine & "Web: http://www.rosewoodhotels.com/en/hotel-georgia-vancouver" & Environment.NewLine & Environment.NewLine & "The associates at Rosewood Hotel Georgia have a passion for impeccable service and Canadian hospitality to make guests feel at home. To stay at this luxury hotel is to experience one of life's finest rewards."
        'ElseIf country = "France" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("FRAh3.jpg")
        '    RichTextBox1.Text = "Hotel Le Cavendish." & Environment.NewLine & Environment.NewLine & "4 stars Hotel." & Environment.NewLine & Environment.NewLine & "11 Boulevard Carnot, 06400 Cannes, France   Tel: 00 33 4 97 06 26 00" & Environment.NewLine & "Web: http://www.cavendish-cannes.com/en" & Environment.NewLine & Environment.NewLine & "This boutique hotel provides soundproofed rooms equipped with satellite TV, air conditioning and free Wi-Fi access. Some rooms at the Cavendish also have a private balcony. The homemade buffet breakfast is made on site and features freshly juices and jams. Guests are invited to relax in the Lounge Bar, which has a selection of self-service aperitifs between 18:00 and 21:00. Le Cavendish is a 5-minute walk from the Palais des Festivals et des Congres and just 300 meters from SNCF Cannes Train Station. It is located on Boulevard Carnot which provides direct access to the E80 and A8 motorways."
        'ElseIf country = "Malaysia" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("The Place on the Bay.jpg")
        'End If
        'p1.Hide()
        'p3.Hide()
        'p2.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        pos = 3
        checkpos()
        'If country = "South Africa" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("Tsala Treetop Lodge.jpg")
        '    RichTextBox1.Text = "Tsala Treetop Lodge." & Environment.NewLine & Environment.NewLine & "5 stars Hotel   |   PO Box 454, Harkerville, Plettenberg Bay 6600, South Africa " & Environment.NewLine & Environment.NewLine & "Tel: +27 (0) 44 532 8228" & Environment.NewLine & Environment.NewLine & "Web: www.tsala.com" & Environment.NewLine & Environment.NewLine & "Like the monumental ruins of an ancient central African civilisation, Tsala’s impressive stone-masonry entrance flanked by water features leads to a magnificent foyer supported by Blackwood columns. The elaborate afro-baroque décor’s earthy colours, rich textures and handcrafted fittings are inspired by the diverse cultures of Africa, with the sophistication of the Western World. The views are breathtaking, whether from the exotic dining room, intimate glassed-in lounge, or large open decks high above the forest floor. Tsala is a magical place, encircled by lush forests extending across rolling valleys, towards the distant hills."
        'ElseIf country = "Canada" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("Le Square.jpg")
        '    RichTextBox1.Text = "Le Square Phillips Hotel & Suites." & Environment.NewLine & Environment.NewLine & "3 stars Hotel." & Environment.NewLine & Environment.NewLine & "1193 Place Phillips, Montreal, Quebec H3B 3C9, Canada (Ville-Marie)  Tel: (514) 393-1193" & Environment.NewLine & "Web: http://www.squarephillips.com/" & Environment.NewLine & Environment.NewLine & "Spacious and refined accommodations that redefine hotel standards, bonds with personalized services and let you enter a new era. A short walk from La Maison du Festival Rio Tinto Alcan and Place des Festivals stands on Place Phillips Street, Le Square Phillips Hôtel & Suites. This historical building from renowned architect Ernest Cormier was completely restored, harmonized with the present and is now prompted by a new vocation; one hundred sixty grand studios and suites were created to make you discover a new art of living downtown. On the roof you have it all, indoor swimming pool, exercise room, sundeck and a view of Phillips Square that you will remember for a long time. To start your day on the right note, the hotel offers complimentary breakfast that you can enjoy in our private breakfast lounge or take and savour in the intimacy of your room. For a short or extended stay, if you happen to be with us for business or simply to enjoy being in the centre of the second largest French speaking city in the world, you will be steps away from some of Montreal's most prestigious addresses and its premier entertainment district, Le Quartier des Spectacle."
        'ElseIf country = "France" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("FRAh4.jpg")
        '    RichTextBox1.Text = "Hyatt Regency Nice Palais de la Mediterranee." & Environment.NewLine & Environment.NewLine & "5 stars Hotel." & Environment.NewLine & Environment.NewLine & "13 Promenade des Anglais, 06000 Nice, France Tel: 00 33 4 93 27 12 34" & Environment.NewLine & "Web: http://nice.regency.hyatt.com/" & Environment.NewLine & Environment.NewLine & "Free Wi-Fi, a minibar and an LCD TV are provided in the air-conditioned guest rooms. Most of the elegant rooms have a furnished terrace with views of the sea or of the town. Regional cuisine and Mediterranean dishes are served in the hotel restaurant, Le 3e. You can enjoy drinks in the Lounge Bar Le 3e at Hyatt Regency Nice Palais de la Méditerranée. The fitness center at the Hyatt Regency Nice Palais de la Méditerranée has cardio-training gym equipment. Nice Train Station is a 5-minute walk away. Nice-Cote d’Azur Airport is just 6km away."
        'ElseIf country = "Malaysia" Then
        '    PictureBox1.Image = System.Drawing.Image.FromFile("Tsala Treetop Lodge.jpg")
        'End If
        'p2.Hide()
        'p0.Hide()
        'p3.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RichTextBox1_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        Process.Start(e.LinkText)
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        pos += 1
        If pos = 4 Then
            pos = 0
        End If

        checkpos()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        pos = pos - 1
        If pos = -1 Then
            pos = 3
        End If

        checkpos()
    End Sub
End Class