namespace ValuttaVeksling
{
    partial class Receipt
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
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.amountLabel1 = new System.Windows.Forms.Label();
            this.commisionLabel1 = new System.Windows.Forms.Label();
            this.toPayLabel1 = new System.Windows.Forms.Label();
            this.exchangeRateLabel = new System.Windows.Forms.Label();
            this.dateLabel2 = new System.Windows.Forms.Label();
            this.amountLabel2 = new System.Windows.Forms.Label();
            this.commisionLabel2 = new System.Windows.Forms.Label();
            this.toPayLabel2 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateLabel1
            // 
            this.dateLabel1.AutoSize = true;
            this.dateLabel1.Location = new System.Drawing.Point(13, 25);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(33, 13);
            this.dateLabel1.TabIndex = 0;
            this.dateLabel1.Text = "Dato:";
            // 
            // amountLabel1
            // 
            this.amountLabel1.AutoSize = true;
            this.amountLabel1.Location = new System.Drawing.Point(13, 47);
            this.amountLabel1.Name = "amountLabel1";
            this.amountLabel1.Size = new System.Drawing.Size(37, 13);
            this.amountLabel1.TabIndex = 1;
            this.amountLabel1.Text = "Beløp:";
            // 
            // commisionLabel1
            // 
            this.commisionLabel1.AutoSize = true;
            this.commisionLabel1.Location = new System.Drawing.Point(12, 69);
            this.commisionLabel1.Name = "commisionLabel1";
            this.commisionLabel1.Size = new System.Drawing.Size(60, 13);
            this.commisionLabel1.TabIndex = 2;
            this.commisionLabel1.Text = "Kommisjon:";
            // 
            // toPayLabel1
            // 
            this.toPayLabel1.AutoSize = true;
            this.toPayLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPayLabel1.Location = new System.Drawing.Point(13, 102);
            this.toPayLabel1.Name = "toPayLabel1";
            this.toPayLabel1.Size = new System.Drawing.Size(75, 13);
            this.toPayLabel1.TabIndex = 3;
            this.toPayLabel1.Text = "UTBETALT:";
            // 
            // exchangeRateLabel
            // 
            this.exchangeRateLabel.AutoSize = true;
            this.exchangeRateLabel.Location = new System.Drawing.Point(12, 150);
            this.exchangeRateLabel.Name = "exchangeRateLabel";
            this.exchangeRateLabel.Size = new System.Drawing.Size(42, 13);
            this.exchangeRateLabel.TabIndex = 4;
            this.exchangeRateLabel.Text = "Forhold";
            // 
            // dateLabel2
            // 
            this.dateLabel2.AutoSize = true;
            this.dateLabel2.Location = new System.Drawing.Point(107, 25);
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.Size = new System.Drawing.Size(30, 13);
            this.dateLabel2.TabIndex = 5;
            this.dateLabel2.Text = "Dato";
            // 
            // amountLabel2
            // 
            this.amountLabel2.AutoSize = true;
            this.amountLabel2.Location = new System.Drawing.Point(107, 47);
            this.amountLabel2.Name = "amountLabel2";
            this.amountLabel2.Size = new System.Drawing.Size(34, 13);
            this.amountLabel2.TabIndex = 6;
            this.amountLabel2.Text = "Beløp";
            // 
            // commisionLabel2
            // 
            this.commisionLabel2.AutoSize = true;
            this.commisionLabel2.Location = new System.Drawing.Point(107, 69);
            this.commisionLabel2.Name = "commisionLabel2";
            this.commisionLabel2.Size = new System.Drawing.Size(57, 13);
            this.commisionLabel2.TabIndex = 7;
            this.commisionLabel2.Text = "Kommisjon";
            // 
            // toPayLabel2
            // 
            this.toPayLabel2.AutoSize = true;
            this.toPayLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPayLabel2.Location = new System.Drawing.Point(107, 102);
            this.toPayLabel2.Name = "toPayLabel2";
            this.toPayLabel2.Size = new System.Drawing.Size(87, 13);
            this.toPayLabel2.TabIndex = 8;
            this.toPayLabel2.Text = "Utbetalt beløp";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(101, 212);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "Ferdig";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_OnClick);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.toPayLabel2);
            this.Controls.Add(this.commisionLabel2);
            this.Controls.Add(this.amountLabel2);
            this.Controls.Add(this.dateLabel2);
            this.Controls.Add(this.exchangeRateLabel);
            this.Controls.Add(this.toPayLabel1);
            this.Controls.Add(this.commisionLabel1);
            this.Controls.Add(this.amountLabel1);
            this.Controls.Add(this.dateLabel1);
            this.Name = "Receipt";
            this.Text = "ValuttaVeksler - Kvittering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel1;
        private System.Windows.Forms.Label amountLabel1;
        private System.Windows.Forms.Label commisionLabel1;
        private System.Windows.Forms.Label toPayLabel1;
        private System.Windows.Forms.Label exchangeRateLabel;
        private System.Windows.Forms.Label dateLabel2;
        private System.Windows.Forms.Label amountLabel2;
        private System.Windows.Forms.Label commisionLabel2;
        private System.Windows.Forms.Label toPayLabel2;
        private System.Windows.Forms.Button acceptButton;
    }
}