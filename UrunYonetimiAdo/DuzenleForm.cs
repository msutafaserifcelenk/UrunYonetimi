using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetimiAdo.Models;

namespace UrunYonetimiAdo
{
    public partial class DuzenleForm : Form
    {
        private readonly Urun orjinalUrun;
        public event EventHandler<UrunDuzenlendiEventArgs> UrunDuzenlendi;
        public DuzenleForm(Urun urun)
        {
            this.orjinalUrun = urun; //burda sadece orjinal ürünü tutuyoruz
            InitializeComponent();
            txtUrunAd.Text = orjinalUrun.UrunAd;
            nudBirimFiyat.Value = orjinalUrun.BirimFiyat;
        }

        protected virtual void UrunDuzenlendiginde(UrunDuzenlendiEventArgs args) //
        {
            if (UrunDuzenlendi != null)
            {
                UrunDuzenlendi(this, args); // this Ana forma eventin bu formdan(duzenleform) geldiğini bildirir args da kullanılan classın(UrunDuzenlendiEventArgs) özelliklerini gönderir
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string urunAd = txtUrunAd.Text.Trim();
            decimal birimFiyat = nudBirimFiyat.Value;

            if (urunAd == "")
            {
                MessageBox.Show("Ürün adı girmelisiniz.");
                return;
            }

            var args = new UrunDuzenlendiEventArgs();
            args.EskiUrun = orjinalUrun;
            args.YeniUrun = new Urun()
            {
                Id = orjinalUrun.Id,
                UrunAd = urunAd,
                BirimFiyat = birimFiyat
            };

            UrunDuzenlendiginde(args);
            Close();
        }

        private void DuzenleForm_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        //protected miras alanlar görsün diye virtualda ezebilsinler diye
    }


}
