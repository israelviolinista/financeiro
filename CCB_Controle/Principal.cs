using CCB_Controle.view;

namespace CCB_Controle
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void anoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAno frm = new frmAno();
            frm.ShowDialog();

        }

        private void lançamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLanc frmL=new frmLanc();
            frmL.ShowDialog();
        }
    }
}