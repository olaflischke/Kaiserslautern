namespace EierfarmUi
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
            this.btnEiLegen = new System.Windows.Forms.Button();
            this.btnNeuesHuhn = new System.Windows.Forms.Button();
            this.btnFuettern = new System.Windows.Forms.Button();
            this.cbxTiere = new System.Windows.Forms.ComboBox();
            this.pgdTier = new System.Windows.Forms.PropertyGrid();
            this.btnNeueGans = new System.Windows.Forms.Button();
            this.btnNeuesSchnabeltier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEiLegen
            // 
            this.btnEiLegen.Location = new System.Drawing.Point(241, 142);
            this.btnEiLegen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEiLegen.Name = "btnEiLegen";
            this.btnEiLegen.Size = new System.Drawing.Size(99, 41);
            this.btnEiLegen.TabIndex = 0;
            this.btnEiLegen.Text = "Ei legen";
            this.btnEiLegen.UseVisualStyleBackColor = true;
            this.btnEiLegen.Click += new System.EventHandler(this.btnEiLegen_Click);
            // 
            // btnNeuesHuhn
            // 
            this.btnNeuesHuhn.Location = new System.Drawing.Point(241, 31);
            this.btnNeuesHuhn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNeuesHuhn.Name = "btnNeuesHuhn";
            this.btnNeuesHuhn.Size = new System.Drawing.Size(99, 41);
            this.btnNeuesHuhn.TabIndex = 1;
            this.btnNeuesHuhn.Text = "Huhn";
            this.btnNeuesHuhn.UseVisualStyleBackColor = true;
            this.btnNeuesHuhn.Click += new System.EventHandler(this.btnNeuesHuhn_Click);
            // 
            // btnFuettern
            // 
            this.btnFuettern.Location = new System.Drawing.Point(241, 89);
            this.btnFuettern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFuettern.Name = "btnFuettern";
            this.btnFuettern.Size = new System.Drawing.Size(99, 41);
            this.btnFuettern.TabIndex = 2;
            this.btnFuettern.Text = "Füttern";
            this.btnFuettern.UseVisualStyleBackColor = true;
            this.btnFuettern.Click += new System.EventHandler(this.btnFuettern_Click);
            // 
            // cbxTiere
            // 
            this.cbxTiere.DisplayMember = "Name";
            this.cbxTiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTiere.FormattingEnabled = true;
            this.cbxTiere.Location = new System.Drawing.Point(60, 41);
            this.cbxTiere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTiere.Name = "cbxTiere";
            this.cbxTiere.Size = new System.Drawing.Size(176, 24);
            this.cbxTiere.TabIndex = 3;
            this.cbxTiere.SelectedIndexChanged += new System.EventHandler(this.cbxTiere_SelectedIndexChanged);
            // 
            // pgdTier
            // 
            this.pgdTier.Location = new System.Drawing.Point(52, 75);
            this.pgdTier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgdTier.Name = "pgdTier";
            this.pgdTier.Size = new System.Drawing.Size(183, 222);
            this.pgdTier.TabIndex = 4;
            // 
            // btnNeueGans
            // 
            this.btnNeueGans.Location = new System.Drawing.Point(346, 31);
            this.btnNeueGans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNeueGans.Name = "btnNeueGans";
            this.btnNeueGans.Size = new System.Drawing.Size(99, 41);
            this.btnNeueGans.TabIndex = 5;
            this.btnNeueGans.Text = "Gans";
            this.btnNeueGans.UseVisualStyleBackColor = true;
            this.btnNeueGans.Click += new System.EventHandler(this.btnNeueGans_Click);
            // 
            // btnNeuesSchnabeltier
            // 
            this.btnNeuesSchnabeltier.Location = new System.Drawing.Point(451, 31);
            this.btnNeuesSchnabeltier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNeuesSchnabeltier.Name = "btnNeuesSchnabeltier";
            this.btnNeuesSchnabeltier.Size = new System.Drawing.Size(99, 41);
            this.btnNeuesSchnabeltier.TabIndex = 6;
            this.btnNeuesSchnabeltier.Text = "Schnabeltier";
            this.btnNeuesSchnabeltier.UseVisualStyleBackColor = true;
            this.btnNeuesSchnabeltier.Click += new System.EventHandler(this.btnNeuesSchnabeltier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 339);
            this.Controls.Add(this.btnNeuesSchnabeltier);
            this.Controls.Add(this.btnNeueGans);
            this.Controls.Add(this.pgdTier);
            this.Controls.Add(this.cbxTiere);
            this.Controls.Add(this.btnFuettern);
            this.Controls.Add(this.btnNeuesHuhn);
            this.Controls.Add(this.btnEiLegen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Eierfarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEiLegen;
        private System.Windows.Forms.Button btnNeuesHuhn;
        private System.Windows.Forms.Button btnFuettern;
        private System.Windows.Forms.ComboBox cbxTiere;
        private System.Windows.Forms.PropertyGrid pgdTier;
        private System.Windows.Forms.Button btnNeueGans;
        private System.Windows.Forms.Button btnNeuesSchnabeltier;
    }
}

