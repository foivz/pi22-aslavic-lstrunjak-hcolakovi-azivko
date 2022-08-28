
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNav
            // 
            this.buttonNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(104)))), ((int)(((byte)(100)))));
            this.buttonNav.FlatAppearance.BorderSize = 0;
            this.buttonNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNav.Location = new System.Drawing.Point(9, 3);
            this.buttonNav.Name = "buttonNav";
            this.buttonNav.Size = new System.Drawing.Size(1051, 45);
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
            this.buttonBack.Location = new System.Drawing.Point(42, 618);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(131, 41);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Nazad";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(84)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Location = new System.Drawing.Point(19, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 671);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(48, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 100);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(241, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(807, 671);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // DetaljiPutovanjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1069, 750);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetaljiPutovanjaForm";
            this.Text = "DetaljiPutovanjaForm";
            this.Load += new System.EventHandler(this.DetaljiPutovanjaForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNav;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}