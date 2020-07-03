using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Auto_Atendimento
{
    public partial class Confirma_XE : Form
    {
        public Confirma_XE()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Cliente_Lanche_Pronto CLP = new Cliente_Lanche_Pronto();
            CLP.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string batata;
            string refri;
            if (cbBatata.Checked == true)
            {
                batata = "sim";


            }
            else
            {
                batata = "nao";
                ;
            }
            if (cbRefrigerante.Checked == true)
            {
                refri = "sim";
            }
            else
            {
                refri = "nao";
            }
            try
            {
                SqlConnection con = Conexao.OC();
                string ven = "update ingredientes set quantidade = quantidade-2 where nome = 'pao'" +
                "update ingredientes set quantidade = quantidade-1 where nome = 'hamburger'" +
                "update ingredientes set quantidade = quantidade-1 where nome = 'ovo frito'" +
                "update ingredientes set quantidade = quantidade-1 where nome = 'presunto'" +
                "update ingredientes set quantidade = quantidade-1 where nome = 'queijo'" +
                "update ingredientes set quantidade = quantidade-1 where nome = 'alface'" +
                "update ingredientes set quantidade = quantidade-3 where nome = 'tomate'";
                SqlCommand ingre = new SqlCommand(ven, con);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Pedir_Lanche_Pronto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", "X-Egg");
                cmd.Parameters.AddWithValue("@preço", "12.00");
                cmd.Parameters.AddWithValue("@batata", batata);
                cmd.Parameters.AddWithValue("@refri", refri);
                Conexao.OC();
                ingre.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido realizado com sucesso!", "PEDIDO", MessageBoxButtons.OK);
                this.Close();
                FrmObrigado obri = new FrmObrigado();
                obri.Show();
                Conexao.FC();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
