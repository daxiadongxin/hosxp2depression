Imports System
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports Crypto

Public Class mysqlhelper

    Public DepressSQLConnectionStr As String = "server=110.164.197.220;user=root;database=Depression_54;port=3306;password=depression_prasri;"

#Region "MySQL"
#Region "MySQl Config"
    Public Shared Property MySQLUser() As String
        Get
            MySQLUser = System.Configuration.ConfigurationSettings.AppSettings.Get("MyUser")
        End Get
        Set(ByVal value As String)
            AppConfigFileSettings.UpdateAppSettings("MyUser", value)
        End Set
    End Property
    Public Shared Property MySQLPassword() As String
        Get
            MySQLPassword = System.Configuration.ConfigurationSettings.AppSettings.Get("MyPassword")

        End Get
        Set(ByVal value As String)
            AppConfigFileSettings.UpdateAppSettings("MyPassword", value)
        End Set
    End Property
    Public Shared Property MySQLPort() As Int32
        Get
            MySQLPort = System.Configuration.ConfigurationSettings.AppSettings.Get("MyPort")
        End Get
        Set(ByVal value As Int32)
            AppConfigFileSettings.UpdateAppSettings("MyPort", value)
        End Set
    End Property
    Public Shared Property MySQLDatabase() As String
        Get
            MySQLDatabase = System.Configuration.ConfigurationSettings.AppSettings.Get("MyDatabase")
        End Get
        Set(ByVal value As String)
            AppConfigFileSettings.UpdateAppSettings("MyDatabase", value)
        End Set
    End Property
    Public Shared Property MySQLServer() As String
        Get
            MySQLServer = System.Configuration.ConfigurationSettings.AppSettings.Get("MyServer")
        End Get
        Set(ByVal value As String)
            AppConfigFileSettings.UpdateAppSettings("MyServer", value)
        End Set
    End Property
