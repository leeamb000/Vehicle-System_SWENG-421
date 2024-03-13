namespace VehicleSystem
{
    partial class TransmissionForm
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
            this.transmissionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // transmissionListBox
            // 
            this.transmissionListBox.FormattingEnabled = true;
            this.transmissionListBox.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.transmissionListBox.Location = new System.Drawing.Point(65, 27);
            this.transmissionListBox.Name = "transmissionListBox";
            this.transmissionListBox.Size = new System.Drawing.Size(120, 43);
            this.transmissionListBox.TabIndex = 0;
            this.transmissionListBox.SelectedIndexChanged += new System.EventHandler(this.transmissionListBox_SelectedIndexChanged);
            // 
            // TransmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 115);
            this.Controls.Add(this.transmissionListBox);
            this.Name = "TransmissionForm";
            this.Text = "Transmission";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox transmissionListBox;
    }
}