namespace piumettiEsercizioTrigger
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStorico = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeAdd = new System.Windows.Forms.TextBox();
            this.txtCognomeAdd = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.pnlSeparatore = new System.Windows.Forms.Panel();
            this.btnModifica = new System.Windows.Forms.Button();
            this.txtModificaCognome = new System.Windows.Forms.TextBox();
            this.txtModificaNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancella = new System.Windows.Forms.Button();
            this.dgvAgg = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgg)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienti
            // 
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(17, 41);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.Size = new System.Drawing.Size(472, 442);
            this.dgvClienti.TabIndex = 0;
            this.dgvClienti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienti_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clienti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Storico";
            // 
            // dgvStorico
            // 
            this.dgvStorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorico.Location = new System.Drawing.Point(559, 41);
            this.dgvStorico.Name = "dgvStorico";
            this.dgvStorico.Size = new System.Drawing.Size(560, 442);
            this.dgvStorico.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cognome:";
            // 
            // txtNomeAdd
            // 
            this.txtNomeAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAdd.Location = new System.Drawing.Point(117, 517);
            this.txtNomeAdd.Name = "txtNomeAdd";
            this.txtNomeAdd.Size = new System.Drawing.Size(100, 27);
            this.txtNomeAdd.TabIndex = 6;
            // 
            // txtCognomeAdd
            // 
            this.txtCognomeAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCognomeAdd.Location = new System.Drawing.Point(117, 559);
            this.txtCognomeAdd.Name = "txtCognomeAdd";
            this.txtCognomeAdd.Size = new System.Drawing.Size(100, 27);
            this.txtCognomeAdd.TabIndex = 7;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(14, 598);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(203, 38);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "Aggiungi cliente";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // pnlSeparatore
            // 
            this.pnlSeparatore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparatore.BackColor = System.Drawing.Color.Gray;
            this.pnlSeparatore.Location = new System.Drawing.Point(-1, 489);
            this.pnlSeparatore.Name = "pnlSeparatore";
            this.pnlSeparatore.Size = new System.Drawing.Size(1704, 13);
            this.pnlSeparatore.TabIndex = 9;
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(324, 598);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(203, 38);
            this.btnModifica.TabIndex = 14;
            this.btnModifica.Text = "Modifica cliente selezionato";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // txtModificaCognome
            // 
            this.txtModificaCognome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificaCognome.Location = new System.Drawing.Point(427, 559);
            this.txtModificaCognome.Name = "txtModificaCognome";
            this.txtModificaCognome.Size = new System.Drawing.Size(100, 27);
            this.txtModificaCognome.TabIndex = 13;
            // 
            // txtModificaNome
            // 
            this.txtModificaNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificaNome.Location = new System.Drawing.Point(427, 517);
            this.txtModificaNome.Name = "txtModificaNome";
            this.txtModificaNome.Size = new System.Drawing.Size(100, 27);
            this.txtModificaNome.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cognome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nome:";
            // 
            // btnCancella
            // 
            this.btnCancella.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancella.Location = new System.Drawing.Point(599, 517);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(203, 119);
            this.btnCancella.TabIndex = 19;
            this.btnCancella.Text = "Cancella cliente selezionato";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // dgvAgg
            // 
            this.dgvAgg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgg.Location = new System.Drawing.Point(1125, 41);
            this.dgvAgg.Name = "dgvAgg";
            this.dgvAgg.Size = new System.Drawing.Size(560, 442);
            this.dgvAgg.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1120, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Aggiornamenti";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 648);
            this.Controls.Add(this.dgvAgg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.txtModificaCognome);
            this.Controls.Add(this.txtModificaNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlSeparatore);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtCognomeAdd);
            this.Controls.Add(this.txtNomeAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvStorico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClienti);
            this.Name = "frmMain";
            this.Text = "Esercizio Trigger";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStorico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeAdd;
        private System.Windows.Forms.TextBox txtCognomeAdd;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Panel pnlSeparatore;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TextBox txtModificaCognome;
        private System.Windows.Forms.TextBox txtModificaNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.DataGridView dgvAgg;
        private System.Windows.Forms.Label label7;
    }
}

