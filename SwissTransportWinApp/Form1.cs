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

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmB_to.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmB_to.AutoCompleteSource = AutoCompleteSource.ListItems;

            //ITransport Test = new Transport();
            //var stations = Test.GetStations("A");

            //cmB_to.DataSource = stations.StationList;
        }
        private void cmB_From_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            getinput(cmB_From.Text, cmB_From);
        }
        private void CmB_From_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void cmB_to_TextChanged(object sender, EventArgs e)
        {
            //getinput(cmB_to.Text, cmB_to);
        }


        ////Funktionen

        void getinput(string input, ComboBox box)
        {
            RemoveAllItem(box);
            box.DroppedDown = true;
            findStation(input, box);
        }
        void findStation(string input, ComboBox box)
        {
            ITransport Test = new Transport();
            var stations = Test.GetStations(input);
            if (stations.StationList.Any() == false)
            {
                RemoveAllItem(box);
                return;
            }
            foreach (Station s in stations.StationList)
            {
                if (s.Name == null)
                {
                  return;
                }
                else if (s.Name.Contains(input))
                {
                    addItem(box, s.Name);
                }

            }

        }









            //void findStation(string input, ComboBox box)
            //{

            //    ITransport Test = new Transport();
            //    var stations = Test.GetStations(input);

            //    if (stations.StationList.Any() == false)
            //    {
            //        RemoveAllItem(box);
            //        return;
            //    }
            //    foreach (Station s in stations.StationList)
            //    {
            //        if (s.Name == null)
            //        {
            //            RemoveItem(box, s.Name);
            //            return;
            //        }
            //        else if (s.Name.Contains(input))
            //        {
            //            CompareCmbox(box, input, s.Name);
            //        }
            //    }

            //}
            //void CompareCmbox(ComboBox box, string input, string Name)
            //{
            //    if (box.Items.Count == 0)
            //    {
            //        addItem(box, Name);
            //    }
            //    else
            //    {
            //        bool existing = false;

            //        for (int i = 0; i == box.Items.Count; i++)
            //        {
            //            if (input == box.GetItemText(box.Items[i]))
            //            {
            //                existing = true;
            //            }
            //        }
            //        if (!existing)
            //        {
            //            addItem(box, Name);
            //        }
            //    }


            //}

            void addItem(ComboBox box, String Name)
            {
                box.Items.Add(Name);
            }
            void RemoveItem(ComboBox box, String Name)
            {
                box.Items.Remove(Name);
            }
            void RemoveAllItem(ComboBox box)
            {
                box.Items.Clear();
            }


    }
}

