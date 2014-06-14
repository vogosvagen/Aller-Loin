Module conModule
    Public connectionstring As String = "Data Source=Bassel-PC;" & "Initial Catalog=hcidata;" & "Integrated Security=True;"
    Public connection As New SqlClient.SqlConnection(connectionstring)

    Public Function make_con(ByVal u As String)
        Dim found As Boolean = False
        Try
            connection.Open()
            Dim sql_query As String = "select * from hcipro"

            Dim command As New SqlClient.SqlCommand(sql_query, connection)
            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader

            Dim test As Boolean = reader.Read
            While test = True
                If u = reader(0) Then
                    make_con = True
                End If
                test = reader.Read
            End While

            '--------------------------------------------------------------------'

            connection.Close()
        Catch ex As Exception
            MessageBox.Show("errror")
        End Try
    End Function

    Public Function make_pcon(ByVal p As String)
        Dim found As Boolean = False
        Try
            connection.Open()
            Dim sql_query As String = "select * from hcipro"

            Dim command As New SqlClient.SqlCommand(sql_query, connection)
            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader

            Dim test As Boolean = reader.Read
            While test = True
                If p = reader(1) Then
                    make_pcon = True
                End If
                test = reader.Read
            End While

            '--------------------------------------------------------------------'

            connection.Close()
        Catch ex As Exception
            MessageBox.Show("errror")
        End Try
    End Function

    Public Function getdata()

        Try

            connection.Open()


            Dim sql_query As String = "select username, password from hcipro;"


            Dim command As New SqlClient.SqlCommand(sql_query, connection)


            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader()



            If reader.HasRows Then


                Do While reader.Read()


                    MessageBox.Show(reader.GetString(0))
                    'MessageBox.Show(reader.Item("username") & "  " & reader.Item("password"))


                Loop


            Else


                MessageBox.Show("No rows found.")


            End If

            connection.Close()


        Catch ex As Exception


            MessageBox.Show(ex.ToString)


        End Try


    End Function

    Public Function setdata(ByVal username As String, ByVal password As String) As Boolean
        Try
            connection.Open()
            Dim sql_query As String = "insert into hcipro(username,password,SA,MALY,SArate,FRA,FRArate,CANA,CANArate,BRA,BRArate) values ('" & username & "','" & password & "','false','false','null','false','null','false','null','false','null');"
            Dim command As New SqlClient.SqlCommand(sql_query, connection)
            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader



            connection.Close()

        Catch ex As Exception
            MessageBox.Show("insert failed")
            setdata = False
        End Try
        setdata = True
    End Function

    Public Function checkfave(ByVal u As String, ByVal c As String)
        Try

            connection.Open()


            Dim sql_query As String = "select " & c & " from hcipro where username='" & u & "';"


            Dim command As New SqlClient.SqlCommand(sql_query, connection)


            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader()


            If reader.HasRows Then


                Do While reader.Read()
                    If reader(0).ToString = "false" Then
                        checkfave = False
                    Else
                        checkfave = True
                    End If
                Loop
            End If
            connection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Public Function checkRate(ByVal u As String, ByVal cr As String) As String
        Try

            connection.Open()


            Dim sql_query As String = "select " & cr & " from hcipro where username='" & u & "';"


            Dim command As New SqlClient.SqlCommand(sql_query, connection)


            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then


                Do While reader.Read()
                    If reader(0).ToString = "false" Then
                        checkRate = "false"
                    ElseIf reader(0).ToString = "true" Then
                        checkRate = "true"
                    Else
                        checkRate = "null"
                    End If
                Loop
            End If
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Public Function unfave(ByVal u As String, ByVal c As String)
        Try

            connection.Open()


            Dim sql_query As String = "update hcipro SET " & c & " ='false' where " & c & " = 'true' and username='" & u & "'"


            Dim command As New SqlClient.SqlCommand(sql_query, connection)


            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Public Function countups(ByVal cr As String) As Integer
        Dim counter As Integer = 0
        Try

            connection.Open()

            Dim sql_query As String = "select " & cr & " from hcipro"


            Dim command As New SqlClient.SqlCommand(sql_query, connection)


            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader

            If reader.HasRows Then


                Do While reader.Read()
                    If reader(0).ToString = "true" Then
                        counter += 1
                        countups = counter
                    End If
                Loop
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Public Function countdowns(ByVal cr As String) As Integer
        Dim counter As Integer = 0
        Try

            connection.Open()

            Dim sql_query As String = "select " & cr & " from hcipro"


            Dim command As New SqlClient.SqlCommand(sql_query, connection)


            Dim reader As SqlClient.SqlDataReader = Command.ExecuteReader

            If reader.HasRows Then


                Do While reader.Read()
                    If reader(0).ToString = "false" Then
                        counter += 1
                        countdowns = counter
                    End If
                Loop
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function


    Public Sub rateup(ByVal u As String, ByVal cr As String)
        Try

            connection.Open()

            Dim sql_query As String = "update hcipro SET " & cr & " ='true' where username='" & u & "'"


            Dim command As New SqlClient.SqlCommand(sql_query, connection)


            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub ratedown(ByVal u As String, ByVal cr As String)
        Try

            connection.Open()

            Dim sql_query As String = "update hcipro SET " & cr & " ='false' where username='" & u & "'"


            Dim command As New SqlClient.SqlCommand(sql_query, connection)


            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub ratenull(ByVal u As String, ByVal cr As String)
        Try

            connection.Open()

            Dim sql_query As String = "update hcipro SET " & cr & " ='null' where username='" & u & "'"


            Dim command As New SqlClient.SqlCommand(sql_query, connection)


            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Public Function fave(ByVal u As String, ByVal c As String)
        Try

            connection.Open()


            Dim sql_query As String = "update hcipro SET " & c & " ='true' where " & c & " = 'false' and username='" & u & "'"


            Dim command As New SqlClient.SqlCommand(sql_query, connection)


            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function
End Module
