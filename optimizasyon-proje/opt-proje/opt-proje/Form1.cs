using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opt_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kapasite = Convert.ToInt32(kapasiteTextBox.Text);
            int itemsayi = Convert.ToInt32(item_sayiTextBox.Text);
            char[] ayrac = { ' ', ',', '-', '+', '*' };
            var agirliklar = weightTextBox.Text.Split(ayrac);
            var agirlikList = new List<int>();
            foreach (var i in agirliklar)
            {
                agirlikList.Add(Convert.ToInt32(i));
            }
            int[] agirlikdizi = agirlikList.ToArray();
            if (agirlikdizi.Length != itemsayi)
            {
                MessageBox.Show("Lütfen item sayısı ile eşit sayıda ağırlık giriniz.");
                return;

            }

            var degerler = valueTextBox.Text.Split(ayrac);
            var degerlerList = new List<int>();
            foreach (var i in degerler)
            {
               degerlerList.Add(Convert.ToInt32(i));
            }
            int[] degerdizi = degerlerList.ToArray();
            if (degerdizi.Length != itemsayi)
            {
                MessageBox.Show("Lütfen item sayısı ile eşit sayıda değer giriniz.");
                return;
            }


            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                {
                    if (ctl.Text == String.Empty)
                    {
                        MessageBox.Show(Convert.ToString(((TextBox)ctl).Tag + " boş!"));
                       

                    }
                }
                else
                {
                    KnapSackResult result = KnapSack(kapasite, agirlikdizi, degerdizi, itemsayi);
                    
                    if (agirlikdizi.Length != itemsayi || degerdizi.Length != itemsayi)
                    {
                        labelsonuc.Text = "Lütfen değerleri doğru giriniz.";
                    }
                    else
                    {
                        labelsonuc.Text = Convert.ToString(result.Result);
                        this.dataGridView1.DataSource = degerdizi;

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Ağırlıkları", typeof(int));
                        dt.Columns.Add("Değerleri", typeof(int));

                        for (int i = 0; i < result.WeightList.Count ; i++)
                        {
                            dt.Rows.Add(new object[] { result.WeightList[i], result.ValueList[i] });
                        }
                        dataGridView1.DataSource = dt;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.AllowUserToAddRows = false;

                    }
                }

        }
        public static KnapSackResult KnapSack(int kapasite, int[] agirlikdizi, int[] degerdizi, int itemsayi)
        {
            int[,] K = new int[itemsayi + 1, kapasite + 1];

            for (int i = 0; i <= itemsayi; ++i)
            {
                for (int w = 0; w <= kapasite; ++w)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (agirlikdizi[i - 1] <= w)
                        K[i, w] = Math.Max(degerdizi[i - 1] + K[i - 1, w - agirlikdizi[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }


            int res = K[itemsayi, kapasite];
            int _w, j;
            _w = kapasite;
            var selectedList = new List<int>();
            var valueList = new List<int>();
            for (j = itemsayi; j > 0 && res > 0; j--)
            {

                if (res == K[j - 1, _w])
                    continue;
                else
                {

                    selectedList.Add(agirlikdizi[j - 1]);
                    valueList.Add(degerdizi[j-1]);
                    res = res - degerdizi[j - 1];
                    _w = _w - agirlikdizi[j - 1];
                }
            }

            KnapSackResult knapSackResult = new KnapSackResult()
            {
                Result = K[itemsayi, kapasite],
                WeightList = selectedList,
                ValueList = valueList
            };

            return knapSackResult;

        }

        private void kapasiteTextBox_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(kapasiteTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen sadece tam sayı giriniz.");
                kapasiteTextBox.Text = kapasiteTextBox.Text.Remove(kapasiteTextBox.Text.Length - 1);
            }
           
        }

        private void item_sayiTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(item_sayiTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen sadece tam sayı giriniz.");
                item_sayiTextBox.Text = item_sayiTextBox.Text.Remove(item_sayiTextBox.Text.Length - 1);
            }
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(weightTextBox.Text, "[^-0-9+-,* ]"))
            {
                MessageBox.Show("Lütfen sadece tam  sayı giriniz.");
                weightTextBox.Text = weightTextBox.Text.Remove(weightTextBox.Text.Length - 1);
            }
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(valueTextBox.Text, "[^-0-9+-,* ]"))
            {
                MessageBox.Show("Lütfen sadece tam sayı giriniz.");
                valueTextBox.Text = valueTextBox.Text.Remove(valueTextBox.Text.Length - 1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
