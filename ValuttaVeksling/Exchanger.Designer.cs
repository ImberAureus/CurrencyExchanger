namespace ValuttaVeksling
{
    partial class Exchanger
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
            this.fromCurrencyLabel = new System.Windows.Forms.Label();
            this.toCurrencyLabel = new System.Windows.Forms.Label();
            this.fromCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.toCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.getCurrencyExchangeRateButton = new System.Windows.Forms.Button();
            this.toPayLabel = new System.Windows.Forms.Label();
            this.toPayTextBox = new System.Windows.Forms.TextBox();
            this.acceptExchangeButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.toPayCurrencyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromCurrencyLabel
            // 
            this.fromCurrencyLabel.AutoSize = true;
            this.fromCurrencyLabel.Location = new System.Drawing.Point(19, 57);
            this.fromCurrencyLabel.Name = "fromCurrencyLabel";
            this.fromCurrencyLabel.Size = new System.Drawing.Size(58, 13);
            this.fromCurrencyLabel.TabIndex = 0;
            this.fromCurrencyLabel.Text = "Fra Valutta";
            // 
            // toCurrencyLabel
            // 
            this.toCurrencyLabel.AutoSize = true;
            this.toCurrencyLabel.Location = new System.Drawing.Point(223, 57);
            this.toCurrencyLabel.Name = "toCurrencyLabel";
            this.toCurrencyLabel.Size = new System.Drawing.Size(54, 13);
            this.toCurrencyLabel.TabIndex = 1;
            this.toCurrencyLabel.Text = "Til Valutta";
            // 
            // fromCurrencyComboBox
            // 
            this.fromCurrencyComboBox.FormattingEnabled = true;
            this.fromCurrencyComboBox.Location = new System.Drawing.Point(22, 84);
            this.fromCurrencyComboBox.Name = "fromCurrencyComboBox";
            this.fromCurrencyComboBox.Size = new System.Drawing.Size(157, 21);
            this.fromCurrencyComboBox.TabIndex = 2;
            // 
            // toCurrencyComboBox
            // 
            this.toCurrencyComboBox.FormattingEnabled = true;
            this.toCurrencyComboBox.Location = new System.Drawing.Point(226, 84);
            this.toCurrencyComboBox.Name = "toCurrencyComboBox";
            this.toCurrencyComboBox.Size = new System.Drawing.Size(157, 21);
            this.toCurrencyComboBox.TabIndex = 3;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(19, 140);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(34, 13);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "Beløp";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(22, 165);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(124, 20);
            this.amountTextBox.TabIndex = 5;
            // 
            // getCurrencyExchangeRateButton
            // 
            this.getCurrencyExchangeRateButton.Location = new System.Drawing.Point(223, 165);
            this.getCurrencyExchangeRateButton.Name = "getCurrencyExchangeRateButton";
            this.getCurrencyExchangeRateButton.Size = new System.Drawing.Size(137, 23);
            this.getCurrencyExchangeRateButton.TabIndex = 6;
            this.getCurrencyExchangeRateButton.Text = "Hent Vekslingsforhold";
            this.getCurrencyExchangeRateButton.UseVisualStyleBackColor = true;
            this.getCurrencyExchangeRateButton.Click += new System.EventHandler(this.GetExchangeRateButton_OnClick);
            // 
            // toPayLabel
            // 
            this.toPayLabel.AutoSize = true;
            this.toPayLabel.Location = new System.Drawing.Point(19, 232);
            this.toPayLabel.Name = "toPayLabel";
            this.toPayLabel.Size = new System.Drawing.Size(69, 13);
            this.toPayLabel.TabIndex = 7;
            this.toPayLabel.Text = "Til Utbetaling";
            // 
            // toPayTextBox
            // 
            this.toPayTextBox.Location = new System.Drawing.Point(22, 258);
            this.toPayTextBox.Name = "toPayTextBox";
            this.toPayTextBox.ReadOnly = true;
            this.toPayTextBox.Size = new System.Drawing.Size(124, 20);
            this.toPayTextBox.TabIndex = 8;
            // 
            // acceptExchangeButton
            // 
            this.acceptExchangeButton.Location = new System.Drawing.Point(223, 255);
            this.acceptExchangeButton.Name = "acceptExchangeButton";
            this.acceptExchangeButton.Size = new System.Drawing.Size(137, 23);
            this.acceptExchangeButton.TabIndex = 9;
            this.acceptExchangeButton.Text = "Veksle";
            this.acceptExchangeButton.UseVisualStyleBackColor = true;
            this.acceptExchangeButton.Click += new System.EventHandler(this.AcceptExchangeRateButton_OnClick);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(157, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(65, 29);
            this.settingsButton.TabIndex = 10;
            this.settingsButton.Text = "Instillinger";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_OnClick);
            // 
            // toPayCurrencyLabel
            // 
            this.toPayCurrencyLabel.AutoSize = true;
            this.toPayCurrencyLabel.Location = new System.Drawing.Point(153, 264);
            this.toPayCurrencyLabel.Name = "toPayCurrencyLabel";
            this.toPayCurrencyLabel.Size = new System.Drawing.Size(0, 13);
            this.toPayCurrencyLabel.TabIndex = 11;
            // 
            // Exchanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 302);
            this.Controls.Add(this.toPayCurrencyLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.acceptExchangeButton);
            this.Controls.Add(this.toPayTextBox);
            this.Controls.Add(this.toPayLabel);
            this.Controls.Add(this.getCurrencyExchangeRateButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.toCurrencyComboBox);
            this.Controls.Add(this.fromCurrencyComboBox);
            this.Controls.Add(this.toCurrencyLabel);
            this.Controls.Add(this.fromCurrencyLabel);
            this.Name = "Exchanger";
            this.Text = "ValuttaVeksler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromCurrencyLabel;
        private System.Windows.Forms.Label toCurrencyLabel;
        private System.Windows.Forms.ComboBox fromCurrencyComboBox;
        private System.Windows.Forms.ComboBox toCurrencyComboBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button getCurrencyExchangeRateButton;
        private System.Windows.Forms.Label toPayLabel;
        private System.Windows.Forms.TextBox toPayTextBox;
        private System.Windows.Forms.Button acceptExchangeButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label toPayCurrencyLabel;
    }
}

