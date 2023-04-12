namespace Proje_Hastane
{
    partial class FrmDoktorGiriş
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
            this.label3 = new System.Windows.Forms.Label();
            this.GrsBtnHasta = new System.Windows.Forms.Button();
            this.GrsTxtBox = new System.Windows.Forms.TextBox();
            this.GrsTcMsk = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 46);
            this.label3.TabIndex = 13;
            this.label3.Text = "Doktor Giriş Paneli";
            // 
            // GrsBtnHasta
            // 
            this.GrsBtnHasta.Location = new System.Drawing.Point(166, 177);
            this.GrsBtnHasta.Name = "GrsBtnHasta";
            this.GrsBtnHasta.Size = new System.Drawing.Size(107, 31);
            this.GrsBtnHasta.TabIndex = 12;
            this.GrsBtnHasta.Text = "Giriş";
            this.GrsBtnHasta.UseVisualStyleBackColor = true;
            this.GrsBtnHasta.Click += new System.EventHandler(this.GrsBtnHasta_Click);
            // 
            // GrsTxtBox
            // 
            this.GrsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrsTxtBox.Location = new System.Drawing.Point(129, 133);
            this.GrsTxtBox.Name = "GrsTxtBox";
            this.GrsTxtBox.PasswordChar = '*';
            this.GrsTxtBox.Size = new System.Drawing.Size(169, 27);
            this.GrsTxtBox.TabIndex = 10;
            // 
            // GrsTcMsk
            // 
            this.GrsTcMsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrsTcMsk.Location = new System.Drawing.Point(129, 78);
            this.GrsTcMsk.Mask = "00000000000";
            this.GrsTcMsk.Name = "GrsTcMsk";
            this.GrsTcMsk.Size = new System.Drawing.Size(169, 27);
            this.GrsTcMsk.TabIndex = 1;
            this.GrsTcMsk.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC Kimlik No:";
            // 
            // FrmDoktorGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(435, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GrsBtnHasta);
            this.Controls.Add(this.GrsTxtBox);
            this.Controls.Add(this.GrsTcMsk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoktorGiriş";
            this.Text = "FrmDoktorGiriş";
            this.Load += new System.EventHandler(this.FrmDoktorGiriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GrsBtnHasta;
        private System.Windows.Forms.TextBox GrsTxtBox;
        private System.Windows.Forms.MaskedTextBox GrsTcMsk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}