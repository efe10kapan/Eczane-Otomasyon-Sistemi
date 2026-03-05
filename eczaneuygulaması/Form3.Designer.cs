namespace eczaneuygulaması
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkayıtara = new System.Windows.Forms.Button();
            this.btnkayıtsil = new System.Windows.Forms.Button();
            this.btnkayıtekle = new System.Windows.Forms.Button();
            this.btngüncel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedtxtilackodu = new System.Windows.Forms.MaskedTextBox();
            this.txtsırano = new System.Windows.Forms.TextBox();
            this.txtilacadi = new System.Windows.Forms.TextBox();
            this.txtüfirmasi = new System.Windows.Forms.TextBox();
            this.txtksekli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtkadet = new System.Windows.Forms.TextBox();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.txtsonktarihi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbreceteli = new System.Windows.Forms.RadioButton();
            this.rbrecetesiz = new System.Windows.Forms.RadioButton();
            this.rbtum = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btnödeme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(314, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sıra No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(284, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlaç Kodu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(299, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "İlaç Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(231, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Üretim Firması :";
            // 
            // btnkayıtara
            // 
            this.btnkayıtara.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnkayıtara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkayıtara.FlatAppearance.BorderSize = 0;
            this.btnkayıtara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayıtara.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıtara.ForeColor = System.Drawing.Color.LightGray;
            this.btnkayıtara.Location = new System.Drawing.Point(3, 60);
            this.btnkayıtara.Name = "btnkayıtara";
            this.btnkayıtara.Size = new System.Drawing.Size(163, 55);
            this.btnkayıtara.TabIndex = 5;
            this.btnkayıtara.Text = "Kayıt Ara";
            this.btnkayıtara.UseVisualStyleBackColor = false;
            this.btnkayıtara.Click += new System.EventHandler(this.btnkayıtara_Click);
            // 
            // btnkayıtsil
            // 
            this.btnkayıtsil.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnkayıtsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkayıtsil.FlatAppearance.BorderSize = 0;
            this.btnkayıtsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayıtsil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıtsil.ForeColor = System.Drawing.Color.LightGray;
            this.btnkayıtsil.Location = new System.Drawing.Point(5, 121);
            this.btnkayıtsil.Name = "btnkayıtsil";
            this.btnkayıtsil.Size = new System.Drawing.Size(161, 55);
            this.btnkayıtsil.TabIndex = 6;
            this.btnkayıtsil.Text = "Kayıt Sil";
            this.btnkayıtsil.UseVisualStyleBackColor = false;
            this.btnkayıtsil.Click += new System.EventHandler(this.btnkayıtsil_Click);
            // 
            // btnkayıtekle
            // 
            this.btnkayıtekle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnkayıtekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkayıtekle.FlatAppearance.BorderSize = 0;
            this.btnkayıtekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayıtekle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıtekle.ForeColor = System.Drawing.Color.LightGray;
            this.btnkayıtekle.Location = new System.Drawing.Point(5, 182);
            this.btnkayıtekle.Name = "btnkayıtekle";
            this.btnkayıtekle.Size = new System.Drawing.Size(161, 56);
            this.btnkayıtekle.TabIndex = 7;
            this.btnkayıtekle.Text = "Kayıt Ekle";
            this.btnkayıtekle.UseVisualStyleBackColor = false;
            this.btnkayıtekle.Click += new System.EventHandler(this.button3_Click);
            // 
            // btngüncel
            // 
            this.btngüncel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btngüncel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngüncel.FlatAppearance.BorderSize = 0;
            this.btngüncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngüncel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncel.ForeColor = System.Drawing.Color.LightGray;
            this.btngüncel.Location = new System.Drawing.Point(5, 244);
            this.btngüncel.Name = "btngüncel";
            this.btngüncel.Size = new System.Drawing.Size(161, 56);
            this.btngüncel.TabIndex = 8;
            this.btngüncel.Text = "Güncelle";
            this.btngüncel.UseVisualStyleBackColor = false;
            this.btngüncel.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(634, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kullanım Şekli :";
            // 
            // maskedtxtilackodu
            // 
            this.maskedtxtilackodu.Location = new System.Drawing.Point(397, 75);
            this.maskedtxtilackodu.Mask = "0000";
            this.maskedtxtilackodu.Name = "maskedtxtilackodu";
            this.maskedtxtilackodu.Size = new System.Drawing.Size(100, 22);
            this.maskedtxtilackodu.TabIndex = 10;
            this.maskedtxtilackodu.ValidatingType = typeof(int);
            // 
            // txtsırano
            // 
            this.txtsırano.Location = new System.Drawing.Point(397, 35);
            this.txtsırano.Name = "txtsırano";
            this.txtsırano.Size = new System.Drawing.Size(100, 22);
            this.txtsırano.TabIndex = 11;
            // 
            // txtilacadi
            // 
            this.txtilacadi.Location = new System.Drawing.Point(397, 116);
            this.txtilacadi.Name = "txtilacadi";
            this.txtilacadi.Size = new System.Drawing.Size(100, 22);
            this.txtilacadi.TabIndex = 12;
            // 
            // txtüfirmasi
            // 
            this.txtüfirmasi.Location = new System.Drawing.Point(397, 162);
            this.txtüfirmasi.Name = "txtüfirmasi";
            this.txtüfirmasi.Size = new System.Drawing.Size(100, 22);
            this.txtüfirmasi.TabIndex = 13;
            // 
            // txtksekli
            // 
            this.txtksekli.Location = new System.Drawing.Point(788, 35);
            this.txtksekli.Name = "txtksekli";
            this.txtksekli.Size = new System.Drawing.Size(100, 22);
            this.txtksekli.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(706, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fiyatı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(670, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kaç Adet :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(660, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Barkod No :";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(788, 75);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 22);
            this.txtfiyat.TabIndex = 18;
            // 
            // txtkadet
            // 
            this.txtkadet.Location = new System.Drawing.Point(788, 116);
            this.txtkadet.Name = "txtkadet";
            this.txtkadet.Size = new System.Drawing.Size(100, 22);
            this.txtkadet.TabIndex = 19;
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(788, 152);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(100, 22);
            this.txtbarkodno.TabIndex = 20;
            // 
            // txtsonktarihi
            // 
            this.txtsonktarihi.Location = new System.Drawing.Point(788, 198);
            this.txtsonktarihi.Name = "txtsonktarihi";
            this.txtsonktarihi.Size = new System.Drawing.Size(100, 22);
            this.txtsonktarihi.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(596, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Son Kullanım Tarihi :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rbreceteli);
            this.panel1.Controls.Add(this.rbrecetesiz);
            this.panel1.Controls.Add(this.rbtum);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtsırano);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtsonktarihi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtbarkodno);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtkadet);
            this.panel1.Controls.Add(this.maskedtxtilackodu);
            this.panel1.Controls.Add(this.txtfiyat);
            this.panel1.Controls.Add(this.txtilacadi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtüfirmasi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtksekli);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(164, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 682);
            this.panel1.TabIndex = 25;
            // 
            // rbreceteli
            // 
            this.rbreceteli.AutoSize = true;
            this.rbreceteli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbreceteli.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbreceteli.Location = new System.Drawing.Point(76, 225);
            this.rbreceteli.Name = "rbreceteli";
            this.rbreceteli.Size = new System.Drawing.Size(102, 26);
            this.rbreceteli.TabIndex = 30;
            this.rbreceteli.TabStop = true;
            this.rbreceteli.Text = "Reçeteli";
            this.rbreceteli.UseVisualStyleBackColor = true;
            // 
            // rbrecetesiz
            // 
            this.rbrecetesiz.AutoSize = true;
            this.rbrecetesiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbrecetesiz.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbrecetesiz.Location = new System.Drawing.Point(226, 225);
            this.rbrecetesiz.Name = "rbrecetesiz";
            this.rbrecetesiz.Size = new System.Drawing.Size(114, 26);
            this.rbrecetesiz.TabIndex = 28;
            this.rbrecetesiz.TabStop = true;
            this.rbrecetesiz.Text = "Reçetesiz";
            this.rbrecetesiz.UseVisualStyleBackColor = true;
            // 
            // rbtum
            // 
            this.rbtum.AutoSize = true;
            this.rbtum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtum.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtum.Location = new System.Drawing.Point(397, 225);
            this.rbtum.Name = "rbtum";
            this.rbtum.Size = new System.Drawing.Size(126, 26);
            this.rbtum.TabIndex = 29;
            this.rbtum.TabStop = true;
            this.rbtum.Text = "Tüm ilaçlar";
            this.rbtum.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(3, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "MediChain";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncıkıs.FlatAppearance.BorderSize = 0;
            this.btncıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncıkıs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.ForeColor = System.Drawing.Color.Black;
            this.btncıkıs.Location = new System.Drawing.Point(3, 654);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(40, 30);
            this.btncıkıs.TabIndex = 26;
            this.btncıkıs.Text = "x";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btnödeme
            // 
            this.btnödeme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnödeme.FlatAppearance.BorderSize = 0;
            this.btnödeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnödeme.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnödeme.ForeColor = System.Drawing.Color.LightGray;
            this.btnödeme.Location = new System.Drawing.Point(-2, 306);
            this.btnödeme.Name = "btnödeme";
            this.btnödeme.Size = new System.Drawing.Size(168, 46);
            this.btnödeme.TabIndex = 27;
            this.btnödeme.Text = "Ödeme Yap";
            this.btnödeme.UseVisualStyleBackColor = false;
            this.btnödeme.Click += new System.EventHandler(this.btnfiltrele_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1221, 685);
            this.Controls.Add(this.btnödeme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btnkayıtara);
            this.Controls.Add(this.btngüncel);
            this.Controls.Add(this.btnkayıtsil);
            this.Controls.Add(this.btnkayıtekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkayıtara;
        private System.Windows.Forms.Button btnkayıtsil;
        private System.Windows.Forms.Button btnkayıtekle;
        private System.Windows.Forms.Button btngüncel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedtxtilackodu;
        private System.Windows.Forms.TextBox txtsırano;
        private System.Windows.Forms.TextBox txtilacadi;
        private System.Windows.Forms.TextBox txtüfirmasi;
        private System.Windows.Forms.TextBox txtksekli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtkadet;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.TextBox txtsonktarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbreceteli;
        private System.Windows.Forms.RadioButton rbrecetesiz;
        private System.Windows.Forms.RadioButton rbtum;
        private System.Windows.Forms.Button btnödeme;
    }
}