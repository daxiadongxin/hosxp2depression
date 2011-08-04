Public Class frmCheckOnlinePatient 
    Dim Strsql As String
    Dim _mysql As New mysqlhelper
#Region "Function"
    Sub Load_Data()
        Try

            Strsql = "select id,offid,hn,prename,firstname,lastname,cid,sexid,birthdate,address,villid,subdistid,distid,provid,registdate"
            Strsql = Strsql & ",solution,statusid,ifnull(date_2q,'') as date_2q,score2q,ifnull(date_8q,'') as date_8q,score8q,ifnull(date_9q,'') as date_9q,score9q,ifnull(drugdate,'') as drugdate,drug,drug2,drug3,username,ifnull(lastupdate,'') as lastupdate"
            Strsql = Strsql & ",cardno,ifnull(beingdate,'') as beingdate,chronicid,chroniccode,ifnull(beingdate,'') as expdate,exported,onserver,time from depres_person where cid = '" & Me.TxtCID.Text & "'"



            Dim DT_DepresPerson As New DataTable

            DT_DepresPerson = _mysql.GetMYSQLDataTable(Strsql, "depres_person", _mysql.DepressSQLConnectionStr)
            If DT_DepresPerson.Rows.Count = 0 Then
                MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Exclamation)

                Exit Sub
            Else

                MsgBox("พบข้อมูลทั้งสิ้น " & DT_DepresPerson.Rows.Count & " Record(s)", MsgBoxStyle.Exclamation)
                With Me.GridControl1

                    .DataSource = DT_DepresPerson
                End With
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub BtnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCheck.Click
        If Me.TxtCID.Text <> "" Then
            Load_Data()
        End If
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub


    Private Sub frmCheckOnlinePatient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With Me.GridColumn1
            .Visible = True
            .Caption = "id"
            .FieldName = "id"
        End With

        With Me.GridColumn2
            .Visible = True
            .Caption = "offid"
            .FieldName = "offid"
        End With

        With Me.GridColumn3
            .Visible = True
            .Caption = "hn"
            .FieldName = "hn"
        End With

        With Me.GridColumn4
            .Visible = True
            .Caption = "prename"
            .FieldName = "prename"
        End With

        With Me.GridColumn5
            .Visible = True
            .Caption = "firstname"
            .FieldName = "firstname"
        End With

        With Me.GridColumn6
            .Visible = True
            .Caption = "lastname"
            .FieldName = "lastname"
        End With

        With Me.GridColumn7
            .Visible = True
            .Caption = "cid"
            .FieldName = "cid"
        End With

        With Me.GridColumn8
            .Visible = True
            .Caption = "sexid"
            .FieldName = "sexid"
        End With

        With Me.GridColumn9
            .Visible = True
            .Caption = "birthdate"
            .FieldName = "birthdate"
        End With

        With Me.GridColumn10
            .Visible = True
            .Caption = "address"
            .FieldName = "address"
        End With

        With Me.GridColumn11
            .Visible = True
            .Caption = "villid"
            .FieldName = "villid"
        End With

        With Me.GridColumn12
            .Visible = True
            .Caption = "subdistid"
            .FieldName = "subdistid"
        End With

        With Me.GridColumn13
            .Visible = True
            .Caption = "distid"
            .FieldName = "distid"
        End With

        With Me.GridColumn14
            .Visible = True
            .Caption = "provid"
            .FieldName = "provid"
        End With

        With Me.GridColumn15
            .Visible = True
            .Caption = "registdate"
            .FieldName = "registdate"
        End With

        With Me.GridColumn16
            .Visible = False
            .Caption = "solution"
            .FieldName = "solution"
        End With

        With Me.GridColumn17
            .Visible = False
            .Caption = "statusid"
            .FieldName = "statusid"
        End With

        With Me.GridColumn18
            .Visible = True
            .Caption = "date_2q"
            .FieldName = "date_2q"
        End With

        With Me.GridColumn19
            .Visible = True
            .Caption = "date_2q"
            .FieldName = "date_2q"
        End With

        With Me.GridColumn20
            .Visible = True
            .Caption = "date_8q"
            .FieldName = "date_8q"
        End With

        With Me.GridColumn21
            .Visible = True
            .Caption = "score8q"
            .FieldName = "score8q"
        End With

        With Me.GridColumn22
            .Visible = True
            .Caption = "date_9q"
            .FieldName = "date_9q"
        End With

        With Me.GridColumn23
            .Visible = True
            .Caption = "score9q"
            .FieldName = "score9q"
        End With

        With Me.GridColumn24
            .Visible = False
            .Caption = "drugdate"
            .FieldName = "drugdate"
        End With

        With Me.GridColumn25
            .Visible = False
            .Caption = "drug"
            .FieldName = "drug"
        End With

        With Me.GridColumn26
            .Visible = False
            .Caption = "drug2"
            .FieldName = "drug2"
        End With

        With Me.GridColumn27
            .Visible = False
            .Caption = "drug3"
            .FieldName = "drug3"
        End With

        With Me.GridColumn28
            .Visible = True
            .Caption = "username"
            .FieldName = "username"
        End With

        With Me.GridColumn29
            .Visible = True
            .Caption = "lastupdate"
            .FieldName = "lastupdate"
        End With

        With Me.GridColumn30
            .Visible = True
            .Caption = "cardno"
            .FieldName = "cardno"
        End With

        With Me.GridColumn31
            .Visible = True
            .Caption = "beingdate"
            .FieldName = "beingdate"
        End With
        With Me.GridColumn32
            .Visible = True
            .Caption = "chronicid"
            .FieldName = "chronicid"
        End With

        With Me.GridColumn33
            .Visible = True
            .Caption = "chroniccode"
            .FieldName = "chroniccode"
        End With

        With Me.GridColumn34
            .Visible = True
            .Caption = "expdate"
            .FieldName = "expdate"
        End With

        With Me.GridColumn35
            .Visible = True
            .Caption = "exported"
            .FieldName = "exported"
        End With

        With Me.GridColumn36
            .Visible = True
            .Caption = "onserver"
            .FieldName = "onserver"
        End With

        With Me.GridColumn37
            .Visible = True
            .Caption = "time"
            .FieldName = "time"
        End With
        With Me.GridControl1

            .DataSource = Nothing
        End With
    End Sub
End Class