#End Region
    Public Shared Function MySQLConnectionStr() As String
        Try
            Dim Crypto As New Crypto.Crypto
            MySQLConnectionStr = "server=" & MySQLServer & ";user=" & MySQLUser & ";database=" & MySQLDatabase & ";port=" & MySQLPort & ";password=" & Crypto.Decrypt(MySQLPassword, "sys11266") & ";"
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Function
    Public Shared ReadOnly Property ConnMysql() As String
        Get
            ConnMysql = MySQLConnectionStr()
        End Get
    End Property

    Function GetMYSQLDataset(ByVal Strsql As String, _
           Optional ByVal DatasetName As String = "Dataset1", _
           Optional ByVal TableName As String = "Table") As DataSet
        Dim MyConnq As New MySqlConnection
        MyConnq.ConnectionString = ConnMysql
        Dim DA As New MySqlDataAdapter(Strsql, MyConnq)
        Dim DS As New DataSet(DatasetName)
        Try
            DA.Fill(DS, TableName)
        Catch x1 As Exception
            Err.Raise(60002, , x1.Message)
            MsgBox(x1.Message.ToString)
        End Try
        Return DS
    End Function
    Function GetMYSQLDataset(ByVal Strsql As String, ByVal DatasetName As DataSet, _
          Optional ByVal TableName As String = "Table") As DataSet
        Dim MyConnq As New MySqlConnection
        MyConnq.ConnectionString = ConnMysql
        Dim DA As New MySqlDataAdapter(Strsql, MyConnq)
        Try
            System.Diagnostics.EventLog.WriteEntry(Application.ProductName, Strsql, EventLogEntryType.Information)
            DA.Fill(DatasetName, TableName)
        Catch x1 As Exception
            Err.Raise(60002, , x1.Message)
            MsgBox(x1.Message.ToString)
        End Try
        Return DatasetName
    End Function
    Sub FillDataset(ByVal Strsql As String, ByVal DatasetName As DataSet, ByVal TableName As String)
        Dim MyConnq As New MySqlConnection
        MyConnq.ConnectionString = ConnMysql
        Dim DA As New MySqlDataAdapter(Strsql, MyConnq)
        Try
            System.Diagnostics.EventLog.WriteEntry(Application.ProductName, Strsql, EventLogEntryType.Information)
            DA.Fill(DatasetName, TableName)
        Catch x1 As Exception
            Err.Raise(60002, , x1.Message)
            MsgBox(x1.Message.ToString)
        End Try
    End Sub


    Function GetMYSQLDataTable(ByVal Strsql As String, _
    Optional ByVal TableName As String = "Table", Optional ByVal StrMySqlConn As String = "") As DataTable
        Dim MyConnq As New MySqlConnection
        If StrMySqlConn = "" Then
            MyConnq.ConnectionString = ConnMysql
        Else
            MyConnq.ConnectionString = StrMySqlConn
        End If



        Dim DA As New MySqlDataAdapter(Strsql, MyConnq)
        Dim DT As New DataTable(TableName)
        Try

            DA.Fill(DT)
        Catch x1 As Exception
            Err.Raise(60002, , x1.Message)
            MsgBox(x1.Message.ToString, MsgBoxStyle.Critical, "SQL Exception")
        End Try
        Return DT
    End Function


    Function MySQLExecute(ByRef CmdStr As String, ByVal Conn As MySqlConnection) As Integer
        Dim Cmd As New MySqlCommand
        Cmd.CommandText = CmdStr
        Cmd.Connection = Conn
        Dim X As Integer
        Try
            Conn.Open()
            X = Cmd.ExecuteNonQuery()
        Catch
            X = -1
        Finally
            Conn.Close()
        End Try
        Return X
    End Function
    Function MySQLExecute(ByRef CmdStr As String) As Integer
        Dim MyConnq As New MySqlConnection
        MyConnq.ConnectionString = ConnMysql
        Dim Cmd As New MySqlCommand
        Cmd.CommandText = CmdStr
        Cmd.Connection = MyConnq
        Dim X As Integer
        Try
            MyConnq.Open()
            X = Cmd.ExecuteNonQuery()
        Catch
            X = -1
        Finally
            MyConnq.Close()
        End Try
        Return X
    End Function

    Function MySQLExecuteScalar(ByVal connString As String, ByVal cmdType As CommandType, ByVal cmdText As String, ByVal cmdParms As MySqlParameter()) As Object
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            MySQLPrepareCommand(cmd, conn, cmdType, cmdText, cmdParms)
            Dim val As Object = cmd.ExecuteScalar()

            cmd.Parameters.Clear()

            Return val
        Catch ex As SqlException

            Throw New Exception("SQL Exception ", ex)
        Catch exx As Exception
            Throw New Exception("ExeculateScalar", exx)
        Finally
            conn.Close()
            conn = Nothing
            cmd = Nothing
        End Try
    End Function
    Function MySQLExecuteScalar(ByVal cmdType As CommandType, ByVal cmdText As String, ByVal cmdParms As MySqlParameter()) As Object
        Dim MyConnq As New MySqlConnection
        MyConnq.ConnectionString = ConnMysql
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            MySQLPrepareCommand(cmd, MyConnq, cmdType, cmdText, cmdParms)
            Dim val As Object = cmd.ExecuteScalar()
            cmd.Parameters.Clear()
            Return val
        Catch ex As SqlException
            Throw New Exception("SQL Exception ", ex)
        Catch exx As Exception
            Throw New Exception("ExeculateScalar", exx)
        Finally
            cmd.Connection.Close()
            cmd = Nothing
        End Try
    End Function
    Function MySQLExecuteScalar(ByVal cmdText As String) As Object
        Dim MyConnq As New MySqlConnection
        MyConnq.ConnectionString = ConnMysql
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            If Not MyConnq.State = ConnectionState.Open Then
                'MsgBox("Connection open")
                MyConnq.Open()
            End If
            cmd.Connection = MyConnq
            cmd.CommandText = cmdText
            Dim val As Object = cmd.ExecuteScalar()
            cmd.Parameters.Clear()
            Return val
        Catch ex As SqlException
            Throw New Exception("SQL Exception ", ex)
        Catch exx As Exception
            MsgBox(exx.Message)
            Throw New Exception("ExeculateScalar", exx)
        Finally
            cmd.Connection.Close()
            cmd = Nothing
        End Try
    End Function

    Public Function MySQLPrepareCommand(ByRef cmd As MySqlCommand, ByRef conn As MySqlConnection, ByRef cmdType As CommandType, ByRef cmdText As String, ByRef cmdParms As MySqlParameter()) As Boolean
        If Not conn.State = ConnectionState.Open Then
            'MsgBox("Connection open")
            conn.Open()
        End If
        Try
            cmd.Connection = conn
            cmd.CommandText = cmdText
            cmd.Parameters.Clear()
            '  cmd.ParameterCheck = True
            cmd.CommandType = cmdType
            If Not (IsNothing(cmdParms)) Then
                Dim parm As MySqlParameter
                For Each parm In cmdParms
                    cmd.Parameters.Add(parm)
                Next
            End If
        Catch ex As SqlException
            Throw New Exception("SQL Exception ", ex)
        Catch exx As Exception
            Throw New Exception("PrepareCommand : ", exx)
        End Try
    End Function
    Public Sub MYSQLCreateParam(ByRef Cmd As MySqlCommand, ByVal StrType As String)
        'T:Text, M:Memo, Y:Currency, D:Datetime, I:Integer, S:Single, B:Boolean, P: Picture
        Dim i As Integer
        Dim j As String
        For i = 1 To Len(StrType)
            j = UCase(Mid(StrType, i, 1))
            Dim P1 As New MySqlParameter
            P1.ParameterName = "@P" & i
            Select Case j
                Case "T"
                    P1.MySqlDbType = MySqlDbType.VarChar
                Case "M"
                    P1.MySqlDbType = MySqlDbType.Text
                Case "Y"
                    P1.MySqlDbType = MySqlDbType.Decimal
                Case "D"
                    P1.MySqlDbType = MySqlDbType.DateTime
                Case "I"
                    P1.MySqlDbType = MySqlDbType.Int64
                Case "S"
                    P1.MySqlDbType = MySqlDbType.Decimal
                Case "B"
                    P1.MySqlDbType = MySqlDbType.Bit
                Case "P"
                    P1.MySqlDbType = MySqlDbType.Binary
            End Select
            Cmd.Parameters.Add(P1)
        Next
    End Sub
    Public Function MYSQLCreateCommand(ByVal Strsql As String) As MySqlCommand
        Dim cmd As New MySqlCommand(Strsql)
        Return cmd
    End Function
    Public Shared Function MYSQLExecQuery(ByVal ProcedureName As String, ByVal Parms As MySqlParameter(), ByVal sqlconn As MySqlConnection, Optional ByVal DatasetName As String = "Dataset1") As DataSet
        Dim dsDataSet As New DataSet(DatasetName)
        ' Configure the MySqlCommand object
        Dim _cmdSqlCommand As MySqlCommand = New MySqlCommand()

        With _cmdSqlCommand
            .CommandType = CommandType.StoredProcedure      'Set type to StoredProcedure
            .CommandText = ProcedureName                    'Specify stored procedure to run
            .Connection = sqlconn

            ' Clear any previous parameters from the Command object
            Call .Parameters.Clear()

            ' Loop through parmameter collection adding parameters to the command object
            If Not (Parms Is Nothing) Then
                For Each sqlParm As MySqlParameter In Parms
                    _cmdSqlCommand.Parameters.Add(sqlParm)
                Next
            End If
        End With

        Dim _adpAdapter As MySqlDataAdapter = New MySqlDataAdapter()
        ' Configure Adapter to use newly created command object and fill the dataset.
        _adpAdapter.SelectCommand = _cmdSqlCommand
        _adpAdapter.Fill(dsDataSet)

        Return dsDataSet
    End Function
#End Region

End Class
