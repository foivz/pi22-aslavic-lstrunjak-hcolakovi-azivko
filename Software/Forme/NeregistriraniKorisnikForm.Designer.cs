namespace Forme
{
    partial class NeregistriraniKorisnikForm
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
            this.popisLinijaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registrirajSeButton = new System.Windows.Forms.Button();
            this.nazadButton = new System.Windows.Forms.Button();
            this.pretraziButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisLinijaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // popisLinijaDataGridView
            // 
            this.popisLinijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisLinijaDataGridView.Location = new System.Drawing.Point(43, 91);
            this.popisLinijaDataGridView.Name = "popisLinijaDataGridView";
            this.popisLinijaDataGridView.RowHeadersWidth = 51;
            this.popisLinijaDataGridView.RowTemplate.Height = 24;
            this.popisLinijaDataGridView.Size = new System.Drawing.Size(771, 396);
            this.popisLinijaDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite odredište:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(204, 39);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(263, 29);
            this.searchTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nemaš račun?";
            // 
            // registrirajSeButton
            // 
            this.registrirajSeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrirajSeButton.Location = new System.Drawing.Point(172, 517);
            this.registrirajSeButton.Name = "registrirajSeButton";
            this.registrirajSeButton.Size = new System.Drawing.Size(158, 47);
            this.registrirajSeButton.TabIndex = 4;
            this.registrirajSeButton.Text = "Registriraj se";
            this.registrirajSeButton.UseVisualStyleBackColor = true;
            this.registrirajSeButton.Click += new System.EventHandler(this.registrirajSeButton_Click);
            // 
            // nazadButton
            // 
            this.nazadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazadButton.Location = new System.Drawing.Point(682, 517);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(132, 47);
            this.nazadButton.TabIndex = 5;
            this.nazadButton.Text = "Nazad";
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            // 
            // pretraziButton
            // 
            this.pretraziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pretraziButton.Location = new System.Drawing.Point(487, 30);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(113, 46);
            this.pretraziButton.TabIndex = 6;
            this.pretraziButton.Text = "Pretraži";
            this.pretraziButton.UseVisualStyleBackColor = true;
            // 
            // NeregistriraniKorisnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(862, 586);
            this.Controls.Add(this.pretraziButton);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.registrirajSeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.popisLinijaDataGridView);
            this.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NeregistriraniKorisnikForm";
            this.Text = "Popis autobusnih linija";
            ((System.ComponentModel.ISupportInitialize)(this.popisLinijaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView popisLinijaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registrirajSeButton;
        private System.Windows.Forms.Button nazadButton;
        private System.Windows.Forms.Button pretraziButton;
    }
}