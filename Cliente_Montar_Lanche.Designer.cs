namespace Auto_Atendimento
{
    partial class Cliente_Montar_Lanche
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLanche = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHamburguer = new System.Windows.Forms.Label();
            this.btnHamburguer = new System.Windows.Forms.Button();
            this.btnBacon = new System.Windows.Forms.Button();
            this.btnPresunto = new System.Windows.Forms.Button();
            this.btnQueijo = new System.Windows.Forms.Button();
            this.btnAlface = new System.Windows.Forms.Button();
            this.btnTomate = new System.Windows.Forms.Button();
            this.btnCebola = new System.Windows.Forms.Button();
            this.cbxRefri = new System.Windows.Forms.CheckBox();
            this.cbxBatata = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanche)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Menu;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(570, 42);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(88, 31);
            this.txtValor.TabIndex = 36;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(716, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Valor do Lanche   R$";
            // 
            // dgvLanche
            // 
            this.dgvLanche.AllowUserToAddRows = false;
            this.dgvLanche.AllowUserToDeleteRows = false;
            this.dgvLanche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvLanche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanche.Location = new System.Drawing.Point(433, 120);
            this.dgvLanche.Name = "dgvLanche";
            this.dgvLanche.ReadOnly = true;
            this.dgvLanche.Size = new System.Drawing.Size(343, 299);
            this.dgvLanche.TabIndex = 33;
            this.dgvLanche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLanche_CellContentClick);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(42, 346);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(204, 73);
            this.btnFinalizar.TabIndex = 51;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Cebola";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tomate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "alface";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Queijo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Presunto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Bacon";
            // 
            // lblHamburguer
            // 
            this.lblHamburguer.AutoSize = true;
            this.lblHamburguer.Location = new System.Drawing.Point(44, 27);
            this.lblHamburguer.Name = "lblHamburguer";
            this.lblHamburguer.Size = new System.Drawing.Size(59, 13);
            this.lblHamburguer.TabIndex = 44;
            this.lblHamburguer.Text = "Hamburger";
            // 
            // btnHamburguer
            // 
            this.btnHamburguer.Location = new System.Drawing.Point(42, 43);
            this.btnHamburguer.Name = "btnHamburguer";
            this.btnHamburguer.Size = new System.Drawing.Size(65, 23);
            this.btnHamburguer.TabIndex = 52;
            this.btnHamburguer.UseVisualStyleBackColor = true;
            this.btnHamburguer.Click += new System.EventHandler(this.btnHamburguer_Click);
            // 
            // btnBacon
            // 
            this.btnBacon.Location = new System.Drawing.Point(42, 84);
            this.btnBacon.Name = "btnBacon";
            this.btnBacon.Size = new System.Drawing.Size(65, 23);
            this.btnBacon.TabIndex = 53;
            this.btnBacon.UseVisualStyleBackColor = true;
            this.btnBacon.Click += new System.EventHandler(this.btnBacon_Click);
            // 
            // btnPresunto
            // 
            this.btnPresunto.Location = new System.Drawing.Point(42, 125);
            this.btnPresunto.Name = "btnPresunto";
            this.btnPresunto.Size = new System.Drawing.Size(65, 23);
            this.btnPresunto.TabIndex = 54;
            this.btnPresunto.UseVisualStyleBackColor = true;
            this.btnPresunto.Click += new System.EventHandler(this.btnPresunto_Click);
            // 
            // btnQueijo
            // 
            this.btnQueijo.Location = new System.Drawing.Point(42, 166);
            this.btnQueijo.Name = "btnQueijo";
            this.btnQueijo.Size = new System.Drawing.Size(65, 23);
            this.btnQueijo.TabIndex = 55;
            this.btnQueijo.UseVisualStyleBackColor = true;
            this.btnQueijo.Click += new System.EventHandler(this.btnQueijo_Click);
            // 
            // btnAlface
            // 
            this.btnAlface.Location = new System.Drawing.Point(42, 207);
            this.btnAlface.Name = "btnAlface";
            this.btnAlface.Size = new System.Drawing.Size(65, 23);
            this.btnAlface.TabIndex = 56;
            this.btnAlface.UseVisualStyleBackColor = true;
            this.btnAlface.Click += new System.EventHandler(this.btnAlface_Click);
            // 
            // btnTomate
            // 
            this.btnTomate.Location = new System.Drawing.Point(42, 248);
            this.btnTomate.Name = "btnTomate";
            this.btnTomate.Size = new System.Drawing.Size(65, 23);
            this.btnTomate.TabIndex = 57;
            this.btnTomate.UseVisualStyleBackColor = true;
            this.btnTomate.Click += new System.EventHandler(this.btnTomate_Click);
            // 
            // btnCebola
            // 
            this.btnCebola.Location = new System.Drawing.Point(42, 289);
            this.btnCebola.Name = "btnCebola";
            this.btnCebola.Size = new System.Drawing.Size(65, 23);
            this.btnCebola.TabIndex = 58;
            this.btnCebola.UseVisualStyleBackColor = true;
            this.btnCebola.Click += new System.EventHandler(this.btnCebola_Click);
            // 
            // cbxRefri
            // 
            this.cbxRefri.AutoSize = true;
            this.cbxRefri.Location = new System.Drawing.Point(336, 125);
            this.cbxRefri.Name = "cbxRefri";
            this.cbxRefri.Size = new System.Drawing.Size(84, 17);
            this.cbxRefri.TabIndex = 59;
            this.cbxRefri.Text = "Refrigerante";
            this.cbxRefri.UseVisualStyleBackColor = true;
            // 
            // cbxBatata
            // 
            this.cbxBatata.AutoSize = true;
            this.cbxBatata.Location = new System.Drawing.Point(336, 191);
            this.cbxBatata.Name = "cbxBatata";
            this.cbxBatata.Size = new System.Drawing.Size(80, 17);
            this.cbxBatata.TabIndex = 60;
            this.cbxBatata.Text = "Batata Frita";
            this.cbxBatata.UseVisualStyleBackColor = true;
            // 
            // Cliente_Montar_Lanche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxBatata);
            this.Controls.Add(this.cbxRefri);
            this.Controls.Add(this.btnCebola);
            this.Controls.Add(this.btnTomate);
            this.Controls.Add(this.btnAlface);
            this.Controls.Add(this.btnQueijo);
            this.Controls.Add(this.btnPresunto);
            this.Controls.Add(this.btnBacon);
            this.Controls.Add(this.btnHamburguer);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHamburguer);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLanche);
            this.Name = "Cliente_Montar_Lanche";
            this.Text = "Cliente_Montar_Lanche_V2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLanche;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHamburguer;
        private System.Windows.Forms.Button btnHamburguer;
        private System.Windows.Forms.Button btnBacon;
        private System.Windows.Forms.Button btnPresunto;
        private System.Windows.Forms.Button btnQueijo;
        private System.Windows.Forms.Button btnAlface;
        private System.Windows.Forms.Button btnTomate;
        private System.Windows.Forms.Button btnCebola;
        private System.Windows.Forms.CheckBox cbxRefri;
        private System.Windows.Forms.CheckBox cbxBatata;
    }
}