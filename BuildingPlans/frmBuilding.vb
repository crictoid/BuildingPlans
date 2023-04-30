' Program:      Building Plans Conversion
' Author:       Mark Bulmer
' Date:         February 26, 2022
' Purpose:      This application converts inches to meters or meters to inches.

Option Strict On

Public Class frmBuilding
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' The btnCalculate event handler calculates the conversion between units.

        ' Declaration Section
        Dim decConversion As Decimal
        Dim decUnit As Decimal
        Dim decCostEstimate As Decimal
        Dim decInches As Decimal = 0.0254D
        Dim decMeters As Decimal = 39.37008D


        ' Did user enter a numeric value?
        If IsNumeric(txtLength.Text) Then
            decConversion = Convert.ToDecimal(txtLength.Text)
            ' Is length greater than zero
            If decConversion > 0 Then
                ' Determine unit conversion
                If radInches.Checked Then
                    decUnit = decInches
                    lblUnitChoice.Text = " meters"
                ElseIf radMeters.Checked Then
                    decUnit = decMeters
                    lblUnitChoice.Text = " inches"
                End If
                ' Calculate and display the converted measurement
                decCostEstimate = decConversion * decUnit
                lblConvertedLength.Text = decCostEstimate.ToString("N3")
            Else
                ' Display error message if user entered a negative value
                MsgBox("You entered " & decConversion.ToString() & ". Enter a Positive Number", , "Input Error")
                txtLength.Text = ""
                txtLength.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter a positive integer.", , "Input Error")
            txtLength.Text = ""
            txtLength.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the Clear button. It 
        ' clears the unit selected text box and the converted length label.

        txtLength.Clear()
        lblConvertedLength.Text = ""
        lblUnitChoice.Text = ""
        radInches.Checked = True
        radMeters.Checked = False
        txtLength.Focus()
    End Sub

    Private Sub frmBuilding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of the 
        ' program. It sets the focus to the unit selected text box and
        ' clears the converted length label.

        txtLength.Focus()
        lblConvertedLength.Text = ""
    End Sub

End Class
