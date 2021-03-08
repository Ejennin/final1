Public Class frmDoubleHalf


    'Declare constants
    Const TWO_TIMES As Double = 2.0
    Const HALF As Double = 0.5


    'Declare variables
    Dim intUserNum As Integer
    Dim intCalc As Integer


    'Extract user Number
    Dim intUserNum1 = Convert.ToInt32(txtUserNum.Text)

    'Calculate Double or Half




    Private Sub btnDouble_Click(sender As Object, e As EventArgs) Handles btnDouble.Click
        txtAnswer.Text = (intUserNum1 * TWO_TIMES)
    End Sub

    Private Sub btnHalf_Click(sender As Object, e As EventArgs) Handles btnHalf.Click
        txtAnswer.Text = (intUserNum1 * HALF)
    End Sub

    Private Sub txtUserNum_TextChanged(sender As Object, e As EventArgs) Handles txtUserNum.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close Form
        Me.Close()
    End Sub

    Private Sub frmDoubleHalf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
