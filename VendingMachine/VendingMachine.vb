﻿Public Class VendingMachine

    Dim CurrentMoney As Decimal = 0

    Dim orderSlot1Count As Integer = 0
    Dim orderSlot2Count As Integer = 0
    Dim orderSlot3Count As Integer = 0
    Dim orderSlot4Count As Integer = 0
    Dim orderSlot5Count As Integer = 0
    Dim orderSlot6Count As Integer = 0

    Dim orderSlot1ID As Integer = 0
    Dim orderSlot2ID As Integer = 0
    Dim orderSlot3ID As Integer = 0
    Dim orderSlot4ID As Integer = 0
    Dim orderSlot5ID As Integer = 0
    Dim orderSlot6ID As Integer = 0

    Dim pepsiPrice As Decimal = 0.85
    Dim cokePrice As Decimal = 0.85
    Dim monsterPrice As Decimal = 1.5
    Dim crispsPrice As Decimal = 1
    Dim dairymilkPrice As Decimal = 0.75
    Dim winegumsPrice As Decimal = 1.5

    Dim pepsiStock As Integer = CInt(Math.Ceiling(Rnd() * 50)) + 2
    Dim cokeStock As Integer = CInt(Math.Ceiling(Rnd() * 50)) + 2
    Dim monsterStock As Integer = CInt(Math.Ceiling(Rnd() * 50)) + 2
    Dim crispsStock As Integer = CInt(Math.Ceiling(Rnd() * 50)) + 2
    Dim dairymilkStock As Integer = CInt(Math.Ceiling(Rnd() * 50)) + 2
    Dim winegumsStock As Integer = CInt(Math.Ceiling(Rnd() * 50)) + 2

    Dim Dispensing As Boolean = False
    Dim DispenseModifier As Integer = 1

    Dim currentTick As Integer = 0

    Dim consoleWindow As New ConsoleForm

    Private Sub appendLog(text As String)
        consoleWindow.addDebugLine(text)
    End Sub

    Private Sub ResetMachine()
        CurrentMoney = 0
        orderSlot1Count = 0
        orderSlot2Count = 0
        orderSlot3Count = 0
        orderSlot4Count = 0
        orderSlot5Count = 0
        orderSlot6Count = 0
        orderSlot1ID = 0
        orderSlot2ID = 0
        orderSlot3ID = 0
        orderSlot4ID = 0
        orderSlot5ID = 0
        orderSlot6ID = 0
        order_item_1.Text = ""
        order_item_2.Text = ""
        order_item_3.Text = ""
        order_item_4.Text = ""
        order_item_5.Text = ""
        order_item_6.Text = ""
        appendLog("(ResetMachine) Reset Machine")
    End Sub

    Private Sub InitMachine()
        coin_1p_return.Text = "0"
        coin_2p_return.Text = "0"
        coin_5p_return.Text = "0"
        coin_10p_return.Text = "0"
        coin_20p_return.Text = "0"
        coin_50p_return.Text = "0"
        coin_100p_return.Text = "0"
        coin_200p_return.Text = "0"
        appendLog("(InitMachine) Initialised Machine")
    End Sub

    Private Sub ReturnCoins()
        While CurrentMoney > 0
            If CurrentMoney >= 2.0 Then
                coin_200p_return.Text = Convert.ToInt32(coin_200p_return.Text) + 1
                CurrentMoney = CurrentMoney - 2.0
            ElseIf CurrentMoney >= 1.0 Then
                coin_100p_return.Text = Convert.ToInt32(coin_100p_return.Text) + 1
                CurrentMoney = CurrentMoney - 1.0
            ElseIf CurrentMoney >= 0.5 Then
                coin_50p_return.Text = Convert.ToInt32(coin_50p_return.Text) + 1
                CurrentMoney = CurrentMoney - 0.5
            ElseIf CurrentMoney >= 0.2 Then
                coin_20p_return.Text = Convert.ToInt32(coin_20p_return.Text) + 1
                CurrentMoney = CurrentMoney - 0.2
            ElseIf CurrentMoney >= 0.1 Then
                coin_10p_return.Text = Convert.ToInt32(coin_10p_return.Text) + 1
                CurrentMoney = CurrentMoney - 0.1
            ElseIf CurrentMoney >= 0.05 Then
                coin_5p_return.Text = Convert.ToInt32(coin_5p_return.Text) + 1
                CurrentMoney = CurrentMoney - 0.05
            ElseIf CurrentMoney >= 0.02 Then
                coin_2p_return.Text = Convert.ToInt32(coin_2p_return.Text) + 1
                CurrentMoney = CurrentMoney - 0.02
            ElseIf CurrentMoney >= 0.01 Then
                coin_1p_return.Text = Convert.ToInt32(coin_1p_return.Text) + 1
                CurrentMoney = CurrentMoney - 0.01
            End If
        End While
        appendLog("(ReturnCoins) Returned Change")
        ResetMachine()
    End Sub

    Private Sub InsertMoney(money As Decimal)
        CurrentMoney = CurrentMoney + money
        appendLog("(InsertMoney) Inserted " & FormatCurrency(money))
    End Sub

    Private Sub SpendMoney(money As Decimal)
        CurrentMoney = CurrentMoney - money
        appendLog("(SpendMoney) Spent " & FormatCurrency(money))
    End Sub

    Private Sub Runtime_Tick(sender As Object, e As EventArgs) Handles Runtime.Tick

        display_money.Text = FormatCurrency(CurrentMoney)
        pepsi_price.Text = Convert.ToString(FormatCurrency(pepsiPrice))
        coke_price.Text = Convert.ToString(FormatCurrency(cokePrice))
        monster_price.Text = Convert.ToString(FormatCurrency(monsterPrice))
        crisps_price.Text = Convert.ToString(FormatCurrency(crispsPrice))
        dairymilk_price.Text = Convert.ToString(FormatCurrency(dairymilkPrice))
        winegums_price.Text = Convert.ToString(FormatCurrency(winegumsPrice))

        slot1_total_price.Text = Convert.ToString(FormatCurrency(SlotTotalPrice(1)))
        slot2_total_price.Text = Convert.ToString(FormatCurrency(SlotTotalPrice(2)))
        slot3_total_price.Text = Convert.ToString(FormatCurrency(SlotTotalPrice(3)))
        slot4_total_price.Text = Convert.ToString(FormatCurrency(SlotTotalPrice(4)))
        slot5_total_price.Text = Convert.ToString(FormatCurrency(SlotTotalPrice(5)))
        slot6_total_price.Text = Convert.ToString(FormatCurrency(SlotTotalPrice(6)))
        total_price.Text = Convert.ToString(FormatCurrency(TotalPrice))

        pepsi_stock.Text = "Stock: " & GetStockValue(100)
        coke_stock.Text = "Stock: " & GetStockValue(101)
        monster_stock.Text = "Stock: " & GetStockValue(102)
        crisps_stock.Text = "Stock: " & GetStockValue(103)
        dairymilk_stock.Text = "Stock: " & GetStockValue(104)
        winegums_stock.Text = "Stock: " & GetStockValue(105)

        If CurrentMoney = 0 Or Dispensing Then
            main_menu.Visible = False
            coin_cancel_button.Enabled = False
        ElseIf CurrentMoney > 0 Then
            main_menu.Visible = True
            coin_cancel_button.Enabled = True
        End If

        If ChangeAwaitingCollection() Or Not Dispensing Then
            coin_change_collect_button.Enabled = True
        Else
            coin_change_collect_button.Enabled = False
        End If

        If ChangeAwaitingCollection() And ItemsAwaitingCollection() Then
            moneyPrompt.Text = "Please Collect Your Items and Change"
        ElseIf ChangeAwaitingCollection() And Not ItemsAwaitingCollection() Then
            moneyPrompt.Text = "Please Collect Your Change"
        ElseIf Not ChangeAwaitingCollection() And ItemsAwaitingCollection() Then
            moneyPrompt.Text = "Please Collect Your Items"
        Else
            moneyPrompt.Text = "Please Insert Money To Continue"
        End If

        If orderSlot1Count = 0 Or Dispensing Then
            slot1_remove_item.Enabled = False
        Else
            slot1_remove_item.Enabled = True
        End If
        If orderSlot2Count = 0 Or Dispensing Then
            slot2_remove_item.Enabled = False
        Else
            slot2_remove_item.Enabled = True
        End If
        If orderSlot3Count = 0 Or Dispensing Then
            slot3_remove_item.Enabled = False
        Else
            slot3_remove_item.Enabled = True
        End If
        If orderSlot4Count = 0 Or Dispensing Then
            slot4_remove_item.Enabled = False
        Else
            slot4_remove_item.Enabled = True
        End If
        If orderSlot5Count = 0 Or Dispensing Then
            slot5_remove_item.Enabled = False
        Else
            slot5_remove_item.Enabled = True
        End If
        If orderSlot6Count = 0 Or Dispensing Then
            slot6_remove_item.Enabled = False
        Else
            slot6_remove_item.Enabled = True
        End If

        If (TotalPrice() + ValueItemID(orderSlot1ID) > CurrentMoney) Or orderSlot1Count = 0 Or GetStockValue(orderSlot1ID) = 0 Or Dispensing Then
            slot1_add_item.Enabled = False
        Else
            slot1_add_item.Enabled = True
        End If
        If (TotalPrice() + ValueItemID(orderSlot2ID) > CurrentMoney) Or orderSlot2Count = 0 Or GetStockValue(orderSlot2ID) = 0 Or Dispensing Then
            slot2_add_item.Enabled = False
        Else
            slot2_add_item.Enabled = True
        End If
        If (TotalPrice() + ValueItemID(orderSlot3ID) > CurrentMoney) Or orderSlot3Count = 0 Or GetStockValue(orderSlot3ID) = 0 Or Dispensing Then
            slot3_add_item.Enabled = False
        Else
            slot3_add_item.Enabled = True
        End If
        If (TotalPrice() + ValueItemID(orderSlot4ID) > CurrentMoney) Or orderSlot4Count = 0 Or GetStockValue(orderSlot4ID) = 0 Or Dispensing Then
            slot4_add_item.Enabled = False
        Else
            slot4_add_item.Enabled = True
        End If
        If (TotalPrice() + ValueItemID(orderSlot5ID) > CurrentMoney) Or orderSlot5Count = 0 Or GetStockValue(orderSlot5ID) = 0 Or Dispensing Then
            slot5_add_item.Enabled = False
        Else
            slot5_add_item.Enabled = True
        End If
        If (TotalPrice() + ValueItemID(orderSlot6ID) > CurrentMoney) Or orderSlot6Count = 0 Or GetStockValue(orderSlot6ID) = 0 Or Dispensing Then
            slot6_add_item.Enabled = False
        Else
            slot6_add_item.Enabled = True
        End If

        If CurrentMoney = 0 Or TotalPrice() > CurrentMoney Or orderSlot1Count = 0 Or Dispensing Then
            confirm_purchase_button.Enabled = False
        Else
            confirm_purchase_button.Enabled = True
        End If

        If Not dispensed_item1.Text = "" Or Dispensing Then
            items_collect_button.Enabled = True
            coin_1p_insert.Enabled = False
            coin_2p_insert.Enabled = False
            coin_5p_insert.Enabled = False
            coin_10p_insert.Enabled = False
            coin_20p_insert.Enabled = False
            coin_50p_insert.Enabled = False
            coin_100p_insert.Enabled = False
            coin_200p_insert.Enabled = False
        Else
            items_collect_button.Enabled = False
            coin_1p_insert.Enabled = True
            coin_2p_insert.Enabled = True
            coin_5p_insert.Enabled = True
            coin_10p_insert.Enabled = True
            coin_20p_insert.Enabled = True
            coin_50p_insert.Enabled = True
            coin_100p_insert.Enabled = True
            coin_200p_insert.Enabled = True
        End If
        ShiftOrderList()

        If orderSlot1Count > 0 Then
            DispenseModifier = (orderSlot1Count + orderSlot2Count + orderSlot3Count + orderSlot4Count + orderSlot5Count + orderSlot6Count)
        End If

        currentTick = currentTick + 1

        consoleWindow.setRuntimeTick(currentTick)
    End Sub

    Private Function ItemsAwaitingCollection()
        If Not dispensed_item1.Text = "" Then
            Return True
            appendLog("(ItemsAwaitingCollection) Items are awaiting collection")
        Else
            Return False
        End If
    End Function

    Private Function ChangeAwaitingCollection()
        If (Convert.ToInt32(coin_1p_return.Text) + Convert.ToInt32(coin_2p_return.Text) + Convert.ToInt32(coin_5p_return.Text) + Convert.ToInt32(coin_10p_return.Text) + Convert.ToInt32(coin_20p_return.Text) + Convert.ToInt32(coin_50p_return.Text) + Convert.ToInt32(coin_100p_return.Text) + Convert.ToInt32(coin_200p_return.Text)) > 0 Then
            Return True
            appendLog("(ChangeAwaitingCollection) Change is awaiting collection")
        Else
            Return False
        End If
    End Function

    Private Sub PurchaseItems()
        Dispensing = True
        dispense_progress.Value = 0
        DispenseTime.Interval = 10 * DispenseModifier
        DispenseTime.Start()
        appendLog("(PurchaseItems) Items Purchased")
    End Sub

    Dim BarValue As Integer = 0
    Private Sub DispenseTime_Tick(sender As Object, e As EventArgs) Handles DispenseTime.Tick
        BarValue = dispense_progress.Value + 2
        If BarValue > 100 Then
            BarValue = 100
        End If

        dispense_progress.Value = BarValue
        appendLog("(DispenseTime_Tick) Dispensing Items... " & BarValue & "%")

        If dispense_progress.Value = 100 Then
            DispenseTime.Stop()
            DispenseItems()
            Dispensing = False
            appendLog("(DispenseTime_Tick) Items Dispensed")
        End If
    End Sub

    Private Sub DispenseItems()
        dispensed_item1.Text = order_item_1.Text
        dispensed_item2.Text = order_item_2.Text
        dispensed_item3.Text = order_item_3.Text
        dispensed_item4.Text = order_item_4.Text
        dispensed_item5.Text = order_item_5.Text
        dispensed_item6.Text = order_item_6.Text
        SpendMoney(TotalPrice)
        If CurrentMoney > 0 Then
            ReturnCoins()
        End If
    End Sub

    Private Function ConvertItemID(itemID As Integer)
        If itemID = 100 Then
            Return "Pepsi Original"
        ElseIf itemID = 101 Then
            Return "Coca-Cola Original"
        ElseIf itemID = 102 Then
            Return "Monster Energy"
        ElseIf itemID = 103 Then
            Return "Walkers Cheese & Onion"
        ElseIf itemID = 104 Then
            Return "Cadbury Dairy Milk"
        ElseIf itemID = 105 Then
            Return "Maynards Wine Gums"
        Else
            Return "Unregistered Item"
        End If
        appendLog("(ConvertItemID) Converted ID " & itemID)
    End Function

    Private Function ValueItemID(itemID As Integer)
        If itemID = 100 Then
            Return pepsiPrice
        ElseIf itemID = 101 Then
            Return cokePrice
        ElseIf itemID = 102 Then
            Return monsterPrice
        ElseIf itemID = 103 Then
            Return crispsPrice
        ElseIf itemID = 104 Then
            Return dairymilkPrice
        ElseIf itemID = 105 Then
            Return winegumsPrice
        Else
            Return 0
        End If
        appendLog("(ValueItemID) Valued ID " & itemID)
    End Function

    Private Sub UpdateOrder()
        If orderSlot1Count = 0 And Not order_item_1.Text = "" Then
            order_item_1.Text = ""
            orderSlot1ID = 0
            appendLog("(UpdateOrder) Erased orderSlot1")
        ElseIf orderSlot1ID > 0 And Not order_item_1.Text = orderSlot1Count & "x " & ConvertItemID(orderSlot1ID) Then
            order_item_1.Text = orderSlot1Count & "x " & ConvertItemID(orderSlot1ID)
            appendLog("(UpdateOrder) Set orderSlot1 to ID " & orderSlot1ID & " with " & orderSlot1Count & " count")
        End If
        If orderSlot2Count = 0 And Not order_item_2.Text = "" Then
            order_item_2.Text = ""
            orderSlot2ID = 0
            appendLog("(UpdateOrder) Erased orderSlot2")
        ElseIf orderSlot2ID > 0 And Not order_item_2.Text = orderSlot2Count & "x " & ConvertItemID(orderSlot2ID) Then
            order_item_2.Text = orderSlot2Count & "x " & ConvertItemID(orderSlot2ID)
            appendLog("(UpdateOrder) Set orderSlot2 to ID " & orderSlot2ID & " with " & orderSlot2Count & " count")
        End If
        If orderSlot3Count = 0 And Not order_item_3.Text = "" Then
            order_item_3.Text = ""
            orderSlot3ID = 0
            appendLog("(UpdateOrder) Erased orderSlot3")
        ElseIf orderSlot3ID > 0 And Not order_item_3.Text = orderSlot3Count & "x " & ConvertItemID(orderSlot3ID) Then
            order_item_3.Text = orderSlot3Count & "x " & ConvertItemID(orderSlot3ID)
            appendLog("(UpdateOrder) Set orderSlot3 to ID " & orderSlot3ID & " with " & orderSlot3Count & " count")
        End If
        If orderSlot4Count = 0 And Not order_item_4.Text = "" Then
            order_item_4.Text = ""
            orderSlot4ID = 0
            appendLog("(UpdateOrder) Erased orderSlot4")
        ElseIf orderSlot4ID > 0 And Not order_item_4.Text = orderSlot4Count & "x " & ConvertItemID(orderSlot4ID) Then
            order_item_4.Text = orderSlot4Count & "x " & ConvertItemID(orderSlot4ID)
            appendLog("(UpdateOrder) Set orderSlot4 to OID " & orderSlot4ID & " with " & orderSlot4Count & " count")
        End If
        If orderSlot5Count = 0 And Not order_item_5.Text = "" Then
            order_item_5.Text = ""
            orderSlot5ID = 0
            appendLog("(UpdateOrder) Erased orderSlot5")
        ElseIf orderSlot5ID > 0 And Not order_item_5.Text = orderSlot5Count & "x " & ConvertItemID(orderSlot5ID) Then
            order_item_5.Text = orderSlot5Count & "x " & ConvertItemID(orderSlot5ID)
            appendLog("(UpdateOrder) Set orderSlot5 to ID " & orderSlot5ID & " with " & orderSlot5Count & " count")
        End If
        If orderSlot6Count = 0 And Not order_item_6.Text = "" Then
            order_item_6.Text = ""
            orderSlot6ID = 0
            appendLog("(UpdateOrder) Erased orderSlot6")
        ElseIf orderSlot6ID > 0 And Not order_item_6.Text = orderSlot6Count & "x " & ConvertItemID(orderSlot6ID) Then
            order_item_6.Text = orderSlot6Count & "x " & ConvertItemID(orderSlot6ID)
            appendLog("(UpdateOrder) Set orderSlot6 to ID " & orderSlot6ID & " with " & orderSlot6Count & " count")
        End If
    End Sub

    Private Function GetStockValue(itemID As Integer)
        If itemID = 100 Then
            Return pepsiStock
        ElseIf itemID = 101 Then
            Return cokeStock
        ElseIf itemID = 102 Then
            Return monsterStock
        ElseIf itemID = 103 Then
            Return crispsStock
        ElseIf itemID = 104 Then
            Return dairymilkStock
        ElseIf itemID = 105 Then
            Return winegumsStock
        Else
            Return 0
        End If
        appendLog("(GetStockValue) Got stock value of ID" & itemID)
    End Function

    Private Sub AddStock(itemID As Integer)
        If itemID = 100 Then
            pepsiStock = pepsiStock + 1
        ElseIf itemID = 101 Then
            cokeStock = cokeStock + 1
        ElseIf itemID = 102 Then
            monsterStock = monsterStock + 1
        ElseIf itemID = 103 Then
            crispsStock = crispsStock + 1
        ElseIf itemID = 104 Then
            dairymilkStock = dairymilkStock + 1
        ElseIf itemID = 105 Then
            winegumsStock = winegumsStock + 1
        End If
        appendLog("(AddStock) Added 1 stock of ID" & itemID)
    End Sub

    Private Sub RemoveStock(itemID As Integer)
        If itemID = 100 Then
            pepsiStock = pepsiStock - 1
        ElseIf itemID = 101 Then
            cokeStock = cokeStock - 1
        ElseIf itemID = 102 Then
            monsterStock = monsterStock - 1
        ElseIf itemID = 103 Then
            crispsStock = crispsStock - 1
        ElseIf itemID = 104 Then
            dairymilkStock = dairymilkStock - 1
        ElseIf itemID = 105 Then
            winegumsStock = winegumsStock - 1
        End If
        appendLog("(RemoveStock) Removed 1 stock of ID" & itemID)
    End Sub

    Private Sub AddItemOrder(itemID As Integer)
        If GetStockValue(itemID) > 0 Then
            If orderSlot1ID = 0 Or orderSlot1ID = itemID Then
                orderSlot1Count = orderSlot1Count + 1
                orderSlot1ID = itemID
            ElseIf orderSlot2ID = 0 Or orderSlot2ID = itemID Then
                orderSlot2Count = orderSlot2Count + 1
                orderSlot2ID = itemID
            ElseIf orderSlot3ID = 0 Or orderSlot3ID = itemID Then
                orderSlot3Count = orderSlot3Count + 1
                orderSlot3ID = itemID
            ElseIf orderSlot4ID = 0 Or orderSlot4ID = itemID Then
                orderSlot4Count = orderSlot4Count + 1
                orderSlot4ID = itemID
            ElseIf orderSlot5ID = 0 Or orderSlot5ID = itemID Then
                orderSlot5Count = orderSlot5Count + 1
                orderSlot5ID = itemID
            ElseIf orderSlot6ID = 0 Or orderSlot6ID = itemID Then
                orderSlot6Count = orderSlot6Count + 1
                orderSlot6ID = itemID
            End If
            appendLog("(AddItemOrder) Added 1 of ID" & itemID & " to order")
            UpdateOrder()
            RemoveStock(itemID)
        End If

    End Sub

    Private Sub RemoveItemOrder(slot As Integer)
        If slot = 1 And orderSlot1Count > 0 Then
            orderSlot1Count = orderSlot1Count - 1
            AddStock(orderSlot1ID)
        ElseIf slot = 2 And orderSlot2Count > 0 Then
            orderSlot2Count = orderSlot2Count - 1
            AddStock(orderSlot2ID)
        ElseIf slot = 3 And orderSlot3Count > 0 Then
            orderSlot3Count = orderSlot3Count - 1
            AddStock(orderSlot3ID)
        ElseIf slot = 4 And orderSlot4Count > 0 Then
            orderSlot4Count = orderSlot4Count - 1
            AddStock(orderSlot4ID)
        ElseIf slot = 5 And orderSlot5Count > 0 Then
            orderSlot5Count = orderSlot5Count - 1
            AddStock(orderSlot5ID)
        ElseIf slot = 6 And orderSlot6Count > 0 Then
            orderSlot6Count = orderSlot6Count - 1
            AddStock(orderSlot6ID)
        End If
        appendLog("(RemoveItemOrder) Removed 1 from item slot" & slot & " from order")
        UpdateOrder()
    End Sub

    Private Function SlotTotalPrice(slot As Integer)
        If slot = 1 And orderSlot1ID > 0 Then
            Return ValueItemID(orderSlot1ID) * orderSlot1Count
        ElseIf slot = 2 And orderSlot2ID > 0 Then
            Return ValueItemID(orderSlot2ID) * orderSlot2Count
        ElseIf slot = 3 And orderSlot3ID > 0 Then
            Return ValueItemID(orderSlot3ID) * orderSlot3Count
        ElseIf slot = 4 And orderSlot4ID > 0 Then
            Return ValueItemID(orderSlot4ID) * orderSlot4Count
        ElseIf slot = 5 And orderSlot5ID > 0 Then
            Return ValueItemID(orderSlot5ID) * orderSlot5Count
        ElseIf slot = 6 And orderSlot1ID > 0 Then
            Return ValueItemID(orderSlot6ID) * orderSlot6Count
        Else
            Return 0
        End If
    End Function

    Private Sub ShiftOrderList()
        If Not orderSlot6ID = 0 And orderSlot5ID = 0 Then
            orderSlot5ID = orderSlot6ID
            orderSlot5Count = orderSlot6Count
            orderSlot6ID = 0
            orderSlot6Count = 0
            appendLog("(ShiftOrderList) Shifted ID " & orderSlot6ID & " from slot 6 to slot 5")
        End If
        If Not orderSlot5ID = 0 And orderSlot4ID = 0 Then
            orderSlot4ID = orderSlot5ID
            orderSlot4Count = orderSlot5Count
            orderSlot5ID = 0
            orderSlot5Count = 0
            appendLog("(ShiftOrderList) Shifted ID " & orderSlot5ID & " from slot 5 to slot 4")
        End If
        If Not orderSlot4ID = 0 And orderSlot3ID = 0 Then
            orderSlot3ID = orderSlot4ID
            orderSlot3Count = orderSlot4Count
            orderSlot4ID = 0
            orderSlot4Count = 0
            appendLog("(ShiftOrderList) Shifted ID " & orderSlot4ID & " from slot 4 to slot 3")
        End If
        If Not orderSlot3ID = 0 And orderSlot2ID = 0 Then
            orderSlot2ID = orderSlot3ID
            orderSlot2Count = orderSlot3Count
            orderSlot3ID = 0
            orderSlot3Count = 0
            appendLog("(ShiftOrderList) Shifted ID " & orderSlot3ID & " from slot 3 to slot 2")
        End If
        If Not orderSlot2ID = 0 And orderSlot1ID = 0 Then
            orderSlot1ID = orderSlot2ID
            orderSlot1Count = orderSlot2Count
            orderSlot2ID = 0
            orderSlot2Count = 0
            appendLog("(ShiftOrderList) Shifted ID " & orderSlot2ID & " from slot 2 to slot 1")
        End If
        UpdateOrder()
    End Sub

    Private Function TotalPrice()
        Return SlotTotalPrice(1) + SlotTotalPrice(2) + SlotTotalPrice(3) + SlotTotalPrice(4) + SlotTotalPrice(5) + SlotTotalPrice(6)
    End Function


    'UI Handler

    Private Sub coin_1p_insert_Click(sender As Object, e As EventArgs) Handles coin_1p_insert.Click
        InsertMoney(0.01)
    End Sub

    Private Sub coin_2p_insert_Click(sender As Object, e As EventArgs) Handles coin_2p_insert.Click
        InsertMoney(0.02)
    End Sub

    Private Sub coin_5p_insert_Click(sender As Object, e As EventArgs) Handles coin_5p_insert.Click
        InsertMoney(0.05)
    End Sub

    Private Sub coin_10p_insert_Click(sender As Object, e As EventArgs) Handles coin_10p_insert.Click
        InsertMoney(0.1)
    End Sub

    Private Sub coin_20p_insert_Click(sender As Object, e As EventArgs) Handles coin_20p_insert.Click
        InsertMoney(0.2)
    End Sub

    Private Sub coin_50p_insert_Click(sender As Object, e As EventArgs) Handles coin_50p_insert.Click
        InsertMoney(0.5)
    End Sub

    Private Sub coin_100p_insert_Click(sender As Object, e As EventArgs) Handles coin_100p_insert.Click
        InsertMoney(1)
    End Sub

    Private Sub coin_200p_insert_Click(sender As Object, e As EventArgs) Handles coin_200p_insert.Click
        InsertMoney(2)
    End Sub

    Private Sub coin_return_button_Click(sender As Object, e As EventArgs) Handles coin_cancel_button.Click
        ReturnCoins()
    End Sub

    Private Sub VendingMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitMachine()
    End Sub

    Private Sub coin_change_collect_button_Click(sender As Object, e As EventArgs) Handles coin_change_collect_button.Click
        appendLog("(ChangeCollect) Change collected")
        InitMachine()
    End Sub

    Private Sub pepsi_button_Click(sender As Object, e As EventArgs) Handles pepsi_button.Click
        If Not (TotalPrice() + ValueItemID(100) > CurrentMoney) Then
            AddItemOrder(100)
        End If
    End Sub

    Private Sub coke_button_Click(sender As Object, e As EventArgs) Handles coke_button.Click
        If Not (TotalPrice() + ValueItemID(101) > CurrentMoney) Then
            AddItemOrder(101)
        End If
    End Sub

    Private Sub monster_button_Click(sender As Object, e As EventArgs) Handles monster_button.Click
        If Not (TotalPrice() + ValueItemID(102) > CurrentMoney) Then
            AddItemOrder(102)
        End If
    End Sub

    Private Sub crisps_button_Click(sender As Object, e As EventArgs) Handles crisps_button.Click
        If Not (TotalPrice() + ValueItemID(103) > CurrentMoney) Then
            AddItemOrder(103)
        End If
    End Sub

    Private Sub dairymilk_button_Click(sender As Object, e As EventArgs) Handles dairymilk_button.Click
        If Not (TotalPrice() + ValueItemID(104) > CurrentMoney) Then
            AddItemOrder(104)
        End If
    End Sub

    Private Sub winegums_button_Click(sender As Object, e As EventArgs) Handles winegums_button.Click
        If Not (TotalPrice() + ValueItemID(105) > CurrentMoney) Then
            AddItemOrder(105)
        End If
    End Sub

    Private Sub slot1_add_item_Click(sender As Object, e As EventArgs) Handles slot1_add_item.Click
        If orderSlot1ID > 0 And Not (TotalPrice() + ValueItemID(orderSlot1ID) > CurrentMoney) Then
            AddItemOrder(orderSlot1ID)
        End If
    End Sub

    Private Sub slot2_add_item_Click(sender As Object, e As EventArgs) Handles slot2_add_item.Click
        If orderSlot2ID > 0 And Not (TotalPrice() + ValueItemID(orderSlot2ID) > CurrentMoney) Then
            AddItemOrder(orderSlot2ID)
        End If
    End Sub

    Private Sub slot3_add_item_Click(sender As Object, e As EventArgs) Handles slot3_add_item.Click
        If orderSlot3ID > 0 And Not (TotalPrice() + ValueItemID(orderSlot3ID) > CurrentMoney) Then
            AddItemOrder(orderSlot3ID)
        End If
    End Sub

    Private Sub slot4_add_item_Click(sender As Object, e As EventArgs) Handles slot4_add_item.Click
        If orderSlot4ID > 0 And Not (TotalPrice() + ValueItemID(orderSlot4ID) > CurrentMoney) Then
            AddItemOrder(orderSlot4ID)
        End If
    End Sub

    Private Sub slot5_add_item_Click(sender As Object, e As EventArgs) Handles slot5_add_item.Click
        If orderSlot5ID > 0 And Not (TotalPrice() + ValueItemID(orderSlot5ID) > CurrentMoney) Then
            AddItemOrder(orderSlot5ID)
        End If
    End Sub

    Private Sub slot6_add_item_Click(sender As Object, e As EventArgs) Handles slot6_add_item.Click
        If orderSlot6ID > 0 And Not (TotalPrice() + ValueItemID(orderSlot6ID) > CurrentMoney) Then
            AddItemOrder(orderSlot6ID)
        End If
    End Sub

    Private Sub slot1_remove_item_Click(sender As Object, e As EventArgs) Handles slot1_remove_item.Click
        RemoveItemOrder(1)
    End Sub

    Private Sub slot2_remove_item_Click(sender As Object, e As EventArgs) Handles slot2_remove_item.Click
        RemoveItemOrder(2)
    End Sub

    Private Sub slot3_remove_item_Click(sender As Object, e As EventArgs) Handles slot3_remove_item.Click
        RemoveItemOrder(3)
    End Sub

    Private Sub slot4_remove_item_Click(sender As Object, e As EventArgs) Handles slot4_remove_item.Click
        RemoveItemOrder(4)
    End Sub

    Private Sub slot5_remove_item_Click(sender As Object, e As EventArgs) Handles slot5_remove_item.Click
        RemoveItemOrder(5)
    End Sub

    Private Sub slot6_remove_item_Click(sender As Object, e As EventArgs) Handles slot6_remove_item.Click
        RemoveItemOrder(6)
    End Sub

    Private Sub confirm_purchase_button_Click(sender As Object, e As EventArgs) Handles confirm_purchase_button.Click
        PurchaseItems()
    End Sub

    Private Sub items_collect_button_Click(sender As Object, e As EventArgs) Handles items_collect_button.Click
        dispensed_item1.Text = ""
        dispensed_item2.Text = ""
        dispensed_item3.Text = ""
        dispensed_item4.Text = ""
        dispensed_item5.Text = ""
        dispensed_item6.Text = ""
        dispense_progress.Value = 0
        appendLog("(ItemsCollect) Items Collected")
    End Sub

    Private Sub version_Click(sender As Object, e As EventArgs) Handles version.Click
        Toolbar.Visible = Not Toolbar.Visible
    End Sub

    Private Sub RefillStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefillStockToolStripMenuItem.Click
        pepsiStock = 100
        cokeStock = 100
        crispsStock = 100
        dairymilkStock = 100
        winegumsStock = 100

        appendLog("(Debug - RefillStock) Refilled all stock to 100 each")
    End Sub

    Private Sub ConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsoleToolStripMenuItem.Click
        consoleWindow.Visible = Not consoleWindow.Visible
    End Sub

End Class
