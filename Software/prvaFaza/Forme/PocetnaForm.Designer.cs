namespace Hasan
{
    partial class PocetnaForm
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
            this.registriraniKorisnikButton = new System.Windows.Forms.Button();
            this.neregistriraniKorisnikButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registriraniKorisnikButton
            // 
            this.registriraniKorisnikButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.registriraniKorisnikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registriraniKorisnikButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registriraniKorisnikButton.ForeColor = System.Drawing.SystemColors.Control;
            this.registriraniKorisnikButton.Location = new System.Drawing.Point(234, 272);
            this.registriraniKorisnikButton.Name = "registriraniKorisnikButton";
            this.registriraniKorisnikButton.Size = new System.Drawing.Size(148, 86);
            this.registriraniKorisnikButton.TabIndex = 1;
            this.registriraniKorisnikButton.Text = "Registrirani korisnik";
            this.registriraniKorisnikButton.UseVisualStyleBackColor = false;
            this.registriraniKorisnikButton.Click += new System.EventHandler(this.registriraniKorisnikButton_Click);
            // 
            // neregistriraniKorisnikButton
            // 
            this.neregistriraniKorisnikButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.neregistriraniKorisnikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neregistriraniKorisnikButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neregistriraniKorisnikButton.ForeColor = System.Drawing.SystemColors.Control;
            this.neregistriraniKorisnikButton.Location = new System.Drawing.Point(406, 272);
            this.neregistriraniKorisnikButton.Name = "neregistriraniKorisnikButton";
            this.neregistriraniKorisnikButton.Size = new System.Drawing.Size(148, 86);
            this.neregistriraniKorisnikButton.TabIndex = 2;
            this.neregistriraniKorisnikButton.Text = "Neregistrirani korisnik";
            this.neregistriraniKorisnikButton.UseVisualStyleBackColor = false;
            this.neregistriraniKorisnikButton.Click += new System.EventHandler(this.neregistriraniKorisnikButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(137, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 144);
            this.label1.TabIndex = 3;
            this.label1.Text = "LinkBus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminButton
            // 
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminButton.ForeColor = System.Drawing.SystemColors.Control;
            this.adminButton.Location = new System.Drawing.Point(64, 272);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(148, 86);
            this.adminButton.TabIndex = 4;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click_1);
            // 
            // izlazButton
            // 
            this.izlazButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izlazButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izlazButton.ForeColor = System.Drawing.SystemColors.Control;
            this.izlazButton.Location = new System.Drawing.Point(234, 383);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(148, 86);
            this.izlazButton.TabIndex = 5;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // PocetnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(653, 481);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.neregistriraniKorisnikButton);
            this.Controls.Add(this.registriraniKorisnikButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PocetnaForm";
            this.Text = "Početna forma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registriraniKorisnikButton;
        private System.Windows.Forms.Button neregistriraniKorisnikButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button izlazButton;
    }
}

