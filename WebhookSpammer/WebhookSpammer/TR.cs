using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WebhookSpammer
{
    public partial class TR : Form
    {
        public TR()
        {
            InitializeComponent();
        }

        public int basariliMesaj;
        public int basarisizMesaj;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spam başlıyor.");
            basariliMesaj = 0;
            basarisizMesaj = 0;
            if (everyone.Checked)
                spam(webhookURL.Text, webhookName.Text, content.Text + " @everyone", Convert.ToInt32(sayi.Text));
            else
                spam(webhookURL.Text, webhookName.Text, content.Text, Convert.ToInt32(sayi.Text));
        }

        public void spam(string webhookURL, string webhookUsername, string webhookContent, int mesajSayisi)
        {
            WebClient wc = new WebClient();
            Task.Run(() =>
            {
                for (int i = 0; i < mesajSayisi; i++)
                {
                    try
                    {
                        wc.UploadValues(webhookURL, new System.Collections.Specialized.NameValueCollection
                            {
                                {
                                    "username", webhookUsername
                                },
                                {
                                    "content", webhookContent
                                }
                            });
                        basariliMesaj++;
                    }

                    catch (WebException ex)
                    {
                        basarisizMesaj++;
                    }
                }
                MessageBox.Show($"Spam bitti! {basariliMesaj} adet başarılı mesaj, {basarisizMesaj} adet başarısız mesaj bulunuyor!");
            });

        }
    }
}
