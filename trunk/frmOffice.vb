Public Class frmOffice
    Dim Strsql As String
    Dim _mssql As New ClsSQLhelper
    Dim MyConn As New SqlClient.SqlConnection
    Dim On_Load As Boolean = True
#Region "Function"

    Sub Load_Province(Optional ByVal ProvinceID As String = "")
        Strsql = "Select province,provname from tbProvince"
        If ProvinceID <> "" Then
            Strsql = Strsql & " where province = '" & ProvinceID & "'"
        End If
        Dim DT_tbProvince As New DataTable
        DT_tbProvince = _mssql.GetMSSQLDataTable(Strsql, MyConn, "tbProvince")
        With Me.CboProvince
            .DataSource = DT_tbProvince
            .DisplayMember = "provname"
            .ValueMember = "province"
            Me.TxtProvince.Text = DT_tbProvince.Rows(0).Item("province").ToString
        End With

    End Sub
    Sub Load_district(Optional ByVal districtID As String = "")
        Strsql = "Select district,distname from tbdistrict where province = " & Me.TxtProvince.Text
        If districtID <> "" Then
            Strsql = Strsql & " and district = '" & districtID & "'"
        End If
        Dim DT_tbdistrict As New DataTable
        DT_tbdistrict = _mssql.GetMSSQLDataTable(Strsql, MyConn, "tbdistrict")
        With Me.CboAmp
            .DataSource = DT_tbdistrict

            .DisplayMember = "distname"
            .ValueMember = "district"
            Me.TxtAmph.Text = DT_tbdistrict.Rows(0).Item("district").ToString

        End With

    End Sub
    Sub Load_subdistrict(Optional ByVal subdistrictID As String = "")
        Strsql = "Select subdistrict,subdname from tbsubdistrict where province = " & Me.TxtProvince.Text & " and   district = " & Me.TxtAmph.Text
        If subdistrictID <> "" Then
            Strsql = Strsql & " and subdistrict = '" & subdistrictID & "'"
        End If
        Dim DT_subdistrict As New DataTable
        DT_subdistrict = _mssql.GetMSSQLDataTable(Strsql, MyConn, "tbsubdistrict")
        With Me.CboTumbon
            .DataSource = DT_subdistrict
            .DisplayMember = "subdname"
            .ValueMember = "subdistrict"
            Me.TxtTumbon.Text = DT_subdistrict.Rows(0).Item("subdistrict").ToString
        End With

    End Sub
    Sub Load_Office(Optional ByVal OfficeID As String = "")
        Strsql = "Select pcucode,{FN CONCAT(name2,pcuname)} as officename  from tbpcu where province = '" & Me.TxtProvince.Text & "' and district = '" & Me.TxtAmph.Text & "' and subdistrict = '" & Me.TxtTumbon.Text & "'"
        If OfficeID <> "" Then
            Strsql = "Select pcucode,{FN CONCAT(name2,pcuname)} as officename,province,district,subdistrict  from tbpcu where  pcucode = '" & OfficeID & "'"
        End If
        Dim DT_PCU As New DataTable
        DT_PCU = _mssql.GetMSSQLDataTable(Strsql, MyConn, "tbpcu")

        With Me.CboOffice
            .DataSource = DT_PCU

            .DisplayMember = "officename"
            .ValueMember = "pcucode"

        End With

        If OfficeID <> "" Then

            'Dim DT_PCU2 As New DataTable
            'DT_PCU2 = _mssql.GetMSSQLDataTable(Strsql, MyConn, "tbpcu")
            Me.TxtOfficeCode.Text = DT_PCU.Rows(0).Item("pcucode")
            Load_Province(DT_PCU.Rows(0).Item("province"))
            Load_district(DT_PCU.Rows(0).Item("district"))
            Load_subdistrict(DT_PCU.Rows(0).Item("subdistrict"))

        End If
    End Sub
    Sub Load_Data()
        Try

            MyConn.ConnectionString = My.Settings.ConnStr



            MyConn.ConnectionString = My.Settings.ConnStr
            Strsql = "Select tbpcu.pcucode,{FN CONCAT(tbpcu.name2,tbpcu.pcuname)} as officename,tbpcu.province,tbpcu.district,tbpcu.subdistrict  from tbProgrameValue left join tbpcu on tbProgrameValue.pcucode = tbpcu.pcucode"
            Dim DT_ProgrameValue As New DataTable
            DT_ProgrameValue = _mssql.GetMSSQLDataTable(Strsql, MyConn, "tbProgrameValue")

            If DT_ProgrameValue.Rows.Count <> 0 Then
                'Me.TxtOfficeCode.Text = DT_ProgrameValue.Rows(0).Item("pcucode")
                'Me.TxtProvince.Text = DT_ProgrameValue.Rows(0).Item("province")
                'Me.TxtAmph.Text = DT_ProgrameValue.Rows(0).Item("district")
                'Me.TxtTumbon.Text = DT_ProgrameValue.Rows(0).Item("subdistrict")
                'Me.CboOffice.Text = DT_ProgrameValue.Rows(0).Item("officename")



                'Me.CboProvince.SelectedValue = DT_ProgrameValue.Rows(0).Item("province")
                'Me.CboAmp.SelectedValue = DT_ProgrameValue.Rows(0).Item("district")
                'Me.CboTumbon.SelectedValue = DT_ProgrameValue.Rows(0).Item("subdistrict")
                Load_Province(DT_ProgrameValue.Rows(0).Item("province"))
                Load_district(DT_ProgrameValue.Rows(0).Item("district"))
                Load_subdistrict(DT_ProgrameValue.Rows(0).Item("subdistrict"))
                Load_Office(DT_ProgrameValue.Rows(0).Item("pcucode"))
            Else
                Load_Province()
                Load_district()
                Load_subdistrict()
                Load_Office()
            End If

            On_Load = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub frmOffice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Load_Data()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Try
            Strsql = "Update tbProgrameValue set pcucode = " & Me.TxtOfficeCode.Text & ",province = " & Me.TxtProvince.Text & ",district = " & Me.TxtAmph.Text & ",subdistrict = " & Me.TxtTumbon.Text
            _mssql.Execute(Strsql)
            MsgBox("ปรับปรุงข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "ผลการปรับปรุงข้อมูล")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TxtOfficeCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOfficeCode.KeyDown
        If On_Load = True Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            Load_Office(Me.TxtOfficeCode.Text)
        End If
    End Sub
    Private Sub TxtProvince_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProvince.KeyDown
        If On_Load = True Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            Load_Province(Me.TxtProvince.Text)
        End If
    End Sub
    Private Sub TxtAmph_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAmph.KeyDown
        If On_Load = True Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            Load_district(Me.TxtAmph.Text)
        End If
    End Sub
    Private Sub TxtTumbon_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTumbon.KeyDown
        If On_Load = True Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            Load_subdistrict(Me.TxtTumbon.Text)
        End If
    End Sub

    Private Sub TxtOfficeCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOfficeCode.EditValueChanged

    End Sub

    Private Sub TxtProvince_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProvince.EditValueChanged

    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Load_Data()
    End Sub
End Class