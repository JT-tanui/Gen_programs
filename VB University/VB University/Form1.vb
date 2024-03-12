Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub payroll_button_Click(sender As Object, e As EventArgs) Handles payroll_button.Click
        ' Calculate gross pay
        Dim hours As Double = 0
        If Double.TryParse(hours_worked.Text, hours) Then
            Dim payRate As Double = 0
            If Double.TryParse(pay_rate.Text, payRate) Then
                Dim grossPay = hours * payRate
                If hours > 40 Then
                    grossPay += (hours - 40) * payRate * 1.5
                End If

                ' Check the status of the radio buttons
                Dim deduction As Double = 0
                If retirement.Checked Then
                    ' No calculations
                ElseIf standard_plan.Checked Then
                    deduction = grossPay * 0.05
                ElseIf A_plan.Checked Then
                    deduction = grossPay * 0.08
                End If

                ' Check the status of the check boxes
                If medical_insuarance.Checked Then
                    deduction += 3775
                End If
                If life_insuarance.Checked Then
                    deduction += 1835
                End If
                If Dental_insuarance.Checked Then
                    deduction += 400
                End If

                ' Calculate tax
                Dim tax As Double = 0
                If grossPay < 98500 Then
                    tax = grossPay * 0.08
                ElseIf grossPay < 245000 Then
                    tax = grossPay * 0.18
                Else
                    tax = grossPay * 0.28
                End If

                ' Calculate net pay
                Dim netPay = grossPay - tax - deduction

                ' Display the results
                payroll_outbox.Text = "Gross pay: " & grossPay.ToString("C") & Environment.NewLine & "Deductions: " & deduction.ToString("C") & Environment.NewLine & "Tax: " & tax.ToString("C") & Environment.NewLine & "Net pay: " & netPay.ToString("C")
            Else
                MessageBox.Show("Please enter a valid pay rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter a valid number of hours worked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class