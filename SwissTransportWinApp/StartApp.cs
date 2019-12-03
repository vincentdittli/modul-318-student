using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportWinApp
{
    public partial class StartApp : Form
    {
        public StartApp()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Connections_Click(object sender, EventArgs e)
        { 
            if (Application.OpenForms.OfType<Connections>().Count()< 3)
            {
                new Connections().Show();
            }
            else
            {
                MessageBox.Show("To many Connections open");
            }
        }
    }
}
