namespace praktikumsenincrud
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
            dataGridView1 = new DataGridView();
            kode = new DataGridViewTextBoxColumn();
            NamaBahan = new DataGridViewTextBoxColumn();
            Kategori = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Satuan = new DataGridViewTextBoxColumn();
            HargaSatuan = new DataGridViewTextBoxColumn();
            BatasMinimum = new DataGridViewTextBoxColumn();
            textSatuan = new TextBox();
            textNamaBahan = new TextBox();
            textKode = new TextBox();
            cmbKategori = new ComboBox();
            numericStok = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericHarsatuan = new NumericUpDown();
            numericBatasMin = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericHarsatuan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBatasMin).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kode, NamaBahan, Kategori, Stok, Satuan, HargaSatuan, BatasMinimum });
            dataGridView1.Location = new Point(201, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(695, 344);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // kode
            // 
            kode.HeaderText = "Kode Bahan";
            kode.Name = "kode";
            kode.ReadOnly = true;
            // 
            // NamaBahan
            // 
            NamaBahan.HeaderText = "Nama Bahan";
            NamaBahan.Name = "NamaBahan";
            NamaBahan.ReadOnly = true;
            // 
            // Kategori
            // 
            Kategori.HeaderText = "Kategori";
            Kategori.Name = "Kategori";
            Kategori.ReadOnly = true;
            // 
            // Stok
            // 
            Stok.HeaderText = "Stok";
            Stok.Name = "Stok";
            Stok.ReadOnly = true;
            // 
            // Satuan
            // 
            Satuan.HeaderText = "Satuan";
            Satuan.Name = "Satuan";
            Satuan.ReadOnly = true;
            // 
            // HargaSatuan
            // 
            HargaSatuan.HeaderText = "Harga Satuan";
            HargaSatuan.Name = "HargaSatuan";
            HargaSatuan.ReadOnly = true;
            // 
            // BatasMinimum
            // 
            BatasMinimum.HeaderText = "Batas Minimum";
            BatasMinimum.Name = "BatasMinimum";
            BatasMinimum.ReadOnly = true;
            // 
            // textSatuan
            // 
            textSatuan.Location = new Point(30, 279);
            textSatuan.Name = "textSatuan";
            textSatuan.Size = new Size(150, 23);
            textSatuan.TabIndex = 0;
            // 
            // textNamaBahan
            // 
            textNamaBahan.Location = new Point(30, 100);
            textNamaBahan.Name = "textNamaBahan";
            textNamaBahan.Size = new Size(150, 23);
            textNamaBahan.TabIndex = 0;
            // 
            // textKode
            // 
            textKode.Location = new Point(30, 48);
            textKode.Name = "textKode";
            textKode.Size = new Size(150, 23);
            textKode.TabIndex = 0;
            textKode.TextChanged += textBox4_TextChanged;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(30, 158);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(150, 23);
            cmbKategori.TabIndex = 2;
            // 
            // numericStok
            // 
            numericStok.Location = new Point(30, 217);
            numericStok.Name = "numericStok";
            numericStok.Size = new Size(150, 23);
            numericStok.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 4;
            label1.Text = "KODE BAHAN :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 82);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 4;
            label2.Text = "NAMA BAHAN :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 135);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "KATEGORI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 194);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 4;
            label4.Text = "STOK :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 256);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "SATUAN :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 320);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 4;
            label6.Text = "HARGA SATUAN :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 391);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 4;
            label7.Text = "BATAS MIN :";
            // 
            // numericHarsatuan
            // 
            numericHarsatuan.Location = new Point(30, 352);
            numericHarsatuan.Name = "numericHarsatuan";
            numericHarsatuan.Size = new Size(150, 23);
            numericHarsatuan.TabIndex = 3;
            // 
            // numericBatasMin
            // 
            numericBatasMin.Location = new Point(33, 417);
            numericBatasMin.Name = "numericBatasMin";
            numericBatasMin.Size = new Size(150, 23);
            numericBatasMin.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Location = new Point(275, 417);
            button1.Name = "button1";
            button1.Size = new Size(122, 35);
            button1.TabIndex = 5;
            button1.Text = "TAMBAH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Location = new Point(513, 417);
            button2.Name = "button2";
            button2.Size = new Size(113, 35);
            button2.TabIndex = 5;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(763, 417);
            button3.Name = "button3";
            button3.Size = new Size(115, 35);
            button3.TabIndex = 5;
            button3.Text = "HAPUS";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 508);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericBatasMin);
            Controls.Add(numericHarsatuan);
            Controls.Add(numericStok);
            Controls.Add(cmbKategori);
            Controls.Add(dataGridView1);
            Controls.Add(textKode);
            Controls.Add(textSatuan);
            Controls.Add(textNamaBahan);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericHarsatuan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBatasMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox textSatuan;
        private TextBox textNamaBahan;
        private TextBox textKode;
        private ComboBox cmbKategori;
        private NumericUpDown numericStok;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericHarsatuan;
        private NumericUpDown numericBatasMin;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn kode;
        private DataGridViewTextBoxColumn NamaBahan;
        private DataGridViewTextBoxColumn Kategori;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewTextBoxColumn Satuan;
        private DataGridViewTextBoxColumn HargaSatuan;
        private DataGridViewTextBoxColumn BatasMinimum;
    }
}
