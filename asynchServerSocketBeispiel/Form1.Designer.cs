namespace asynchServerSocketBeispiel {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.startButton = new System.Windows.Forms.Button();
            this.peersListe = new System.Windows.Forms.ListView();
            this.IdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OSCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatusText = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(472, 236);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // peersListe
            // 
            this.peersListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCol,
            this.NameCol,
            this.IPCol,
            this.OSCol});
            this.peersListe.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.peersListe.Location = new System.Drawing.Point(10, 11);
            this.peersListe.MultiSelect = false;
            this.peersListe.Name = "peersListe";
            this.peersListe.Size = new System.Drawing.Size(456, 437);
            this.peersListe.TabIndex = 5;
            this.peersListe.UseCompatibleStateImageBehavior = false;
            this.peersListe.View = System.Windows.Forms.View.Details;
            // 
            // IdCol
            // 
            this.IdCol.Text = "ID";
            this.IdCol.Width = 100;
            // 
            // NameCol
            // 
            this.NameCol.Text = "Name";
            this.NameCol.Width = 100;
            // 
            // IPCol
            // 
            this.IPCol.Text = "IP";
            this.IPCol.Width = 100;
            // 
            // OSCol
            // 
            this.OSCol.Text = "OS";
            this.OSCol.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.StatusText);
            this.groupBox1.Controls.Add(this.StatusLabel);
            this.groupBox1.Location = new System.Drawing.Point(472, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 220);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.ForeColor = System.Drawing.Color.Red;
            this.StatusText.Location = new System.Drawing.Point(6, 52);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(74, 25);
            this.StatusText.TabIndex = 1;
            this.StatusText.Text = "Offline";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(6, 16);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(79, 25);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 460);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.peersListe);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(999, 499);
            this.MinimumSize = new System.Drawing.Size(999, 499);
            this.Name = "Form1";
            this.Text = "P2P Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button startButton;
        public System.Windows.Forms.ListView peersListe;
        private System.Windows.Forms.ColumnHeader IdCol;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader IPCol;
        private System.Windows.Forms.ColumnHeader OSCol;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Label StatusLabel;
    }
}

