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
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.sfdGuarda = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRubros
            // 
            this.cbRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRubros.FormattingEnabled = true;
            this.cbRubros.Location = new System.Drawing.Point(141, 60);
            this.cbRubros.Name = "cbRubros";
            this.cbRubros.Size = new System.Drawing.Size(134, 23);
            this.cbRubros.TabIndex = 0;
            this.cbRubros.SelectedIndexChanged += new System.EventHandler(this.cbRubros_SelectedIndexChanged);
            // 
            // lblRubros
            // 
            this.lblRubros.AutoSize = true;
            this.lblRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubros.Location = new System.Drawing.Point(12, 62);
            this.lblRubros.Name = "lblRubros";
            this.lblRubros.Size = new System.Drawing.Size(124, 17);
            this.lblRubros.TabIndex = 1;
            this.lblRubros.Text = "Seleccionar rubro:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 18);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Consulta de artículos";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clColdigo,
            this.clDescripcion,
            this.clCosto,
            this.clStock,
            this.clValorStock});
            this.dgvArticulos.Location = new System.Drawing.Point(16, 131);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(706, 228);
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
            this.clValorStock.Width = 110;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(188, 98);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(86, 27);
            this.cmdConsultar.TabIndex = 4;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdExportarDatos
            // 
            this.cmdExportarDatos.Enabled = false;
            this.cmdExportarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarDatos.Location = new System.Drawing.Point(603, 486);
            this.cmdExportarDatos.Name = "cmdExportarDatos";
            this.cmdExportarDatos.Size = new System.Drawing.Size(107, 27);
            this.cmdExportarDatos.TabIndex = 5;
            this.cmdExportarDatos.Text = "Exportar datos";
            this.cmdExportarDatos.UseVisualStyleBackColor = true;
            this.cmdExportarDatos.Click += new System.EventHandler(this.cmdExportarDatos_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(584, 386);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(132, 22);
            this.lblCantidad.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(584, 425);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(132, 22);
            this.lblTotal.TabIndex = 7;
            // 
            // lblCantlabel
            // 
            this.lblCantlabel.AutoSize = true;
            this.lblCantlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantlabel.Location = new System.Drawing.Point(432, 392);
            this.lblCantlabel.Name = "lblCantlabel";
            this.lblCantlabel.Size = new System.Drawing.Size(145, 17);
            this.lblCantlabel.TabIndex = 8;
            this.lblCantlabel.Text = "Cantidad de articulos:";
            // 
            // lblTotlabel
            // 
            this.lblTotlabel.AutoSize = true;
            this.lblTotlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotlabel.Location = new System.Drawing.Point(432, 431);
            this.lblTotlabel.Name = "lblTotlabel";
            this.lblTotlabel.Size = new System.Drawing.Size(116, 17);
            this.lblTotlabel.TabIndex = 9;
            this.lblTotlabel.Text = "Total valor stock:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.LinkColor = System.Drawing.Color.MidnightBlue;
            this.lblInfo.Location = new System.Drawing.Point(13, 499);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(135, 15);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.TabStop = true;
            this.lblInfo.Text = "Datos del desarrollador";
            this.lblInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInfo_LinkClicked);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Location = new System.Drawing.Point(500, 486);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(86, 27);
            this.cmdImprimir.TabIndex = 11;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.UseVisualStyleBackColor = true;
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage_1);
            // 
            // frmVentaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(728, 525);
            this.Controls.Add(this.cmdImprimir);
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
            this.Name = "frmVentaEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de articulos en un rubro";
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
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdExportarDatos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantlabel;
        private System.Windows.Forms.Label lblTotlabel;
        private System.Windows.Forms.LinkLabel lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clColdigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorStock;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
        private System.Windows.Forms.SaveFileDialog sfdGuarda;
    }
}

