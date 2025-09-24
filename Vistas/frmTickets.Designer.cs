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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTickets));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrarBusqueda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cmbBusca = new System.Windows.Forms.ComboBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.pnlTickets = new System.Windows.Forms.Panel();
            this.btnbuscarresultado = new System.Windows.Forms.Button();
            this.cboTickets = new System.Windows.Forms.ComboBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblFechaRecibido = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.pnlTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.dgvData);
            this.panel2.Controls.Add(this.btnBorrarBusqueda);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtBusca);
            this.panel2.Controls.Add(this.cmbBusca);
            this.panel2.Controls.Add(this.lblBusca);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.panel2.Location = new System.Drawing.Point(22, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 338);
            this.panel2.TabIndex = 4;
            // 
            // btnBorrarBusqueda
            // 
            this.btnBorrarBusqueda.BackColor = System.Drawing.Color.Salmon;
            this.btnBorrarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBorrarBusqueda.Location = new System.Drawing.Point(470, 14);
            this.btnBorrarBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarBusqueda.Name = "btnBorrarBusqueda";
            this.btnBorrarBusqueda.Size = new System.Drawing.Size(77, 25);
            this.btnBorrarBusqueda.TabIndex = 19;
            this.btnBorrarBusqueda.Text = "Borrar";
            this.btnBorrarBusqueda.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(389, 14);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 25);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(247, 16);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.ShortcutsEnabled = false;
            this.txtBusca.Size = new System.Drawing.Size(138, 21);
            this.txtBusca.TabIndex = 17;
            // 
            // cmbBusca
            // 
            this.cmbBusca.FormattingEnabled = true;
            this.cmbBusca.Location = new System.Drawing.Point(73, 16);
            this.cmbBusca.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBusca.Name = "cmbBusca";
            this.cmbBusca.Size = new System.Drawing.Size(170, 23);
            this.cmbBusca.TabIndex = 16;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Location = new System.Drawing.Point(11, 20);
            this.lblBusca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(65, 15);
            this.lblBusca.TabIndex = 15;
            this.lblBusca.Text = "Busca por:";
            // 
            // pnlTickets
            // 
            this.pnlTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTickets.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTickets.Controls.Add(this.btnbuscarresultado);
            this.pnlTickets.Controls.Add(this.cboTickets);
            this.pnlTickets.Controls.Add(this.lblTicket);
            this.pnlTickets.Controls.Add(this.lblFechaRecibido);
            this.pnlTickets.Controls.Add(this.lblFechaEntrega);
            this.pnlTickets.Controls.Add(this.lblTickets);
            this.pnlTickets.Controls.Add(this.dtpFechaFin);
            this.pnlTickets.Controls.Add(this.dtpFechaInicio);
            this.pnlTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pnlTickets.Location = new System.Drawing.Point(22, 12);
            this.pnlTickets.Name = "pnlTickets";
            this.pnlTickets.Size = new System.Drawing.Size(756, 82);
            this.pnlTickets.TabIndex = 3;
            // 
            // btnbuscarresultado
            // 
            this.btnbuscarresultado.BackColor = System.Drawing.Color.LightGray;
            this.btnbuscarresultado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarresultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarresultado.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarresultado.Image")));
            this.btnbuscarresultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscarresultado.Location = new System.Drawing.Point(622, 40);
            this.btnbuscarresultado.Name = "btnbuscarresultado";
            this.btnbuscarresultado.Size = new System.Drawing.Size(64, 23);
            this.btnbuscarresultado.TabIndex = 7;
            this.btnbuscarresultado.Text = "Buscar";
            this.btnbuscarresultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarresultado.UseVisualStyleBackColor = false;
            // 
            // cboTickets
            // 
            this.cboTickets.BackColor = System.Drawing.SystemColors.Window;
            this.cboTickets.FormattingEnabled = true;
            this.cboTickets.Location = new System.Drawing.Point(486, 41);
            this.cboTickets.Name = "cboTickets";
            this.cboTickets.Size = new System.Drawing.Size(121, 23);
            this.cboTickets.TabIndex = 6;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(438, 48);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(42, 15);
            this.lblTicket.TabIndex = 5;
            this.lblTicket.Text = "Ticket:";
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
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(100, 47);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(104, 21);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTicket,
            this.descripcionTicket,
            this.FechaEntrega,
            this.FechaRecibido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Location = new System.Drawing.Point(0, 53);
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
            this.dgvData.Size = new System.Drawing.Size(754, 283);
            this.dgvData.TabIndex = 20;
            // 
            // idTicket
            // 
            this.idTicket.HeaderText = "idTicket";
            this.idTicket.Name = "idTicket";
            this.idTicket.ReadOnly = true;
            this.idTicket.Visible = false;
            // 
            // descripcionTicket
            // 
            this.descripcionTicket.HeaderText = "Ticket";
            this.descripcionTicket.Name = "descripcionTicket";
            this.descripcionTicket.ReadOnly = true;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "Fecha Entrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.ReadOnly = true;
            // 
            // FechaRecibido
            // 
            this.FechaRecibido.HeaderText = "Fecha Recibido";
            this.FechaRecibido.Name = "FechaRecibido";
            this.FechaRecibido.ReadOnly = true;
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTickets);
            this.Name = "frmTickets";
            this.Text = "frmTickets";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTickets.ResumeLayout(false);
            this.pnlTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBorrarBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cmbBusca;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.Panel pnlTickets;
        private System.Windows.Forms.Button btnbuscarresultado;
        private System.Windows.Forms.ComboBox cboTickets;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblFechaRecibido;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRecibido;
    }
}