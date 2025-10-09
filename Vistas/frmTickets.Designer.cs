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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTickets = new System.Windows.Forms.Panel();
            this.btnbuscarresultado = new System.Windows.Forms.Button();
            this.lblFechaRecibido = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.tbcTickets = new System.Windows.Forms.TabControl();
            this.tcpAdministrarTickets = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDetalleTicket = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblDetalleTicket = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.lblFechaEntregadoRegistro = new System.Windows.Forms.Label();
            this.lblFechaRecbidoRegistro = new System.Windows.Forms.Label();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.tcpVerTickets = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.dtpFehcaRecibidoRegistro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntregadoRegistro = new System.Windows.Forms.DateTimePicker();
            this.pnlTickets.SuspendLayout();
            this.tbcTickets.SuspendLayout();
            this.tcpAdministrarTickets.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDetalleTicket.SuspendLayout();
            this.tcpVerTickets.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTickets
            // 
            this.pnlTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTickets.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTickets.Controls.Add(this.btnbuscarresultado);
            this.pnlTickets.Controls.Add(this.lblFechaRecibido);
            this.pnlTickets.Controls.Add(this.lblFechaEntrega);
            this.pnlTickets.Controls.Add(this.lblTickets);
            this.pnlTickets.Controls.Add(this.dtpFechaFin);
            this.pnlTickets.Controls.Add(this.dtpFechaInicio);
            this.pnlTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pnlTickets.Location = new System.Drawing.Point(8, 17);
            this.pnlTickets.Name = "pnlTickets";
            this.pnlTickets.Size = new System.Drawing.Size(776, 82);
            this.pnlTickets.TabIndex = 3;
            // 
            // btnbuscarresultado
            // 
            this.btnbuscarresultado.BackColor = System.Drawing.Color.LightGray;
            this.btnbuscarresultado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarresultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarresultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscarresultado.Location = new System.Drawing.Point(622, 40);
            this.btnbuscarresultado.Name = "btnbuscarresultado";
            this.btnbuscarresultado.Size = new System.Drawing.Size(64, 23);
            this.btnbuscarresultado.TabIndex = 7;
            this.btnbuscarresultado.Text = "Buscar";
            this.btnbuscarresultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarresultado.UseVisualStyleBackColor = false;
            // 
            // lblFechaRecibido
            // 
            this.lblFechaRecibido.AutoSize = true;
            this.lblFechaRecibido.Location = new System.Drawing.Point(210, 49);
            this.lblFechaRecibido.Name = "lblFechaRecibido";
            this.lblFechaRecibido.Size = new System.Drawing.Size(96, 15);
            this.lblFechaRecibido.TabIndex = 4;
            this.lblFechaRecibido.Text = "Fecha Recibido:";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(13, 47);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(90, 15);
            this.lblFechaEntrega.TabIndex = 3;
            this.lblFechaEntrega.Text = "Fecha Entrega:";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(0, 0);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(76, 24);
            this.lblTickets.TabIndex = 2;
            this.lblTickets.Text = "Tickets";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(312, 47);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(104, 21);
            this.dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(100, 47);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(104, 21);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // tbcTickets
            // 
            this.tbcTickets.Controls.Add(this.tcpAdministrarTickets);
            this.tbcTickets.Controls.Add(this.tcpVerTickets);
            this.tbcTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTickets.Location = new System.Drawing.Point(0, 0);
            this.tbcTickets.Name = "tbcTickets";
            this.tbcTickets.SelectedIndex = 0;
            this.tbcTickets.Size = new System.Drawing.Size(800, 450);
            this.tbcTickets.TabIndex = 5;
            // 
            // tcpAdministrarTickets
            // 
            this.tcpAdministrarTickets.Controls.Add(this.panel1);
            this.tcpAdministrarTickets.Location = new System.Drawing.Point(4, 22);
            this.tcpAdministrarTickets.Name = "tcpAdministrarTickets";
            this.tcpAdministrarTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tcpAdministrarTickets.Size = new System.Drawing.Size(792, 424);
            this.tcpAdministrarTickets.TabIndex = 0;
            this.tcpAdministrarTickets.Text = "Administrar tickets";
            this.tcpAdministrarTickets.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pnlDetalleTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 418);
            this.panel1.TabIndex = 0;
            // 
            // pnlDetalleTicket
            // 
            this.pnlDetalleTicket.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlDetalleTicket.Controls.Add(this.dtpFechaEntregadoRegistro);
            this.pnlDetalleTicket.Controls.Add(this.dtpFehcaRecibidoRegistro);
            this.pnlDetalleTicket.Controls.Add(this.btnCliente);
            this.pnlDetalleTicket.Controls.Add(this.txtid);
            this.pnlDetalleTicket.Controls.Add(this.lblDetalleTicket);
            this.pnlDetalleTicket.Controls.Add(this.btnBorrar);
            this.pnlDetalleTicket.Controls.Add(this.btnGuardar);
            this.pnlDetalleTicket.Controls.Add(this.btnLimpiar);
            this.pnlDetalleTicket.Controls.Add(this.txtCliente);
            this.pnlDetalleTicket.Controls.Add(this.txtNroDocumento);
            this.pnlDetalleTicket.Controls.Add(this.lblFechaEntregadoRegistro);
            this.pnlDetalleTicket.Controls.Add(this.lblFechaRecbidoRegistro);
            this.pnlDetalleTicket.Controls.Add(this.lblDescripción);
            this.pnlDetalleTicket.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDetalleTicket.Location = new System.Drawing.Point(0, 0);
            this.pnlDetalleTicket.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDetalleTicket.Name = "pnlDetalleTicket";
            this.pnlDetalleTicket.Size = new System.Drawing.Size(133, 418);
            this.pnlDetalleTicket.TabIndex = 10;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(3, 106);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(122, 23);
            this.btnCliente.TabIndex = 17;
            this.btnCliente.Text = "Buscar cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(76, 31);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(23, 20);
            this.txtid.TabIndex = 16;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // lblDetalleTicket
            // 
            this.lblDetalleTicket.AutoSize = true;
            this.lblDetalleTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTicket.Location = new System.Drawing.Point(3, 10);
            this.lblDetalleTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalleTicket.Name = "lblDetalleTicket";
            this.lblDetalleTicket.Size = new System.Drawing.Size(109, 40);
            this.lblDetalleTicket.TabIndex = 11;
            this.lblDetalleTicket.Text = "Detalles del \r\nCliente";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBorrar.BackColor = System.Drawing.Color.Salmon;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(7, 383);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(119, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(7, 321);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 26);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(6, 351);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 27);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCliente.Location = new System.Drawing.Point(4, 144);
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
            this.txtNroDocumento.Location = new System.Drawing.Point(7, 73);
            this.txtNroDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.ShortcutsEnabled = false;
            this.txtNroDocumento.Size = new System.Drawing.Size(121, 21);
            this.txtNroDocumento.TabIndex = 4;
            // 
            // lblFechaEntregadoRegistro
            // 
            this.lblFechaEntregadoRegistro.AutoSize = true;
            this.lblFechaEntregadoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFechaEntregadoRegistro.Location = new System.Drawing.Point(1, 211);
            this.lblFechaEntregadoRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaEntregadoRegistro.Name = "lblFechaEntregadoRegistro";
            this.lblFechaEntregadoRegistro.Size = new System.Drawing.Size(100, 15);
            this.lblFechaEntregadoRegistro.TabIndex = 3;
            this.lblFechaEntregadoRegistro.Text = "Fecha entregado";
            // 
            // lblFechaRecbidoRegistro
            // 
            this.lblFechaRecbidoRegistro.AutoSize = true;
            this.lblFechaRecbidoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFechaRecbidoRegistro.Location = new System.Drawing.Point(1, 170);
            this.lblFechaRecbidoRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRecbidoRegistro.Name = "lblFechaRecbidoRegistro";
            this.lblFechaRecbidoRegistro.Size = new System.Drawing.Size(88, 15);
            this.lblFechaRecbidoRegistro.TabIndex = 2;
            this.lblFechaRecbidoRegistro.Text = "Fecha recibido";
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDescripción.Location = new System.Drawing.Point(4, 59);
            this.lblDescripción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(72, 15);
            this.lblDescripción.TabIndex = 0;
            this.lblDescripción.Text = "Descripción";
            // 
            // tcpVerTickets
            // 
            this.tcpVerTickets.Controls.Add(this.pnlTickets);
            this.tcpVerTickets.Controls.Add(this.panel2);
            this.tcpVerTickets.Location = new System.Drawing.Point(4, 22);
            this.tcpVerTickets.Name = "tcpVerTickets";
            this.tcpVerTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tcpVerTickets.Size = new System.Drawing.Size(792, 424);
            this.tcpVerTickets.TabIndex = 1;
            this.tcpVerTickets.Text = "Ver tickets";
            this.tcpVerTickets.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.dgvData);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.panel2.Location = new System.Drawing.Point(8, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 311);
            this.panel2.TabIndex = 4;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(776, 311);
            this.dgvData.TabIndex = 20;
            // 
            // dtpFehcaRecibidoRegistro
            // 
            this.dtpFehcaRecibidoRegistro.CustomFormat = "yyyy/MM/dd";
            this.dtpFehcaRecibidoRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFehcaRecibidoRegistro.Location = new System.Drawing.Point(5, 188);
            this.dtpFehcaRecibidoRegistro.Name = "dtpFehcaRecibidoRegistro";
            this.dtpFehcaRecibidoRegistro.Size = new System.Drawing.Size(117, 20);
            this.dtpFehcaRecibidoRegistro.TabIndex = 18;
            // 
            // dtpFechaEntregadoRegistro
            // 
            this.dtpFechaEntregadoRegistro.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaEntregadoRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntregadoRegistro.Location = new System.Drawing.Point(7, 229);
            this.dtpFechaEntregadoRegistro.Name = "dtpFechaEntregadoRegistro";
            this.dtpFechaEntregadoRegistro.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaEntregadoRegistro.TabIndex = 19;
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcTickets);
            this.Name = "frmTickets";
            this.Text = "frmTickets";
            this.pnlTickets.ResumeLayout(false);
            this.pnlTickets.PerformLayout();
            this.tbcTickets.ResumeLayout(false);
            this.tcpAdministrarTickets.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlDetalleTicket.ResumeLayout(false);
            this.pnlDetalleTicket.PerformLayout();
            this.tcpVerTickets.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTickets;
        private System.Windows.Forms.Button btnbuscarresultado;
        private System.Windows.Forms.Label lblFechaRecibido;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TabControl tbcTickets;
        private System.Windows.Forms.TabPage tcpAdministrarTickets;
        private System.Windows.Forms.TabPage tcpVerTickets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel pnlDetalleTicket;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblDetalleTicket;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label lblFechaEntregadoRegistro;
        private System.Windows.Forms.Label lblFechaRecbidoRegistro;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.DateTimePicker dtpFechaEntregadoRegistro;
        private System.Windows.Forms.DateTimePicker dtpFehcaRecibidoRegistro;
    }
}