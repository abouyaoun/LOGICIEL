
namespace LLWS.UserInterface.infoUtilisateur
{
    partial class infoUtilisateur
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
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_dateinscri = new System.Windows.Forms.Label();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_budget = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_mail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_mail.Location = new System.Drawing.Point(42, 151);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(66, 35);
            this.lbl_mail.TabIndex = 0;
            this.lbl_mail.Text = "Mail";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_nom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nom.Location = new System.Drawing.Point(42, 92);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(73, 35);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "Nom";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_prenom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_prenom.Location = new System.Drawing.Point(42, 37);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(107, 35);
            this.lbl_prenom.TabIndex = 2;
            this.lbl_prenom.Text = "Prenom";
            // 
            // lbl_dateinscri
            // 
            this.lbl_dateinscri.AutoSize = true;
            this.lbl_dateinscri.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_dateinscri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dateinscri.Location = new System.Drawing.Point(42, 211);
            this.lbl_dateinscri.Name = "lbl_dateinscri";
            this.lbl_dateinscri.Size = new System.Drawing.Size(214, 35);
            this.lbl_dateinscri.TabIndex = 3;
            this.lbl_dateinscri.Text = "Date d\'insciption";
            // 
            // lbl_grade
            // 
            this.lbl_grade.AutoSize = true;
            this.lbl_grade.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_grade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_grade.Location = new System.Drawing.Point(42, 262);
            this.lbl_grade.Name = "lbl_grade";
            this.lbl_grade.Size = new System.Drawing.Size(85, 35);
            this.lbl_grade.TabIndex = 4;
            this.lbl_grade.Text = "Grade";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_budget);
            this.panel1.Controls.Add(this.lbl_grade);
            this.panel1.Controls.Add(this.lbl_dateinscri);
            this.panel1.Controls.Add(this.lbl_prenom);
            this.panel1.Controls.Add(this.lbl_nom);
            this.panel1.Controls.Add(this.lbl_mail);
            this.panel1.Location = new System.Drawing.Point(24, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 408);
            this.panel1.TabIndex = 10;
            // 
            // lbl_budget
            // 
            this.lbl_budget.AutoSize = true;
            this.lbl_budget.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_budget.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_budget.Location = new System.Drawing.Point(42, 330);
            this.lbl_budget.Name = "lbl_budget";
            this.lbl_budget.Size = new System.Drawing.Size(134, 44);
            this.lbl_budget.TabIndex = 5;
            this.lbl_budget.Text = "Budget ";
            // 
            // infoUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 946);
            this.Controls.Add(this.panel1);
            this.Name = "infoUtilisateur";
            this.Text = "infoUtilisateur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_dateinscri;
        private System.Windows.Forms.Label lbl_grade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_budget;
    }
}