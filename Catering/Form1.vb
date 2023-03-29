Public Class Form1

    Dim strInput As String
    Dim intPoints As Integer = 0
    Dim strPayChoice As String = ""
    Dim strMeal As String = ""
    Dim decCost As Decimal = 0.00
    Const _cdecDisc As Decimal = 0.05
    Dim decDiscTot As Decimal = 0.00

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If Integer.TryParse(strInput, intPoints) Then

            If rdiCheese.Checked Then
                strMeal = "Gourmet Cheese platter"
                decCost = 49.99
            ElseIf rdiPinwheel.Checked Then
                strMeal = "Pinwheel Wraps platter"
                decCost = 59.99
            ElseIf rdiVeggie.Checked Then
                strMeal = "veggie platter"
                decCost = 29.99
            ElseIf rdiSnC.Checked Then
                strMeal = "sausage and cheese platter"
                decCost = 49.99
            Else
                strMeal = "fruit platter"
                decCost = 29.99
            End If

            If rdiPrPy.Checked Then
                strPayChoice = "pre-pay"
            ElseIf rdiPckUp.Checked Then
                strPayChoice = "pay-upon-pickup"
            End If

            decDiscTot = (intPoints \ 10) * _cdecDisc
            decCost -= (decDiscTot * decCost)


            If (decCost <= 0.00) Then
                lblPay.Text = "please don't ask us for money we're broke :("
                lblPay.Visible = True
            Else
                lblPay.Text = "Your order of a " + strMeal & vbNewLine & "costs $" + decCost.ToString("N2") + " using " + strPayChoice & vbNewLine & "after a discount of " + intPoints.ToString + " points"
                lblPay.Visible = True
                btnCalc.Enabled = False
            End If
        Else
            lblPay.Text = "That doesn't seem like a number!" & vbNewLine & "Please try again."
            lblPay.Visible = True
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblPay.Visible = False
        tbxInput.Text = ""
        rdiPrPy.PerformClick()
        rdiFruit.PerformClick()
        tbxInput.Select()
        btnCalc.Enabled = False
        btnClear.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub tbxInput_TextChanged(sender As Object, e As EventArgs) Handles tbxInput.TextChanged
        strInput = tbxInput.Text
        btnClear.Enabled = True
        btnCalc.Enabled = True
        If tbxInput.Text = "" Then
            btnCalc.Enabled = False
            If lblPay.Visible = False Then
                btnClear.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdiPckUp_CheckedChanged(sender As Object, e As EventArgs) Handles rdiPckUp.CheckedChanged
        btnCalc.Enabled = True
    End Sub

    Private Sub rdiSnC_CheckedChanged(sender As Object, e As EventArgs) Handles rdiSnC.CheckedChanged
        btnCalc.Enabled = True
    End Sub

    Private Sub rdiVeggie_CheckedChanged(sender As Object, e As EventArgs) Handles rdiVeggie.CheckedChanged
        btnCalc.Enabled = True
    End Sub

    Private Sub rdiPinwheel_CheckedChanged(sender As Object, e As EventArgs) Handles rdiPinwheel.CheckedChanged
        btnCalc.Enabled = True
    End Sub

    Private Sub rdiCheese_CheckedChanged(sender As Object, e As EventArgs) Handles rdiCheese.CheckedChanged
        btnCalc.Enabled = True
    End Sub

    Private Sub rdiPrPy_CheckedChanged(sender As Object, e As EventArgs) Handles rdiPrPy.CheckedChanged
        btnCalc.Enabled = True
    End Sub

    Private Sub rdiFruit_CheckedChanged(sender As Object, e As EventArgs) Handles rdiFruit.CheckedChanged
        btnCalc.Enabled = True
    End Sub
End Class
