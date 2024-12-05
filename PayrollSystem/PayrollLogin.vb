Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Ocsp
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.Text

Public Class PayrollLogin

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Enable double buffering
        Me.DoubleBuffered = True
    End Sub



    ' MySQL Connection Object
    Dim konek As New MySqlConnection("server=localhost;userid=root;password='';database=payroll_systemdb")

    Private Sub PayrollLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Create the SQL query to verify username and password directly (no hashing)
        Dim query As String = "SELECT * FROM payroll_register WHERE username = @username AND password = @password"

        ' Set up the MySQL command
        Dim cmd As New MySqlCommand(query, konek)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password) ' Plain text password comparison

        If String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            konek.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                ' If username and password match, show the dashboard
                PayrollDashboard.Show()
                Me.Hide() ' Optionally hide the login form
                TextBox1.Text = ""
                TextBox2.Text = ""

            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            konek.Close()
        End Try
    End Sub


    ' Hash the password before storing or comparing it


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PayrollRegister.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class
