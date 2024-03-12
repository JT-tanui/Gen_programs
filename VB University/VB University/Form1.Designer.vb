<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        pay_rate = New TextBox()
        Label5 = New Label()
        ID = New MaskedTextBox()
        hours_worked = New TextBox()
        Label7 = New Label()
        department = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        myname = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        A_plan = New RadioButton()
        standard_plan = New RadioButton()
        retirement = New RadioButton()
        Label9 = New Label()
        Label10 = New Label()
        GroupBox3 = New GroupBox()
        Dental_insuarance = New CheckBox()
        life_insuarance = New CheckBox()
        medical_insuarance = New CheckBox()
        Label12 = New Label()
        GroupBox4 = New GroupBox()
        payroll_button = New Button()
        payroll_outbox = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(pay_rate)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(ID)
        GroupBox1.Controls.Add(hours_worked)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(department)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(myname)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(672, 816)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Employee Information Group Box"
        ' 
        ' pay_rate
        ' 
        pay_rate.Location = New Point(450, 435)
        pay_rate.MaxLength = 10
        pay_rate.Name = "pay_rate"
        pay_rate.Size = New Size(168, 23)
        pay_rate.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(358, 438)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 11
        Label5.Text = "Pay rate :"
        ' 
        ' ID
        ' 
        ID.Location = New Point(185, 349)
        ID.Mask = "000-00-0000"
        ID.Name = "ID"
        ID.Size = New Size(433, 23)
        ID.TabIndex = 10
        ' 
        ' hours_worked
        ' 
        hours_worked.Location = New Point(185, 435)
        hours_worked.MaxLength = 10
        hours_worked.Name = "hours_worked"
        hours_worked.Size = New Size(140, 23)
        hours_worked.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(53, 443)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 15)
        Label7.TabIndex = 8
        Label7.Text = "Hours Worked :"
        ' 
        ' department
        ' 
        department.Location = New Point(185, 390)
        department.Name = "department"
        department.Size = New Size(433, 23)
        department.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(52, 398)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 15)
        Label4.TabIndex = 6
        Label4.Text = "Employee Department :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 357)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 4
        Label3.Text = "Employee ID :"
        ' 
        ' myname
        ' 
        myname.AccessibleDescription = ""
        myname.AccessibleName = ""
        myname.Location = New Point(185, 300)
        myname.Name = "myname"
        myname.Size = New Size(433, 23)
        myname.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 308)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 15)
        Label2.TabIndex = 1
        Label2.Text = "Employee Name :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(305, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 15)
        Label1.TabIndex = 0
        Label1.Text = "Employee Information Group Box"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(A_plan)
        GroupBox2.Controls.Add(standard_plan)
        GroupBox2.Controls.Add(retirement)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Location = New Point(704, 36)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(570, 231)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Benefits Group box"
        ' 
        ' A_plan
        ' 
        A_plan.AutoSize = True
        A_plan.Location = New Point(282, 166)
        A_plan.Name = "A_plan"
        A_plan.Size = New Size(198, 19)
        A_plan.TabIndex = 11
        A_plan.TabStop = True
        A_plan.Text = "401A plan (8% of your gross pay)"
        A_plan.UseVisualStyleBackColor = True
        ' 
        ' standard_plan
        ' 
        standard_plan.AutoSize = True
        standard_plan.Location = New Point(282, 129)
        standard_plan.Name = "standard_plan"
        standard_plan.Size = New Size(219, 19)
        standard_plan.TabIndex = 10
        standard_plan.TabStop = True
        standard_plan.Text = "Standard plan (5% of your gross pay)"
        standard_plan.UseVisualStyleBackColor = True
        ' 
        ' retirement
        ' 
        retirement.AutoSize = True
        retirement.Location = New Point(282, 90)
        retirement.Name = "retirement"
        retirement.Size = New Size(128, 19)
        retirement.TabIndex = 9
        retirement.TabStop = True
        retirement.Text = "No Retirement Plan"
        retirement.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(84, 90)
        Label9.Name = "Label9"
        Label9.Size = New Size(140, 15)
        Label9.TabIndex = 1
        Label9.Text = "Employee benefit option:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(260, 48)
        Label10.MaximumSize = New Size(50, 50)
        Label10.MinimumSize = New Size(100, 20)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 20)
        Label10.TabIndex = 0
        Label10.Text = "Benefits"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Dental_insuarance)
        GroupBox3.Controls.Add(life_insuarance)
        GroupBox3.Controls.Add(medical_insuarance)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Location = New Point(704, 312)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(570, 200)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Employee insuarance benefits"
        ' 
        ' Dental_insuarance
        ' 
        Dental_insuarance.AutoSize = True
        Dental_insuarance.Location = New Point(264, 168)
        Dental_insuarance.Name = "Dental_insuarance"
        Dental_insuarance.Size = New Size(171, 19)
        Dental_insuarance.TabIndex = 4
        Dental_insuarance.Text = "Dental insuarance (KES 400)"
        Dental_insuarance.UseVisualStyleBackColor = True
        ' 
        ' life_insuarance
        ' 
        life_insuarance.AutoSize = True
        life_insuarance.Location = New Point(264, 134)
        life_insuarance.Name = "life_insuarance"
        life_insuarance.Size = New Size(165, 19)
        life_insuarance.TabIndex = 3
        life_insuarance.Text = "Life Insuarance (KES 1,835)"
        life_insuarance.UseVisualStyleBackColor = True
        ' 
        ' medical_insuarance
        ' 
        medical_insuarance.AutoSize = True
        medical_insuarance.Location = New Point(264, 93)
        medical_insuarance.Name = "medical_insuarance"
        medical_insuarance.Size = New Size(194, 19)
        medical_insuarance.TabIndex = 2
        medical_insuarance.Text = "Medical insuarance ( KES 3,775 )"
        medical_insuarance.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(250, 35)
        Label12.Name = "Label12"
        Label12.Size = New Size(251, 15)
        Label12.TabIndex = 0
        Label12.Text = "Employee insuarance benefits (Per pay period)"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(payroll_button)
        GroupBox4.Controls.Add(payroll_outbox)
        GroupBox4.Location = New Point(704, 542)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(570, 259)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Payroll Information Groupbox "
        ' 
        ' payroll_button
        ' 
        payroll_button.Location = New Point(264, 204)
        payroll_button.Name = "payroll_button"
        payroll_button.Size = New Size(158, 49)
        payroll_button.TabIndex = 1
        payroll_button.Text = "Payroll"
        payroll_button.UseVisualStyleBackColor = True
        ' 
        ' payroll_outbox
        ' 
        payroll_outbox.AccessibleName = "Payroll"
        payroll_outbox.Location = New Point(3, 22)
        payroll_outbox.Multiline = True
        payroll_outbox.Name = "payroll_outbox"
        payroll_outbox.ReadOnly = True
        payroll_outbox.Size = New Size(561, 149)
        payroll_outbox.TabIndex = 0
        payroll_outbox.TabStop = False
        payroll_outbox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1474, 992)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)


    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents hours_worked As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents department As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents myname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents A_plan As RadioButton
    Friend WithEvents standard_plan As RadioButton
    Friend WithEvents retirement As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Dental_insuarance As CheckBox
    Friend WithEvents life_insuarance As CheckBox
    Friend WithEvents medical_insuarance As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents payroll_outbox As TextBox
    Friend WithEvents ID As MaskedTextBox
    Friend WithEvents pay_rate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents payroll_button As Button

End Class
