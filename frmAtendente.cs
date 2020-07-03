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
    
    public partial class frmAtendente : Form
    {
        SqlConnection conn = Conexao.OC();
        public void carrega_dgv_atendente()
        {
            String query = "SELECT * FROM pedido";
            SqlCommand cmd = new SqlCommand(query, conn);
            Conexao.OC();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ingrediente = new DataTable();
            da.Fill(ingrediente);
            dgv_atendente.DataSource = ingrediente;
            Conexao.FC();
        }

        public frmAtendente()
        {
            InitializeComponent();
        }

        private void frmAtendente_Load(object sender, EventArgs e)
        {
            carrega_dgv_atendente();
        }

        private void dgv_atendente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_atendente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}