namespace Lab3
{
    partial class SimpleRSA
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
            this.pbCode = new System.Windows.Forms.PictureBox();
            this.pbDecode = new System.Windows.Forms.PictureBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiaima = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCiphertext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlaintext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMahoa = new System.Windows.Forms.Button();
            this.tbE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCode
            // 
            this.pbCode.BackgroundImage = global::Lab3.Properties.Resources.muitenphai;
            this.pbCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCode.Location = new System.Drawing.Point(408, 354);
            this.pbCode.Name = "pbCode";
            this.pbCode.Size = new System.Drawing.Size(60, 89);
            this.pbCode.TabIndex = 39;
            this.pbCode.TabStop = false;
            // 
            // pbDecode
            // 
            this.pbDecode.BackgroundImage = global::Lab3.Properties.Resources.muitentrai;
            this.pbDecode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDecode.Location = new System.Drawing.Point(408, 354);
            this.pbDecode.Name = "pbDecode";
            this.pbDecode.Size = new System.Drawing.Size(60, 89);
            this.pbDecode.TabIndex = 38;
            this.pbDecode.TabStop = false;
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(926, 257);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(245, 26);
            this.tbQ.TabIndex = 34;
            this.tbQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(880, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "q:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(1057, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 49);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(925, 218);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(245, 26);
            this.tbP.TabIndex = 35;
            this.tbP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(880, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "p:";
            // 
            // btnGiaima
            // 
            this.btnGiaima.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGiaima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiaima.Location = new System.Drawing.Point(957, 509);
            this.btnGiaima.Name = "btnGiaima";
            this.btnGiaima.Size = new System.Drawing.Size(173, 49);
            this.btnGiaima.TabIndex = 31;
            this.btnGiaima.Text = "GIẢI MÃ";
            this.btnGiaima.UseVisualStyleBackColor = false;
            this.btnGiaima.Click += new System.EventHandler(this.btnGiaima_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ciphertext:";
            // 
            // tbCiphertext
            // 
            this.tbCiphertext.Location = new System.Drawing.Point(506, 210);
            this.tbCiphertext.Multiline = true;
            this.tbCiphertext.Name = "tbCiphertext";
            this.tbCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCiphertext.Size = new System.Drawing.Size(333, 419);
            this.tbCiphertext.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Plaintext :";
            // 
            // tbPlaintext
            // 
            this.tbPlaintext.Location = new System.Drawing.Point(36, 210);
            this.tbPlaintext.Multiline = true;
            this.tbPlaintext.Name = "tbPlaintext";
            this.tbPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPlaintext.Size = new System.Drawing.Size(333, 419);
            this.tbPlaintext.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 52);
            this.label1.TabIndex = 26;
            this.label1.Text = "Simple RSA";
            // 
            // btnMahoa
            // 
            this.btnMahoa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMahoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMahoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMahoa.Location = new System.Drawing.Point(957, 444);
            this.btnMahoa.Name = "btnMahoa";
            this.btnMahoa.Size = new System.Drawing.Size(173, 49);
            this.btnMahoa.TabIndex = 25;
            this.btnMahoa.Text = "MÃ HÓA";
            this.btnMahoa.UseVisualStyleBackColor = false;
            this.btnMahoa.Click += new System.EventHandler(this.btnMahoa_Click);
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(926, 296);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(245, 26);
            this.tbE.TabIndex = 40;
            this.tbE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(880, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 29);
            this.label6.TabIndex = 41;
            this.label6.Text = "e:";
            // 
            // SimpleRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbCode);
            this.Controls.Add(this.pbDecode);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGiaima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCiphertext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPlaintext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMahoa);
            this.Name = "SimpleRSA";
            this.Text = "SimpleRSA";
            this.Load += new System.EventHandler(this.SimpleRSA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCode;
        private System.Windows.Forms.PictureBox pbDecode;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGiaima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCiphertext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlaintext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMahoa;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.Label label6;
    }
}