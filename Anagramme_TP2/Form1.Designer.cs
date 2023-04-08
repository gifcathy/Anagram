namespace Anagramme_TP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTester = new Button();
            btnRejouer = new Button();
            btnQuitter = new Button();
            gbPropo = new GroupBox();
            txtPropo = new TextBox();
            gbHist = new GroupBox();
            lbxHistorique = new ListBox();
            gbEssais = new GroupBox();
            labNB = new Label();
            labEssaisP = new Label();
            labNbER = new Label();
            lbxEssais = new ListBox();
            labMD = new Label();
            labMot = new Label();
            gbPropo.SuspendLayout();
            gbHist.SuspendLayout();
            gbEssais.SuspendLayout();
            SuspendLayout();
            // 
            // btnTester
            // 
            btnTester.Enabled = false;
            btnTester.Location = new Point(228, 47);
            btnTester.Name = "btnTester";
            btnTester.Size = new Size(75, 32);
            btnTester.TabIndex = 0;
            btnTester.Text = "Tester";
            btnTester.UseVisualStyleBackColor = true;
            btnTester.Click += btnTester_Click;
            // 
            // btnRejouer
            // 
            btnRejouer.Location = new Point(476, 332);
            btnRejouer.Name = "btnRejouer";
            btnRejouer.Size = new Size(75, 39);
            btnRejouer.TabIndex = 1;
            btnRejouer.Text = "Rejouer";
            btnRejouer.UseVisualStyleBackColor = true;
            btnRejouer.Click += btnRejouer_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(608, 332);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(75, 39);
            btnQuitter.TabIndex = 2;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // gbPropo
            // 
            gbPropo.Controls.Add(txtPropo);
            gbPropo.Controls.Add(btnTester);
            gbPropo.Location = new Point(59, 106);
            gbPropo.Name = "gbPropo";
            gbPropo.Size = new Size(333, 116);
            gbPropo.TabIndex = 3;
            gbPropo.TabStop = false;
            gbPropo.Text = "Proposition";
            // 
            // txtPropo
            // 
            txtPropo.Location = new Point(15, 53);
            txtPropo.Name = "txtPropo";
            txtPropo.Size = new Size(170, 23);
            txtPropo.TabIndex = 1;
            txtPropo.TextChanged += txtPropo_TextChanged;
            // 
            // gbHist
            // 
            gbHist.Controls.Add(lbxHistorique);
            gbHist.Location = new Point(442, 106);
            gbHist.Name = "gbHist";
            gbHist.Size = new Size(287, 178);
            gbHist.TabIndex = 4;
            gbHist.TabStop = false;
            gbHist.Text = "Historique des parties";
            // 
            // lbxHistorique
            // 
            lbxHistorique.FormattingEnabled = true;
            lbxHistorique.ItemHeight = 15;
            lbxHistorique.Location = new Point(17, 38);
            lbxHistorique.Name = "lbxHistorique";
            lbxHistorique.Size = new Size(254, 124);
            lbxHistorique.TabIndex = 0;
            // 
            // gbEssais
            // 
            gbEssais.Controls.Add(labNB);
            gbEssais.Controls.Add(labEssaisP);
            gbEssais.Controls.Add(labNbER);
            gbEssais.Controls.Add(lbxEssais);
            gbEssais.Location = new Point(59, 241);
            gbEssais.Name = "gbEssais";
            gbEssais.Size = new Size(333, 204);
            gbEssais.TabIndex = 5;
            gbEssais.TabStop = false;
            gbEssais.Text = "Essais";
            // 
            // labNB
            // 
            labNB.Location = new Point(154, 38);
            labNB.Name = "labNB";
            labNB.Size = new Size(100, 23);
            labNB.TabIndex = 3;
            // 
            // labEssaisP
            // 
            labEssaisP.AutoSize = true;
            labEssaisP.Location = new Point(15, 67);
            labEssaisP.Name = "labEssaisP";
            labEssaisP.Size = new Size(104, 15);
            labEssaisP.TabIndex = 2;
            labEssaisP.Text = "Essais précédents :";
            // 
            // labNbER
            // 
            labNbER.AutoSize = true;
            labNbER.Location = new Point(15, 38);
            labNbER.Name = "labNbER";
            labNbER.Size = new Size(139, 15);
            labNbER.TabIndex = 1;
            labNbER.Text = "Nombre d'essais restant :";
            // 
            // lbxEssais
            // 
            lbxEssais.FormattingEnabled = true;
            lbxEssais.ItemHeight = 15;
            lbxEssais.Location = new Point(15, 94);
            lbxEssais.Name = "lbxEssais";
            lbxEssais.Size = new Size(301, 94);
            lbxEssais.TabIndex = 0;
            // 
            // labMD
            // 
            labMD.AutoSize = true;
            labMD.Location = new Point(59, 19);
            labMD.Name = "labMD";
            labMD.Size = new Size(86, 15);
            labMD.TabIndex = 6;
            labMD.Text = "Mot à deviner :";
            // 
            // labMot
            // 
            labMot.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labMot.Location = new Point(59, 47);
            labMot.Name = "labMot";
            labMot.Size = new Size(143, 45);
            labMot.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 457);
            Controls.Add(labMot);
            Controls.Add(labMD);
            Controls.Add(gbEssais);
            Controls.Add(gbHist);
            Controls.Add(btnQuitter);
            Controls.Add(btnRejouer);
            Controls.Add(gbPropo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbPropo.ResumeLayout(false);
            gbPropo.PerformLayout();
            gbHist.ResumeLayout(false);
            gbEssais.ResumeLayout(false);
            gbEssais.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTester;
        private Button btnRejouer;
        private Button btnQuitter;
        private GroupBox gbPropo;
        private TextBox txtPropo;
        private GroupBox gbHist;
        private ListBox lbxHistorique;
        private GroupBox gbEssais;
        private Label labEssaisP;
        private Label labNbER;
        private ListBox lbxEssais;
        private Label labMD;
        private Label labMot;
        private Label labNB;
    }
}