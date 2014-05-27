Public Class Online

    Friend OnlineClass As GlobalPrice = New GlobalPrice()
    Friend OnlineSwitch = False


    Sub InputParse()
        Try
            OnlineClass.Dollars = Integer.Parse(dollarsTextBox.Text)
        Catch ex As Exception
            OnlineClass.Dollars = 0
        End Try

        Try
            OnlineClass.Cents = Integer.Parse(centsTextBox.Text)
        Catch ex As Exception
            OnlineClass.Cents = 0
        End Try

        Try
            OnlineClass.Number = Integer.Parse(numberComboBox.Text)
        Catch ex As Exception
            OnlineClass.Number = 0
        End Try

        Try
            OnlineClass.ShippingDollar = Integer.Parse(shipdollarTextBox.Text)
        Catch ex As Exception
            OnlineClass.ShippingDollar = 0
        End Try

        Try
            OnlineClass.ShippingCent = Integer.Parse(shipcentTextBox.Text)
        Catch ex As Exception
            OnlineClass.ShippingCent = 0
        End Try
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        StartForm.Close()
    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        OnlineSwitch = True
        Me.Hide()
        Normal.Show()
    End Sub

    Private Sub RestruantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestruantToolStripMenuItem.Click
        OnlineSwitch = True
        Me.Hide()
        Restaurant.Show()
    End Sub


    '    Private Sub Online_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
    'If this is the first form loaded, do nothing
    'Else load the appriate form's object
    ' If StartForm.firstload Then

    '        ElseIf Restaurant.ResturantSwitch Then
    '       OnlineClass = Restaurant.RestruantClass
    '      OnlineSwitch = False
    '     ElseIf Normal.NormalSwitch Then
    '    OnlineClass = Normal.NormalClass
    '   OnlineSwitch = False
    '  End If

    'StartForm.firstload = False
    ' End Sub

    Private Sub dollarsTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles dollarsTextBox.Leave
        InputParse()
        OnlineClass.OnlineSplit()
        costTextBox.Text = OnlineClass.Price.ToString("N2")
    End Sub
End Class