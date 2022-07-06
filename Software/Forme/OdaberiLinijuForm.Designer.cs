namespace Forme
{
    partial class OdaberiLinijuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.popisLinijaDataGridView = new System.Windows.Forms.DataGridView();
            this.odaberiLinijuButton = new System.Windows.Forms.Button();
            this.nazadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisLinijaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis linija:";
            // 
            // popisLinijaDataGridView
            // 
            this.popisLinijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.popisLinijaDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.popisLinijaDataGridView.Location = new System.Drawing.Point(41, 81);
            this.popisLinijaDataGridView.Name = "popisLinijaDataGridView";
            this.popisLinijaDataGridView.RowHeadersWidth = 51;
            this.popisLinijaDataGridView.RowTemplate.Height = 24;
            this.popisLinijaDataGridView.Size = new System.Drawing.Size(735, 379);
            this.popisLinijaDataGridView.TabIndex = 1;
            // 
            // odaberiLinijuButton
            // 
            this.odaberiLinijuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaberiLinijuButton.Location = new System.Drawing.Point(477, 478);
            this.odaberiLinijuButton.Name = "odaberiLinijuButton";
            this.odaberiLinijuButton.Size = new System.Drawing.Size(134, 70);
            this.odaberiLinijuButton.TabIndex = 2;
            this.odaberiLinijuButton.Text = "Odaberi liniju";
            this.odaberiLinijuButton.UseVisualStyleBackColor = true;
            this.odaberiLinijuButton.Click += new System.EventHandler(this.odaberiLinijuButton_Click);
            // 
            // nazadButton
            // 
            this.nazadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazadButton.Location = new System.Drawing.Point(642, 478);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(134, 70);
            this.nazadButton.TabIndex = 3;
            this.nazadButton.Text = "Nazad";
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            // 
            // OdaberiLinijuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(832, 576);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.odaberiLinijuButton);
            this.Controls.Add(this.popisLinijaDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OdaberiLinijuForm";
            this.Text = "Odabir linije";
            this.Load += new System.EventHandler(this.OdaberiLinijuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisLinijaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView popisLinijaDataGridView;
        private System.Windows.Forms.Button odaberiLinijuButton;
        private System.Windows.Forms.Button nazadButton;
    }
}