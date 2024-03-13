
namespace VehicleSystem
{
    partial class SuspensionForm
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
            this.strutCheckBox = new System.Windows.Forms.CheckBox();
            this.springCheckBox = new System.Windows.Forms.CheckBox();
            this.shockCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // strutCheckBox
            // 
            this.strutCheckBox.AutoSize = true;
            this.strutCheckBox.Location = new System.Drawing.Point(69, 178);
            this.strutCheckBox.Name = "strutCheckBox";
            this.strutCheckBox.Size = new System.Drawing.Size(48, 17);
            this.strutCheckBox.TabIndex = 4;
            this.strutCheckBox.Text = "Strut";
            this.strutCheckBox.UseVisualStyleBackColor = true;
            this.strutCheckBox.CheckedChanged += new System.EventHandler(this.strutCheckBox_CheckedChanged);
            // 
            // springCheckBox
            // 
            this.springCheckBox.AutoSize = true;
            this.springCheckBox.Location = new System.Drawing.Point(69, 211);
            this.springCheckBox.Name = "springCheckBox";
            this.springCheckBox.Size = new System.Drawing.Size(56, 17);
            this.springCheckBox.TabIndex = 5;
            this.springCheckBox.Text = "Spring";
            this.springCheckBox.UseVisualStyleBackColor = true;
            this.springCheckBox.CheckedChanged += new System.EventHandler(this.springCheckBox_CheckedChanged);
            // 
            // shockCheckBox
            // 
            this.shockCheckBox.AutoSize = true;
            this.shockCheckBox.Location = new System.Drawing.Point(69, 245);
            this.shockCheckBox.Name = "shockCheckBox";
            this.shockCheckBox.Size = new System.Drawing.Size(102, 17);
            this.shockCheckBox.TabIndex = 6;
            this.shockCheckBox.Text = "Shock Absorber";
            this.shockCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Suspension Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose Parts";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "AddComponent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Rear",
            "Front"});
            this.listBox1.Location = new System.Drawing.Point(69, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(115, 43);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SuspensionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 361);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shockCheckBox);
            this.Controls.Add(this.springCheckBox);
            this.Controls.Add(this.strutCheckBox);
            this.Name = "SuspensionForm";
            this.Text = "SuspensionForm";
            this.Load += new System.EventHandler(this.SuspensionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox strutCheckBox;
        private System.Windows.Forms.CheckBox springCheckBox;
        private System.Windows.Forms.CheckBox shockCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}