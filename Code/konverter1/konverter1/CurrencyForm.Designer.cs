namespace konverter1
{
    partial class CurrencyForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageBox = new System.Windows.Forms.TextBox();
            this.fromAmount = new System.Windows.Forms.TextBox();
            this.toAmount = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.fromCurrency = new System.Windows.Forms.ComboBox();
            this.toCurrency = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 12);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(334, 259);
            this.messageBox.TabIndex = 0;
            // 
            // fromAmount
            // 
            this.fromAmount.Location = new System.Drawing.Point(12, 317);
            this.fromAmount.Name = "fromAmount";
            this.fromAmount.Size = new System.Drawing.Size(135, 22);
            this.fromAmount.TabIndex = 1;
            this.fromAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FromAmont_KeyUp);
            // 
            // toAmount
            // 
            this.toAmount.Location = new System.Drawing.Point(316, 317);
            this.toAmount.Name = "toAmount";
            this.toAmount.ReadOnly = true;
            this.toAmount.Size = new System.Drawing.Size(136, 22);
            this.toAmount.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(268, 402);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(109, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Перевести";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // fromCurrency
            // 
            this.fromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromCurrency.FormattingEnabled = true;
            this.fromCurrency.Items.AddRange(new object[] {
            "BYN",
            "USD",
            "EUR",
            "RUB"});
            this.fromCurrency.Location = new System.Drawing.Point(166, 315);
            this.fromCurrency.Name = "fromCurrency";
            this.fromCurrency.Size = new System.Drawing.Size(121, 24);
            this.fromCurrency.TabIndex = 6;
            // 
            // toCurrency
            // 
            this.toCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toCurrency.FormattingEnabled = true;
            this.toCurrency.Items.AddRange(new object[] {
            "BYN",
            "USD",
            "EUR",
            "RUB"});
            this.toCurrency.Location = new System.Drawing.Point(500, 315);
            this.toCurrency.Name = "toCurrency";
            this.toCurrency.Size = new System.Drawing.Size(121, 24);
            this.toCurrency.TabIndex = 7;
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 437);
            this.Controls.Add(this.toCurrency);
            this.Controls.Add(this.fromCurrency);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.toAmount);
            this.Controls.Add(this.fromAmount);
            this.Controls.Add(this.messageBox);
            this.Name = "CurrencyForm";
            this.Text = "Currency converter by SHAMILYOVA KSENIA 550503";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox fromAmount;
        private System.Windows.Forms.TextBox toAmount;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.ComboBox fromCurrency;
        private System.Windows.Forms.ComboBox toCurrency;
    }
}

