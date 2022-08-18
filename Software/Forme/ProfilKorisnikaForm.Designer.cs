namespace Forme
{
    partial class ProfilKorisnikaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brojMobitelaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.povijestPutovanjaDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.zatvoriButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.povijestPutovanjaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Broj mobitela:";
            // 
            // brojMobitelaTextBox
            // 
            this.brojMobitelaTextBox.Enabled = false;
            this.brojMobitelaTextBox.Location = new System.Drawing.Point(185, 550);
            this.brojMobitelaTextBox.Name = "brojMobitelaTextBox";
            this.brojMobitelaTextBox.Size = new System.Drawing.Size(274, 29);
            this.brojMobitelaTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(185, 489);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(274, 29);
            this.emailTextBox.TabIndex = 6;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Enabled = false;
            this.prezimeTextBox.Location = new System.Drawing.Point(185, 430);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(274, 29);
            this.prezimeTextBox.TabIndex = 7;
            // 
            // imeTextBox
            // 
            this.imeTextBox.Enabled = false;
            this.imeTextBox.Location = new System.Drawing.Point(185, 372);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(274, 29);
            this.imeTextBox.TabIndex = 8;
            // 
            // povijestPutovanjaDataGridView
            // 
            this.povijestPutovanjaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.povijestPutovanjaDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.povijestPutovanjaDataGridView.Location = new System.Drawing.Point(510, 82);
            this.povijestPutovanjaDataGridView.Name = "povijestPutovanjaDataGridView";
            this.povijestPutovanjaDataGridView.RowHeadersWidth = 51;
            this.povijestPutovanjaDataGridView.RowTemplate.Height = 24;
            this.povijestPutovanjaDataGridView.Size = new System.Drawing.Size(570, 418);
            this.povijestPutovanjaDataGridView.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(505, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vaša putovanja:";
            // 
            // zatvoriButton
            // 
            this.zatvoriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zatvoriButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zatvoriButton.Location = new System.Drawing.Point(949, 526);
            this.zatvoriButton.Name = "zatvoriButton";
            this.zatvoriButton.Size = new System.Drawing.Size(131, 53);
            this.zatvoriButton.TabIndex = 11;
            this.zatvoriButton.Text = "Zatvori";
            this.zatvoriButton.UseVisualStyleBackColor = true;
            this.zatvoriButton.Click += new System.EventHandler(this.zatvoriButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forme.Properties.Resources._960x1;
            this.pictureBox1.Location = new System.Drawing.Point(53, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 302);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(684, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // ProfilKorisnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1123, 613);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zatvoriButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.povijestPutovanjaDataGridView);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.brojMobitelaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfilKorisnikaForm";
            this.Text = "Profil korisnika";
            this.Load += new System.EventHandler(this.ProfilKorisnikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.povijestPutovanjaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brojMobitelaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.DataGridView povijestPutovanjaDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button zatvoriButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}