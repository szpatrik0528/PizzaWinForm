using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pizza_winForm
{
    public partial class Form1 : Form
    {
        public string kiválasztottPizza { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Adatbetoltes();
        }

        private void Adatbetoltes()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Vesszővel tagolt CSV |*.csv|Szöveges fájl (*.txt)|*.txt|Összes fájl (*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.Title = "Adatfálj neve";
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.FileName = "Pizza.csv";

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                textBox_faljbetoltes.Text = Path.GetFileName(ofd.FileName);
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_pizza_menu.Items.Add(new Pizza(sr.ReadLine()));
                    }
                }
            }
        }

        private void button_betoltes_Click(object sender, EventArgs e)
        {

        }

        public void Atlagszamitas()
        {
            double atlag = 0;
            foreach (Pizza item in listBox_pizza_menu.Items)
            {
                atlag += item.Par;
            }
            atlag = atlag / listBox_pizza_menu.Items.Count;

            MessageBox.Show($"A pizzák átlagára: {atlag.ToString("#,##0.0 Ft")}", "A pizzák átlaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_atalagar(object sender, EventArgs e)
        {
            Atlagszamitas();
        }

        private void button_fizetesmegerosites_Click(object sender, EventArgs e)
        {
            if (radioButton_bankkartya.Checked)
            {
                MessageBox.Show("Bankkártya opció lett kiválasztva.");
            }
            else if (radioButton_kezpenz.Checked)
            {
                MessageBox.Show("Készpénz opció lett kiválasztva.");
            }
            else
            {
                MessageBox.Show("Nincs kiválasztva fizetési mód.");
            }

            if (checkBox_szamla.Checked)
            {
                MessageBox.Show("Számla ki lesz állítva.");
            }
        }

        private void radioButton_bankkartya_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_kezpenz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_szamla_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_db_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void listBox_kosar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
   
        private void listBox_pizza_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_pizza_menu.SelectedIndex != 0)
            {
                kiválasztottPizza = listBox_pizza_menu.SelectedItem.ToString();
            }
        }

        private void button_hozzaadas_Click(object sender, EventArgs e)
        {

            // Ellenőrizzük, hogy a felhasználó megadott-e egy számot a darabszámhoz.
            if (int.TryParse(textBox_db.Text, out int darabszam))
            {
                // Ellenőrizzük, hogy van-e kiválasztott elem a listBox_pizza_menu-ban.
                if (!string.IsNullOrEmpty(kiválasztottPizza))
                {
                    // Kiválasztott elem hozzáadása a listBox_kosar-hoz a megadott darabszámmal.
                    string kosarElem = $"{kiválasztottPizza} - {darabszam} db";
                    listBox_kosar.Items.Add(kosarElem);

                    // Egyéb módosítások vagy műveletek, amiket végrehajthatnál.
                }
                else
                {
                    MessageBox.Show("Válassz ki egy pizzát a hozzáadáshoz!");
                }
            }
            else
            {
                MessageBox.Show("Kérlek, adj meg egy érvényes számot a darabszámnak!");
            }
            
        }

        private void button_rendeles_Click(object sender, EventArgs e)
        {
            if (listBox_kosar.Items.Count > 0)
            {
                string paymentMethod = "";
                if (radioButton_bankkartya.Checked)
                {
                    paymentMethod = "Bankkártya";
                }
                else if (radioButton_kezpenz.Checked)
                {
                    paymentMethod = "Készpénz";
                }

                string szamlaStatus = checkBox_szamla.Checked ? "Számla kérve" : "Számla nem kérve";

                decimal vegosszeg = 0;
                foreach (var item in listBox_kosar.Items)
                {
                    string[] elemReszek = item.ToString().Split('-');
                    string pizzaNev = elemReszek[0].Trim();
                    int darabszam;

                    if (int.TryParse(elemReszek[1].Trim().Split(' ')[0], out darabszam))
                    {
                        decimal pizzaAr = GetPizzaPriceByName(pizzaNev);
                        decimal pizzaOsszeg = darabszam * pizzaAr;
                        vegosszeg += pizzaOsszeg;
                    }
                }

                string orderDetails = $"Rendelés részletei:\n\n";
                foreach (var item in listBox_kosar.Items)
                {
                    orderDetails += $"{item}\n";
                }
                orderDetails += $"\nFizetési mód: {paymentMethod}\n";
                orderDetails += $"Számla: {szamlaStatus}\n";
                orderDetails += $"Végösszeg: {vegosszeg} Ft";

                
                string filePath = "rendeles.txt";

                System.IO.File.WriteAllText(filePath, orderDetails);

                MessageBox.Show("Rendelés elkészült, a részletek a rendeles.txt fájlba mentve.");
            }
            else
            {
                MessageBox.Show("A kosár üres. Kérlek, adj hozzá elemeket a rendeléshez!");
            }
        }

        private void textBox_vegosszeg_TextChanged(object sender, EventArgs e)
        {
            
            // Kezdetben a végösszeg 0
            decimal vegosszeg = 0;

            // Végigmegyünk minden elemen a kosárban
            foreach (var item in listBox_kosar.Items)
            {
                // Az elem formátuma például: "Pizza név - darabszám db"
                // Szétválasztjuk a "-" karakter mentén
                string[] elemReszek = item.ToString().Split('-');

                // Az első rész a pizza név, a második a darabszám
                string pnev = elemReszek[0].Trim();
                int darabszam;

                // Próbáljuk meg konvertálni a darabszámot számmá
                if (int.TryParse(elemReszek[1].Trim().Split(' ')[0], out darabszam))
                {
                    // Vegyük fel a pizza árát a pizzaNev alapján (ezt be kell állítanod a saját kódodban)
                    decimal par = GetPizzaPriceByName(pnev);

                    // Számoljuk ki a végösszeget az adott pizzára
                    decimal pizzaOsszeg = darabszam * par;

                    // Adjuk hozzá az összeget a teljes végösszeghez
                    vegosszeg += pizzaOsszeg;
                }
            }
            textBox_vegosszeg.Text = $"{vegosszeg} Ft";
        }

        private decimal GetPizzaPriceByName(string pizzaNev)
        {
            return 1000;
        }

        private void button_vegosszeg_Click(object sender, EventArgs e)
        {
            // Kezdetben a végösszeg 0
            decimal vegosszeg = 0;

            // Végigmegyünk minden elemen a kosárban
            foreach (var item in listBox_kosar.Items)
            {
                // Az elem formátuma például: "Pizza név - darabszám db"
                // Szétválasztjuk a "-" karakter mentén
                string[] elemReszek = item.ToString().Split('-');

                // Az első rész a pizza név, a második a darabszám
                string pnev = elemReszek[0].Trim();
                int darabszam;

                // Próbáljuk meg konvertálni a darabszámot számmá
                if (int.TryParse(elemReszek[1].Trim().Split(' ')[0], out darabszam))
                {
                    // Vegyük fel a pizza árát a pizzaNev alapján (ezt be kell állítanod a saját kódodban)
                    decimal par = GetPizzaPriceByName(pnev);

                    // Számoljuk ki a végösszeget az adott pizzára
                    decimal posszeg = darabszam * par;

                    // Adjuk hozzá az összeget a teljes végösszeghez
                    vegosszeg += posszeg;
                }
            }

            // Kiírjuk a végösszeget a textBox_vegosszeg-be
            textBox_vegosszeg.Text = $"{vegosszeg} Ft";
        }
    }

}