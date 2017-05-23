namespace SPT
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbConnections = new System.Windows.Forms.GroupBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblDatumZeit = new System.Windows.Forms.Label();
            this.tbBis = new System.Windows.Forms.TextBox();
            this.lblBis = new System.Windows.Forms.Label();
            this.tbVon = new System.Windows.Forms.TextBox();
            this.lblVon = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbAbfahrtstafel = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbConnections.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbAbfahrtstafel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(55, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbConnections);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.gbConnections.Location = new System.Drawing.Point(0, 71);
            this.gbConnections.Name = "gbConnections";
            this.gbConnections.Size = new System.Drawing.Size(737, 174);
            this.gbConnections.TabIndex = 13;
            this.gbConnections.TabStop = false;
            this.gbConnections.Text = "Verbindungen suchen";
            this.gbConnections.Enter += new System.EventHandler(this.gbConnections_Enter);
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
            // 
            // lblBis
            // 
            this.lblBis.AutoSize = true;
            this.lblBis.Location = new System.Drawing.Point(463, 52);
            this.lblBis.Name = "lblBis";
            this.lblBis.Size = new System.Drawing.Size(48, 25);
            this.lblBis.TabIndex = 2;
            this.lblBis.Text = "Bis:";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbAbfahrtstafel);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbAbfahrtstafel
            // 
            this.gbAbfahrtstafel.Controls.Add(this.button1);
            this.gbAbfahrtstafel.Controls.Add(this.textBox2);
            this.gbAbfahrtstafel.Controls.Add(this.label4);
            this.gbAbfahrtstafel.Location = new System.Drawing.Point(-35, 102);
            this.gbAbfahrtstafel.Name = "gbAbfahrtstafel";
            this.gbAbfahrtstafel.Size = new System.Drawing.Size(826, 106);
            this.gbAbfahrtstafel.TabIndex = 15;
            this.gbAbfahrtstafel.TabStop = false;
            this.gbAbfahrtstafel.Text = "Abfahrtstafel erstellen";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 422);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(743, 208);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbConnections.ResumeLayout(false);
            this.gbConnections.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbAbfahrtstafel.ResumeLayout(false);
            this.gbAbfahrtstafel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbConnections;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label lblDatumZeit;
        private System.Windows.Forms.TextBox tbBis;
        private System.Windows.Forms.Label lblBis;
        private System.Windows.Forms.TextBox tbVon;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.GroupBox gbAbfahrtstafel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}