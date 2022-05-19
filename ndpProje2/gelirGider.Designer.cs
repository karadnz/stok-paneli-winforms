
namespace ndpProje2
{
    partial class gelirGider
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yenile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTopGelir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lblTopGider = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrPersonel = new System.Windows.Forms.NumericUpDown();
            this.nmrGida = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmrElektrik = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmrIsitma = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nmrDiger = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tarihSecici = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.giderEkle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nmrPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrElektrik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIsitma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiger)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(347, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satis Gelirleri:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(267, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(383, 156);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "musteri";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Urun";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "miktar";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gelir";
            this.columnHeader4.Width = 45;
            // 
            // yenile
            // 
            this.yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenile.Location = new System.Drawing.Point(660, 385);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(94, 53);
            this.yenile.TabIndex = 3;
            this.yenile.Text = "Verileri Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(656, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Gelir:";
            // 
            // lblTopGelir
            // 
            this.lblTopGelir.AutoSize = true;
            this.lblTopGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopGelir.Location = new System.Drawing.Point(698, 178);
            this.lblTopGelir.Name = "lblTopGelir";
            this.lblTopGelir.Size = new System.Drawing.Size(16, 16);
            this.lblTopGelir.TabIndex = 5;
            this.lblTopGelir.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Magaza Gideri Ekle:";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Info;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader12,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(267, 279);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(383, 156);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            this.columnHeader5.Width = 54;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Personel";
            this.columnHeader6.Width = 58;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Elektrik";
            this.columnHeader7.Width = 49;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Isitma";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Diger";
            this.columnHeader9.Width = 43;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Gunluk Toplam";
            this.columnHeader10.Width = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(347, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Magaza Giderleri:";
            // 
            // lblTopGider
            // 
            this.lblTopGider.AutoSize = true;
            this.lblTopGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopGider.Location = new System.Drawing.Point(698, 351);
            this.lblTopGider.Name = "lblTopGider";
            this.lblTopGider.Size = new System.Drawing.Size(16, 16);
            this.lblTopGider.TabIndex = 10;
            this.lblTopGider.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(656, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Toplam Gider:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(22, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personel:";
            // 
            // nmrPersonel
            // 
            this.nmrPersonel.Location = new System.Drawing.Point(130, 100);
            this.nmrPersonel.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrPersonel.Name = "nmrPersonel";
            this.nmrPersonel.Size = new System.Drawing.Size(85, 20);
            this.nmrPersonel.TabIndex = 12;
            // 
            // nmrGida
            // 
            this.nmrGida.Location = new System.Drawing.Point(130, 148);
            this.nmrGida.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrGida.Name = "nmrGida";
            this.nmrGida.Size = new System.Drawing.Size(85, 20);
            this.nmrGida.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(22, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gida";
            // 
            // nmrElektrik
            // 
            this.nmrElektrik.Location = new System.Drawing.Point(130, 190);
            this.nmrElektrik.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrElektrik.Name = "nmrElektrik";
            this.nmrElektrik.Size = new System.Drawing.Size(85, 20);
            this.nmrElektrik.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(22, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Elektrik";
            // 
            // nmrIsitma
            // 
            this.nmrIsitma.Location = new System.Drawing.Point(130, 235);
            this.nmrIsitma.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrIsitma.Name = "nmrIsitma";
            this.nmrIsitma.Size = new System.Drawing.Size(85, 20);
            this.nmrIsitma.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(22, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Isitma";
            // 
            // nmrDiger
            // 
            this.nmrDiger.Location = new System.Drawing.Point(130, 282);
            this.nmrDiger.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrDiger.Name = "nmrDiger";
            this.nmrDiger.Size = new System.Drawing.Size(85, 20);
            this.nmrDiger.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(22, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Diger:";
            // 
            // tarihSecici
            // 
            this.tarihSecici.CustomFormat = "dd-MMM-yyyy";
            this.tarihSecici.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarihSecici.Location = new System.Drawing.Point(130, 332);
            this.tarihSecici.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.tarihSecici.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.tarihSecici.Name = "tarihSecici";
            this.tarihSecici.Size = new System.Drawing.Size(85, 20);
            this.tarihSecici.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(-2, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tarih(dd/mm/yy):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "tarih";
            this.label13.Visible = false;
            // 
            // giderEkle
            // 
            this.giderEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderEkle.Location = new System.Drawing.Point(160, 385);
            this.giderEkle.Name = "giderEkle";
            this.giderEkle.Size = new System.Drawing.Size(97, 36);
            this.giderEkle.TabIndex = 24;
            this.giderEkle.Text = "Gider Ekle";
            this.giderEkle.UseVisualStyleBackColor = true;
            this.giderEkle.Click += new System.EventHandler(this.giderEkle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "tarih text";
            this.label14.Visible = false;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Gida";
            this.columnHeader12.Width = 44;
            // 
            // gelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.giderEkle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tarihSecici);
            this.Controls.Add(this.nmrDiger);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nmrIsitma);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nmrElektrik);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nmrGida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmrPersonel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTopGider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTopGelir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "gelirGider";
            this.Text = "gelirGider";
            ((System.ComponentModel.ISupportInitialize)(this.nmrPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrElektrik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIsitma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTopGelir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTopGider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrPersonel;
        private System.Windows.Forms.NumericUpDown nmrGida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmrElektrik;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmrIsitma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmrDiger;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker tarihSecici;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button giderEkle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}