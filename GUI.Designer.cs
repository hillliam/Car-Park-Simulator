namespace Car_Park_Simulator
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnterCarPark = new System.Windows.Forms.Button();
            this.btnPressForCoin = new System.Windows.Forms.Button();
            this.btnCarArrives = new System.Windows.Forms.Button();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpArrivalSimulator = new System.Windows.Forms.GroupBox();
            this.grpExitSimulator = new System.Windows.Forms.GroupBox();
            this.btnCarArrivesAtExit = new System.Windows.Forms.Button();
            this.btnEnterCoin = new System.Windows.Forms.Button();
            this.btnExitCarPark = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAvailableCoins = new System.Windows.Forms.TextBox();
            this.lblAvailableCoins = new System.Windows.Forms.Label();
            this.txtAvailableSpaces = new System.Windows.Forms.TextBox();
            this.lblAvailableSpaces = new System.Windows.Forms.Label();
            this.txtExitBarrier = new System.Windows.Forms.TextBox();
            this.lblExitBarrier = new System.Windows.Forms.Label();
            this.txtEntryBarrier = new System.Windows.Forms.TextBox();
            this.lblEntryBarrier = new System.Windows.Forms.Label();
            this.txtFullSign = new System.Windows.Forms.TextBox();
            this.lblFullSign = new System.Windows.Forms.Label();
            this.grpCoinMachineDisplay = new System.Windows.Forms.GroupBox();
            this.txtCoinMachine = new System.Windows.Forms.TextBox();
            this.coinDisplay = new System.Windows.Forms.ListBox();
            this.grpCoinsCollected = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnInsert2p = new System.Windows.Forms.Button();
            this.btnInsert1p = new System.Windows.Forms.Button();
            this.btnInsert20p = new System.Windows.Forms.Button();
            this.btnInsert2Pound = new System.Windows.Forms.Button();
            this.btnInsert50p = new System.Windows.Forms.Button();
            this.btnRequestCoin = new System.Windows.Forms.Button();
            this.btnCalculateValue = new System.Windows.Forms.Button();
            this.btnInsert10p = new System.Windows.Forms.Button();
            this.btnInsert5p = new System.Windows.Forms.Button();
            this.btnInsert1Pound = new System.Windows.Forms.Button();
            this.btnInsertCoin = new System.Windows.Forms.Button();
            this.GrpPaymentDisplay = new System.Windows.Forms.GroupBox();
            this.txtPaymentDisplay = new System.Windows.Forms.TextBox();
            this.grpArrivalSimulator.SuspendLayout();
            this.grpExitSimulator.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpCoinMachineDisplay.SuspendLayout();
            this.grpCoinsCollected.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.GrpPaymentDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnterCarPark
            // 
            this.btnEnterCarPark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterCarPark.Location = new System.Drawing.Point(6, 126);
            this.btnEnterCarPark.Name = "btnEnterCarPark";
            this.btnEnterCarPark.Size = new System.Drawing.Size(151, 46);
            this.btnEnterCarPark.TabIndex = 0;
            this.btnEnterCarPark.Text = "Enter Car Park";
            this.btnEnterCarPark.UseVisualStyleBackColor = true;
            this.btnEnterCarPark.Visible = false;
            this.btnEnterCarPark.Click += new System.EventHandler(this.btnEnterCarPark_Click);
            // 
            // btnPressForCoin
            // 
            this.btnPressForCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPressForCoin.Location = new System.Drawing.Point(6, 74);
            this.btnPressForCoin.Name = "btnPressForCoin";
            this.btnPressForCoin.Size = new System.Drawing.Size(151, 46);
            this.btnPressForCoin.TabIndex = 0;
            this.btnPressForCoin.Text = "Press for Coin";
            this.btnPressForCoin.UseVisualStyleBackColor = true;
            this.btnPressForCoin.Visible = false;
            this.btnPressForCoin.Click += new System.EventHandler(this.btnPressForCoin_Click);
            // 
            // btnCarArrives
            // 
            this.btnCarArrives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarArrives.Location = new System.Drawing.Point(6, 22);
            this.btnCarArrives.Name = "btnCarArrives";
            this.btnCarArrives.Size = new System.Drawing.Size(151, 46);
            this.btnCarArrives.TabIndex = 0;
            this.btnCarArrives.Text = "Car Arrives at Car Park";
            this.btnCarArrives.UseVisualStyleBackColor = true;
            this.btnCarArrives.Visible = false;
            this.btnCarArrives.Click += new System.EventHandler(this.btnCarArrives_Click);
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(12, 9);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(357, 46);
            this.lblMainHeading.TabIndex = 2;
            this.lblMainHeading.Text = "Car Park Simulator";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(320, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpArrivalSimulator
            // 
            this.grpArrivalSimulator.Controls.Add(this.btnCarArrives);
            this.grpArrivalSimulator.Controls.Add(this.btnPressForCoin);
            this.grpArrivalSimulator.Controls.Add(this.btnEnterCarPark);
            this.grpArrivalSimulator.Location = new System.Drawing.Point(12, 159);
            this.grpArrivalSimulator.Name = "grpArrivalSimulator";
            this.grpArrivalSimulator.Size = new System.Drawing.Size(163, 184);
            this.grpArrivalSimulator.TabIndex = 3;
            this.grpArrivalSimulator.TabStop = false;
            this.grpArrivalSimulator.Text = "Car Arrival Simulator";
            // 
            // grpExitSimulator
            // 
            this.grpExitSimulator.Controls.Add(this.btnCarArrivesAtExit);
            this.grpExitSimulator.Controls.Add(this.btnEnterCoin);
            this.grpExitSimulator.Controls.Add(this.btnExitCarPark);
            this.grpExitSimulator.Location = new System.Drawing.Point(181, 159);
            this.grpExitSimulator.Name = "grpExitSimulator";
            this.grpExitSimulator.Size = new System.Drawing.Size(163, 184);
            this.grpExitSimulator.TabIndex = 3;
            this.grpExitSimulator.TabStop = false;
            this.grpExitSimulator.Text = "Car Exit Simulator";
            // 
            // btnCarArrivesAtExit
            // 
            this.btnCarArrivesAtExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarArrivesAtExit.Location = new System.Drawing.Point(6, 22);
            this.btnCarArrivesAtExit.Name = "btnCarArrivesAtExit";
            this.btnCarArrivesAtExit.Size = new System.Drawing.Size(151, 46);
            this.btnCarArrivesAtExit.TabIndex = 0;
            this.btnCarArrivesAtExit.Text = "Car Arrives at Exit";
            this.btnCarArrivesAtExit.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtExit.Visible = false;
            this.btnCarArrivesAtExit.Click += new System.EventHandler(this.btnCarArrivesAtExit_Click);
            // 
            // btnEnterCoin
            // 
            this.btnEnterCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterCoin.Location = new System.Drawing.Point(6, 74);
            this.btnEnterCoin.Name = "btnEnterCoin";
            this.btnEnterCoin.Size = new System.Drawing.Size(151, 46);
            this.btnEnterCoin.TabIndex = 0;
            this.btnEnterCoin.Text = "Enter Coin";
            this.btnEnterCoin.UseVisualStyleBackColor = true;
            this.btnEnterCoin.Visible = false;
            this.btnEnterCoin.Click += new System.EventHandler(this.btnEnterCoin_Click);
            // 
            // btnExitCarPark
            // 
            this.btnExitCarPark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitCarPark.Location = new System.Drawing.Point(6, 126);
            this.btnExitCarPark.Name = "btnExitCarPark";
            this.btnExitCarPark.Size = new System.Drawing.Size(151, 46);
            this.btnExitCarPark.TabIndex = 0;
            this.btnExitCarPark.Text = "Exit Car Park";
            this.btnExitCarPark.UseVisualStyleBackColor = true;
            this.btnExitCarPark.Visible = false;
            this.btnExitCarPark.Click += new System.EventHandler(this.btnExitCarPark_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAvailableCoins);
            this.groupBox3.Controls.Add(this.lblAvailableCoins);
            this.groupBox3.Controls.Add(this.txtAvailableSpaces);
            this.groupBox3.Controls.Add(this.lblAvailableSpaces);
            this.groupBox3.Controls.Add(this.txtExitBarrier);
            this.groupBox3.Controls.Add(this.lblExitBarrier);
            this.groupBox3.Controls.Add(this.txtEntryBarrier);
            this.groupBox3.Controls.Add(this.lblEntryBarrier);
            this.groupBox3.Controls.Add(this.txtFullSign);
            this.groupBox3.Controls.Add(this.lblFullSign);
            this.groupBox3.Location = new System.Drawing.Point(372, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 184);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal Data";
            // 
            // txtAvailableCoins
            // 
            this.txtAvailableCoins.Location = new System.Drawing.Point(111, 150);
            this.txtAvailableCoins.Name = "txtAvailableCoins";
            this.txtAvailableCoins.Size = new System.Drawing.Size(123, 20);
            this.txtAvailableCoins.TabIndex = 1;
            // 
            // lblAvailableCoins
            // 
            this.lblAvailableCoins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableCoins.AutoSize = true;
            this.lblAvailableCoins.Location = new System.Drawing.Point(30, 153);
            this.lblAvailableCoins.Name = "lblAvailableCoins";
            this.lblAvailableCoins.Size = new System.Drawing.Size(82, 13);
            this.lblAvailableCoins.TabIndex = 0;
            this.lblAvailableCoins.Text = "Available Coins:";
            // 
            // txtAvailableSpaces
            // 
            this.txtAvailableSpaces.Location = new System.Drawing.Point(111, 120);
            this.txtAvailableSpaces.Name = "txtAvailableSpaces";
            this.txtAvailableSpaces.Size = new System.Drawing.Size(123, 20);
            this.txtAvailableSpaces.TabIndex = 1;
            // 
            // lblAvailableSpaces
            // 
            this.lblAvailableSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableSpaces.AutoSize = true;
            this.lblAvailableSpaces.Location = new System.Drawing.Point(20, 123);
            this.lblAvailableSpaces.Name = "lblAvailableSpaces";
            this.lblAvailableSpaces.Size = new System.Drawing.Size(92, 13);
            this.lblAvailableSpaces.TabIndex = 0;
            this.lblAvailableSpaces.Text = "Available Spaces:";
            // 
            // txtExitBarrier
            // 
            this.txtExitBarrier.Location = new System.Drawing.Point(111, 90);
            this.txtExitBarrier.Name = "txtExitBarrier";
            this.txtExitBarrier.Size = new System.Drawing.Size(123, 20);
            this.txtExitBarrier.TabIndex = 1;
            // 
            // lblExitBarrier
            // 
            this.lblExitBarrier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExitBarrier.AutoSize = true;
            this.lblExitBarrier.Location = new System.Drawing.Point(52, 93);
            this.lblExitBarrier.Name = "lblExitBarrier";
            this.lblExitBarrier.Size = new System.Drawing.Size(60, 13);
            this.lblExitBarrier.TabIndex = 0;
            this.lblExitBarrier.Text = "Exit Barrier:";
            // 
            // txtEntryBarrier
            // 
            this.txtEntryBarrier.Location = new System.Drawing.Point(111, 60);
            this.txtEntryBarrier.Name = "txtEntryBarrier";
            this.txtEntryBarrier.Size = new System.Drawing.Size(123, 20);
            this.txtEntryBarrier.TabIndex = 1;
            // 
            // lblEntryBarrier
            // 
            this.lblEntryBarrier.AutoSize = true;
            this.lblEntryBarrier.Location = new System.Drawing.Point(45, 63);
            this.lblEntryBarrier.Name = "lblEntryBarrier";
            this.lblEntryBarrier.Size = new System.Drawing.Size(67, 13);
            this.lblEntryBarrier.TabIndex = 0;
            this.lblEntryBarrier.Text = "Entry Barrier:";
            // 
            // txtFullSign
            // 
            this.txtFullSign.Location = new System.Drawing.Point(111, 30);
            this.txtFullSign.Name = "txtFullSign";
            this.txtFullSign.Size = new System.Drawing.Size(123, 20);
            this.txtFullSign.TabIndex = 1;
            // 
            // lblFullSign
            // 
            this.lblFullSign.AutoSize = true;
            this.lblFullSign.Location = new System.Drawing.Point(62, 33);
            this.lblFullSign.Name = "lblFullSign";
            this.lblFullSign.Size = new System.Drawing.Size(50, 13);
            this.lblFullSign.TabIndex = 0;
            this.lblFullSign.Text = "Full Sign:";
            // 
            // grpCoinMachineDisplay
            // 
            this.grpCoinMachineDisplay.Controls.Add(this.txtCoinMachine);
            this.grpCoinMachineDisplay.Location = new System.Drawing.Point(372, 85);
            this.grpCoinMachineDisplay.Name = "grpCoinMachineDisplay";
            this.grpCoinMachineDisplay.Size = new System.Drawing.Size(250, 46);
            this.grpCoinMachineDisplay.TabIndex = 5;
            this.grpCoinMachineDisplay.TabStop = false;
            this.grpCoinMachineDisplay.Text = "Coin Machine Display";
            // 
            // txtCoinMachine
            // 
            this.txtCoinMachine.Location = new System.Drawing.Point(6, 20);
            this.txtCoinMachine.Name = "txtCoinMachine";
            this.txtCoinMachine.Size = new System.Drawing.Size(209, 20);
            this.txtCoinMachine.TabIndex = 0;
            // 
            // coinDisplay
            // 
            this.coinDisplay.FormattingEnabled = true;
            this.coinDisplay.Location = new System.Drawing.Point(6, 20);
            this.coinDisplay.Name = "coinDisplay";
            this.coinDisplay.Size = new System.Drawing.Size(133, 225);
            this.coinDisplay.TabIndex = 6;
            // 
            // grpCoinsCollected
            // 
            this.grpCoinsCollected.Controls.Add(this.coinDisplay);
            this.grpCoinsCollected.Location = new System.Drawing.Point(628, 85);
            this.grpCoinsCollected.Name = "grpCoinsCollected";
            this.grpCoinsCollected.Size = new System.Drawing.Size(152, 258);
            this.grpCoinsCollected.TabIndex = 6;
            this.grpCoinsCollected.TabStop = false;
            this.grpCoinsCollected.Text = "Coins Collected by Drivers";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnInsert2p);
            this.groupBox6.Controls.Add(this.btnInsert1p);
            this.groupBox6.Controls.Add(this.btnInsert20p);
            this.groupBox6.Controls.Add(this.btnInsert2Pound);
            this.groupBox6.Controls.Add(this.btnInsert50p);
            this.groupBox6.Controls.Add(this.btnRequestCoin);
            this.groupBox6.Controls.Add(this.btnCalculateValue);
            this.groupBox6.Controls.Add(this.btnInsert10p);
            this.groupBox6.Controls.Add(this.btnInsert5p);
            this.groupBox6.Controls.Add(this.btnInsert1Pound);
            this.groupBox6.Controls.Add(this.btnInsertCoin);
            this.groupBox6.Location = new System.Drawing.Point(372, 349);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(408, 150);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Payment Machine";
            // 
            // btnInsert2p
            // 
            this.btnInsert2p.Enabled = false;
            this.btnInsert2p.Location = new System.Drawing.Point(120, 50);
            this.btnInsert2p.Name = "btnInsert2p";
            this.btnInsert2p.Size = new System.Drawing.Size(75, 23);
            this.btnInsert2p.TabIndex = 10;
            this.btnInsert2p.Text = "Insert 2p";
            this.btnInsert2p.UseVisualStyleBackColor = true;
            this.btnInsert2p.Click += new System.EventHandler(this.btnInsert2p_Click);
            // 
            // btnInsert1p
            // 
            this.btnInsert1p.Enabled = false;
            this.btnInsert1p.Location = new System.Drawing.Point(120, 20);
            this.btnInsert1p.Name = "btnInsert1p";
            this.btnInsert1p.Size = new System.Drawing.Size(75, 23);
            this.btnInsert1p.TabIndex = 9;
            this.btnInsert1p.Text = "Insert 1p";
            this.btnInsert1p.UseVisualStyleBackColor = true;
            this.btnInsert1p.Click += new System.EventHandler(this.btnInsert1p_Click);
            // 
            // btnInsert20p
            // 
            this.btnInsert20p.Enabled = false;
            this.btnInsert20p.Location = new System.Drawing.Point(200, 20);
            this.btnInsert20p.Name = "btnInsert20p";
            this.btnInsert20p.Size = new System.Drawing.Size(75, 23);
            this.btnInsert20p.TabIndex = 8;
            this.btnInsert20p.Text = "Insert 20p";
            this.btnInsert20p.UseVisualStyleBackColor = true;
            this.btnInsert20p.Click += new System.EventHandler(this.btnInsert20p_Click);
            // 
            // btnInsert2Pound
            // 
            this.btnInsert2Pound.Enabled = false;
            this.btnInsert2Pound.Location = new System.Drawing.Point(200, 110);
            this.btnInsert2Pound.Name = "btnInsert2Pound";
            this.btnInsert2Pound.Size = new System.Drawing.Size(75, 23);
            this.btnInsert2Pound.TabIndex = 7;
            this.btnInsert2Pound.Text = "Insert £2";
            this.btnInsert2Pound.UseVisualStyleBackColor = true;
            this.btnInsert2Pound.Click += new System.EventHandler(this.btnInsert2Pound_Click);
            // 
            // btnInsert50p
            // 
            this.btnInsert50p.Enabled = false;
            this.btnInsert50p.Location = new System.Drawing.Point(200, 50);
            this.btnInsert50p.Name = "btnInsert50p";
            this.btnInsert50p.Size = new System.Drawing.Size(75, 23);
            this.btnInsert50p.TabIndex = 6;
            this.btnInsert50p.Text = "Insert 50p";
            this.btnInsert50p.UseVisualStyleBackColor = true;
            this.btnInsert50p.Click += new System.EventHandler(this.btnInsert50p_Click);
            // 
            // btnRequestCoin
            // 
            this.btnRequestCoin.Enabled = false;
            this.btnRequestCoin.Location = new System.Drawing.Point(24, 93);
            this.btnRequestCoin.Name = "btnRequestCoin";
            this.btnRequestCoin.Size = new System.Drawing.Size(75, 37);
            this.btnRequestCoin.TabIndex = 5;
            this.btnRequestCoin.Text = "Request Coin";
            this.btnRequestCoin.UseVisualStyleBackColor = true;
            this.btnRequestCoin.Click += new System.EventHandler(this.btnRequestCoin_Click);
            // 
            // btnCalculateValue
            // 
            this.btnCalculateValue.Enabled = false;
            this.btnCalculateValue.Location = new System.Drawing.Point(23, 49);
            this.btnCalculateValue.Name = "btnCalculateValue";
            this.btnCalculateValue.Size = new System.Drawing.Size(75, 37);
            this.btnCalculateValue.TabIndex = 4;
            this.btnCalculateValue.Text = "Calculate Value";
            this.btnCalculateValue.UseVisualStyleBackColor = true;
            this.btnCalculateValue.Click += new System.EventHandler(this.btnCalculateValue_Click);
            // 
            // btnInsert10p
            // 
            this.btnInsert10p.Enabled = false;
            this.btnInsert10p.Location = new System.Drawing.Point(120, 110);
            this.btnInsert10p.Name = "btnInsert10p";
            this.btnInsert10p.Size = new System.Drawing.Size(75, 23);
            this.btnInsert10p.TabIndex = 3;
            this.btnInsert10p.Text = "Insert 10p";
            this.btnInsert10p.UseVisualStyleBackColor = true;
            this.btnInsert10p.Click += new System.EventHandler(this.btnInsert10p_Click);
            // 
            // btnInsert5p
            // 
            this.btnInsert5p.Enabled = false;
            this.btnInsert5p.Location = new System.Drawing.Point(120, 80);
            this.btnInsert5p.Name = "btnInsert5p";
            this.btnInsert5p.Size = new System.Drawing.Size(75, 23);
            this.btnInsert5p.TabIndex = 2;
            this.btnInsert5p.Text = "Insert 5p";
            this.btnInsert5p.UseVisualStyleBackColor = true;
            this.btnInsert5p.Click += new System.EventHandler(this.btnInsert5p_Click);
            // 
            // btnInsert1Pound
            // 
            this.btnInsert1Pound.Enabled = false;
            this.btnInsert1Pound.Location = new System.Drawing.Point(200, 80);
            this.btnInsert1Pound.Name = "btnInsert1Pound";
            this.btnInsert1Pound.Size = new System.Drawing.Size(75, 23);
            this.btnInsert1Pound.TabIndex = 1;
            this.btnInsert1Pound.Text = "Insert £1";
            this.btnInsert1Pound.UseVisualStyleBackColor = true;
            this.btnInsert1Pound.Click += new System.EventHandler(this.btnInsert1Pound_Click);
            // 
            // btnInsertCoin
            // 
            this.btnInsertCoin.Enabled = false;
            this.btnInsertCoin.Location = new System.Drawing.Point(23, 20);
            this.btnInsertCoin.Name = "btnInsertCoin";
            this.btnInsertCoin.Size = new System.Drawing.Size(75, 23);
            this.btnInsertCoin.TabIndex = 0;
            this.btnInsertCoin.Text = "Insert Coin";
            this.btnInsertCoin.UseVisualStyleBackColor = true;
            this.btnInsertCoin.Click += new System.EventHandler(this.btnInsertCoin_Click);
            // 
            // GrpPaymentDisplay
            // 
            this.GrpPaymentDisplay.Controls.Add(this.txtPaymentDisplay);
            this.GrpPaymentDisplay.Location = new System.Drawing.Point(106, 369);
            this.GrpPaymentDisplay.Name = "GrpPaymentDisplay";
            this.GrpPaymentDisplay.Size = new System.Drawing.Size(250, 46);
            this.GrpPaymentDisplay.TabIndex = 6;
            this.GrpPaymentDisplay.TabStop = false;
            this.GrpPaymentDisplay.Text = "Payment display";
            // 
            // txtPaymentDisplay
            // 
            this.txtPaymentDisplay.Location = new System.Drawing.Point(6, 20);
            this.txtPaymentDisplay.Name = "txtPaymentDisplay";
            this.txtPaymentDisplay.Size = new System.Drawing.Size(209, 20);
            this.txtPaymentDisplay.TabIndex = 0;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 509);
            this.Controls.Add(this.GrpPaymentDisplay);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.grpCoinsCollected);
            this.Controls.Add(this.grpCoinMachineDisplay);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpExitSimulator);
            this.Controls.Add(this.grpArrivalSimulator);
            this.Controls.Add(this.lblMainHeading);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Park Simulator";
            this.grpArrivalSimulator.ResumeLayout(false);
            this.grpExitSimulator.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpCoinMachineDisplay.ResumeLayout(false);
            this.grpCoinMachineDisplay.PerformLayout();
            this.grpCoinsCollected.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.GrpPaymentDisplay.ResumeLayout(false);
            this.GrpPaymentDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterCarPark;
        private System.Windows.Forms.Button btnPressForCoin;
        private System.Windows.Forms.Button btnCarArrives;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpArrivalSimulator;
        private System.Windows.Forms.GroupBox grpExitSimulator;
        private System.Windows.Forms.Button btnCarArrivesAtExit;
        private System.Windows.Forms.Button btnEnterCoin;
        private System.Windows.Forms.Button btnExitCarPark;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAvailableCoins;
        private System.Windows.Forms.Label lblAvailableCoins;
        private System.Windows.Forms.TextBox txtAvailableSpaces;
        private System.Windows.Forms.Label lblAvailableSpaces;
        private System.Windows.Forms.TextBox txtExitBarrier;
        private System.Windows.Forms.Label lblExitBarrier;
        private System.Windows.Forms.TextBox txtEntryBarrier;
        private System.Windows.Forms.Label lblEntryBarrier;
        private System.Windows.Forms.TextBox txtFullSign;
        private System.Windows.Forms.Label lblFullSign;
        private System.Windows.Forms.GroupBox grpCoinMachineDisplay;
        private System.Windows.Forms.TextBox txtCoinMachine;
        private System.Windows.Forms.ListBox coinDisplay;
        private System.Windows.Forms.GroupBox grpCoinsCollected;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnInsertCoin;
        private System.Windows.Forms.Button btnInsert1Pound;
        private System.Windows.Forms.GroupBox GrpPaymentDisplay;
        private System.Windows.Forms.TextBox txtPaymentDisplay;
        private System.Windows.Forms.Button btnInsert10p;
        private System.Windows.Forms.Button btnInsert5p;
        private System.Windows.Forms.Button btnCalculateValue;
        private System.Windows.Forms.Button btnRequestCoin;
        private System.Windows.Forms.Button btnInsert20p;
        private System.Windows.Forms.Button btnInsert2Pound;
        private System.Windows.Forms.Button btnInsert50p;
        private System.Windows.Forms.Button btnInsert2p;
        private System.Windows.Forms.Button btnInsert1p;
    }
}

