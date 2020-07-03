namespace Auto_Atendimento
{
    partial class FrmObrigado
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
            this.lblObrigado = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblObrigado
            // 
            this.lblObrigado.AutoSize = true;
            this.lblObrigado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrigado.Location = new System.Drawing.Point(221, 85);
            this.lblObrigado.Name = "lblObrigado";
            this.lblObrigado.Size = new System.Drawing.Size(272, 55);
            this.lblObrigado.TabIndex = 0;
            this.lblObrigado.Text = "Obrigado!!!";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.Location = new System.Drawing.Point(135, 140);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(446, 25);
            this.lblFim.TabIndex = 1;
            this.lblFim.Text = "Basta aguardar até seu pedido estar pronto...";
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPedido.Location = new System.Drawing.Point(231, 208);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(262, 70);
            this.btnNovoPedido.TabIndex = 2;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // FrmObrigado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.lblObrigado);
            this.Name = "FrmObrigado";
            this.Text = "FrmObrigado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObrigado;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Button btnNovoPedido;
    }
}