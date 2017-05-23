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
            this.gbAbfahrtstafel = new System.Windows.Forms.GroupBox();
            this.tafCbVon = new System.Windows.Forms.ComboBox();
            this.tafBtnSuchen = new System.Windows.Forms.Button();
            this.tafLblVon = new System.Windows.Forms.Label();
            this.gbConnections = new System.Windows.Forms.GroupBox();
            this.conCbBis = new System.Windows.Forms.ComboBox();
            this.conCbVon = new System.Windows.Forms.ComboBox();
            this.conBtnSuchen = new System.Windows.Forms.Button();
            this.conDtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.conLblDatumZeit = new System.Windows.Forms.Label();
            this.conLblBis = new System.Windows.Forms.Label();
            this.conLblVon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVerbindungen = new System.Windows.Forms.DataGridView();
            this.gbAbfahrtstafel.SuspendLayout();
            this.gbConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAbfahrtstafel
            // 
            this.gbAbfahrtstafel.Controls.Add(this.tafCbVon);
            this.gbAbfahrtstafel.Controls.Add(this.tafBtnSuchen);
            this.gbAbfahrtstafel.Controls.Add(this.tafLblVon);
            this.gbAbfahrtstafel.Location = new System.Drawing.Point(76, 397);
            this.gbAbfahrtstafel.Name = "gbAbfahrtstafel";
            this.gbAbfahrtstafel.Size = new System.Drawing.Size(826, 153);
            this.gbAbfahrtstafel.TabIndex = 14;
            this.gbAbfahrtstafel.TabStop = false;
            this.gbAbfahrtstafel.Text = "Abfahrtstafel erstellen";
            // 
            // tafCbVon
            // 
            this.tafCbVon.FormattingEnabled = true;
            this.tafCbVon.Location = new System.Drawing.Point(221, 48);
            this.tafCbVon.Name = "tafCbVon";
            this.tafCbVon.Size = new System.Drawing.Size(236, 33);
            this.tafCbVon.TabIndex = 7;
            this.tafCbVon.DropDown += new System.EventHandler(this.tafCbVon_DropDown);
            // 
            // tafBtnSuchen
            // 
            this.tafBtnSuchen.Location = new System.Drawing.Point(468, 43);
            this.tafBtnSuchen.Name = "tafBtnSuchen";
            this.tafBtnSuchen.Size = new System.Drawing.Size(293, 40);
            this.tafBtnSuchen.TabIndex = 6;
            this.tafBtnSuchen.Text = "Suchen";
            this.tafBtnSuchen.UseVisualStyleBackColor = true;
            this.tafBtnSuchen.Click += new System.EventHandler(this.tafBtnSuchen_Click);
            // 
            // tafLblVon
            // 
            this.tafLblVon.AutoSize = true;
            this.tafLblVon.Location = new System.Drawing.Point(26, 52);
            this.tafLblVon.Name = "tafLblVon";
            this.tafLblVon.Size = new System.Drawing.Size(56, 25);
            this.tafLblVon.TabIndex = 0;
            this.tafLblVon.Text = "Von:";
            // 
            // gbConnections
            // 
            this.gbConnections.Controls.Add(this.conCbBis);
            this.gbConnections.Controls.Add(this.conCbVon);
            this.gbConnections.Controls.Add(this.conBtnSuchen);
            this.gbConnections.Controls.Add(this.conDtpDateTime);
            this.gbConnections.Controls.Add(this.conLblDatumZeit);
            this.gbConnections.Controls.Add(this.conLblBis);
            this.gbConnections.Controls.Add(this.conLblVon);
            this.gbConnections.Location = new System.Drawing.Point(76, 153);
            this.gbConnections.Name = "gbConnections";
            this.gbConnections.Size = new System.Drawing.Size(826, 184);
            this.gbConnections.TabIndex = 12;
            this.gbConnections.TabStop = false;
            this.gbConnections.Text = "Verbindungen suchen";
            // 
            // conCbBis
            // 
            this.conCbBis.FormattingEnabled = true;
            this.conCbBis.Location = new System.Drawing.Point(507, 49);
            this.conCbBis.Name = "conCbBis";
            this.conCbBis.Size = new System.Drawing.Size(254, 33);
            this.conCbBis.TabIndex = 6;
            this.conCbBis.DropDown += new System.EventHandler(this.conCbBis_DropDown);
            // 
            // conCbVon
            // 
            this.conCbVon.FormattingEnabled = true;
            this.conCbVon.Location = new System.Drawing.Point(221, 49);
            this.conCbVon.Name = "conCbVon";
            this.conCbVon.Size = new System.Drawing.Size(236, 33);
            this.conCbVon.TabIndex = 5;
            this.conCbVon.DropDown += new System.EventHandler(this.conCbVon_DropDown);
            // 
            // conBtnSuchen
            // 
            this.conBtnSuchen.Location = new System.Drawing.Point(468, 106);
            this.conBtnSuchen.Name = "conBtnSuchen";
            this.conBtnSuchen.Size = new System.Drawing.Size(293, 40);
            this.conBtnSuchen.TabIndex = 4;
            this.conBtnSuchen.Text = "Suchen";
            this.conBtnSuchen.UseVisualStyleBackColor = true;
            this.conBtnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // conDtpDateTime
            // 
            this.conDtpDateTime.CustomFormat = "dd.MM.yy HH:mm";
            this.conDtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.conDtpDateTime.Location = new System.Drawing.Point(221, 109);
            this.conDtpDateTime.Name = "conDtpDateTime";
            this.conDtpDateTime.Size = new System.Drawing.Size(236, 31);
            this.conDtpDateTime.TabIndex = 3;
            // 
            // conLblDatumZeit
            // 
            this.conLblDatumZeit.AutoSize = true;
            this.conLblDatumZeit.Location = new System.Drawing.Point(26, 109);
            this.conLblDatumZeit.Name = "conLblDatumZeit";
            this.conLblDatumZeit.Size = new System.Drawing.Size(128, 25);
            this.conLblDatumZeit.TabIndex = 2;
            this.conLblDatumZeit.Text = "Datum / Zeit";
            // 
            // conLblBis
            // 
            this.conLblBis.AutoSize = true;
            this.conLblBis.Location = new System.Drawing.Point(463, 52);
            this.conLblBis.Name = "conLblBis";
            this.conLblBis.Size = new System.Drawing.Size(48, 25);
            this.conLblBis.TabIndex = 2;
            this.conLblBis.Text = "Bis:";
            // 
            // conLblVon
            // 
            this.conLblVon.AutoSize = true;
            this.conLblVon.Location = new System.Drawing.Point(26, 52);
            this.conLblVon.Name = "conLblVon";
            this.conLblVon.Size = new System.Drawing.Size(56, 25);
            this.conLblVon.TabIndex = 0;
            this.conLblVon.Text = "Von:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(199, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(583, 61);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Swiss Public Transport";
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.Name = "Ankunft";
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.Name = "Abfahrt";
            // 
            // Dauer
            // 
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.Name = "Dauer";
            // 
            // Bis
            // 
            this.Bis.HeaderText = "Bis";
            this.Bis.Name = "Bis";
            this.Bis.Width = 150;
            // 
            // Von
            // 
            this.Von.HeaderText = "Von";
            this.Von.Name = "Von";
            this.Von.Width = 150;
            // 
            // dgvVerbindungen
            // 
            this.dgvVerbindungen.AllowUserToOrderColumns = true;
            this.dgvVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Bis,
            this.Dauer,
            this.Abfahrt,
            this.Ankunft,
            this.Gleis});
            this.dgvVerbindungen.Location = new System.Drawing.Point(76, 588);
            this.dgvVerbindungen.Name = "dgvVerbindungen";
            this.dgvVerbindungen.RowTemplate.Height = 33;
            this.dgvVerbindungen.ShowRowErrors = false;
            this.dgvVerbindungen.Size = new System.Drawing.Size(826, 280);
            this.dgvVerbindungen.TabIndex = 16;
            // 
            // SPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 917);
            this.Controls.Add(this.dgvVerbindungen);
            this.Controls.Add(this.gbAbfahrtstafel);
            this.Controls.Add(this.gbConnections);
            this.Controls.Add(this.lblTitle);
            this.Name = "SPT";
            this.Text = "SPT";
            this.gbAbfahrtstafel.ResumeLayout(false);
            this.gbAbfahrtstafel.PerformLayout();
            this.gbConnections.ResumeLayout(false);
            this.gbConnections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAbfahrtstafel;
        private System.Windows.Forms.Button tafBtnSuchen;
        private System.Windows.Forms.Label tafLblVon;
        private System.Windows.Forms.GroupBox gbConnections;
        private System.Windows.Forms.Button conBtnSuchen;
        private System.Windows.Forms.DateTimePicker conDtpDateTime;
        private System.Windows.Forms.Label conLblDatumZeit;
        private System.Windows.Forms.Label conLblBis;
        private System.Windows.Forms.Label conLblVon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridView dgvVerbindungen;
        private System.Windows.Forms.ComboBox tafCbVon;
        private System.Windows.Forms.ComboBox conCbBis;
        private System.Windows.Forms.ComboBox conCbVon;
    }
}

