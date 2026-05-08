Imports MySql.Data.MySqlClient

Module Module1
    Public con As New MySqlConnection("server=127.0.0.1;port=3306;user id=root;password=;database=school_db")
    Public cmd As New MySqlCommand()
    Public reader As MySqlDataReader
    Public adapter As New MySqlDataAdapter()
    Sub Opencon()
        con.Open()
    End Sub
End Module