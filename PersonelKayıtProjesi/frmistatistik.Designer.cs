namespace PersonelKayıtProjesi
{
    partial class frmistatistik
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
            label3 = new Label();
            lblToplamPersonel = new Label();
            lblEvliPersonel = new Label();
            lblBekarPersonel = new Label();
            label7 = new Label();
            lblsehirSayısı = new Label();
            label9 = new Label();
            label10 = new Label();
            lblToplamMaas = new Label();
            lblOrtMaas = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 61);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Toplam Personel Sayısı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 100);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 1;
            label2.Text = "Evli Personel Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 137);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 2;
            label3.Text = "Bekar Personel Sayısı:";
            // 
            // lblToplamPersonel
            // 
            lblToplamPersonel.AutoSize = true;
            lblToplamPersonel.Location = new Point(384, 61);
            lblToplamPersonel.Name = "lblToplamPersonel";
            lblToplamPersonel.Size = new Size(17, 20);
            lblToplamPersonel.TabIndex = 3;
            lblToplamPersonel.Text = "0";
            // 
            // lblEvliPersonel
            // 
            lblEvliPersonel.AutoSize = true;
            lblEvliPersonel.Location = new Point(384, 100);
            lblEvliPersonel.Name = "lblEvliPersonel";
            lblEvliPersonel.Size = new Size(17, 20);
            lblEvliPersonel.TabIndex = 4;
            lblEvliPersonel.Text = "0";
            // 
            // lblBekarPersonel
            // 
            lblBekarPersonel.AutoSize = true;
            lblBekarPersonel.Location = new Point(384, 137);
            lblBekarPersonel.Name = "lblBekarPersonel";
            lblBekarPersonel.Size = new Size(17, 20);
            lblBekarPersonel.TabIndex = 5;
            lblBekarPersonel.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(193, 172);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 6;
            label7.Text = "Şehir Sayısı:";
            // 
            // lblsehirSayısı
            // 
            lblsehirSayısı.AutoSize = true;
            lblsehirSayısı.Location = new Point(384, 172);
            lblsehirSayısı.Name = "lblsehirSayısı";
            lblsehirSayısı.Size = new Size(17, 20);
            lblsehirSayısı.TabIndex = 7;
            lblsehirSayısı.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(193, 204);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 8;
            label9.Text = "Toplam Maaş:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(193, 238);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 9;
            label10.Text = "Ortalama Maaş:";
            // 
            // lblToplamMaas
            // 
            lblToplamMaas.AutoSize = true;
            lblToplamMaas.Location = new Point(384, 204);
            lblToplamMaas.Name = "lblToplamMaas";
            lblToplamMaas.Size = new Size(17, 20);
            lblToplamMaas.TabIndex = 10;
            lblToplamMaas.Text = "0";
            // 
            // lblOrtMaas
            // 
            lblOrtMaas.AutoSize = true;
            lblOrtMaas.Location = new Point(384, 238);
            lblOrtMaas.Name = "lblOrtMaas";
            lblOrtMaas.Size = new Size(17, 20);
            lblOrtMaas.TabIndex = 11;
            lblOrtMaas.Text = "0";
            // 
            // frmistatistik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOrtMaas);
            Controls.Add(lblToplamMaas);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lblsehirSayısı);
            Controls.Add(label7);
            Controls.Add(lblBekarPersonel);
            Controls.Add(lblEvliPersonel);
            Controls.Add(lblToplamPersonel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmistatistik";
            Text = "frmistatistik";
            Load += frmistatistik_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblToplamPersonel;
        private Label lblEvliPersonel;
        private Label lblBekarPersonel;
        private Label label7;
        private Label lblsehirSayısı;
        private Label label9;
        private Label label10;
        private Label lblToplamMaas;
        private Label lblOrtMaas;
    }
}