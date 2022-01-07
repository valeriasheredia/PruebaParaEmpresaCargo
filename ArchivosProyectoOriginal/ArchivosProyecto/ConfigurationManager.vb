Public Class ConfigurationManager
    Private Shared _instance As ConfigurationManager = Nothing
    Private ReadOnly _threadLock As New Object()

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As ConfigurationManager
        Get
            If _instance Is Nothing Then
                _instance = New ConfigurationManager()
            End If

            Return _instance
        End Get
    End Property


    Private _codigoDoCentro As Integer
    Public Property CodigoDoCentro() As Integer
        Get
            SyncLock _threadLock
                Return _codigoDoCentro
            End SyncLock
        End Get
        Set(value As Integer)
            SyncLock _threadLock
                _codigoDoCentro = value
            End SyncLock
        End Set
    End Property

    Private _nomeDoCentro As String

    Public Property NomeDoCentro() As String
        Get
            SyncLock _threadLock
                Return _nomeDoCentro
            End SyncLock
        End Get
        Set(value As String)
            SyncLock _threadLock
                _nomeDoCentro = value
            End SyncLock
        End Set
    End Property

End Class