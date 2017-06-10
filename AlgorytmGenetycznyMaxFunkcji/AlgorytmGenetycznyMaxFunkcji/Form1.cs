using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AlgorytmGenetycznyMaxFunkcji
{
    public partial class Form1 : Form
    {
        public string rodzic;
        public List<string> rodzice = new List<string>();
        public List<string> tempOsobnik = new List<string>();
        public List<int> tablicaWykresu = new List<int>();


        int licznik = 1;
        public int suma, ocena, sumaOceny, maxOsobnik = 0, wKroku, maxOsobnikOstatni;
        int a,b,iloscPowtorzen;

        public Form1()
        {
            InitializeComponent();
            comboBoxFunkcja.Items.Add("ax^2 + b");
        }

        public void losowaniePuli()
        {
            Random losowanie = new Random();
            int temp=0;
            for (int x = 0; x <= 5; x++)
            {
                for (int i = 0; i <= 4; i++) 
                {
                    temp = losowanie.Next(0, 2); 
                    rodzic += temp.ToString();
                }
                rodzice.Add(rodzic);
                rodzic = ""; 
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            Thread thr = new Thread(glownaPetla);
            if (!string.IsNullOrEmpty(textBoxA.Text))
            {
                a = Convert.ToInt32(textBoxA.Text);
            }
            if (!string.IsNullOrEmpty(textBoxB.Text))
            {
                b = Convert.ToInt32(textBoxB.Text);
            }
            textBoxA.Enabled = false;
            textBoxB.Enabled = false;
            iloscPowtorzen = Convert.ToInt32(numericUpDown_ilsocPowtorzen.Value);
            losowaniePuli();
            thr.Start();
            buttonDalej.Enabled = true;          
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            rodzic = "";
            reset();
            richTextBox.Clear();
            rodzice.Clear();
            tempOsobnik.Clear();
            licznik = 1;
            maxOsobnik = 0;
            maxOsobnikOstatni = 0;
            tablicaWykresu.Clear();
            textBoxA.Enabled = true;
            textBoxB.Enabled = true;
            buttonStart.Enabled = true;
            chartWykres.Series[0].Points.Clear();
        }

        private void buttonDalej_Click(object sender, EventArgs e)
        {
            
            iloscPowtorzen = Convert.ToInt32(numericUpDown_ilsocPowtorzen.Value);
            for (int i = 0; i <= iloscPowtorzen - 1; i++)
            {
                funkcjaWypisania();
                funkcjaPrzystosowania();
                krzyzowanie();
                mutowanie();
                if (ocena >= maxOsobnik)
                {
                    maxOsobnik = ocena;
                    wKroku = licznik;
                }
                licznik++;
                reset();
            }
            richTextBox.AppendText("Najlepsza osobnik funkcji: " + maxOsobnik + " w kroku: " + wKroku + Environment.NewLine);
        }

        private void funkcjaWypisania()
        {
            richTextBox.Invoke(new Action(delegate ()
            {
                richTextBox.AppendText("Krok " + licznik + Environment.NewLine);
            }));
            foreach (string miejsce in rodzice)
            {
                int liczba = doDziesietnej(miejsce);
                ocena = (a * (liczba * liczba)) + (b); 
                if (ocena >= maxOsobnik)
                {
                    maxOsobnik = ocena;
                    wKroku = licznik;
                }
                if (ocena >= maxOsobnikOstatni)
                {
                    maxOsobnikOstatni = ocena;
                }
                richTextBox.Invoke(new Action(delegate ()
                {
                    richTextBox.AppendText(miejsce + " = " + doDziesietnej(miejsce) + ", Funkcja f(x) = " + ocena.ToString() + Environment.NewLine);
                }));
                suma += doDziesietnej(miejsce);
                sumaOceny += ocena;
            }
            richTextBox.Invoke(new Action(delegate ()
            {
                richTextBox.AppendText("Suma = " + suma.ToString() + " Suma funkcji f(x) = " + sumaOceny.ToString() + Environment.NewLine);
                richTextBox.AppendText("Najwyzszy osobnik w iteracjii: " + maxOsobnikOstatni + Environment.NewLine + Environment.NewLine);
                richTextBox.ScrollToCaret();
            }));

            chartWykres.Invoke(new Action(delegate ()
            {
                chartWykres.Series[0].Points.Add(maxOsobnikOstatni);
                chartWykres.ChartAreas[0].AxisX.Minimum = 0;
                chartWykres.ChartAreas[0].CursorX.AutoScroll = true;

                chartWykres.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                chartWykres.ChartAreas[0].AxisX.ScaleView.Zoom(0, 100);

                chartWykres.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            }));
            maxOsobnikOstatni = 0;

        }

        private int doDziesietnej(string str)
        {
            return Convert.ToInt32(str, 2);
        }

        private void funkcjaPrzystosowania()
        {
            int[,] zakres = new int[2, 6];
            int temp=0;
            Random losowanie = new Random();   

            for(int x = 0; x <= 5; x++)
            {
                int y = 1;
                int liczba = doDziesietnej(rodzice[x]);
                temp += ((a * (liczba * liczba)) + (b)  * 100 / sumaOceny);
                zakres[1, x] = temp;
                zakres[0, y] = temp + 1;
                y++;
            }
            zakres[0, 0] = 0;
            zakres[1, 5] = 100;
            for (int x = 0; x <= 5; x++)
            {
                int losowana = losowanie.Next(0, 101);
                if (losowana > zakres[0, 0] && losowana < zakres[1, 0])
                {
                    tempOsobnik.Add(rodzice[0]);
                }
                else if (losowana > zakres[0, 1] && losowana < zakres[1, 1])
                {
                    tempOsobnik.Add(rodzice[1]);
                }
                else if (losowana > zakres[0, 2] && losowana < zakres[1, 2])
                {
                    tempOsobnik.Add(rodzice[2]);
                }
                else if (losowana > zakres[0, 3] && losowana < zakres[1, 3])
                {
                    tempOsobnik.Add(rodzice[3]);
                }
                else if (losowana > zakres[0, 4] && losowana < zakres[1, 4])
                {
                    tempOsobnik.Add(rodzice[4]);
                }
                else if (losowana > zakres[0, 5] && losowana < zakres[1, 5])
                {
                    tempOsobnik.Add(rodzice[5]);
                }
            }
            rodzice = new List<string>();
            rodzice.AddRange(tempOsobnik);
            tempOsobnik = new List<string>();
            
        }

        private void mutowanie()
        {
            Random czyMutuje = new Random();
            tempOsobnik = new List<string>();
            for (int x = 0; x<=5; x++)
            {
                string osobnik = rodzice[x];
                if (czyMutuje.Next(0, 101) <= 20)
                {
                    int bit = czyMutuje.Next(0, 5);
                    StringBuilder poMutacji = new StringBuilder(osobnik);
                    if (osobnik[bit] == '0')
                    {
                        poMutacji[bit] = '1';
                        tempOsobnik.Add(poMutacji.ToString());
                    }
                    else
                    {
                        poMutacji[bit] = '0';
                        tempOsobnik.Add(poMutacji.ToString());
                    }
                }
                else
                {
                    tempOsobnik.Add(osobnik);
                }
            }
            rodzice = new List<string>();
            rodzice.AddRange(tempOsobnik);
            tempOsobnik = new List<string>();
        }

        private void krzyzowanie()
        {
            Random czyKrzyzuje = new Random();
            string osobnikPierwszy , osobinkDrugi;
            for (int xpoz = 0; xpoz<=5; xpoz+=2)
            {
                int y = 1;
                osobnikPierwszy = "";
                osobinkDrugi = "";
                osobnikPierwszy = rodzice[xpoz];
                osobinkDrugi = rodzice[y];
                if (czyKrzyzuje.Next(0, 101) <= 80)
                {
                    StringBuilder tempJeden = new StringBuilder(osobnikPierwszy);
                    StringBuilder tempDwa = new StringBuilder(osobinkDrugi);
                    tempJeden.Insert(2, tempDwa);
                    tempDwa.Insert(2, tempJeden);
                    tempJeden.Remove(0, 2);
                    tempJeden.Remove(4, 3);
                    tempDwa.Remove(0, 2);
                    tempDwa.Remove(4, 8);
                    tempOsobnik.Add(tempJeden.ToString());
                    tempOsobnik.Add(tempDwa.ToString());
                }
                else
                {
                    tempOsobnik.Add(osobnikPierwszy);
                    tempOsobnik.Add(osobinkDrugi);
                }
                y+=2;
                
            }
            rodzice = new List<string>();
            rodzice.AddRange(tempOsobnik);
            tempOsobnik = new List<string>();
        }

        private void reset()
        {
            suma = 0;
            sumaOceny = 0;
        }

        private void glownaPetla()
        {
            for (int i = 0; i <= iloscPowtorzen - 1; i++)
            {
                funkcjaWypisania();
                funkcjaPrzystosowania();
                krzyzowanie();
                mutowanie();
                licznik++;
                reset();
            }
            richTextBox.Invoke(new Action(delegate ()
            {
                richTextBox.AppendText("Najlepszy osobnik funkcji: " + maxOsobnik + " w kroku: " + wKroku + Environment.NewLine);
            }));
        }

    }
}
