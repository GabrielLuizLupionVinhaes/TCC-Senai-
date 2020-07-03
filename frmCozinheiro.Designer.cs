namespace Auto_Atendimento
{
    partial class frmCozinheiro
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
            this.dgv_cozinheiro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cozinheiro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cozinheiro
            // 
            this.dgv_cozinheiro.AllowUserToAddRows = false;
            this.dgv_cozinheiro.AllowUserToDeleteRows = false;
            this.dgv_cozinheiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cozinheiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cozinheiro.Location = new System.Drawing.Point(0, 0);
            this.dgv_cozinheiro.Name = "dgv_cozinheiro";
            this.dgv_cozinheiro.ReadOnly = true;
            this.dgv_cozinheiro.Size = new System.Drawing.Size(800, 450);
            this.dgv_cozinheiro.TabIndex = 0;
            this.dgv_cozinheiro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cozinheiro_CellClick);
            this.dgv_cozinheiro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cozinheiro_CellContentClick);
            this.dgv_cozinheiro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cozinheiro_CellDoubleClick);
            // 
            // frmCozinheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_cozinheiro);
            this.Name = "frmCozinheiro";
            this.Text = "frmCozinheiro";
            this.Load += new System.EventHandler(this.frmCozinheiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cozinheiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cozinheiro;
    }
}