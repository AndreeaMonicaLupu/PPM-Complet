namespace Proiect_SOAC
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
            this.btnSort = new System.Windows.Forms.Button();
            this.checkPredictor = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chechHRg = new System.Windows.Forms.CheckedListBox();
            this.checkBitiPredictie = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblAcuratete = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.btnPerm = new System.Windows.Forms.Button();
            this.btnPuzzle = new System.Windows.Forms.Button();
            this.btnQueens = new System.Windows.Forms.Button();
            this.btnTower = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.pnlAcuratete = new System.Windows.Forms.Panel();
            this.txtTotalSalturi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rchCorecte = new System.Windows.Forms.RichTextBox();
            this.rchIncProc = new System.Windows.Forms.RichTextBox();
            this.rchIncorecte = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.rchTrace = new System.Windows.Forms.RichTextBox();
            this.rchActHRg = new System.Windows.Forms.Label();
            this.rchPredictie = new System.Windows.Forms.Label();
            this.procentaj = new System.Windows.Forms.Label();
            this.rchHRg = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.rchTotal = new System.Windows.Forms.RichTextBox();
            this.rchCorecteProc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAcuratete.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSort.Location = new System.Drawing.Point(37, 62);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(108, 28);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "FSORT";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // checkPredictor
            // 
            this.checkPredictor.AllowDrop = true;
            this.checkPredictor.FormattingEnabled = true;
            this.checkPredictor.Items.AddRange(new object[] {
            "Complet",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.checkPredictor.Location = new System.Drawing.Point(191, 69);
            this.checkPredictor.Name = "checkPredictor";
            this.checkPredictor.Size = new System.Drawing.Size(109, 191);
            this.checkPredictor.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tip predictor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dimensiune HRg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Biti predictie";
            // 
            // chechHRg
            // 
            this.chechHRg.AllowDrop = true;
            this.chechHRg.FormattingEnabled = true;
            this.chechHRg.Items.AddRange(new object[] {
            "30",
            "40",
            "50",
            "100",
            "200",
            "300",
            "500"});
            this.chechHRg.Location = new System.Drawing.Point(189, 291);
            this.chechHRg.Name = "chechHRg";
            this.chechHRg.Size = new System.Drawing.Size(132, 38);
            this.chechHRg.TabIndex = 17;
            this.chechHRg.Click += new System.EventHandler(this.chechHRg_Click);
            this.chechHRg.SelectedIndexChanged += new System.EventHandler(this.chechHRg_SelectedIndexChanged);
            // 
            // checkBitiPredictie
            // 
            this.checkBitiPredictie.FormattingEnabled = true;
            this.checkBitiPredictie.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "8",
            "16",
            "32"});
            this.checkBitiPredictie.Location = new System.Drawing.Point(189, 362);
            this.checkBitiPredictie.Name = "checkBitiPredictie";
            this.checkBitiPredictie.Size = new System.Drawing.Size(132, 38);
            this.checkBitiPredictie.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(259, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "ACURATETE";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(685, 36);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblAcuratete
            // 
            this.lblAcuratete.AutoSize = true;
            this.lblAcuratete.Location = new System.Drawing.Point(380, 5);
            this.lblAcuratete.Name = "lblAcuratete";
            this.lblAcuratete.Size = new System.Drawing.Size(64, 17);
            this.lblAcuratete.TabIndex = 21;
            this.lblAcuratete.Text = "_______";
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.Color.Teal;
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveData.Location = new System.Drawing.Point(52, 342);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(78, 46);
            this.btnSaveData.TabIndex = 23;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBubble.Location = new System.Drawing.Point(37, 96);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(108, 28);
            this.btnBubble.TabIndex = 24;
            this.btnBubble.Text = "FBUBBLE";
            this.btnBubble.UseVisualStyleBackColor = false;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnMatrix
            // 
            this.btnMatrix.BackColor = System.Drawing.Color.PeachPuff;
            this.btnMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMatrix.Location = new System.Drawing.Point(37, 130);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(108, 28);
            this.btnMatrix.TabIndex = 25;
            this.btnMatrix.Text = "FMATRIX";
            this.btnMatrix.UseVisualStyleBackColor = false;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // btnPerm
            // 
            this.btnPerm.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPerm.Location = new System.Drawing.Point(37, 164);
            this.btnPerm.Name = "btnPerm";
            this.btnPerm.Size = new System.Drawing.Size(108, 28);
            this.btnPerm.TabIndex = 26;
            this.btnPerm.Text = "FPERM";
            this.btnPerm.UseVisualStyleBackColor = false;
            this.btnPerm.Click += new System.EventHandler(this.btnPerm_Click);
            // 
            // btnPuzzle
            // 
            this.btnPuzzle.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPuzzle.Location = new System.Drawing.Point(37, 198);
            this.btnPuzzle.Name = "btnPuzzle";
            this.btnPuzzle.Size = new System.Drawing.Size(108, 28);
            this.btnPuzzle.TabIndex = 27;
            this.btnPuzzle.Text = "FPUZZLE";
            this.btnPuzzle.UseVisualStyleBackColor = false;
            this.btnPuzzle.Click += new System.EventHandler(this.btnPuzzle_Click);
            // 
            // btnQueens
            // 
            this.btnQueens.BackColor = System.Drawing.Color.PeachPuff;
            this.btnQueens.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnQueens.Location = new System.Drawing.Point(37, 232);
            this.btnQueens.Name = "btnQueens";
            this.btnQueens.Size = new System.Drawing.Size(108, 28);
            this.btnQueens.TabIndex = 28;
            this.btnQueens.Text = "FQUEENS";
            this.btnQueens.UseVisualStyleBackColor = false;
            this.btnQueens.Click += new System.EventHandler(this.btnQueens_Click);
            // 
            // btnTower
            // 
            this.btnTower.BackColor = System.Drawing.Color.PeachPuff;
            this.btnTower.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTower.Location = new System.Drawing.Point(37, 266);
            this.btnTower.Name = "btnTower";
            this.btnTower.Size = new System.Drawing.Size(108, 28);
            this.btnTower.TabIndex = 29;
            this.btnTower.Text = "FTOWER";
            this.btnTower.UseVisualStyleBackColor = false;
            this.btnTower.Click += new System.EventHandler(this.btnTower_Click);
            // 
            // btnTree
            // 
            this.btnTree.BackColor = System.Drawing.Color.PeachPuff;
            this.btnTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTree.Location = new System.Drawing.Point(37, 300);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(108, 28);
            this.btnTree.TabIndex = 30;
            this.btnTree.Text = "FTREE";
            this.btnTree.UseVisualStyleBackColor = false;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // pnlAcuratete
            // 
            this.pnlAcuratete.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlAcuratete.Controls.Add(this.progressBar1);
            this.pnlAcuratete.Controls.Add(this.label11);
            this.pnlAcuratete.Controls.Add(this.lblAcuratete);
            this.pnlAcuratete.Location = new System.Drawing.Point(363, 362);
            this.pnlAcuratete.Name = "pnlAcuratete";
            this.pnlAcuratete.Size = new System.Drawing.Size(727, 69);
            this.pnlAcuratete.TabIndex = 32;
            // 
            // txtTotalSalturi
            // 
            this.txtTotalSalturi.Location = new System.Drawing.Point(205, 413);
            this.txtTotalSalturi.Name = "txtTotalSalturi";
            this.txtTotalSalturi.Size = new System.Drawing.Size(78, 22);
            this.txtTotalSalturi.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(177, 438);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 17);
            this.label15.TabIndex = 37;
            this.label15.Text = "Numar total de salturi";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rchCorecteProc);
            this.panel3.Controls.Add(this.rchTotal);
            this.panel3.Controls.Add(this.rchCorecte);
            this.panel3.Controls.Add(this.rchIncProc);
            this.panel3.Controls.Add(this.rchIncorecte);
            this.panel3.Controls.Add(this.richTextBox7);
            this.panel3.Controls.Add(this.rchTrace);
            this.panel3.Controls.Add(this.rchActHRg);
            this.panel3.Controls.Add(this.rchPredictie);
            this.panel3.Controls.Add(this.procentaj);
            this.panel3.Controls.Add(this.rchHRg);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(363, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 297);
            this.panel3.TabIndex = 38;
            // 
            // rchCorecte
            // 
            this.rchCorecte.Location = new System.Drawing.Point(380, 20);
            this.rchCorecte.Name = "rchCorecte";
            this.rchCorecte.Size = new System.Drawing.Size(102, 271);
            this.rchCorecte.TabIndex = 28;
            this.rchCorecte.Text = "";
            // 
            // rchIncProc
            // 
            this.rchIncProc.Location = new System.Drawing.Point(298, 21);
            this.rchIncProc.Name = "rchIncProc";
            this.rchIncProc.Size = new System.Drawing.Size(76, 271);
            this.rchIncProc.TabIndex = 26;
            this.rchIncProc.Text = "";
            // 
            // rchIncorecte
            // 
            this.rchIncorecte.Location = new System.Drawing.Point(201, 21);
            this.rchIncorecte.Name = "rchIncorecte";
            this.rchIncorecte.Size = new System.Drawing.Size(91, 271);
            this.rchIncorecte.TabIndex = 24;
            this.rchIncorecte.Text = "";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(115, 20);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(80, 271);
            this.richTextBox7.TabIndex = 25;
            this.richTextBox7.Text = "";
            // 
            // rchTrace
            // 
            this.rchTrace.Location = new System.Drawing.Point(3, 21);
            this.rchTrace.Name = "rchTrace";
            this.rchTrace.Size = new System.Drawing.Size(105, 270);
            this.rchTrace.TabIndex = 19;
            this.rchTrace.Text = "";
            // 
            // rchActHRg
            // 
            this.rchActHRg.AutoSize = true;
            this.rchActHRg.Location = new System.Drawing.Point(397, 1);
            this.rchActHRg.Name = "rchActHRg";
            this.rchActHRg.Size = new System.Drawing.Size(57, 17);
            this.rchActHRg.TabIndex = 17;
            this.rchActHRg.Text = "Corecte";
            // 
            // rchPredictie
            // 
            this.rchPredictie.AutoSize = true;
            this.rchPredictie.Location = new System.Drawing.Point(215, 1);
            this.rchPredictie.Name = "rchPredictie";
            this.rchPredictie.Size = new System.Drawing.Size(66, 17);
            this.rchPredictie.TabIndex = 15;
            this.rchPredictie.Text = "Incorecte";
            // 
            // procentaj
            // 
            this.procentaj.AutoSize = true;
            this.procentaj.Location = new System.Drawing.Point(317, 1);
            this.procentaj.Name = "procentaj";
            this.procentaj.Size = new System.Drawing.Size(28, 17);
            this.procentaj.TabIndex = 14;
            this.procentaj.Text = "[%]";
            this.procentaj.Click += new System.EventHandler(this.Corect_Click);
            // 
            // rchHRg
            // 
            this.rchHRg.AutoSize = true;
            this.rchHRg.Location = new System.Drawing.Point(135, 5);
            this.rchHRg.Name = "rchHRg";
            this.rchHRg.Size = new System.Drawing.Size(36, 17);
            this.rchHRg.TabIndex = 0;
            this.rchHRg.Text = "HRg";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 17);
            this.label21.TabIndex = 13;
            this.label21.Text = "Trace";
            // 
            // rchTotal
            // 
            this.rchTotal.Location = new System.Drawing.Point(566, 21);
            this.rchTotal.Name = "rchTotal";
            this.rchTotal.Size = new System.Drawing.Size(140, 271);
            this.rchTotal.TabIndex = 29;
            this.rchTotal.Text = "";
            this.rchTotal.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // rchCorecteProc
            // 
            this.rchCorecteProc.Location = new System.Drawing.Point(488, 20);
            this.rchCorecteProc.Name = "rchCorecteProc";
            this.rchCorecteProc.Size = new System.Drawing.Size(72, 271);
            this.rchCorecteProc.TabIndex = 31;
            this.rchCorecteProc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "[%]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1266, 466);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotalSalturi);
            this.Controls.Add(this.pnlAcuratete);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnTower);
            this.Controls.Add(this.btnQueens);
            this.Controls.Add(this.btnPuzzle);
            this.Controls.Add(this.btnPerm);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.checkBitiPredictie);
            this.Controls.Add(this.chechHRg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkPredictor);
            this.Controls.Add(this.btnSort);
            this.Name = "Form1";
            this.Text = "PPM predictor";
            this.pnlAcuratete.ResumeLayout(false);
            this.pnlAcuratete.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox chechHRg;
        private System.Windows.Forms.CheckedListBox checkBitiPredictie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckedListBox checkPredictor;
        private System.Windows.Forms.Label lblAcuratete;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.Button btnPerm;
        private System.Windows.Forms.Button btnPuzzle;
        private System.Windows.Forms.Button btnQueens;
        private System.Windows.Forms.Button btnTower;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Panel pnlAcuratete;
        private System.Windows.Forms.TextBox txtTotalSalturi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rchCorecte;
        private System.Windows.Forms.RichTextBox rchIncProc;
        private System.Windows.Forms.RichTextBox rchIncorecte;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox rchTrace;
        private System.Windows.Forms.Label rchActHRg;
        private System.Windows.Forms.Label rchPredictie;
        private System.Windows.Forms.Label procentaj;
        private System.Windows.Forms.Label rchHRg;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox rchTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchCorecteProc;
        private System.Windows.Forms.Label label2;
    }
}

