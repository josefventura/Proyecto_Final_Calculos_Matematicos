using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TF_POO_Grupo_Discordia_0908
{
    /*Este Programa fue diseñado para realizar varias opreciones matematicas . -Darell Ventura 15-mism-1-069*/
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void BT1_Click(object sender, EventArgs e)
        {

            if (RB1.Checked == true)
            {
                /* Esto es para que cada vez que le den a accionar se multipliquen los dos textbox y tire el resultado en un mensaje. -Andy Familia 15-mism-1-015*/
                int a, b, c;
                a = int.Parse(TxB1.Text);
                b = int.Parse(TxB2.Text);
                c = a * b;
                MessageBox.Show("su resultado es " + Convert.ToString(c));
            }
            if (RB2.Checked == true)
            {
                /*Esto es para que cada vez que le den a accionar saque el factorial de un numero y muestre el resultado. -Eliana Antigua 15-MISM-1-053*/
                int n1, n2, n3;
                n1 = int.Parse(TxB1.Text);
                n2 = n1 - 1;
                n3 = n1;
                while (n2 >= 1)
                {
                    n3 = n3 * n2;
                    n2--;


                }

                MessageBox.Show(Convert.ToString(n3));

            }
            if (RB3.Checked == true)
            {
                int n1, x, r;
                n1 = int.Parse(TxB1.Text);
                LB1.Items.Clear(); /* esto es para que cada vez que le den a accionar se limpie el listbox. -josef ventura 15-mism-1-016*/
                for (x = 1; x < 13; x++)
                {
                    r = x * n1;
                    LB1.Items.Add(Convert.ToString(n1) + " x " + Convert.ToString(x) + " = " + Convert.ToString(r));
                }

            }
         
        }
    }
}
