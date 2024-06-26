﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;
using Timer = System.Timers.Timer;
using System.Net;
using System.IO;
using System.Xml;
using Microsoft.Win32;

namespace JM_RESPALDA
{
    public partial class JM_RESPALDA : Form
    {
        private FolderBrowserDialog buscaCarpeta = new FolderBrowserDialog();
        private DataSet dsJMRespalda = new DataSet();
        private DataTable dtBackUp = new DataTable();
        private readonly string xmlRespaldos = "JM-Respalda.xml";
        private readonly string[] sColumnas = { "Nombre", "Origen", "Destino", "Periodicidad", "DiaMes", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo", "Hora" };

        string archivoip = Application.StartupPath + "\\GuardaIP.txt";
        string archivoxml2 = Application.StartupPath + "\\MDatos.xml";
        string subkey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        //Equipo\HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run

        public JM_RESPALDA()
        {
            InitializeComponent();
        }

        private void JM_RESPALDA_Load(object sender, EventArgs e)
        {
            CreaEstructuraDs();

            bool fileExist = File.Exists(xmlRespaldos);
            if (!fileExist) dsJMRespalda.WriteXml(xmlRespaldos);

            dsJMRespalda.ReadXml(xmlRespaldos, XmlReadMode.ReadSchema);

            dataGridView1.DataSource = dsJMRespalda;
            dataGridView1.DataMember = "BackUp";

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Uighur", 18F, FontStyle.Regular);

            cbx_hora.SelectedIndex = 0;
            cbx_minuto.SelectedIndex = 0;
        }
        private void CreaEstructuraDs()
        {
            dsJMRespalda.DataSetName = "JM-RESPALDA";
            dtBackUp.TableName = "BackUp";
            dsJMRespalda.Tables.Add(dtBackUp);
            dtBackUp.Columns.Add("ID", typeof(int));
            dtBackUp.Columns.Add("Nombre", typeof(string));
            dtBackUp.Columns.Add("Origen", typeof(string));
            dtBackUp.Columns.Add("Destino", typeof(string));
            dtBackUp.Columns.Add("Periodicidad", typeof(string));
            dtBackUp.Columns.Add("DiaMes", typeof(int));
            dtBackUp.Columns.Add("Lunes", typeof(bool));
            dtBackUp.Columns.Add("Martes", typeof(bool));
            dtBackUp.Columns.Add("Miercoles", typeof(bool));
            dtBackUp.Columns.Add("Jueves", typeof(bool));
            dtBackUp.Columns.Add("Viernes", typeof(bool));
            dtBackUp.Columns.Add("Sabado", typeof(bool));
            dtBackUp.Columns.Add("Domingo", typeof(bool));
            dtBackUp.Columns.Add("Hora", typeof(string));
        }

        #region Movimiento a la barra det titulo

        // Codigo para dar movimiento en la pantalla

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Codigo para dar movimiento en la pantalla


        // evento MouseDown de la herramienta(s) que tendra movimiento
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        // evento MouseDown de la herramienta(s) que tendra movimiento


        #endregion

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    //Asinga el estado de la ventana como minimizado
            this.Hide();
            notifyIcon1.BalloonTipText = "Trabajando en segundo plano";
            notifyIcon1.ShowBalloonTip(3000);
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void txt_origen_Click(object sender, EventArgs e)
        {            
            if (buscaCarpeta.ShowDialog() == DialogResult.OK) txt_origen.Text = buscaCarpeta.SelectedPath;
        }

        private void txt_destino_Click(object sender, EventArgs e)
        {
            if (buscaCarpeta.ShowDialog() == DialogResult.OK) txt_destino.Text = buscaCarpeta.SelectedPath;
        }

        private void cbx_periodicidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cbx_periodicidad.Text)
            {
                case "Diario":
                    groupBox_Dias(false, true, false, true);
                    btn_iniciar.Visible = false;
                    break;
                case "Semanal":
                    groupBox_Dias(true, false, false, true);
                    chb_lunes.Checked = true;
                    btn_iniciar.Visible = false;
                    break;
                case "Mensual":
                    groupBox_Dias(false, false, true, true);
                    btn_iniciar.Visible = false;
                    break;
                case "Unica vez":
                    groupBox_Dias(false, false, false, false);
                    groupBox1.Enabled = false;
                    btn_iniciar.Visible = true;
                    break;
                case "Personalizado":
                    groupBox_Dias(true, false, false, true);
                    btn_iniciar.Visible = false;
                    break;
                default:
                    groupBox_Dias(true, false, false, false);
                    btn_iniciar.Visible = false;
                    break;
            }
        }
        private void groupBox_Dias(bool habilitar, bool check, bool cbxDia, bool btnGuardar)
        {
            chb_lunes.Checked = check;
            chb_lunes.Enabled = habilitar;
            chb_martes.Checked = check;
            chb_martes.Enabled = habilitar;
            chb_miercoles.Checked = check;
            chb_miercoles.Enabled = habilitar;
            chb_jueves.Checked = check;
            chb_jueves.Enabled = habilitar;
            chb_viernes.Checked = check;
            chb_viernes.Enabled = habilitar;
            chb_sabado.Checked = check;
            chb_sabado.Enabled = habilitar;
            chb_domingo.Checked = check;
            chb_domingo.Enabled = habilitar;

            lbl_num_dia.Visible = cbxDia;
            cbx_dia.Visible = cbxDia;
            cbx_dia.Text = null;

            groupBox1.Enabled = !cbxDia;

            btn_guardar.Enabled = btnGuardar;
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            if (cbx_periodicidad.Text == "Semanal") selecciona_Dia(checkbox.Text);
        }
        private void selecciona_Dia(string habilita)
        {
            chb_lunes.Checked = chb_lunes.Text.Contains(habilita) ? true : false;
            chb_martes.Checked = chb_martes.Text.Contains(habilita) ? true : false;
            chb_miercoles.Checked = chb_miercoles.Text.Contains(habilita) ? true : false;
            chb_jueves.Checked = chb_jueves.Text.Contains(habilita) ? true : false;
            chb_viernes.Checked = chb_viernes.Text.Contains(habilita) ? true : false;
            chb_sabado.Checked = chb_sabado.Text.Contains(habilita) ? true : false;
            chb_domingo.Checked = chb_domingo.Text.Contains(habilita) ? true : false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string[] datosFila = new string[14];
                for(int i=0; i < 14; i++)
                {
                    datosFila[i] = dataGridView1.SelectedRows[0].Cells[i].Value + string.Empty;
                }

                lbl_id.Text = datosFila[0];
                txt_name.Text = datosFila[1];
                txt_origen.Text = datosFila[2];
                txt_destino.Text = datosFila[3];
                cbx_periodicidad.Text = datosFila[4];
                switch (datosFila[4])
                {
                    case "Diario":
                        groupBox_Dias(false, true, false, true);
                        break;
                    case "Semanal":
                        groupBox_Dias(true, false, false, true);
                        break;
                    case "Mensual":
                        groupBox_Dias(false, false, true, true);
                        break;
                    case "Unica vez":
                        groupBox_Dias(false, false, false, false);
                        groupBox1.Enabled = false;
                        break;
                    case "Personalizado":
                        groupBox_Dias(true, false, false, true);
                        break;
                    default:
                        groupBox_Dias(true, false, false, false);
                        break;
                }
                cbx_dia.Text = datosFila[5];
                chb_lunes.Checked = datosFila[6].ToLower().Contains("true") ? true : false;
                chb_martes.Checked = datosFila[7].ToLower().Contains("true") ? true : false;
                chb_miercoles.Checked = datosFila[8].ToLower().Contains("true") ? true : false;
                chb_jueves.Checked = datosFila[9].ToLower().Contains("true") ? true : false;
                chb_viernes.Checked = datosFila[10].ToLower().Contains("true") ? true : false;
                chb_sabado.Checked = datosFila[11].ToLower().Contains("true") ? true : false;
                chb_domingo.Checked = datosFila[12].ToLower().Contains("true") ? true : false;
                cbx_hora.Text = datosFila[13].Substring(0,2);
                cbx_minuto.Text = datosFila[13].Substring(3, 2);

            }

