namespace Lab3
{
    partial class NumberTheory
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
            this.btn8bitprime = new System.Windows.Forms.RadioButton();
            this.btn16bitprime = new System.Windows.Forms.RadioButton();
            this.btn64bitprime = new System.Windows.Forms.RadioButton();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnMersenne = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn8bitprime
            // 
            this.btn8bitprime.AutoSize = true;
            this.btn8bitprime.Location = new System.Drawing.Point(35, 45);
            this.btn8bitprime.Name = "btn8bitprime";
            this.btn8bitprime.Size = new System.Drawing.Size(224, 24);
            this.btn8bitprime.TabIndex = 0;
            this.btn8bitprime.TabStop = true;
            this.btn8bitprime.Text = "8-bit random prime number";
            this.btn8bitprime.UseVisualStyleBackColor = true;
            this.btn8bitprime.CheckedChanged += new System.EventHandler(this.btn8bitprime_CheckedChanged);
            // 
            // btn16bitprime
            // 
            this.btn16bitprime.AutoSize = true;
            this.btn16bitprime.Location = new System.Drawing.Point(297, 45);
            this.btn16bitprime.Name = "btn16bitprime";
            this.btn16bitprime.Size = new System.Drawing.Size(233, 24);
            this.btn16bitprime.TabIndex = 1;
            this.btn16bitprime.TabStop = true;
            this.btn16bitprime.Text = "16-bit random prime number";
            this.btn16bitprime.UseVisualStyleBackColor = true;
            this.btn16bitprime.CheckedChanged += new System.EventHandler(this.btn16bitprime_CheckedChanged);
            // 
            // btn64bitprime
            // 
            this.btn64bitprime.AutoSize = true;
            this.btn64bitprime.Location = new System.Drawing.Point(551, 45);
            this.btn64bitprime.Name = "btn64bitprime";
            this.btn64bitprime.Size = new System.Drawing.Size(233, 24);
            this.btn64bitprime.TabIndex = 2;
            this.btn64bitprime.TabStop = true;
            this.btn64bitprime.Text = "64-bit random prime number";
            this.btn64bitprime.UseVisualStyleBackColor = true;
            this.btn64bitprime.CheckedChanged += new System.EventHandler(this.btn64bitprime_CheckedChanged);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(35, 213);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(810, 195);
            this.tbText.TabIndex = 3;
            this.tbText.TextChanged += new System.EventHandler(this.tbText_TextChanged);
            // 
            // btnMersenne
            // 
            this.btnMersenne.AutoSize = true;
            this.btnMersenne.Location = new System.Drawing.Point(35, 95);
            this.btnMersenne.Name = "btnMersenne";
            this.btnMersenne.Size = new System.Drawing.Size(407, 24);
            this.btnMersenne.TabIndex = 4;
            this.btnMersenne.TabStop = true;
            this.btnMersenne.Text = "10 largest primee nummbers under 10 fisrt Mersenne";
            this.btnMersenne.UseVisualStyleBackColor = true;
            this.btnMersenne.CheckedChanged += new System.EventHandler(this.btnMersenne_CheckedChanged);
            // 
            // NumberTheory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1772, 1038);
            this.Controls.Add(this.btnMersenne);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btn64bitprime);
            this.Controls.Add(this.btn16bitprime);
            this.Controls.Add(this.btn8bitprime);
            this.Name = "NumberTheory";
            this.Text = "NumberTheory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btn8bitprime;
        private System.Windows.Forms.RadioButton btn16bitprime;
        private System.Windows.Forms.RadioButton btn64bitprime;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.RadioButton btnMersenne;
    }
}