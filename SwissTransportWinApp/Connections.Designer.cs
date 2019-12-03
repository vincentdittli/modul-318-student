namespace SwissTransportWinApp
{
    partial class Connections
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connections));
            this.gb_From = new System.Windows.Forms.GroupBox();
            this.lbx_from = new System.Windows.Forms.ListBox();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.gb_to = new System.Windows.Forms.GroupBox();
            this.lbx_to = new System.Windows.Forms.ListBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.Gp_DateTime = new System.Windows.Forms.GroupBox();
            this.input_date = new System.Windows.Forms.DateTimePicker();
            this.input_time = new System.Windows.Forms.DateTimePicker();
            this.picB_connection = new System.Windows.Forms.PictureBox();
            this.pcB_noConnection = new System.Windows.Forms.PictureBox();
            this.lbx_connecntions = new System.Windows.Forms.ListBox();
            this.gb_input = new System.Windows.Forms.GroupBox();
            this.gb_Connections = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rB_Departure = new System.Windows.Forms.RadioButton();
            this.rB_arrival = new System.Windows.Forms.RadioButton();
            this.gb_From.SuspendLayout();
            this.gb_to.SuspendLayout();
            this.Gp_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_connection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_noConnection)).BeginInit();
            this.gb_input.SuspendLayout();
            this.gb_Connections.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_From
            // 
            this.gb_From.AutoSize = true;
            this.gb_From.Controls.Add(this.lbx_from);
            this.gb_From.Controls.Add(this.txt_from);
            this.gb_From.Location = new System.Drawing.Point(19, 19);
            this.gb_From.MinimumSize = new System.Drawing.Size(154, 165);
            this.gb_From.Name = "gb_From";
            this.gb_From.Size = new System.Drawing.Size(154, 165);
            this.gb_From.TabIndex = 12;
            this.gb_From.TabStop = false;
            this.gb_From.Text = "From";
            // 
            // lbx_from
            // 
            this.lbx_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_from.FormattingEnabled = true;
            this.lbx_from.Location = new System.Drawing.Point(3, 36);
            this.lbx_from.MinimumSize = new System.Drawing.Size(120, 95);
            this.lbx_from.Name = "lbx_from";
            this.lbx_from.Size = new System.Drawing.Size(148, 126);
            this.lbx_from.TabIndex = 9;
            this.lbx_from.DoubleClick += new System.EventHandler(this.Lbx_from_DoubleClick);
            // 
            // txt_from
            // 
            this.txt_from.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_from.Location = new System.Drawing.Point(3, 16);
            this.txt_from.MinimumSize = new System.Drawing.Size(120, 20);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(148, 20);
            this.txt_from.TabIndex = 7;
            this.txt_from.TextChanged += new System.EventHandler(this.Txt_from_TextChanged);
            this.txt_from.Enter += new System.EventHandler(this.Txt_from_Enter);
            this.txt_from.Leave += new System.EventHandler(this.Txt_from_Leave);
            // 
            // gb_to
            // 
            this.gb_to.AutoSize = true;
            this.gb_to.Controls.Add(this.lbx_to);
            this.gb_to.Controls.Add(this.txt_to);
            this.gb_to.Location = new System.Drawing.Point(238, 19);
            this.gb_to.MinimumSize = new System.Drawing.Size(154, 165);
            this.gb_to.Name = "gb_to";
            this.gb_to.Size = new System.Drawing.Size(154, 165);
            this.gb_to.TabIndex = 13;
            this.gb_to.TabStop = false;
            this.gb_to.Text = "To";
            // 
            // lbx_to
            // 
            this.lbx_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_to.FormattingEnabled = true;
            this.lbx_to.Location = new System.Drawing.Point(3, 36);
            this.lbx_to.Name = "lbx_to";
            this.lbx_to.Size = new System.Drawing.Size(148, 126);
            this.lbx_to.TabIndex = 10;
            this.lbx_to.DoubleClick += new System.EventHandler(this.Lbx_to_DoubleClick);
            // 
            // txt_to
            // 
            this.txt_to.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_to.Location = new System.Drawing.Point(3, 16);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(148, 20);
            this.txt_to.TabIndex = 8;
            this.txt_to.TextChanged += new System.EventHandler(this.Txt_to_TextChanged);
            this.txt_to.Enter += new System.EventHandler(this.Txt_to_Enter);
            this.txt_to.Leave += new System.EventHandler(this.Txt_to_Leave);
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.Location = new System.Drawing.Point(303, 204);
            this.btn_search.MinimumSize = new System.Drawing.Size(50, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 40);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // Gp_DateTime
            // 
            this.Gp_DateTime.AutoSize = true;
            this.Gp_DateTime.Controls.Add(this.rB_arrival);
            this.Gp_DateTime.Controls.Add(this.input_date);
            this.Gp_DateTime.Controls.Add(this.input_time);
            this.Gp_DateTime.Controls.Add(this.rB_Departure);
            this.Gp_DateTime.Location = new System.Drawing.Point(22, 204);
            this.Gp_DateTime.MaximumSize = new System.Drawing.Size(0, 70);
            this.Gp_DateTime.MinimumSize = new System.Drawing.Size(281, 45);
            this.Gp_DateTime.Name = "Gp_DateTime";
            this.Gp_DateTime.Size = new System.Drawing.Size(281, 70);
            this.Gp_DateTime.TabIndex = 12;
            this.Gp_DateTime.TabStop = false;
            this.Gp_DateTime.Text = "Departure";
            // 
            // input_date
            // 
            this.input_date.CustomFormat = "dddd d.MMMM yyyy";
            this.input_date.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_date.Location = new System.Drawing.Point(3, 16);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(191, 20);
            this.input_date.TabIndex = 4;
            // 
            // input_time
            // 
            this.input_time.CustomFormat = "hh:mm";
            this.input_time.Dock = System.Windows.Forms.DockStyle.Right;
            this.input_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_time.Location = new System.Drawing.Point(222, 16);
            this.input_time.Name = "input_time";
            this.input_time.ShowUpDown = true;
            this.input_time.Size = new System.Drawing.Size(56, 20);
            this.input_time.TabIndex = 5;
            // 
            // picB_connection
            // 
            this.picB_connection.Image = ((System.Drawing.Image)(resources.GetObject("picB_connection.Image")));
            this.picB_connection.Location = new System.Drawing.Point(177, 79);
            this.picB_connection.Name = "picB_connection";
            this.picB_connection.Size = new System.Drawing.Size(55, 50);
            this.picB_connection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_connection.TabIndex = 14;
            this.picB_connection.TabStop = false;
            // 
            // pcB_noConnection
            // 
            this.pcB_noConnection.Image = ((System.Drawing.Image)(resources.GetObject("pcB_noConnection.Image")));
            this.pcB_noConnection.Location = new System.Drawing.Point(177, 79);
            this.pcB_noConnection.Name = "pcB_noConnection";
            this.pcB_noConnection.Size = new System.Drawing.Size(55, 50);
            this.pcB_noConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcB_noConnection.TabIndex = 15;
            this.pcB_noConnection.TabStop = false;
            // 
            // lbx_connecntions
            // 
            this.lbx_connecntions.FormattingEnabled = true;
            this.lbx_connecntions.Location = new System.Drawing.Point(6, 19);
            this.lbx_connecntions.Name = "lbx_connecntions";
            this.lbx_connecntions.Size = new System.Drawing.Size(212, 251);
            this.lbx_connecntions.TabIndex = 16;
            // 
            // gb_input
            // 
            this.gb_input.Controls.Add(this.gb_From);
            this.gb_input.Controls.Add(this.btn_search);
            this.gb_input.Controls.Add(this.pcB_noConnection);
            this.gb_input.Controls.Add(this.picB_connection);
            this.gb_input.Controls.Add(this.gb_to);
            this.gb_input.Controls.Add(this.Gp_DateTime);
            this.gb_input.Location = new System.Drawing.Point(2, 1);
            this.gb_input.Name = "gb_input";
            this.gb_input.Size = new System.Drawing.Size(418, 284);
            this.gb_input.TabIndex = 17;
            this.gb_input.TabStop = false;
            // 
            // gb_Connections
            // 
            this.gb_Connections.Controls.Add(this.lbx_connecntions);
            this.gb_Connections.Location = new System.Drawing.Point(434, 1);
            this.gb_Connections.Name = "gb_Connections";
            this.gb_Connections.Size = new System.Drawing.Size(224, 284);
            this.gb_Connections.TabIndex = 18;
            this.gb_Connections.TabStop = false;
            this.gb_Connections.Text = "Connections";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 51);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 51);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(346, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 51);
            this.button3.TabIndex = 21;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(517, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 51);
            this.button4.TabIndex = 22;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // rB_Departure
            // 
            this.rB_Departure.AutoSize = true;
            this.rB_Departure.Location = new System.Drawing.Point(6, 48);
            this.rB_Departure.Name = "rB_Departure";
            this.rB_Departure.Size = new System.Drawing.Size(72, 17);
            this.rB_Departure.TabIndex = 16;
            this.rB_Departure.TabStop = true;
            this.rB_Departure.Text = "Departure";
            this.rB_Departure.UseVisualStyleBackColor = true;
            this.rB_Departure.CheckedChanged += new System.EventHandler(this.RB_Departure_CheckedChanged);
            // 
            // rB_arrival
            // 
            this.rB_arrival.AutoSize = true;
            this.rB_arrival.Location = new System.Drawing.Point(97, 48);
            this.rB_arrival.Name = "rB_arrival";
            this.rB_arrival.Size = new System.Drawing.Size(54, 17);
            this.rB_arrival.TabIndex = 17;
            this.rB_arrival.TabStop = true;
            this.rB_arrival.Text = "Arrival";
            this.rB_arrival.UseVisualStyleBackColor = true;
            this.rB_arrival.CheckedChanged += new System.EventHandler(this.RB_arrival_CheckedChanged);
            // 
            // Connections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 394);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_Connections);
            this.Controls.Add(this.gb_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(469, 433);
            this.Name = "Connections";
            this.Text = "Connections";
            this.Load += new System.EventHandler(this.Connections_Load);
            this.gb_From.ResumeLayout(false);
            this.gb_From.PerformLayout();
            this.gb_to.ResumeLayout(false);
            this.gb_to.PerformLayout();
            this.Gp_DateTime.ResumeLayout(false);
            this.Gp_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_connection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_noConnection)).EndInit();
            this.gb_input.ResumeLayout(false);
            this.gb_input.PerformLayout();
            this.gb_Connections.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_From;
        private System.Windows.Forms.ListBox lbx_from;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.GroupBox gb_to;
        private System.Windows.Forms.ListBox lbx_to;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox Gp_DateTime;
        private System.Windows.Forms.DateTimePicker input_date;
        private System.Windows.Forms.DateTimePicker input_time;
        private System.Windows.Forms.PictureBox pcB_noConnection;
        private System.Windows.Forms.PictureBox picB_connection;
        private System.Windows.Forms.ListBox lbx_connecntions;
        private System.Windows.Forms.GroupBox gb_input;
        private System.Windows.Forms.GroupBox gb_Connections;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rB_arrival;
        private System.Windows.Forms.RadioButton rB_Departure;
    }
}

