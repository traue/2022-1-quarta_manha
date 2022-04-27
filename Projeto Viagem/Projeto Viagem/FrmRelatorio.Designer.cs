namespace Projeto_Viagem
{
    partial class FrmRelatorio
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
            this.rtRelatorio = new System.Windows.Forms.RichTextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.btExportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtRelatorio
            // 
            this.rtRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtRelatorio.Location = new System.Drawing.Point(12, 12);
            this.rtRelatorio.Name = "rtRelatorio";
            this.rtRelatorio.Size = new System.Drawing.Size(1064, 646);
            this.rtRelatorio.TabIndex = 0;
            this.rtRelatorio.Text = "";
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(775, 664);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(301, 67);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btExportar
            // 
            this.btExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportar.Location = new System.Drawing.Point(468, 664);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(301, 67);
            this.btExportar.TabIndex = 2;
            this.btExportar.Text = "Exportar para TXT";
            this.btExportar.UseVisualStyleBackColor = false;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 792);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.rtRelatorio);
            this.Name = "FrmRelatorio";
            this.Text = "Relatório da Viagem";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtRelatorio;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExportar;
    }
}