''Imports System.Data.SqlClient
Imports System.Data.SqlClient
Module ClassConexao

    Public ConecaoMinuto = 19
    Public ConecaoSegundo = 59
    Public SistemaLogado As Integer = 0

    Public CodigoUsuario As Integer
    Public NomeUsuario As String

    Private _GerenciadorConfiguracao As ConfigurationManager = ConfigurationManager.Instance
    Public Function Descript()
        Descript = "Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\rmendes\source\repos\ProjParametrizacion\ProjParametrizacion\DB\Parametrizacion.mdf;Integrated Security=True"
    End Function
    Public Function Dscrptgrfa(StrConn As String)
        Dscrptgrfa = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(StrConn))
    End Function
    Function Criptografa(value As String)
        Criptografa = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(value))
    End Function
End Module
