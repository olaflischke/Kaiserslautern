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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEiLegen
            // 
            this.btnEiLegen.Location = new System.Drawing.Point(362, 222);
            this.btnEiLegen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEiLegen.Name = "btnEiLegen";
            this.btnEiLegen.Size = new System.Drawing.Size(148, 64);
            this.btnEiLegen.TabIndex = 0;
            this.btnEiLegen.Text = "Ei legen";
            this.btnEiLegen.UseVisualStyleBackColor = true;
            this.btnEiLegen.Click += new System.EventHandler(this.btnEiLegen_Click);
            // 
            // btnNeuesHuhn
            // 
            this.btnNeuesHuhn.Location = new System.Drawing.Point(362, 48);
            this.btnNeuesHuhn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNeuesHuhn.Name = "btnNeuesHuhn";
            this.btnNeuesHuhn.Size = new System.Drawing.Size(148, 64);
            this.btnNeuesHuhn.TabIndex = 1;
            this.btnNeuesHuhn.Text = "Huhn";
            this.btnNeuesHuhn.UseVisualStyleBackColor = true;
            this.btnNeuesHuhn.Click += new System.EventHandler(this.btnNeuesHuhn_Click);
            // 
            // btnFuettern
            // 
            this.btnFuettern.Location = new System.Drawing.Point(362, 139);
            this.btnFuettern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFuettern.Name = "btnFuettern";
            this.btnFuettern.Size = new System.Drawing.Size(148, 64);
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
            this.cbxTiere.Location = new System.Drawing.Point(90, 64);
            this.cbxTiere.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxTiere.Name = "cbxTiere";
            this.cbxTiere.Size = new System.Drawing.Size(262, 33);
            this.cbxTiere.TabIndex = 3;
            this.cbxTiere.SelectedIndexChanged += new System.EventHandler(this.cbxTiere_SelectedIndexChanged);
            // 
            // pgdTier
            // 
            this.pgdTier.Location = new System.Drawing.Point(78, 117);
            this.pgdTier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pgdTier.Name = "pgdTier";
            this.pgdTier.Size = new System.Drawing.Size(274, 347);
            this.pgdTier.TabIndex = 4;
            // 
            // btnNeueGans
            // 
            this.btnNeueGans.Location = new System.Drawing.Point(519, 48);
            this.btnNeueGans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNeueGans.Name = "btnNeueGans";
            this.btnNeueGans.Size = new System.Drawing.Size(148, 64);
            this.btnNeueGans.TabIndex = 5;
            this.btnNeueGans.Text = "Gans";
            this.btnNeueGans.UseVisualStyleBackColor = true;
            this.btnNeueGans.Click += new System.EventHandler(this.btnNeueGans_Click);
            // 
            // btnNeuesSchnabeltier
            // 
            this.btnNeuesSchnabeltier.Location = new System.Drawing.Point(676, 48);
            this.btnNeuesSchnabeltier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNeuesSchnabeltier.Name = "btnNeuesSchnabeltier";
            this.btnNeuesSchnabeltier.Size = new System.Drawing.Size(148, 64);
            this.btnNeuesSchnabeltier.TabIndex = 6;
            this.btnNeuesSchnabeltier.Text = "Schnabeltier";
            this.btnNeuesSchnabeltier.UseVisualStyleBackColor = true;
            this.btnNeuesSchnabeltier.Click += new System.EventHandler(this.btnNeuesSchnabeltier_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "Laden";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 267);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 530);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNeuesSchnabeltier);
            this.Controls.Add(this.btnNeueGans);
            this.Controls.Add(this.pgdTier);
            this.Controls.Add(this.cbxTiere);
            this.Controls.Add(this.btnFuettern);
            this.Controls.Add(this.btnNeuesHuhn);
            this.Controls.Add(this.btnEiLegen);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

