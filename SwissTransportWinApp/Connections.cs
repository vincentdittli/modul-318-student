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
    public partial class Connections : Form
    {
        public Connections()
        {
            InitializeComponent();
        }

        
        private void Connections_Load(object sender, EventArgs e)
        {
            txtbox_Leave(txt_from,"Von");
            txtbox_Leave(txt_to,"Nach");
        }

        //userinput
        private void Txt_from_TextChanged(object sender, EventArgs e)
        {
            if(txt_from.ForeColor != Color.Gray)
            findStation(txt_from.Text, lbx_from);
        }
        private void Txt_to_TextChanged(object sender, EventArgs e)
        {
            if (txt_to.ForeColor != Color.Gray)
                findStation(txt_to.Text, lbx_to);
        }
        private void Lbx_to_DoubleClick(object sender, EventArgs e)
        {
            lbxToText(txt_to, lbx_to.Text);
        }
        private void Lbx_from_DoubleClick(object sender, EventArgs e)
        {
            lbxToText(txt_from, lbx_from.Text);
        }

        private void Txt_from_Enter(object sender, EventArgs e)
        {
            txtbox_Enter(txt_from);
        }

        private void Txt_from_Leave(object sender, EventArgs e)
        {
            txtbox_Leave(txt_from,"Von");
        }
        private void Txt_to_Enter(object sender, EventArgs e)
        {
            txtbox_Enter(txt_to);
        }

        private void Txt_to_Leave(object sender, EventArgs e)
        {
            txtbox_Leave(txt_to,"Nach");
        }
        //Funktionen

        void lbxToText(TextBox TxtBox,string input)
        {
            if(input != "")
            TxtBox.Text = input;
        }

        void txtbox_Enter(TextBox Box)
        {
            if (Box.ForeColor == Color.Gray)
            {
                Box.ForeColor = Color.Black;
                Box.Text = "";
            }
        }
        void txtbox_Leave(TextBox Box, string Text)
        {
            if (Box.Text == "")
            {
                Box.ForeColor = Color.Gray;
                Box.Text = Text;
            }
        }
        void connectionpicture(TextBox txt_from,TextBox txt_to, PictureBox picture)
        {
            if(txt_from.Text!= "" && txt_to.Text != "")
            {
                picture.Visible = false;
            }
            else
            {
                picture.Visible = true;
            }

        }
        void findStation(string input, ListBox Box)
        {
            Box.Items.Clear();
            ITransport Test = new Transport();
            var stations = Test.GetStations(input);
            if (stations.StationList.Any() == false)
            {
                return;
            }
            foreach (Station s in stations.StationList)
            {
                if (s.Name == null || s.Name == input)
                {
                    return;
                }
                else if (s.Name.Contains(input))
                {
                    Box.Items.Add(s.Name);
                }
            }
        }

        private void PcB_noConnection_Click(object sender, EventArgs e)
        {
            pcB_noConnection.Visible = false;
        }
    }
}