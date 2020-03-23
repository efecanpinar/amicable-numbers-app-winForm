/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Ödev 2
**				ÖĞRENCİ ADI............: Muhammed Efecan PINAR
**				ÖĞRENCİ NUMARASI.......: G181210092
**              DERSİN ALINDIĞI GRUP...: 2D
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        // Return friend number
        public IEnumerable<int> calculate(int number)
        {
            List<int> Arr = new List<int>();
            for(int i = 1; i < number; i++)
            {
                if(number%i == 0)
                {
                    Arr.Add(i);
                }
            }

            return Arr;
        }


        private void AddTools(IEnumerable<int> multiOfX, IEnumerable<int> multiOfY)
        {
            // Form
            this.Height = 400;
            this.Width = 800;

            // TextBox
            TextBox txtXTotal = new TextBox();
            txtXTotal.Width = 100;
            txtXTotal.Location = new Point(400, 160);

            TextBox txtYTotal = new TextBox();
            txtYTotal.Width = 100;
            txtYTotal.Location = new Point(600, 160);

            txtXTotal.Text = multiOfX.Sum().ToString();
            txtYTotal.Text = multiOfY.Sum().ToString();

            // Label
            Label labelListX = new Label();
            labelListX.Width = 200;
            labelListX.Text = "X";
            labelListX.Location = new Point(440, 35);

            Label labelListY = new Label();
            labelListY.Text = "Y";
            labelListY.Width = 200;
            labelListY.Location = new Point(640, 35);

            Label labelTotal = new Label();
            labelTotal.Width = 200;
            labelTotal.Text = "Toplam: ";
            labelTotal.Location = new Point(350, 164);

            // ListBox
            ListBox ListBoxX = new ListBox();
            ListBoxX.Width = 100;
            ListBoxX.Height = 100;
            ListBoxX.Location = new Point(400, 60);

            ListBox ListBoxY = new ListBox();
            ListBoxY.Width = 100;
            ListBoxY.Height = 100;
            ListBoxY.Location = new Point(600, 60);

            ListBoxX.DataSource = multiOfX;
            ListBoxY.DataSource = multiOfY;

            // Adding toolbox to the form
            this.Controls.Add(txtXTotal);
            this.Controls.Add(txtYTotal);
            this.Controls.Add(labelListX);
            this.Controls.Add(labelListY);
            this.Controls.Add(ListBoxX);
            this.Controls.Add(ListBoxY);
            this.Controls.Add(labelTotal);

        }
        // Is it friend button
        private void btnFriend_Click(object sender, EventArgs e)
        {
            IEnumerable<int> multiOfX;
            IEnumerable<int> multiOfY;

            try
            {
                multiOfY = calculate(Convert.ToInt32(textBox2.Text));
                multiOfX = calculate(Convert.ToInt32(textBox1.Text));
            }

            catch (Exception ex)
            {
                throw ex;
            }

            AddTools(multiOfX, multiOfY);

            Button btnFriend = (Button)sender;
            btnFriend.Enabled = false;
        }
        // Finish button
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
