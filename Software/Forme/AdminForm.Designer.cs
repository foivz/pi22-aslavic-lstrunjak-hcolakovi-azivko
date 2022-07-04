namespace Forme
{
    partial class AdminForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dodajLinijuButton = new System.Windows.Forms.Button();
            this.azurirajLinijuButton = new System.Windows.Forms.Button();
            this.obirsiLinijuButton = new System.Windows.Forms.Button();
            this.odjaviSeButton = new System.Windows.Forms.Button();
            this.profilButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filtrirajButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.odredisteTextBox = new System.Windows.Forms.TextBox();
            this.polazisteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pretraziButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraži linije:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(181, 47);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(256, 29);
            this.searchTextBox.TabIndex = 2;
            // 
            // dodajLinijuButton
            // 
            this.dodajLinijuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajLinijuButton.Location = new System.Drawing.Point(43, 528);
            this.dodajLinijuButton.Name = "dodajLinijuButton";
            this.dodajLinijuButton.Size = new System.Drawing.Size(122, 64);
            this.dodajLinijuButton.TabIndex = 3;
            this.dodajLinijuButton.Text = "Dodaj liniju";
            this.dodajLinijuButton.UseVisualStyleBackColor = true;
            this.dodajLinijuButton.Click += new System.EventHandler(this.dodajLinijuButton_Click);
            // 
            // azurirajLinijuButton
            // 
            this.azurirajLinijuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.azurirajLinijuButton.Location = new System.Drawing.Point(181, 528);
            this.azurirajLinijuButton.Name = "azurirajLinijuButton";
            this.azurirajLinijuButton.Size = new System.Drawing.Size(122, 64);
            this.azurirajLinijuButton.TabIndex = 4;
            this.azurirajLinijuButton.Text = "Ažuriraj liniju";
            this.azurirajLinijuButton.UseVisualStyleBackColor = true;
            this.azurirajLinijuButton.Click += new System.EventHandler(this.azurirajLinijuButton_Click);
            // 
            // obirsiLinijuButton
            // 
            this.obirsiLinijuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obirsiLinijuButton.Location = new System.Drawing.Point(315, 528);
            this.obirsiLinijuButton.Name = "obirsiLinijuButton";
            this.obirsiLinijuButton.Size = new System.Drawing.Size(122, 64);
            this.obirsiLinijuButton.TabIndex = 5;
            this.obirsiLinijuButton.Text = "Obriši liniju";
            this.obirsiLinijuButton.UseVisualStyleBackColor = true;
            // 
            // odjaviSeButton
            // 
            this.odjaviSeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odjaviSeButton.Location = new System.Drawing.Point(882, 528);
            this.odjaviSeButton.Name = "odjaviSeButton";
            this.odjaviSeButton.Size = new System.Drawing.Size(122, 64);
            this.odjaviSeButton.TabIndex = 6;
            this.odjaviSeButton.Text = "Odjavi se";
            this.odjaviSeButton.UseVisualStyleBackColor = true;
            this.odjaviSeButton.Click += new System.EventHandler(this.odjaviSeButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilButton.Location = new System.Drawing.Point(882, 12);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(122, 64);
            this.profilButton.TabIndex = 7;
            this.profilButton.Text = "Profil";
            this.profilButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filtrirajButton);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.odredisteTextBox);
            this.groupBox1.Controls.Add(this.polazisteTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(714, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 363);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtriraj linije";
            // 
            // filtrirajButton
            // 
            this.filtrirajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrirajButton.Location = new System.Drawing.Point(10, 301);
            this.filtrirajButton.Name = "filtrirajButton";
            this.filtrirajButton.Size = new System.Drawing.Size(265, 42);
            this.filtrirajButton.TabIndex = 6;
            this.filtrirajButton.Text = "Filtriraj";
            this.filtrirajButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(10, 247);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 29);
            this.dateTimePicker.TabIndex = 5;
            // 
            // odredisteTextBox
            // 
            this.odredisteTextBox.Location = new System.Drawing.Point(10, 165);
            this.odredisteTextBox.Name = "odredisteTextBox";
            this.odredisteTextBox.Size = new System.Drawing.Size(265, 29);
            this.odredisteTextBox.TabIndex = 4;
            // 
            // polazisteTextBox
            // 
            this.polazisteTextBox.Location = new System.Drawing.Point(10, 77);
            this.polazisteTextBox.Name = "polazisteTextBox";
            this.polazisteTextBox.Size = new System.Drawing.Size(265, 29);
            this.polazisteTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Datum i vrijeme polaska:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Odredište:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Polazište:";
            // 
            // pretraziButton
            // 
            this.pretraziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pretraziButton.Location = new System.Drawing.Point(464, 41);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(126, 41);
            this.pretraziButton.TabIndex = 9;
            this.pretraziButton.Text = "Pretraži";
            this.pretraziButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1025, 619);
            this.Controls.Add(this.pretraziButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.profilButton);
            this.Controls.Add(this.odjaviSeButton);
            this.Controls.Add(this.obirsiLinijuButton);
            this.Controls.Add(this.azurirajLinijuButton);
            this.Controls.Add(this.dodajLinijuButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "LinkBus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button dodajLinijuButton;
        private System.Windows.Forms.Button azurirajLinijuButton;
        private System.Windows.Forms.Button obirsiLinijuButton;
        private System.Windows.Forms.Button odjaviSeButton;
        private System.Windows.Forms.Button profilButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button filtrirajButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox odredisteTextBox;
        private System.Windows.Forms.TextBox polazisteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pretraziButton;
    }
}