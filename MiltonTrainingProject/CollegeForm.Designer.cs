namespace MiltonTrainingProject
{
    partial class CollegeForm
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
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.addCollegebtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(12, 12);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(171, 20);
            this.txtCName.TabIndex = 0;
            this.txtCName.Text = "Name";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(215, 13);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 1;
            this.txtCity.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(12, 59);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(158, 20);
            this.txtStreet.TabIndex = 3;
            this.txtStreet.Text = "Street";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(13, 98);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 4;
            this.txtZip.Text = "Zip Code";
            // 
            // addCollegebtn
            // 
            this.addCollegebtn.Location = new System.Drawing.Point(38, 159);
            this.addCollegebtn.Name = "addCollegebtn";
            this.addCollegebtn.Size = new System.Drawing.Size(75, 23);
            this.addCollegebtn.TabIndex = 5;
            this.addCollegebtn.Text = "ADD";
            this.addCollegebtn.UseVisualStyleBackColor = true;
            this.addCollegebtn.Click += new System.EventHandler(this.addCollegebtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(194, 59);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(121, 21);
            this.cbState.TabIndex = 7;
            this.cbState.Text = "State";
            // 
            // CollegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 208);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addCollegebtn);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCName);
            this.Name = "CollegeForm";
            this.Text = "CollegeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button addCollegebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbState;
    }
}