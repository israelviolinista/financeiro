using CCB_Controle.entidade;
using CCB_Controle.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCB_Controle.view
{
    public partial class frmAno : Form
    {
           Anos obj=new Anos();
        public frmAno()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            txtAno.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtAno.Text == "")
            {
                MessageBox.Show("Insira um Ano!");
                return;
              

            }
            Salvar();
            txtAno.Text = "";
        }

        private void Salvar()
        {
            MessageBox.Show("entrou aqui");
            try
            {
                obj.Ano=Convert.ToInt32(txtAno.Text);
                int x = AnoModel.Inserir(obj);
                MessageBox.Show("   valor de x:" + x);

                if (x >0)
                {
                    MessageBox.Show("Inserido com sucesso,valor de x:"+ x);
                }
                else
                {
                    MessageBox.Show("Inserido com sucesso");


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Não inserido: Error !!! " + ex);
                ;
            }
        }
    }
}
