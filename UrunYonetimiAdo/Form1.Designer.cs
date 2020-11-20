namespace UrunYonetimiAdo
{
    partial class Form1
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
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvUrunler.Location = new System.Drawing.Point(19, 66);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(368, 248);
            this.dgvUrunler.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UrunAd";
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BirimFiyat";
            this.Column3.HeaderText = "Birim Fiyatı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // nudBirimFiyat
            // 
            this.nudBirimFiyat.Location = new System.Drawing.Point(141, 39);
            this.nudBirimFiyat.Name = "nudBirimFiyat";
            this.nudBirimFiyat.Size = new System.Drawing.Size(142, 20);
            this.nudBirimFiyat.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(289, 34);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 28);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(19, 39);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(116, 20);
            this.txtUrunAd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Birim Fiyatı:";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(125, 320);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(98, 28);
            this.btnDuzenle.TabIndex = 8;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(21, 320);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 28);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 359);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudBirimFiyat);
            this.Controls.Add(this.dgvUrunler);
            this.Name = "Form1";
            this.Text = "Ürün Yönetimi(ADO.NET)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.NumericUpDown nudBirimFiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

