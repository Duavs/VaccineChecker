Imports System.Data.OleDb
Public Class Form1
    Dim pro As String
    Dim str As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim query As String
    Dim myreader As OleDbDataReader
    Dim strsql As String
    Public Sub Connection()
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Duavs\source\repos\VaccineChecker\VaccineChecker\dbvaccine.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()

    End Sub

    Public Sub load_data()
        Try
            query = "SELECT * FROM vaccinatedlist"

            Dim search As New OleDbDataAdapter(query, myconnection)
            Dim ds As DataSet = New DataSet
            search.Fill(ds, "vaccinatedlist")
            DataGridView.DataSource = ds.Tables("vaccinatedlist")
            Label1.Text = "Total:" & DataGridView.Rows.Count

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub VaccinatedlistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VaccinatedlistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbvaccineDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VaccinatedlistTableAdapter.Fill(Me.DbvaccineDataSet.vaccinatedlist)
        Connection()
        load_data()
        str = ""
        cbfirstdose.Checked = True
        cbseconddose.Enabled = False
        dtpseconddose.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles clear.Click
        tbxfirstname.Clear()
        tbxID.Clear()
        tbxlastname.Clear()
        tbxmi.Clear()
        TextBox1.Clear()
        cbseconddose.Checked = False
        cbfirstdose.Checked = True
        cbfirstdose.Enabled = True
        dtpfirstdose.Enabled = True
        cmbvaccine.Enabled = True
        btnsave.Enabled = True
        cbseconddose.Enabled = False
        dtpseconddose.Enabled = False
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        command = "insert into vaccinatedlist([ID],[Lastname], [Firstname], [MI], [Date of Birth], [FirstDose Covid19], [SecondDose Covid19], [FirstDose],  [Vaccine Brand]) values ('" & tbxID.Text & "','" & tbxlastname.Text & "','" & tbxfirstname.Text & "','" & tbxmi.Text & "', '" & dtpbirthday.Value & "', " & cbfirstdose.Checked & ", " & cbseconddose.Checked & ", '" & dtpfirstdose.Value & "',  '" & cmbvaccine.Text & "')"
        Dim Cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        Cmd.Parameters.Add(New OleDbParameter("ID", CType(tbxID.Text, String)))

        Cmd.Parameters.Add(New OleDbParameter("Lastname", CType(tbxlastname.Text, String)))
        Cmd.Parameters.Add(New OleDbParameter("Firstname", CType(tbxfirstname.Text, String)))
        Cmd.Parameters.Add(New OleDbParameter("MI", CType(tbxmi.Text, String)))
        Cmd.Parameters.Add(New OleDbParameter("Date of Birth", CType(dtpbirthday.Value, String)))
        If cbfirstdose.Checked = True Then
            Cmd.Parameters.Add(New OleDbParameter("FirstDose Covid19", CType(cbfirstdose.Checked, String)))
        End If
        If cbseconddose.Checked = True Then
            Cmd.Parameters.Add(New OleDbParameter("SecondDose Covid19", CType(cbseconddose.Checked, String)))
        End If
        Cmd.Parameters.Add(New OleDbParameter("FirstDose", CType(dtpfirstdose.Value, String)))
        Cmd.Parameters.Add(New OleDbParameter("Vaccine Brand", CType(cmbvaccine.ValueMember, String)))
        strsql = "select [ID] from vaccinatedlist where [ID] = " + tbxID.Text + ""
        Dim cmd2 As New OleDbCommand(strsql, myconnection)
        myreader = cmd2.ExecuteReader
        If (myreader.Read()) Then
            MsgBox("ID duplicate")
            Return
        End If
        If tbxID.Text = "" Or tbxlastname.Text = "" Or tbxfirstname.Text = "" Or tbxmi.Text = "" Then
            MsgBox("Please fill the missing feild")
            Return
        End If
        Try
        Cmd.ExecuteNonQuery()
            MsgBox("Record Save")
            load_data()
            tbxfirstname.Clear()
            tbxID.Clear()
            tbxlastname.Clear()
            tbxmi.Clear()
            Cmd.Dispose()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView.CellMouseClick
        selectedrow = DataGridView.Rows(e.RowIndex)
        tbxID.Text = Form1.selectedrow.Cells(0).Value.ToString()
        tbxlastname.Text = Form1.selectedrow.Cells(1).Value.ToString()
        tbxfirstname.Text = Form1.selectedrow.Cells(2).Value.ToString()
        tbxmi.Text = Form1.selectedrow.Cells(3).Value.ToString()
        dtpbirthday.Value = Form1.selectedrow.Cells(4).Value.ToString()
        cbfirstdose.Checked = Form1.selectedrow.Cells(5).Value.ToString()
        cbseconddose.Checked = Form1.selectedrow.Cells(6).Value.ToString()
        dtpfirstdose.Value = Form1.selectedrow.Cells(7).Value.ToString()
        cmbvaccine.Text = Form1.selectedrow.Cells(9).Value.ToString()
        If cbfirstdose.Checked AndAlso cbseconddose.Checked Then
            MsgBox("Congratulations! You are fully vaccinated")
        End If
        cbfirstdose.Enabled = False
        cbseconddose.Enabled = True
        dtpfirstdose.Enabled = False
        dtpseconddose.Enabled = True

    End Sub
    Public Shared Property selectedrow As DataGridViewRow

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim cmd1 As New OleDbCommand("select [ID], [Lastname], [Firstname], [MI], [Date of Birth], [FirstDose Covid19], [SecondDose Covid19], [FirstDose], [SecondDose], [Vaccine Brand] from vaccinatedlist where [ID] like '%" + TextBox1.Text + "%'", myconnection)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)

        DataGridView.DataSource = dt
        DataGridView.Columns(0).HeaderText = "ID"
        DataGridView.Columns(1).HeaderText = "Lastname"
        DataGridView.Columns(2).HeaderText = "Firstname"
        DataGridView.Columns(3).HeaderText = "MI"
        DataGridView.Columns(4).HeaderText = "Date of Birth"
        DataGridView.Columns(5).HeaderText = "FirstDose Covid19"
        DataGridView.Columns(6).HeaderText = "SecondDose Covid19"
        DataGridView.Columns(7).HeaderText = "FistDose"
        DataGridView.Columns(8).HeaderText = "SecondDose"
        DataGridView.Columns(9).HeaderText = "Vaccine Brand"

    End Sub

    Private Sub btnupdate_Click_1(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim Cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cbseconddose.Enabled = True
        Dim cmdupdate As New OleDbCommand("Update vaccinatedlist set [Lastname] = '" & tbxlastname.Text & "', [Firstname] = '" & tbxfirstname.Text & "', [MI] = '" & tbxmi.Text & "', [Date of Birth] = '" & dtpbirthday.Value & "', [FirstDose Covid19] = " & cbfirstdose.Checked & ", [SecondDose Covid19] = " & cbseconddose.Checked & ", [FirstDose] = '" & dtpfirstdose.Value & "', [SecondDose] = '" & dtpseconddose.Value & "' where [ID] = " & tbxID.Text & "", myconnection)
        cmdupdate.Parameters.Add(New OleDbParameter("Vaccine Brand", CType(cmbvaccine.ValueMember, String)))
        cmdupdate.ExecuteNonQuery()
        MsgBox("Data Updated")
        load_data()
        cbfirstdose.Enabled = False
        cbseconddose.Enabled = False
        dtpfirstdose.Enabled = False
        dtpseconddose.Enabled = False
        btnsave.Enabled = True
        tbxfirstname.Clear()
        tbxID.Clear()
        tbxlastname.Clear()
        tbxmi.Clear()
        cbseconddose.Checked = False
        cbfirstdose.Checked = True
        cbfirstdose.Enabled = True
        dtpfirstdose.Enabled = True
        cmbvaccine.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmddelete As New OleDbCommand("DELETE from vaccinatedlist where ID = @ID", myconnection)
        cmddelete.Parameters.AddWithValue("@ID", tbxID.Text)
        cmddelete.ExecuteNonQuery()
        load_data()
        cbfirstdose.Enabled = False
        cbseconddose.Enabled = False
        dtpfirstdose.Enabled = False
        dtpseconddose.Enabled = False
        btnsave.Enabled = True
        tbxfirstname.Clear()
        tbxID.Clear()
        tbxlastname.Clear()
        tbxmi.Clear()
        cbseconddose.Checked = False
        cbfirstdose.Checked = True
        cbfirstdose.Enabled = True
        dtpfirstdose.Enabled = True
        cmbvaccine.Enabled = True
    End Sub
    Private Sub tbxID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
