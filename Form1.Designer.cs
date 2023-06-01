namespace CalculadoraIMC
{
    partial class FrmPrincipal
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtPESO = new System.Windows.Forms.TextBox();
            this.LblPeso = new System.Windows.Forms.Label();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.LblAltura = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.LblEdad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(327, 294);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(155, 62);
            this.BtnCalcular.TabIndex = 15;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            // 
            // TxtPESO
            // 
            this.TxtPESO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPESO.Location = new System.Drawing.Point(365, 210);
            this.TxtPESO.Name = "TxtPESO";
            this.TxtPESO.Size = new System.Drawing.Size(97, 29);
            this.TxtPESO.TabIndex = 14;
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.Location = new System.Drawing.Point(282, 212);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(57, 24);
            this.LblPeso.TabIndex = 13;
            this.LblPeso.Text = "Peso";
            // 
            // TxtAltura
            // 
            this.TxtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAltura.Location = new System.Drawing.Point(365, 157);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(97, 29);
            this.TxtAltura.TabIndex = 12;
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.Location = new System.Drawing.Point(282, 159);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(64, 24);
            this.LblAltura.TabIndex = 11;
            this.LblAltura.Text = "Altura";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdad.Location = new System.Drawing.Point(365, 103);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(97, 29);
            this.TxtEdad.TabIndex = 10;
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdad.Location = new System.Drawing.Point(282, 105);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(59, 24);
            this.LblEdad.TabIndex = 9;
            this.LblEdad.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ingresar datos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtPESO);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.LblEdad);
            this.Name = "FrmPrincipal";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtPESO;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label label1;
    }
}

