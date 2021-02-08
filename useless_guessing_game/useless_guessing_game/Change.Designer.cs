
namespace useless_guessing_game
{
    partial class Change
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
            this.label4 = new System.Windows.Forms.Label();
            this.changetb = new System.Windows.Forms.TextBox();
            this.SecretW = new System.Windows.Forms.Label();
            this.Changebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "secret word is";
            // 
            // changetb
            // 
            this.changetb.Location = new System.Drawing.Point(74, 108);
            this.changetb.Name = "changetb";
            this.changetb.Size = new System.Drawing.Size(100, 20);
            this.changetb.TabIndex = 4;
            this.changetb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.changetb_KeyPress);
            // 
            // SecretW
            // 
            this.SecretW.AutoSize = true;
            this.SecretW.Location = new System.Drawing.Point(84, 81);
            this.SecretW.Name = "SecretW";
            this.SecretW.Size = new System.Drawing.Size(28, 13);
            this.SecretW.TabIndex = 3;
            this.SecretW.Text = ".......";
            // 
            // Changebtn
            // 
            this.Changebtn.Location = new System.Drawing.Point(87, 143);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(75, 23);
            this.Changebtn.TabIndex = 5;
            this.Changebtn.Text = "change";
            this.Changebtn.UseVisualStyleBackColor = true;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 213);
            this.Controls.Add(this.Changebtn);
            this.Controls.Add(this.changetb);
            this.Controls.Add(this.SecretW);
            this.Controls.Add(this.label4);
            this.Name = "Change";
            this.Text = "Change";
            this.Load += new System.EventHandler(this.Change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox changetb;
        private System.Windows.Forms.Label SecretW;
        private System.Windows.Forms.Button Changebtn;
    }
}