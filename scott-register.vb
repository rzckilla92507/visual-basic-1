    Public Class Form1
    Inherits System.Windows.Forms.Form
    
    '------Your Design code would go here.
    
    'Class level variables as Decimal values
    Dim tax, subTotal, total As Decimal

    'Class level constants as Decimal values
    Dim taxRate As Decimal = 0.08 '8.0% tax rate
    Dim priceHamburger As Decimal = 5.95
    Dim priceChickenSandwich As Decimal = 7.95
    Dim priceFishSandwich As Decimal = 6.95
    Dim priceCheese As Decimal = 2.0
    Dim priceBacon As Decimal = 1.5
    Dim priceAvocado As Decimal = 2.5
    Dim priceSideRanch As Decimal = 0.5
    Dim priceSideBBQ As Decimal = 0.5
    Dim priceFries As Decimal = 2.95
    Dim priceSalad As Decimal = 3.95
    Dim priceFruit As Decimal = 1.95
    Dim priceSoda As Decimal = 1.5
    Dim priceIcedTea As Decimal = 1.5
    Dim priceWater As Decimal = 1.0

    '------------------------Form Load and Helper Subroutines------------------------------------------
    'Form Load Event
    'Initialize variables and clear the form
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        initializeVariables()
        clearTheCustomerSelections()
        clearReceipt()

    End Sub

    Private Sub initializeVariables() 'for each new customer

        subTotal = 0
        tax = 0
        total = 0

    End Sub


    Private Sub clearTheCustomerSelections() 'for each new customer

        btnNoneMainItems.Checked = True
        btnNoneFoodSides.Checked = True
        btnCheese.Checked = False
        btnBacon.Checked = False
        btnAvocado.Checked = False
        btnRanchSide.Checked = False
        btnBBQ.Checked = False
        btnSoda.Checked = False
        btnIcedTea.Checked = False
        btnWater.Checked = False

    End Sub

    Private Sub clearReceipt() 'for each new customer

        listBoxDisplay.Items.Clear() 'clear the customer checked
        listBoxTotal.Items.Clear()

    End Sub

    
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        initializeVariables()
        clearTheCustomerSelections()
        clearReceipt()
    End Sub

    Private Sub btnAddToCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToCart.Click

        computeCurrentSelection()
        updateTotal()
        clearTheCustomerSelections()


    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Me.Close()

    End Sub

    Private Sub computeCurrentSelection()

        'If Hamburger Item was selected
        If btnHamburger.Checked Then
            subTotal += priceHamburger 'subtotal = subtotal + priceHamburger

            Dim hamburgerItem As String = priceHamburger.ToString("C") & " Hamburger"
            listBoxDisplay.Items.Add(hamburgerItem)
        End If

        'Chicken Sandwich Item was selected
        If btnChickenSandwich.Checked Then
            subTotal += priceChickenSandwich

            Dim chickenSandwichItem As String = priceChickenSandwich.ToString("C") & " Chicken Sandwich"
            listBoxDisplay.Items.Add(chickenSandwichItem)
        End If

        'Fish Sandwich Item was selected
        If btnFishSandwich.Checked Then
            subTotal += priceFishSandwich

            Dim fishSandwichItem As String = priceFishSandwich.ToString("C") & " Fish Sandwich"
            listBoxDisplay.Items.Add(fishSandwichItem)
        End If

        'Adding Cheese Item was selected
        If btnCheese.Checked Then
            subTotal += priceCheese

            Dim extraCheeseItem As String = priceCheese.ToString("C") & " add Cheese"
            listBoxDisplay.Items.Add(extraCheeseItem)
        End If

    End Sub

    Private Sub updateTotal()

        'Clear the previous subtotal, tax and total
        listBoxTotal.Items.Clear()

        'Compute and display the subtotal
        listBoxTotal.Items.Add("SUB TOTAL = " & subTotal.ToString("C"))

        'Compute and display the tax
        tax = subTotal * taxRate
        listBoxTotal.Items.Add("             TAX = " & tax.ToString("C"))

        'Compute and display the total
        total = subTotal + tax
        listBoxTotal.Items.Add("        TOTAL = " & total.ToString("C"))

        'Separate each person's order on the receipt
        listBoxDisplay.Items.Add("------------------------")

    End Sub
End Class
