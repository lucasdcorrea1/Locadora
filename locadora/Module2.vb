Imports System.Data.SqlClient
Module Module2
    Public CONN As SqlConnection
    Private STRCON As String
    Private IDCLIENTE As Integer
    Private NOMECLIENTE As String
    Private IDFUNCIONARIO As Integer
    Private NOMEFUNCIONARIO As String
    Public Sub setStr()
        STRCON = "Data Source=LAPTOP-4AHMN2DM\SQLSERVER;Initial Catalog=locadora;"
        STRCON = STRCON & "User Id=Sa;Password=cloudmed"

    End Sub
    Public Sub setCON()
        CONN = New SqlConnection(STRCON)

    End Sub
    '------Dados Do Cliente--------'
    Public Sub setIDCLIENTE(ID As Integer)
        IDCLIENTE = ID
    End Sub
    Public Sub setNOMECLIENTE(N As String)
        NOMECLIENTE = N
    End Sub
    Public Function getIDCLIENTE()
        Return IDCLIENTE
    End Function
    Public Function getNOMECLIENTE()
        Return NOMECLIENTE
    End Function
    '-----Fim Dos Dados Do Cliente---'
    '-----Dados do funcionario-------'
    Public Sub setIDFUNCIONARIO(ID As Integer)
        IDFUNCIONARIO = ID
    End Sub
    Public Sub setNOMEFUNCIONARIO(N As String)
        NOMEFUNCIONARIO = N
    End Sub
    Public Function getIDFUNCIONARIO()
        Return IDFUNCIONARIO
    End Function
    Public Function getNOMEFUNCIONARIO()
        Return NOMEFUNCIONARIO
    End Function

    '-----Fim Dos Dados Do Funcionario---'

End Module
