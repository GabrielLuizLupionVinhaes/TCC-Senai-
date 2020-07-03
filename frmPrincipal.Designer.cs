namespace Auto_Atendimento
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_atendente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor_compra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgv_ingrediente = new System.Windows.Forms.DataGridView();
            this.btn_cozinheiro = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atendente
            // 
            this.btn_atendente.Location = new System.Drawing.Point(576, 12);
            this.btn_atendente.Name = "btn_atendente";
            this.btn_atendente.Size = new System.Drawing.Size(75, 23);
            this.btn_atendente.TabIndex = 0;
            this.btn_atendente.Text = "Atendente";
            this.btn_atendente.UseVisualStyleBackColor = true;
            this.btn_atendente.Click += new System.EventHandler(this.btn_atendente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(120, 83);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(171, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(120, 122);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(120, 20);
            this.txt_quantidade.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade";
            // 
            // txt_valor_compra
            // 
            this.txt_valor_compra.Location = new System.Drawing.Point(120, 161);
            this.txt_valor_compra.Name = "txt_valor_compra";
            this.txt_valor_compra.Size = new System.Drawing.Size(120, 20);
            this.txt_valor_compra.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "valor de compra";
            // 
            // btn_localizar
            // 
            this.btn_localizar.Location = new System.Drawing.Point(245, 41);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(75, 23);
            this.btn_localizar.TabIndex = 9;
            this.btn_localizar.Text = "Pesquisar";
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(576, 94);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 10;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(576, 137);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 11;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(576, 177);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 12;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(34, 44);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 13);
            this.lbl_id.TabIndex = 13;
            this.lbl_id.Text = "Id";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(120, 44);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 14;
            // 
            // dgv_ingrediente
            // 
            this.dgv_ingrediente.AllowUserToAddRows = false;
            this.dgv_ingrediente.AllowUserToDeleteRows = false;
            this.dgv_ingrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingrediente.Location = new System.Drawing.Point(22, 208);
            this.dgv_ingrediente.Name = "dgv_ingrediente";
            this.dgv_ingrediente.ReadOnly = true;
            this.dgv_ingrediente.Size = new System.Drawing.Size(465, 195);
            this.dgv_ingrediente.TabIndex = 15;
            this.dgv_ingrediente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ingrediente_CellClick);
            // 
            // btn_cozinheiro
            // 
            this.btn_cozinheiro.Location = new System.Drawing.Point(576, 44);
            this.btn_cozinheiro.Name = "btn_cozinheiro";
            this.btn_cozinheiro.Size = new System.Drawing.Size(75, 23);
            this.btn_cozinheiro.TabIndex = 16;
            this.btn_cozinheiro.Text = "Cozinheiro";
            this.btn_cozinheiro.UseVisualStyleBackColor = true;
            this.btn_cozinheiro.Click += new System.EventHandler(this.btn_cozinheiro_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(402, 24);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(85, 40);
            this.btnCliente.TabIndex = 17;
            this.btnCliente.Text = "Visao do cliente(teste)";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 427);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btn_cozinheiro);
            this.Controls.Add(this.dgv_ingrediente);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_localizar);
            this.Controls.Add(this.txt_valor_compra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_atendente);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingrediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atendente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor_compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dgv_ingrediente;
        private System.Windows.Forms.Button btn_cozinheiro;
        private System.Windows.Forms.Button btnCliente;
    }
}

