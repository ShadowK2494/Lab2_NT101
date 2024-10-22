namespace Lab3
{
    partial class RootForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(98, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "LAB TASK: PUBLIC-KEY CRYPTOGRAPHY ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(318, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 58);
            this.label2.TabIndex = 7;
            this.label2.Text = "LAB 02";
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn2.Location = new System.Drawing.Point(228, 314);
            this.btn2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(343, 73);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2. Simple RSA";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn1.Location = new System.Drawing.Point(228, 231);
            this.btn1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(343, 73);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1. Number Theory";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "RootForm";
            this.Text = "RootForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}