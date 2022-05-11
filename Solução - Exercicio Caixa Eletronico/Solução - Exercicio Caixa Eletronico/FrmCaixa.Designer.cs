namespace Solução___Exercicio_Caixa_Eletronico
{
    partial class FrmCaixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorSaqui = new System.Windows.Forms.TextBox();
            this.btSacar = new System.Windows.Forms.Button();
            this.lbNotasNecessarias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do Saque:";
            // 
            // txtValorSaqui
            // 
            this.txtValorSaqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorSaqui.Location = new System.Drawing.Point(308, 82);
            this.txtValorSaqui.Name = "txtValorSaqui";
            this.txtValorSaqui.Size = new System.Drawing.Size(188, 50);
            this.txtValorSaqui.TabIndex = 1;
            // 
            // btSacar
            // 
            this.btSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSacar.Location = new System.Drawing.Point(20, 156);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(476, 73);
            this.btSacar.TabIndex = 2;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // lbNotasNecessarias
            // 
            this.lbNotasNecessarias.AutoSize = true;
            this.lbNotasNecessarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotasNecessarias.Location = new System.Drawing.Point(15, 284);
            this.lbNotasNecessarias.Name = "lbNotasNecessarias";
            this.lbNotasNecessarias.Size = new System.Drawing.Size(58, 44);
            this.lbNotasNecessarias.TabIndex = 3;
            this.lbNotasNecessarias.Text = "---";
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 804);
            this.Controls.Add(this.lbNotasNecessarias);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.txtValorSaqui);
            this.Controls.Add(this.label1);
            this.Name = "FrmCaixa";
            this.Text = "Super Caixa Eletrônico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorSaqui;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.Label lbNotasNecessarias;
    }
}

