Imports System.Data
Imports System.Data.OleDb
Public Class Connect
    Dim StrlCaminho As String = "D:\OFICINA\oficina.accdb"
    Dim cn As OleDbConnection
    Function Conect()
        Dim Testeconect As Boolean
        cn = New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=" & StrlCaminho & "")
        Try
            cn.Open()
            Testeconect = True
        Catch ex As Exception
            Console.WriteLine(ex)
            Testeconect = False
        End Try
        Return Testeconect
    End Function
    Function FechaConect()
        cn.Close()
    End Function
    Function Tabela(Sql As String)
        Dim Table As New DataTable
        Dim Cnm As New OleDbCommand
        Cnm.Connection = cn
        Cnm.CommandText = Sql
        Dim adptador As New OleDbDataAdapter(Cnm)
        Try
            adptador.Fill(Table)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        cn.Close()
        Return Table
    End Function
    Function Login(user As String, senha As String)
        Dim Table As New DataTable
        Dim c As New Connect
        Table = Tabela("SELECT tbl_user.Nome, tbl_user.Senha " &
               "FROM tbl_user " &
               "WHERE (((tbl_user.Nome)='" & user & "') AND ((tbl_user.Senha)=" & senha & "));")
        If Table.Rows.Count >= 1 Then
            Return True
        End If
    End Function
End Class

