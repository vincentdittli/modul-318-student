using SwissTransport;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmB_From_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
       
        private void CmB_From_TextChanged(object sender, EventArgs e)
        {
            if(cmB_From.Text.Length >= 3)
            {
                findStation(cmB_From.Text,cmB_From);
            }
        }

        void findStation(string input, ComboBox box)
        {

            ITransport Test = new Transport();
            var stations = Test.GetStations(input);

            bool found = false;           
            foreach (Station s in stations.StationList)
            {
                if (s.Name.Contains(input))
                {

                    if (box.Items.Count <= 0)
                    {
                        box.Items.Add(s.Name);
                    }
                    else
                    {

                        for (int i = 0; i < box.Items.Count; i++)
                        {
                            if (input != box.GetItemText(box.Items[i]))
                            {
                                box.Items.Add(s.Name);
                            }
                        }
                    }

                    found = true;
                }
            }
            if (!found)
            {
                box.Items.Clear();
            }
        }
    }
}
