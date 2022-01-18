namespace BitcoinCalculator2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.currencyMenu = new System.Windows.Forms.ComboBox();
            this.getRatesBTN = new System.Windows.Forms.Button();
            this.amountOfBtc = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyMenu
            // 
            this.currencyMenu.FormattingEnabled = true;
            this.currencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.currencyMenu.Location = new System.Drawing.Point(450, 86);
            this.currencyMenu.Name = "currencyMenu";
            this.currencyMenu.Size = new System.Drawing.Size(121, 24);
            this.currencyMenu.TabIndex = 0;
            this.currencyMenu.Text = "Select currency";
            // 
            // getRatesBTN
            // 
            this.getRatesBTN.Location = new System.Drawing.Point(594, 126);
            this.getRatesBTN.Name = "getRatesBTN";
            this.getRatesBTN.Size = new System.Drawing.Size(75, 23);
            this.getRatesBTN.TabIndex = 1;
            this.getRatesBTN.Text = "Get Rates";
            this.getRatesBTN.UseVisualStyleBackColor = true;
            this.getRatesBTN.Click += new System.EventHandler(this.getRadesBTN_Click);
            // 
            // amountOfBtc
            // 
            this.amountOfBtc.Location = new System.Drawing.Point(450, 126);
            this.amountOfBtc.Name = "amountOfBtc";
            this.amountOfBtc.Size = new System.Drawing.Size(121, 22);
            this.amountOfBtc.TabIndex = 2;
            this.amountOfBtc.Text = "Amount Of Bitcoins";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(591, 258);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(126, 22);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(591, 236);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 16);
            this.label.TabIndex = 4;
            this.label.Text = "result";
            this.label.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBtc);
            this.Controls.Add(this.getRatesBTN);
            this.Controls.Add(this.currencyMenu);
            this.Name = "Form2";
            this.Text = "BitcoinCalculator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.Button getRatesBTN;
        private System.Windows.Forms.TextBox amountOfBtc;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label;
    }
}