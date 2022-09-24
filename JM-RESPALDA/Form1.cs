using System;
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
        FolderBrowserDialog buscaCarpeta = new FolderBrowserDialog();
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
            _7Zip ruta7zip = new _7Zip();

            txt_name.Text = ruta7zip.ruta7zip;
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
                    groupBox_Dias(false, true, false);
                    break;
                case "Semanal":
                    groupBox_Dias(true, false, false);
                    break;
                case "Mensual":
                    groupBox_Dias(false, false, true);
                    break;
                case "Unica vez":
                    groupBox_Dias(false, false, false);
                    groupBox1.Enabled = false;
                    break;
                case "Personalizado":
                    groupBox_Dias(true, false, false);
                    break;
                default:
                    groupBox_Dias(true, false, false);
                    break;
            }
        }
        private void groupBox_Dias(bool habilitar, bool check, bool cbxDia)
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
            cbx_dia.SelectedIndex = 0;

            groupBox1.Enabled = !cbxDia;
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
    }
}
