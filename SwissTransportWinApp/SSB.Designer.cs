namespace SwissTransportWinApp
{
    partial class SSB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSB));
            this.gb_from = new System.Windows.Forms.GroupBox();
            this.lbx_from = new System.Windows.Forms.ListBox();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.gb_to = new System.Windows.Forms.GroupBox();
            this.lbx_to = new System.Windows.Forms.ListBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.gb_dateTime = new System.Windows.Forms.GroupBox();
            this.rb_arrival = new System.Windows.Forms.RadioButton();
            this.input_date = new System.Windows.Forms.DateTimePicker();
            this.input_time = new System.Windows.Forms.DateTimePicker();
            this.rb_departure = new System.Windows.Forms.RadioButton();
            this.pic_connection = new System.Windows.Forms.PictureBox();
            this.pic_noConnection = new System.Windows.Forms.PictureBox();
            this.lbx_connections = new System.Windows.Forms.ListBox();
            this.gb_input = new System.Windows.Forms.GroupBox();
            this.gb_connections = new System.Windows.Forms.GroupBox();
            this.btn_screenStation = new System.Windows.Forms.Button();
            this.btn_screenConnection = new System.Windows.Forms.Button();
            this.gb_from.SuspendLayout();
            this.gb_to.SuspendLayout();
            this.gb_dateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_connection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_noConnection)).BeginInit();
            this.gb_input.SuspendLayout();
            this.gb_connections.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_from
            // 
            this.gb_from.AutoSize = true;
            this.gb_from.Controls.Add(this.lbx_from);
            this.gb_from.Controls.Add(this.txt_from);
            this.gb_from.Location = new System.Drawing.Point(19, 19);
            this.gb_from.MinimumSize = new System.Drawing.Size(154, 165);
            this.gb_from.Name = "gb_from";
            this.gb_from.Size = new System.Drawing.Size(154, 165);
            this.gb_from.TabIndex = 0;
            this.gb_from.TabStop = false;
            this.gb_from.Text = "From";
            // 
            // lbx_from
            // 
            this.lbx_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_from.FormattingEnabled = true;
            this.lbx_from.Location = new System.Drawing.Point(3, 36);
            this.lbx_from.MinimumSize = new System.Drawing.Size(120, 95);
            this.lbx_from.Name = "lbx_from";
            this.lbx_from.Size = new System.Drawing.Size(148, 126);
            this.lbx_from.TabIndex = 1;
            this.lbx_from.DoubleClick += new System.EventHandler(this.Lbx_from_DoubleClick);
            // 
            // txt_from
            // 
            this.txt_from.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_from.Location = new System.Drawing.Point(3, 16);
            this.txt_from.MinimumSize = new System.Drawing.Size(120, 20);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(148, 20);
            this.txt_from.TabIndex = 0;
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
            this.gb_to.TabIndex = 1;
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
            this.lbx_to.TabIndex = 1;
            this.lbx_to.DoubleClick += new System.EventHandler(this.Lbx_to_DoubleClick);
            // 
            // txt_to
            // 
            this.txt_to.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_to.Location = new System.Drawing.Point(3, 16);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(148, 20);
            this.txt_to.TabIndex = 0;
            this.txt_to.TextChanged += new System.EventHandler(this.Txt_to_TextChanged);
            this.txt_to.Enter += new System.EventHandler(this.Txt_to_Enter);
            this.txt_to.Leave += new System.EventHandler(this.Txt_to_Leave);
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.Location = new System.Drawing.Point(309, 220);
            this.btn_search.MinimumSize = new System.Drawing.Size(50, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 40);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // gb_dateTime
            // 
            this.gb_dateTime.AutoSize = true;
            this.gb_dateTime.Controls.Add(this.rb_arrival);
            this.gb_dateTime.Controls.Add(this.input_date);
            this.gb_dateTime.Controls.Add(this.input_time);
            this.gb_dateTime.Controls.Add(this.rb_departure);
            this.gb_dateTime.Location = new System.Drawing.Point(22, 204);
            this.gb_dateTime.MaximumSize = new System.Drawing.Size(0, 70);
            this.gb_dateTime.MinimumSize = new System.Drawing.Size(281, 45);
            this.gb_dateTime.Name = "gb_dateTime";
            this.gb_dateTime.Size = new System.Drawing.Size(281, 70);
            this.gb_dateTime.TabIndex = 2;
            this.gb_dateTime.TabStop = false;
            this.gb_dateTime.Text = "Departure";
            // 
            // rb_arrival
            // 
            this.rb_arrival.AutoSize = true;
            this.rb_arrival.Location = new System.Drawing.Point(97, 48);
            this.rb_arrival.Name = "rb_arrival";
            this.rb_arrival.Size = new System.Drawing.Size(54, 17);
            this.rb_arrival.TabIndex = 3;
            this.rb_arrival.TabStop = true;
            this.rb_arrival.Text = "Arrival";
            this.rb_arrival.UseVisualStyleBackColor = true;
            this.rb_arrival.CheckedChanged += new System.EventHandler(this.Rb_arrival_CheckedChanged);
            // 
            // input_date
            // 
            this.input_date.CustomFormat = "dddd d.MMMM yyyy";
            this.input_date.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_date.Location = new System.Drawing.Point(3, 16);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(191, 20);
            this.input_date.TabIndex = 0;
            // 
            // input_time
            // 
            this.input_time.CustomFormat = "HH:mm";
            this.input_time.Dock = System.Windows.Forms.DockStyle.Right;
            this.input_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_time.Location = new System.Drawing.Point(222, 16);
            this.input_time.Name = "input_time";
            this.input_time.ShowUpDown = true;
            this.input_time.Size = new System.Drawing.Size(56, 20);
            this.input_time.TabIndex = 1;
            // 
            // rb_departure
            // 
            this.rb_departure.AutoSize = true;
            this.rb_departure.Location = new System.Drawing.Point(6, 48);
            this.rb_departure.Name = "rb_departure";
            this.rb_departure.Size = new System.Drawing.Size(72, 17);
            this.rb_departure.TabIndex = 2;
            this.rb_departure.TabStop = true;
            this.rb_departure.Text = "Departure";
            this.rb_departure.UseVisualStyleBackColor = true;
            this.rb_departure.CheckedChanged += new System.EventHandler(this.Rb_departure_CheckedChanged);
            // 
            // pic_connection
            // 
            this.pic_connection.Image = ((System.Drawing.Image)(resources.GetObject("pic_connection.Image")));
            this.pic_connection.Location = new System.Drawing.Point(177, 79);
            this.pic_connection.Name = "pic_connection";
            this.pic_connection.Size = new System.Drawing.Size(55, 50);
            this.pic_connection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_connection.TabIndex = 14;
            this.pic_connection.TabStop = false;
            // 
            // pic_noConnection
            // 
            this.pic_noConnection.Image = ((System.Drawing.Image)(resources.GetObject("pic_noConnection.Image")));
            this.pic_noConnection.Location = new System.Drawing.Point(177, 79);
            this.pic_noConnection.Name = "pic_noConnection";
            this.pic_noConnection.Size = new System.Drawing.Size(55, 50);
            this.pic_noConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_noConnection.TabIndex = 15;
            this.pic_noConnection.TabStop = false;
            // 
            // lbx_connections
            // 
            this.lbx_connections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_connections.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_connections.FormattingEnabled = true;
            this.lbx_connections.ItemHeight = 23;
            this.lbx_connections.Location = new System.Drawing.Point(3, 16);
            this.lbx_connections.Name = "lbx_connections";
            this.lbx_connections.Size = new System.Drawing.Size(316, 142);
            this.lbx_connections.TabIndex = 0;
            // 
            // gb_input
            // 
            this.gb_input.Controls.Add(this.gb_from);
            this.gb_input.Controls.Add(this.btn_search);
            this.gb_input.Controls.Add(this.pic_noConnection);
            this.gb_input.Controls.Add(this.pic_connection);
            this.gb_input.Controls.Add(this.gb_to);
            this.gb_input.Controls.Add(this.gb_dateTime);
            this.gb_input.Location = new System.Drawing.Point(2, 1);
            this.gb_input.Name = "gb_input";
            this.gb_input.Size = new System.Drawing.Size(418, 284);
            this.gb_input.TabIndex = 0;
            this.gb_input.TabStop = false;
            // 
            // gb_connections
            // 
            this.gb_connections.Controls.Add(this.lbx_connections);
            this.gb_connections.Location = new System.Drawing.Point(434, 1);
            this.gb_connections.Name = "gb_connections";
            this.gb_connections.Size = new System.Drawing.Size(322, 161);
            this.gb_connections.TabIndex = 1;
            this.gb_connections.TabStop = false;
            this.gb_connections.Text = "Connections";
            // 
            // btn_screenStation
            // 
            this.btn_screenStation.Location = new System.Drawing.Point(655, 182);
            this.btn_screenStation.Name = "btn_screenStation";
            this.btn_screenStation.Size = new System.Drawing.Size(98, 79);
            this.btn_screenStation.TabIndex = 3;
            this.btn_screenStation.Text = "Station";
            this.btn_screenStation.UseVisualStyleBackColor = true;
            this.btn_screenStation.Click += new System.EventHandler(this.Btn_screenStation_Click);
            // 
            // btn_screenConnection
            // 
            this.btn_screenConnection.Location = new System.Drawing.Point(437, 182);
            this.btn_screenConnection.Name = "btn_screenConnection";
            this.btn_screenConnection.Size = new System.Drawing.Size(98, 79);
            this.btn_screenConnection.TabIndex = 2;
            this.btn_screenConnection.Text = "Connection";
            this.btn_screenConnection.UseVisualStyleBackColor = true;
            this.btn_screenConnection.Click += new System.EventHandler(this.Btn_screenConnection_Click);
            // 
            // SSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 301);
            this.Controls.Add(this.btn_screenConnection);
            this.Controls.Add(this.btn_screenStation);
            this.Controls.Add(this.gb_connections);
            this.Controls.Add(this.gb_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 340);
            this.MinimumSize = new System.Drawing.Size(800, 340);
            this.Name = "SSB";
            this.Text = "SSB";
            this.Load += new System.EventHandler(this.Connections_Load);
            this.gb_from.ResumeLayout(false);
            this.gb_from.PerformLayout();
            this.gb_to.ResumeLayout(false);
            this.gb_to.PerformLayout();
            this.gb_dateTime.ResumeLayout(false);
            this.gb_dateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_connection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_noConnection)).EndInit();
            this.gb_input.ResumeLayout(false);
            this.gb_input.PerformLayout();
            this.gb_connections.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_from;
        private System.Windows.Forms.ListBox lbx_from;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.GroupBox gb_to;
        private System.Windows.Forms.ListBox lbx_to;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox gb_dateTime;
        private System.Windows.Forms.DateTimePicker input_date;
        private System.Windows.Forms.DateTimePicker input_time;
        private System.Windows.Forms.PictureBox pic_noConnection;
        private System.Windows.Forms.PictureBox pic_connection;
        private System.Windows.Forms.ListBox lbx_connections;
        private System.Windows.Forms.GroupBox gb_input;
        private System.Windows.Forms.GroupBox gb_connections;
        private System.Windows.Forms.Button btn_screenStation;
        private System.Windows.Forms.RadioButton rb_arrival;
        private System.Windows.Forms.RadioButton rb_departure;
        private System.Windows.Forms.Button btn_screenConnection;
    }
}

