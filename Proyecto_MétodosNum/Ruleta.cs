using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Proyecto_MétodosNum
{
    //Microsoft.Office.Interop.PowerPoint.Application oPPT;
    //Microsoft.Office.Interop.PowerPoint.Presentations objPresSet;
    //Microsoft.Office.Interop.PowerPoint.Presentation objPres;
    //Microsoft.Office.Interop.PowerPoint.SlideShowView oSlideShowView;
    //Timer slidetest;
    public partial class Ruleta : Form
    {
        public string elapsedTime="";

        int tiempo = 0, numero;
        int numAzar = 0, n = 1, x = 1;
        public Ruleta()
        {
            InitializeComponent();
            pictureBox1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\estef\OneDrive\Documentos\Visual Studio 2019\Rulepardy\Recursos\rule.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            timer1.Start();

            //lblTiempo.Text = elapsedTime;
            numero = this.numeroAzar(7);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Solo se gira la ruleta dos intervalos del timer
            //lblTiempo.Text = tiempo.ToString();
            tiempo += 1;
            if (tiempo > 1)
            {
                pictureBox1.Enabled = false;
                timer1.Stop();
                //Manda al menu de las preguntas el numero que fue elegido
                Form menu = new MenuPrincipal(numero);
                Thread.Sleep(800);
                menu.Show();
                this.Hide();
            }
            else
            {
                //Se obtiene el nmero al azar
                mostrarProblema(numero);
            }
        }

        void mostrarProblema(int numero)
        {
            lblNumProblema.Text = "Obtuviste el problema " + numero.ToString();
            //Thread.Sleep(1000);
        }

        int numeroAzar(int divisor)
        {
            //Se usa esa formula para obtener numeros al azar, y se usan los segundos locales(de la compu)
            int segundos = DateTime.Now.Second + 1; //Se le suma 1 para que no ocurra excepcion
            for (int i = 0; i < n; i++)
            {
                numAzar = (segundos * x + segundos) % divisor;
            }
            n++;
            x = numAzar;
            if(numAzar == 0)
            {
                numeroAzar(divisor);
            }
            return numAzar;
            
        }

    }
}
