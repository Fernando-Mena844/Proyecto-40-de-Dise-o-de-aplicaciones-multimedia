namespace Vistas
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.gbModulos = new System.Windows.Forms.GroupBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.gbModulos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbModulos
            // 
            this.gbModulos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbModulos.Controls.Add(this.btnCategoria);
            this.gbModulos.Controls.Add(this.btnClientes);
            this.gbModulos.Controls.Add(this.btnTickets);
            this.gbModulos.Controls.Add(this.btnUsuario);
            this.gbModulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbModulos.Location = new System.Drawing.Point(0, 0);
            this.gbModulos.Name = "gbModulos";
            this.gbModulos.Size = new System.Drawing.Size(144, 561);
            this.gbModulos.TabIndex = 0;
            this.gbModulos.TabStop = false;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.Location = new System.Drawing.Point(3, 178);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(138, 54);
            this.btnCategoria.TabIndex = 3;
            this.btnCategoria.Text = "Categoría";
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.Location = new System.Drawing.Point(3, 124);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(138, 54);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnTickets
            // 
            this.btnTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTickets.Location = new System.Drawing.Point(3, 70);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(138, 54);
            this.btnTickets.TabIndex = 1;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.Location = new System.Drawing.Point(3, 16);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(138, 54);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(144, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(24, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(144, 70);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(810, 491);
            this.pnlContenedor.TabIndex = 5;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbModulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(970, 600);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.gbModulos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbModulos;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}