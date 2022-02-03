namespace Coursework.Cmd.Implementation_of_windows
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameOlympTexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countCountryNumD = new System.Windows.Forms.NumericUpDown();
            this.CancelBtm = new System.Windows.Forms.Button();
            this.applyBtm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countCountryNumD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "The name of the Olympiad";
            // 
            // NameOlympTexBox
            // 
            this.NameOlympTexBox.Location = new System.Drawing.Point(433, 72);
            this.NameOlympTexBox.Name = "NameOlympTexBox";
            this.NameOlympTexBox.Size = new System.Drawing.Size(401, 39);
            this.NameOlympTexBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(631, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "The number of countries in the Olympiad";
            // 
            // countCountryNumD
            // 
            this.countCountryNumD.Location = new System.Drawing.Point(649, 151);
            this.countCountryNumD.Maximum = new decimal(new int[] {
            195,
            0,
            0,
            0});
            this.countCountryNumD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countCountryNumD.Name = "countCountryNumD";
            this.countCountryNumD.Size = new System.Drawing.Size(185, 39);
            this.countCountryNumD.TabIndex = 3;
            this.countCountryNumD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // CancelBtm
            // 
            this.CancelBtm.BackColor = System.Drawing.Color.Salmon;
            this.CancelBtm.FlatAppearance.BorderSize = 0;
            this.CancelBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtm.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelBtm.Location = new System.Drawing.Point(69, 273);
            this.CancelBtm.Name = "CancelBtm";
            this.CancelBtm.Size = new System.Drawing.Size(271, 65);
            this.CancelBtm.TabIndex = 4;
            this.CancelBtm.Text = "Cancel";
            this.CancelBtm.UseVisualStyleBackColor = false;
            this.CancelBtm.Click += new System.EventHandler(this.CancelBtm_Click);
            // 
            // applyBtm
            // 
            this.applyBtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.applyBtm.FlatAppearance.BorderSize = 0;
            this.applyBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtm.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applyBtm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.applyBtm.Location = new System.Drawing.Point(496, 273);
            this.applyBtm.Name = "applyBtm";
            this.applyBtm.Size = new System.Drawing.Size(271, 65);
            this.applyBtm.TabIndex = 5;
            this.applyBtm.Text = "Apply";
            this.applyBtm.UseVisualStyleBackColor = false;
            this.applyBtm.Click += new System.EventHandler(this.applyBtm_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 373);
            this.Controls.Add(this.applyBtm);
            this.Controls.Add(this.CancelBtm);
            this.Controls.Add(this.countCountryNumD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameOlympTexBox);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.countCountryNumD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox NameOlympTexBox;
        private Label label2;
        private NumericUpDown countCountryNumD;
        private Button CancelBtm;
        private Button applyBtm;
    }
}