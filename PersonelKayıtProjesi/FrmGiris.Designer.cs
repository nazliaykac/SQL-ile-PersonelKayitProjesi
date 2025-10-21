namespace PersonelKayıtProjesi
{
    partial class FrmGiris
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
            label1 = new Label();
            label2 = new Label();
            txtad = new TextBox();
            txtsifre = new TextBox();
            btngiris = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 112);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 162);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txtad
            // 
            txtad.Location = new Point(345, 112);
            txtad.Name = "txtad";
            txtad.Size = new Size(177, 27);
            txtad.TabIndex = 2;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(345, 159);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(177, 27);
            txtsifre.TabIndex = 3;
            txtsifre.UseSystemPasswordChar = true;
            // 
            // btngiris
            // 
            btngiris.Location = new Point(287, 225);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(197, 49);
            btngiris.TabIndex = 4;
            btngiris.Text = "Giriş Yap";
            btngiris.UseVisualStyleBackColor = true;
            btngiris.Click += btngiris_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(108, 9);
            label3.Name = "label3";
            label3.Size = new Size(584, 41);
            label3.TabIndex = 5;
            label3.Text = "PERSONEL TAKİP SİSTEMİ GİRİŞ EKRANI";
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btngiris);
            Controls.Add(txtsifre);
            Controls.Add(txtad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmGiris";
            Text = "FrmGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtad;
        private TextBox txtsifre;
        private Button btngiris;
        private Label label3;
    }
}