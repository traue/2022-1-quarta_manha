namespace Super_Bloco_Notas
{
    partial class FrmFilha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilha));
            this.rtTextoUsuario = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtTextoUsuario
            // 
            this.rtTextoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtTextoUsuario.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtTextoUsuario.Location = new System.Drawing.Point(0, 0);
            this.rtTextoUsuario.Name = "rtTextoUsuario";
            this.rtTextoUsuario.Size = new System.Drawing.Size(1096, 676);
            this.rtTextoUsuario.TabIndex = 0;
            this.rtTextoUsuario.Text = "";
            // 
            // FrmFilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 676);
            this.Controls.Add(this.rtTextoUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFilha";
            this.Text = "bla";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtTextoUsuario;
    }
}