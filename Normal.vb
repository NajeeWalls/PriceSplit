Public Class Normal

    'These are the 3 variables that all 3 calculating forms. 
    'When a form another form is loaded, these values carry on to this form.
    Friend globaldollar As Integer
    Friend globalcent As Integer
    Friend globalpeople As Integer

    Friend NormalClass As GlobalPrice = New GlobalPrice()
    Friend NormalSwitch As Boolean =False



    'This is the basis of the entire program. This takes a dollar and cent amount, add's them together.
    'Friend Function NormalSpilt(ByVal dollars As Integer, ByVal cents As Integer, ByVal people As Integer) As String
    'Dim x As Decimal
    '   Try
    '      x = (dollars + (cents / 100)) / people
    'Catch ex As Exception
    '     x = 0
    'End Try


    '    Return x.ToString("N2")
    'End Function

    Friend Sub NormalParse()
        'If the inputs are not numbers, change the value to 0
        Try
            NormalClass.Dollars = Integer.Parse(dollarsTextBox.Text)
        Catch ex As Exception
            NormalClass.Dollars = 0
        End Try

        Try
            NormalClass.Cents = Integer.Parse(centsTextBox.Text)
        Catch ex As Exception
            NormalClass.Cents = 0
        End Try

        Try
            NormalClass.Number = Integer.Parse(numberComboBox.Text)
        Catch
            NormalClass.Number = 0
        End Try

        Try
            NormalClass.TaxPercent = Decimal.Parse(taxTextBox.Text)
        Catch ex As Exception
            NormalClass.TaxPercent = 0
        End Try
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        StartForm.Close()
    End Sub

    Private Sub OnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineToolStripMenuItem.Click
        NormalSwitch = True
        Online.Show()
        Me.Hide()
    End Sub

    Private Sub RestaurantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestaurantToolStripMenuItem.Click
        NormalSwitch = True
        Restaurant.Show()
        Me.Hide()
    End Sub

    Private Sub dollarsTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles dollarsTextBox.Leave
        NormalParse()
        NormalClass.NormalSplit()
        priceTextBox.Text = NormalClass.Price().ToString("N2")
    End Sub

    '   Private Sub Normal_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
    'If this is the first form loaded, do nothing
    'Else load the appriate form's object

    '    If Restaurant.ResturantSwitch Then
    '       NormalClass = Restaurant.RestruantClass
    '      NormalSwitch = False
    ' ElseIf Online.OnlineSwitch Then
    '    NormalClass = Online.OnlineClass
    '   NormalSwitch = False
    '        End If

    '    StartForm.firstload = False
    ' End Sub
End Class