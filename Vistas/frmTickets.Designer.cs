namespace Vistas
{
    partial class frmTickets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDetalleTicket = new System.Windows.Forms.Panel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dtpFechaEntregadoRegistro = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpFehcaRecibidoRegistro = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblFechaEntregadoRegistro = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblFechaRecbidoRegistro = new System.Windows.Forms.Label();
            this.lblDetalleTicket = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlDetalleTicket.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetalleTicket
            // 
            this.pnlDetalleTicket.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlDetalleTicket.Controls.Add(this.cmbCategoria);
            this.pnlDetalleTicket.Controls.Add(this.lblCategoria);
            this.pnlDetalleTicket.Controls.Add(this.dtpFechaEntregadoRegistro);
            this.pnlDetalleTicket.Controls.Add(this.btnLimpiar);
            this.pnlDetalleTicket.Controls.Add(this.dtpFehcaRecibidoRegistro);
            this.pnlDetalleTicket.Controls.Add(this.btnGuardar);
            this.pnlDetalleTicket.Controls.Add(this.txtCliente);
            this.pnlDetalleTicket.Controls.Add(this.txtNroDocumento);
            this.pnlDetalleTicket.Controls.Add(this.btnCliente);
            this.pnlDetalleTicket.Controls.Add(this.btnBorrar);
            this.pnlDetalleTicket.Controls.Add(this.lblDescripción);
            this.pnlDetalleTicket.Controls.Add(this.lblFechaEntregadoRegistro);
            this.pnlDetalleTicket.Controls.Add(this.txtid);
            this.pnlDetalleTicket.Controls.Add(this.lblFechaRecbidoRegistro);
            this.pnlDetalleTicket.Controls.Add(this.lblDetalleTicket);
            this.pnlDetalleTicket.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDetalleTicket.Location = new System.Drawing.Point(0, 0);
            this.pnlDetalleTicket.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDetalleTicket.Name = "pnlDetalleTicket";
            this.pnlDetalleTicket.Size = new System.Drawing.Size(133, 450);
            this.pnlDetalleTicket.TabIndex = 10;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(7, 290);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 21;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 274);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "Categoria";
            // 
            // dtpFechaEntregadoRegistro
            // 
            this.dtpFechaEntregadoRegistro.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaEntregadoRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntregadoRegistro.Location = new System.Drawing.Point(8, 229);
            this.dtpFechaEntregadoRegistro.Name = "dtpFechaEntregadoRegistro";
            this.dtpFechaEntregadoRegistro.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaEntregadoRegistro.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(7, 383);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 27);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtpFehcaRecibidoRegistro
            // 
            this.dtpFehcaRecibidoRegistro.CustomFormat = "yyyy/MM/dd";
            this.dtpFehcaRecibidoRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFehcaRecibidoRegistro.Location = new System.Drawing.Point(6, 188);
            this.dtpFehcaRecibidoRegistro.Name = "dtpFehcaRecibidoRegistro";
            this.dtpFehcaRecibidoRegistro.Size = new System.Drawing.Size(117, 20);
            this.dtpFehcaRecibidoRegistro.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(8, 353);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 26);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCliente.Location = new System.Drawing.Point(5, 144);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.ShortcutsEnabled = false;
            this.txtCliente.Size = new System.Drawing.Size(121, 21);
            this.txtCliente.TabIndex = 5;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNroDocumento.Location = new System.Drawing.Point(8, 73);
            this.txtNroDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.ShortcutsEnabled = false;
            this.txtNroDocumento.Size = new System.Drawing.Size(121, 21);
            this.txtNroDocumento.TabIndex = 4;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(4, 106);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(122, 23);
            this.btnCliente.TabIndex = 17;
            this.btnCliente.Text = "Buscar cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBorrar.BackColor = System.Drawing.Color.Salmon;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(8, 415);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(119, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDescripción.Location = new System.Drawing.Point(5, 59);
            this.lblDescripción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(72, 15);
            this.lblDescripción.TabIndex = 0;
            this.lblDescripción.Text = "Descripción";
            // 
            // lblFechaEntregadoRegistro
            // 
            this.lblFechaEntregadoRegistro.AutoSize = true;
            this.lblFechaEntregadoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFechaEntregadoRegistro.Location = new System.Drawing.Point(2, 211);
            this.lblFechaEntregadoRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaEntregadoRegistro.Name = "lblFechaEntregadoRegistro";
            this.lblFechaEntregadoRegistro.Size = new System.Drawing.Size(100, 15);
            this.lblFechaEntregadoRegistro.TabIndex = 3;
            this.lblFechaEntregadoRegistro.Text = "Fecha entregado";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(77, 31);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(23, 20);
            this.txtid.TabIndex = 16;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // lblFechaRecbidoRegistro
            // 
            this.lblFechaRecbidoRegistro.AutoSize = true;
            this.lblFechaRecbidoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFechaRecbidoRegistro.Location = new System.Drawing.Point(2, 170);
            this.lblFechaRecbidoRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRecbidoRegistro.Name = "lblFechaRecbidoRegistro";
            this.lblFechaRecbidoRegistro.Size = new System.Drawing.Size(88, 15);
            this.lblFechaRecbidoRegistro.TabIndex = 2;
            this.lblFechaRecbidoRegistro.Text = "Fecha recibido";
            // 
            // lblDetalleTicket
            // 
            this.lblDetalleTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTicket.Location = new System.Drawing.Point(4, 10);
            this.lblDetalleTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalleTicket.Name = "lblDetalleTicket";
            this.lblDetalleTicket.Size = new System.Drawing.Size(109, 40);
            this.lblDetalleTicket.TabIndex = 11;
            this.lblDetalleTicket.Text = "Detalles del ticket";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Controls.Add(this.pnlDetalleTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(133, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(667, 450);
            this.dgvData.TabIndex = 11;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick_1);
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmTickets";
            this.Text = "frmTickets";
            this.Load += new System.EventHandler(this.frmTickets_Load);
            this.pnlDetalleTicket.ResumeLayout(false);
            this.pnlDetalleTicket.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetalleTicket;
        private System.Windows.Forms.DateTimePicker dtpFechaEntregadoRegistro;
        private System.Windows.Forms.Label lblDetalleTicket;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFehcaRecibidoRegistro;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Label lblFechaEntregadoRegistro;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblFechaRecbidoRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridView dgvData;
    }
}