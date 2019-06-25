namespace ValuttaVeksling
{
    partial class Settings
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
            this.commisionLabel = new System.Windows.Forms.Label();
            this.percentageTextBox = new System.Windows.Forms.TextBox();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commisionLabel
            // 
            this.commisionLabel.AutoSize = true;
            this.commisionLabel.Location = new System.Drawing.Point(22, 22);
            this.commisionLabel.Name = "commisionLabel";
            this.commisionLabel.Size = new System.Drawing.Size(57, 13);
            this.commisionLabel.TabIndex = 0;
            this.commisionLabel.Text = "Kommisjon";
            // 
            // percentageTextBox
            // 
            this.percentageTextBox.Location = new System.Drawing.Point(107, 22);
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.Size = new System.Drawing.Size(23, 20);
            this.percentageTextBox.TabIndex = 1;
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageLabel.Location = new System.Drawing.Point(136, 23);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(18, 15);
            this.percentageLabel.TabIndex = 2;
            this.percentageLabel.Text = "%";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 67);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Lagre Instillinger";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_OnClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(148, 66);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Avbryt";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_OnClick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.percentageTextBox);
            this.Controls.Add(this.commisionLabel);
            this.Name = "Settings";
            this.Text = "ValuttaVeksler - Instillinger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label commisionLabel;
        private System.Windows.Forms.TextBox percentageTextBox;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}