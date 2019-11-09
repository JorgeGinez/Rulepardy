using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MétodosNum
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(int columna=1)
        {
            InitializeComponent();
            String nomColumna = "col" + columna.ToString();
            switch (nomColumna)
            {
                case "col1":
                    NoL100.Enabled = false;
                    NoL100.BackColor = Color.Gray;
                    NoL300.Enabled = false;
                    NoL300.BackColor = Color.Gray;
                    NoL500.Enabled = false;
                    NoL500.BackColor = Color.Gray;
                    L100.Enabled = false;
                    L100.BackColor = Color.Gray;
                    L300.Enabled = false;
                    L300.BackColor = Color.Gray;
                    L500.Enabled = false;
                    L500.BackColor = Color.Gray;
                    MinC100.Enabled = false;
                    MinC100.BackColor = Color.Gray;
                    MinC300.Enabled = false;
                    MinC300.BackColor = Color.Gray;
                    MinC500.Enabled = false;
                    MinC500.BackColor = Color.Gray;
                    Int100.Enabled = false;
                    Int100.BackColor = Color.Gray;
                    Int300.Enabled = false;
                    Int300.BackColor = Color.Gray;
                    Int500.Enabled = false;
                    Int500.BackColor = Color.Gray;
                    Edo100.Enabled = false;
                    Edo100.BackColor = Color.Gray;
                    Edo300.Enabled = false;
                    Edo300.BackColor = Color.Gray;
                    Edo500.Enabled = false;
                    Edo500.BackColor = Color.Gray;
                    Edo2_100.Enabled = false;
                    Edo2_100.BackColor = Color.Gray;
                    Edo2_300.Enabled = false;
                    Edo2_300.BackColor = Color.Gray;
                    Edo2_500.Enabled = false;
                    Edo2_500.BackColor = Color.Gray;
                    break;
                case "col2":
                    Interp100.Enabled = false;
                    Interp100.BackColor = Color.Gray;
                    Interp300.Enabled = false;
                    Interp300.BackColor = Color.Gray;
                    Interp500.Enabled = false;
                    Interp500.BackColor = Color.Gray;
                    L100.Enabled = false;
                    L100.BackColor = Color.Gray;
                    L300.Enabled = false;
                    L300.BackColor = Color.Gray;
                    L500.Enabled = false;
                    L500.BackColor = Color.Gray;
                    MinC100.Enabled = false;
                    MinC100.BackColor = Color.Gray;
                    MinC300.Enabled = false;
                    MinC300.BackColor = Color.Gray;
                    MinC500.Enabled = false;
                    MinC500.BackColor = Color.Gray;
                    Int100.Enabled = false;
                    Int100.BackColor = Color.Gray;
                    Int300.Enabled = false;
                    Int300.BackColor = Color.Gray;
                    Int500.Enabled = false;
                    Int500.BackColor = Color.Gray;
                    Edo100.Enabled = false;
                    Edo100.BackColor = Color.Gray;
                    Edo300.Enabled = false;
                    Edo300.BackColor = Color.Gray;
                    Edo500.Enabled = false;
                    Edo500.BackColor = Color.Gray;
                    Edo2_100.Enabled = false;
                    Edo2_100.BackColor = Color.Gray;
                    Edo2_300.Enabled = false;
                    Edo2_300.BackColor = Color.Gray;
                    Edo2_500.Enabled = false;
                    Edo2_500.BackColor = Color.Gray;
                    break;
                case "col3":
                    Interp100.Enabled = false;
                    Interp100.BackColor = Color.Gray;
                    Interp300.Enabled = false;
                    Interp300.BackColor = Color.Gray;
                    Interp500.Enabled = false;
                    Interp500.BackColor = Color.Gray;
                    NoL100.Enabled = false;
                    NoL100.BackColor = Color.Gray;
                    NoL300.Enabled = false;
                    NoL300.BackColor = Color.Gray;
                    NoL500.Enabled = false;
                    NoL500.BackColor = Color.Gray;
                    MinC100.Enabled = false;
                    MinC100.BackColor = Color.Gray;
                    MinC300.Enabled = false;
                    MinC300.BackColor = Color.Gray;
                    MinC500.Enabled = false;
                    MinC500.BackColor = Color.Gray;
                    Int100.Enabled = false;
                    Int100.BackColor = Color.Gray;
                    Int300.Enabled = false;
                    Int300.BackColor = Color.Gray;
                    Int500.Enabled = false;
                    Int500.BackColor = Color.Gray;
                    Edo100.Enabled = false;
                    Edo100.BackColor = Color.Gray;
                    Edo300.Enabled = false;
                    Edo300.BackColor = Color.Gray;
                    Edo500.Enabled = false;
                    Edo500.BackColor = Color.Gray;
                    Edo2_100.Enabled = false;
                    Edo2_100.BackColor = Color.Gray;
                    Edo2_300.Enabled = false;
                    Edo2_300.BackColor = Color.Gray;
                    Edo2_500.Enabled = false;
                    Edo2_500.BackColor = Color.Gray;
                    break;
                case "col4":
                    Interp100.Enabled = false;
                    Interp100.BackColor = Color.Gray;
                    Interp300.Enabled = false;
                    Interp300.BackColor = Color.Gray;
                    Interp500.Enabled = false;
                    Interp500.BackColor = Color.Gray;
                    NoL100.Enabled = false;
                    NoL100.BackColor = Color.Gray;
                    NoL300.Enabled = false;
                    NoL300.BackColor = Color.Gray;
                    NoL500.Enabled = false;
                    NoL500.BackColor = Color.Gray;
                    L100.Enabled = false;
                    L100.BackColor = Color.Gray;
                    L300.Enabled = false;
                    L300.BackColor = Color.Gray;
                    L500.Enabled = false;
                    L500.BackColor = Color.Gray;
                    Int100.Enabled = false;
                    Int100.BackColor = Color.Gray;
                    Int300.Enabled = false;
                    Int300.BackColor = Color.Gray;
                    Int500.Enabled = false;
                    Int500.BackColor = Color.Gray;
                    Edo100.Enabled = false;
                    Edo100.BackColor = Color.Gray;
                    Edo300.Enabled = false;
                    Edo300.BackColor = Color.Gray;
                    Edo500.Enabled = false;
                    Edo500.BackColor = Color.Gray;
                    Edo2_100.Enabled = false;
                    Edo2_100.BackColor = Color.Gray;
                    Edo2_300.Enabled = false;
                    Edo2_300.BackColor = Color.Gray;
                    Edo2_500.Enabled = false;
                    Edo2_500.BackColor = Color.Gray;
                    break;
                case "col5":
                    Interp100.Enabled = false;
                    Interp100.BackColor = Color.Gray;
                    Interp300.Enabled = false;
                    Interp300.BackColor = Color.Gray;
                    Interp500.Enabled = false;
                    Interp500.BackColor = Color.Gray;
                    NoL100.Enabled = false;
                    NoL100.BackColor = Color.Gray;
                    NoL300.Enabled = false;
                    NoL300.BackColor = Color.Gray;
                    NoL500.Enabled = false;
                    NoL500.BackColor = Color.Gray;
                    L100.Enabled = false;
                    L100.BackColor = Color.Gray;
                    L300.Enabled = false;
                    L300.BackColor = Color.Gray;
                    L500.Enabled = false;
                    L500.BackColor = Color.Gray;
                    MinC100.Enabled = false;
                    MinC100.BackColor = Color.Gray;
                    MinC300.Enabled = false;
                    MinC300.BackColor = Color.Gray;
                    MinC500.Enabled = false;
                    MinC500.BackColor = Color.Gray;
                    Edo100.Enabled = false;
                    Edo100.BackColor = Color.Gray;
                    Edo300.Enabled = false;
                    Edo300.BackColor = Color.Gray;
                    Edo500.Enabled = false;
                    Edo500.BackColor = Color.Gray;
                    Edo2_100.Enabled = false;
                    Edo2_100.BackColor = Color.Gray;
                    Edo2_300.Enabled = false;
                    Edo2_300.BackColor = Color.Gray;
                    Edo2_500.Enabled = false;
                    Edo2_500.BackColor = Color.Gray;
                    break;
                case "col6":
                    Interp100.Enabled = false;
                    Interp100.BackColor = Color.Gray;
                    Interp300.Enabled = false;
                    Interp300.BackColor = Color.Gray;
                    Interp500.Enabled = false;
                    Interp500.BackColor = Color.Gray;
                    NoL100.Enabled = false;
                    NoL100.BackColor = Color.Gray;
                    NoL300.Enabled = false;
                    NoL300.BackColor = Color.Gray;
                    NoL500.Enabled = false;
                    NoL500.BackColor = Color.Gray;
                    L100.Enabled = false;
                    L100.BackColor = Color.Gray;
                    L300.Enabled = false;
                    L300.BackColor = Color.Gray;
                    L500.Enabled = false;
                    L500.BackColor = Color.Gray;
                    MinC100.Enabled = false;
                    MinC100.BackColor = Color.Gray;
                    MinC300.Enabled = false;
                    MinC300.BackColor = Color.Gray;
                    MinC500.Enabled = false;
                    MinC500.BackColor = Color.Gray;
                    Int100.Enabled = false;
                    Int100.BackColor = Color.Gray;
                    Int300.Enabled = false;
                    Int300.BackColor = Color.Gray;
                    Int500.Enabled = false;
                    Int500.BackColor = Color.Gray;
                    Edo2_100.Enabled = false;
                    Edo2_100.BackColor = Color.Gray;
                    Edo2_300.Enabled = false;
                    Edo2_300.BackColor = Color.Gray;
                    Edo2_500.Enabled = false;
                    Edo2_500.BackColor = Color.Gray;
                    break;
                case "col7":
                    Interp100.Enabled = false;
                    Interp100.BackColor = Color.Gray;
                    Interp300.Enabled = false;
                    Interp300.BackColor = Color.Gray;
                    Interp500.Enabled = false;
                    Interp500.BackColor = Color.Gray;
                    NoL100.Enabled = false;
                    NoL100.BackColor = Color.Gray;
                    NoL300.Enabled = false;
                    NoL300.BackColor = Color.Gray;
                    NoL500.Enabled = false;
                    NoL500.BackColor = Color.Gray;
                    L100.Enabled = false;
                    L100.BackColor = Color.Gray;
                    L300.Enabled = false;
                    L300.BackColor = Color.Gray;
                    L500.Enabled = false;
                    L500.BackColor = Color.Gray;
                    MinC100.Enabled = false;
                    MinC100.BackColor = Color.Gray;
                    MinC300.Enabled = false;
                    MinC300.BackColor = Color.Gray;
                    MinC500.Enabled = false;
                    MinC500.BackColor = Color.Gray;
                    Int100.Enabled = false;
                    Int100.BackColor = Color.Gray;
                    Int300.Enabled = false;
                    Int300.BackColor = Color.Gray;
                    Int500.Enabled = false;
                    Int500.BackColor = Color.Gray;
                    Edo100.Enabled = false;
                    Edo100.BackColor = Color.Gray;
                    Edo300.Enabled = false;
                    Edo300.BackColor = Color.Gray;
                    Edo500.Enabled = false;
                    Edo500.BackColor = Color.Gray;
                    break;
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form interp100 = new Interp100();
            interp100.Show();
            this.Hide();
        }

        private void Button29_Click(object sender, EventArgs e)
        {

        }

        private void Button26_Click(object sender, EventArgs e)
        {

        }

        private void Button39_Click(object sender, EventArgs e)
        {

        }

        private void Button40_Click(object sender, EventArgs e)
        {

        }

        private void Button41_Click(object sender, EventArgs e)
        {

        }

        private void Button42_Click(object sender, EventArgs e)
        {

        }

        private void Button33_Click(object sender, EventArgs e)
        {

        }

        private void Button34_Click(object sender, EventArgs e)
        {

        }

        private void Button35_Click(object sender, EventArgs e)
        {

        }

        private void Button36_Click(object sender, EventArgs e)
        {

        }

        private void Button37_Click(object sender, EventArgs e)
        {

        }

        private void Button32_Click(object sender, EventArgs e)
        {

        }

        private void Button31_Click(object sender, EventArgs e)
        {

        }

        private void Button30_Click(object sender, EventArgs e)
        {

        }

        private void Button28_Click(object sender, EventArgs e)
        {

        }

        private void Button27_Click(object sender, EventArgs e)
        {

        }

        private void Button21_Click(object sender, EventArgs e)
        {

        }

        private void Button22_Click(object sender, EventArgs e)
        {

        }

        private void Button23_Click(object sender, EventArgs e)
        {

        }

        private void Button24_Click(object sender, EventArgs e)
        {

        }

        private void Button20_Click(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {

        }

        private void Button16_Click(object sender, EventArgs e)
        {

        }

        private void Button15_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button38_Click(object sender, EventArgs e)
        {

        }

        private void Button25_Click(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
