using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7.EquazioniGrado2.Core;

namespace Week7.EquazioniGrado2.Form_master
{
    public partial class Equazione2grado : Form
    {

        private double valueA;
        private double valueB;
        private double valueC;
        private double[] equazione;
        private Equation equation = new Equation();

        public Equazione2grado()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            valueA = double.Parse(textBox_ValueA.Text);
        }

        private void btn_Risoluzione_Click(object sender, EventArgs e)
        {
          //  valueB = (string.IsNullOrEmpty(txtValue.Text)) ? 0 : double.Parse(txtValue.Text);
            txtValue.Text = equation.RisolviEquazioneDiSecondoGrado( valueA,  valueB,  valueC).ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ValueB_TextChanged(object sender, EventArgs e)
        {
            valueB = double.Parse(textBox_ValueB.Text);
        }

        private void textBox_valueC_TextChanged(object sender, EventArgs e)
        {
            valueC = double.Parse(textBox_valueC.Text);
        }
    }
}
