namespace Bhaskara
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
            this.lbx2 = new System.Windows.Forms.Label();
            this.lbx = new System.Windows.Forms.Label();
            this.lbzero = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbDelta = new System.Windows.Forms.Label();
            this.lbXP = new System.Windows.Forms.Label();
            this.lbXN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx2
            // 
            this.lbx2.AutoSize = true;
            this.lbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx2.Location = new System.Drawing.Point(110, 133);
            this.lbx2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(75, 37);
            this.lbx2.TabIndex = 0;
            this.lbx2.Text = "X² +";
            // 
            // lbx
            // 
            this.lbx.AutoSize = true;
            this.lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx.Location = new System.Drawing.Point(291, 133);
            this.lbx.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(66, 37);
            this.lbx.TabIndex = 1;
            this.lbx.Text = "X +";
            // 
            // lbzero
            // 
            this.lbzero.AutoSize = true;
            this.lbzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbzero.Location = new System.Drawing.Point(463, 133);
            this.lbzero.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbzero.Name = "lbzero";
            this.lbzero.Size = new System.Drawing.Size(63, 37);
            this.lbzero.TabIndex = 2;
            this.lbzero.Text = "= 0";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(14, 127);
            this.txtA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(86, 47);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(195, 127);
            this.txtB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(86, 47);
            this.txtB.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(367, 127);
            this.txtC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(86, 47);
            this.txtC.TabIndex = 5;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(12, 40);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(891, 37);
            this.lbInfo.TabIndex = 6;
            this.lbInfo.Text = "Informe uma equação quadrádica no formato ax² + bx + c = 0";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(196)))), ((int)(((byte)(253)))));
            this.btCalcular.Location = new System.Drawing.Point(14, 208);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(512, 65);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbDelta
            // 
            this.lbDelta.AutoSize = true;
            this.lbDelta.Location = new System.Drawing.Point(12, 320);
            this.lbDelta.Name = "lbDelta";
            this.lbDelta.Size = new System.Drawing.Size(121, 37);
            this.lbDelta.TabIndex = 8;
            this.lbDelta.Text = "DELTA";
            this.lbDelta.Visible = false;
            // 
            // lbXP
            // 
            this.lbXP.AutoSize = true;
            this.lbXP.Location = new System.Drawing.Point(12, 394);
            this.lbXP.Name = "lbXP";
            this.lbXP.Size = new System.Drawing.Size(45, 37);
            this.lbXP.TabIndex = 9;
            this.lbXP.Text = "X\'";
            this.lbXP.Visible = false;
            // 
            // lbXN
            // 
            this.lbXN.AutoSize = true;
            this.lbXN.Location = new System.Drawing.Point(8, 468);
            this.lbXN.Name = "lbXN";
            this.lbXN.Size = new System.Drawing.Size(49, 37);
            this.lbXN.TabIndex = 10;
            this.lbXN.Text = "X\"";
            this.lbXN.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(899, 561);
            this.Controls.Add(this.lbXN);
            this.Controls.Add(this.lbXP);
            this.Controls.Add(this.lbDelta);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbzero);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.lbx2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Bhaskara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbx2;
        private System.Windows.Forms.Label lbx;
        private System.Windows.Forms.Label lbzero;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbDelta;
        private System.Windows.Forms.Label lbXP;
        private System.Windows.Forms.Label lbXN;
    }
}

