namespace Coursework.Cmd.Implementation_of_windows
{
    partial class FormAddCountryAgents
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
            this.nameCountryTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countPeopleNumD = new System.Windows.Forms.NumericUpDown();
            this.ApplyBtm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countPeopleNumD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the country";
            // 
            // nameCountryTxb
            // 
            this.nameCountryTxb.Location = new System.Drawing.Point(340, 34);
            this.nameCountryTxb.MinimumSize = new System.Drawing.Size(3, 0);
            this.nameCountryTxb.Name = "nameCountryTxb";
            this.nameCountryTxb.Size = new System.Drawing.Size(269, 39);
            this.nameCountryTxb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of representatives";
            // 
            // countPeopleNumD
            // 
            this.countPeopleNumD.Location = new System.Drawing.Point(443, 107);
            this.countPeopleNumD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countPeopleNumD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countPeopleNumD.Name = "countPeopleNumD";
            this.countPeopleNumD.Size = new System.Drawing.Size(166, 39);
            this.countPeopleNumD.TabIndex = 3;
            this.countPeopleNumD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ApplyBtm
            // 
            this.ApplyBtm.BackColor = System.Drawing.Color.PaleGreen;
            this.ApplyBtm.FlatAppearance.BorderSize = 0;
            this.ApplyBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyBtm.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ApplyBtm.Location = new System.Drawing.Point(12, 179);
            this.ApplyBtm.Name = "ApplyBtm";
            this.ApplyBtm.Size = new System.Drawing.Size(752, 66);
            this.ApplyBtm.TabIndex = 4;
            this.ApplyBtm.Text = "Apply";
            this.ApplyBtm.UseVisualStyleBackColor = false;
            this.ApplyBtm.Click += new System.EventHandler(this.ApplyBtm_Click);
            // 
            // FormAddCountryAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.ApplyBtm);
            this.Controls.Add(this.countPeopleNumD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameCountryTxb);
            this.Controls.Add(this.label1);
            this.Name = "FormAddCountryAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddCountryAgents";
            ((System.ComponentModel.ISupportInitialize)(this.countPeopleNumD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nameCountryTxb;
        private Label label2;
        private NumericUpDown countPeopleNumD;
        private Button ApplyBtm;
    }
}