using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFA_SomaPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Soma s;
            s = new Soma();
            s.setNum1(int.Parse(txtN1.Text));
            s.setNum2(int.Parse(txtN2.Text));
            s.calcular();
            lblResultado.Text = s.getResultado().ToString();
            radPar.Checked = s.resultadoPar();
            radImpar.Checked = !s.resultadoPar();
            chkPar.Checked = s.resultadoPar();
            radMaior0.Checked = !s.resultadoNegativo();
            radMenor0.Checked = s.resultadoNegativo();
            chkNegativo.Checked = s.resultadoNegativo();
        }
    }
}
