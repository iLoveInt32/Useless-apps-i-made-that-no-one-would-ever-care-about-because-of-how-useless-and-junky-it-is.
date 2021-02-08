
namespace useless_guessing_game
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
            this.guess_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guess_btn = new System.Windows.Forms.Button();
            this.num_guess = new System.Windows.Forms.Label();
            this.Changebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guess_tb
            // 
            this.guess_tb.Location = new System.Drawing.Point(88, 85);
            this.guess_tb.Name = "guess_tb";
            this.guess_tb.Size = new System.Drawing.Size(100, 20);
            this.guess_tb.TabIndex = 0;
            this.guess_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guess_tb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "guess";
            // 
            // guess_btn
            // 
            this.guess_btn.Location = new System.Drawing.Point(100, 161);
            this.guess_btn.Name = "guess_btn";
            this.guess_btn.Size = new System.Drawing.Size(75, 23);
            this.guess_btn.TabIndex = 2;
            this.guess_btn.Text = "guess";
            this.guess_btn.UseVisualStyleBackColor = true;
            this.guess_btn.Click += new System.EventHandler(this.guess_btn_Click);
            // 
            // num_guess
            // 
            this.num_guess.AutoSize = true;
            this.num_guess.Location = new System.Drawing.Point(120, 129);
            this.num_guess.Name = "num_guess";
            this.num_guess.Size = new System.Drawing.Size(10, 13);
            this.num_guess.TabIndex = 3;
            this.num_guess.Text = " ";
            // 
            // Changebtn
            // 
            this.Changebtn.Location = new System.Drawing.Point(12, 226);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(75, 23);
            this.Changebtn.TabIndex = 4;
            this.Changebtn.Text = "change";
            this.Changebtn.UseVisualStyleBackColor = true;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Changebtn);
            this.Controls.Add(this.num_guess);
            this.Controls.Add(this.guess_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guess_tb);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guess_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guess_btn;
        private System.Windows.Forms.Label num_guess;
        private System.Windows.Forms.Button Changebtn;
    }
}

