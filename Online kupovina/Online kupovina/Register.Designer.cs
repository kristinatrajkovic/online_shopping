
namespace Online_kupovina
{
    partial class Register
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
            this.label8 = new System.Windows.Forms.Label();
            this.prikaziSifruCb = new System.Windows.Forms.CheckBox();
            this.potLozinkaTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imeTb = new System.Windows.Forms.TextBox();
            this.prezimeTb = new System.Windows.Forms.TextBox();
            this.LozinkaTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.korisnickoImeTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.otkaziBtn = new System.Windows.Forms.Button();
            this.potvrdiBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(550, -2);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 46);
            this.label8.TabIndex = 42;
            this.label8.Text = "x";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // prikaziSifruCb
            // 
            this.prikaziSifruCb.AutoSize = true;
            this.prikaziSifruCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prikaziSifruCb.Location = new System.Drawing.Point(402, 494);
            this.prikaziSifruCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prikaziSifruCb.Name = "prikaziSifruCb";
            this.prikaziSifruCb.Size = new System.Drawing.Size(115, 24);
            this.prikaziSifruCb.TabIndex = 40;
            this.prikaziSifruCb.Text = "Prikaži šifru";
            this.prikaziSifruCb.UseVisualStyleBackColor = true;
            this.prikaziSifruCb.CheckedChanged += new System.EventHandler(this.prikaziSifruCb_CheckedChanged);
            // 
            // potLozinkaTb
            // 
            this.potLozinkaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potLozinkaTb.Location = new System.Drawing.Point(271, 445);
            this.potLozinkaTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.potLozinkaTb.Name = "potLozinkaTb";
            this.potLozinkaTb.PasswordChar = '•';
            this.potLozinkaTb.Size = new System.Drawing.Size(244, 35);
            this.potLozinkaTb.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 445);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 33);
            this.label6.TabIndex = 38;
            this.label6.Text = "Potvrda lozinke:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 33);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 33);
            this.label4.TabIndex = 36;
            this.label4.Text = "Prezime:";
            // 
            // imeTb
            // 
            this.imeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeTb.Location = new System.Drawing.Point(272, 138);
            this.imeTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imeTb.Name = "imeTb";
            this.imeTb.Size = new System.Drawing.Size(244, 35);
            this.imeTb.TabIndex = 35;
            // 
            // prezimeTb
            // 
            this.prezimeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimeTb.Location = new System.Drawing.Point(272, 214);
            this.prezimeTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prezimeTb.Name = "prezimeTb";
            this.prezimeTb.Size = new System.Drawing.Size(244, 35);
            this.prezimeTb.TabIndex = 34;
            // 
            // LozinkaTb
            // 
            this.LozinkaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LozinkaTb.Location = new System.Drawing.Point(271, 368);
            this.LozinkaTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LozinkaTb.Name = "LozinkaTb";
            this.LozinkaTb.PasswordChar = '•';
            this.LozinkaTb.Size = new System.Drawing.Size(244, 35);
            this.LozinkaTb.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "Lozinka:";
            // 
            // korisnickoImeTb
            // 
            this.korisnickoImeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoImeTb.Location = new System.Drawing.Point(271, 291);
            this.korisnickoImeTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.korisnickoImeTb.Name = "korisnickoImeTb";
            this.korisnickoImeTb.Size = new System.Drawing.Size(244, 35);
            this.korisnickoImeTb.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 33);
            this.label2.TabIndex = 28;
            this.label2.Text = "Korisničko ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 46);
            this.label1.TabIndex = 43;
            this.label1.Text = "Online kupovina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(164, 544);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 29);
            this.label7.TabIndex = 46;
            this.label7.Text = "Nemate nalog? Prijavite se.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // otkaziBtn
            // 
            this.otkaziBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otkaziBtn.Location = new System.Drawing.Point(304, 579);
            this.otkaziBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.otkaziBtn.Name = "otkaziBtn";
            this.otkaziBtn.Size = new System.Drawing.Size(127, 46);
            this.otkaziBtn.TabIndex = 45;
            this.otkaziBtn.Text = "Otkaži";
            this.otkaziBtn.UseVisualStyleBackColor = true;
            this.otkaziBtn.Click += new System.EventHandler(this.otkaziBtn_Click);
            // 
            // potvrdiBtn
            // 
            this.potvrdiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potvrdiBtn.Location = new System.Drawing.Point(158, 576);
            this.potvrdiBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.potvrdiBtn.Name = "potvrdiBtn";
            this.potvrdiBtn.Size = new System.Drawing.Size(127, 46);
            this.potvrdiBtn.TabIndex = 44;
            this.potvrdiBtn.Text = "Potvrdi";
            this.potvrdiBtn.UseVisualStyleBackColor = true;
            this.potvrdiBtn.Click += new System.EventHandler(this.potvrdiBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Online_kupovina.Properties.Resources.shopping_cart;
            this.pictureBox2.Location = new System.Drawing.Point(14, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 659);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.otkaziBtn);
            this.Controls.Add(this.potvrdiBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.prikaziSifruCb);
            this.Controls.Add(this.potLozinkaTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imeTb);
            this.Controls.Add(this.prezimeTb);
            this.Controls.Add(this.LozinkaTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.korisnickoImeTb);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox prikaziSifruCb;
        private System.Windows.Forms.TextBox potLozinkaTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imeTb;
        private System.Windows.Forms.TextBox prezimeTb;
        private System.Windows.Forms.TextBox LozinkaTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox korisnickoImeTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button otkaziBtn;
        private System.Windows.Forms.Button potvrdiBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}