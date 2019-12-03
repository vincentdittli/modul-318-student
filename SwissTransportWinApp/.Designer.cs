namespace SwissTransportWinApp
{
    partial class StartApp
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
            this.btn_Connections = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Connections
            // 
            this.btn_Connections.Location = new System.Drawing.Point(110, 53);
            this.btn_Connections.Name = "btn_Connections";
            this.btn_Connections.Size = new System.Drawing.Size(75, 23);
            this.btn_Connections.TabIndex = 0;
            this.btn_Connections.Text = "Connections";
            this.btn_Connections.UseVisualStyleBackColor = true;
            this.btn_Connections.Click += new System.EventHandler(this.Btn_Connections_Click);
            // 
            // StartApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Connections);
            this.Name = "StartApp";
            this.Text = "SSB";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Connections;
    }
}