using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFA_Contador
{
    public partial class Form1 : Form
    {
        private Contador contador;

        public Form1()
        {
            InitializeComponent();
            this.contador = new Contador();
            lblContador.Text = this.contador.getNumero().ToString();
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            this.contador.zerar();
            lblContador.Text = this.contador.getNumero().ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.contador.adicionar();
            lblContador.Text = this.contador.getNumero().ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            this.contador.subtrair();
            lblContador.Text = this.contador.getNumero().ToString();
        }
    }
}
