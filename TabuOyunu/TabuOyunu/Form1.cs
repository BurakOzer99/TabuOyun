using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabuOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int doğru = 0;
        int yanlıs = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string [] kelime = { "hece","küsmek","avize","koordinat","terim","soyut","baskül","halisülasyon","armağan","antika","santraç","paraşüt","tiyatro","dost","anahtar","kedi","bonker","fidan","pratik","mesai" };
            string [,] yasak = new string[20, 3];
            yasak[0, 0] = "kelime";
            yasak[0, 1] = "harf";
            yasak[0, 2] = "ses";
            yasak[1, 0] = "darılmak";
            yasak[1, 1] = "kızmak";
            yasak[1, 2] = "konuşmak";
            yasak[2, 0] = "lamba";
            yasak[2, 1] = "kristal";
            yasak[2, 2] = "tavan";
            yasak[3, 0] = "yer";
            yasak[3, 1] = "enlem";
            yasak[3, 2] = "boylam";
            yasak[4, 0] = "kelime";
            yasak[4, 1] = "anlam";
            yasak[4, 2] = "fatih";
            yasak[5, 0] = "duyu";
            yasak[5, 1] = "algılamak";
            yasak[5, 2] = "görülmeyen";
            yasak[6, 0] = "tartı";
            yasak[6, 1] = "kilo";
            yasak[6, 2] = "agır";
            yasak[7, 0] = "hayal";
            yasak[7, 1] = "gercek";
            yasak[7, 2] = "gormek";
            yasak[8, 0] = "hediye";
            yasak[8, 1] = "vermek";
            yasak[8, 2] = "almak";
            yasak[9, 0] = "müzayede";
            yasak[9, 1] = "zengin";
            yasak[9, 2] = "eski";
            yasak[10, 0] = "şah-mat";
            yasak[10, 1] = "kale";
            yasak[10, 2] = "vezir";
            yasak[11, 0] = "uçak";
            yasak[11, 1] = "atlamak";
            yasak[11, 2] = "uçmak"; 
            yasak[12, 0] = "oyuncu";
            yasak[12, 1] = "sahne";
            yasak[12, 2] = "perde";
            yasak[13, 0] = "güven";
            yasak[13, 1] = "samimi";
            yasak[13, 2] = "dürüst";
            yasak[14, 0] = "kilt";
            yasak[14, 1] = "metal";
            yasak[14, 2] = "kasa";
            yasak[15, 0] = "pati";
            yasak[15, 1] = "fare";
            yasak[15, 2] = "tüy";
            yasak[16, 0] = "eliaçık";
            yasak[16, 1] = "cömert";
            yasak[16, 2] = "para";
            yasak[17, 0] = "agaç";
            yasak[17, 1] = "büyümek";
            yasak[17, 2] = "küçük";
            yasak[18, 0] = "kolay";
            yasak[18, 1] = "zeka";
            yasak[18, 2] = "cabuk";
            yasak[19, 0] = "saat";
            yasak[19, 1] = "iş";
            yasak[19, 2] = "fazla";
            timer1.Start();
            Random rnd = new Random();
            int rasgele = rnd.Next(0, kelime.Length);
            textBox1.Text = kelime[rasgele];
            listBox1.Items.Clear();
            for (int i = 0; i < 3; i++)
            {
                listBox1.Items.Add(yasak[rasgele,i]);
            }
            sayac = 0;
            
            Console.ReadLine();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 1;
            progressBar1.Value = sayac;
            label5.Text = sayac.ToString();
            if (sayac==100)
            {
                timer1.Stop();
                Console.WriteLine("süre doldu Game Over");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doğru++;
            label2.Text = doğru.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yanlıs++;
            label4.Text = yanlıs.ToString();
        }
    }
}
