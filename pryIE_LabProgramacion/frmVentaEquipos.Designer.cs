namespace pryIE_LabProgramacion
{
    partial class frmVentaEquipos
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
            this.cbRubros = new System.Windows.Forms.ComboBox();
            this.lblRubros = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clColdigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdExportarDatos = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantlabel = new System.Windows.Forms.Label();
            this.lblTotlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRubros
            // 
            this.cbRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRubros.FormattingEnabled = true;
            this.cbRubros.Location = new System.Drawing.Point(134, 55);
            this.cbRubros.Name = "cbRubros";
            this.cbRubros.Size = new System.Drawing.Size(134, 23);
            this.cbRubros.TabIndex = 0;
            // 
            // lblRubros
            // 
            this.lblRubros.AutoSize = true;
            this.lblRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubros.Location = new System.Drawing.Point(12, 62);
            this.lblRubros.Name = "lblRubros";
            this.lblRubros.Size = new System.Drawing.Size(116, 16);
            this.lblRubros.TabIndex = 1;
            this.lblRubros.Text = "Seleccionar rubro:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 16);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Consulta de artículos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clColdigo,
            this.clDescripcion,
            this.clCosto,
            this.clStock,
            this.clValorStock});
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 228);
            this.dataGridView1.TabIndex = 3;
            // 
            // clColdigo
            // 
            this.clColdigo.HeaderText = "Código";
            this.clColdigo.Name = "clColdigo";
            // 
            // clDescripcion
            // 
            this.clDescripcion.HeaderText = "Descripcion";
            this.clDescripcion.Name = "clDescripcion";
            this.clDescripcion.Width = 190;
            // 
            // clCosto
            // 
            this.clCosto.HeaderText = "Costo";
            this.clCosto.Name = "clCosto";
            // 
            // clStock
            // 
            this.clStock.HeaderText = "Stock";
            this.clStock.Name = "clStock";
            // 
            // clValorStock
            // 
            this.clValorStock.HeaderText = "Valor en Stock";
            this.clValorStock.Name = "clValorStock";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(182, 99);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(86, 25);
            this.cmdConsultar.TabIndex = 4;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // cmdExportarDatos
            // 
            this.cmdExportarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarDatos.Location = new System.Drawing.Point(524, 502);
            this.cmdExportarDatos.Name = "cmdExportarDatos";
            this.cmdExportarDatos.Size = new System.Drawing.Size(121, 27);
            this.cmdExportarDatos.TabIndex = 5;
            this.cmdExportarDatos.Text = "Exportar datos";
            this.cmdExportarDatos.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(168, 396);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(132, 22);
            this.lblCantidad.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(168, 435);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(132, 22);
            this.lblTotal.TabIndex = 7;
            // 
            // lblCantlabel
            // 
            this.lblCantlabel.AutoSize = true;
            this.lblCantlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantlabel.Location = new System.Drawing.Point(16, 402);
            this.lblCantlabel.Name = "lblCantlabel";
            this.lblCantlabel.Size = new System.Drawing.Size(136, 16);
            this.lblCantlabel.TabIndex = 8;
            this.lblCantlabel.Text = "Cantidad de articulos:";
            // 
            // lblTotlabel
            // 
            this.lblTotlabel.AutoSize = true;
            this.lblTotlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotlabel.Location = new System.Drawing.Point(16, 441);
            this.lblTotlabel.Name = "lblTotlabel";
            this.lblTotlabel.Size = new System.Drawing.Size(109, 16);
            this.lblTotlabel.TabIndex = 9;
            this.lblTotlabel.Text = "Total valor stock:";
            // 
            // frmVentaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 541);
            this.Controls.Add(this.lblTotlabel);
            this.Controls.Add(this.lblCantlabel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmdExportarDatos);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblRubros);
            this.Controls.Add(this.cbRubros);
            this.Name = "frmVentaEquipos";
            this.Text = "Venta de equipos informáticos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRubros;
        private System.Windows.Forms.Label lblRubros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clColdigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorStock;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdExportarDatos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantlabel;
        private System.Windows.Forms.Label lblTotlabel;
    }
}

