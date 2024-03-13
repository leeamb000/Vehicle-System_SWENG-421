namespace VehicleSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.vehicleListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accesoriesListBox = new System.Windows.Forms.ListBox();
            this.addPartsBtn = new System.Windows.Forms.Button();
            this.fuelListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addFuelBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.colorListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addColorBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.maintanceBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addAccessoryBtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleListBox
            // 
            this.vehicleListBox.FormattingEnabled = true;
            this.vehicleListBox.Items.AddRange(new object[] {
            "SUV",
            "Minivan",
            "Sedan",
            "Truck",
            "Convertible",
            "Motorcycle"});
            this.vehicleListBox.Location = new System.Drawing.Point(112, 55);
            this.vehicleListBox.Name = "vehicleListBox";
            this.vehicleListBox.Size = new System.Drawing.Size(205, 82);
            this.vehicleListBox.TabIndex = 0;
            this.vehicleListBox.Click += new System.EventHandler(this.vehicleListBox_Click);
            this.vehicleListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vehicleListBox_MouseClick);
            this.vehicleListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Enabled = false;
            this.addVehicleBtn.Location = new System.Drawing.Point(334, 72);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(108, 43);
            this.addVehicleBtn.TabIndex = 2;
            this.addVehicleBtn.Text = "Choose Model";
            this.addVehicleBtn.UseVisualStyleBackColor = true;
            this.addVehicleBtn.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fuel Type";
            // 
            // accesoriesListBox
            // 
            this.accesoriesListBox.FormattingEnabled = true;
            this.accesoriesListBox.Items.AddRange(new object[] {
            "Seating Capacity",
            "Doors",
            "Transmission",
            "Spare Tires",
            "Suspension"});
            this.accesoriesListBox.Location = new System.Drawing.Point(383, 222);
            this.accesoriesListBox.Name = "accesoriesListBox";
            this.accesoriesListBox.Size = new System.Drawing.Size(145, 82);
            this.accesoriesListBox.TabIndex = 3;
            this.accesoriesListBox.Click += new System.EventHandler(this.listBox2_Click);
            this.accesoriesListBox.SelectedIndexChanged += new System.EventHandler(this.accesoriesListBox_SelectedIndexChanged);
            // 
            // addPartsBtn
            // 
            this.addPartsBtn.Enabled = false;
            this.addPartsBtn.Location = new System.Drawing.Point(401, 340);
            this.addPartsBtn.Name = "addPartsBtn";
            this.addPartsBtn.Size = new System.Drawing.Size(108, 43);
            this.addPartsBtn.TabIndex = 5;
            this.addPartsBtn.Text = "Add Customized Part";
            this.addPartsBtn.UseVisualStyleBackColor = true;
            this.addPartsBtn.Click += new System.EventHandler(this.btnAddCustomizedParts_Click);
            // 
            // fuelListBox
            // 
            this.fuelListBox.FormattingEnabled = true;
            this.fuelListBox.Items.AddRange(new object[] {
            "Gasoline",
            "Diesel",
            "Electric",
            "Hybrid",
            "Alternative Fuels"});
            this.fuelListBox.Location = new System.Drawing.Point(218, 222);
            this.fuelListBox.Name = "fuelListBox";
            this.fuelListBox.Size = new System.Drawing.Size(145, 82);
            this.fuelListBox.TabIndex = 12;
            this.fuelListBox.Click += new System.EventHandler(this.fuelListBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customize Parts";
            // 
            // addFuelBtn
            // 
            this.addFuelBtn.Enabled = false;
            this.addFuelBtn.Location = new System.Drawing.Point(241, 340);
            this.addFuelBtn.Name = "addFuelBtn";
            this.addFuelBtn.Size = new System.Drawing.Size(108, 43);
            this.addFuelBtn.TabIndex = 14;
            this.addFuelBtn.Text = "Select Fuel Type";
            this.addFuelBtn.UseVisualStyleBackColor = true;
            this.addFuelBtn.Click += new System.EventHandler(this.addFuelBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(241, 478);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(901, 144);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(1090, 161);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1087, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Seat Covers";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(1090, 117);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 10;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1087, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of Mats";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1090, 72);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vehicle";
            // 
            // colorListBox
            // 
            this.colorListBox.FormattingEnabled = true;
            this.colorListBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Grey",
            "Blue",
            "Green",
            "Red",
            "Yellow"});
            this.colorListBox.Location = new System.Drawing.Point(54, 222);
            this.colorListBox.Name = "colorListBox";
            this.colorListBox.Size = new System.Drawing.Size(145, 82);
            this.colorListBox.TabIndex = 17;
            this.colorListBox.SelectedIndexChanged += new System.EventHandler(this.colorListBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vehicle Color";
            // 
            // addColorBtn
            // 
            this.addColorBtn.Enabled = false;
            this.addColorBtn.Location = new System.Drawing.Point(72, 340);
            this.addColorBtn.Name = "addColorBtn";
            this.addColorBtn.Size = new System.Drawing.Size(108, 43);
            this.addColorBtn.TabIndex = 19;
            this.addColorBtn.Text = "Select Color";
            this.addColorBtn.UseVisualStyleBackColor = true;
            this.addColorBtn.Click += new System.EventHandler(this.addColorBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Maintance";
            // 
            // maintanceBtn
            // 
            this.maintanceBtn.Enabled = false;
            this.maintanceBtn.Location = new System.Drawing.Point(566, 340);
            this.maintanceBtn.Name = "maintanceBtn";
            this.maintanceBtn.Size = new System.Drawing.Size(108, 43);
            this.maintanceBtn.TabIndex = 21;
            this.maintanceBtn.Text = "Select Maintance";
            this.maintanceBtn.UseVisualStyleBackColor = true;
            this.maintanceBtn.Click += new System.EventHandler(this.maintanceBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Oil Change",
            "Wheel Rotation",
            "Brakes Check"});
            this.listBox1.Location = new System.Drawing.Point(551, 222);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 82);
            this.listBox1.TabIndex = 20;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(899, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Accessories";
            // 
            // addAccessoryBtn
            // 
            this.addAccessoryBtn.Enabled = false;
            this.addAccessoryBtn.Location = new System.Drawing.Point(939, 289);
            this.addAccessoryBtn.Name = "addAccessoryBtn";
            this.addAccessoryBtn.Size = new System.Drawing.Size(108, 43);
            this.addAccessoryBtn.TabIndex = 24;
            this.addAccessoryBtn.Text = "Add Accessory";
            this.addAccessoryBtn.UseVisualStyleBackColor = true;
            this.addAccessoryBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Floor Mat",
            "Seat Cover",
            "Auto Starter",
            "Passenger Video Screen",
            "Tire Pressure Monitor",
            "Car Alarm",
            "Phone Mount"});
            this.listBox2.Location = new System.Drawing.Point(919, 55);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(145, 199);
            this.listBox2.TabIndex = 23;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1087, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Number of Video Screens";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(607, 639);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 43);
            this.button2.TabIndex = 27;
            this.button2.Text = "Order Vehicle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 715);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addAccessoryBtn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maintanceBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addColorBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.colorListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addFuelBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fuelListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.addPartsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accesoriesListBox);
            this.Controls.Add(this.addVehicleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleListBox);
            this.Name = "Form1";
            this.Text = "Customize Vehicle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox vehicleListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addVehicleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox accesoriesListBox;
        private System.Windows.Forms.Button addPartsBtn;
        private System.Windows.Forms.ListBox fuelListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addFuelBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox colorListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addColorBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button maintanceBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addAccessoryBtn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.TextBox textBox1;
    }
}

