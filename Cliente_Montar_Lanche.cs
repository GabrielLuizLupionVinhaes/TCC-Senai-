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
    public partial class Cliente_Montar_Lanche : Form
    {
        public Cliente_Montar_Lanche()
        {
            InitializeComponent();
            dgvLanche.Columns.Add("Ingredientes", "Ingredientes");
            dgvLanche.Columns.Add("Preço", "Preço");
            DataGridViewButtonColumn tira = new DataGridViewButtonColumn();
            tira.Name = "Retirar";
            tira.HeaderText = "Retirar";
            tira.Text = "X";
            tira.UseColumnTextForButtonValue = true;
            dgvLanche.Columns.Insert(2, tira);
            txtValor.Enabled = false;
            btnFinalizar.Enabled = false;
        }
        public void Limite()
        {
            if(dgvLanche.Rows.Count >= 12)
            {
                btnHamburguer.Enabled = false;
                btnBacon.Enabled = false;
                btnPresunto.Enabled = false;
                btnQueijo.Enabled = false;
                btnAlface.Enabled = false;
                btnTomate.Enabled = false;
                btnCebola.Enabled = false;
                MessageBox.Show("Seu limite de ingredientes foi alcançado!", "URGENTE", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                btnHamburguer.Enabled = true;
                btnBacon.Enabled = true;
                btnPresunto.Enabled = true;
                btnQueijo.Enabled = true;
                btnAlface.Enabled = true;
                btnTomate.Enabled = true;
                btnCebola.Enabled = true;
            }
        }
        public void Finalizar()
        {
            if (dgvLanche.Rows.Count > 0)
            {
                btnFinalizar.Enabled = true;
            }
            else
            {
                btnFinalizar.Enabled = false;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Cliente_Inicio CI = new Cliente_Inicio();
            CI.Show();

        }

        private void btnHamburguer_Click(object sender, EventArgs e)
        {
            DataGridViewRow hamburger = new DataGridViewRow();
            hamburger.CreateCells(dgvLanche);
            hamburger.Cells[0].Value = "Hamburger";
            hamburger.Cells[1].Value = 3.00;
            dgvLanche.Rows.Add(hamburger);
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvLanche.Rows)
                soma += Convert.ToDecimal(dr.Cells[1].Value);
            txtValor.Text = Convert.ToString(soma);
            Finalizar();
            Limite();
        }

        private void btnBacon_Click(object sender, EventArgs e)
        {
            DataGridViewRow bacon = new DataGridViewRow();
            bacon.CreateCells(dgvLanche);
            bacon.Cells[0].Value = "Bacon";
            bacon.Cells[1].Value = 3.00;
            dgvLanche.Rows.Add(bacon);
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvLanche.Rows)
                soma += Convert.ToDecimal(dr.Cells[1].Value);
            txtValor.Text = Convert.ToString(soma);
            Finalizar();
            Limite();
        }

        private void btnPresunto_Click(object sender, EventArgs e)
        {
            DataGridViewRow presunto = new DataGridViewRow();
            presunto.CreateCells(dgvLanche);
            presunto.Cells[0].Value = "Presunto";
            presunto.Cells[1].Value = 1.50;
            dgvLanche.Rows.Add(presunto);
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvLanche.Rows)
                soma += Convert.ToDecimal(dr.Cells[1].Value);
            txtValor.Text = Convert.ToString(soma);
            Finalizar();
            Limite();
        }

        private void btnQueijo_Click(object sender, EventArgs e)
        {
            DataGridViewRow queijo = new DataGridViewRow();
            queijo.CreateCells(dgvLanche);
            queijo.Cells[0].Value = "Queijo";
            queijo.Cells[1].Value = 1.50;
            dgvLanche.Rows.Add(queijo);
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvLanche.Rows)
                soma += Convert.ToDecimal(dr.Cells[1].Value);
            txtValor.Text = Convert.ToString(soma);
            Finalizar();
            Limite();
        }

        private void btnAlface_Click(object sender, EventArgs e)
        {
            DataGridViewRow alface = new DataGridViewRow();
            alface.CreateCells(dgvLanche);
            alface.Cells[0].Value = "Alface";
            alface.Cells[1].Value = 1.50;
            dgvLanche.Rows.Add(alface);
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvLanche.Rows)
                soma += Convert.ToDecimal(dr.Cells[1].Value);
            txtValor.Text = Convert.ToString(soma);
            Finalizar();
            Limite();
        }

        private void btnTomate_Click(object sender, EventArgs e)
        {
            DataGridViewRow tomate = new DataGridViewRow();
            tomate.CreateCells(dgvLanche);
            tomate.Cells[0].Value = "Tomate";
            tomate.Cells[1].Value = 2.00;
            dgvLanche.Rows.Add(tomate);
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvLanche.Rows)
                soma += Convert.ToDecimal(dr.Cells[1].Value);
            txtValor.Text = Convert.ToString(soma);
            Finalizar();
            Limite();
        }
        
        private void btnCebola_Click(object sender, EventArgs e)
        {
            DataGridViewRow cebola = new DataGridViewRow();
            cebola.CreateCells(dgvLanche);
            cebola.Cells[0].Value = "Cebola";
            cebola.Cells[1].Value = 1.50;
            dgvLanche.Rows.Add(cebola);
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvLanche.Rows)
                soma += Convert.ToDecimal(dr.Cells[1].Value);
            txtValor.Text = Convert.ToString(soma);
            Finalizar();
            Limite();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLanche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var index = e.RowIndex;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                dgvLanche.Rows.RemoveAt(index);
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvLanche.Rows)
                    soma += Convert.ToDecimal(dr.Cells[1].Value);
                txtValor.Text = Convert.ToString(soma);
                Limite();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar pedido", "Confirmação de Lanche", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                string refri = "não";
                string batata = "não";
                if (cbxRefri.Checked == true)
                {
                    refri = "sim";
                }
                if (cbxBatata.Checked == true)
                {
                    batata = "sim";
                }
                string ingredientes = "";
                SqlConnection con = Conexao.OC();
                for (int i = 0; i < dgvLanche.RowCount; i++)
                {
                    ingredientes = dgvLanche.Rows[i].Cells[0].Value.ToString() + "-" + ingredientes;

                }
                foreach (DataGridViewRow dr in dgvLanche.Rows)
                {   
                    SqlCommand cmdtira = new SqlCommand("TiraIngrediente", con);
                    cmdtira.CommandType = CommandType.StoredProcedure;
                    cmdtira.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = dr.Cells[0].Value;
                    string tira = "update ingredientes set quantidade = quantidade-2 where nome = 'pao'";
                    SqlCommand cmdpao = new SqlCommand(tira, con);
                    cmdtira.ExecuteNonQuery();
                    cmdpao.ExecuteNonQuery();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Pedir_Cria_Lanche";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", ingredientes);
                cmd.Parameters.AddWithValue("@preço", txtValor.Text);
                cmd.Parameters.AddWithValue("@batata", batata);
                cmd.Parameters.AddWithValue("@refri", refri);
                cmd.ExecuteNonQuery();
                Conexao.FC();
                this.Close();
                FrmObrigado obri = new FrmObrigado();
                obri.Show();
                


            }













            /*List <object> ingredientes = new List<object>();
            for (Int32 i = 0; i < dgvLanche.Rows.Count; i++)
            {
                ingredientes.Add(Convert.ToString(dgvLanche.Rows[i].Cells[0].Value.ToString()));
            }
            try
            {
                SqlConnection con = Conexao.OC();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Pedir_Lanche_Pronto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", SqlDbType.Text).Value = ingredientes;
                cmd.Parameters.AddWithValue("@preço", txtValor.Text);
                cmd.Parameters.AddWithValue("@batata", batata);
                cmd.Parameters.AddWithValue("@refri", refri);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido realizado com sucesso!", "PEDIDO", MessageBoxButtons.OK);

            }
            catch (Exception)
            {

                MessageBox.Show("DEU RUIM DNV AFFFF!", "PEDIDO", MessageBoxButtons.OK);
            }*/

            /*int linhas = 0;
            List<Ingrediente> ingrediente = new List<Ingrediente>();
            while (linhas < dgvLanche.Rows.Count)
            {
                ingrediente.Add(new Ingrediente() { dgvLanche.Rows[linhas].Cells[0].Value.ToString() });
                linhas++;
            }
            try
            {
                SqlConnection con = Conexao.OC();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Pedir_Lanche_Pronto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", ingrediente);
                cmd.Parameters.AddWithValue("@preço", txtValor.Text);
                cmd.Parameters.AddWithValue("@batata", batata);
                cmd.Parameters.AddWithValue("@refri", refri);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido realizado com sucesso!", "PEDIDO", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Deu ruim dnv", "PEDIDO", MessageBoxButtons.OK);

            }*/


        }
    }
}
