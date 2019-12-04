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
    public partial class SSB : Form
    {
        public SSB()
        {
            InitializeComponent();
        }

        private void Connections_Load(object sender, EventArgs e)
        {
            txtBoxLeave(txt_from,"From");
            txtBoxLeave(txt_to,"To");
            btn_search.Enabled = false;
            rb_departure.Checked = true;
            btn_screenConnection.Enabled = false;
        }

        /*User Input*/

        //doubleclick
        private void Lbx_to_DoubleClick(object sender, EventArgs e)
        {
            lbxToText(txt_to, lbx_to.Text);
        }

        private void Lbx_from_DoubleClick(object sender, EventArgs e)
        {
            lbxToText(txt_from, lbx_from.Text);
        }

        //Click
        private void Btn_search_Click(object sender, EventArgs e)
        {
            if(btn_screenConnection.Enabled == false)
            {
                string Time = input_time.Value.ToShortTimeString();
                string Date = input_date.Value.ToShortDateString();
                bool Arrival = rb_arrival.Checked == true;

                findConnection(lbx_connections, Date, Time, Arrival);
            }
            else
            {
                cutTime();
            }
            

        }

        private void Btn_screenStation_Click(object sender, EventArgs e)
        {
            btn_screenStation.Enabled = false;
            btn_screenConnection.Enabled = true;
            switchScreen(2);
        }

        private void Btn_screenConnection_Click(object sender, EventArgs e)
        {
            btn_screenConnection.Enabled = false;
            btn_screenStation.Enabled = true;
            switchScreen(1);
        }

        //Textchanged
        private void Txt_from_TextChanged(object sender, EventArgs e)
        {
            if (txt_from.ForeColor != Color.Gray)
                findStation(txt_from.Text, lbx_from);
            else if (btn_screenConnection.Enabled == false)
            {
                pic_noConnection.Visible = true;
                btn_search.Enabled = false;
            }
        }

        private void Txt_to_TextChanged(object sender, EventArgs e)
        {
            if (txt_to.ForeColor != Color.Gray)
                findStation(txt_to.Text, lbx_to);
            else if (btn_screenConnection.Enabled == false)
            {
                pic_noConnection.Visible = true;
                btn_search.Enabled = false;
            }
        }

        //Enter and Leave
        private void Txt_from_Enter(object sender, EventArgs e)
        {
            txtBoxEnter(txt_from);
        }

        private void Txt_from_Leave(object sender, EventArgs e)
        {
            txtBoxLeave(txt_from,"From");
        }

        private void Txt_to_Enter(object sender, EventArgs e)
        {
            txtBoxEnter(txt_to);
        }

        private void Txt_to_Leave(object sender, EventArgs e)
        {
            txtBoxLeave(txt_to,"To");
        }

        //CheckedChange
        private void Rb_departure_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_departure.Checked == true)
            {
                rb_arrival.Enabled = true;
                rb_departure.Enabled = false;
                timeFor("Departure");
            }
        }

        private void Rb_arrival_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_arrival.Checked == true)
            {
                rb_arrival.Enabled = false;
                rb_departure.Enabled = true;
                timeFor("Arrival");
            }
        }


        /*Funktionen*/
        void findStation(string input, ListBox box)
        {
            btn_search.Enabled = false;
            box.Items.Clear();
            ITransport Test = new Transport();
            var stations = Test.GetStations(input);
            if (stations.StationList.Any() == false)
            {
                btn_search.Enabled = false;
                return;
            }
            if(btn_screenConnection.Enabled == false)
                 pic_noConnection.Visible = true;
            foreach (SwissTransport.Station s in stations.StationList)
            {
                if (s.Name == null || s.Name == input)
                {
                    connectionPicture();
                    return;
                }
                else if (s.Name.Contains(input))
                {
                    box.Items.Add(s.Name);
                }
            }
        }

        void findConnection(ListBox box, string date, string time, bool arrival)
        {
            box.Items.Clear();

            ITransport Temp = new Transport();
            var connections = Temp.GetConnections(txt_from.Text, txt_to.Text,date,time,arrival);
            if (connections.ConnectionList.Any() == false)
            {
                if (btn_screenConnection.Enabled == false)
                    pic_noConnection.Visible = true;
                return;
            }
            pic_noConnection.Visible = false;
            foreach (Connection c in connections.ConnectionList)
            {
                if(arrival == true)
                {
                    showConnections(box, c.To.Arrival.ToString());
                }
                else
                {
                    showConnections(box, c.From.Departure.ToString());
                }
                    
            }
        }

        void findStationboard(string date, string time)
        {
            lbx_connections.Items.Clear();

            ITransport Temp = new Transport();
            var stationboard = Temp.GetStationBoard(txt_from.Text, date, time);
            if (stationboard.Entries.Any() == false)
            {
                return;
            }
            foreach (StationBoard sb in stationboard.Entries)
            {
                lbx_connections.Items.Add(sb.To + " || " + sb.Stop.Departure.ToShortTimeString() + " || "+ sb.Stop.Departure.ToShortDateString());
            }
        }

        void lbxToText(TextBox box,string input)
        {
            if(input != "")
            box.Text = input;
        }

        void txtBoxEnter(TextBox box)
        {
            if (box.ForeColor == Color.Gray)
            {
                box.ForeColor = Color.Black;
                box.Text = "";
            }
        }

        void txtBoxLeave(TextBox box, string text)
        {
            if (box.Text == "")
            {
                box.ForeColor = Color.Gray;
                box.Text = text;
            }
        }

        void connectionPicture()
        {
            if(txt_from.Text != "From" && txt_to.Text != "To" && txt_from.Text != "" && txt_to.Text != "") 
            {
                pic_noConnection.Visible = false;
                btn_search.Enabled = true;
            }
            else if(btn_screenConnection.Enabled == false)
            {
                pic_noConnection.Visible = true;
            }

        }

        void showConnections(ListBox box,string time)
        {
            string cuttedTime = time.Substring(11,5);
            box.Items.Add("From " + txt_from.Text + " to " + txt_to.Text + " " + cuttedTime);
        }

        void timeFor(string text)
        {
            gb_dateTime.Text = text;
        }

        void cutTime()
        {
            string Time = input_time.Value.ToShortTimeString();
            string Date = input_date.Value.ToShortDateString();
            string Day = Date.Substring(3, 2);
            string Month = Date.Substring(0, 2);
            string Year = Date.Substring(7);
            string NewDate = Year + "-" + Month + "-" + Day;

            findStationboard(NewDate, Time);
        }

        void switchScreen(int button)
        {
            int Screencase = button;
            switch (Screencase)
            {
                case 1:
                    lbx_connections.Items.Clear();
                    gb_to.Visible = true;
                    pic_noConnection.Visible = true;
                    pic_connection.Visible = true;
                    rb_arrival.Visible = true;
                    rb_departure.Visible = true;
                    break;
                case 2:
                    lbx_connections.Items.Clear();
                    txt_to.Text = "";
                    txtBoxLeave(txt_to,"to");
                    gb_to.Visible = false;
                    pic_noConnection.Visible = false;
                    pic_connection.Visible = false;
                    rb_arrival.Visible = false;
                    rb_departure.Visible = false;
                    break;
            }
               
        }
    }
}