
namespace Forme
{
    partial class DetaljiPutovanjaForm
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
            this.buttonNav = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonNav
            // 
            this.buttonNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonNav.FlatAppearance.BorderSize = 0;
            this.buttonNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNav.Location = new System.Drawing.Point(-2, -4);
            this.buttonNav.Name = "buttonNav";
            this.buttonNav.Size = new System.Drawing.Size(986, 30);
            this.buttonNav.TabIndex = 0;
            this.buttonNav.UseVisualStyleBackColor = false;
            this.buttonNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonNav_MouseDown);
            this.buttonNav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonNav_MouseMove);
            this.buttonNav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonNav_MouseUp);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(990, 7);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(131, 41);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Nazad";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(366, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 671);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 171);
            this.panel2.TabIndex = 3;
            // 
            // DetaljiPutovanjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1133, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetaljiPutovanjaForm";
            this.Text = "DetaljiPutovanjaForm";
            this.Load += new System.EventHandler(this.DetaljiPutovanjaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNav;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}