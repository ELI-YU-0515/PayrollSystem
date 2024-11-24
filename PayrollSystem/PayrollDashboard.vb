Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing

Public Class PayrollDashboard
    Dim konek As New MySqlConnection("server=localhost;userid=root;password='';database=payroll_systemdb")

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Enable double buffering
        Me.DoubleBuffered = True
    End Sub

    Private Sub PayrollDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties for a simple outer glow
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New Padding(20) ' Increase form size to allow space for glow
        roundCorners(Me)

        Panel1.Show() ' Show Panel1 (Employee Details)
        Panel2.Hide() ' Hide Panel2 (Salary Details)
        ' Load data into the DataGridViews when the form loads
        LoadData()
    End Sub

    Private Sub roundCorners(obj As Form)
        obj.Region = New Region(createRoundedPath(obj))
    End Sub

    Private Function createRoundedPath(obj As Form) As GraphicsPath
        Dim DGP As New GraphicsPath()
        DGP.StartFigure()
        ' Define rounded corners
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()
        Return DGP
    End Function

    Private Sub edit_dataClick(sender As Object, e As EventArgs) Handles edit_data.Click
        ' Ensure a row is selected in the DataGridView
        If emp_details_data.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit.")
            Return
        End If

        ' Retrieve the selected row
        Dim selectedRow As DataGridViewRow = emp_details_data.SelectedRows(0)

        ' Populate textboxes with data from the selected row
        Try
            ref_id.Text = selectedRow.Cells("ref_id").Value.ToString()
            emp_fname.Text = selectedRow.Cells("emp_fname").Value.ToString()
            emp_mname.Text = selectedRow.Cells("emp_mname").Value.ToString()
            emp_lname.Text = selectedRow.Cells("emp_lname").Value.ToString()
            emp_age.Text = selectedRow.Cells("emp_age").Value.ToString()
            emp_address.Text = selectedRow.Cells("emp_address").Value.ToString()
            emp_mobile.Text = selectedRow.Cells("emp_mobile").Value.ToString()

            ' Handle ComboBox for position
            If emp_pos.Items.Contains(selectedRow.Cells("emp_position").Value.ToString()) Then
                emp_pos.SelectedItem = selectedRow.Cells("emp_position").Value.ToString()
            Else
                emp_pos.SelectedIndex = -1 ' Reset if value doesn't exist in ComboBox
            End If

            ' Handle gender checkboxes
            Dim gender As String = selectedRow.Cells("emp_sex").Value.ToString()
            If gender = "Male" Then
                CheckBoxMale.Checked = True
                CheckBoxFemale.Checked = False
            ElseIf gender = "Female" Then
                CheckBoxMale.Checked = False
                CheckBoxFemale.Checked = True
            End If

            ' Load the image into the PictureBox
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    ' Update button click event
    Private Sub update_data_btn_Click(sender As Object, e As EventArgs) Handles update_data.Click
        ' Ensure a row is selected in the DataGridView
        If emp_details_data.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to update.")
            Return
        End If

        ' Retrieve the selected row's internal_id (hidden)
        Dim selectedRow As DataGridViewRow = emp_details_data.SelectedRows(0)
        Dim internalId As Integer = Convert.ToInt32(selectedRow.Cells("internal_id").Value)

        ' Ensure all fields are populated
        If String.IsNullOrEmpty(ref_id.Text) OrElse String.IsNullOrEmpty(emp_fname.Text) OrElse String.IsNullOrEmpty(emp_lname.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Prepare gender
        Dim gender As String = If(CheckBoxMale.Checked, "Male", "Female")

        ' Prepare position
        Dim position As String = If(emp_pos.SelectedItem IsNot Nothing, emp_pos.SelectedItem.ToString(), "")

        ' Prepare the update query
        Dim updateQuery As String = "UPDATE emp_details SET ref_id = @REFID, emp_fname = @FirstName, emp_mname = @MiddleName, emp_lname = @LastName, emp_age = @EMPAge, emp_sex = @EMPSex, emp_address = @EMPAddress, emp_mobile = @EMPMobile, emp_position = @EMPPos WHERE internal_id = @InternalId"

        Using konek As New MySqlConnection("server=localhost;userid=root;password='';database=payroll_systemdb")
            Try
                konek.Open()

                Using cmd As New MySqlCommand(updateQuery, konek)
                    ' Add parameters to the query
                    cmd.Parameters.AddWithValue("@REFID", ref_id.Text)
                    cmd.Parameters.AddWithValue("@FirstName", emp_fname.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", emp_mname.Text)
                    cmd.Parameters.AddWithValue("@LastName", emp_lname.Text)
                    cmd.Parameters.AddWithValue("@EMPAge", emp_age.Text)
                    cmd.Parameters.AddWithValue("@EMPAddress", emp_address.Text)
                    cmd.Parameters.AddWithValue("@EMPMobile", emp_mobile.Text)
                    cmd.Parameters.AddWithValue("@EMPSex", gender)
                    cmd.Parameters.AddWithValue("@EMPPos", position)
                    cmd.Parameters.AddWithValue("@InternalId", internalId)

                    ' Execute the update query
                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Data updated successfully!")
                        LoadData() ' Refresh the DataGridView to reflect the changes
                        ClearInputs() ' Clear all input controls
                    Else
                        MessageBox.Show("Update failed.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub



    ' Method to clear all input controls
    Private Sub ClearInputs()
        ' Clear all textboxes
        ref_id.Clear()
        emp_fname.Clear()
        emp_mname.Clear()
        emp_lname.Clear()
        emp_age.Clear()
        emp_address.Clear()
        emp_mobile.Clear()


        If emp_pos.Items.Count > 0 Then
            emp_pos.SelectedIndex = -1 ' Reset to no selection
        End If

        ' Uncheck checkboxes
        CheckBoxMale.Checked = False
        CheckBoxFemale.Checked = False

        ' Clear the PictureBox
        emp_img.Image = Nothing

        ' Optionally reset other controls if needed
    End Sub



    Private Sub InsertData_Click(sender As Object, e As EventArgs) Handles insert_data.Click
        Using konek As New MySqlConnection("server=localhost;userid=root;password='';database=payroll_systemdb")

            Dim gender As String = If(CheckBoxMale.Checked, "Male", "Female")
            Dim position As String = If(emp_pos.SelectedItem IsNot Nothing, emp_pos.SelectedItem.ToString(), "")


            Try
                konek.Open()

                Dim querymain = "INSERT INTO emp_details (ref_id, emp_img, emp_fname, emp_mname, emp_lname, emp_age, emp_sex, emp_address, emp_mobile, emp_position) 
                                       VALUES (@REFID, @EMPImage, @Firstname, @MiddleName, @LastName, @EMPAge, @EMPSex, @EMPAddress, @EMPMobile, @EMPPos)"

                Using Command As New MySqlCommand(querymain, konek)
                    ' Add parameters to avoid SQL injection
                    Command.Parameters.AddWithValue("@REFID", ref_id.Text)
                    Command.Parameters.AddWithValue("@FirstName", emp_fname.Text)
                    Command.Parameters.AddWithValue("@MiddleName", emp_mname.Text)
                    Command.Parameters.AddWithValue("@LastName", emp_lname.Text)
                    Command.Parameters.AddWithValue("@EMPAge", emp_age.Text)
                    Command.Parameters.AddWithValue("@EMPAddress", emp_address.Text) ' Corrected text box name for address
                    Command.Parameters.AddWithValue("@EMPMobile", emp_mobile.Text) ' Corrected text box name for mobile number
                    Command.Parameters.AddWithValue("@EMPSex", gender) ' Static value for sex
                    Command.Parameters.AddWithValue("@EMPImage", "IMAGE") ' Static value for image
                    Command.Parameters.AddWithValue("@EMPPos", position) ' Static value for image

                    If Command.ExecuteNonQuery > 0 Then
                        MessageBox.Show("Data inserted successfully!")
                        LoadData() ' Refresh the DataGridView
                    Else
                        MessageBox.Show("Insertion failed.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub





    Private Sub insert_image_btn_Click(sender As Object, e As EventArgs) Handles insert_image_btn.Click
        ' Create a new OpenFileDialog object
        Dim openFileDialog As New OpenFileDialog()

        ' Set the filter to allow image files only
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        ' Show the OpenFileDialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file's path
            Dim selectedFilePath As String = openFileDialog.FileName

            ' Display the selected file path in a message box (optional)
            MessageBox.Show("Selected image: " & selectedFilePath)

            ' Load the image into the PictureBox
            emp_img.Image = Image.FromFile(selectedFilePath)

            ' Optionally, resize the PictureBox to fit the image
            emp_img.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            MessageBox.Show("No image selected.")
        End If
    End Sub




    Private Sub delete_data_btn_Click(sender As Object, e As EventArgs) Handles delete_data.Click
        ' Ensure a row is selected in the DataGridView
        If emp_details_data.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Return
        End If

        ' Retrieve the selected row's internal_id (hidden column)
        Dim selectedRow As DataGridViewRow = emp_details_data.SelectedRows(0)
        Dim internalId As Integer = selectedRow.Cells("internal_id").Value ' Assuming internal_id is stored in the DataGridView

        ' Confirm deletion
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirmResult = DialogResult.Yes Then
            Using konek As New MySqlConnection("server=localhost;userid=root;password='';database=payroll_systemdb")
                Try
                    konek.Open()

                    ' SQL DELETE query using internal_id
                    Dim deleteQuery As String = "DELETE FROM emp_details WHERE internal_id = @internalId"

                    Using cmd As New MySqlCommand(deleteQuery, konek)
                        cmd.Parameters.AddWithValue("@internalId", internalId)

                        If cmd.ExecuteNonQuery() > 0 Then
                            MessageBox.Show("Record deleted successfully.")
                            LoadData()
                        Else
                            MessageBox.Show("Failed to delete the record.")
                        End If
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End If
    End Sub



    Private Sub LoadData()
        Using konek As New MySqlConnection("server=localhost;userid=root;password='';database=payroll_systemdb")
            Try
                konek.Open()

                ' Query to fetch data from the tables
                Dim query1 As String = "SELECT * FROM emp_details"
                Dim query2 As String = "SELECT * FROM emp_salary"

                ' Create data adapters and data tables
                Dim adapter1 As New MySqlDataAdapter(query1, konek)
                Dim dt1 As New DataTable()
                adapter1.Fill(dt1)

                ' Create another data adapter for the second query
                Dim adapter2 As New MySqlDataAdapter(query2, konek)
                Dim dt2 As New DataTable()
                adapter2.Fill(dt2)

                ' Assign data tables to the corresponding DataGridViews
                emp_details_data.DataSource = dt1
                emp_salary_data.DataSource = dt2

                emp_details_data.Columns("internal_id").Visible = False
                emp_salary_data.Columns("internal_id").Visible = False



            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Switch between panels using BringToFront
    Private Sub salary_detailsbtn_Click(sender As Object, e As EventArgs) Handles salary_detailsbtn.Click
        ' Switch to the Salary Details panel and show corresponding DataGridView
        Panel1.Hide()
        Panel2.Show()
    End Sub

    Private Sub emp_detailsbtn_Click(sender As Object, e As EventArgs) Handles emp_detailsbtn.Click
        ' Switch to the Employee Details panel and show corresponding DataGridView
        Panel2.Hide()
        Panel1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        PayrollLogin.Show()
    End Sub

    Private Sub clear_data_Click(sender As Object, e As EventArgs) Handles clear_data.Click
        ClearInputs()

    End Sub

    Private Sub CheckBoxMale_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMale.CheckedChanged
        If CheckBoxMale.Checked Then
            CheckBoxFemale.Checked = False
        End If
    End Sub

    Private Sub CheckBoxFemale_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFemale.CheckedChanged
        If CheckBoxFemale.Checked Then
            CheckBoxMale.Checked = False
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles log_date.ValueChanged

    End Sub














    'SALARY PANEL CODE'

    Private Sub emp_Hworked_TextChanged(sender As Object, e As EventArgs) Handles emp_Hworked.TextChanged
        CalculateGrossIncome()
    End Sub

    Private Sub emp_Hrate_TextChanged(sender As Object, e As EventArgs) Handles emp_Hrate.TextChanged
        CalculateGrossIncome()
    End Sub

    Private Sub CalculateGrossIncome()
        ' Validate input for Hours Worked and Hourly Rate
        Dim hoursWorked As Integer
        Dim hourlyRate As Decimal
        Dim grossIncome As Decimal

        If Integer.TryParse(emp_Hworked.Text, hoursWorked) AndAlso Decimal.TryParse(emp_Hrate.Text, hourlyRate) Then
            ' Calculate Gross Income
            grossIncome = hoursWorked * hourlyRate
            emp_gross.Text = grossIncome.ToString("F2") ' Display with 2 decimal places

            ' Calculate deductions automatically after updating gross income
            CalculateDeductions()
        Else
            ' Reset Gross Income and Deductions if input is invalid
            emp_gross.Text = "0.00"
            ResetDeductions()
        End If
    End Sub

    Private Sub CalculateDeductions()
        ' Validate input for Gross Income
        Dim grossIncome As Decimal
        If Not Decimal.TryParse(emp_gross.Text, grossIncome) OrElse grossIncome = 0 Then
            ' Reset deductions if invalid or zero gross income
            ResetDeductions()
            Return
        End If

        ' Declare variables for deductions
        Dim sssPercent As Decimal = 0
        Dim phicPercent As Decimal = 0
        Dim pagibigFixed As Decimal = 0

        ' Determine percentages and fixed values based on position
        Select Case emp_pos2.Text
            Case "EMPLOYEE"
                sssPercent = 0.03
                phicPercent = 0.02
                pagibigFixed = 100
            Case "TEAM MANAGER"
                sssPercent = 0.035
                phicPercent = 0.025
                pagibigFixed = 200
            Case "PROJECT MANAGER"
                sssPercent = 0.04
                phicPercent = 0.03
                pagibigFixed = 300
            Case "HR"
                sssPercent = 0.045
                phicPercent = 0.035
                pagibigFixed = 400
            Case "CEO"
                sssPercent = 0.05
                phicPercent = 0.04
                pagibigFixed = 500
            Case Else
                ' Reset deductions if position is not selected
                ResetDeductions()
                Return
        End Select

        ' Calculate deductions
        Dim sssDeduction As Decimal = grossIncome * sssPercent
        Dim phicDeduction As Decimal = grossIncome * phicPercent
        Dim pagibigDeduction As Decimal = pagibigFixed

        ' Update deduction fields
        emp_sss.Text = sssDeduction.ToString("F2")
        emp_phic.Text = phicDeduction.ToString("F2")
        emp_pagibig.Text = pagibigDeduction.ToString("F2")

        ' Calculate Total Deductions
        Dim totalDeduction As Decimal = sssDeduction + phicDeduction + pagibigDeduction
        Dim employeenet As Decimal = grossIncome - totalDeduction
        emp_deduc.Text = totalDeduction.ToString("F2")
        emp_net.Text = employeenet.ToString("F2")
    End Sub

    Private Sub ResetDeductions()
        ' Reset all deduction fields to "0.00"
        emp_sss.Text = "0.00"
        emp_phic.Text = "0.00"
        emp_pagibig.Text = "0.00"
        emp_deduc.Text = "0.00"
        emp_net.Text = "0.00"
    End Sub

    Private Sub retrieve_data_btn_Click(sender As Object, e As EventArgs) Handles retrieve_salary.Click
        ' Ensure a row is selected in the DataGridView
        If emp_details_data.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to retrieve data.")
            Return
        End If

        ' Retrieve the selected row
        Dim selectedRow = emp_details_data.SelectedRows(0)

        ' Get internal_id (hidden) and use it for further processing if needed
        Dim internalId As Integer = selectedRow.Cells("internal_id").Value

        ' Populate textboxes with data from the selected row
        Try
            ' Retrieve and combine employee name
            Dim firstName = selectedRow.Cells("emp_fname").Value.ToString
            Dim middleI As String = selectedRow.Cells("emp_mname").Value.ToString()
            If Not String.IsNullOrWhiteSpace(middleI) Then
                middleI = middleI.Substring(0, 1) & "."
            Else
                middleI = "" ' Handle case where middle name is empty or null
            End If
            Dim lastName = selectedRow.Cells("emp_lname").Value.ToString
            emp_full.Text = $"{firstName} {middleI} {lastName}" ' Combine first and last name

            ' Retrieve position and reference ID
            emp_pos2.Text = selectedRow.Cells("emp_position").Value.ToString
            ref_id2.Text = selectedRow.Cells("ref_id").Value.ToString
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub


    Private Sub Insert_Salary_Click(sender As Object, e As EventArgs) Handles insert_salary.Click
        ' Define the connection string
        Dim connectionString As String = "server=localhost;userid=root;password='';database=payroll_systemdb"

        Dim position As String = emp_pos2.Text

        Using konek As New MySqlConnection(connectionString)
            Try
                ' Open the database connection
                konek.Open()

                ' Define the SQL INSERT query
                Dim querymain As String = "INSERT INTO emp_salary (ref_id, log_date,emp_position, hours_worked, hourly_rate, emp_sss, emp_phic, emp_pagibig, emp_TIncome, emp_TDeduc,emp_netpay) 
                                       VALUES (@REFID, @LogDate,@EMPPos, @HWorked, @HRate, @EMPsss, @EMPphic, @EMPpagibig, @EMPTIncome, @EMPTDeduc, @EMPNetpay)"

                Using Command As New MySqlCommand(querymain, konek)
                    ' Add parameters to avoid SQL injection
                    Command.Parameters.AddWithValue("@REFID", ref_id2.Text)
                    Command.Parameters.AddWithValue("@LogDate", log_date.Value.ToString("yyyy-MM-dd")) ' Ensure proper date format
                    Command.Parameters.AddWithValue("@EMPPos", position)
                    Command.Parameters.AddWithValue("@HWorked", emp_Hworked.Text)
                    Command.Parameters.AddWithValue("@HRate", emp_Hrate.Text)
                    Command.Parameters.AddWithValue("@EMPsss", emp_sss.Text)
                    Command.Parameters.AddWithValue("@EMPphic", emp_phic.Text)
                    Command.Parameters.AddWithValue("@EMPpagibig", emp_pagibig.Text)
                    Command.Parameters.AddWithValue("@EMPTIncome", emp_gross.Text)
                    Command.Parameters.AddWithValue("@EMPTDeduc", emp_deduc.Text)
                    Command.Parameters.AddWithValue("@EMPNetpay", emp_net.Text)

                    ' Execute the query and check the result
                    If Command.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Data inserted successfully!")
                        LoadData() ' Refresh the DataGridView
                    Else
                        MessageBox.Show("Insertion failed.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub delete_salary_Click(sender As Object, e As EventArgs) Handles delete_salary.Click
        ' Ensure a row is selected in the DataGridView
        If emp_salary_data.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Return
        End If

        ' Retrieve the selected row's internal_id (hidden column)


        Dim selectedRow As DataGridViewRow = emp_salary_data.SelectedRows(0)
        Dim internalId As Integer = selectedRow.Cells("internal_id").Value ' Assuming internal_id is stored in the DataGridView


        ' Confirm deletion
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirmResult = DialogResult.Yes Then
            Using konek As New MySqlConnection("server=localhost;userid=root;password='';database=payroll_systemdb")
                Try
                    konek.Open()

                    ' SQL DELETE query using internal_id
                    Dim deleteQuery As String = "DELETE FROM emp_salary WHERE internal_id = @Internal_ID"

                    Using cmd As New MySqlCommand(deleteQuery, konek)
                        cmd.Parameters.AddWithValue("@Internal_ID", internalId)

                        If cmd.ExecuteNonQuery() > 0 Then
                            MessageBox.Show("Record deleted successfully.")
                            LoadData()
                        Else
                            MessageBox.Show("Failed to delete the record.")
                        End If
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End If
    End Sub



    Private selectedInternalId As Integer


    Private Sub print_salary_btn_Click(sender As Object, e As EventArgs) Handles print_salary_btn.Click
        ' Create a PrintPreviewDialog to show the print preview.
        Dim printPreviewDialog As New PrintPreviewDialog()


        ' Set the PrintDocument for the PrintPreviewDialog.
        printPreviewDialog.Document = PrintDocument1

        ' Fetch the internal_id from the emp_salary_details DataGridView
        Dim selectedRow As DataGridViewRow = emp_salary_data.CurrentRow
        Dim internalId As Integer = Convert.ToInt32(selectedRow.Cells("internal_id").Value)

        ' Pass the internalId to the print logic using a global variable
        selectedInternalId = internalId

        ' Show the PrintPreviewDialog
        printPreviewDialog.StartPosition = FormStartPosition.CenterScreen
        printPreviewDialog.Width = 800
        printPreviewDialog.Height = 600
        printPreviewDialog.ShowDialog()
    End Sub



    Public Class EmployeeData
        Public Property FullName As String
        Public Property Position As String
        Public Property TotalIncome As Decimal
        Public Property TotalDeductions As Decimal
        Public Property NetPay As Decimal
    End Class


    Private Function GetEmployeeDataByInternalId(internalId As Integer) As EmployeeData
        Dim employee As New EmployeeData()

        ' Your SQL query
        Dim query As String = "SELECT * FROM vw_employee_summary WHERE internal_id = @internalId"

        ' Assuming you're using MySQL to run the query
        Using conn As New MySqlConnection("server=localhost;userid=root;password='';database=payroll_systemdb")
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@internalId", internalId)

                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Populate employee data from the reader
                        employee.FullName = reader("emp_full_name").ToString()
                        employee.Position = reader("emp_position").ToString()
                        employee.TotalIncome = Convert.ToDecimal(reader("emp_TIncome"))
                        employee.TotalDeductions = Convert.ToDecimal(reader("emp_TDeduc"))
                        employee.NetPay = Convert.ToDecimal(reader("emp_netpay"))
                    End If
                End Using
            End Using
        End Using

        Return employee
    End Function




    Private Sub printDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Get the logo from resources
        Using logoImage As Image = My.Resources.

            ' Define positions and sizes for the logo
            Dim logoX As Integer = 50
            Dim logoY As Integer = 50
            Dim logoWidth As Integer = 100
            Dim logoHeight As Integer = 100

            ' Draw the logo
            e.Graphics.DrawImage(logoImage, logoX, logoY, logoWidth, logoHeight)

            ' Define the title font
            Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
            Dim titleX As Integer = logoX + logoWidth + 20 ' Position title next to logo
            Dim titleY As Integer = logoY + (logoHeight / 4) ' Center-align title with logo

            ' Draw the title
            e.Graphics.DrawString("ITECH COMPANY PAY-SLIP", titleFont, Brushes.Black, titleX, titleY)
        End Using
    End Sub



End Class