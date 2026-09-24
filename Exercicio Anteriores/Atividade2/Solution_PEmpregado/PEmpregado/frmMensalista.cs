using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEmpregado
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnInstancia1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToInt32(txtSalario.Text);

            MessageBox.Show("Nome=" + objMensalista.NomeEmpregado +
                "\n" + "Matrícula=" + objMensalista.Matricula +
                "\n" + "Tempo trabalho:" + objMensalista.TempoTrabalho() +
                "\n" + "Salário Final=" + objMensalista.SalarioBruto().ToString("N2"));
        }
    }
}
