namespace CalculadoraIMC
{
    partial class FrmCalculos
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
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblIndicador = new System.Windows.Forms.Label();
            this.LblValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblExcedente = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(354, 218);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(119, 24);
            this.LblEstado.TabIndex = 14;
            this.LblEstado.Text = "Sobre Peso\r\n";
            // 
            // LblIndicador
            // 
            this.LblIndicador.AutoSize = true;
            this.LblIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIndicador.Location = new System.Drawing.Point(246, 99);
            this.LblIndicador.Name = "LblIndicador";
            this.LblIndicador.Size = new System.Drawing.Size(52, 24);
            this.LblIndicador.TabIndex = 12;
            this.LblIndicador.Text = "ICM:";
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(354, 99);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(96, 24);
            this.LblValor.TabIndex = 15;
            this.LblValor.Text = "--- 28.0 --";
            this.LblValor.Click += new System.EventHandler(this.LblValor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Estado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Excedente:";
            // 
            // LblExcedente
            // 
            this.LblExcedente.AutoSize = true;
            this.LblExcedente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExcedente.Location = new System.Drawing.Point(370, 167);
            this.LblExcedente.Name = "LblExcedente";
            this.LblExcedente.Size = new System.Drawing.Size(61, 24);
            this.LblExcedente.TabIndex = 18;
            this.LblExcedente.Text = "+21.9";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(273, 299);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(158, 66);
            this.BtnRegresar.TabIndex = 19;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // FrmCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.LblExcedente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblIndicador);
            this.Name = "FrmCalculos";
            this.Text = "Calculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblIndicador;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblExcedente;
        private System.Windows.Forms.Button BtnRegresar;
    }
}