﻿Imports System.Data.SqlClient

Public Class ProjectLayout
    Private reqana, Design, Development, Testing As Date
    Private NoOfDays As Integer
    Private ReqNo, DesNo, DevNo, TesNo, DepNo As Integer
    Public task As String

    Private Sub ProjectLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ManagerHomePage.pid <> "new" Then
            ProjectId.Text = ManagerHomePage.pid
        Else
            ProjectId.Text = NewProjectWizard.id
            UndoBtn.Enabled = False
        End If

        'adds data to the layout table
        Dim Com As String = "Select Days from Projects where PId ='" + ProjectId.Text + "'"

        'creating a sql command statement 
        Dim command As SqlCommand = LoginForm.sql.CreateCommand()
        command.CommandText = Com

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
             .SelectCommand = command
        }

        'creates a table with the required data
        Dim data As New DataSet()
        sqlAdapter.Fill(data)
        NoOfDays = Convert.ToInt32(data.Tables(0).Rows(0)(0).ToString)
        ProjectSpan.Text = "Project Span : " + NoOfDays.ToString + "Days"

        ManagerHomePage.Hide()
        'Filling all the fields when opened from clicking on Datagrid in ManagerHomePage
        If ManagerHomePage.pid <> "new" Then
            'ProjectId.Text = ManagerHomePage.pid
            ProjectName.Text = ManagerHomePage.title
            Start.Text = ManagerHomePage.startdate.ToString().Substring(0, 10)
            dead.Text = ManagerHomePage.deadline.ToString().Substring(0, 10)
            Count.Text = ManagerHomePage.people
            'reset width according to date
            SavedRatio()
        Else
            'Filling all the fields when opened from NewProjectWizard
            ' ProjectId.Text = NewProjectWizard.id
            ProjectName.Text = NewProjectWizard.ProjectName.Text
            Start.Text = Today.ToString("dd-MM-yyyy")
            dead.Text = NewProjectWizard.DeadlineDuration.Value.ToString("dd-MM-yyyy")
            Count.Text = NewProjectWizard.PeopleCount.Value
            'reset according to idea value ratio
            Ratio()

            'adds data to the layout table
            Dim que As String = "INSERT INTO Layout(PID, StartDate, Deadline) VALUES('" + NewProjectWizard.id + "','" + Today.ToString("MM-dd-yyyy") + "','" + NewProjectWizard.DeadlineDuration.Value.ToString("MM-dd-yyyy") + "')"
            'creating a sql command statement 
            Dim coma As SqlCommand = LoginForm.sql.CreateCommand()
            coma.CommandText = que
            'sqladapter to handle the sql commands 
            Dim Adapter As New SqlDataAdapter With {
             .SelectCommand = coma
            }
            'creates a table with the required data
            Dim da As New DataSet()
            Adapter.Fill(da)

        End If

        GetDays()
        GetEndDates()
        ToolTip()



        'qurry for adding row in layout with only pid and deadline
    End Sub

    'Project layout will be saved when Save button is clicked
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        LayoutTable()
        Dim responce As String = MsgBox("The changes are saved" + vbLf + "Do you want to exit?", vbYesNo, "Are you sure?")
        If responce = vbYes Then
            'will store the project layout in the layout table
            Me.Close()
        End If
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        EditProjectDetails.Show()
        Me.Enabled = False
        Me.Hide()
    End Sub

    Private Sub AddEmp_Click(sender As Object, e As EventArgs) Handles addEmp.Click
        Me.Enabled = False
        Contributors.Show()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        'starting stage sizes based on percentages 
        ReqPanel.Size = New Size(0.15 * DeploymentPanel.Size.Width, 50)
        DesPanel.Size = New Size(0.2 * DeploymentPanel.Size.Width, 50)
        DevelopmentPanel.Size = New Size(0.3 * DeploymentPanel.Size.Width, 50)
        TestingPanel.Size = New Size(0.25 * DeploymentPanel.Size.Width, 50)
        'starting stage positions based on sizes 
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        TestingPanel.Size = RightDevPanel.Size

    End Sub

    Private Sub ReqPanel_SizeChanged(sender As Object, e As EventArgs) Handles ReqPanel.SizeChanged
        GetDays()
        GetEndDates()
        ToolTip()
        SetDaysCount()
    End Sub

    Private Sub DesPanel_SizeChanged(sender As Object, e As EventArgs) Handles DesPanel.SizeChanged
        GetDays()
        GetEndDates()
        ToolTip()
        SetDaysCount()
    End Sub

    Private Sub DevelopmentPanel_SizeChanged(sender As Object, e As EventArgs) Handles DevelopmentPanel.SizeChanged
        GetDays()
        GetEndDates()
        ToolTip()
        SetDaysCount()
    End Sub

    Private Sub TestingPanel_SizeChanged(sender As Object, e As EventArgs) Handles TestingPanel.SizeChanged
        GetDays()
        GetEndDates()
        ToolTip()
        SetDaysCount()
    End Sub

    Private Sub ProjectLayout_FormClosing_1(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'saves the dates in the table
        LayoutTable()
        MsgBox("The dates have been saved.")
        ManagerHomePage.Enabled = True
        ManagerHomePage.Show()
        ManagerHomePage.Refresh()
        ManagerHomePage.ManagerDataGrid.Refresh()
    End Sub

    Private Sub ReqSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles ReqSplitter.SplitterMoved
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        TestingPanel.Size = RightDevPanel.Size
    End Sub

    Private Sub RightDesSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles RightDesSplitter.SplitterMoved
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        TestingPanel.Size = RightDevPanel.Size
    End Sub

    Private Sub RDevSplitter_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles RDevSplitter.SplitterMoved
        TestingPanel.Size = RightDevPanel.Size
    End Sub

    Private Sub LayoutTable()
        'adds data to the layout table
        Dim UpdateCommand As String = "UPDATE Layout SET Requirement='" + reqana.ToString("MM-dd-yyyy") + "',Design='" + Design.ToString("MM-dd-yyyy") + "',Development='" + Development.ToString("MM-dd-yyyy") + "',Testing='" + Testing.ToString("MM-dd-yyyy") + "' Where PId ='" + ProjectId.Text + "'"

        'creating a sql command statement 
        Dim command As SqlCommand = LoginForm.sql.CreateCommand()
        command.CommandText = UpdateCommand

        'sqladapter to handle the sql commands 
        Dim sqlAdapter As New SqlDataAdapter With {
             .SelectCommand = command
        }

        'creates a table with the required data
        Dim data As New DataSet()
        sqlAdapter.Fill(data)
    End Sub

    Private Sub GetDays()
        ReqNo = Math.Round((ReqPanel.Size.Width / DeploymentPanel.Size.Width) * NoOfDays)
        DesNo = Math.Round((DesPanel.Size.Width / DeploymentPanel.Size.Width) * NoOfDays)
        DevNo = Math.Round((DevelopmentPanel.Size.Width / DeploymentPanel.Size.Width) * NoOfDays)
        TesNo = Math.Round((TestingPanel.Size.Width / DeploymentPanel.Size.Width) * NoOfDays)
        DepNo = Math.Round((DeployPanel.Size.Width / DeploymentPanel.Size.Width) * NoOfDays)
    End Sub

    Private Sub GetEndDates()
        If ManagerHomePage.pid <> "new" Then
            reqana = Convert.ToDateTime(ManagerHomePage.startdate.ToString().Substring(0, 10)).AddDays(ReqNo)
        Else
            reqana = Today.AddDays(ReqNo)
        End If
        Design = reqana.AddDays(DesNo)
        Development = Design.AddDays(DevNo)
        Testing = Development.AddDays(TesNo)
    End Sub

    Private Sub SetDays_Click(sender As Object, e As EventArgs) Handles SetDays.Click

        If reqNum.Value < 5 Or desNum.Value < 6 Or devNum.Value < 9 Then
            MsgBox("Days cannot be too low !")
            SetDaysCount()
        Else
            ReqPanel.Size = New Size((reqNum.Value / NoOfDays) * DeploymentPanel.Size.Width, 50)
            DesPanel.Size = New Size((desNum.Value / NoOfDays) * DeploymentPanel.Size.Width, 50)
            DevelopmentPanel.Size = New Size((devNum.Value / NoOfDays) * DeploymentPanel.Size.Width, 50)

            LeftDesPanel.Size = ReqPanel.Size
            LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
            TestingPanel.Size = RightDevPanel.Size
        End If

    End Sub

    Private Sub ToolTip()
        ReqTip.SetToolTip(Me.ReqBtn, reqana.ToString.Substring(0, 10) + " (" + ReqNo.ToString + " Days)")
        DesTip.SetToolTip(Me.DesignBtn, Design.ToString.Substring(0, 10) + " (" + DesNo.ToString + " Days)")
        DevTip.SetToolTip(Me.DevBtn, Development.ToString.Substring(0, 10) + " (" + DevNo.ToString + " Days)")
        TestTip.SetToolTip(Me.TestBtn, Testing.ToString.Substring(0, 10) + " (" + TesNo.ToString + " Days)")
        DepTip.SetToolTip(Me.DepBtn, dead.Text + " (" + DepNo.ToString + " Days)")
    End Sub

    Private Sub UndoBtn_Click(sender As Object, e As EventArgs) Handles UndoBtn.Click
        SavedRatio()
    End Sub

    Private Sub Ratio()
        'starting stage sizes based on percentages 
        ReqPanel.Size = New Size(0.15 * DeploymentPanel.Size.Width, 50)
        DesPanel.Size = New Size(0.2 * DeploymentPanel.Size.Width, 50)
        DevelopmentPanel.Size = New Size(0.3 * DeploymentPanel.Size.Width, 50)
        TestingPanel.Size = New Size(0.25 * DeploymentPanel.Size.Width, 50)

        'starting stage positions based on sizes 
        LeftDesPanel.Size = ReqPanel.Size
        LeftDevPanel.Size = LeftDesPanel.Size + DesPanel.Size
        TestingPanel.Size = RightDevPanel.Size
    End Sub

    Private Sub SavedRatio()
        Dim Com As String = "SELECT StartDate, Requirement, Design, Development, Testing, Deadline FROM Layout WHERE PId = '" & ProjectId.Text & "'"

        Dim command As SqlCommand = LoginForm.sql.CreateCommand()
        command.CommandText = Com

        Dim sqlAdapter As New SqlDataAdapter With {
        .SelectCommand = command
    }

        Dim data As New DataSet()

        Try
            sqlAdapter.Fill(data)

            If data.Tables(0).Rows.Count > 0 Then
                Dim reqDays As Integer = DateDiff("d", Convert.ToDateTime(data.Tables(0).Rows(0)(0).ToString), Convert.ToDateTime(data.Tables(0).Rows(0)(1).ToString))
                Dim desDays As Integer = DateDiff("d", Convert.ToDateTime(data.Tables(0).Rows(0)(1).ToString), Convert.ToDateTime(data.Tables(0).Rows(0)(2).ToString))
                Dim devDays As Integer = DateDiff("d", Convert.ToDateTime(data.Tables(0).Rows(0)(2).ToString), Convert.ToDateTime(data.Tables(0).Rows(0)(3).ToString))
                Dim testDays As Integer = DateDiff("d", Convert.ToDateTime(data.Tables(0).Rows(0)(3).ToString), Convert.ToDateTime(data.Tables(0).Rows(0)(4).ToString))
                Dim depDays As Integer = DateDiff("d", Convert.ToDateTime(data.Tables(0).Rows(0)(4).ToString), Convert.ToDateTime(data.Tables(0).Rows(0)(5).ToString))

                ' Now you can use reqDays, desDays, devDays, testDays, and depDays as needed
            Else
                MessageBox.Show("No data found for the project ID: " & ProjectId.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving project layout: " & ex.Message)
        End Try
    End Sub

    Private Sub ReqBtn_Click(sender As Object, e As EventArgs) Handles ReqBtn.Click
        task = "Requirement Analysis"
        TaskContributor.Show()
        Me.Hide()
    End Sub

    Private Sub DesignBtn_Click(sender As Object, e As EventArgs) Handles DesignBtn.Click
        task = "Design"
        TaskContributor.Show()
        Me.Hide()
    End Sub

    Private Sub DevBtn_Click(sender As Object, e As EventArgs) Handles DevBtn.Click
        task = "Development"
        TaskContributor.Show()
        Me.Hide()
    End Sub

    Private Sub TestBtn_Click(sender As Object, e As EventArgs) Handles TestBtn.Click
        task = "Testing"
        TaskContributor.Show()
        Me.Hide()
    End Sub

    Private Sub SetDaysCount()
        reqNum.Value = ReqNo
        desNum.Value = DesNo
        devNum.Value = DevNo
    End Sub

    Private Sub Layout_Enter(sender As Object, e As EventArgs) Handles Layout.Enter

    End Sub
End Class