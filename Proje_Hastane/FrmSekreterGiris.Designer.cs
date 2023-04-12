namespace Proje_Hastane
{
    partial class FrmSekreterGiris
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
            this.label3.Location = new System.Drawing.Point(59, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sekreter Giriş Paneli";
            // 
            // GrsBtnHasta
            // 
            this.GrsBtnHasta.Location = new System.Drawing.Point(186, 206);
            this.GrsBtnHasta.Name = "GrsBtnHasta";
            this.GrsBtnHasta.Size = new System.Drawing.Size(107, 31);
            this.GrsBtnHasta.TabIndex = 18;
            this.GrsBtnHasta.Text = "Giriş";
            this.GrsBtnHasta.UseVisualStyleBackColor = true;
            this.GrsBtnHasta.Click += new System.EventHandler(this.GrsBtnHasta_Click);
            // 
            // GrsTxtBox
            // 
            this.GrsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrsTxtBox.Location = new System.Drawing.Point(149, 162);
            this.GrsTxtBox.Name = "GrsTxtBox";
            this.GrsTxtBox.PasswordChar = '*';
            this.GrsTxtBox.Size = new System.Drawing.Size(169, 27);
            this.GrsTxtBox.TabIndex = 17;
            this.GrsTxtBox.Text = "1234";
            // 
            // GrsTcMsk
            // 
            this.GrsTcMsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrsTcMsk.Location = new System.Drawing.Point(149, 107);
            this.GrsTcMsk.Mask = "00000000000";
            this.GrsTcMsk.Name = "GrsTcMsk";
            this.GrsTcMsk.Size = new System.Drawing.Size(169, 27);
            this.GrsTcMsk.TabIndex = 16;
            this.GrsTcMsk.Text = "59746385255";
            this.GrsTcMsk.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "TC Kimlik No:";
            // 
            // FrmSekreterGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 264);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GrsBtnHasta);
            this.Controls.Add(this.GrsTxtBox);
            this.Controls.Add(this.GrsTcMsk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSekreterGiris";
            this.Text = "FrmSekreterGiris";
            this.Load += new System.EventHandler(this.FrmSekreterGiris_Load);
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