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
            btn_search.Enabled = false;
            rB_Departure.Checked = true;
        }


        ////userinput

        private void Txt_from_TextChanged(object sender, EventArgs e)
        {
            if(txt_from.ForeColor != Color.Gray)
                findStation(txt_from.Text, lbx_from);
            else
                pcB_noConnection.Visible = true;
        }
        private void Txt_to_TextChanged(object sender, EventArgs e)
        {
            if (txt_to.ForeColor != Color.Gray)
                findStation(txt_to.Text, lbx_to);
            else
                pcB_noConnection.Visible = true;
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
        private void Btn_search_Click(object sender, EventArgs e)
        {
            DateTime Time = input_date.Value.Date + input_time.Value.TimeOfDay;
            bool Arrival = rB_arrival.Checked==true;
            findConnection(lbx_connecntions, input_date.Value.Date, input_time.Value.TimeOfDay, Arrival);

        }
        private void RB_Departure_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_Departure.Checked == true)
            {
                rB_arrival.Enabled = true;
                rB_Departure.Enabled = false;
                Timefor("Departure");
            }
        }
        private void RB_arrival_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_arrival.Checked == true)
            {
                rB_arrival.Enabled = false;
                rB_Departure.Enabled = true;
                Timefor("Arrival");
            }
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
        void connectionpicture()
        {
            if(txt_from.Text != "Von" && txt_to.Text != "Nach") //txt_from.Text!= "" && txt_to.Text != "" && 
            {
                pcB_noConnection.Visible = false;
                btn_search.Enabled = true;
            }
            else
            {
                pcB_noConnection.Visible = true;
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
            pcB_noConnection.Visible = true;
            foreach (Station s in stations.StationList)
            {
                if (s.Name == null || s.Name == input)
                {
                    connectionpicture();
                    return;
                }
                else if (s.Name.Contains(input))
                {
                    Box.Items.Add(s.Name);
                }
            }
        }

        void findConnection(ListBox Box, DateTime Date, TimeSpan Time, bool arrival)
        {
            Box.Items.Clear();

            ITransport Temp = new Transport();
            var connections = Temp.GetConnections(txt_from.Text, txt_to.Text);
            if (connections.ConnectionList.Any() == false)
            {
                return;
            }
            pcB_noConnection.Visible = true;
            foreach (Connection c in connections.ConnectionList)
            {
                if(arrival == true)
                {
                    if(c.To.Arrival.Contains(Date.ToString()))
                    {

                    }
                }
                else
                {
                    string Cn = c.From.Station.Name + " " + c.To.Station.Name + " " + c.To.Arrival;
                    Box.Items.Add(Cn);
                }
            }
        }
        void Timefor(string Text)
        {
            Gp_DateTime.Text = Text;
        }
    }
}