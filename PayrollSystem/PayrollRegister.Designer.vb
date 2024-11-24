<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayrollRegister))
        Panel1 = New Panel()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        register_btn = New Button()
        Panel6 = New Panel()
        user_type = New TextBox()
        Panel5 = New Panel()
        PSTextbox2 = New TextBox()
        Panel8 = New Panel()
        user_name = New TextBox()
        Panel3 = New Panel()
        FName = New TextBox()
        RichTextBox1 = New RichTextBox()
        Panel4 = New Panel()
        PSTextbox1 = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        LName = New TextBox()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel8.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(register_btn)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(411, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(399, 451)
        Panel1.TabIndex = 3
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(88, 291)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 16
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(217, 55)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 14)
        Label3.TabIndex = 18
        Label3.Text = "Last Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(88, 317)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 28)
        Label6.TabIndex = 18
        Label6.Text = "User - " & vbCrLf & "Type" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(88, 232)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 14)
        Label5.TabIndex = 18
        Label5.Text = "Confirm Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(88, 110)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 14)
        Label8.TabIndex = 18
        Label8.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(88, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 14)
        Label4.TabIndex = 18
        Label4.Text = "Create Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(88, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 14)
        Label2.TabIndex = 18
        Label2.Text = "First Name"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(108, 404)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(211, 15)
        LinkLabel1.TabIndex = 19
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Not yet registered? | Create Account  >"
        ' 
        ' register_btn
        ' 
        register_btn.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        register_btn.Location = New Point(84, 361)
        register_btn.Name = "register_btn"
        register_btn.Size = New Size(253, 36)
        register_btn.TabIndex = 18
        register_btn.Text = "REGISTER"
        register_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ButtonShadow
        Panel6.Controls.Add(user_type)
        Panel6.Location = New Point(149, 317)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(192, 29)
        Panel6.TabIndex = 15
        ' 
        ' user_type
        ' 
        user_type.Location = New Point(0, 0)
        user_type.Multiline = True
        user_type.Name = "user_type"
        user_type.Size = New Size(193, 29)
        user_type.TabIndex = 17
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ButtonShadow
        Panel5.Controls.Add(PSTextbox2)
        Panel5.Location = New Point(88, 253)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(253, 29)
        Panel5.TabIndex = 15
        ' 
        ' PSTextbox2
        ' 
        PSTextbox2.Location = New Point(-1, 0)
        PSTextbox2.Multiline = True
        PSTextbox2.Name = "PSTextbox2"
        PSTextbox2.Size = New Size(254, 29)
        PSTextbox2.TabIndex = 15
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ButtonShadow
        Panel8.Controls.Add(user_name)
        Panel8.Location = New Point(88, 131)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(253, 29)
        Panel8.TabIndex = 15
        ' 
        ' user_name
        ' 
        user_name.Location = New Point(-1, 0)
        user_name.Multiline = True
        user_name.Name = "user_name"
        user_name.Size = New Size(254, 29)
        user_name.TabIndex = 13
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonShadow
        Panel3.Controls.Add(FName)
        Panel3.Controls.Add(RichTextBox1)
        Panel3.Location = New Point(88, 78)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(120, 29)
        Panel3.TabIndex = 15
        ' 
        ' FName
        ' 
        FName.Location = New Point(0, 0)
        FName.Multiline = True
        FName.Name = "FName"
        FName.Size = New Size(121, 29)
        FName.TabIndex = 11
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Location = New Point(6, 38)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(253, 29)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = ""
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonShadow
        Panel4.Controls.Add(PSTextbox1)
        Panel4.Location = New Point(88, 197)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(253, 29)
        Panel4.TabIndex = 15
        ' 
        ' PSTextbox1
        ' 
        PSTextbox1.Location = New Point(-1, 0)
        PSTextbox1.Multiline = True
        PSTextbox1.Name = "PSTextbox1"
        PSTextbox1.Size = New Size(254, 29)
        PSTextbox1.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(123, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 22)
        Label1.TabIndex = 7
        Label1.Text = "Register Account"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.Controls.Add(LName)
        Panel2.Location = New Point(221, 78)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(120, 29)
        Panel2.TabIndex = 15
        ' 
        ' LName
        ' 
        LName.Location = New Point(-1, 0)
        LName.Multiline = True
        LName.Name = "LName"
        LName.Size = New Size(121, 29)
        LName.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(405, 451)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(88, 19)
        Button2.Name = "Button2"
        Button2.Size = New Size(253, 36)
        Button2.TabIndex = 20
        Button2.Text = "REGISTER"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PayrollRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "PayrollRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents register_btn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents user_name As TextBox
    Friend WithEvents FName As TextBox
    Friend WithEvents PSTextbox1 As TextBox
    Friend WithEvents LName As TextBox
    Friend WithEvents user_type As TextBox
    Friend WithEvents PSTextbox2 As TextBox
End Class
