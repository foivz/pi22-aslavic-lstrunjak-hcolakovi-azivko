namespace Forme
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
            this.adminButton = new System.Windows.Forms.Button();
            this.registriraniKorisnikButton = new System.Windows.Forms.Button();
            this.neregistriraniKorisnikButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminButton
            // 
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminButton.Location = new System.Drawing.Point(89, 208);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(141, 83);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // registriraniKorisnikButton
            // 
            this.registriraniKorisnikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registriraniKorisnikButton.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registriraniKorisnikButton.Location = new System.Drawing.Point(294, 208);
            this.registriraniKorisnikButton.Name = "registriraniKorisnikButton";
            this.registriraniKorisnikButton.Size = new System.Drawing.Size(141, 83);
            this.registriraniKorisnikButton.TabIndex = 1;
            this.registriraniKorisnikButton.Text = "Registrirani korisnik";
            this.registriraniKorisnikButton.UseVisualStyleBackColor = true;
            this.registriraniKorisnikButton.Click += new System.EventHandler(this.registriraniKorisnikButton_Click);
            // 
            // neregistriraniKorisnikButton
            // 
            this.neregistriraniKorisnikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neregistriraniKorisnikButton.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.neregistriraniKorisnikButton.Location = new System.Drawing.Point(496, 208);
            this.neregistriraniKorisnikButton.Name = "neregistriraniKorisnikButton";
            this.neregistriraniKorisnikButton.Size = new System.Drawing.Size(141, 83);
            this.neregistriraniKorisnikButton.TabIndex = 2;
            this.neregistriraniKorisnikButton.Text = "Neregistrirani korisnik";
            this.neregistriraniKorisnikButton.UseVisualStyleBackColor = true;
            this.neregistriraniKorisnikButton.Click += new System.EventHandler(this.neregistriraniKorisnikButton_Click);
            // 
            // izlazButton
            // 
            this.izlazButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izlazButton.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlazButton.Location = new System.Drawing.Point(294, 324);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(141, 83);
            this.izlazButton.TabIndex = 3;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(233, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 96);
            this.label1.TabIndex = 4;
            this.label1.Text = "LinkBus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.neregistriraniKorisnikButton);
            this.Controls.Add(this.registriraniKorisnikButton);
            this.Controls.Add(this.adminButton);
            this.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Početna stranica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button registriraniKorisnikButton;
        private System.Windows.Forms.Button neregistriraniKorisnikButton;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Label label1;
    }
}

