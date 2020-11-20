namespace UrunYonetimiAdo
{
    partial class DuzenleForm
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
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.nudBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // btnİptal
            // 
            this.btnİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Location = new System.Drawing.Point(16, 86);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(82, 29);
            this.btnİptal.TabIndex = 1;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(118, 12);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(120, 20);
            this.txtUrunAd.TabIndex = 2;
            // 
            // nudBirimFiyat
            // 
            this.nudBirimFiyat.Location = new System.Drawing.Point(119, 47);
            this.nudBirimFiyat.Name = "nudBirimFiyat";
            this.nudBirimFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudBirimFiyat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birim Fiyatı:";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(104, 86);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(122, 29);
            this.btnDuzenle.TabIndex = 5;
            this.btnDuzenle.Text = "KAYDET";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // DuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 137);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudBirimFiyat);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.label1);
            this.Name = "DuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DuzenleForm";
            this.Load += new System.EventHandler(this.DuzenleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.NumericUpDown nudBirimFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDuzenle;
    }
}