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

    public partial class frmCozinheiro : Form
    {
        public void carrega_dgv_cozinheiro()
        {
            SqlConnection conn = Conexao.OC();
            String query = "SELECT * FROM pedido";
            SqlCommand cmd = new SqlCommand(query, conn);
            if(conn.State == ConnectionState.Open) { conn.Close(); }
            Conexao.OC();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ingrediente = new DataTable();
            da.Fill(ingrediente);
            dgv_cozinheiro.DataSource = ingrediente;
            Conexao.FC();
        }

        public frmCozinheiro()
        {
            InitializeComponent();
        }
        //Carrega data grid ao iniciar
        private void frmCozinheiro_Load(object sender, EventArgs e)
        {
            carrega_dgv_cozinheiro();
        }

        private void dgv_cozinheiro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Atualiza Status ao clicar
        private void dgv_cozinheiro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = Conexao.OC();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_cozinheiro.Rows[e.RowIndex];
                //Pega o id da celula seleciona
                string id = row.Cells[0].Value.ToString();
                //Pega o nome da celula seleciona
                string nome = row.Cells[1].Value.ToString();
                if (conn.State == ConnectionState.Open) { conn.Close(); }
                Conexao.OC();
                //Muda o status para Pronto
                if (row.Cells[3].Value.ToString() == "Andamento                                    ")
                {
                    DialogResult _ = MessageBox.Show("Lanche: " + nome + "", "Terminar Pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (_ == DialogResult.OK)
                    {
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "Status";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@status", "Pronto");
                        if (conn.State == ConnectionState.Open) { conn.Close(); }
                        Conexao.OC();
                        cmd.ExecuteNonQuery();
                        carrega_dgv_cozinheiro();
                        Conexao.FC();
                    }
                }
                //Muda o status para em Andamento
                else if (row.Cells[3].Value.ToString() == "                                             ")
                {
                    DialogResult _ = MessageBox.Show("Lanche: " + nome + "", "Iniciar Pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (_ == DialogResult.OK)
                    {
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "Status";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@status", "Andamento");
                        if(conn.State == ConnectionState.Open) { conn.Close(); }
                        Conexao.OC();
                        cmd.ExecuteNonQuery();
                        carrega_dgv_cozinheiro();
                        Conexao.FC();
                    }
                }
                //Apenas pare verificar
                else
                {
                    MessageBox.Show("Produto finalizado");
                }
            }
        }

        private void dgv_cozinheiro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
