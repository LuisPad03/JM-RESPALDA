
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JM_RESPALDA));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbx_dia = new System.Windows.Forms.ComboBox();
            this.cbx_periodicidad = new System.Windows.Forms.ComboBox();
            this.chb_domingo = new System.Windows.Forms.CheckBox();
            this.chb_sabado = new System.Windows.Forms.CheckBox();
            this.chb_viernes = new System.Windows.Forms.CheckBox();
            this.chb_jueves = new System.Windows.Forms.CheckBox();
            this.chb_miercoles = new System.Windows.Forms.CheckBox();
            this.chb_martes = new System.Windows.Forms.CheckBox();
            this.chb_lunes = new System.Windows.Forms.CheckBox();
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
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.cbx_dia);
            this.panel3.Controls.Add(this.cbx_periodicidad);
            this.panel3.Controls.Add(this.chb_domingo);
            this.panel3.Controls.Add(this.chb_sabado);
            this.panel3.Controls.Add(this.chb_viernes);
            this.panel3.Controls.Add(this.chb_jueves);
            this.panel3.Controls.Add(this.chb_miercoles);
            this.panel3.Controls.Add(this.chb_martes);
            this.panel3.Controls.Add(this.chb_lunes);
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
            this.panel3.Location = new System.Drawing.Point(378, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 317);
            this.panel3.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 229);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2022, 8, 21, 0, 0, 0, 0);
            // 
            // cbx_dia
            // 
            this.cbx_dia.FormattingEnabled = true;
            this.cbx_dia.Location = new System.Drawing.Point(59, 200);
            this.cbx_dia.Name = "cbx_dia";
            this.cbx_dia.Size = new System.Drawing.Size(95, 21);
            this.cbx_dia.TabIndex = 10;
            // 
            // cbx_periodicidad
            // 
            this.cbx_periodicidad.FormattingEnabled = true;
            this.cbx_periodicidad.Location = new System.Drawing.Point(85, 92);
            this.cbx_periodicidad.Name = "cbx_periodicidad";
            this.cbx_periodicidad.Size = new System.Drawing.Size(101, 21);
            this.cbx_periodicidad.TabIndex = 10;
            // 
            // chb_domingo
            // 
            this.chb_domingo.AutoSize = true;
            this.chb_domingo.Location = new System.Drawing.Point(192, 166);
            this.chb_domingo.Name = "chb_domingo";
            this.chb_domingo.Size = new System.Drawing.Size(68, 17);
            this.chb_domingo.TabIndex = 9;
            this.chb_domingo.Text = "Domingo";
            this.chb_domingo.UseVisualStyleBackColor = true;
            // 
            // chb_sabado
            // 
            this.chb_sabado.AutoSize = true;
            this.chb_sabado.Location = new System.Drawing.Point(123, 166);
            this.chb_sabado.Name = "chb_sabado";
            this.chb_sabado.Size = new System.Drawing.Size(63, 17);
            this.chb_sabado.TabIndex = 9;
            this.chb_sabado.Text = "Sabado";
            this.chb_sabado.UseVisualStyleBackColor = true;
            // 
            // chb_viernes
            // 
            this.chb_viernes.AutoSize = true;
            this.chb_viernes.Location = new System.Drawing.Point(56, 166);
            this.chb_viernes.Name = "chb_viernes";
            this.chb_viernes.Size = new System.Drawing.Size(61, 17);
            this.chb_viernes.TabIndex = 9;
            this.chb_viernes.Text = "Viernes";
            this.chb_viernes.UseVisualStyleBackColor = true;
            // 
            // chb_jueves
            // 
            this.chb_jueves.AutoSize = true;
            this.chb_jueves.Location = new System.Drawing.Point(226, 137);
            this.chb_jueves.Name = "chb_jueves";
            this.chb_jueves.Size = new System.Drawing.Size(60, 17);
            this.chb_jueves.TabIndex = 9;
            this.chb_jueves.Text = "Jueves";
            this.chb_jueves.UseVisualStyleBackColor = true;
            // 
            // chb_miercoles
            // 
            this.chb_miercoles.AutoSize = true;
            this.chb_miercoles.Location = new System.Drawing.Point(149, 137);
            this.chb_miercoles.Name = "chb_miercoles";
            this.chb_miercoles.Size = new System.Drawing.Size(71, 17);
            this.chb_miercoles.TabIndex = 9;
            this.chb_miercoles.Text = "Miercoles";
            this.chb_miercoles.UseVisualStyleBackColor = true;
            // 
            // chb_martes
            // 
            this.chb_martes.AutoSize = true;
            this.chb_martes.Location = new System.Drawing.Point(85, 137);
            this.chb_martes.Name = "chb_martes";
            this.chb_martes.Size = new System.Drawing.Size(58, 17);
            this.chb_martes.TabIndex = 9;
            this.chb_martes.Text = "Martes";
            this.chb_martes.UseVisualStyleBackColor = true;
            // 
            // chb_lunes
            // 
            this.chb_lunes.AutoSize = true;
            this.chb_lunes.Location = new System.Drawing.Point(24, 137);
            this.chb_lunes.Name = "chb_lunes";
            this.chb_lunes.Size = new System.Drawing.Size(55, 17);
            this.chb_lunes.TabIndex = 9;
            this.chb_lunes.Text = "Lunes";
            this.chb_lunes.UseVisualStyleBackColor = true;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(18, 235);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(33, 13);
            this.lbl_hora.TabIndex = 7;
            this.lbl_hora.Text = "Hora:";
            // 
            // lbl_num_dia
            // 
            this.lbl_num_dia.AutoSize = true;
            this.lbl_num_dia.Location = new System.Drawing.Point(18, 203);
            this.lbl_num_dia.Name = "lbl_num_dia";
            this.lbl_num_dia.Size = new System.Drawing.Size(28, 13);
            this.lbl_num_dia.TabIndex = 6;
            this.lbl_num_dia.Text = "Día:";
            // 
            // lbl_periodicidad
            // 
            this.lbl_periodicidad.AutoSize = true;
            this.lbl_periodicidad.Location = new System.Drawing.Point(18, 95);
            this.lbl_periodicidad.Name = "lbl_periodicidad";
            this.lbl_periodicidad.Size = new System.Drawing.Size(68, 13);
            this.lbl_periodicidad.TabIndex = 5;
            this.lbl_periodicidad.Text = "Periodicidad:";
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Location = new System.Drawing.Point(18, 69);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(46, 13);
            this.lbl_destino.TabIndex = 4;
            this.lbl_destino.Text = "Destino:";
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(85, 66);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(199, 20);
            this.txt_destino.TabIndex = 3;
            // 
            // txt_origen
            // 
            this.txt_origen.Location = new System.Drawing.Point(85, 41);
            this.txt_origen.Name = "txt_origen";
            this.txt_origen.Size = new System.Drawing.Size(199, 20);
            this.txt_origen.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.Location = new System.Drawing.Point(85, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(199, 20);
            this.txt_name.TabIndex = 3;
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Location = new System.Drawing.Point(18, 44);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(41, 13);
            this.lbl_origen.TabIndex = 2;
            this.lbl_origen.Text = "Origen:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(18, 16);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Nombre:";
            // 
            // btn_detener
            // 
            this.btn_detener.Enabled = false;
            this.btn_detener.FlatAppearance.BorderSize = 0;
            this.btn_detener.Location = new System.Drawing.Point(209, 277);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(75, 23);
            this.btn_detener.TabIndex = 0;
            this.btn_detener.Text = "Detener";
            this.btn_detener.UseVisualStyleBackColor = true;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_iniciar.Enabled = false;
            this.btn_iniciar.FlatAppearance.BorderSize = 0;
            this.btn_iniciar.Location = new System.Drawing.Point(128, 277);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.Location = new System.Drawing.Point(47, 277);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 317);
            this.panel1.TabIndex = 3;
            // 
            // JM_RESPALDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 359);
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
    }
}

