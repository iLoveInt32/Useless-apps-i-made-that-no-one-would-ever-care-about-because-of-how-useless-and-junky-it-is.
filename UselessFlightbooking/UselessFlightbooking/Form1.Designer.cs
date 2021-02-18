
namespace UselessFlightbooking
{
    partial class BookFlight
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
            this.Totb = new System.Windows.Forms.MaskedTextBox();
            this.Fromtb = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Firstnametb = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lastnametb = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MainCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Passportrb = new System.Windows.Forms.RadioButton();
            this.DateExpireddtp = new System.Windows.Forms.DateTimePicker();
            this.Docexpdatelb = new System.Windows.Forms.Label();
            this.DateIssueddtp = new System.Windows.Forms.DateTimePicker();
            this.Docissdatelb = new System.Windows.Forms.Label();
            this.Docnumtb = new System.Windows.Forms.MaskedTextBox();
            this.Docnumlb = new System.Windows.Forms.Label();
            this.Idrb = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Bagweightud = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Bookbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bagweightud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // Totb
            // 
            this.Totb.Location = new System.Drawing.Point(108, 124);
            this.Totb.Name = "Totb";
            this.Totb.Size = new System.Drawing.Size(100, 20);
            this.Totb.TabIndex = 1;
            // 
            // Fromtb
            // 
            this.Fromtb.Location = new System.Drawing.Point(357, 125);
            this.Fromtb.Name = "Fromtb";
            this.Fromtb.Size = new System.Drawing.Size(100, 20);
            this.Fromtb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "From:";
            // 
            // Firstnametb
            // 
            this.Firstnametb.Location = new System.Drawing.Point(108, 79);
            this.Firstnametb.Name = "Firstnametb";
            this.Firstnametb.Size = new System.Drawing.Size(100, 20);
            this.Firstnametb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Firstname:";
            // 
            // Lastnametb
            // 
            this.Lastnametb.Location = new System.Drawing.Point(357, 80);
            this.Lastnametb.Name = "Lastnametb";
            this.Lastnametb.Size = new System.Drawing.Size(100, 20);
            this.Lastnametb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lastname:";
            // 
            // MainCalendar
            // 
            this.MainCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.MainCalendar.Location = new System.Drawing.Point(32, 167);
            this.MainCalendar.Name = "MainCalendar";
            this.MainCalendar.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Passportrb);
            this.groupBox1.Controls.Add(this.DateExpireddtp);
            this.groupBox1.Controls.Add(this.Docexpdatelb);
            this.groupBox1.Controls.Add(this.DateIssueddtp);
            this.groupBox1.Controls.Add(this.Docissdatelb);
            this.groupBox1.Controls.Add(this.Docnumtb);
            this.groupBox1.Controls.Add(this.Docnumlb);
            this.groupBox1.Controls.Add(this.Idrb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(533, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 326);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Travel Options";
            // 
            // Passportrb
            // 
            this.Passportrb.AutoSize = true;
            this.Passportrb.Location = new System.Drawing.Point(27, 70);
            this.Passportrb.Name = "Passportrb";
            this.Passportrb.Size = new System.Drawing.Size(66, 17);
            this.Passportrb.TabIndex = 16;
            this.Passportrb.TabStop = true;
            this.Passportrb.Text = "Passport";
            this.Passportrb.UseVisualStyleBackColor = true;
            this.Passportrb.CheckedChanged += new System.EventHandler(this.Passportrb_CheckedChanged);
            // 
            // DateExpireddtp
            // 
            this.DateExpireddtp.Location = new System.Drawing.Point(18, 282);
            this.DateExpireddtp.Name = "DateExpireddtp";
            this.DateExpireddtp.Size = new System.Drawing.Size(205, 20);
            this.DateExpireddtp.TabIndex = 15;
            // 
            // Docexpdatelb
            // 
            this.Docexpdatelb.AutoSize = true;
            this.Docexpdatelb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Docexpdatelb.Location = new System.Drawing.Point(15, 253);
            this.Docexpdatelb.Name = "Docexpdatelb";
            this.Docexpdatelb.Size = new System.Drawing.Size(168, 18);
            this.Docexpdatelb.TabIndex = 14;
            this.Docexpdatelb.Text = "Document Expiry Date:";
            // 
            // DateIssueddtp
            // 
            this.DateIssueddtp.Location = new System.Drawing.Point(18, 213);
            this.DateIssueddtp.Name = "DateIssueddtp";
            this.DateIssueddtp.Size = new System.Drawing.Size(205, 20);
            this.DateIssueddtp.TabIndex = 13;
            this.DateIssueddtp.ValueChanged += new System.EventHandler(this.DateIssueddtp_ValueChanged);
            // 
            // Docissdatelb
            // 
            this.Docissdatelb.AutoSize = true;
            this.Docissdatelb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Docissdatelb.Location = new System.Drawing.Point(15, 182);
            this.Docissdatelb.Name = "Docissdatelb";
            this.Docissdatelb.Size = new System.Drawing.Size(170, 18);
            this.Docissdatelb.TabIndex = 11;
            this.Docissdatelb.Text = "Document Issued Date:";
            // 
            // Docnumtb
            // 
            this.Docnumtb.Location = new System.Drawing.Point(27, 140);
            this.Docnumtb.Name = "Docnumtb";
            this.Docnumtb.Size = new System.Drawing.Size(147, 20);
            this.Docnumtb.TabIndex = 12;
            // 
            // Docnumlb
            // 
            this.Docnumlb.AutoSize = true;
            this.Docnumlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Docnumlb.Location = new System.Drawing.Point(15, 110);
            this.Docnumlb.Name = "Docnumlb";
            this.Docnumlb.Size = new System.Drawing.Size(142, 18);
            this.Docnumlb.TabIndex = 11;
            this.Docnumlb.Text = "Document Number:";
            // 
            // Idrb
            // 
            this.Idrb.AutoSize = true;
            this.Idrb.Location = new System.Drawing.Point(114, 70);
            this.Idrb.Name = "Idrb";
            this.Idrb.Size = new System.Drawing.Size(60, 17);
            this.Idrb.TabIndex = 12;
            this.Idrb.TabStop = true;
            this.Idrb.Text = "ID card";
            this.Idrb.UseVisualStyleBackColor = true;
            this.Idrb.CheckedChanged += new System.EventHandler(this.Idrb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Travel Document:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Baggage Weight:";
            // 
            // Bagweightud
            // 
            this.Bagweightud.Location = new System.Drawing.Point(171, 366);
            this.Bagweightud.Name = "Bagweightud";
            this.Bagweightud.Size = new System.Drawing.Size(60, 20);
            this.Bagweightud.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(237, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Killogram\'s (KG)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(354, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Logo";
            // 
            // Bookbtn
            // 
            this.Bookbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookbtn.Location = new System.Drawing.Point(12, 415);
            this.Bookbtn.Name = "Bookbtn";
            this.Bookbtn.Size = new System.Drawing.Size(772, 40);
            this.Bookbtn.TabIndex = 16;
            this.Bookbtn.Text = "Book";
            this.Bookbtn.UseVisualStyleBackColor = true;
            this.Bookbtn.Click += new System.EventHandler(this.Bookbtn_Click);
            // 
            // BookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.Bookbtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Bagweightud);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainCalendar);
            this.Controls.Add(this.Lastnametb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Firstnametb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fromtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Totb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookFlight";
            this.Text = "Book Flight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bagweightud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Totb;
        private System.Windows.Forms.MaskedTextBox Fromtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Firstnametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Lastnametb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar MainCalendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DateExpireddtp;
        private System.Windows.Forms.Label Docexpdatelb;
        private System.Windows.Forms.DateTimePicker DateIssueddtp;
        private System.Windows.Forms.Label Docissdatelb;
        private System.Windows.Forms.MaskedTextBox Docnumtb;
        private System.Windows.Forms.Label Docnumlb;
        private System.Windows.Forms.RadioButton Idrb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Bagweightud;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton Passportrb;
        private System.Windows.Forms.Button Bookbtn;
    }
}

