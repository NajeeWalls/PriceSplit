Public Class StartForm
    'Program Name: Price Split
    'Programmer: Bradley/Millspaugh
    'Date: April 2012
    'Description: This Program divides the price of a given amount depending on variables like number of people, sales tax, shipping,ect.
    'Most of the code will derive from form "Normal". Look to that if you want to see code.

    'Tracks if the form picked is the first one picked from the start screen
    Friend firstload As Boolean = True

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub normalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles normalButton.Click
        Me.Hide()
        Normal.Show()


   
    End Sub

    Private Sub restaurantButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restaurantButton.Click
        Me.Hide()
        Restaurant.Show()


    End Sub

    Private Sub onlineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onlineButton.Click
        Me.Hide()
        Online.Show()


    End Sub

    Private Sub StartForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
