Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ClsSQLhelper

#Region "MSSQL"
    Public Function GetMSSQLDataset(ByVal Strsql As String, ByVal sqlconn As SqlConnection, _
           Optional ByVal DatasetName As String = "Dataset1", _
           Optional ByVal TableName As String = "Table") As DataSet
        Dim DA As New SqlDataAdapter(Strsql, sqlconn)
        Dim DS As New DataSet(DatasetName)
        Try
            DA.Fill(DS, TableName)
        Catch x1 As Exception
            Err.Raise(60002, , x1.Message)
        End Try
        Return DS
    End Function
    Public Function GetMSSQLDataTable(ByVal Strsql As String, ByVal sqlconn As SqlConnection, _
        Optional ByVal TableName As String = "Table") As DataTable
        Dim DA As New SqlDataAdapter(Strsql, sqlconn)
        Dim DT As New DataTable(TableName)
        Try
            DA.Fill(DT)
        Catch x1 As Exception
            Err.Raise(60002, , x1.Message)
        End Try
        Return DT
    End Function
    Public Function CreateCommand(ByVal Strsql As String) As SqlCommand
        Dim cmd As New SqlCommand(Strsql)
        Return cmd
    End Function
    Public Function Execute(ByVal Strsql As String) As Integer
        Dim cmd As New SqlCommand
        Dim Conn As New SqlConnection
        Conn.ConnectionString = My.Settings.ConnStr
        cmd.CommandText = Strsql
        cmd.Connection = Conn
        Dim X As Integer

        Try
            Conn.Open()
            X = cmd.ExecuteNonQuery()
        Catch
            X = -1
        Finally
            Conn.Close()
        End Try
        Return X


    End Function
    Public Function Execute(ByVal Strsql As String, ByRef NeedErrDesc As Boolean) As String
        Dim cmd As New SqlCommand
        Dim Conn As New SqlConnection
        Conn.ConnectionString = My.Settings.ConnStr
        cmd.CommandText = Strsql
        cmd.Connection = Conn
        Dim X As Integer

        Try
            Conn.Open()
            X = cmd.ExecuteNonQuery()
            Return X
        Catch ex As Exception
            If Err.Number = 5 Then
                Execute = "¢éÍÁÙÅ«éÓ«éÍ¹"
            Else
                Execute = Err.Number & " : " & ex.Message
            End If

        Finally
            Conn.Close()
        End Try



    End Function
    Public Function Execute(ByRef Cmd As SqlCommand, ByVal sqlconn As SqlConnection) As Integer
        Cmd.Connection = sqlconn
        Dim X As Integer
        Try
            sqlconn.Open()
            X = Cmd.ExecuteNonQuery()
        Catch ex As Exception
            X = -1
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
        Return X

    End Function
    Public Sub CreateParam(ByRef Cmd As SqlCommand, ByVal StrType As String)
        'T:Text, M:Memo, Y:Currency, D:Datetime, I:Integer, S:Single, B:Boolean, P: Picture
        Dim i As Integer
        Dim j As String
        For i = 1 To Len(StrType)
            j = UCase(Mid(StrType, i, 1))
            Dim P1 As New SqlParameter
            P1.ParameterName = "@P" & i
            Select Case j
                Case "T"
                    P1.SqlDbType = SqlDbType.VarChar
                Case "M"
                    P1.SqlDbType = SqlDbType.Text
                Case "Y"
                    P1.SqlDbType = SqlDbType.Money
                Case "D"
                    P1.SqlDbType = SqlDbType.DateTime
                Case "I"
                    P1.SqlDbType = SqlDbType.Int
                Case "S"
                    P1.SqlDbType = SqlDbType.Decimal
                Case "B"
                    P1.SqlDbType = SqlDbType.Bit
                Case "P"
                    P1.SqlDbType = SqlDbType.Image
            End Select
            Cmd.Parameters.Add(P1)
        Next
    End Sub
    Public Function ExecQuery(ByVal ProcedureName As String, ByVal Parms As SqlParameter(), ByVal sqlconn As SqlConnection, Optional ByVal DatasetName As String = "Dataset1") As DataSet
        '****************************************************************************************
        ' ExecQuery
        ' ABSTRACT: Executes a stored procedure against the Eisemann database and returns
        '   a NEW Dataset with the selected data.
        '
        ' INPUT PARMS:  ProcedureName   Name of Stored Procedure to execute
        '               Parms           Array of SqlParameter objects that will be passed into the
        '                               stored procedure.
        '
        ' RETURNS:      DataSet populated with results from stored procedure execution.
        '
        '****************************************************************************************
        Dim dsDataSet As New DataSet(DatasetName)
        ' Configure the SqlCommand object
        Dim _cmdSqlCommand As SqlCommand = New SqlCommand()

        With _cmdSqlCommand
            .CommandType = CommandType.StoredProcedure      'Set type to StoredProcedure
            .CommandText = ProcedureName                    'Specify stored procedure to run
            .Connection = sqlconn

            ' Clear any previous parameters from the Command object
            Call .Parameters.Clear()

            ' Loop through parmameter collection adding parameters to the command object
            If Not (Parms Is Nothing) Then
                For Each sqlParm As SqlParameter In Parms
                    _cmdSqlCommand.Parameters.Add(sqlParm)
                Next
            End If
        End With

        Dim _adpAdapter As SqlDataAdapter = New SqlDataAdapter()
        ' Configure Adapter to use newly created command object and fill the dataset.
        _adpAdapter.SelectCommand = _cmdSqlCommand
        _adpAdapter.Fill(dsDataSet)

        Return dsDataSet
    End Function
#End Region
End Class
