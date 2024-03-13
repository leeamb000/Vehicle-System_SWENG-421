namespace VehicleSystem
{
    partial class SpareTireForm
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
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.spareTireBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(103, 84);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // spareTireBtn
            // 
            this.spareTireBtn.Location = new System.Drawing.Point(115, 125);
            this.spareTireBtn.Name = "spareTireBtn";
            this.spareTireBtn.Size = new System.Drawing.Size(108, 43);
            this.spareTireBtn.TabIndex = 22;
            this.spareTireBtn.Text = "AddComponent";
            this.spareTireBtn.UseVisualStyleBackColor = true;
            this.spareTireBtn.Click += new System.EventHandler(this.rimSizeBtn_Click);
            // 
            // SpareTireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 240);
            this.Controls.Add(this.spareTireBtn);
            this.Controls.Add(this.numericUpDown2);
            this.Name = "SpareTireForm";
            this.Text = "SpareTireForm";
            this.Load += new System.EventHandler(this.SpareTireForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button spareTireBtn;
        internal System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}