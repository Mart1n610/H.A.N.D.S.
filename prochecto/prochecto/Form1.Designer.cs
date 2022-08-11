namespace prochecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnImita = new System.Windows.Forms.Button();
			this.btnflechaI = new System.Windows.Forms.PictureBox();
			this.btnflechaD = new System.Windows.Forms.PictureBox();
			this.LabImita = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.btnflechaI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnflechaD)).BeginInit();
			this.SuspendLayout();
			// 
			// btnImita
			// 
			this.btnImita.Location = new System.Drawing.Point(197, 84);
			this.btnImita.Name = "btnImita";
			this.btnImita.Size = new System.Drawing.Size(435, 246);
			this.btnImita.TabIndex = 0;
			this.btnImita.Text = "Imita las formas";
			this.btnImita.UseVisualStyleBackColor = true;
			this.btnImita.Click += new System.EventHandler(this.BtnImita_Click);
			// 
			// btnflechaI
			// 
			this.btnflechaI.Image = global::prochecto.Properties.Resources._580b57fcd9996e24bc43c44e;
			this.btnflechaI.Location = new System.Drawing.Point(58, 162);
			this.btnflechaI.Name = "btnflechaI";
			this.btnflechaI.Size = new System.Drawing.Size(71, 63);
			this.btnflechaI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnflechaI.TabIndex = 2;
			this.btnflechaI.TabStop = false;
			// 
			// btnflechaD
			// 
			this.btnflechaD.Image = global::prochecto.Properties.Resources._580b57fcd9996e24bc43c44e;
			this.btnflechaD.Location = new System.Drawing.Point(702, 162);
			this.btnflechaD.Name = "btnflechaD";
			this.btnflechaD.Size = new System.Drawing.Size(71, 63);
			this.btnflechaD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnflechaD.TabIndex = 3;
			this.btnflechaD.TabStop = false;
			// 
			// LabImita
			// 
			this.LabImita.AutoSize = true;
			this.LabImita.Location = new System.Drawing.Point(370, 29);
			this.LabImita.Name = "LabImita";
			this.LabImita.Size = new System.Drawing.Size(79, 13);
			this.LabImita.TabIndex = 4;
			this.LabImita.Text = "Imita las formas";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 481);
			this.Controls.Add(this.LabImita);
			this.Controls.Add(this.btnflechaD);
			this.Controls.Add(this.btnflechaI);
			this.Controls.Add(this.btnImita);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.btnflechaI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnflechaD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImita;
        private System.Windows.Forms.PictureBox btnflechaI;
		private System.Windows.Forms.PictureBox btnflechaD;
		private System.Windows.Forms.Label LabImita;
	}
}

