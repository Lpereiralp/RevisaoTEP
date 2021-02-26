using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoTEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValida_Click(object sender, EventArgs e)
        {
            int senha;
            senha = int.Parse(txtsenha.Text);
            if (senha == 1234)
            {
                MessageBox.Show("Acesso Permitido");
            }
            else
            {
                MessageBox.Show("Acesso Negado");
            }
        }
    }
}
