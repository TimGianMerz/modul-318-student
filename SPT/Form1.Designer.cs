namespace SPT
{
    partial class SPT
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbConnections = new System.Windows.Forms.GroupBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblDatumZeit = new System.Windows.Forms.Label();
            this.tbBis = new System.Windows.Forms.TextBox();
            this.lblBis = new System.Windows.Forms.Label();
            this.tbVon = new System.Windows.Forms.TextBox();
            this.lblVon = new System.Windows.Forms.Label();
            this.gbAbfahrtstafel = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.gbConnections.SuspendLayout();
            this.gbAbfahrtstafel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Swiss Public Transport";
            // 
            // gbConnections
            // 
            this.gbConnections.Controls.Add(this.btnSuchen);
            this.gbConnections.Controls.Add(this.dtpDateTime);
            this.gbConnections.Controls.Add(this.lblDatumZeit);
            this.gbConnections.Controls.Add(this.tbBis);
            this.gbConnections.Controls.Add(this.lblBis);
            this.gbConnections.Controls.Add(this.tbVon);
            this.gbConnections.Controls.Add(this.lblVon);
            this.gbConnections.Location = new System.Drawing.Point(533, 146);
            this.gbConnections.Name = "gbConnections";
            this.gbConnections.Size = new System.Drawing.Size(826, 174);
            this.gbConnections.TabIndex = 1;
            this.gbConnections.TabStop = false;
            this.gbConnections.Text = "Verbindungen suchen";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(468, 106);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(293, 40);
            this.btnSuchen.TabIndex = 4;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "dd.MM.yy HH:mm";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(221, 109);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(236, 31);
            this.dtpDateTime.TabIndex = 3;
            this.dtpDateTime.ValueChanged += new System.EventHandler(this.dtpDateTime_ValueChanged);
            // 
            // lblDatumZeit
            // 
            this.lblDatumZeit.AutoSize = true;
            this.lblDatumZeit.Location = new System.Drawing.Point(26, 109);
            this.lblDatumZeit.Name = "lblDatumZeit";
            this.lblDatumZeit.Size = new System.Drawing.Size(128, 25);
            this.lblDatumZeit.TabIndex = 2;
            this.lblDatumZeit.Text = "Datum / Zeit";
            // 
            // tbBis
            // 
            this.tbBis.Location = new System.Drawing.Point(525, 49);
            this.tbBis.Name = "tbBis";
            this.tbBis.Size = new System.Drawing.Size(236, 31);
            this.tbBis.TabIndex = 2;
            this.tbBis.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblBis
            // 
            this.lblBis.AutoSize = true;
            this.lblBis.Location = new System.Drawing.Point(463, 52);
            this.lblBis.Name = "lblBis";
            this.lblBis.Size = new System.Drawing.Size(48, 25);
            this.lblBis.TabIndex = 2;
            this.lblBis.Text = "Bis:";
            this.lblBis.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbVon
            // 
            this.tbVon.Location = new System.Drawing.Point(221, 52);
            this.tbVon.Name = "tbVon";
            this.tbVon.Size = new System.Drawing.Size(236, 31);
            this.tbVon.TabIndex = 1;
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(26, 52);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(56, 25);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von:";
            // 
            // gbAbfahrtstafel
            // 
            this.gbAbfahrtstafel.Controls.Add(this.button1);
            this.gbAbfahrtstafel.Controls.Add(this.textBox2);
            this.gbAbfahrtstafel.Controls.Add(this.label4);
            this.gbAbfahrtstafel.Location = new System.Drawing.Point(533, 390);
            this.gbAbfahrtstafel.Name = "gbAbfahrtstafel";
            this.gbAbfahrtstafel.Size = new System.Drawing.Size(826, 106);
            this.gbAbfahrtstafel.TabIndex = 5;
            this.gbAbfahrtstafel.TabStop = false;
            this.gbAbfahrtstafel.Text = "Abfahrtstafel erstellen";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 31);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Von:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.lblCurrentLocation);
            this.groupBox1.Location = new System.Drawing.Point(533, 560);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verbindungen suchen";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Suchen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(221, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 31);
            this.textBox3.TabIndex = 7;
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.AutoSize = true;
            this.lblCurrentLocation.Location = new System.Drawing.Point(26, 64);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(189, 25);
            this.lblCurrentLocation.TabIndex = 0;
            this.lblCurrentLocation.Text = "Aktueller Standort:";
            this.lblCurrentLocation.Click += new System.EventHandler(this.label5_Click);
            // 
            // SPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 825);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAbfahrtstafel);
            this.Controls.Add(this.gbConnections);
            this.Controls.Add(this.label1);
            this.Name = "SPT";
            this.Text = "SPT";
            this.gbConnections.ResumeLayout(false);
            this.gbConnections.PerformLayout();
            this.gbAbfahrtstafel.ResumeLayout(false);
            this.gbAbfahrtstafel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConnections;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.TextBox tbVon;
        private System.Windows.Forms.TextBox tbBis;
        private System.Windows.Forms.Label lblBis;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label lblDatumZeit;
        private System.Windows.Forms.GroupBox gbAbfahrtstafel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCurrentLocation;
    }
}

