<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendingMachine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendingMachine))
        Me.CoinBox = New System.Windows.Forms.GroupBox()
        Me.display_money = New System.Windows.Forms.TextBox()
        Me.coin_200p_insert = New System.Windows.Forms.Button()
        Me.coin_100p_insert = New System.Windows.Forms.Button()
        Me.coin_50p_insert = New System.Windows.Forms.Button()
        Me.coin_20p_insert = New System.Windows.Forms.Button()
        Me.coin_10p_insert = New System.Windows.Forms.Button()
        Me.coin_5p_insert = New System.Windows.Forms.Button()
        Me.coin_2p_insert = New System.Windows.Forms.Button()
        Me.coin_1p_insert = New System.Windows.Forms.Button()
        Me.ChangeBox = New System.Windows.Forms.GroupBox()
        Me.coin_change_collect_button = New System.Windows.Forms.Button()
        Me.coin_200p_return_label = New System.Windows.Forms.Label()
        Me.coin_200p_return = New System.Windows.Forms.TextBox()
        Me.coin_100p_return_label = New System.Windows.Forms.Label()
        Me.coin_100p_return = New System.Windows.Forms.TextBox()
        Me.coin_50p_return_label = New System.Windows.Forms.Label()
        Me.coin_50p_return = New System.Windows.Forms.TextBox()
        Me.coin_20p_return_label = New System.Windows.Forms.Label()
        Me.coin_20p_return = New System.Windows.Forms.TextBox()
        Me.coin_10p_return_label = New System.Windows.Forms.Label()
        Me.coin_10p_return = New System.Windows.Forms.TextBox()
        Me.coin_5p_return_label = New System.Windows.Forms.Label()
        Me.coin_5p_return = New System.Windows.Forms.TextBox()
        Me.coin_2p_return_label = New System.Windows.Forms.Label()
        Me.coin_2p_return = New System.Windows.Forms.TextBox()
        Me.coin_1p_return_label = New System.Windows.Forms.Label()
        Me.coin_1p_return = New System.Windows.Forms.TextBox()
        Me.coin_cancel_button = New System.Windows.Forms.Button()
        Me.Runtime = New System.Windows.Forms.Timer(Me.components)
        Me.main_menu = New System.Windows.Forms.GroupBox()
        Me.winegums_stock = New System.Windows.Forms.Label()
        Me.winegums_price = New System.Windows.Forms.Label()
        Me.winegums_button = New System.Windows.Forms.PictureBox()
        Me.dairymilk_stock = New System.Windows.Forms.Label()
        Me.dairymilk_price = New System.Windows.Forms.Label()
        Me.dairymilk_button = New System.Windows.Forms.PictureBox()
        Me.crisps_stock = New System.Windows.Forms.Label()
        Me.crisps_price = New System.Windows.Forms.Label()
        Me.crisps_button = New System.Windows.Forms.PictureBox()
        Me.coke_stock = New System.Windows.Forms.Label()
        Me.pepsi_stock = New System.Windows.Forms.Label()
        Me.monster_stock = New System.Windows.Forms.Label()
        Me.monster_price = New System.Windows.Forms.Label()
        Me.monster_button = New System.Windows.Forms.PictureBox()
        Me.coke_price = New System.Windows.Forms.Label()
        Me.pepsi_price = New System.Windows.Forms.Label()
        Me.coke_button = New System.Windows.Forms.PictureBox()
        Me.pepsi_button = New System.Windows.Forms.PictureBox()
        Me.order_menu = New System.Windows.Forms.GroupBox()
        Me.total_price = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.slot6_total_price = New System.Windows.Forms.TextBox()
        Me.slot5_total_price = New System.Windows.Forms.TextBox()
        Me.slot4_total_price = New System.Windows.Forms.TextBox()
        Me.slot3_total_price = New System.Windows.Forms.TextBox()
        Me.slot2_total_price = New System.Windows.Forms.TextBox()
        Me.slot1_total_price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.slot6_add_item = New System.Windows.Forms.Button()
        Me.slot5_add_item = New System.Windows.Forms.Button()
        Me.slot4_add_item = New System.Windows.Forms.Button()
        Me.slot3_add_item = New System.Windows.Forms.Button()
        Me.slot2_add_item = New System.Windows.Forms.Button()
        Me.slot1_add_item = New System.Windows.Forms.Button()
        Me.slot6_remove_item = New System.Windows.Forms.Button()
        Me.slot5_remove_item = New System.Windows.Forms.Button()
        Me.slot4_remove_item = New System.Windows.Forms.Button()
        Me.slot3_remove_item = New System.Windows.Forms.Button()
        Me.slot2_remove_item = New System.Windows.Forms.Button()
        Me.slot1_remove_item = New System.Windows.Forms.Button()
        Me.order_item_6 = New System.Windows.Forms.TextBox()
        Me.order_item_5 = New System.Windows.Forms.TextBox()
        Me.order_item_4 = New System.Windows.Forms.TextBox()
        Me.order_item_3 = New System.Windows.Forms.TextBox()
        Me.order_item_2 = New System.Windows.Forms.TextBox()
        Me.order_item_1 = New System.Windows.Forms.TextBox()
        Me.confirm_purchase_button = New System.Windows.Forms.Button()
        Me.moneyPrompt = New System.Windows.Forms.Label()
        Me.dispensed_items_tray = New System.Windows.Forms.GroupBox()
        Me.items_collect_button = New System.Windows.Forms.Button()
        Me.dispensed_item6 = New System.Windows.Forms.TextBox()
        Me.dispensed_item5 = New System.Windows.Forms.TextBox()
        Me.dispensed_item4 = New System.Windows.Forms.TextBox()
        Me.dispensed_item3 = New System.Windows.Forms.TextBox()
        Me.dispensed_item2 = New System.Windows.Forms.TextBox()
        Me.dispensed_item1 = New System.Windows.Forms.TextBox()
        Me.version = New System.Windows.Forms.Label()
        Me.CoinBox.SuspendLayout()
        Me.ChangeBox.SuspendLayout()
        Me.main_menu.SuspendLayout()
        CType(Me.winegums_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dairymilk_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crisps_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monster_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coke_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pepsi_button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.order_menu.SuspendLayout()
        Me.dispensed_items_tray.SuspendLayout()
        Me.SuspendLayout()
        '
        'CoinBox
        '
        Me.CoinBox.Controls.Add(Me.display_money)
        Me.CoinBox.Controls.Add(Me.coin_200p_insert)
        Me.CoinBox.Controls.Add(Me.coin_100p_insert)
        Me.CoinBox.Controls.Add(Me.coin_50p_insert)
        Me.CoinBox.Controls.Add(Me.coin_20p_insert)
        Me.CoinBox.Controls.Add(Me.coin_10p_insert)
        Me.CoinBox.Controls.Add(Me.coin_5p_insert)
        Me.CoinBox.Controls.Add(Me.coin_2p_insert)
        Me.CoinBox.Controls.Add(Me.coin_1p_insert)
        Me.CoinBox.Controls.Add(Me.ChangeBox)
        Me.CoinBox.Location = New System.Drawing.Point(680, 12)
        Me.CoinBox.Name = "CoinBox"
        Me.CoinBox.Size = New System.Drawing.Size(208, 567)
        Me.CoinBox.TabIndex = 0
        Me.CoinBox.TabStop = False
        Me.CoinBox.Text = "Coins"
        '
        'display_money
        '
        Me.display_money.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display_money.Location = New System.Drawing.Point(55, 31)
        Me.display_money.Name = "display_money"
        Me.display_money.ReadOnly = True
        Me.display_money.Size = New System.Drawing.Size(99, 30)
        Me.display_money.TabIndex = 9
        Me.display_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'coin_200p_insert
        '
        Me.coin_200p_insert.Location = New System.Drawing.Point(108, 204)
        Me.coin_200p_insert.Name = "coin_200p_insert"
        Me.coin_200p_insert.Size = New System.Drawing.Size(94, 31)
        Me.coin_200p_insert.TabIndex = 8
        Me.coin_200p_insert.Text = "£2"
        Me.coin_200p_insert.UseVisualStyleBackColor = True
        '
        'coin_100p_insert
        '
        Me.coin_100p_insert.Location = New System.Drawing.Point(6, 204)
        Me.coin_100p_insert.Name = "coin_100p_insert"
        Me.coin_100p_insert.Size = New System.Drawing.Size(94, 31)
        Me.coin_100p_insert.TabIndex = 7
        Me.coin_100p_insert.Text = "£1"
        Me.coin_100p_insert.UseVisualStyleBackColor = True
        '
        'coin_50p_insert
        '
        Me.coin_50p_insert.Location = New System.Drawing.Point(108, 167)
        Me.coin_50p_insert.Name = "coin_50p_insert"
        Me.coin_50p_insert.Size = New System.Drawing.Size(94, 31)
        Me.coin_50p_insert.TabIndex = 6
        Me.coin_50p_insert.Text = "50p"
        Me.coin_50p_insert.UseVisualStyleBackColor = True
        '
        'coin_20p_insert
        '
        Me.coin_20p_insert.Location = New System.Drawing.Point(6, 167)
        Me.coin_20p_insert.Name = "coin_20p_insert"
        Me.coin_20p_insert.Size = New System.Drawing.Size(94, 31)
        Me.coin_20p_insert.TabIndex = 5
        Me.coin_20p_insert.Text = "20p"
        Me.coin_20p_insert.UseVisualStyleBackColor = True
        '
        'coin_10p_insert
        '
        Me.coin_10p_insert.Location = New System.Drawing.Point(108, 130)
        Me.coin_10p_insert.Name = "coin_10p_insert"
        Me.coin_10p_insert.Size = New System.Drawing.Size(94, 31)
        Me.coin_10p_insert.TabIndex = 4
        Me.coin_10p_insert.Text = "10p"
        Me.coin_10p_insert.UseVisualStyleBackColor = True
        '
        'coin_5p_insert
        '
        Me.coin_5p_insert.Location = New System.Drawing.Point(6, 130)
        Me.coin_5p_insert.Name = "coin_5p_insert"
        Me.coin_5p_insert.Size = New System.Drawing.Size(94, 31)
        Me.coin_5p_insert.TabIndex = 3
        Me.coin_5p_insert.Text = "5p"
        Me.coin_5p_insert.UseVisualStyleBackColor = True
        '
        'coin_2p_insert
        '
        Me.coin_2p_insert.Location = New System.Drawing.Point(108, 93)
        Me.coin_2p_insert.Name = "coin_2p_insert"
        Me.coin_2p_insert.Size = New System.Drawing.Size(94, 31)
        Me.coin_2p_insert.TabIndex = 2
        Me.coin_2p_insert.Text = "2p"
        Me.coin_2p_insert.UseVisualStyleBackColor = True
        '
        'coin_1p_insert
        '
        Me.coin_1p_insert.Location = New System.Drawing.Point(6, 93)
        Me.coin_1p_insert.Name = "coin_1p_insert"
        Me.coin_1p_insert.Size = New System.Drawing.Size(94, 31)
        Me.coin_1p_insert.TabIndex = 1
        Me.coin_1p_insert.Text = "1p"
        Me.coin_1p_insert.UseVisualStyleBackColor = True
        '
        'ChangeBox
        '
        Me.ChangeBox.Controls.Add(Me.coin_change_collect_button)
        Me.ChangeBox.Controls.Add(Me.coin_200p_return_label)
        Me.ChangeBox.Controls.Add(Me.coin_200p_return)
        Me.ChangeBox.Controls.Add(Me.coin_100p_return_label)
        Me.ChangeBox.Controls.Add(Me.coin_100p_return)
        Me.ChangeBox.Controls.Add(Me.coin_50p_return_label)
        Me.ChangeBox.Controls.Add(Me.coin_50p_return)
        Me.ChangeBox.Controls.Add(Me.coin_20p_return_label)
        Me.ChangeBox.Controls.Add(Me.coin_20p_return)
        Me.ChangeBox.Controls.Add(Me.coin_10p_return_label)
        Me.ChangeBox.Controls.Add(Me.coin_10p_return)
        Me.ChangeBox.Controls.Add(Me.coin_5p_return_label)
        Me.ChangeBox.Controls.Add(Me.coin_5p_return)
        Me.ChangeBox.Controls.Add(Me.coin_2p_return_label)
        Me.ChangeBox.Controls.Add(Me.coin_2p_return)
        Me.ChangeBox.Controls.Add(Me.coin_1p_return_label)
        Me.ChangeBox.Controls.Add(Me.coin_1p_return)
        Me.ChangeBox.Location = New System.Drawing.Point(6, 291)
        Me.ChangeBox.Name = "ChangeBox"
        Me.ChangeBox.Size = New System.Drawing.Size(195, 270)
        Me.ChangeBox.TabIndex = 0
        Me.ChangeBox.TabStop = False
        Me.ChangeBox.Text = "Change"
        '
        'coin_change_collect_button
        '
        Me.coin_change_collect_button.Enabled = False
        Me.coin_change_collect_button.Location = New System.Drawing.Point(95, 224)
        Me.coin_change_collect_button.Name = "coin_change_collect_button"
        Me.coin_change_collect_button.Size = New System.Drawing.Size(94, 31)
        Me.coin_change_collect_button.TabIndex = 16
        Me.coin_change_collect_button.Text = "Collect Change"
        Me.coin_change_collect_button.UseVisualStyleBackColor = True
        '
        'coin_200p_return_label
        '
        Me.coin_200p_return_label.AutoSize = True
        Me.coin_200p_return_label.Location = New System.Drawing.Point(49, 220)
        Me.coin_200p_return_label.Name = "coin_200p_return_label"
        Me.coin_200p_return_label.Size = New System.Drawing.Size(26, 13)
        Me.coin_200p_return_label.TabIndex = 15
        Me.coin_200p_return_label.Text = "£2's"
        '
        'coin_200p_return
        '
        Me.coin_200p_return.Location = New System.Drawing.Point(15, 217)
        Me.coin_200p_return.Name = "coin_200p_return"
        Me.coin_200p_return.ReadOnly = True
        Me.coin_200p_return.Size = New System.Drawing.Size(34, 20)
        Me.coin_200p_return.TabIndex = 14
        Me.coin_200p_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'coin_100p_return_label
        '
        Me.coin_100p_return_label.AutoSize = True
        Me.coin_100p_return_label.Location = New System.Drawing.Point(49, 194)
        Me.coin_100p_return_label.Name = "coin_100p_return_label"
        Me.coin_100p_return_label.Size = New System.Drawing.Size(26, 13)
        Me.coin_100p_return_label.TabIndex = 13
        Me.coin_100p_return_label.Text = "£1's"
        '
        'coin_100p_return
        '
        Me.coin_100p_return.Location = New System.Drawing.Point(15, 191)
        Me.coin_100p_return.Name = "coin_100p_return"
        Me.coin_100p_return.ReadOnly = True
        Me.coin_100p_return.Size = New System.Drawing.Size(34, 20)
        Me.coin_100p_return.TabIndex = 12
        Me.coin_100p_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'coin_50p_return_label
        '
        Me.coin_50p_return_label.AutoSize = True
        Me.coin_50p_return_label.Location = New System.Drawing.Point(49, 168)
        Me.coin_50p_return_label.Name = "coin_50p_return_label"
        Me.coin_50p_return_label.Size = New System.Drawing.Size(32, 13)
        Me.coin_50p_return_label.TabIndex = 11
        Me.coin_50p_return_label.Text = "50p's"
        '
        'coin_50p_return
        '
        Me.coin_50p_return.Location = New System.Drawing.Point(15, 165)
        Me.coin_50p_return.Name = "coin_50p_return"
        Me.coin_50p_return.ReadOnly = True
        Me.coin_50p_return.Size = New System.Drawing.Size(34, 20)
        Me.coin_50p_return.TabIndex = 10
        Me.coin_50p_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'coin_20p_return_label
        '
        Me.coin_20p_return_label.AutoSize = True
        Me.coin_20p_return_label.Location = New System.Drawing.Point(49, 142)
        Me.coin_20p_return_label.Name = "coin_20p_return_label"
        Me.coin_20p_return_label.Size = New System.Drawing.Size(32, 13)
        Me.coin_20p_return_label.TabIndex = 9
        Me.coin_20p_return_label.Text = "20p's"
        '
        'coin_20p_return
        '
        Me.coin_20p_return.Location = New System.Drawing.Point(15, 139)
        Me.coin_20p_return.Name = "coin_20p_return"
        Me.coin_20p_return.ReadOnly = True
        Me.coin_20p_return.Size = New System.Drawing.Size(34, 20)
        Me.coin_20p_return.TabIndex = 8
        Me.coin_20p_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'coin_10p_return_label
        '
        Me.coin_10p_return_label.AutoSize = True
        Me.coin_10p_return_label.Location = New System.Drawing.Point(49, 116)
        Me.coin_10p_return_label.Name = "coin_10p_return_label"
        Me.coin_10p_return_label.Size = New System.Drawing.Size(32, 13)
        Me.coin_10p_return_label.TabIndex = 7
        Me.coin_10p_return_label.Text = "10p's"
        '
        'coin_10p_return
        '
        Me.coin_10p_return.Location = New System.Drawing.Point(15, 113)
        Me.coin_10p_return.Name = "coin_10p_return"
        Me.coin_10p_return.ReadOnly = True
        Me.coin_10p_return.Size = New System.Drawing.Size(34, 20)
        Me.coin_10p_return.TabIndex = 6
        Me.coin_10p_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'coin_5p_return_label
        '
        Me.coin_5p_return_label.AutoSize = True
        Me.coin_5p_return_label.Location = New System.Drawing.Point(49, 90)
        Me.coin_5p_return_label.Name = "coin_5p_return_label"
        Me.coin_5p_return_label.Size = New System.Drawing.Size(26, 13)
        Me.coin_5p_return_label.TabIndex = 5
        Me.coin_5p_return_label.Text = "5p's"
        '
        'coin_5p_return
        '
        Me.coin_5p_return.Location = New System.Drawing.Point(15, 87)
        Me.coin_5p_return.Name = "coin_5p_return"
        Me.coin_5p_return.ReadOnly = True
        Me.coin_5p_return.Size = New System.Drawing.Size(34, 20)
        Me.coin_5p_return.TabIndex = 4
        Me.coin_5p_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'coin_2p_return_label
        '
        Me.coin_2p_return_label.AutoSize = True
        Me.coin_2p_return_label.Location = New System.Drawing.Point(49, 64)
        Me.coin_2p_return_label.Name = "coin_2p_return_label"
        Me.coin_2p_return_label.Size = New System.Drawing.Size(26, 13)
        Me.coin_2p_return_label.TabIndex = 3
        Me.coin_2p_return_label.Text = "2p's"
        '
        'coin_2p_return
        '
        Me.coin_2p_return.Location = New System.Drawing.Point(15, 61)
        Me.coin_2p_return.Name = "coin_2p_return"
        Me.coin_2p_return.ReadOnly = True
        Me.coin_2p_return.Size = New System.Drawing.Size(34, 20)
        Me.coin_2p_return.TabIndex = 2
        Me.coin_2p_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'coin_1p_return_label
        '
        Me.coin_1p_return_label.AutoSize = True
        Me.coin_1p_return_label.Location = New System.Drawing.Point(49, 38)
        Me.coin_1p_return_label.Name = "coin_1p_return_label"
        Me.coin_1p_return_label.Size = New System.Drawing.Size(26, 13)
        Me.coin_1p_return_label.TabIndex = 1
        Me.coin_1p_return_label.Text = "1p's"
        '
        'coin_1p_return
        '
        Me.coin_1p_return.Location = New System.Drawing.Point(15, 35)
        Me.coin_1p_return.Name = "coin_1p_return"
        Me.coin_1p_return.ReadOnly = True
        Me.coin_1p_return.Size = New System.Drawing.Size(34, 20)
        Me.coin_1p_return.TabIndex = 0
        Me.coin_1p_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'coin_cancel_button
        '
        Me.coin_cancel_button.Enabled = False
        Me.coin_cancel_button.Location = New System.Drawing.Point(516, 270)
        Me.coin_cancel_button.Name = "coin_cancel_button"
        Me.coin_cancel_button.Size = New System.Drawing.Size(158, 33)
        Me.coin_cancel_button.TabIndex = 10
        Me.coin_cancel_button.Text = "Cancel Purchase"
        Me.coin_cancel_button.UseVisualStyleBackColor = True
        '
        'Runtime
        '
        Me.Runtime.Enabled = True
        '
        'main_menu
        '
        Me.main_menu.Controls.Add(Me.winegums_stock)
        Me.main_menu.Controls.Add(Me.winegums_price)
        Me.main_menu.Controls.Add(Me.winegums_button)
        Me.main_menu.Controls.Add(Me.dairymilk_stock)
        Me.main_menu.Controls.Add(Me.dairymilk_price)
        Me.main_menu.Controls.Add(Me.dairymilk_button)
        Me.main_menu.Controls.Add(Me.crisps_stock)
        Me.main_menu.Controls.Add(Me.crisps_price)
        Me.main_menu.Controls.Add(Me.crisps_button)
        Me.main_menu.Controls.Add(Me.coke_stock)
        Me.main_menu.Controls.Add(Me.pepsi_stock)
        Me.main_menu.Controls.Add(Me.monster_stock)
        Me.main_menu.Controls.Add(Me.monster_price)
        Me.main_menu.Controls.Add(Me.monster_button)
        Me.main_menu.Controls.Add(Me.coke_price)
        Me.main_menu.Controls.Add(Me.pepsi_price)
        Me.main_menu.Controls.Add(Me.coke_button)
        Me.main_menu.Controls.Add(Me.pepsi_button)
        Me.main_menu.Location = New System.Drawing.Point(12, 12)
        Me.main_menu.Name = "main_menu"
        Me.main_menu.Size = New System.Drawing.Size(332, 567)
        Me.main_menu.TabIndex = 1
        Me.main_menu.TabStop = False
        Me.main_menu.Text = "Menu"
        Me.main_menu.Visible = False
        '
        'winegums_stock
        '
        Me.winegums_stock.AutoSize = True
        Me.winegums_stock.Location = New System.Drawing.Point(267, 531)
        Me.winegums_stock.Name = "winegums_stock"
        Me.winegums_stock.Size = New System.Drawing.Size(47, 13)
        Me.winegums_stock.TabIndex = 19
        Me.winegums_stock.Text = "Stock: 0"
        Me.winegums_stock.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'winegums_price
        '
        Me.winegums_price.AutoSize = True
        Me.winegums_price.Location = New System.Drawing.Point(173, 531)
        Me.winegums_price.Name = "winegums_price"
        Me.winegums_price.Size = New System.Drawing.Size(34, 13)
        Me.winegums_price.TabIndex = 18
        Me.winegums_price.Text = "£0.00"
        Me.winegums_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'winegums_button
        '
        Me.winegums_button.Image = Global.VendingMachine.My.Resources.Resources.WineGums
        Me.winegums_button.Location = New System.Drawing.Point(175, 389)
        Me.winegums_button.Name = "winegums_button"
        Me.winegums_button.Size = New System.Drawing.Size(140, 139)
        Me.winegums_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.winegums_button.TabIndex = 17
        Me.winegums_button.TabStop = False
        '
        'dairymilk_stock
        '
        Me.dairymilk_stock.AutoSize = True
        Me.dairymilk_stock.Location = New System.Drawing.Point(107, 531)
        Me.dairymilk_stock.Name = "dairymilk_stock"
        Me.dairymilk_stock.Size = New System.Drawing.Size(47, 13)
        Me.dairymilk_stock.TabIndex = 16
        Me.dairymilk_stock.Text = "Stock: 0"
        Me.dairymilk_stock.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dairymilk_price
        '
        Me.dairymilk_price.AutoSize = True
        Me.dairymilk_price.Location = New System.Drawing.Point(13, 531)
        Me.dairymilk_price.Name = "dairymilk_price"
        Me.dairymilk_price.Size = New System.Drawing.Size(34, 13)
        Me.dairymilk_price.TabIndex = 15
        Me.dairymilk_price.Text = "£0.00"
        Me.dairymilk_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dairymilk_button
        '
        Me.dairymilk_button.Image = Global.VendingMachine.My.Resources.Resources.DairyMilk
        Me.dairymilk_button.Location = New System.Drawing.Point(15, 389)
        Me.dairymilk_button.Name = "dairymilk_button"
        Me.dairymilk_button.Size = New System.Drawing.Size(140, 139)
        Me.dairymilk_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dairymilk_button.TabIndex = 14
        Me.dairymilk_button.TabStop = False
        '
        'crisps_stock
        '
        Me.crisps_stock.AutoSize = True
        Me.crisps_stock.Location = New System.Drawing.Point(268, 345)
        Me.crisps_stock.Name = "crisps_stock"
        Me.crisps_stock.Size = New System.Drawing.Size(47, 13)
        Me.crisps_stock.TabIndex = 13
        Me.crisps_stock.Text = "Stock: 0"
        Me.crisps_stock.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'crisps_price
        '
        Me.crisps_price.AutoSize = True
        Me.crisps_price.Location = New System.Drawing.Point(174, 345)
        Me.crisps_price.Name = "crisps_price"
        Me.crisps_price.Size = New System.Drawing.Size(34, 13)
        Me.crisps_price.TabIndex = 12
        Me.crisps_price.Text = "£0.00"
        Me.crisps_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'crisps_button
        '
        Me.crisps_button.Image = Global.VendingMachine.My.Resources.Resources.WalkersCheeseOnion
        Me.crisps_button.Location = New System.Drawing.Point(176, 203)
        Me.crisps_button.Name = "crisps_button"
        Me.crisps_button.Size = New System.Drawing.Size(140, 139)
        Me.crisps_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.crisps_button.TabIndex = 11
        Me.crisps_button.TabStop = False
        '
        'coke_stock
        '
        Me.coke_stock.AutoSize = True
        Me.coke_stock.Location = New System.Drawing.Point(268, 162)
        Me.coke_stock.Name = "coke_stock"
        Me.coke_stock.Size = New System.Drawing.Size(47, 13)
        Me.coke_stock.TabIndex = 10
        Me.coke_stock.Text = "Stock: 0"
        Me.coke_stock.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pepsi_stock
        '
        Me.pepsi_stock.AutoSize = True
        Me.pepsi_stock.Location = New System.Drawing.Point(108, 162)
        Me.pepsi_stock.Name = "pepsi_stock"
        Me.pepsi_stock.Size = New System.Drawing.Size(47, 13)
        Me.pepsi_stock.TabIndex = 9
        Me.pepsi_stock.Text = "Stock: 0"
        Me.pepsi_stock.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'monster_stock
        '
        Me.monster_stock.AutoSize = True
        Me.monster_stock.Location = New System.Drawing.Point(108, 345)
        Me.monster_stock.Name = "monster_stock"
        Me.monster_stock.Size = New System.Drawing.Size(47, 13)
        Me.monster_stock.TabIndex = 8
        Me.monster_stock.Text = "Stock: 0"
        Me.monster_stock.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'monster_price
        '
        Me.monster_price.AutoSize = True
        Me.monster_price.Location = New System.Drawing.Point(14, 345)
        Me.monster_price.Name = "monster_price"
        Me.monster_price.Size = New System.Drawing.Size(34, 13)
        Me.monster_price.TabIndex = 7
        Me.monster_price.Text = "£0.00"
        Me.monster_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'monster_button
        '
        Me.monster_button.Image = Global.VendingMachine.My.Resources.Resources.MonsterCan
        Me.monster_button.Location = New System.Drawing.Point(15, 203)
        Me.monster_button.Name = "monster_button"
        Me.monster_button.Size = New System.Drawing.Size(140, 139)
        Me.monster_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.monster_button.TabIndex = 6
        Me.monster_button.TabStop = False
        '
        'coke_price
        '
        Me.coke_price.AutoSize = True
        Me.coke_price.Location = New System.Drawing.Point(173, 162)
        Me.coke_price.Name = "coke_price"
        Me.coke_price.Size = New System.Drawing.Size(34, 13)
        Me.coke_price.TabIndex = 5
        Me.coke_price.Text = "£0.00"
        Me.coke_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pepsi_price
        '
        Me.pepsi_price.AutoSize = True
        Me.pepsi_price.Location = New System.Drawing.Point(14, 162)
        Me.pepsi_price.Name = "pepsi_price"
        Me.pepsi_price.Size = New System.Drawing.Size(34, 13)
        Me.pepsi_price.TabIndex = 4
        Me.pepsi_price.Text = "£0.00"
        Me.pepsi_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'coke_button
        '
        Me.coke_button.Image = Global.VendingMachine.My.Resources.Resources.CokeCan
        Me.coke_button.Location = New System.Drawing.Point(176, 20)
        Me.coke_button.Name = "coke_button"
        Me.coke_button.Size = New System.Drawing.Size(140, 139)
        Me.coke_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.coke_button.TabIndex = 3
        Me.coke_button.TabStop = False
        '
        'pepsi_button
        '
        Me.pepsi_button.Image = Global.VendingMachine.My.Resources.Resources.PepsiCan
        Me.pepsi_button.Location = New System.Drawing.Point(15, 21)
        Me.pepsi_button.Name = "pepsi_button"
        Me.pepsi_button.Size = New System.Drawing.Size(140, 139)
        Me.pepsi_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pepsi_button.TabIndex = 2
        Me.pepsi_button.TabStop = False
        '
        'order_menu
        '
        Me.order_menu.Controls.Add(Me.total_price)
        Me.order_menu.Controls.Add(Me.Label2)
        Me.order_menu.Controls.Add(Me.slot6_total_price)
        Me.order_menu.Controls.Add(Me.slot5_total_price)
        Me.order_menu.Controls.Add(Me.slot4_total_price)
        Me.order_menu.Controls.Add(Me.slot3_total_price)
        Me.order_menu.Controls.Add(Me.slot2_total_price)
        Me.order_menu.Controls.Add(Me.slot1_total_price)
        Me.order_menu.Controls.Add(Me.Label1)
        Me.order_menu.Controls.Add(Me.slot6_add_item)
        Me.order_menu.Controls.Add(Me.slot5_add_item)
        Me.order_menu.Controls.Add(Me.slot4_add_item)
        Me.order_menu.Controls.Add(Me.slot3_add_item)
        Me.order_menu.Controls.Add(Me.slot2_add_item)
        Me.order_menu.Controls.Add(Me.slot1_add_item)
        Me.order_menu.Controls.Add(Me.slot6_remove_item)
        Me.order_menu.Controls.Add(Me.slot5_remove_item)
        Me.order_menu.Controls.Add(Me.slot4_remove_item)
        Me.order_menu.Controls.Add(Me.slot3_remove_item)
        Me.order_menu.Controls.Add(Me.slot2_remove_item)
        Me.order_menu.Controls.Add(Me.slot1_remove_item)
        Me.order_menu.Controls.Add(Me.order_item_6)
        Me.order_menu.Controls.Add(Me.order_item_5)
        Me.order_menu.Controls.Add(Me.order_item_4)
        Me.order_menu.Controls.Add(Me.order_item_3)
        Me.order_menu.Controls.Add(Me.order_item_2)
        Me.order_menu.Controls.Add(Me.order_item_1)
        Me.order_menu.Location = New System.Drawing.Point(350, 12)
        Me.order_menu.Name = "order_menu"
        Me.order_menu.Size = New System.Drawing.Size(324, 246)
        Me.order_menu.TabIndex = 0
        Me.order_menu.TabStop = False
        Me.order_menu.Text = "Order"
        '
        'total_price
        '
        Me.total_price.Location = New System.Drawing.Point(164, 209)
        Me.total_price.Name = "total_price"
        Me.total_price.ReadOnly = True
        Me.total_price.Size = New System.Drawing.Size(69, 20)
        Me.total_price.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Total:"
        '
        'slot6_total_price
        '
        Me.slot6_total_price.Location = New System.Drawing.Point(164, 170)
        Me.slot6_total_price.Name = "slot6_total_price"
        Me.slot6_total_price.ReadOnly = True
        Me.slot6_total_price.Size = New System.Drawing.Size(69, 20)
        Me.slot6_total_price.TabIndex = 25
        '
        'slot5_total_price
        '
        Me.slot5_total_price.Location = New System.Drawing.Point(164, 144)
        Me.slot5_total_price.Name = "slot5_total_price"
        Me.slot5_total_price.ReadOnly = True
        Me.slot5_total_price.Size = New System.Drawing.Size(69, 20)
        Me.slot5_total_price.TabIndex = 24
        '
        'slot4_total_price
        '
        Me.slot4_total_price.Location = New System.Drawing.Point(164, 118)
        Me.slot4_total_price.Name = "slot4_total_price"
        Me.slot4_total_price.ReadOnly = True
        Me.slot4_total_price.Size = New System.Drawing.Size(69, 20)
        Me.slot4_total_price.TabIndex = 23
        '
        'slot3_total_price
        '
        Me.slot3_total_price.Location = New System.Drawing.Point(164, 92)
        Me.slot3_total_price.Name = "slot3_total_price"
        Me.slot3_total_price.ReadOnly = True
        Me.slot3_total_price.Size = New System.Drawing.Size(69, 20)
        Me.slot3_total_price.TabIndex = 22
        '
        'slot2_total_price
        '
        Me.slot2_total_price.Location = New System.Drawing.Point(164, 66)
        Me.slot2_total_price.Name = "slot2_total_price"
        Me.slot2_total_price.ReadOnly = True
        Me.slot2_total_price.Size = New System.Drawing.Size(69, 20)
        Me.slot2_total_price.TabIndex = 21
        '
        'slot1_total_price
        '
        Me.slot1_total_price.Location = New System.Drawing.Point(164, 40)
        Me.slot1_total_price.Name = "slot1_total_price"
        Me.slot1_total_price.ReadOnly = True
        Me.slot1_total_price.Size = New System.Drawing.Size(69, 20)
        Me.slot1_total_price.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Order List:"
        '
        'slot6_add_item
        '
        Me.slot6_add_item.Enabled = False
        Me.slot6_add_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot6_add_item.Location = New System.Drawing.Point(239, 167)
        Me.slot6_add_item.Name = "slot6_add_item"
        Me.slot6_add_item.Size = New System.Drawing.Size(36, 23)
        Me.slot6_add_item.TabIndex = 18
        Me.slot6_add_item.Text = "+"
        Me.slot6_add_item.UseVisualStyleBackColor = True
        '
        'slot5_add_item
        '
        Me.slot5_add_item.Enabled = False
        Me.slot5_add_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot5_add_item.Location = New System.Drawing.Point(239, 141)
        Me.slot5_add_item.Name = "slot5_add_item"
        Me.slot5_add_item.Size = New System.Drawing.Size(36, 23)
        Me.slot5_add_item.TabIndex = 17
        Me.slot5_add_item.Text = "+"
        Me.slot5_add_item.UseVisualStyleBackColor = True
        '
        'slot4_add_item
        '
        Me.slot4_add_item.Enabled = False
        Me.slot4_add_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot4_add_item.Location = New System.Drawing.Point(239, 115)
        Me.slot4_add_item.Name = "slot4_add_item"
        Me.slot4_add_item.Size = New System.Drawing.Size(36, 23)
        Me.slot4_add_item.TabIndex = 16
        Me.slot4_add_item.Text = "+"
        Me.slot4_add_item.UseVisualStyleBackColor = True
        '
        'slot3_add_item
        '
        Me.slot3_add_item.Enabled = False
        Me.slot3_add_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot3_add_item.Location = New System.Drawing.Point(239, 89)
        Me.slot3_add_item.Name = "slot3_add_item"
        Me.slot3_add_item.Size = New System.Drawing.Size(36, 23)
        Me.slot3_add_item.TabIndex = 15
        Me.slot3_add_item.Text = "+"
        Me.slot3_add_item.UseVisualStyleBackColor = True
        '
        'slot2_add_item
        '
        Me.slot2_add_item.Enabled = False
        Me.slot2_add_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot2_add_item.Location = New System.Drawing.Point(239, 63)
        Me.slot2_add_item.Name = "slot2_add_item"
        Me.slot2_add_item.Size = New System.Drawing.Size(36, 23)
        Me.slot2_add_item.TabIndex = 14
        Me.slot2_add_item.Text = "+"
        Me.slot2_add_item.UseVisualStyleBackColor = True
        '
        'slot1_add_item
        '
        Me.slot1_add_item.Enabled = False
        Me.slot1_add_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot1_add_item.Location = New System.Drawing.Point(239, 38)
        Me.slot1_add_item.Name = "slot1_add_item"
        Me.slot1_add_item.Size = New System.Drawing.Size(36, 23)
        Me.slot1_add_item.TabIndex = 13
        Me.slot1_add_item.Text = "+"
        Me.slot1_add_item.UseVisualStyleBackColor = True
        '
        'slot6_remove_item
        '
        Me.slot6_remove_item.Enabled = False
        Me.slot6_remove_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot6_remove_item.Location = New System.Drawing.Point(281, 167)
        Me.slot6_remove_item.Name = "slot6_remove_item"
        Me.slot6_remove_item.Size = New System.Drawing.Size(36, 23)
        Me.slot6_remove_item.TabIndex = 12
        Me.slot6_remove_item.Text = "-"
        Me.slot6_remove_item.UseVisualStyleBackColor = True
        '
        'slot5_remove_item
        '
        Me.slot5_remove_item.Enabled = False
        Me.slot5_remove_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot5_remove_item.Location = New System.Drawing.Point(281, 141)
        Me.slot5_remove_item.Name = "slot5_remove_item"
        Me.slot5_remove_item.Size = New System.Drawing.Size(36, 23)
        Me.slot5_remove_item.TabIndex = 11
        Me.slot5_remove_item.Text = "-"
        Me.slot5_remove_item.UseVisualStyleBackColor = True
        '
        'slot4_remove_item
        '
        Me.slot4_remove_item.Enabled = False
        Me.slot4_remove_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot4_remove_item.Location = New System.Drawing.Point(281, 115)
        Me.slot4_remove_item.Name = "slot4_remove_item"
        Me.slot4_remove_item.Size = New System.Drawing.Size(36, 23)
        Me.slot4_remove_item.TabIndex = 10
        Me.slot4_remove_item.Text = "-"
        Me.slot4_remove_item.UseVisualStyleBackColor = True
        '
        'slot3_remove_item
        '
        Me.slot3_remove_item.Enabled = False
        Me.slot3_remove_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot3_remove_item.Location = New System.Drawing.Point(281, 89)
        Me.slot3_remove_item.Name = "slot3_remove_item"
        Me.slot3_remove_item.Size = New System.Drawing.Size(36, 23)
        Me.slot3_remove_item.TabIndex = 9
        Me.slot3_remove_item.Text = "-"
        Me.slot3_remove_item.UseVisualStyleBackColor = True
        '
        'slot2_remove_item
        '
        Me.slot2_remove_item.Enabled = False
        Me.slot2_remove_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot2_remove_item.Location = New System.Drawing.Point(281, 63)
        Me.slot2_remove_item.Name = "slot2_remove_item"
        Me.slot2_remove_item.Size = New System.Drawing.Size(36, 23)
        Me.slot2_remove_item.TabIndex = 8
        Me.slot2_remove_item.Text = "-"
        Me.slot2_remove_item.UseVisualStyleBackColor = True
        '
        'slot1_remove_item
        '
        Me.slot1_remove_item.Enabled = False
        Me.slot1_remove_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slot1_remove_item.Location = New System.Drawing.Point(281, 38)
        Me.slot1_remove_item.Name = "slot1_remove_item"
        Me.slot1_remove_item.Size = New System.Drawing.Size(36, 23)
        Me.slot1_remove_item.TabIndex = 7
        Me.slot1_remove_item.Text = "-"
        Me.slot1_remove_item.UseVisualStyleBackColor = True
        '
        'order_item_6
        '
        Me.order_item_6.Location = New System.Drawing.Point(6, 170)
        Me.order_item_6.Name = "order_item_6"
        Me.order_item_6.ReadOnly = True
        Me.order_item_6.Size = New System.Drawing.Size(152, 20)
        Me.order_item_6.TabIndex = 5
        '
        'order_item_5
        '
        Me.order_item_5.Location = New System.Drawing.Point(6, 144)
        Me.order_item_5.Name = "order_item_5"
        Me.order_item_5.ReadOnly = True
        Me.order_item_5.Size = New System.Drawing.Size(152, 20)
        Me.order_item_5.TabIndex = 4
        '
        'order_item_4
        '
        Me.order_item_4.Location = New System.Drawing.Point(6, 118)
        Me.order_item_4.Name = "order_item_4"
        Me.order_item_4.ReadOnly = True
        Me.order_item_4.Size = New System.Drawing.Size(152, 20)
        Me.order_item_4.TabIndex = 3
        '
        'order_item_3
        '
        Me.order_item_3.Location = New System.Drawing.Point(6, 92)
        Me.order_item_3.Name = "order_item_3"
        Me.order_item_3.ReadOnly = True
        Me.order_item_3.Size = New System.Drawing.Size(152, 20)
        Me.order_item_3.TabIndex = 2
        '
        'order_item_2
        '
        Me.order_item_2.Location = New System.Drawing.Point(6, 66)
        Me.order_item_2.Name = "order_item_2"
        Me.order_item_2.ReadOnly = True
        Me.order_item_2.Size = New System.Drawing.Size(152, 20)
        Me.order_item_2.TabIndex = 1
        '
        'order_item_1
        '
        Me.order_item_1.Location = New System.Drawing.Point(6, 40)
        Me.order_item_1.Name = "order_item_1"
        Me.order_item_1.ReadOnly = True
        Me.order_item_1.Size = New System.Drawing.Size(152, 20)
        Me.order_item_1.TabIndex = 0
        '
        'confirm_purchase_button
        '
        Me.confirm_purchase_button.Enabled = False
        Me.confirm_purchase_button.Location = New System.Drawing.Point(350, 270)
        Me.confirm_purchase_button.Name = "confirm_purchase_button"
        Me.confirm_purchase_button.Size = New System.Drawing.Size(158, 33)
        Me.confirm_purchase_button.TabIndex = 6
        Me.confirm_purchase_button.Text = "Confirm Purchase"
        Me.confirm_purchase_button.UseVisualStyleBackColor = True
        '
        'moneyPrompt
        '
        Me.moneyPrompt.AutoSize = True
        Me.moneyPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moneyPrompt.Location = New System.Drawing.Point(24, 260)
        Me.moneyPrompt.Name = "moneyPrompt"
        Me.moneyPrompt.Size = New System.Drawing.Size(303, 25)
        Me.moneyPrompt.TabIndex = 2
        Me.moneyPrompt.Text = "Please Insert Money To Continue"
        '
        'dispensed_items_tray
        '
        Me.dispensed_items_tray.Controls.Add(Me.items_collect_button)
        Me.dispensed_items_tray.Controls.Add(Me.dispensed_item6)
        Me.dispensed_items_tray.Controls.Add(Me.dispensed_item5)
        Me.dispensed_items_tray.Controls.Add(Me.dispensed_item4)
        Me.dispensed_items_tray.Controls.Add(Me.dispensed_item3)
        Me.dispensed_items_tray.Controls.Add(Me.dispensed_item2)
        Me.dispensed_items_tray.Controls.Add(Me.dispensed_item1)
        Me.dispensed_items_tray.Location = New System.Drawing.Point(350, 313)
        Me.dispensed_items_tray.Name = "dispensed_items_tray"
        Me.dispensed_items_tray.Size = New System.Drawing.Size(324, 266)
        Me.dispensed_items_tray.TabIndex = 11
        Me.dispensed_items_tray.TabStop = False
        Me.dispensed_items_tray.Text = "Dispensed Items"
        '
        'items_collect_button
        '
        Me.items_collect_button.Enabled = False
        Me.items_collect_button.Location = New System.Drawing.Point(81, 204)
        Me.items_collect_button.Name = "items_collect_button"
        Me.items_collect_button.Size = New System.Drawing.Size(152, 31)
        Me.items_collect_button.TabIndex = 12
        Me.items_collect_button.Text = "Collect Items"
        Me.items_collect_button.UseVisualStyleBackColor = True
        '
        'dispensed_item6
        '
        Me.dispensed_item6.Location = New System.Drawing.Point(81, 178)
        Me.dispensed_item6.Name = "dispensed_item6"
        Me.dispensed_item6.ReadOnly = True
        Me.dispensed_item6.Size = New System.Drawing.Size(152, 20)
        Me.dispensed_item6.TabIndex = 33
        '
        'dispensed_item5
        '
        Me.dispensed_item5.Location = New System.Drawing.Point(81, 152)
        Me.dispensed_item5.Name = "dispensed_item5"
        Me.dispensed_item5.ReadOnly = True
        Me.dispensed_item5.Size = New System.Drawing.Size(152, 20)
        Me.dispensed_item5.TabIndex = 32
        '
        'dispensed_item4
        '
        Me.dispensed_item4.Location = New System.Drawing.Point(81, 126)
        Me.dispensed_item4.Name = "dispensed_item4"
        Me.dispensed_item4.ReadOnly = True
        Me.dispensed_item4.Size = New System.Drawing.Size(152, 20)
        Me.dispensed_item4.TabIndex = 31
        '
        'dispensed_item3
        '
        Me.dispensed_item3.Location = New System.Drawing.Point(81, 100)
        Me.dispensed_item3.Name = "dispensed_item3"
        Me.dispensed_item3.ReadOnly = True
        Me.dispensed_item3.Size = New System.Drawing.Size(152, 20)
        Me.dispensed_item3.TabIndex = 30
        '
        'dispensed_item2
        '
        Me.dispensed_item2.Location = New System.Drawing.Point(81, 74)
        Me.dispensed_item2.Name = "dispensed_item2"
        Me.dispensed_item2.ReadOnly = True
        Me.dispensed_item2.Size = New System.Drawing.Size(152, 20)
        Me.dispensed_item2.TabIndex = 29
        '
        'dispensed_item1
        '
        Me.dispensed_item1.Location = New System.Drawing.Point(81, 48)
        Me.dispensed_item1.Name = "dispensed_item1"
        Me.dispensed_item1.ReadOnly = True
        Me.dispensed_item1.Size = New System.Drawing.Size(152, 20)
        Me.dispensed_item1.TabIndex = 28
        '
        'version
        '
        Me.version.Location = New System.Drawing.Point(848, 578)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(54, 20)
        Me.version.TabIndex = 12
        Me.version.Text = "v1.0"
        Me.version.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'VendingMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 591)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.dispensed_items_tray)
        Me.Controls.Add(Me.main_menu)
        Me.Controls.Add(Me.coin_cancel_button)
        Me.Controls.Add(Me.CoinBox)
        Me.Controls.Add(Me.order_menu)
        Me.Controls.Add(Me.moneyPrompt)
        Me.Controls.Add(Me.confirm_purchase_button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VendingMachine"
        Me.Text = "Vending Machine"
        Me.CoinBox.ResumeLayout(False)
        Me.CoinBox.PerformLayout()
        Me.ChangeBox.ResumeLayout(False)
        Me.ChangeBox.PerformLayout()
        Me.main_menu.ResumeLayout(False)
        Me.main_menu.PerformLayout()
        CType(Me.winegums_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dairymilk_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crisps_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monster_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coke_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pepsi_button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.order_menu.ResumeLayout(False)
        Me.order_menu.PerformLayout()
        Me.dispensed_items_tray.ResumeLayout(False)
        Me.dispensed_items_tray.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CoinBox As GroupBox
    Friend WithEvents display_money As TextBox
    Friend WithEvents coin_200p_insert As Button
    Friend WithEvents coin_100p_insert As Button
    Friend WithEvents coin_50p_insert As Button
    Friend WithEvents coin_20p_insert As Button
    Friend WithEvents coin_10p_insert As Button
    Friend WithEvents coin_5p_insert As Button
    Friend WithEvents coin_2p_insert As Button
    Friend WithEvents coin_1p_insert As Button
    Friend WithEvents ChangeBox As GroupBox
    Friend WithEvents Runtime As Timer
    Friend WithEvents main_menu As GroupBox
    Friend WithEvents coin_cancel_button As Button
    Friend WithEvents coin_200p_return_label As Label
    Friend WithEvents coin_200p_return As TextBox
    Friend WithEvents coin_100p_return_label As Label
    Friend WithEvents coin_100p_return As TextBox
    Friend WithEvents coin_50p_return_label As Label
    Friend WithEvents coin_50p_return As TextBox
    Friend WithEvents coin_20p_return_label As Label
    Friend WithEvents coin_20p_return As TextBox
    Friend WithEvents coin_10p_return_label As Label
    Friend WithEvents coin_10p_return As TextBox
    Friend WithEvents coin_5p_return_label As Label
    Friend WithEvents coin_5p_return As TextBox
    Friend WithEvents coin_2p_return_label As Label
    Friend WithEvents coin_2p_return As TextBox
    Friend WithEvents coin_1p_return_label As Label
    Friend WithEvents coin_1p_return As TextBox
    Friend WithEvents coin_change_collect_button As Button
    Friend WithEvents coke_button As PictureBox
    Friend WithEvents pepsi_button As PictureBox
    Friend WithEvents order_menu As GroupBox
    Friend WithEvents confirm_purchase_button As Button
    Friend WithEvents order_item_6 As TextBox
    Friend WithEvents order_item_5 As TextBox
    Friend WithEvents order_item_4 As TextBox
    Friend WithEvents order_item_3 As TextBox
    Friend WithEvents order_item_2 As TextBox
    Friend WithEvents order_item_1 As TextBox
    Friend WithEvents slot6_remove_item As Button
    Friend WithEvents slot5_remove_item As Button
    Friend WithEvents slot4_remove_item As Button
    Friend WithEvents slot3_remove_item As Button
    Friend WithEvents slot2_remove_item As Button
    Friend WithEvents slot1_remove_item As Button
    Friend WithEvents slot6_add_item As Button
    Friend WithEvents slot5_add_item As Button
    Friend WithEvents slot4_add_item As Button
    Friend WithEvents slot3_add_item As Button
    Friend WithEvents slot2_add_item As Button
    Friend WithEvents slot1_add_item As Button
    Friend WithEvents coke_price As Label
    Friend WithEvents pepsi_price As Label
    Friend WithEvents slot6_total_price As TextBox
    Friend WithEvents slot5_total_price As TextBox
    Friend WithEvents slot4_total_price As TextBox
    Friend WithEvents slot3_total_price As TextBox
    Friend WithEvents slot2_total_price As TextBox
    Friend WithEvents slot1_total_price As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents total_price As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents moneyPrompt As Label
    Friend WithEvents dispensed_items_tray As GroupBox
    Friend WithEvents items_collect_button As Button
    Friend WithEvents dispensed_item6 As TextBox
    Friend WithEvents dispensed_item5 As TextBox
    Friend WithEvents dispensed_item4 As TextBox
    Friend WithEvents dispensed_item3 As TextBox
    Friend WithEvents dispensed_item2 As TextBox
    Friend WithEvents dispensed_item1 As TextBox
    Friend WithEvents monster_button As PictureBox
    Friend WithEvents monster_price As Label
    Friend WithEvents coke_stock As Label
    Friend WithEvents pepsi_stock As Label
    Friend WithEvents monster_stock As Label
    Friend WithEvents crisps_button As PictureBox
    Friend WithEvents crisps_stock As Label
    Friend WithEvents crisps_price As Label
    Friend WithEvents dairymilk_stock As Label
    Friend WithEvents dairymilk_price As Label
    Friend WithEvents dairymilk_button As PictureBox
    Friend WithEvents winegums_stock As Label
    Friend WithEvents winegums_price As Label
    Friend WithEvents winegums_button As PictureBox
    Friend WithEvents version As Label
End Class
