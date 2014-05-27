Public Class Restaurant
    Private percentageswitch As Boolean
    Friend RestruantClass As GlobalPrice = New GlobalPrice
    Friend ResturantSwitch As Boolean

    Sub InputParse()
        Try
            RestruantClass.Dollars = Integer.Parse(dollarsTextBox.Text)
        Catch ex As Exception
            RestruantClass.Dollars = 0
        End Try

        Try
            RestruantClass.Cents = Integer.Parse(centsTextBox.Text)
        Catch ex As Exception
            RestruantClass.Cents = 0
        End Try

        Try
            RestruantClass.Number = Integer.Parse(numberComboBox.Text)
        Catch ex As Exception
            RestruantClass.Number = 0
        End Try

        Try
            RestruantClass.TaxPercent = Decimal.Parse(taxTextBox.Text)
        Catch ex As Exception
            RestruantClass.TaxPercent = 0
        End Try

        Try
            RestruantClass.TipPercent = Decimal.Parse(tippercentTextBox.Text)
        Catch ex As Exception
            RestruantClass.TipPercent = 0
        End Try

        Try
            RestruantClass.DollarTip = Integer.Parse(tipdollarTextBox.Text)
        Catch ex As Exception
            RestruantClass.DollarTip = 0
        End Try

        Try
            RestruantClass.CentTip = Integer.Parse(tipcentTextBox.Text)
        Catch ex As Exception
            RestruantClass.CentTip = 0
        End Try
      
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        StartForm.Close()
    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        ResturantSwitch = True
        Normal.Show()
        Me.Hide()
    End Sub

    Private Sub OnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineToolStripMenuItem.Click
        ResturantSwitch = True
        Online.Show()
        Me.Hide()
    End Sub

    Private Sub tipdollarTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles tipdollarTextBox.Leave, taxTextBox.TextChanged, numberComboBox.TextChanged, dollarsTextBox.TextChanged, centsTextBox.TextChanged
        InputParse()
        RestruantClass.RestruantSplit(True)
        priceTextBox.Text = RestruantClass.Price.ToString("N2")
        tippercentTextBox.Text = RestruantClass.TipPercent.ToString()


    End Sub

    Private Sub tipcentTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles tipcentTextBox.Leave
        InputParse()
        RestruantClass.RestruantSplit(True)
        priceTextBox.Text = RestruantClass.Price.ToString("N2")
        tippercentTextBox.Text = RestruantClass.TipPercent.ToString()
    End Sub

    Private Sub dollarsTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles dollarsTextBox.Leave
        InputParse()
        RestruantClass.RestruantSplit()
        priceTextBox.Text = RestruantClass.Price.ToString("N2")
        tipdollarTextBox.Text = RestruantClass.DollarTip.ToString()
        tipcentTextBox.Text = RestruantClass.CentTip.ToString()
    End Sub
End Class