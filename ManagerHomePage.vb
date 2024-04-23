﻿Imports System.Data.SqlClient

Public Class ManagerHomePage

    Public pid As String = "new"
    Public title, startdate, deadline, people As String

    Private Sub LogoutManager_Click(sender As Object, e As EventArgs) Handles LogoutManager.Click
        Me.Close()
    End Sub

    Private Sub NewProject_Click(sender As Object, e As EventArgs) Handles NewProject.Click
        pid = "new"
        NewProjectWizard.Show()
        Me.Enabled = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'creating a sql command statement 
        Dim form2command As SqlCommand = LoginForm.sql.CreateCommand()
        form2command.CommandText = "SELECT * FROM Employees WHERE Id ='" + LoginForm.UserIDBox.Text + "'"

        'sqladapter to handle the sql commands 
        Dim form2sqlAdapter As New SqlDataAdapter With {
            .SelectCommand = form2command
        }

        'creates a table with the required data
        Dim form2data As New DataSet()
        form2sqlAdapter.Fill(form2data)

        'fill the data in the required places
        ManagerName.Text = form2data.Tables(0).Rows(0)(1).ToString()
        ManagerId.Text = form2data.Tables(0).Rows(0)(0).ToString()

        'fetch all the projects under current manager
        DataLoader()
    End Sub

    Public Sub DataLoader()
        'creating a sql command statement 
        Dim Consolecommand As SqlCommand = LoginForm.sql.CreateCommand()
        Consolecommand.CommandText = "SELECT PId, Title, Startdate, Deadline,People FROM Projects WHERE ManagerId = '" & ManagerId.Text & "'"

        'sqladapter to handle the sql commands 
        Dim ConsolesqlAdapter As New SqlDataAdapter With {
            .SelectCommand = Consolecommand
        }

        'creates a table with the required data
        Dim Consoledata As New DataSet()
        ConsolesqlAdapter.Fill(Consoledata)

        'shows the table if the employee is assigned to any task
        If (Consoledata.Tables(0).Rows.Count) > 0 Then
            ManagerDataGrid.Visible = True
            ManagerDataGrid.DataSource = Consoledata.Tables(0)
        End If
    End Sub

    Private Sub ManagerHomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim responce As String = MsgBox("Do you want to Logout?", vbYesNo, "Are You Sure?")
        If responce = vbYes Then
            'disconnects sql connection
            LoginForm.sql.Close()
            LoginForm.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ManagerDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ManagerDataGrid.CellContentClick
        With ManagerDataGrid
            pid = .Rows(.CurrentCell.RowIndex).Cells(0).Value.ToString
            title = .Rows(.CurrentCell.RowIndex).Cells(1).Value.ToString
            startdate = .Rows(.CurrentCell.RowIndex).Cells(2).Value.ToString
            deadline = .Rows(.CurrentCell.RowIndex).Cells(3).Value.ToString
            people = .Rows(.CurrentCell.RowIndex).Cells(4).Value.ToString
            ProjectLayout.Show()
        End With
        Me.Enabled = False
    End Sub

    Private Sub ProjectBox_Enter(sender As Object, e As EventArgs) Handles ProjectBox.Enter

    End Sub
End Class