namespace Coursework.Cmd.Implementation_of_windows
{
    partial class FormAddPeople
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
            this.labelPlayer = new System.Windows.Forms.Label();
            this.nameTexb = new System.Windows.Forms.TextBox();
            this.surnameTexB = new System.Windows.Forms.TextBox();
            this.midllenameTexB = new System.Windows.Forms.TextBox();
            this.CountryTexb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ApplyBtm = new System.Windows.Forms.Button();
            this.dateTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Bauhaus 93", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayer.Location = new System.Drawing.Point(12, 9);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(163, 42);
            this.labelPlayer.TabIndex = 0;
            this.labelPlayer.Text = "Player 1";
            // 
            // nameTexb
            // 
            this.nameTexb.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTexb.Location = new System.Drawing.Point(118, 88);
            this.nameTexb.Name = "nameTexb";
            this.nameTexb.Size = new System.Drawing.Size(366, 43);
            this.nameTexb.TabIndex = 1;
            this.nameTexb.TextChanged += new System.EventHandler(this.nameTexb_TextChanged);
            // 
            // surnameTexB
            // 
            this.surnameTexB.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnameTexB.Location = new System.Drawing.Point(173, 144);
            this.surnameTexB.Name = "surnameTexB";
            this.surnameTexB.Size = new System.Drawing.Size(311, 43);
            this.surnameTexB.TabIndex = 2;
            this.surnameTexB.TextChanged += new System.EventHandler(this.surnameTexB_TextChanged);
            // 
            // midllenameTexB
            // 
            this.midllenameTexB.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.midllenameTexB.Location = new System.Drawing.Point(222, 208);
            this.midllenameTexB.Name = "midllenameTexB";
            this.midllenameTexB.Size = new System.Drawing.Size(264, 43);
            this.midllenameTexB.TabIndex = 3;
            this.midllenameTexB.TextChanged += new System.EventHandler(this.midllenameTexB_TextChanged);
            // 
            // CountryTexb
            // 
            this.CountryTexb.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountryTexb.Location = new System.Drawing.Point(173, 270);
            this.CountryTexb.Name = "CountryTexb";
            this.CountryTexb.ReadOnly = true;
            this.CountryTexb.Size = new System.Drawing.Size(311, 43);
            this.CountryTexb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "MiddleName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of birth: ";
            // 
            // ApplyBtm
            // 
            this.ApplyBtm.Location = new System.Drawing.Point(118, 437);
            this.ApplyBtm.Name = "ApplyBtm";
            this.ApplyBtm.Size = new System.Drawing.Size(310, 63);
            this.ApplyBtm.TabIndex = 12;
            this.ApplyBtm.Text = "Apply";
            this.ApplyBtm.UseVisualStyleBackColor = true;
            this.ApplyBtm.Click += new System.EventHandler(this.ApplyBtm_Click);
            // 
            // dateTextBox1
            // 
            this.dateTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTextBox1.Location = new System.Drawing.Point(253, 338);
            this.dateTextBox1.Mask = "00/00/0000";
            this.dateTextBox1.Name = "dateTextBox1";
            this.dateTextBox1.Size = new System.Drawing.Size(231, 43);
            this.dateTextBox1.TabIndex = 13;
            this.dateTextBox1.ValidatingType = typeof(System.DateTime);
            this.dateTextBox1.TextChanged += new System.EventHandler(this.dateTextBox1_TextChanged);
            // 
            // FormAddPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 580);
            this.Controls.Add(this.dateTextBox1);
            this.Controls.Add(this.ApplyBtm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryTexb);
            this.Controls.Add(this.midllenameTexB);
            this.Controls.Add(this.surnameTexB);
            this.Controls.Add(this.nameTexb);
            this.Controls.Add(this.labelPlayer);
            this.Name = "FormAddPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddPeople";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPlayer;
        private TextBox nameTexb;
        private TextBox surnameTexB;
        private TextBox midllenameTexB;
        private TextBox CountryTexb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button ApplyBtm;
        private MaskedTextBox dateTextBox1;
    }
}