Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles



Imports MySql.Data.MySqlClient



Public Class PayrollRegister



    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Enable double buffering
        Me.DoubleBuffered = True
    End Sub



    Dim konek As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        konek = New MySqlConnection
        konek.ConnectionString = "server=localhost;userid=root;password='';database=payroll_systemdb"

        Try
            konek.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            konek.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            konek.Close()
        End Try
    End Sub




    Private Sub PayrollRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties for a simple outer glow
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New Padding(20) ' Increase form size to allow space for glow
        roundCorners(Me)
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


    Private Sub Register_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        konek = New MySqlConnection("server=localhost;userid=root;password='';database=payroll_systemdb")

        Try
            konek.Open()

            Dim query As String = "INSERT INTO payroll_register (user_fname, user_lname, username, password, user_type) VALUES (@FirstName, @LastName, @Username, @Password, @UserType)"
            COMMAND = New MySqlCommand(query, konek)

            ' Add parameters to avoid SQL injection
            COMMAND.Parameters.AddWithValue("@FirstName", FName.Text)
            COMMAND.Parameters.AddWithValue("@LastName", LName.Text)
            COMMAND.Parameters.AddWithValue("@Username", user_name.Text)
            COMMAND.Parameters.AddWithValue("@Password", PSTextbox1.Text)
            COMMAND.Parameters.AddWithValue("@UserType", user_type.Text)

            If COMMAND.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Data inserted successfully!")
            Else
                MessageBox.Show("Insertion failed.")
            End If

            konek.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If konek.State = ConnectionState.Open Then
                konek.Close()
            End If
        End Try
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PSTextbox1.PasswordChar = ControlChars.NullChar ' Show password
            PSTextbox2.PasswordChar = ControlChars.NullChar
        Else
            PSTextbox1.PasswordChar = "*" ' Hide password
            PSTextbox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles register_btn.Click

    End Sub




    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Hide the register form and show the login form
        Me.Hide()
        PayrollLogin.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Fname_TextChanged(sender As Object, e As EventArgs) Handles LName.TextChanged

    End Sub
End Class