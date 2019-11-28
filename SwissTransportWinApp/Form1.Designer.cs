namespace SwissTransportWinApp
{
    partial class Form1
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
            this.cmB_From = new System.Windows.Forms.ComboBox();
            this.cmB_to = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_date = new System.Windows.Forms.DateTimePicker();
            this.input_time = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmB_From
            // 
            this.cmB_From.FormattingEnabled = true;
            this.cmB_From.Location = new System.Drawing.Point(22, 32);
            this.cmB_From.Name = "cmB_From";
            this.cmB_From.Size = new System.Drawing.Size(121, 21);
            this.cmB_From.TabIndex = 0;
            this.cmB_From.TextChanged += new System.EventHandler(this.CmB_From_TextChanged);
            this.cmB_From.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmB_From_KeyPress);
            // 
            // cmB_to
            // 
            this.cmB_to.FormattingEnabled = true;
            this.cmB_to.Location = new System.Drawing.Point(179, 32);
            this.cmB_to.Name = "cmB_to";
            this.cmB_to.Size = new System.Drawing.Size(121, 21);
            this.cmB_to.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // input_date
            // 
            this.input_date.Location = new System.Drawing.Point(22, 78);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(200, 20);
            this.input_date.TabIndex = 4;
            // 
            // input_time
            // 
            this.input_time.CustomFormat = "hh:mm";
            this.input_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_time.Location = new System.Drawing.Point(247, 78);
            this.input_time.Name = "input_time";
            this.input_time.ShowUpDown = true;
            this.input_time.Size = new System.Drawing.Size(53, 20);
            this.input_time.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(121, 303);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.input_time);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmB_to);
            this.Controls.Add(this.cmB_From);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmB_From;
        private System.Windows.Forms.ComboBox cmB_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker input_date;
        private System.Windows.Forms.DateTimePicker input_time;
        private System.Windows.Forms.Button btn_search;
    }
}

