namespace Coursework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddOlypBtm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddOlypBtm
            // 
            this.AddOlypBtm.FlatAppearance.BorderSize = 4;
            this.AddOlypBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOlypBtm.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddOlypBtm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddOlypBtm.Location = new System.Drawing.Point(136, 166);
            this.AddOlypBtm.Name = "AddOlypBtm";
            this.AddOlypBtm.Size = new System.Drawing.Size(380, 74);
            this.AddOlypBtm.TabIndex = 0;
            this.AddOlypBtm.Text = "Add The Olympiad";
            this.AddOlypBtm.UseVisualStyleBackColor = true;
            this.AddOlypBtm.Click += new System.EventHandler(this.AddOlypBtm_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(136, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update The Olympiad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(136, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show The Olympiad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 728);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddOlypBtm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olympiada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddOlypBtm;
        private Button button1;
        private Button button2;
    }
}