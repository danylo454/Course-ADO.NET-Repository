namespace Coursework.Cmd.Implementation_of_windows
{
    partial class FormShow
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
            this.table = new System.Windows.Forms.DataGridView();
            this.OlimpiadaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Silver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bronze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OlimpiadaName,
            this.CountryName,
            this.Gold,
            this.Silver,
            this.Bronze,
            this.Count});
            this.table.Location = new System.Drawing.Point(2, 64);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 82;
            this.table.RowTemplate.Height = 41;
            this.table.Size = new System.Drawing.Size(1323, 545);
            this.table.TabIndex = 0;
            // 
            // OlimpiadaName
            // 
            this.OlimpiadaName.HeaderText = "Olimpiada";
            this.OlimpiadaName.MinimumWidth = 10;
            this.OlimpiadaName.Name = "OlimpiadaName";
            this.OlimpiadaName.ReadOnly = true;
            this.OlimpiadaName.Width = 200;
            // 
            // CountryName
            // 
            this.CountryName.HeaderText = "Country";
            this.CountryName.MinimumWidth = 10;
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            this.CountryName.Width = 200;
            // 
            // Gold
            // 
            this.Gold.HeaderText = "Gold";
            this.Gold.MinimumWidth = 10;
            this.Gold.Name = "Gold";
            this.Gold.ReadOnly = true;
            this.Gold.Width = 200;
            // 
            // Silver
            // 
            this.Silver.HeaderText = "Silver";
            this.Silver.MinimumWidth = 10;
            this.Silver.Name = "Silver";
            this.Silver.ReadOnly = true;
            this.Silver.Width = 200;
            // 
            // Bronze
            // 
            this.Bronze.HeaderText = "Bronze";
            this.Bronze.MinimumWidth = 10;
            this.Bronze.Name = "Bronze";
            this.Bronze.ReadOnly = true;
            this.Bronze.Width = 200;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 10;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Top 5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sorting";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show Players";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 621);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.table);
            this.Name = "FormShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShow";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn OlimpiadaName;
        private DataGridViewTextBoxColumn CountryName;
        private DataGridViewTextBoxColumn Gold;
        private DataGridViewTextBoxColumn Silver;
        private DataGridViewTextBoxColumn Bronze;
        private DataGridViewTextBoxColumn Count;
        private DataGridView table;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}