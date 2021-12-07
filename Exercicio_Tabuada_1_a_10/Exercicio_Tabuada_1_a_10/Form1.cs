using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Tabuada_1_a_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            notifyIcon1.BalloonTipText = "Em Execução";
            notifyIcon1.ShowBalloonTip(6000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool validar;
            int numValidador = 0;

            validar = int.TryParse(txtNum.Text, out numValidador);

            if (txtNum.Text != "" && validar == true)
            {
                                
                int num1 = int.Parse(txtNum.Text);
                lstResultado.Clear();

                for (int cont = 1; cont <= 10; cont++)
                {
                    string expressao = string.Format("{0} + {1} = {2}", num1, cont, num1 + cont); //Temos de formatar primeiro pq o ListView só aceita 3 args
                                                                                                                                             //e não teríamos como passar esses valores pra lá
                    lstResultado.Items.Add(expressao);

                    txtNum.Clear();
                    txtNum.Focus();
                 }
            }

            else MessageBox.Show("Número inválido, digitar um número válido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
