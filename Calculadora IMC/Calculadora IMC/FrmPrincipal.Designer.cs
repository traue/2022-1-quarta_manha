namespace Calculadora_IMC
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
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbResultadoIMC = new System.Windows.Forms.Label();
            this.lbClassificacao = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso.Location = new System.Drawing.Point(12, 68);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(180, 29);
            this.lbPeso.TabIndex = 0;
            this.lbPeso.Text = "Informe o peso:";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltura.Location = new System.Drawing.Point(12, 116);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(184, 29);
            this.lbAltura.TabIndex = 1;
            this.lbAltura.Text = "Informe a altura:";
            // 
            // lbResultadoIMC
            // 
            this.lbResultadoIMC.AutoSize = true;
            this.lbResultadoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoIMC.Location = new System.Drawing.Point(12, 318);
            this.lbResultadoIMC.Name = "lbResultadoIMC";
            this.lbResultadoIMC.Size = new System.Drawing.Size(61, 29);
            this.lbResultadoIMC.TabIndex = 2;
            this.lbResultadoIMC.Text = "------";
            this.lbResultadoIMC.Visible = false;
            // 
            // lbClassificacao
            // 
            this.lbClassificacao.AutoSize = true;
            this.lbClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassificacao.Location = new System.Drawing.Point(12, 392);
            this.lbClassificacao.Name = "lbClassificacao";
            this.lbClassificacao.Size = new System.Drawing.Size(61, 29);
            this.lbClassificacao.TabIndex = 3;
            this.lbClassificacao.Text = "------";
            this.lbClassificacao.Visible = false;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(202, 65);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(138, 35);
            this.txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(202, 113);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(138, 35);
            this.txtAltura.TabIndex = 5;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(17, 188);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(323, 68);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular o IMC";
            this.btCalcular.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 542);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lbClassificacao);
            this.Controls.Add(this.lbResultadoIMC);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbPeso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbResultadoIMC;
        private System.Windows.Forms.Label lbClassificacao;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btCalcular;
    }
}

