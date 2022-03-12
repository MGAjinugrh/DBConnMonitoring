Imports MySql.Data

Public Class MainModul
    Function TestOpenConn(ByVal base_url As String,
                          Optional ByVal port As String = "3306",
                          Optional ByVal username As String = "root",
                          Optional password As String = "",
                          Optional ByVal db As String = "mysql",
                          Optional ByVal ssl As String = "none",
                          Optional ByVal timeout As String = "3600") As Boolean
        Dim _Con As New MySqlClient.MySqlConnection
        Dim _Cmd As New MySqlClient.MySqlCommand
        Dim _Res As String
        Dim connStr As String

        Try

            If IsDBNull(base_url) Or base_url = "" Then
                TestOpenConn = False
            End If

            connStr =
                "server = " & base_url & "; " &
                "port = " & port & "; " &
                "uid = " & username & "; " &
                "pwd = " & password & "; " &
                "database = " & db & "; " &
                "sslmode = " & ssl & "; " &
                "default command timeout=" & timeout & ";"

            With _Con
                .ConnectionString = connStr
                .Open()
            End With

            With _Cmd
                .Connection = _Con
                .CommandText = "SELECT VERSION()"
                .Prepare()
                _Res = CStr(.ExecuteScalar)
            End With

            If IsDBNull(_Res) Or _Res = "" Then
                TestOpenConn = False
            Else
                TestOpenConn = True
            End If

        Catch ex As Exception
            TestOpenConn = False
        Finally
            _Res = Nothing

            _Cmd.Dispose()
            _Cmd = Nothing

            If _Con.State = ConnectionState.Open Then _Con.Close()
            _Con.ClearPoolAsync(_Con)
            _Con.Dispose()
            _Con = Nothing
        End Try
    End Function
End Class