            btn_nuevo.Enabled = true;
            btn_borrar.Enabled = true;
        }
        
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int idRespaldo = dtBackUp.Rows.Count + 1;
            int diames; 
            bool bDiaMes = int.TryParse(cbx_dia.Text, out diames);
            bool enviaMensaje = false;
            string mensaje = "";

            string nombre = txt_name.Text, origen = txt_origen.Text, destino = txt_destino.Text, periodicidad = cbx_periodicidad.Text, hora = cbx_hora.Text + ":" + cbx_minuto.Text;

            if (nombre != "" && origen != "" && destino != "" && origen != destino)
            {
                if (periodicidad == "Mensual" && diames==0)
                {
                    enviaMensaje = true;
                    mensaje = "Favor de elegir el día del mes.";
                }
                if (periodicidad == "Personalizado" && !chb_lunes.Checked && !chb_martes.Checked && !chb_miercoles.Checked && !chb_jueves.Checked && !chb_viernes.Checked && !chb_sabado.Checked && !chb_domingo.Checked)
                {
                    enviaMensaje = true;
                    mensaje = "Favor de elegir almenos un día de la semana.";
                }
                if (!enviaMensaje)
                {
                    if (int.Parse(lbl_id.Text) == 0) dtBackUp.Rows.Add(idRespaldo, nombre, origen, destino, periodicidad, diames, chb_lunes.Checked, chb_martes.Checked, chb_miercoles.Checked, chb_jueves.Checked, chb_viernes.Checked, chb_sabado.Checked, chb_domingo.Checked, hora);
                    else
                    {
                        string[] vColumnas = { nombre, origen, destino, periodicidad, diames.ToString(), chb_lunes.Checked.ToString(), chb_martes.Checked.ToString(), chb_miercoles.Checked.ToString(), chb_jueves.Checked.ToString(), chb_viernes.Checked.ToString(), chb_sabado.Checked.ToString(), chb_domingo.Checked.ToString(), hora };

                        idRespaldo = int.Parse(lbl_id.Text);
                        for (int i = 0; i < sColumnas.Length; i++)
                        {
                            dtBackUp.Rows[idRespaldo - 1][sColumnas[i]] = vColumnas[i];
                        }
                    }
                    dsJMRespalda.WriteXml(xmlRespaldos);
                }
                else MessageBox.Show(mensaje);
            }
            else if (origen == destino && origen != "" && destino != "" && nombre.Trim() != "") MessageBox.Show("Origen y Destino tienen que ser diferentes.");
            else MessageBox.Show("Favor de llenar todos los campos.");

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "0";
            txt_name.Text = "";
            txt_origen.Text = "";
            txt_destino.Text = "";
            cbx_periodicidad.Text = null;
            groupBox_Dias(true, false, false, true);
            cbx_hora.SelectedIndex = 0;
            cbx_minuto.SelectedIndex = 0;
            btn_borrar.Enabled = false;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            _7Zip comprime7zip = new _7Zip();
            if (comprime7zip.ComprimeCarpeta(txt_origen.Text, txt_destino.Text, 0)) MessageBox.Show("Exitasooooooo perroooos");
            else MessageBox.Show("Hechale GANITAS \n\n Error:\n" + comprime7zip.error);
        }

        private void cbx_hora_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            if (int.Parse(cbx_hora.Text)>18 || int.Parse(cbx_hora.Text) < 8)
            {
                img_noche.Visible = true;
                img_dia.Visible = false;
                //panel3.BackColor = Color.SteelBlue;
            }
            else
            {
                img_noche.Visible = false;
                img_dia.Visible = true;
                panel3.BackColor = Color.White;
            }
        }
    }
}
