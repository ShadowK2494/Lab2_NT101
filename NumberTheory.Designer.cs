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
            this.btnCheckPrime = new System.Windows.Forms.RadioButton();
            this.btnUCLN = new System.Windows.Forms.RadioButton();
            this.btnModular = new System.Windows.Forms.RadioButton();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn1_1_8 = new System.Windows.Forms.Button();
            this.btn1_1_16 = new System.Windows.Forms.Button();
            this.btn1_1_64 = new System.Windows.Forms.Button();
            this.btn1_2 = new System.Windows.Forms.Button();
            this.btn1_3 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn8bitprime
            // 
            this.btn8bitprime.AutoSize = true;
            this.btn8bitprime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn8bitprime.Location = new System.Drawing.Point(739, 172);
            this.btn8bitprime.Name = "btn8bitprime";
            this.btn8bitprime.Size = new System.Drawing.Size(315, 33);
            this.btn8bitprime.TabIndex = 0;
            this.btn8bitprime.TabStop = true;
            this.btn8bitprime.Text = "8-bit số nguyên tố random";
            this.btn8bitprime.UseVisualStyleBackColor = true;
            // 
            // btn16bitprime
            // 
            this.btn16bitprime.AutoSize = true;
            this.btn16bitprime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn16bitprime.Location = new System.Drawing.Point(735, 219);
            this.btn16bitprime.Name = "btn16bitprime";
            this.btn16bitprime.Size = new System.Drawing.Size(328, 33);
            this.btn16bitprime.TabIndex = 1;
            this.btn16bitprime.TabStop = true;
            this.btn16bitprime.Text = "16-bit số nguyên tố random";
            this.btn16bitprime.UseVisualStyleBackColor = true;
            // 
            // btn64bitprime
            // 
            this.btn64bitprime.AutoSize = true;
            this.btn64bitprime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn64bitprime.Location = new System.Drawing.Point(738, 264);
            this.btn64bitprime.Name = "btn64bitprime";
            this.btn64bitprime.Size = new System.Drawing.Size(328, 33);
            this.btn64bitprime.TabIndex = 2;
            this.btn64bitprime.TabStop = true;
            this.btn64bitprime.Text = "64-bit số nguyên tố random";
            this.btn64bitprime.UseVisualStyleBackColor = true;
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbText.Location = new System.Drawing.Point(184, 530);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(866, 136);
            this.tbText.TabIndex = 3;
            // 
            // btnMersenne
            // 
            this.btnMersenne.AutoSize = true;
            this.btnMersenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMersenne.Location = new System.Drawing.Point(80, 170);
            this.btnMersenne.Name = "btnMersenne";
            this.btnMersenne.Size = new System.Drawing.Size(540, 33);
            this.btnMersenne.TabIndex = 4;
            this.btnMersenne.TabStop = true;
            this.btnMersenne.Text = "8 số nguyên tố nhỏ hơn 8 số Mersenne lớn nhất";
            this.btnMersenne.UseVisualStyleBackColor = true;
            // 
            // btnCheckPrime
            // 
            this.btnCheckPrime.AutoSize = true;
            this.btnCheckPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCheckPrime.Location = new System.Drawing.Point(80, 214);
            this.btnCheckPrime.Name = "btnCheckPrime";
            this.btnCheckPrime.Size = new System.Drawing.Size(598, 33);
            this.btnCheckPrime.TabIndex = 5;
            this.btnCheckPrime.TabStop = true;
            this.btnCheckPrime.Text = "Kiểm tra xem INPUT có phải số nguyên tố hay không";
            this.btnCheckPrime.UseVisualStyleBackColor = true;
            // 
            // btnUCLN
            // 
            this.btnUCLN.AutoSize = true;
            this.btnUCLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUCLN.Location = new System.Drawing.Point(79, 259);
            this.btnUCLN.Name = "btnUCLN";
            this.btnUCLN.Size = new System.Drawing.Size(450, 33);
            this.btnUCLN.TabIndex = 6;
            this.btnUCLN.TabStop = true;
            this.btnUCLN.Text = "Tìm UCLN của 2 số từ INPUT (<=2^32)";
            this.btnUCLN.UseVisualStyleBackColor = true;
            // 
            // btnModular
            // 
            this.btnModular.AutoSize = true;
            this.btnModular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModular.Location = new System.Drawing.Point(80, 303);
            this.btnModular.Name = "btnModular";
            this.btnModular.Size = new System.Drawing.Size(877, 33);
            this.btnModular.TabIndex = 7;
            this.btnModular.TabStop = true;
            this.btnModular.Text = "Tính lũy thừa modular a^x mod p (với a, x, p được nhập theo thứ tự trong INPUT)";
            this.btnModular.UseVisualStyleBackColor = true;
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbInput.Location = new System.Drawing.Point(184, 378);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(866, 136);
            this.tbInput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(42, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "INPUT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(20, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "OUTPUT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 52);
            this.label3.TabIndex = 27;
            this.label3.Text = "Number Theory";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(1056, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 49);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn1_1_8
            // 
            this.btn1_1_8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn1_1_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_1_8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1_1_8.Location = new System.Drawing.Point(682, 168);
            this.btn1_1_8.Name = "btn1_1_8";
            this.btn1_1_8.Size = new System.Drawing.Size(81, 40);
            this.btn1_1_8.TabIndex = 38;
            this.btn1_1_8.Text = "1.1_8";
            this.btn1_1_8.UseVisualStyleBackColor = false;
            this.btn1_1_8.Click += new System.EventHandler(this.btn1_1_8_Click);
            // 
            // btn1_1_16
            // 
            this.btn1_1_16.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn1_1_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_1_16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1_1_16.Location = new System.Drawing.Point(681, 214);
            this.btn1_1_16.Name = "btn1_1_16";
            this.btn1_1_16.Size = new System.Drawing.Size(82, 40);
            this.btn1_1_16.TabIndex = 39;
            this.btn1_1_16.Text = "1.1_16";
            this.btn1_1_16.UseVisualStyleBackColor = false;
            this.btn1_1_16.Click += new System.EventHandler(this.btn1_1_16_Click);
            // 
            // btn1_1_64
            // 
            this.btn1_1_64.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn1_1_64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_1_64.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1_1_64.Location = new System.Drawing.Point(682, 260);
            this.btn1_1_64.Name = "btn1_1_64";
            this.btn1_1_64.Size = new System.Drawing.Size(82, 40);
            this.btn1_1_64.TabIndex = 40;
            this.btn1_1_64.Text = "1.1_64";
            this.btn1_1_64.UseVisualStyleBackColor = false;
            this.btn1_1_64.Click += new System.EventHandler(this.btn1_1_64_Click);
            // 
            // btn1_2
            // 
            this.btn1_2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1_2.Location = new System.Drawing.Point(33, 166);
            this.btn1_2.Name = "btn1_2";
            this.btn1_2.Size = new System.Drawing.Size(73, 40);
            this.btn1_2.TabIndex = 41;
            this.btn1_2.Text = "1.2";
            this.btn1_2.UseVisualStyleBackColor = false;
            this.btn1_2.Click += new System.EventHandler(this.btn1_2_Click);
            // 
            // btn1_3
            // 
            this.btn1_3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1_3.Location = new System.Drawing.Point(33, 210);
            this.btn1_3.Name = "btn1_3";
            this.btn1_3.Size = new System.Drawing.Size(73, 40);
            this.btn1_3.TabIndex = 42;
            this.btn1_3.Text = "1.3";
            this.btn1_3.UseVisualStyleBackColor = false;
            this.btn1_3.Click += new System.EventHandler(this.btn1_3_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(33, 300);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(73, 40);
            this.btn3.TabIndex = 43;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(33, 257);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(73, 40);
            this.btn2.TabIndex = 44;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // NumberTheory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1_3);
            this.Controls.Add(this.btn1_2);
            this.Controls.Add(this.btn1_1_64);
            this.Controls.Add(this.btn1_1_16);
            this.Controls.Add(this.btn1_1_8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnModular);
            this.Controls.Add(this.btnUCLN);
            this.Controls.Add(this.btnCheckPrime);
            this.Controls.Add(this.btnMersenne);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btn64bitprime);
            this.Controls.Add(this.btn16bitprime);
            this.Controls.Add(this.btn8bitprime);
            this.Name = "NumberTheory";
            this.Text = "Number Theory";
            this.Load += new System.EventHandler(this.NumberTheory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btn8bitprime;
        private System.Windows.Forms.RadioButton btn16bitprime;
        private System.Windows.Forms.RadioButton btn64bitprime;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.RadioButton btnMersenne;
        private System.Windows.Forms.RadioButton btnCheckPrime;
        private System.Windows.Forms.RadioButton btnUCLN;
        private System.Windows.Forms.RadioButton btnModular;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn1_1_8;
        private System.Windows.Forms.Button btn1_1_16;
        private System.Windows.Forms.Button btn1_1_64;
        private System.Windows.Forms.Button btn1_2;
        private System.Windows.Forms.Button btn1_3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
    }
}