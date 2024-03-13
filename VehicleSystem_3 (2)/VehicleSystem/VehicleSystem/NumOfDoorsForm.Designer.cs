namespace VehicleSystem
{
    partial class NumOfDoorsForm
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
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.addDoorsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(87, 72);
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
            this.numericUpDown3.Size = new System.Drawing.Size(144, 20);
            this.numericUpDown3.TabIndex = 20;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // addDoorsBtn
            // 
            this.addDoorsBtn.Location = new System.Drawing.Point(101, 123);
            this.addDoorsBtn.Name = "addDoorsBtn";
            this.addDoorsBtn.Size = new System.Drawing.Size(108, 43);
            this.addDoorsBtn.TabIndex = 21;
            this.addDoorsBtn.Text = "AddComponent";
            this.addDoorsBtn.UseVisualStyleBackColor = true;
            this.addDoorsBtn.Click += new System.EventHandler(this.addSeatsBtn_Click);
            // 
            // NumOfDoorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 224);
            this.Controls.Add(this.addDoorsBtn);
            this.Controls.Add(this.numericUpDown3);
            this.Name = "NumOfDoorsForm";
            this.Text = "NumOfDoorsForm";
            this.Load += new System.EventHandler(this.NumOfDoorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addDoorsBtn;
        internal System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}