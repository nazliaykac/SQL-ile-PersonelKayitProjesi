namespace PersonelKayıtProjesi
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
            groupBox2 = new GroupBox();
            btngrfk = new Button();
            btnistatis = new Button();
            btntemiz = new Button();
            btngüncel = new Button();
            btnsil = new Button();
            btnkydt = new Button();
            btnliste = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textid = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textad = new TextBox();
            textBoxsoy = new TextBox();
            textBoxmaas = new TextBox();
            textBoxmeslk = new TextBox();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            radioButton2 = new RadioButton();
            label8 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btngrfk);
            groupBox2.Controls.Add(btnistatis);
            groupBox2.Controls.Add(btntemiz);
            groupBox2.Controls.Add(btngüncel);
            groupBox2.Controls.Add(btnsil);
            groupBox2.Controls.Add(btnkydt);
            groupBox2.Controls.Add(btnliste);
            groupBox2.Location = new Point(385, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(403, 372);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlemler";
            // 
            // btngrfk
            // 
            btngrfk.Location = new Point(115, 257);
            btngrfk.Name = "btngrfk";
            btngrfk.Size = new Size(155, 29);
            btngrfk.TabIndex = 8;
            btngrfk.Text = "Grafik";
            btngrfk.UseVisualStyleBackColor = true;
            btngrfk.Click += btngrfk_Click;
            // 
            // btnistatis
            // 
            btnistatis.Location = new Point(115, 222);
            btnistatis.Name = "btnistatis";
            btnistatis.Size = new Size(155, 29);
            btnistatis.TabIndex = 7;
            btnistatis.Text = "İstatistik";
            btnistatis.UseVisualStyleBackColor = true;
            btnistatis.Click += btnistatis_Click;
            // 
            // btntemiz
            // 
            btntemiz.Location = new Point(115, 187);
            btntemiz.Name = "btntemiz";
            btntemiz.Size = new Size(155, 29);
            btntemiz.TabIndex = 6;
            btntemiz.Text = "Temizle";
            btntemiz.UseVisualStyleBackColor = true;
            btntemiz.Click += btntemiz_Click;
            // 
            // btngüncel
            // 
            btngüncel.Location = new Point(115, 152);
            btngüncel.Name = "btngüncel";
            btngüncel.Size = new Size(155, 29);
            btngüncel.TabIndex = 5;
            btngüncel.Text = "Güncelle";
            btngüncel.UseVisualStyleBackColor = true;
            btngüncel.Click += btngüncel_Click;
            // 
            // btnsil
            // 
            btnsil.Location = new Point(115, 117);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(155, 29);
            btnsil.TabIndex = 4;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // btnkydt
            // 
            btnkydt.Location = new Point(115, 82);
            btnkydt.Name = "btnkydt";
            btnkydt.Size = new Size(155, 29);
            btnkydt.TabIndex = 3;
            btnkydt.Text = "Kaydet";
            btnkydt.UseVisualStyleBackColor = true;
            btnkydt.Click += btnkydt_Click;
            // 
            // btnliste
            // 
            btnliste.Location = new Point(115, 47);
            btnliste.Name = "btnliste";
            btnliste.Size = new Size(155, 29);
            btnliste.TabIndex = 2;
            btnliste.Text = "Listele";
            btnliste.UseVisualStyleBackColor = true;
            btnliste.Click += btnliste_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 390);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 304);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kayıtlar";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(770, 278);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 47);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Personel id:";
            // 
            // textid
            // 
            textid.Location = new Point(172, 44);
            textid.Name = "textid";
            textid.Size = new Size(125, 27);
            textid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 86);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Personel ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 126);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 3;
            label3.Text = "Personel Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 161);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 4;
            label4.Text = "Şehir:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 196);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 5;
            label5.Text = "Maaş:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 231);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 6;
            label6.Text = "Durum:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 275);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 7;
            label7.Text = "Meslek:";
            // 
            // textad
            // 
            textad.Location = new Point(172, 84);
            textad.Name = "textad";
            textad.Size = new Size(125, 27);
            textad.TabIndex = 8;
            // 
            // textBoxsoy
            // 
            textBoxsoy.Location = new Point(172, 126);
            textBoxsoy.Name = "textBoxsoy";
            textBoxsoy.Size = new Size(125, 27);
            textBoxsoy.TabIndex = 9;
            // 
            // textBoxmaas
            // 
            textBoxmaas.Location = new Point(172, 189);
            textBoxmaas.Name = "textBoxmaas";
            textBoxmaas.Size = new Size(125, 27);
            textBoxmaas.TabIndex = 10;
            // 
            // textBoxmeslk
            // 
            textBoxmeslk.Location = new Point(172, 268);
            textBoxmeslk.Name = "textBoxmeslk";
            textBoxmeslk.Size = new Size(125, 27);
            textBoxmeslk.TabIndex = 11;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(172, 238);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Evli";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBoxmeslk);
            groupBox1.Controls.Add(textBoxmaas);
            groupBox1.Controls.Add(textBoxsoy);
            groupBox1.Controls.Add(textad);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textid);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 372);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayıt";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(172, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 9;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(231, 238);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 24);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bekar";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(791, 252);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 14;
            label8.Text = "label8";
            label8.Visible = false;
            label8.TextChanged += label8_TextChanged;
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(998, 719);
            Controls.Add(label8);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnliste;
        private Button btngrfk;
        private Button btnistatis;
        private Button btntemiz;
        private Button btngüncel;
        private Button btnsil;
        private Button btnkydt;
        private Label label1;
        private TextBox textid;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textad;
        private TextBox textBoxsoy;
        private TextBox textBoxmaas;
        private TextBox textBoxmeslk;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private DataGridView dataGridView1;
        private Label label8;
    }
}
