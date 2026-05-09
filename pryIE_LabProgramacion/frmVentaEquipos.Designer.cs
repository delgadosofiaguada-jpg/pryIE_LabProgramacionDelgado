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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
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
            this.lblInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRubros
            // 
            this.cbRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRubros.FormattingEnabled = true;
            this.cbRubros.Location = new System.Drawing.Point(179, 68);
            this.cbRubros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRubros.Name = "cbRubros";
            this.cbRubros.Size = new System.Drawing.Size(177, 26);
            this.cbRubros.TabIndex = 0;
            // 
            // lblRubros
            // 
            this.lblRubros.AutoSize = true;
            this.lblRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubros.Location = new System.Drawing.Point(16, 76);
            this.lblRubros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRubros.Name = "lblRubros";
            this.lblRubros.Size = new System.Drawing.Size(146, 20);
            this.lblRubros.TabIndex = 1;
            this.lblRubros.Text = "Seleccionar rubro:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Consulta de artículos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clColdigo,
            this.clDescripcion,
            this.clCosto,
            this.clStock,
            this.clValorStock});
            this.dgvArticulos.Location = new System.Drawing.Point(16, 178);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(844, 281);
            this.dgvArticulos.TabIndex = 3;
            // 
            // clColdigo
            // 
            this.clColdigo.HeaderText = "Código";
            this.clColdigo.MinimumWidth = 6;
            this.clColdigo.Name = "clColdigo";
            this.clColdigo.Width = 125;
            // 
            // clDescripcion
            // 
            this.clDescripcion.HeaderText = "Descripcion";
            this.clDescripcion.MinimumWidth = 6;
            this.clDescripcion.Name = "clDescripcion";
            this.clDescripcion.Width = 190;
            // 
            // clCosto
            // 
            this.clCosto.HeaderText = "Costo";
            this.clCosto.MinimumWidth = 6;
            this.clCosto.Name = "clCosto";
            this.clCosto.Width = 125;
            // 
            // clStock
            // 
            this.clStock.HeaderText = "Stock";
            this.clStock.MinimumWidth = 6;
            this.clStock.Name = "clStock";
            this.clStock.Width = 125;
            // 
            // clValorStock
            // 
            this.clValorStock.HeaderText = "Valor en Stock";
            this.clValorStock.MinimumWidth = 6;
            this.clValorStock.Name = "clValorStock";
            this.clValorStock.Width = 125;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(243, 129);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(115, 31);
            this.cmdConsultar.TabIndex = 4;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdExportarDatos
            // 
            this.cmdExportarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarDatos.Location = new System.Drawing.Point(715, 603);
            this.cmdExportarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdExportarDatos.Name = "cmdExportarDatos";
            this.cmdExportarDatos.Size = new System.Drawing.Size(143, 33);
            this.cmdExportarDatos.TabIndex = 5;
            this.cmdExportarDatos.Text = "Exportar datos";
            this.cmdExportarDatos.UseVisualStyleBackColor = true;
            this.cmdExportarDatos.Click += new System.EventHandler(this.cmdExportarDatos_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(681, 492);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(176, 27);
            this.lblCantidad.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(681, 540);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(176, 27);
            this.lblTotal.TabIndex = 7;
            // 
            // lblCantlabel
            // 
            this.lblCantlabel.AutoSize = true;
            this.lblCantlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantlabel.Location = new System.Drawing.Point(479, 500);
            this.lblCantlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantlabel.Name = "lblCantlabel";
            this.lblCantlabel.Size = new System.Drawing.Size(172, 20);
            this.lblCantlabel.TabIndex = 8;
            this.lblCantlabel.Text = "Cantidad de articulos:";
            // 
            // lblTotlabel
            // 
            this.lblTotlabel.AutoSize = true;
            this.lblTotlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotlabel.Location = new System.Drawing.Point(479, 548);
            this.lblTotlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotlabel.Name = "lblTotlabel";
            this.lblTotlabel.Size = new System.Drawing.Size(137, 20);
            this.lblTotlabel.TabIndex = 9;
            this.lblTotlabel.Text = "Total valor stock:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.LinkColor = System.Drawing.Color.Purple;
            this.lblInfo.Location = new System.Drawing.Point(16, 674);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(162, 18);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.TabStop = true;
            this.lblInfo.Text = "Datos del desarrollador";
            this.lblInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInfo_LinkClicked);
            // 
            // frmVentaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 709);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTotlabel);
            this.Controls.Add(this.lblCantlabel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmdExportarDatos);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblRubros);
            this.Controls.Add(this.cbRubros);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVentaEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Venta de equipos informáticos";
            this.Load += new System.EventHandler(this.frmVentaEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRubros;
        private System.Windows.Forms.Label lblRubros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
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
        private System.Windows.Forms.LinkLabel lblInfo;
    }
}

