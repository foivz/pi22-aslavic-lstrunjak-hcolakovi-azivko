namespace Forme
{
    partial class LoginForm
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
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.prijaviSeButton = new System.Windows.Forms.Button();
            this.nazadButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka:";
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.korisnickoImeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.korisnickoImeTextBox.ForeColor = System.Drawing.Color.White;
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(211, 63);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(310, 25);
            this.korisnickoImeTextBox.TabIndex = 2;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lozinkaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lozinkaTextBox.ForeColor = System.Drawing.Color.White;
            this.lozinkaTextBox.Location = new System.Drawing.Point(211, 125);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(310, 25);
            this.lozinkaTextBox.TabIndex = 3;
            this.lozinkaTextBox.UseSystemPasswordChar = true;
            // 
            // prijaviSeButton
            // 
            this.prijaviSeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.prijaviSeButton.FlatAppearance.BorderSize = 0;
            this.prijaviSeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijaviSeButton.Location = new System.Drawing.Point(211, 180);
            this.prijaviSeButton.Name = "prijaviSeButton";
            this.prijaviSeButton.Size = new System.Drawing.Size(128, 57);
            this.prijaviSeButton.TabIndex = 4;
            this.prijaviSeButton.Text = "Prijavi se";
            this.prijaviSeButton.UseVisualStyleBackColor = false;
            this.prijaviSeButton.Click += new System.EventHandler(this.prijaviSeButton_Click);
            // 
            // nazadButton
            // 
            this.nazadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.nazadButton.FlatAppearance.BorderSize = 0;
            this.nazadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazadButton.Location = new System.Drawing.Point(393, 180);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(128, 57);
            this.nazadButton.TabIndex = 5;
            this.nazadButton.Text = "Nazad";
            this.nazadButton.UseVisualStyleBackColor = false;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(104)))), ((int)(((byte)(144)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(573, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(211, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(211, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 1);
            this.panel2.TabIndex = 8;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Z1V3\\Desktop\\PI_Projekt\\pi22-aslavic-lstrunjak-hcolakovi-azivko\\Software" +
    "\\Forme\\Pomoc\\LinkBus User Manual.chm";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(574, 268);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.prijaviSeButton);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Button prijaviSeButton;
        private System.Windows.Forms.Button nazadButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}