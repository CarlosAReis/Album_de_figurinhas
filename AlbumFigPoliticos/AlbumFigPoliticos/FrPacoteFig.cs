using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumFigPoliticos
{
    public partial class FrPacoteFig : Form
    {
        public FrPacoteFig()
        {
            InitializeComponent();
            MessageBox.Show("Parabens, você ganhou o pacote de figurinhas do dia!");
        }

        private int Randomico()
        {
            Random gerador = new Random();
            int num;

            num = gerador.Next(1, 6);

            return num;
        }
        private void FrPacoteFig_Load(object sender, EventArgs e)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() ;
            try
            {
                string nome1, nome2, nome3, nome4, pathaux;
                nome1 = "fig" + Randomico();
                Thread.Sleep(10);
                nome2 = "fig" + Randomico();
                Thread.Sleep(10);
                nome3 = "fig" + Randomico();
                Thread.Sleep(10);
                nome4 = "fig" + Randomico();
               
                pathaux = path + nome1 + ".png";
                Image img = Image.FromFile(pathaux);
                picBox1.Image = img;
                pathaux = path + nome2 + ".png";
                img = Image.FromFile(pathaux);
                picBox2.Image = img;
                pathaux = path + nome3 + ".png";
                img = Image.FromFile(pathaux);
                picBox3.Image = img;
                pathaux = path + nome4 + ".png";
                img = Image.FromFile(pathaux);
                picBox4.Image = img;
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
    }
}
