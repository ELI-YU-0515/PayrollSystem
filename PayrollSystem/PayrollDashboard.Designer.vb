<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayrollDashboard))
        Panel1 = New Panel()
        emp_pos = New ComboBox()
        update_data = New Button()
        clear_data = New Button()
        insert_data = New Button()
        edit_data = New Button()
        delete_data = New Button()
        insert_image_btn = New Button()
        CheckBoxFemale = New CheckBox()
        CheckBoxMale = New CheckBox()
        emp_img = New PictureBox()
        emp_mname = New TextBox()
        emp_age = New TextBox()
        ref_id = New TextBox()
        emp_mobile = New TextBox()
        emp_address = New TextBox()
        emp_lname = New TextBox()
        Label10 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        emp_fname = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabControl1 = New TabControl()
        emp_details = New TabPage()
        emp_details_data = New DataGridView()
        emp_salary = New TabPage()
        emp_salary_data = New DataGridView()
        emp_print = New TabPage()
        print_salary_text = New TextBox()
        emp_detailsbtn = New Button()
        salary_detailsbtn = New Button()
        Button3 = New Button()
        Label20 = New Label()
        Label19 = New Label()
        Label12 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label18 = New Label()
        emp_full = New TextBox()
        emp_sss = New TextBox()
        emp_phic = New TextBox()
        emp_pagibig = New TextBox()
        emp_Hworked = New TextBox()
        emp_Hrate = New TextBox()
        Label13 = New Label()
        Label11 = New Label()
        ref_id2 = New TextBox()
        insert_salary = New Button()
        Panel2 = New Panel()
        log_date = New DateTimePicker()
        print_salary_btn = New Button()
        delete_salary = New Button()
        retrieve_salary = New Button()
        emp_pos2 = New TextBox()
        emp_net = New TextBox()
        emp_deduc = New TextBox()
        emp_gross = New TextBox()
        Label25 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label17 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Panel3 = New Panel()
        Role_Label = New Label()
        Label24 = New Label()
        Label23 = New Label()
        PictureBox1 = New PictureBox()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Panel1.SuspendLayout()
        CType(emp_img, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        emp_details.SuspendLayout()
        CType(emp_details_data, ComponentModel.ISupportInitialize).BeginInit()
        emp_salary.SuspendLayout()
        CType(emp_salary_data, ComponentModel.ISupportInitialize).BeginInit()
        emp_print.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.Pattern
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Controls.Add(emp_pos)
        Panel1.Controls.Add(update_data)
        Panel1.Controls.Add(clear_data)
        Panel1.Controls.Add(insert_data)
        Panel1.Controls.Add(edit_data)
        Panel1.Controls.Add(delete_data)
        Panel1.Controls.Add(insert_image_btn)
        Panel1.Controls.Add(CheckBoxFemale)
        Panel1.Controls.Add(CheckBoxMale)
        Panel1.Controls.Add(emp_img)
        Panel1.Controls.Add(emp_mname)
        Panel1.Controls.Add(emp_age)
        Panel1.Controls.Add(ref_id)
        Panel1.Controls.Add(emp_mobile)
        Panel1.Controls.Add(emp_address)
        Panel1.Controls.Add(emp_lname)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(emp_fname)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(280, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(720, 764)
        Panel1.TabIndex = 1
        ' 
        ' emp_pos
        ' 
        emp_pos.FormattingEnabled = True
        emp_pos.Items.AddRange(New Object() {"EMPLOYEE", "TEAM MANAGER", "PROJECT MANAGER", "HR", "CEO"})
        emp_pos.Location = New Point(174, 263)
        emp_pos.Name = "emp_pos"
        emp_pos.Size = New Size(138, 23)
        emp_pos.TabIndex = 8
        ' 
        ' update_data
        ' 
        update_data.BackColor = Color.LimeGreen
        update_data.FlatStyle = FlatStyle.System
        update_data.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        update_data.Location = New Point(294, 348)
        update_data.Name = "update_data"
        update_data.Size = New Size(31, 33)
        update_data.TabIndex = 7
        update_data.Text = "UP"
        update_data.UseVisualStyleBackColor = False
        ' 
        ' clear_data
        ' 
        clear_data.BackColor = Color.LimeGreen
        clear_data.FlatStyle = FlatStyle.System
        clear_data.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clear_data.Location = New Point(329, 347)
        clear_data.Name = "clear_data"
        clear_data.Size = New Size(31, 33)
        clear_data.TabIndex = 7
        clear_data.Text = "--"
        clear_data.UseVisualStyleBackColor = False
        ' 
        ' insert_data
        ' 
        insert_data.BackColor = Color.LimeGreen
        insert_data.FlatStyle = FlatStyle.System
        insert_data.Font = New Font("Verdana", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        insert_data.Location = New Point(366, 348)
        insert_data.Name = "insert_data"
        insert_data.Size = New Size(112, 33)
        insert_data.TabIndex = 7
        insert_data.Text = "INSERT DATA"
        insert_data.UseVisualStyleBackColor = False
        ' 
        ' edit_data
        ' 
        edit_data.BackColor = Color.Yellow
        edit_data.FlatStyle = FlatStyle.System
        edit_data.Font = New Font("Verdana", 6.75F)
        edit_data.Location = New Point(482, 348)
        edit_data.Name = "edit_data"
        edit_data.Size = New Size(100, 33)
        edit_data.TabIndex = 7
        edit_data.Text = "EDIT DATA"
        edit_data.UseVisualStyleBackColor = False
        ' 
        ' delete_data
        ' 
        delete_data.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        delete_data.FlatStyle = FlatStyle.System
        delete_data.Font = New Font("Verdana", 6.75F)
        delete_data.ForeColor = Color.White
        delete_data.Location = New Point(585, 347)
        delete_data.Name = "delete_data"
        delete_data.Size = New Size(108, 33)
        delete_data.TabIndex = 7
        delete_data.Text = "DELETE DATA"
        delete_data.UseVisualStyleBackColor = False
        ' 
        ' insert_image_btn
        ' 
        insert_image_btn.FlatStyle = FlatStyle.System
        insert_image_btn.Location = New Point(563, 155)
        insert_image_btn.Name = "insert_image_btn"
        insert_image_btn.Size = New Size(27, 23)
        insert_image_btn.TabIndex = 6
        insert_image_btn.Text = "+"
        insert_image_btn.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxFemale
        ' 
        CheckBoxFemale.AutoSize = True
        CheckBoxFemale.Font = New Font("Verdana", 9F)
        CheckBoxFemale.Location = New Point(451, 197)
        CheckBoxFemale.Name = "CheckBoxFemale"
        CheckBoxFemale.Size = New Size(74, 18)
        CheckBoxFemale.TabIndex = 5
        CheckBoxFemale.Text = "FEMALE"
        CheckBoxFemale.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMale
        ' 
        CheckBoxMale.AutoSize = True
        CheckBoxMale.Font = New Font("Verdana", 9F)
        CheckBoxMale.Location = New Point(451, 173)
        CheckBoxMale.Name = "CheckBoxMale"
        CheckBoxMale.Size = New Size(59, 18)
        CheckBoxMale.TabIndex = 5
        CheckBoxMale.Text = "MALE"
        CheckBoxMale.UseVisualStyleBackColor = True
        ' 
        ' emp_img
        ' 
        emp_img.BackColor = SystemColors.ControlLight
        emp_img.Location = New Point(596, 64)
        emp_img.Name = "emp_img"
        emp_img.Size = New Size(88, 88)
        emp_img.TabIndex = 4
        emp_img.TabStop = False
        ' 
        ' emp_mname
        ' 
        emp_mname.Location = New Point(174, 95)
        emp_mname.Name = "emp_mname"
        emp_mname.Size = New Size(352, 23)
        emp_mname.TabIndex = 2
        ' 
        ' emp_age
        ' 
        emp_age.Location = New Point(393, 171)
        emp_age.Name = "emp_age"
        emp_age.Size = New Size(42, 23)
        emp_age.TabIndex = 3
        ' 
        ' ref_id
        ' 
        ref_id.Location = New Point(174, 296)
        ref_id.Name = "ref_id"
        ref_id.Size = New Size(138, 23)
        ref_id.TabIndex = 3
        ' 
        ' emp_mobile
        ' 
        emp_mobile.Location = New Point(174, 171)
        emp_mobile.Name = "emp_mobile"
        emp_mobile.Size = New Size(151, 23)
        emp_mobile.TabIndex = 3
        ' 
        ' emp_address
        ' 
        emp_address.Location = New Point(175, 229)
        emp_address.Name = "emp_address"
        emp_address.Size = New Size(352, 23)
        emp_address.TabIndex = 3
        ' 
        ' emp_lname
        ' 
        emp_lname.Location = New Point(174, 128)
        emp_lname.Name = "emp_lname"
        emp_lname.Size = New Size(352, 23)
        emp_lname.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Verdana", 9F)
        Label10.Location = New Point(32, 260)
        Label10.Name = "Label10"
        Label10.Size = New Size(94, 28)
        Label10.TabIndex = 1
        Label10.Text = "EMPLOYEE" & vbCrLf & "POSITION     :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 9F)
        Label7.Location = New Point(337, 175)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 14)
        Label7.TabIndex = 1
        Label7.Text = "AGE   :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Verdana", 9F)
        Label9.Location = New Point(32, 298)
        Label9.Name = "Label9"
        Label9.Size = New Size(116, 14)
        Label9.TabIndex = 1
        Label9.Text = "EMPLOYEE ID     :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 7.5F)
        Label8.Location = New Point(600, 161)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 12)
        Label8.TabIndex = 1
        Label8.Text = "INSERT IMAGE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Verdana", 9F)
        Label6.Location = New Point(32, 175)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 14)
        Label6.TabIndex = 1
        Label6.Text = "CONTACT NO.      :"
        ' 
        ' emp_fname
        ' 
        emp_fname.Location = New Point(174, 64)
        emp_fname.Name = "emp_fname"
        emp_fname.Size = New Size(352, 23)
        emp_fname.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Verdana", 9F)
        Label5.Location = New Point(32, 233)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 14)
        Label5.TabIndex = 1
        Label5.Text = "ADDRESS             :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Verdana", 9F)
        Label4.Location = New Point(32, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 14)
        Label4.TabIndex = 1
        Label4.Text = "LAST NAME          :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Verdana", 9F)
        Label3.Location = New Point(32, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 14)
        Label3.TabIndex = 1
        Label3.Text = "MIDDLE NAME      :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Verdana", 9F)
        Label2.Location = New Point(32, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 14)
        Label2.TabIndex = 1
        Label2.Text = "FIRST NAME         :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        Label1.Location = New Point(303, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 23)
        Label1.TabIndex = 1
        Label1.Text = "EMPLOYEE DETAILS"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(emp_details)
        TabControl1.Controls.Add(emp_salary)
        TabControl1.Controls.Add(emp_print)
        TabControl1.Font = New Font("Verdana", 9F)
        TabControl1.Location = New Point(312, 387)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(665, 356)
        TabControl1.TabIndex = 0
        ' 
        ' emp_details
        ' 
        emp_details.Controls.Add(emp_details_data)
        emp_details.Font = New Font("Verdana", 9F)
        emp_details.Location = New Point(4, 23)
        emp_details.Name = "emp_details"
        emp_details.Padding = New Padding(3)
        emp_details.Size = New Size(657, 329)
        emp_details.TabIndex = 0
        emp_details.Text = "EMPLOYEE DETAILS"
        emp_details.UseVisualStyleBackColor = True
        ' 
        ' emp_details_data
        ' 
        emp_details_data.BackgroundColor = SystemColors.AppWorkspace
        emp_details_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        emp_details_data.GridColor = SystemColors.ActiveBorder
        emp_details_data.Location = New Point(0, 0)
        emp_details_data.Name = "emp_details_data"
        emp_details_data.ReadOnly = True
        emp_details_data.Size = New Size(657, 327)
        emp_details_data.TabIndex = 0
        ' 
        ' emp_salary
        ' 
        emp_salary.Controls.Add(emp_salary_data)
        emp_salary.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emp_salary.Location = New Point(4, 23)
        emp_salary.Name = "emp_salary"
        emp_salary.Padding = New Padding(3)
        emp_salary.Size = New Size(657, 329)
        emp_salary.TabIndex = 1
        emp_salary.Text = "EMPLOYEE SALARY"
        emp_salary.UseVisualStyleBackColor = True
        ' 
        ' emp_salary_data
        ' 
        emp_salary_data.BackgroundColor = SystemColors.AppWorkspace
        emp_salary_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        emp_salary_data.Location = New Point(0, 0)
        emp_salary_data.Name = "emp_salary_data"
        emp_salary_data.ReadOnly = True
        emp_salary_data.Size = New Size(657, 327)
        emp_salary_data.TabIndex = 0
        ' 
        ' emp_print
        ' 
        emp_print.Controls.Add(print_salary_text)
        emp_print.ForeColor = SystemColors.ControlText
        emp_print.Location = New Point(4, 23)
        emp_print.Name = "emp_print"
        emp_print.Size = New Size(657, 329)
        emp_print.TabIndex = 2
        emp_print.Text = "PRINT PAYROLL"
        emp_print.UseVisualStyleBackColor = True
        ' 
        ' print_salary_text
        ' 
        print_salary_text.Location = New Point(3, 3)
        print_salary_text.Multiline = True
        print_salary_text.Name = "print_salary_text"
        print_salary_text.ScrollBars = ScrollBars.Vertical
        print_salary_text.Size = New Size(651, 323)
        print_salary_text.TabIndex = 0
        ' 
        ' emp_detailsbtn
        ' 
        emp_detailsbtn.AutoSize = True
        emp_detailsbtn.BackColor = Color.Transparent
        emp_detailsbtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        emp_detailsbtn.FlatStyle = FlatStyle.System
        emp_detailsbtn.Font = New Font("Verdana", 10F)
        emp_detailsbtn.Location = New Point(0, 385)
        emp_detailsbtn.Name = "emp_detailsbtn"
        emp_detailsbtn.Size = New Size(277, 43)
        emp_detailsbtn.TabIndex = 2
        emp_detailsbtn.Text = "EMPLOYEE DETAILS           "
        emp_detailsbtn.UseMnemonic = False
        emp_detailsbtn.UseVisualStyleBackColor = False
        ' 
        ' salary_detailsbtn
        ' 
        salary_detailsbtn.BackColor = Color.Transparent
        salary_detailsbtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        salary_detailsbtn.FlatStyle = FlatStyle.System
        salary_detailsbtn.Font = New Font("Verdana", 10F)
        salary_detailsbtn.Location = New Point(0, 428)
        salary_detailsbtn.Name = "salary_detailsbtn"
        salary_detailsbtn.Size = New Size(277, 42)
        salary_detailsbtn.TabIndex = 2
        salary_detailsbtn.Text = "SALARY DETAILS               "
        salary_detailsbtn.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(190, 710)
        Button3.Name = "Button3"
        Button3.Size = New Size(78, 42)
        Button3.TabIndex = 2
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        Label20.Location = New Point(303, 20)
        Label20.Name = "Label20"
        Label20.Size = New Size(195, 23)
        Label20.TabIndex = 1
        Label20.Text = "SALARY DETAILS"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Verdana", 9F)
        Label19.Location = New Point(34, 68)
        Label19.Name = "Label19"
        Label19.Size = New Size(129, 14)
        Label19.TabIndex = 1
        Label19.Text = "EMPLOYEE NAME   :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Verdana", 9F)
        Label12.Location = New Point(430, 67)
        Label12.Name = "Label12"
        Label12.Size = New Size(73, 28)
        Label12.TabIndex = 1
        Label12.Text = "EMPLOYEE" & vbCrLf & "SSS:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Verdana", 9F)
        Label14.Location = New Point(430, 116)
        Label14.Name = "Label14"
        Label14.Size = New Size(43, 14)
        Label14.TabIndex = 1
        Label14.Text = "PHIC:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Verdana", 9F)
        Label15.Location = New Point(430, 159)
        Label15.Name = "Label15"
        Label15.Size = New Size(69, 14)
        Label15.TabIndex = 1
        Label15.Text = "PAG-IBIG:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Verdana", 9F)
        Label16.Location = New Point(34, 202)
        Label16.Name = "Label16"
        Label16.Size = New Size(68, 28)
        Label16.TabIndex = 1
        Label16.Text = "HOURS" & vbCrLf & "WORKED:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Verdana", 9F)
        Label18.Location = New Point(34, 249)
        Label18.Name = "Label18"
        Label18.Size = New Size(56, 28)
        Label18.TabIndex = 1
        Label18.Text = "HOURLY" & vbCrLf & "RATE:"
        ' 
        ' emp_full
        ' 
        emp_full.BackColor = SystemColors.ControlLight
        emp_full.Font = New Font("Segoe UI", 15F)
        emp_full.Location = New Point(172, 64)
        emp_full.Name = "emp_full"
        emp_full.ReadOnly = True
        emp_full.Size = New Size(229, 34)
        emp_full.TabIndex = 2
        ' 
        ' emp_sss
        ' 
        emp_sss.BackColor = SystemColors.ControlLight
        emp_sss.Font = New Font("Segoe UI", 15F)
        emp_sss.Location = New Point(531, 64)
        emp_sss.Name = "emp_sss"
        emp_sss.ReadOnly = True
        emp_sss.Size = New Size(161, 34)
        emp_sss.TabIndex = 2
        ' 
        ' emp_phic
        ' 
        emp_phic.BackColor = SystemColors.ControlLight
        emp_phic.Font = New Font("Segoe UI", 15F)
        emp_phic.Location = New Point(530, 106)
        emp_phic.Name = "emp_phic"
        emp_phic.ReadOnly = True
        emp_phic.Size = New Size(161, 34)
        emp_phic.TabIndex = 2
        ' 
        ' emp_pagibig
        ' 
        emp_pagibig.BackColor = SystemColors.ControlLight
        emp_pagibig.Font = New Font("Segoe UI", 15F)
        emp_pagibig.Location = New Point(530, 148)
        emp_pagibig.Name = "emp_pagibig"
        emp_pagibig.ReadOnly = True
        emp_pagibig.Size = New Size(161, 34)
        emp_pagibig.TabIndex = 2
        ' 
        ' emp_Hworked
        ' 
        emp_Hworked.Font = New Font("Segoe UI", 15F)
        emp_Hworked.Location = New Point(173, 201)
        emp_Hworked.Name = "emp_Hworked"
        emp_Hworked.Size = New Size(137, 34)
        emp_Hworked.TabIndex = 2
        ' 
        ' emp_Hrate
        ' 
        emp_Hrate.Font = New Font("Segoe UI", 15F)
        emp_Hrate.Location = New Point(173, 246)
        emp_Hrate.Name = "emp_Hrate"
        emp_Hrate.Size = New Size(137, 34)
        emp_Hrate.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Verdana", 9F)
        Label13.Location = New Point(34, 165)
        Label13.Name = "Label13"
        Label13.Size = New Size(116, 14)
        Label13.TabIndex = 1
        Label13.Text = "EMPLOYEE ID     :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Verdana", 9F)
        Label11.Location = New Point(34, 115)
        Label11.Name = "Label11"
        Label11.Size = New Size(118, 28)
        Label11.TabIndex = 1
        Label11.Text = "EMPLOYEE" & vbCrLf & "POSITION           :"
        ' 
        ' ref_id2
        ' 
        ref_id2.BackColor = SystemColors.ControlLight
        ref_id2.Font = New Font("Segoe UI", 15F)
        ref_id2.Location = New Point(172, 156)
        ref_id2.Name = "ref_id2"
        ref_id2.ReadOnly = True
        ref_id2.Size = New Size(138, 34)
        ref_id2.TabIndex = 3
        ' 
        ' insert_salary
        ' 
        insert_salary.Font = New Font("Verdana", 9F)
        insert_salary.Location = New Point(32, 347)
        insert_salary.Name = "insert_salary"
        insert_salary.Size = New Size(87, 28)
        insert_salary.TabIndex = 7
        insert_salary.Text = "INSERT"
        insert_salary.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.Pattern
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Controls.Add(log_date)
        Panel2.Controls.Add(print_salary_btn)
        Panel2.Controls.Add(delete_salary)
        Panel2.Controls.Add(retrieve_salary)
        Panel2.Controls.Add(insert_salary)
        Panel2.Controls.Add(emp_pos2)
        Panel2.Controls.Add(ref_id2)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(emp_Hrate)
        Panel2.Controls.Add(emp_Hworked)
        Panel2.Controls.Add(emp_net)
        Panel2.Controls.Add(emp_deduc)
        Panel2.Controls.Add(emp_gross)
        Panel2.Controls.Add(emp_pagibig)
        Panel2.Controls.Add(emp_phic)
        Panel2.Controls.Add(emp_sss)
        Panel2.Controls.Add(emp_full)
        Panel2.Controls.Add(Label25)
        Panel2.Controls.Add(Label18)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(Label22)
        Panel2.Controls.Add(Label21)
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label19)
        Panel2.Controls.Add(Label20)
        Panel2.Location = New Point(280, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(720, 764)
        Panel2.TabIndex = 1
        ' 
        ' log_date
        ' 
        log_date.Format = DateTimePickerFormat.Short
        log_date.Location = New Point(172, 287)
        log_date.Name = "log_date"
        log_date.Size = New Size(138, 23)
        log_date.TabIndex = 8
        ' 
        ' print_salary_btn
        ' 
        print_salary_btn.Font = New Font("Verdana", 9F)
        print_salary_btn.Location = New Point(311, 347)
        print_salary_btn.Name = "print_salary_btn"
        print_salary_btn.Size = New Size(87, 28)
        print_salary_btn.TabIndex = 7
        print_salary_btn.Text = "PRINT"
        print_salary_btn.UseVisualStyleBackColor = True
        ' 
        ' delete_salary
        ' 
        delete_salary.Font = New Font("Verdana", 9F)
        delete_salary.Location = New Point(218, 347)
        delete_salary.Name = "delete_salary"
        delete_salary.Size = New Size(87, 28)
        delete_salary.TabIndex = 7
        delete_salary.Text = "DELETE"
        delete_salary.UseVisualStyleBackColor = True
        ' 
        ' retrieve_salary
        ' 
        retrieve_salary.Font = New Font("Verdana", 9F)
        retrieve_salary.Location = New Point(125, 347)
        retrieve_salary.Name = "retrieve_salary"
        retrieve_salary.Size = New Size(87, 28)
        retrieve_salary.TabIndex = 7
        retrieve_salary.Text = "RETRIEVE"
        retrieve_salary.UseVisualStyleBackColor = True
        ' 
        ' emp_pos2
        ' 
        emp_pos2.BackColor = SystemColors.ControlLight
        emp_pos2.Font = New Font("Segoe UI", 15F)
        emp_pos2.Location = New Point(172, 111)
        emp_pos2.Name = "emp_pos2"
        emp_pos2.ReadOnly = True
        emp_pos2.Size = New Size(229, 34)
        emp_pos2.TabIndex = 3
        ' 
        ' emp_net
        ' 
        emp_net.BackColor = SystemColors.ControlLight
        emp_net.Font = New Font("Segoe UI", 15F)
        emp_net.Location = New Point(529, 278)
        emp_net.Name = "emp_net"
        emp_net.ReadOnly = True
        emp_net.Size = New Size(161, 34)
        emp_net.TabIndex = 2
        ' 
        ' emp_deduc
        ' 
        emp_deduc.BackColor = SystemColors.ControlLight
        emp_deduc.Font = New Font("Segoe UI", 15F)
        emp_deduc.Location = New Point(530, 237)
        emp_deduc.Name = "emp_deduc"
        emp_deduc.ReadOnly = True
        emp_deduc.Size = New Size(161, 34)
        emp_deduc.TabIndex = 2
        ' 
        ' emp_gross
        ' 
        emp_gross.BackColor = SystemColors.ControlLight
        emp_gross.Font = New Font("Segoe UI", 15F)
        emp_gross.Location = New Point(529, 196)
        emp_gross.Name = "emp_gross"
        emp_gross.ReadOnly = True
        emp_gross.Size = New Size(161, 34)
        emp_gross.TabIndex = 2
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.BackColor = Color.Transparent
        Label25.Font = New Font("Verdana", 9F)
        Label25.Location = New Point(34, 293)
        Label25.Name = "Label25"
        Label25.Size = New Size(66, 14)
        Label25.TabIndex = 1
        Label25.Text = "PAYDATE:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.BackColor = SystemColors.ButtonFace
        Label22.Font = New Font("Verdana", 9F)
        Label22.Location = New Point(429, 289)
        Label22.Name = "Label22"
        Label22.Size = New Size(62, 14)
        Label22.TabIndex = 1
        Label22.Text = "NET PAY:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = SystemColors.ButtonFace
        Label21.Font = New Font("Verdana", 9F)
        Label21.Location = New Point(429, 240)
        Label21.Name = "Label21"
        Label21.Size = New Size(95, 28)
        Label21.TabIndex = 1
        Label21.Text = "TOTAL" & vbCrLf & "DEDCUTIONS:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = SystemColors.ButtonFace
        Label17.Font = New Font("Verdana", 9F)
        Label17.Location = New Point(429, 199)
        Label17.Name = "Label17"
        Label17.Size = New Size(63, 28)
        Label17.TabIndex = 1
        Label17.Text = "GROSS" & vbCrLf & "INCOME:"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(salary_detailsbtn)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(emp_detailsbtn)
        Panel3.Controls.Add(Role_Label)
        Panel3.Controls.Add(Label24)
        Panel3.Controls.Add(Label23)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(277, 764)
        Panel3.TabIndex = 3
        ' 
        ' Role_Label
        ' 
        Role_Label.AutoSize = True
        Role_Label.BackColor = Color.Transparent
        Role_Label.Font = New Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Role_Label.Location = New Point(107, 204)
        Role_Label.Name = "Role_Label"
        Role_Label.Size = New Size(86, 25)
        Role_Label.TabIndex = 4
        Role_Label.Text = "ROLES"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Verdana", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(67, 231)
        Label24.Name = "Label24"
        Label24.Size = New Size(138, 40)
        Label24.TabIndex = 4
        Label24.Text = "Welcome to " & vbCrLf & "PayrollSystem!"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(67, 204)
        Label23.Name = "Label23"
        Label23.Size = New Size(48, 25)
        Label23.TabIndex = 4
        Label23.Text = "HI!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(14, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(10)
        PictureBox1.Size = New Size(232, 190)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PayrollDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1004, 761)
        Controls.Add(TabControl1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Name = "PayrollDashboard"
        Padding = New Padding(20)
        StartPosition = FormStartPosition.CenterScreen
        Text = "PayrollDashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(emp_img, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        emp_details.ResumeLayout(False)
        CType(emp_details_data, ComponentModel.ISupportInitialize).EndInit()
        emp_salary.ResumeLayout(False)
        CType(emp_salary_data, ComponentModel.ISupportInitialize).EndInit()
        emp_print.ResumeLayout(False)
        emp_print.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents emp_detailsbtn As Button
    Friend WithEvents salary_detailsbtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents emp_details As TabPage
    Friend WithEvents emp_salary As TabPage
    Friend WithEvents emp_salary_data As DataGridView
    Friend WithEvents emp_details_data As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents emp_lname As TextBox
    Friend WithEvents emp_fname As TextBox
    Friend WithEvents emp_mname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents emp_img As PictureBox
    Friend WithEvents emp_address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents emp_age As TextBox
    Friend WithEvents emp_mobile As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBoxFemale As CheckBox
    Friend WithEvents CheckBoxMale As CheckBox
    Friend WithEvents insert_image_btn As Button
    Friend WithEvents delete_data As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ref_id As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents emp_pos As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents emp_full As TextBox
    Friend WithEvents emp_sss As TextBox
    Friend WithEvents emp_phic As TextBox
    Friend WithEvents emp_pagibig As TextBox
    Friend WithEvents emp_Hworked As TextBox
    Friend WithEvents emp_Hrate As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ref_id2 As TextBox
    Friend WithEvents insert_salary As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents emp_net As TextBox
    Friend WithEvents emp_deduc As TextBox
    Friend WithEvents emp_gross As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents retrieve_salary As Button
    Friend WithEvents emp_pos2 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Role_Label As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents insert_data As Button
    Friend WithEvents edit_data As Button
    Friend WithEvents clear_data As Button
    Friend WithEvents log_date As DateTimePicker
    Friend WithEvents update_data As Button
    Friend WithEvents emp_print As TabPage
    Friend WithEvents print_salary_text As TextBox
    Friend WithEvents print_salary_btn As Button
    Friend WithEvents delete_salary As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
