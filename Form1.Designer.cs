namespace Tarea3_DesarrollosUned
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIngresa = new System.Windows.Forms.Button();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PnlIngreso = new System.Windows.Forms.Panel();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.PnlCualidades = new System.Windows.Forms.Panel();
            this.TxtTercero = new System.Windows.Forms.TextBox();
            this.TxtTiempo = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblTercero = new System.Windows.Forms.Label();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.CmbTrabajos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PnlData = new System.Windows.Forms.Panel();
            this.DgvInformacion = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CmbIdentif = new System.Windows.Forms.ComboBox();
            this.CmbTrab = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PnlIngreso.SuspendLayout();
            this.PnlCualidades.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.PnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformacion)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(-2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1010, 43);
            this.label1.TabIndex = 0;
            // 
            // BtnIngresa
            // 
            this.BtnIngresa.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnIngresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresa.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresa.ForeColor = System.Drawing.Color.White;
            this.BtnIngresa.Location = new System.Drawing.Point(20, 50);
            this.BtnIngresa.Name = "BtnIngresa";
            this.BtnIngresa.Size = new System.Drawing.Size(114, 98);
            this.BtnIngresa.TabIndex = 3;
            this.BtnIngresa.Text = "Ingresar Registro";
            this.BtnIngresa.UseVisualStyleBackColor = false;
            this.BtnIngresa.Click += new System.EventHandler(this.BtnIngresa_Click);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.ForeColor = System.Drawing.Color.White;
            this.BtnConsulta.Location = new System.Drawing.Point(20, 203);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(115, 100);
            this.BtnConsulta.TabIndex = 4;
            this.BtnConsulta.Text = "Consultar Registro";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.BtnIngresa);
            this.panel1.Controls.Add(this.BtnConsulta);
            this.panel1.Location = new System.Drawing.Point(3, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 517);
            this.panel1.TabIndex = 11;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(20, 351);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(115, 100);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(164, 45);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(756, 519);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 12;
            this.TabControl.TabStop = false;
            this.TabControl.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PnlIngreso);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(748, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PnlIngreso
            // 
            this.PnlIngreso.BackColor = System.Drawing.Color.White;
            this.PnlIngreso.Controls.Add(this.BtnBorrar);
            this.PnlIngreso.Controls.Add(this.PnlCualidades);
            this.PnlIngreso.Controls.Add(this.BtnRegistrar);
            this.PnlIngreso.Controls.Add(this.CmbTrabajos);
            this.PnlIngreso.Controls.Add(this.label2);
            this.PnlIngreso.Location = new System.Drawing.Point(-2, 0);
            this.PnlIngreso.Name = "PnlIngreso";
            this.PnlIngreso.Size = new System.Drawing.Size(752, 493);
            this.PnlIngreso.TabIndex = 13;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(417, 435);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(266, 37);
            this.BtnBorrar.TabIndex = 21;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // PnlCualidades
            // 
            this.PnlCualidades.Controls.Add(this.TxtTercero);
            this.PnlCualidades.Controls.Add(this.TxtTiempo);
            this.PnlCualidades.Controls.Add(this.TxtDescripcion);
            this.PnlCualidades.Controls.Add(this.LblTercero);
            this.PnlCualidades.Controls.Add(this.LblTiempo);
            this.PnlCualidades.Controls.Add(this.LblDescripcion);
            this.PnlCualidades.Location = new System.Drawing.Point(33, 81);
            this.PnlCualidades.Name = "PnlCualidades";
            this.PnlCualidades.Size = new System.Drawing.Size(699, 332);
            this.PnlCualidades.TabIndex = 20;
            this.PnlCualidades.Visible = false;
            // 
            // TxtTercero
            // 
            this.TxtTercero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTercero.Location = new System.Drawing.Point(0, 0);
            this.TxtTercero.Multiline = true;
            this.TxtTercero.Name = "TxtTercero";
            this.TxtTercero.Size = new System.Drawing.Size(0, 0);
            this.TxtTercero.TabIndex = 24;
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTiempo.Location = new System.Drawing.Point(524, 160);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.Size = new System.Drawing.Size(166, 35);
            this.TxtTiempo.TabIndex = 23;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(261, 26);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(429, 104);
            this.TxtDescripcion.TabIndex = 22;
            // 
            // LblTercero
            // 
            this.LblTercero.AutoSize = true;
            this.LblTercero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTercero.Location = new System.Drawing.Point(8, 240);
            this.LblTercero.Name = "LblTercero";
            this.LblTercero.Size = new System.Drawing.Size(0, 32);
            this.LblTercero.TabIndex = 21;
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiempo.Location = new System.Drawing.Point(8, 159);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(244, 32);
            this.LblTiempo.TabIndex = 20;
            this.LblTiempo.Text = "Tiempo Estimado:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(8, 42);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(172, 32);
            this.LblDescripcion.TabIndex = 19;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(77, 435);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(269, 37);
            this.BtnRegistrar.TabIndex = 19;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // CmbTrabajos
            // 
            this.CmbTrabajos.BackColor = System.Drawing.Color.LightCyan;
            this.CmbTrabajos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTrabajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbTrabajos.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTrabajos.FormattingEnabled = true;
            this.CmbTrabajos.Items.AddRange(new object[] {
            "Historia",
            "Caja de Tiempo",
            "Bug"});
            this.CmbTrabajos.Location = new System.Drawing.Point(549, 26);
            this.CmbTrabajos.Name = "CmbTrabajos";
            this.CmbTrabajos.Size = new System.Drawing.Size(174, 46);
            this.CmbTrabajos.TabIndex = 12;
            this.CmbTrabajos.SelectedIndexChanged += new System.EventHandler(this.CmbTrabajos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.6F);
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seleccione el tipo de trabajo por ingresar";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PnlData);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(748, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PnlData
            // 
            this.PnlData.BackColor = System.Drawing.Color.White;
            this.PnlData.Controls.Add(this.DgvInformacion);
            this.PnlData.Location = new System.Drawing.Point(2, 135);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(746, 349);
            this.PnlData.TabIndex = 1;
            this.PnlData.Visible = false;
            // 
            // DgvInformacion
            // 
            this.DgvInformacion.BackgroundColor = System.Drawing.Color.White;
            this.DgvInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvInformacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInformacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvInformacion.ColumnHeadersHeight = 40;
            this.DgvInformacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descripcion,
            this.Tiempo,
            this.Puntos,
            this.Tipo});
            this.DgvInformacion.GridColor = System.Drawing.Color.MediumBlue;
            this.DgvInformacion.Location = new System.Drawing.Point(10, 32);
            this.DgvInformacion.Name = "DgvInformacion";
            this.DgvInformacion.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInformacion.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvInformacion.RowTemplate.Height = 24;
            this.DgvInformacion.Size = new System.Drawing.Size(728, 227);
            this.DgvInformacion.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.MinimumWidth = 6;
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Width = 75;
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.MinimumWidth = 6;
            this.Puntos.Name = "Puntos";
            this.Puntos.Width = 200;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.CmbIdentif);
            this.panel3.Controls.Add(this.CmbTrab);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 135);
            this.panel3.TabIndex = 0;
            // 
            // CmbIdentif
            // 
            this.CmbIdentif.BackColor = System.Drawing.Color.LightCyan;
            this.CmbIdentif.DisplayMember = "IdTrabajo";
            this.CmbIdentif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIdentif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbIdentif.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbIdentif.FormattingEnabled = true;
            this.CmbIdentif.Location = new System.Drawing.Point(525, 73);
            this.CmbIdentif.Name = "CmbIdentif";
            this.CmbIdentif.Size = new System.Drawing.Size(174, 46);
            this.CmbIdentif.TabIndex = 19;
            this.CmbIdentif.ValueMember = "IdTrabajo";
            this.CmbIdentif.SelectedIndexChanged += new System.EventHandler(this.CmbIdentif_SelectedIndexChanged);
            // 
            // CmbTrab
            // 
            this.CmbTrab.BackColor = System.Drawing.Color.LightCyan;
            this.CmbTrab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbTrab.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTrab.FormattingEnabled = true;
            this.CmbTrab.Items.AddRange(new object[] {
            "Historia",
            "Caja de Tiempo",
            "Bug"});
            this.CmbTrab.Location = new System.Drawing.Point(525, 16);
            this.CmbTrab.Name = "CmbTrab";
            this.CmbTrab.Size = new System.Drawing.Size(174, 46);
            this.CmbTrab.TabIndex = 18;
            this.CmbTrab.SelectedIndexChanged += new System.EventHandler(this.CmbTrab_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.6F);
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(497, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Seleccione el id del trabajo por revisar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.6F);
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Seleccione el tipo de trabajo por revisar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 555);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "DESARROLLOS UNED";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.PnlIngreso.ResumeLayout(false);
            this.PnlIngreso.PerformLayout();
            this.PnlCualidades.ResumeLayout(false);
            this.PnlCualidades.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.PnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformacion)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIngresa;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel PnlIngreso;
        private System.Windows.Forms.ComboBox CmbTrabajos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlCualidades;
        private System.Windows.Forms.TextBox TxtTercero;
        private System.Windows.Forms.TextBox TxtTiempo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblTercero;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CmbIdentif;
        private System.Windows.Forms.ComboBox CmbTrab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.DataGridView DgvInformacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}

