namespace Burbuja
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btmOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un #";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(110, 52);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(188, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // btmAgregar
            // 
            this.btmAgregar.Location = new System.Drawing.Point(340, 52);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(116, 26);
            this.btmAgregar.TabIndex = 2;
            this.btmAgregar.Text = "Agregar";
            this.btmAgregar.UseVisualStyleBackColor = true;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregar_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(124, 139);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(174, 251);
            this.lbLista.TabIndex = 3;
            // 
            // btmOrdenar
            // 
            this.btmOrdenar.Location = new System.Drawing.Point(340, 109);
            this.btmOrdenar.Name = "btmOrdenar";
            this.btmOrdenar.Size = new System.Drawing.Size(116, 23);
            this.btmOrdenar.TabIndex = 4;
            this.btmOrdenar.Text = "Ordenar";
            this.btmOrdenar.UseVisualStyleBackColor = true;
            this.btmOrdenar.Click += new System.EventHandler(this.btmOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmOrdenar);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btmOrdenar;
    }
}

