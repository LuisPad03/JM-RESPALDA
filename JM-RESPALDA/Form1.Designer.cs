
namespace JM_RESPALDA
{
    partial class JM_RESPALDA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JM_RESPALDA));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_martes = new System.Windows.Forms.CheckBox();
            this.chb_lunes = new System.Windows.Forms.CheckBox();
            this.chb_miercoles = new System.Windows.Forms.CheckBox();
            this.chb_domingo = new System.Windows.Forms.CheckBox();
            this.chb_jueves = new System.Windows.Forms.CheckBox();
            this.chb_sabado = new System.Windows.Forms.CheckBox();
            this.chb_viernes = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbx_dia = new System.Windows.Forms.ComboBox();
            this.cbx_periodicidad = new System.Windows.Forms.ComboBox();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_num_dia = new System.Windows.Forms.Label();
            this.lbl_periodicidad = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.txt_origen = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_detener = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BarraTitulo.Controls.Add(this.lbl_nombre);
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Controls.Add(this.pictureBox1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(686, 42);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nombre.Location = new System.Drawing.Point(51, 5);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(137, 36);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "JM-RESPALDA";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = global::JM_RESPALDA.Properties.Resources.restaurar;
            this.iconrestaurar.Location = new System.Drawing.Point(650, 6);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(26, 26);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 1;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JM_RESPALDA.Properties.Resources.disco_duro;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.cbx_dia);
            this.panel3.Controls.Add(this.cbx_periodicidad);
            this.panel3.Controls.Add(this.lbl_hora);
            this.panel3.Controls.Add(this.lbl_num_dia);
            this.panel3.Controls.Add(this.lbl_periodicidad);
            this.panel3.Controls.Add(this.lbl_destino);
            this.panel3.Controls.Add(this.txt_destino);
            this.panel3.Controls.Add(this.txt_origen);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.lbl_origen);
            this.panel3.Controls.Add(this.lbl_name);
            this.panel3.Controls.Add(this.btn_detener);
            this.panel3.Controls.Add(this.btn_iniciar);
            this.panel3.Controls.Add(this.btn_guardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(315, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 295);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_martes);
            this.groupBox1.Controls.Add(this.chb_lunes);
            this.groupBox1.Controls.Add(this.chb_miercoles);
            this.groupBox1.Controls.Add(this.chb_domingo);
            this.groupBox1.Controls.Add(this.chb_jueves);
            this.groupBox1.Controls.Add(this.chb_sabado);
            this.groupBox1.Controls.Add(this.chb_viernes);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(18, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Día(s)";
            // 
            // chb_martes
            // 
            this.chb_martes.AutoSize = true;
            this.chb_martes.Location = new System.Drawing.Point(86, 23);
            this.chb_martes.Name = "chb_martes";
            this.chb_martes.Size = new System.Drawing.Size(70, 32);
            this.chb_martes.TabIndex = 2;
            this.chb_martes.Text = "Martes";
            this.chb_martes.UseVisualStyleBackColor = true;
            this.chb_martes.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // chb_lunes
            // 
            this.chb_lunes.AutoSize = true;
            this.chb_lunes.Location = new System.Drawing.Point(17, 23);
            this.chb_lunes.Name = "chb_lunes";
            this.chb_lunes.Size = new System.Drawing.Size(66, 32);
            this.chb_lunes.TabIndex = 1;
            this.chb_lunes.Text = "Lunes";
            this.chb_lunes.UseVisualStyleBackColor = true;
            this.chb_lunes.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // chb_miercoles
            // 
            this.chb_miercoles.AutoSize = true;
            this.chb_miercoles.Location = new System.Drawing.Point(162, 23);
            this.chb_miercoles.Name = "chb_miercoles";
            this.chb_miercoles.Size = new System.Drawing.Size(87, 32);
            this.chb_miercoles.TabIndex = 3;
            this.chb_miercoles.Text = "Miercoles";
            this.chb_miercoles.UseVisualStyleBackColor = true;
            this.chb_miercoles.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // chb_domingo
            // 
            this.chb_domingo.AutoSize = true;
            this.chb_domingo.Location = new System.Drawing.Point(197, 63);
            this.chb_domingo.Name = "chb_domingo";
            this.chb_domingo.Size = new System.Drawing.Size(87, 32);
            this.chb_domingo.TabIndex = 7;
            this.chb_domingo.Text = "Domingo";
            this.chb_domingo.UseVisualStyleBackColor = true;
            this.chb_domingo.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // chb_jueves
            // 
            this.chb_jueves.AutoSize = true;
            this.chb_jueves.Location = new System.Drawing.Point(252, 23);
            this.chb_jueves.Name = "chb_jueves";
            this.chb_jueves.Size = new System.Drawing.Size(68, 32);
            this.chb_jueves.TabIndex = 4;
            this.chb_jueves.Text = "Jueves";
            this.chb_jueves.UseVisualStyleBackColor = true;
            this.chb_jueves.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // chb_sabado
            // 
            this.chb_sabado.AutoSize = true;
            this.chb_sabado.Location = new System.Drawing.Point(119, 63);
            this.chb_sabado.Name = "chb_sabado";
            this.chb_sabado.Size = new System.Drawing.Size(72, 32);
            this.chb_sabado.TabIndex = 6;
            this.chb_sabado.Text = "Sabado";
            this.chb_sabado.UseVisualStyleBackColor = true;
            this.chb_sabado.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // chb_viernes
            // 
            this.chb_viernes.AutoSize = true;
            this.chb_viernes.Location = new System.Drawing.Point(39, 63);
            this.chb_viernes.Name = "chb_viernes";
            this.chb_viernes.Size = new System.Drawing.Size(75, 32);
            this.chb_viernes.TabIndex = 5;
            this.chb_viernes.Text = "Viernes";
            this.chb_viernes.UseVisualStyleBackColor = true;
            this.chb_viernes.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 229);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
            // 
            // cbx_dia
            // 
            this.cbx_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_dia.Font = new System.Drawing.Font("Microsoft Himalaya", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_dia.FormattingEnabled = true;
            this.cbx_dia.IntegralHeight = false;
            this.cbx_dia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbx_dia.Location = new System.Drawing.Point(304, 95);
            this.cbx_dia.Name = "cbx_dia";
            this.cbx_dia.Size = new System.Drawing.Size(43, 28);
            this.cbx_dia.TabIndex = 5;
            this.cbx_dia.Visible = false;
            // 
            // cbx_periodicidad
            // 
            this.cbx_periodicidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_periodicidad.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_periodicidad.FormattingEnabled = true;
            this.cbx_periodicidad.IntegralHeight = false;
            this.cbx_periodicidad.ItemHeight = 21;
            this.cbx_periodicidad.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Mensual",
            "Unica vez",
            "Personalizado"});
            this.cbx_periodicidad.Location = new System.Drawing.Point(110, 94);
            this.cbx_periodicidad.Name = "cbx_periodicidad";
            this.cbx_periodicidad.Size = new System.Drawing.Size(101, 29);
            this.cbx_periodicidad.TabIndex = 4;
            this.cbx_periodicidad.SelectionChangeCommitted += new System.EventHandler(this.cbx_periodicidad_SelectionChangeCommitted);
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hora.Location = new System.Drawing.Point(18, 226);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(46, 28);
            this.lbl_hora.TabIndex = 7;
            this.lbl_hora.Text = "Hora:";
            // 
            // lbl_num_dia
            // 
            this.lbl_num_dia.AutoSize = true;
            this.lbl_num_dia.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_num_dia.Location = new System.Drawing.Point(217, 95);
            this.lbl_num_dia.Name = "lbl_num_dia";
            this.lbl_num_dia.Size = new System.Drawing.Size(84, 28);
            this.lbl_num_dia.TabIndex = 6;
            this.lbl_num_dia.Text = "Día del mes:";
            this.lbl_num_dia.Visible = false;
            // 
            // lbl_periodicidad
            // 
            this.lbl_periodicidad.AutoSize = true;
            this.lbl_periodicidad.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_periodicidad.Location = new System.Drawing.Point(18, 95);
            this.lbl_periodicidad.Name = "lbl_periodicidad";
            this.lbl_periodicidad.Size = new System.Drawing.Size(90, 28);
            this.lbl_periodicidad.TabIndex = 5;
            this.lbl_periodicidad.Text = "Periodicidad:";
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_destino.Location = new System.Drawing.Point(18, 61);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(61, 28);
            this.lbl_destino.TabIndex = 4;
            this.lbl_destino.Text = "Destino:";
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(85, 66);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(262, 20);
            this.txt_destino.TabIndex = 3;
            this.txt_destino.Click += new System.EventHandler(this.txt_destino_Click);
            // 
            // txt_origen
            // 
            this.txt_origen.Location = new System.Drawing.Point(85, 41);
            this.txt_origen.Name = "txt_origen";
            this.txt_origen.Size = new System.Drawing.Size(262, 20);
            this.txt_origen.TabIndex = 2;
            this.txt_origen.Click += new System.EventHandler(this.txt_origen_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(85, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(262, 20);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_origen.Location = new System.Drawing.Point(18, 36);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(58, 28);
            this.lbl_origen.TabIndex = 2;
            this.lbl_origen.Text = "Origen:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(18, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(64, 28);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Nombre:";
            // 
            // btn_detener
            // 
            this.btn_detener.Enabled = false;
            this.btn_detener.FlatAppearance.BorderSize = 0;
            this.btn_detener.Font = new System.Drawing.Font("Microsoft Himalaya", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_detener.Location = new System.Drawing.Point(270, 262);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(75, 23);
            this.btn_detener.TabIndex = 9;
            this.btn_detener.Text = "Detener";
            this.btn_detener.UseVisualStyleBackColor = false;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciar.Enabled = false;
            this.btn_iniciar.FlatAppearance.BorderSize = 0;
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Himalaya", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_iniciar.Location = new System.Drawing.Point(189, 262);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 8;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Himalaya", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_guardar.Location = new System.Drawing.Point(108, 262);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 295);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(8, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(292, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "JM-Respalda";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // JM_RESPALDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BarraTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JM_RESPALDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JM-RESPALDA";
            this.Load += new System.EventHandler(this.JM_RESPALDA_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_num_dia;
        private System.Windows.Forms.Label lbl_periodicidad;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.CheckBox chb_domingo;
        private System.Windows.Forms.CheckBox chb_sabado;
        private System.Windows.Forms.CheckBox chb_viernes;
        private System.Windows.Forms.CheckBox chb_jueves;
        private System.Windows.Forms.CheckBox chb_miercoles;
        private System.Windows.Forms.CheckBox chb_martes;
        private System.Windows.Forms.CheckBox chb_lunes;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.TextBox txt_origen;
        private System.Windows.Forms.ComboBox cbx_dia;
        private System.Windows.Forms.ComboBox cbx_periodicidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

