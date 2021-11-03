
namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Checkin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbltxt1 = new System.Windows.Forms.TextBox();
            this.Lbltxt2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbltxt3 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(147, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGRISTRATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(55, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 4);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(55, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 4);
            this.panel2.TabIndex = 5;
            // 
            // Checkin
            // 
            this.Checkin.BackColor = System.Drawing.Color.Red;
            this.Checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Checkin.Location = new System.Drawing.Point(125, 793);
            this.Checkin.Name = "Checkin";
            this.Checkin.Size = new System.Drawing.Size(272, 36);
            this.Checkin.TabIndex = 7;
            this.Checkin.Text = "Check-in";
            this.Checkin.UseVisualStyleBackColor = false;
            this.Checkin.Click += new System.EventHandler(this.Checkin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 876);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Back to LOGIN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Lbltxt1
            // 
            this.Lbltxt1.BackColor = System.Drawing.Color.White;
            this.Lbltxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltxt1.ForeColor = System.Drawing.Color.Black;
            this.Lbltxt1.Location = new System.Drawing.Point(98, 407);
            this.Lbltxt1.Name = "Lbltxt1";
            this.Lbltxt1.Size = new System.Drawing.Size(256, 21);
            this.Lbltxt1.TabIndex = 10;
            // 
            // Lbltxt2
            // 
            this.Lbltxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltxt2.Location = new System.Drawing.Point(98, 498);
            this.Lbltxt2.Name = "Lbltxt2";
            this.Lbltxt2.Size = new System.Drawing.Size(256, 21);
            this.Lbltxt2.TabIndex = 11;
            this.Lbltxt2.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(375, 661);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(166, 844);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Already Have an Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Confirm Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Lbltxt3
            // 
            this.Lbltxt3.BackColor = System.Drawing.Color.White;
            this.Lbltxt3.ForeColor = System.Drawing.Color.Black;
            this.Lbltxt3.Location = new System.Drawing.Point(98, 602);
            this.Lbltxt3.Multiline = true;
            this.Lbltxt3.Name = "Lbltxt3";
            this.Lbltxt3.Size = new System.Drawing.Size(256, 24);
            this.Lbltxt3.TabIndex = 19;
            this.Lbltxt3.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(55, 645);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 4);
            this.panel3.TabIndex = 18;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LoginScreen.Properties.Resources.icons8_schloss_orientierung_24;
            this.pictureBox5.Location = new System.Drawing.Point(55, 602);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LoginScreen.Properties.Resources.icons8_schloss_orientierung_24;
            this.pictureBox3.Location = new System.Drawing.Point(55, 498);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LoginScreen.Properties.Resources.icons8_person_männlich_24;
            this.pictureBox2.Location = new System.Drawing.Point(55, 417);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginScreen.Properties.Resources.imgbin_keychain_lock_png;
            this.pictureBox1.Location = new System.Drawing.Point(-395, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1336, 944);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(98, 655);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lbltxt3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Lbltxt2);
            this.Controls.Add(this.Lbltxt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Checkin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Regristration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Checkin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Lbltxt1;
        private System.Windows.Forms.TextBox Lbltxt2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Lbltxt3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button2;
    }
}

