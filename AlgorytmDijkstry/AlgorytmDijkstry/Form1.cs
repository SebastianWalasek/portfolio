using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorytmDijkstry
{
    public partial class Form1 : Form
    {
        private static List<Miasto> lista = new List<Miasto>();
        Miasto startowe, obecneQ;
        int indeksMiasta;
        double odleglos = 0, calkowitaOdleglosc = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // sprawedzenie czy wszystkie pola są wypełnione
            if (textBoxNazwa.Text == "" || textBoxX.Text == "" || textBoxY.Text == "")
            {
                labelError.Text = "Należy wypełnić wszystkie pola !";
            }
            else
            {
                // dodanie nowego Miasta do listy, gdy wszysktie pola są wypełnione
                lista.Add(new Miasto { Nazwa = textBoxNazwa.Text, x = double.Parse(textBoxX.Text), y = double.Parse(textBoxY.Text), zazanczony = false });
                comboBox1.Items.Add(textBoxNazwa.Text);
                textBoxNazwa.Clear();
                textBoxX.Clear();
                textBoxY.Clear();
            }
        }

        // uruchomienie algorytmu, wybranie początkowego Miasta
        private void button1_Click_1(object sender, EventArgs e)
        {
            string wybrane = comboBox1.Text;            
            Miasto results = lista.Find(delegate (Miasto bk)
                {
                    return bk.Nazwa == wybrane;
                }
                );
            startowe = results;
            obecneQ = results;
            najktotszaDroga(obecneQ);

        }

        private string display(Miasto result)
        {
            string wynik = result.Nazwa;
            return wynik;
        }

        // usunięcie obiektów z listy, wyczyszczenie pola tekstowego
        private void button2_Click(object sender, EventArgs e)
        {
            lista.RemoveRange(0, lista.Count);
            comboBox1.Items.Clear();
            richTextBox1.Text = "";
            calkowitaOdleglosc = 0;
        }

        // szukanie Miasta o najkrtoszej drodze
        private int obliczanieDrogi(Miasto obecne)
        {
            double x1 = obecne.x;                                                               // pobranie x z obecengo Miasta
            double y1 = obecne.y;                                                               // pobranie y z obecnego Miasta
            double x2, y2, najkrotszaDroga=0, droga=0;
            for (int licznik = 0; licznik < lista.Count; licznik++)
            {
                if (licznik != lista.IndexOf(obecne) && lista[licznik].zazanczony == false)     // sprawdzenie czy Miasto obecne nie jest takie samo jak Miasto sprawdzane i czy nie było już "odwiedzone" przez algorytm
                {
                    x2 = lista[licznik].x;                                                      // pobranie x Miasta które sprawdzamy
                    y2 = lista[licznik].y;                                                      // pobranie y Miasta które sprawdzamy
                    droga = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));           // obliczenie odległości między punkatami na ośi współrzędnych
                    if (najkrotszaDroga >= droga || najkrotszaDroga == 0)
                    {
                        najkrotszaDroga = droga;
                        indeksMiasta = licznik;
                    }
                }
            }
            odleglos = najkrotszaDroga;
            return indeksMiasta;                                                                // zwrócenie indeksu Miasta w liscie o nakrotszej drodze
        }

        // sprawdzenie wartośći pola tekstowego, czy wartość jest liczbą
        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                labelError.Text = "Nieprawidłowa wartość x !";
                e.Handled = true;
            }
            else
            {
                labelError.Text = "";
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1_Click(sender, e);
            }
        }


        // sprawdzenie wartośći pola tekstowego, czy wartość jest liczbą
        private void textBoxY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                labelError.Text = "Nieprawidłowa wartość y !";
                e.Handled = true;
            }
            else
            {
                labelError.Text = "";
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1_Click(sender, e);
            }
        }

        private void textBoxNazwa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1_Click(sender, e);
            }
        }

        // główna pętla programu
        private void najktotszaDroga(Miasto obecne)
        {
            int indeks;
            for (int i = 0; i < lista.Count-1; i++)
            {
                obecne.zazanczony = true;
                indeks = obliczanieDrogi(obecne);
                obecne = lista[indeks];
                richTextBox1.AppendText("Idę do: " + obecne.Nazwa + " Odległość: " + Math.Round(odleglos,2) + Environment.NewLine);
                calkowitaOdleglosc += odleglos;
            }
            odleglos = Math.Sqrt((startowe.x - obecne.x) * (startowe.x - obecne.x) + (startowe.y - obecne.y) * (startowe.y - obecne.y));
            calkowitaOdleglosc += odleglos;
            richTextBox1.AppendText("Wracam do " + startowe.Nazwa + " Odleglość: "+ Math.Round(odleglos,2)+ Environment.NewLine + "Całkowita odległość: "+ Math.Round(calkowitaOdleglosc,2));
        }
    }
}
