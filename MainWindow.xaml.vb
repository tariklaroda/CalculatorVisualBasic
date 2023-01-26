'Tarik LaRoda
'A00440772
'A06

Class MainWindow

    Dim firstNumber As Decimal
    Dim secondNumber As Decimal
    Dim operation As Integer
    Dim operator_selector As Boolean = False

    Private Sub btnSeven_Click(sender As Object, e As RoutedEventArgs) Handles btnSeven.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "7"
        Else
            txtBox.Text = "7"
        End If

    End Sub

    Private Sub btnEight_Click(sender As Object, e As RoutedEventArgs) Handles btnEight.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "8"
        Else
            txtBox.Text = "8"
        End If
    End Sub

    Private Sub btnNine_Click(sender As Object, e As RoutedEventArgs) Handles btnNine.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "9"
        Else
            txtBox.Text = "9"
        End If
    End Sub

    Private Sub btnFour_Click(sender As Object, e As RoutedEventArgs) Handles btnFour.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "4"
        Else
            txtBox.Text = "4"
        End If
    End Sub

    Private Sub btnFive_Click(sender As Object, e As RoutedEventArgs) Handles btnFive.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "5"
        Else
            txtBox.Text = "5"
        End If
    End Sub

    Private Sub btnSix_Click(sender As Object, e As RoutedEventArgs) Handles btnSix.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "6"
        Else
            txtBox.Text = "6"
        End If
    End Sub

    Private Sub btnThree_Click(sender As Object, e As RoutedEventArgs) Handles btnThree.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "3"
        Else
            txtBox.Text = "3"
        End If
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As RoutedEventArgs) Handles btnTwo.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "2"
        Else
            txtBox.Text = "2"
        End If
    End Sub

    Private Sub btnOne_Click(sender As Object, e As RoutedEventArgs) Handles btnOne.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "1"
        Else
            txtBox.Text = "1"
        End If
    End Sub

    Private Sub btnZero_Click(sender As Object, e As RoutedEventArgs) Handles btnZero.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "0"
        Else
            txtBox.Text = "0"
        End If
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As RoutedEventArgs) Handles btnDecimal.Click
        If txtBox.Text <> "0" Then
            txtBox.Text += "."
        Else
            txtBox.Text = "."
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click
        txtBox.Text = "0"

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As RoutedEventArgs) Handles btnAdd.Click
        firstNumber = txtBox.Text
        txtBox.Text = "0"
        operator_selector = True
        operation = 1 '+
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As RoutedEventArgs) Handles btnSubtract.Click
        firstNumber = txtBox.Text
        txtBox.Text = "0"
        operator_selector = True
        operation = 2 '-
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As RoutedEventArgs) Handles btnMultiply.Click
        firstNumber = txtBox.Text
        txtBox.Text = "0"
        operator_selector = True
        operation = 3 '*
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As RoutedEventArgs) Handles btnDivide.Click
        firstNumber = txtBox.Text
        txtBox.Text = "0"
        operator_selector = True
        operation = 4 '*
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As RoutedEventArgs) Handles btnEquals.Click
        If operator_selector = True Then
            secondNumber = txtBox.Text
            If operation = 1 Then
                txtBox.Text = firstNumber + secondNumber
            ElseIf operation = 2 Then
                txtBox.Text = firstNumber - secondNumber
            ElseIf operation = 3 Then
                txtBox.Text = firstNumber * secondNumber
            ElseIf operation = 4 Then
                If secondNumber = 0 Then
                    txtBox.Text = "Cant Divide By Zero"
                Else
                    txtBox.Text = firstNumber / secondNumber
                End If
            End If
        End If
    End Sub

    Private Sub btnNegate_Click(sender As Object, e As RoutedEventArgs) Handles btnNegate.Click
        If txtBox.Text.Contains("-") Then
            Dim neg As Char = "-"
            txtBox.Text = txtBox.Text.Remove(0, 1)
        Else

            txtBox.Text = "-" + txtBox.Text
        End If
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As RoutedEventArgs) Handles btnBackspace.Click
        If Len(txtBox.Text) = 0 Then Exit Sub
        ' Now remove the last character from the textbox

        txtBox.Text = Mid(txtBox.Text, 1, Len(txtBox.Text) - 1)
    End Sub
End Class
