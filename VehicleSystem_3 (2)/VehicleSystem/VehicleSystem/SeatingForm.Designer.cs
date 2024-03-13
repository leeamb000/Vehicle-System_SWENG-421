namespace VehicleSystem
{
    partial class SeatingCapacityForm
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.addSeatsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 69);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // addSeatsBtn
            // 
            this.addSeatsBtn.Location = new System.Drawing.Point(95, 120);
            this.addSeatsBtn.Name = "addSeatsBtn";
            this.addSeatsBtn.Size = new System.Drawing.Size(108, 43);
            this.addSeatsBtn.TabIndex = 13;
            this.addSeatsBtn.Text = "AddComponent";
            this.addSeatsBtn.UseVisualStyleBackColor = true;
            this.addSeatsBtn.Click += new System.EventHandler(this.addSeatsBtn_Click);
            // 
            // SeatingCapacityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 198);
            this.Controls.Add(this.addSeatsBtn);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "SeatingCapacityForm";
            this.Text = "Seating Capacity";
            this.Load += new System.EventHandler(this.SeatingCapacityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addSeatsBtn;
        internal System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}