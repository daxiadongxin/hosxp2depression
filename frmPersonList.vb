Public Class frmPersonList
    Dim Strsql As String
    Dim _mssql As New ClsSQLhelper
    Dim MyConn As New SqlClient.SqlConnection
#Region "Function"
    Sub Load_Data(Optional ByVal CID As String = "", Optional ByVal Fullname As String = "")
        Try
            Strsql = "Select * from tbProgrameValue"
            Strsql = "select [tbPerson].cid,tbPerson.Prename,[tbPerson].firstname ,[tbPerson].lastname ,datediff(YY, [tbPerson].birthday, getdate())  as age,[tbPerson].cardtype,[tbcardtype].ctypename ,[tbPerson].cardid ,[tbPerson].mfgdate ,[tbPerson].expdate ,[tbPerson].birthday,r1   from [tbPerson] left join tbcardtype on [tbPerson].cardtype  = [tbcardtype].cardtype "
            If Me.TxtCID.Text <> "" And Me.TxtFullname.Text = "" Then
                Strsql = Strsql & " where [tbPerson].cid like '" & Me.TxtCID.Text & "%'"
            ElseIf Me.TxtCID.Text <> "" And Me.TxtFullname.Text <> "" Then
                Strsql = Strsql & " where [tbPerson].cid like '" & Me.TxtCID.Text & "%'"
                If InStr(Me.TxtFullname.Text, " ", CompareMethod.Text) = 0 Then
                    Strsql = Strsql & " and [tbPerson].firstname  like '" & Me.TxtFullname.Text & "%'"
                Else
                    Strsql = Strsql & " and [tbPerson].firstname + ' ' + [tbPerson].lastname like '" & Me.TxtFullname.Text & "%'"
                End If
            ElseIf Me.TxtCID.Text = "" And Me.TxtFullname.Text <> "" Then
                If InStr(Me.TxtFullname.Text, " ", CompareMethod.Text) = 0 Then
                    Strsql = Strsql & " where [tbPerson].firstname  like '" & Me.TxtFullname.Text & "%'"
                Else
                    Strsql = Strsql & " where [tbPerson].firstname + ' ' + [tbPerson].lastname like '" & Me.TxtFullname.Text & "%'"
                End If
            End If

            Dim DT_Person As New DataTable
            DT_Person = _mssql.GetMSSQLDataTable(Strsql, MyConn, "Person")
            With GridPerson
                .DataSource = DT_Person
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    
#End Region
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Dispose()

    End Sub

    Private Sub BtnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowAll.Click
        Load_Data()
    End Sub

    Private Sub frmPersonList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyConn.ConnectionString = My.Settings.ConnStr
        Load_Data()

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Load_Data(Me.TxtCID.Text, Me.TxtFullname.Text)
    End Sub
End Class