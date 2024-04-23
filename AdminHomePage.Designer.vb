<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHomePage))
        AdminName = New Label()
        AdminId = New Label()
        LogoutAdmin = New Button()
        Label4 = New Label()
        Label3 = New Label()
        AdmingprBox = New GroupBox()
        EmpBox = New GroupBox()
        AdminDataGrid = New DataGridView()
        TabControl = New TabControl()
        TabPage1 = New TabPage()
        AddRow = New Button()
        Add_Password = New TextBox()
        Add_Designtion = New ComboBox()
        Add_EmpName = New TextBox()
        Add_ID = New TextBox()
        TabPage2 = New TabPage()
        GetBtn = New Button()
        UpdateRow = New Button()
        Upd_Password = New TextBox()
        Upd_Designation = New ComboBox()
        Upd_Name = New TextBox()
        Upd_ID = New TextBox()
        TabPage3 = New TabPage()
        DeleteRow = New Button()
        Del_ID = New TextBox()
        AdmingprBox.SuspendLayout()
        EmpBox.SuspendLayout()
        CType(AdminDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        TabControl.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' AdminName
        ' 
        AdminName.AutoSize = True
        AdminName.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        AdminName.Location = New Point(77, 51)
        AdminName.Name = "AdminName"
        AdminName.Size = New Size(126, 25)
        AdminName.TabIndex = 18
        AdminName.Text = "Admin Name"
        ' 
        ' AdminId
        ' 
        AdminId.AutoSize = True
        AdminId.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        AdminId.Location = New Point(77, 19)
        AdminId.Name = "AdminId"
        AdminId.Size = New Size(91, 25)
        AdminId.TabIndex = 17
        AdminId.Text = "Admin Id"
        ' 
        ' LogoutAdmin
        ' 
        LogoutAdmin.BackColor = Color.Silver
        LogoutAdmin.FlatAppearance.BorderSize = 0
        LogoutAdmin.FlatStyle = FlatStyle.Flat
        LogoutAdmin.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        LogoutAdmin.Image = My.Resources.Resources.Log_out1
        LogoutAdmin.ImageAlign = ContentAlignment.MiddleRight
        LogoutAdmin.Location = New Point(688, 12)
        LogoutAdmin.Name = "LogoutAdmin"
        LogoutAdmin.Size = New Size(100, 44)
        LogoutAdmin.TabIndex = 13
        LogoutAdmin.Text = "Logout"
        LogoutAdmin.TextAlign = ContentAlignment.MiddleLeft
        LogoutAdmin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(6, 55)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 21)
        Label4.TabIndex = 3
        Label4.Text = "Name  :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(7, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 21)
        Label3.TabIndex = 2
        Label3.Text = "UserID :"
        ' 
        ' AdmingprBox
        ' 
        AdmingprBox.Controls.Add(Label3)
        AdmingprBox.Controls.Add(Label4)
        AdmingprBox.Controls.Add(AdminName)
        AdmingprBox.Controls.Add(AdminId)
        AdmingprBox.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        AdmingprBox.Location = New Point(12, 12)
        AdmingprBox.Name = "AdmingprBox"
        AdmingprBox.Size = New Size(220, 89)
        AdmingprBox.TabIndex = 22
        AdmingprBox.TabStop = False
        AdmingprBox.Text = "Admin"
        ' 
        ' EmpBox
        ' 
        EmpBox.Controls.Add(AdminDataGrid)
        EmpBox.Controls.Add(TabControl)
        EmpBox.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point)
        EmpBox.Location = New Point(12, 107)
        EmpBox.Name = "EmpBox"
        EmpBox.Size = New Size(776, 382)
        EmpBox.TabIndex = 23
        EmpBox.TabStop = False
        EmpBox.Text = "Employees"
        ' 
        ' AdminDataGrid
        ' 
        AdminDataGrid.AllowUserToAddRows = False
        AdminDataGrid.AllowUserToDeleteRows = False
        AdminDataGrid.AllowUserToResizeColumns = False
        AdminDataGrid.AllowUserToResizeRows = False
        AdminDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        AdminDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        AdminDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        AdminDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdminDataGrid.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        AdminDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        AdminDataGrid.Location = New Point(7, 174)
        AdminDataGrid.Name = "AdminDataGrid"
        AdminDataGrid.ReadOnly = True
        AdminDataGrid.RowHeadersWidth = 20
        AdminDataGrid.RowTemplate.Height = 25
        AdminDataGrid.ScrollBars = ScrollBars.Vertical
        AdminDataGrid.Size = New Size(755, 202)
        AdminDataGrid.TabIndex = 0
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabPage1)
        TabControl.Controls.Add(TabPage2)
        TabControl.Controls.Add(TabPage3)
        TabControl.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl.Location = New Point(7, 33)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(763, 135)
        TabControl.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(AddRow)
        TabPage1.Controls.Add(Add_Password)
        TabPage1.Controls.Add(Add_Designtion)
        TabPage1.Controls.Add(Add_EmpName)
        TabPage1.Controls.Add(Add_ID)
        TabPage1.Location = New Point(4, 26)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(755, 105)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Add"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' AddRow
        ' 
        AddRow.BackColor = Color.LightSeaGreen
        AddRow.FlatAppearance.BorderSize = 0
        AddRow.FlatStyle = FlatStyle.Flat
        AddRow.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        AddRow.Location = New Point(630, 35)
        AddRow.Name = "AddRow"
        AddRow.Size = New Size(100, 29)
        AddRow.TabIndex = 26
        AddRow.Text = "Add User"
        AddRow.UseVisualStyleBackColor = False
        ' 
        ' Add_Password
        ' 
        Add_Password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Add_Password.Location = New Point(461, 35)
        Add_Password.Name = "Add_Password"
        Add_Password.PlaceholderText = "Password"
        Add_Password.Size = New Size(100, 29)
        Add_Password.TabIndex = 25
        ' 
        ' Add_Designtion
        ' 
        Add_Designtion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Add_Designtion.FormattingEnabled = True
        Add_Designtion.Items.AddRange(New Object() {"E", "M"})
        Add_Designtion.Location = New Point(316, 35)
        Add_Designtion.Name = "Add_Designtion"
        Add_Designtion.Size = New Size(100, 29)
        Add_Designtion.TabIndex = 24
        ' 
        ' Add_EmpName
        ' 
        Add_EmpName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Add_EmpName.Location = New Point(168, 35)
        Add_EmpName.Name = "Add_EmpName"
        Add_EmpName.PlaceholderText = "Name"
        Add_EmpName.Size = New Size(100, 29)
        Add_EmpName.TabIndex = 1
        ' 
        ' Add_ID
        ' 
        Add_ID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Add_ID.Location = New Point(26, 35)
        Add_ID.Name = "Add_ID"
        Add_ID.PlaceholderText = "UserID"
        Add_ID.Size = New Size(100, 29)
        Add_ID.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(GetBtn)
        TabPage2.Controls.Add(UpdateRow)
        TabPage2.Controls.Add(Upd_Password)
        TabPage2.Controls.Add(Upd_Designation)
        TabPage2.Controls.Add(Upd_Name)
        TabPage2.Controls.Add(Upd_ID)
        TabPage2.Location = New Point(4, 26)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(755, 105)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Update"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' GetBtn
        ' 
        GetBtn.BackColor = Color.Silver
        GetBtn.FlatAppearance.BorderSize = 0
        GetBtn.FlatStyle = FlatStyle.Flat
        GetBtn.Location = New Point(132, 34)
        GetBtn.Name = "GetBtn"
        GetBtn.Size = New Size(63, 30)
        GetBtn.TabIndex = 38
        GetBtn.Text = "Get"
        GetBtn.UseVisualStyleBackColor = False
        ' 
        ' UpdateRow
        ' 
        UpdateRow.BackColor = Color.Goldenrod
        UpdateRow.FlatAppearance.BorderSize = 0
        UpdateRow.FlatStyle = FlatStyle.Flat
        UpdateRow.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        UpdateRow.ImageAlign = ContentAlignment.MiddleRight
        UpdateRow.Location = New Point(630, 35)
        UpdateRow.Name = "UpdateRow"
        UpdateRow.Size = New Size(100, 29)
        UpdateRow.TabIndex = 37
        UpdateRow.Text = "Update "
        UpdateRow.UseVisualStyleBackColor = False
        ' 
        ' Upd_Password
        ' 
        Upd_Password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Upd_Password.Location = New Point(497, 35)
        Upd_Password.Name = "Upd_Password"
        Upd_Password.PlaceholderText = "Password"
        Upd_Password.Size = New Size(100, 29)
        Upd_Password.TabIndex = 36
        ' 
        ' Upd_Designation
        ' 
        Upd_Designation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Upd_Designation.FormattingEnabled = True
        Upd_Designation.Items.AddRange(New Object() {"E", "M"})
        Upd_Designation.Location = New Point(368, 35)
        Upd_Designation.Name = "Upd_Designation"
        Upd_Designation.Size = New Size(100, 29)
        Upd_Designation.TabIndex = 35
        ' 
        ' Upd_Name
        ' 
        Upd_Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Upd_Name.Location = New Point(237, 35)
        Upd_Name.Name = "Upd_Name"
        Upd_Name.PlaceholderText = "Name"
        Upd_Name.Size = New Size(100, 29)
        Upd_Name.TabIndex = 34
        ' 
        ' Upd_ID
        ' 
        Upd_ID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Upd_ID.Location = New Point(26, 35)
        Upd_ID.Name = "Upd_ID"
        Upd_ID.PlaceholderText = "UserID"
        Upd_ID.Size = New Size(100, 29)
        Upd_ID.TabIndex = 33
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(DeleteRow)
        TabPage3.Controls.Add(Del_ID)
        TabPage3.Location = New Point(4, 26)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(755, 105)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Remove"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' DeleteRow
        ' 
        DeleteRow.BackColor = Color.Tomato
        DeleteRow.FlatAppearance.BorderSize = 0
        DeleteRow.FlatStyle = FlatStyle.Flat
        DeleteRow.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DeleteRow.Location = New Point(630, 35)
        DeleteRow.Name = "DeleteRow"
        DeleteRow.Size = New Size(100, 29)
        DeleteRow.TabIndex = 34
        DeleteRow.Text = "Remove"
        DeleteRow.UseVisualStyleBackColor = False
        ' 
        ' Del_ID
        ' 
        Del_ID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Del_ID.Location = New Point(26, 35)
        Del_ID.Name = "Del_ID"
        Del_ID.PlaceholderText = "UserID"
        Del_ID.Size = New Size(227, 29)
        Del_ID.TabIndex = 33
        ' 
        ' AdminHomePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 495)
        Controls.Add(EmpBox)
        Controls.Add(AdmingprBox)
        Controls.Add(LogoutAdmin)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "AdminHomePage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Home Page"
        AdmingprBox.ResumeLayout(False)
        AdmingprBox.PerformLayout()
        EmpBox.ResumeLayout(False)
        CType(AdminDataGrid, ComponentModel.ISupportInitialize).EndInit()
        TabControl.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents AdminName As Label
    Friend WithEvents AdminId As Label
    Friend WithEvents LogoutAdmin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AdmingprBox As GroupBox
    Friend WithEvents EmpBox As GroupBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents AdminDataGrid As DataGridView
    Friend WithEvents Add_EmpName As TextBox
    Friend WithEvents Add_ID As TextBox
    Friend WithEvents Add_Designtion As ComboBox
    Friend WithEvents Add_Password As TextBox
    Friend WithEvents AddRow As Button
    Friend WithEvents GetBtn As Button
    Friend WithEvents UpdateRow As Button
    Friend WithEvents Upd_Password As TextBox
    Friend WithEvents Upd_Designation As ComboBox
    Friend WithEvents Upd_Name As TextBox
    Friend WithEvents Upd_ID As TextBox
    Friend WithEvents DeleteRow As Button
    Friend WithEvents Del_ID As TextBox
End Class
