using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JM_RESPALDA
{
    public partial class JM_RESPALDA : Form
    {
        public JM_RESPALDA()
        {
            InitializeComponent();
        }

        private void JM_RESPALDA_Load(object sender, EventArgs e)
        {
            _7Zip ruta7zip = new _7Zip();

            txt_origen.Text = ruta7zip.ruta7zip;
            
        }
        
    }
}
