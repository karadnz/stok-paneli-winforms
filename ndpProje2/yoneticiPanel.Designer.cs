
namespace ndpProje2
{
    partial class yoneticiPanel
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
            this.musteriGoster = new System.Windows.Forms.Button();
            this.musteriEkle = new System.Windows.Forms.Button();
            this.tedarikciGoster = new System.Windows.Forms.Button();
            this.tedarikciEkle = new System.Windows.Forms.Button();
            this.siparisVer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listIsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.satis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // musteriGoster
            // 
            this.musteriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriGoster.Location = new System.Drawing.Point(16, 157);
            this.musteriGoster.Name = "musteriGoster";
            this.musteriGoster.Size = new System.Drawing.Size(167, 66);
            this.musteriGoster.TabIndex = 0;
            this.musteriGoster.Text = "Musterileri Goster";
            this.musteriGoster.UseVisualStyleBackColor = true;
            this.musteriGoster.Click += new System.EventHandler(this.musteriGoster_Click);
            // 
            // musteriEkle
            // 
            this.musteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriEkle.Location = new System.Drawing.Point(16, 12);
            this.musteriEkle.Name = "musteriEkle";
            this.musteriEkle.Size = new System.Drawing.Size(167, 66);
            this.musteriEkle.TabIndex = 1;
            this.musteriEkle.Text = "Musteri Ekle";
            this.musteriEkle.UseVisualStyleBackColor = true;
            this.musteriEkle.Click += new System.EventHandler(this.musteriEkle_Click);
            // 
            // tedarikciGoster
            // 
            this.tedarikciGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tedarikciGoster.Location = new System.Drawing.Point(216, 156);
            this.tedarikciGoster.Name = "tedarikciGoster";
            this.tedarikciGoster.Size = new System.Drawing.Size(167, 66);
            this.tedarikciGoster.TabIndex = 2;
            this.tedarikciGoster.Text = "Tedarikcileri Goster";
            this.tedarikciGoster.UseVisualStyleBackColor = true;
            this.tedarikciGoster.Click += new System.EventHandler(this.tedarikciGoster_Click);
            // 
            // tedarikciEkle
            // 
            this.tedarikciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tedarikciEkle.Location = new System.Drawing.Point(216, 12);
            this.tedarikciEkle.Name = "tedarikciEkle";
            this.tedarikciEkle.Size = new System.Drawing.Size(167, 66);
            this.tedarikciEkle.TabIndex = 3;
            this.tedarikciEkle.Text = "Tedarkici Ekle";
            this.tedarikciEkle.UseVisualStyleBackColor = true;
            this.tedarikciEkle.Click += new System.EventHandler(this.tedarikciEkle_Click);
            // 
            // siparisVer
            // 
            this.siparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisVer.Location = new System.Drawing.Point(16, 84);
            this.siparisVer.Name = "siparisVer";
            this.siparisVer.Size = new System.Drawing.Size(367, 66);
            this.siparisVer.TabIndex = 4;
            this.siparisVer.Text = "Siparis Ver";
            this.siparisVer.UseVisualStyleBackColor = true;
            this.siparisVer.Click += new System.EventHandler(this.siparisVer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "yazi";
            this.label1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listId,
            this.listIsim,
            this.listTel,
            this.listAdres});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 306);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(415, 196);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listId
            // 
            this.listId.Text = "ID";
            this.listId.Width = 40;
            // 
            // listIsim
            // 
            this.listIsim.Text = "Isim";
            this.listIsim.Width = 140;
            // 
            // listTel
            // 
            this.listTel.Text = "Telefon";
            this.listTel.Width = 150;
            // 
            // listAdres
            // 
            this.listAdres.Text = "Sehir";
            this.listAdres.Width = 80;
            // 
            // satis
            // 
            this.satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satis.Location = new System.Drawing.Point(617, 156);
            this.satis.Name = "satis";
            this.satis.Size = new System.Drawing.Size(179, 66);
            this.satis.TabIndex = 7;
            this.satis.Text = "Satis Bilgilerini Goster";
            this.satis.UseVisualStyleBackColor = true;
            this.satis.Click += new System.EventHandler(this.satis_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(819, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Siparis Bilgilerini Goster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(819, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 65);
            this.button2.TabIndex = 9;
            this.button2.Text = "gelir gider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(617, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 67);
            this.button3.TabIndex = 10;
            this.button3.Text = "stok/depodan-rafa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Info;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(617, 306);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(415, 196);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Isim";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Urun ";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Miktar";
            this.columnHeader4.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(625, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "yazi";
            this.label2.Visible = false;
            // 
            // yoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1066, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.satis);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siparisVer);
            this.Controls.Add(this.tedarikciEkle);
            this.Controls.Add(this.tedarikciGoster);
            this.Controls.Add(this.musteriEkle);
            this.Controls.Add(this.musteriGoster);
            this.Name = "yoneticiPanel";
            this.Text = "yoneticiPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yoneticiPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button musteriGoster;
        private System.Windows.Forms.Button musteriEkle;
        private System.Windows.Forms.Button tedarikciGoster;
        private System.Windows.Forms.Button tedarikciEkle;
        private System.Windows.Forms.Button siparisVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader listId;
        private System.Windows.Forms.ColumnHeader listIsim;
        private System.Windows.Forms.ColumnHeader listTel;
        private System.Windows.Forms.ColumnHeader listAdres;
        private System.Windows.Forms.Button satis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
    }
}