Public Class GlobalPrice
    'Class Name: GlobalPrice
    'Programmer: Najee W.
    'Date: May 2012
    'Description: Handles the 3 forms


    'Dollar, cents, people, tax, tip and shipping decelartions
    Private dollarsinteger As Integer
    Private centsinteger As Integer
    Private peopleinteger As Integer
    Private taxpercentdecimal As Decimal
    Private tippercentdecimal As Decimal
    Private tipdollar As Integer
    Private tipcents As Integer
    Private shippinginteger As Integer
    Private pricedecimal As Decimal

    Private tiptotal As Decimal


    Property Dollars() As Integer
        Get
            Return dollarsinteger
        End Get
        Set(value As Integer)
            dollarsinteger = value
        End Set
    End Property

    Property Cents() As Integer
        Get
            Return centsinteger
        End Get
        Set(value As Integer)
            centsinteger = value
        End Set
    End Property

    Property Number() As Integer
        Get
            Return peopleinteger
        End Get
        Set(value As Integer)
            peopleinteger = value
        End Set
    End Property

    Property TaxPercent() As Decimal
        Get
            Return taxpercentdecimal
        End Get
        Set(value As Decimal)
            taxpercentdecimal = value
        End Set
    End Property

    Property TipPercent() As Decimal
        Get
            Return tippercentdecimal
        End Get
        Set(value As Decimal)
            tippercentdecimal = value
        End Set
    End Property

    Property DollarTip() As Integer
        Get
            Return tipdollar
        End Get
        Set(value As Integer)
            tipdollar = value
        End Set
    End Property

    Property CentTip() As Integer
        Get
            Return tipcents
        End Get
        Set(value As Integer)
            tipcents = value
        End Set
    End Property

    Property Price() As Decimal
        Get
            Return pricedecimal
        End Get
        Set(value As Decimal)
            pricedecimal = value
        End Set
    End Property

    Property ShippingDollar() As Integer

    Property ShippingCent() As Integer

    Public Sub New()
        'Default Constuctor
    End Sub


    Sub NormalSplit()
        'Normal form price is the total amount of dollars and cents, divided by people, and multipled by sales tax
        Try
            pricedecimal = ((dollarsinteger + (centsinteger / 100)) / peopleinteger) * (1 + (taxpercentdecimal / 100))
        Catch ex As Exception
            pricedecimal = 0
        End Try
    End Sub

    Sub RestruantSplit(Optional ByVal amountchange As Boolean = False)
        'First do the normal price split
        NormalSplit()
        'Finally, make a tip percentage or total amount after sales tax
        If amountchange = True Then
            AmountToPercent()
        Else
            PercentToAmount()
        End If
        pricedecimal = pricedecimal + tiptotal
    End Sub

    Protected Sub PercentToAmount()
        Try
            'This portion converts the amount of tip that would be calculated from the percent, into a dollar/cent amount
            tiptotal = (pricedecimal * Number) * (tippercentdecimal / 100)
            tipdollar = Int(tiptotal)
            tipcents = Int((tiptotal - tipdollar) * 100)

            'And then it's divided again so it can be added to the total price.
            tiptotal = tiptotal / Number
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub AmountToPercent()
        'This converts a flat amount money of tip into the percentage of the total.
        Try
            tiptotal = (tipdollar + (tipcents / 100)) / Number
            tippercentdecimal = (tiptotal / pricedecimal) * 100
        Catch ex As Exception

        End Try
        
    End Sub

    Sub OnlineSplit()

        NormalSplit()
        pricedecimal = pricedecimal + (ShippingDollar + (ShippingCent / 100))
    End Sub

End Class

