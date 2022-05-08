
namespace Hasan
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
            this.dodajLinijuButton = new System.Windows.Forms.Button();
            this.azurirajLinijuButton = new System.Windows.Forms.Button();
            this.obrisiLinijuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pretraziTextBox = new System.Windows.Forms.TextBox();
            this.pretraziButton = new System.Windows.Forms.Button();
            this.profilButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.filtrirajButton = new System.Windows.Forms.Button();
            this.odredisteTextBox = new System.Windows.Forms.TextBox();
            this.polazisteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.odjaviSeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dodajLinijuButton
            // 
            this.dodajLinijuButton.Location = new System.Drawing.Point(47, 415);
            this.dodajLinijuButton.Name = "dodajLinijuButton";
            this.dodajLinijuButton.Size = new System.Drawing.Size(111, 59);
            this.dodajLinijuButton.TabIndex = 1;
            this.dodajLinijuButton.Text = "Dodaj liniju";
            this.dodajLinijuButton.UseVisualStyleBackColor = true;
            this.dodajLinijuButton.Click += new System.EventHandler(this.dodajLinijuButton_Click);
            // 
            // azurirajLinijuButton
            // 
            this.azurirajLinijuButton.Location = new System.Drawing.Point(176, 415);
            this.azurirajLinijuButton.Name = "azurirajLinijuButton";
            this.azurirajLinijuButton.Size = new System.Drawing.Size(111, 59);
            this.azurirajLinijuButton.TabIndex = 2;
            this.azurirajLinijuButton.Text = "Ažuriraj liniju";
            this.azurirajLinijuButton.UseVisualStyleBackColor = true;
            this.azurirajLinijuButton.Click += new System.EventHandler(this.azurirajLinijuButton_Click);
            // 
            // obrisiLinijuButton
            // 
            this.obrisiLinijuButton.Location = new System.Drawing.Point(310, 415);
            this.obrisiLinijuButton.Name = "obrisiLinijuButton";
            this.obrisiLinijuButton.Size = new System.Drawing.Size(111, 59);
            this.obrisiLinijuButton.TabIndex = 3;
            this.obrisiLinijuButton.Text = "Obriši liniju";
            this.obrisiLinijuButton.UseVisualStyleBackColor = true;
            this.obrisiLinijuButton.Click += new System.EventHandler(this.obrisiLinijuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pretraži linije:";
            // 
            // pretraziTextBox
            // 
            this.pretraziTextBox.Location = new System.Drawing.Point(144, 55);
            this.pretraziTextBox.Name = "pretraziTextBox";
            this.pretraziTextBox.Size = new System.Drawing.Size(277, 22);
            this.pretraziTextBox.TabIndex = 5;
            // 
            // pretraziButton
            // 
            this.pretraziButton.Location = new System.Drawing.Point(440, 45);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(102, 42);
            this.pretraziButton.TabIndex = 6;
            this.pretraziButton.Text = "Pretraži";
            this.pretraziButton.UseVisualStyleBackColor = true;
            this.pretraziButton.Click += new System.EventHandler(this.pretraziButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.Location = new System.Drawing.Point(812, 33);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(114, 42);
            this.profilButton.TabIndex = 7;
            this.profilButton.Text = "Profil";
            this.profilButton.UseVisualStyleBackColor = true;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.filtrirajButton);
            this.groupBox1.Controls.Add(this.odredisteTextBox);
            this.groupBox1.Controls.Add(this.polazisteTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(638, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 294);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtriraj linije:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(22, 195);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker.TabIndex = 7;
            // 
            // filtrirajButton
            // 
            this.filtrirajButton.Location = new System.Drawing.Point(94, 233);
            this.filtrirajButton.Name = "filtrirajButton";
            this.filtrirajButton.Size = new System.Drawing.Size(106, 44);
            this.filtrirajButton.TabIndex = 6;
            this.filtrirajButton.Text = "Filtriraj";
            this.filtrirajButton.UseVisualStyleBackColor = true;
            this.filtrirajButton.Click += new System.EventHandler(this.filtrirajButton_Click);
            // 
            // odredisteTextBox
            // 
            this.odredisteTextBox.Location = new System.Drawing.Point(19, 130);
            this.odredisteTextBox.Name = "odredisteTextBox";
            this.odredisteTextBox.Size = new System.Drawing.Size(242, 22);
            this.odredisteTextBox.TabIndex = 4;
            // 
            // polazisteTextBox
            // 
            this.polazisteTextBox.Location = new System.Drawing.Point(19, 66);
            this.polazisteTextBox.Name = "polazisteTextBox";
            this.polazisteTextBox.Size = new System.Drawing.Size(245, 22);
            this.polazisteTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Datum polaska:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Odredište:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Polazište:";
            // 
            // odjaviSeButton
            // 
            this.odjaviSeButton.Location = new System.Drawing.Point(815, 415);
            this.odjaviSeButton.Name = "odjaviSeButton";
            this.odjaviSeButton.Size = new System.Drawing.Size(111, 59);
            this.odjaviSeButton.TabIndex = 9;
            this.odjaviSeButton.Text = "Odjavi se";
            this.odjaviSeButton.UseVisualStyleBackColor = true;
            this.odjaviSeButton.Click += new System.EventHandler(this.odjaviSeButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 495);
            this.Controls.Add(this.odjaviSeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.profilButton);
            this.Controls.Add(this.pretraziButton);
            this.Controls.Add(this.pretraziTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.obrisiLinijuButton);
            this.Controls.Add(this.azurirajLinijuButton);
            this.Controls.Add(this.dodajLinijuButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "Autobusni kolodvor";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodajLinijuButton;
        private System.Windows.Forms.Button azurirajLinijuButton;
        private System.Windows.Forms.Button obrisiLinijuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pretraziTextBox;
        private System.Windows.Forms.Button pretraziButton;
        private System.Windows.Forms.Button profilButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button filtrirajButton;
        private System.Windows.Forms.TextBox odredisteTextBox;
        private System.Windows.Forms.TextBox polazisteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button odjaviSeButton;
    }
}