namespace valor_constante
{
    partial class ValorConstante
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
            this.DGVcalculo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsemilla2 = new System.Windows.Forms.TextBox();
            this.txtsemilla1 = new System.Windows.Forms.TextBox();
            this.btncalculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcalculo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVcalculo
            // 
            this.DGVcalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcalculo.Dock = System.Windows.Forms.DockStyle.Right;
            this.DGVcalculo.Location = new System.Drawing.Point(435, 0);
            this.DGVcalculo.Name = "DGVcalculo";
            this.DGVcalculo.RowHeadersWidth = 62;
            this.DGVcalculo.RowTemplate.Height = 28;
            this.DGVcalculo.Size = new System.Drawing.Size(1009, 771);
            this.DGVcalculo.TabIndex = 1;
            this.DGVcalculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcalculo_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 57);
            this.label3.TabIndex = 7;
            this.label3.Text = "Multiplicador constante";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "cantidad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(107, 220);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(129, 30);
            this.txtcantidad.TabIndex = 14;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Semilla 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Constante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsemilla2
            // 
            this.txtsemilla2.Location = new System.Drawing.Point(28, 98);
            this.txtsemilla2.Multiline = true;
            this.txtsemilla2.Name = "txtsemilla2";
            this.txtsemilla2.Size = new System.Drawing.Size(100, 29);
            this.txtsemilla2.TabIndex = 11;
            this.txtsemilla2.TextChanged += new System.EventHandler(this.txtsemilla2_TextChanged);
            // 
            // txtsemilla1
            // 
            this.txtsemilla1.Location = new System.Drawing.Point(215, 98);
            this.txtsemilla1.Multiline = true;
            this.txtsemilla1.Name = "txtsemilla1";
            this.txtsemilla1.Size = new System.Drawing.Size(112, 26);
            this.txtsemilla1.TabIndex = 10;
            this.txtsemilla1.TextChanged += new System.EventHandler(this.txtsemilla1_TextChanged);
            // 
            // btncalculo
            // 
            this.btncalculo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculo.Location = new System.Drawing.Point(107, 130);
            this.btncalculo.Name = "btncalculo";
            this.btncalculo.Size = new System.Drawing.Size(129, 55);
            this.btncalculo.TabIndex = 9;
            this.btncalculo.Text = "Calcular";
            this.btncalculo.UseVisualStyleBackColor = true;
            this.btncalculo.Click += new System.EventHandler(this.btncalculo_Click);
            // 
            // ValorConstante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 771);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsemilla2);
            this.Controls.Add(this.txtsemilla1);
            this.Controls.Add(this.btncalculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVcalculo);
            this.Name = "ValorConstante";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVcalculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVcalculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsemilla2;
        private System.Windows.Forms.TextBox txtsemilla1;
        private System.Windows.Forms.Button btncalculo;
    }
}

