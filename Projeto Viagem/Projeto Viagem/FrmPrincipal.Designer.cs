namespace Projeto_Viagem
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.lbCombustivel = new System.Windows.Forms.Label();
            this.lbPedagio = new System.Windows.Forms.Label();
            this.ckGastoPedagio = new System.Windows.Forms.CheckBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.txtPedagio = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lmKM = new System.Windows.Forms.Label();
            this.lbKML = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistancia.Location = new System.Drawing.Point(12, 76);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(324, 37);
            this.lbDistancia.TabIndex = 0;
            this.lbDistancia.Text = "Distância a percorrer:";
            // 
            // lbConsumo
            // 
            this.lbConsumo.AutoSize = true;
            this.lbConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumo.Location = new System.Drawing.Point(12, 177);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(412, 37);
            this.lbConsumo.TabIndex = 1;
            this.lbConsumo.Text = "Consumo médio do veículo:";
            // 
            // lbCombustivel
            // 
            this.lbCombustivel.AutoSize = true;
            this.lbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCombustivel.Location = new System.Drawing.Point(12, 278);
            this.lbCombustivel.Name = "lbCombustivel";
            this.lbCombustivel.Size = new System.Drawing.Size(445, 37);
            this.lbCombustivel.TabIndex = 2;
            this.lbCombustivel.Text = "Valor do combustível:         R$";
            // 
            // lbPedagio
            // 
            this.lbPedagio.AutoSize = true;
            this.lbPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedagio.Location = new System.Drawing.Point(12, 484);
            this.lbPedagio.Name = "lbPedagio";
            this.lbPedagio.Size = new System.Drawing.Size(448, 37);
            this.lbPedagio.TabIndex = 3;
            this.lbPedagio.Text = "Valor gasto com pedágios: R$";
            this.lbPedagio.Visible = false;
            // 
            // ckGastoPedagio
            // 
            this.ckGastoPedagio.AutoSize = true;
            this.ckGastoPedagio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckGastoPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGastoPedagio.Location = new System.Drawing.Point(12, 379);
            this.ckGastoPedagio.Name = "ckGastoPedagio";
            this.ckGastoPedagio.Size = new System.Drawing.Size(437, 41);
            this.ckGastoPedagio.TabIndex = 4;
            this.ckGastoPedagio.Text = "Houve gastos com pedágio";
            this.ckGastoPedagio.UseVisualStyleBackColor = true;
            this.ckGastoPedagio.CheckedChanged += new System.EventHandler(this.ckGastoPedagio_CheckedChanged);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(466, 73);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 44);
            this.txtDistancia.TabIndex = 5;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(466, 174);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 44);
            this.txtConsumo.TabIndex = 6;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustivel.Location = new System.Drawing.Point(466, 275);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(100, 44);
            this.txtCombustivel.TabIndex = 7;
            // 
            // txtPedagio
            // 
            this.txtPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedagio.Location = new System.Drawing.Point(466, 481);
            this.txtPedagio.Name = "txtPedagio";
            this.txtPedagio.Size = new System.Drawing.Size(100, 44);
            this.txtPedagio.TabIndex = 8;
            this.txtPedagio.Visible = false;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(12, 582);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(665, 83);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular Gastos";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lmKM
            // 
            this.lmKM.AutoSize = true;
            this.lmKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmKM.Location = new System.Drawing.Point(572, 80);
            this.lmKM.Name = "lmKM";
            this.lmKM.Size = new System.Drawing.Size(65, 37);
            this.lmKM.TabIndex = 10;
            this.lmKM.Text = "Km";
            // 
            // lbKML
            // 
            this.lbKML.AutoSize = true;
            this.lbKML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKML.Location = new System.Drawing.Point(572, 181);
            this.lbKML.Name = "lbKML";
            this.lbKML.Size = new System.Drawing.Size(92, 37);
            this.lbKML.TabIndex = 11;
            this.lbKML.Text = "Km/L";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(696, 686);
            this.Controls.Add(this.lbKML);
            this.Controls.Add(this.lmKM);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtPedagio);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.ckGastoPedagio);
            this.Controls.Add(this.lbPedagio);
            this.Controls.Add(this.lbCombustivel);
            this.Controls.Add(this.lbConsumo);
            this.Controls.Add(this.lbDistancia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Gasto da Viagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label lbCombustivel;
        private System.Windows.Forms.Label lbPedagio;
        private System.Windows.Forms.CheckBox ckGastoPedagio;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.TextBox txtPedagio;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lmKM;
        private System.Windows.Forms.Label lbKML;
    }
}

