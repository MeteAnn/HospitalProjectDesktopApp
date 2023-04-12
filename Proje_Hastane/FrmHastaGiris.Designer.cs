namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            this.label2 = new System.Windows.Forms.Label();
            this.GrsTcMsk = new System.Windows.Forms.MaskedTextBox();
            this.GrsTxtBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.GrsBtnHasta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // GrsTcMsk
            // 
            this.GrsTcMsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrsTcMsk.Location = new System.Drawing.Point(135, 78);
            this.GrsTcMsk.Mask = "00000000000";
            this.GrsTcMsk.Name = "GrsTcMsk";
            this.GrsTcMsk.Size = new System.Drawing.Size(169, 27);
            this.GrsTcMsk.TabIndex = 2;
            this.GrsTcMsk.ValidatingType = typeof(int);
            // 
            // GrsTxtBox
            // 
            this.GrsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrsTxtBox.Location = new System.Drawing.Point(135, 133);
            this.GrsTxtBox.Name = "GrsTxtBox";
            this.GrsTxtBox.PasswordChar = '*';
            this.GrsTxtBox.Size = new System.Drawing.Size(169, 27);
            this.GrsTxtBox.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(320, 144);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Üye Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // GrsBtnHasta
            // 
            this.GrsBtnHasta.Location = new System.Drawing.Point(197, 184);
            this.GrsBtnHasta.Name = "GrsBtnHasta";
            this.GrsBtnHasta.Size = new System.Drawing.Size(107, 31);
            this.GrsBtnHasta.TabIndex = 5;
            this.GrsBtnHasta.Text = "Giriş";
            this.GrsBtnHasta.UseVisualStyleBackColor = true;
            this.GrsBtnHasta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(72, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta Giriş Paneli";
            // 
            // FrmHastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(442, 247);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GrsBtnHasta);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.GrsTxtBox);
            this.Controls.Add(this.GrsTcMsk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Girişi";
            this.Load += new System.EventHandler(this.FrmGirisler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox GrsTcMsk;
        private System.Windows.Forms.TextBox GrsTxtBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button GrsBtnHasta;
        private System.Windows.Forms.Label label3;
    }
}