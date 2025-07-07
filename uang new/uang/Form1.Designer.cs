using System;

namespace uang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.AmountToConvertBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ToCurrencyBox = new System.Windows.Forms.ComboBox();
            this.FromCurrencyBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RateDisplay = new System.Windows.Forms.Label();
            this.ConvertedAmountDisplay = new System.Windows.Forms.Label();
            this.picUI2 = new System.Windows.Forms.PictureBox();
            this.picUI3 = new System.Windows.Forms.PictureBox();
            this.picUI4 = new System.Windows.Forms.PictureBox();
            this.picUI5 = new System.Windows.Forms.PictureBox();
            this.picUI1 = new System.Windows.Forms.PictureBox();
            this.picUI6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUI3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUI4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUI5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUI6)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Amount to Convent";
            // 
            // AmountToConvertBox
            // 
            this.AmountToConvertBox.Location = new System.Drawing.Point(172, 261);
            this.AmountToConvertBox.Name = "AmountToConvertBox";
            this.AmountToConvertBox.Size = new System.Drawing.Size(169, 20);
            this.AmountToConvertBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "To Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "From Currency";
            // 
            // ToCurrencyBox
            // 
            this.ToCurrencyBox.FormattingEnabled = true;
            this.ToCurrencyBox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "IDR",
            "JPY",
            "AUD",
            "CAD",
            "CHF",
            "CNY",
            "INR"});
            this.ToCurrencyBox.Location = new System.Drawing.Point(172, 395);
            this.ToCurrencyBox.Name = "ToCurrencyBox";
            this.ToCurrencyBox.Size = new System.Drawing.Size(169, 21);
            this.ToCurrencyBox.TabIndex = 11;
            // 
            // FromCurrencyBox
            // 
            this.FromCurrencyBox.FormattingEnabled = true;
            this.FromCurrencyBox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "IDR",
            "JPY",
            "AUD",
            "CAD",
            "CHF",
            "CNY",
            "INR"});
            this.FromCurrencyBox.Location = new System.Drawing.Point(172, 348);
            this.FromCurrencyBox.Name = "FromCurrencyBox";
            this.FromCurrencyBox.Size = new System.Drawing.Size(169, 21);
            this.FromCurrencyBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(195, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Currency Converter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RateDisplay
            // 
            this.RateDisplay.AutoSize = true;
            this.RateDisplay.BackColor = System.Drawing.Color.White;
            this.RateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateDisplay.Location = new System.Drawing.Point(104, 142);
            this.RateDisplay.Name = "RateDisplay";
            this.RateDisplay.Size = new System.Drawing.Size(291, 29);
            this.RateDisplay.TabIndex = 17;
            this.RateDisplay.Text = "Conversion Rate: 1$ = ???";
            // 
            // ConvertedAmountDisplay
            // 
            this.ConvertedAmountDisplay.AutoSize = true;
            this.ConvertedAmountDisplay.BackColor = System.Drawing.Color.White;
            this.ConvertedAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertedAmountDisplay.Location = new System.Drawing.Point(118, 171);
            this.ConvertedAmountDisplay.Name = "ConvertedAmountDisplay";
            this.ConvertedAmountDisplay.Size = new System.Drawing.Size(263, 29);
            this.ConvertedAmountDisplay.TabIndex = 18;
            this.ConvertedAmountDisplay.Text = "Converted amount : ???";
            // 
            // picUI2
            // 
            this.picUI2.Image = ((System.Drawing.Image)(resources.GetObject("picUI2.Image")));
            this.picUI2.Location = new System.Drawing.Point(127, 31);
            this.picUI2.Name = "picUI2";
            this.picUI2.Size = new System.Drawing.Size(253, 58);
            this.picUI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUI2.TabIndex = 20;
            this.picUI2.TabStop = false;
            // 
            // picUI3
            // 
            this.picUI3.Image = ((System.Drawing.Image)(resources.GetObject("picUI3.Image")));
            this.picUI3.Location = new System.Drawing.Point(27, 128);
            this.picUI3.Name = "picUI3";
            this.picUI3.Size = new System.Drawing.Size(457, 87);
            this.picUI3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUI3.TabIndex = 21;
            this.picUI3.TabStop = false;
            // 
            // picUI4
            // 
            this.picUI4.Image = ((System.Drawing.Image)(resources.GetObject("picUI4.Image")));
            this.picUI4.Location = new System.Drawing.Point(164, 227);
            this.picUI4.Name = "picUI4";
            this.picUI4.Size = new System.Drawing.Size(186, 65);
            this.picUI4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUI4.TabIndex = 22;
            this.picUI4.TabStop = false;
            // 
            // picUI5
            // 
            this.picUI5.Image = ((System.Drawing.Image)(resources.GetObject("picUI5.Image")));
            this.picUI5.Location = new System.Drawing.Point(159, 312);
            this.picUI5.Name = "picUI5";
            this.picUI5.Size = new System.Drawing.Size(198, 119);
            this.picUI5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUI5.TabIndex = 23;
            this.picUI5.TabStop = false;
            // 
            // picUI1
            // 
            this.picUI1.Image = ((System.Drawing.Image)(resources.GetObject("picUI1.Image")));
            this.picUI1.Location = new System.Drawing.Point(0, 2);
            this.picUI1.Name = "picUI1";
            this.picUI1.Size = new System.Drawing.Size(511, 532);
            this.picUI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUI1.TabIndex = 24;
            this.picUI1.TabStop = false;
            // 
            // picUI6
            // 
            this.picUI6.Image = ((System.Drawing.Image)(resources.GetObject("picUI6.Image")));
            this.picUI6.Location = new System.Drawing.Point(185, 448);
            this.picUI6.Name = "picUI6";
            this.picUI6.Size = new System.Drawing.Size(142, 58);
            this.picUI6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUI6.TabIndex = 25;
            this.picUI6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 534);
            this.Controls.Add(this.ConvertedAmountDisplay);
            this.Controls.Add(this.RateDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmountToConvertBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToCurrencyBox);
            this.Controls.Add(this.FromCurrencyBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picUI2);
            this.Controls.Add(this.picUI3);
            this.Controls.Add(this.picUI4);
            this.Controls.Add(this.picUI5);
            this.Controls.Add(this.picUI6);
            this.Controls.Add(this.picUI1);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUI3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUI4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUI5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUI6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountToConvertBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ToCurrencyBox;
        private System.Windows.Forms.ComboBox FromCurrencyBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RateDisplay;
        private System.Windows.Forms.Label ConvertedAmountDisplay;
        private System.Windows.Forms.PictureBox picUI2;
        private System.Windows.Forms.PictureBox picUI3;
        private System.Windows.Forms.PictureBox picUI4;
        private System.Windows.Forms.PictureBox picUI5;
        private System.Windows.Forms.PictureBox picUI1;
        private System.Windows.Forms.PictureBox picUI6;
    }
}

