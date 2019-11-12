namespace WindowsFormsAppWisielec
{
    partial class FormGra
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.textBoxWzorzec = new System.Windows.Forms.TextBox();
            this.panelWprowadzenie = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLitera = new System.Windows.Forms.TextBox();
            this.buttonWyslij = new System.Windows.Forms.Button();
            this.labelWzorzec = new System.Windows.Forms.Label();
            this.buttonPoddaj = new System.Windows.Forms.Button();
            this.pictureBoxSzubienica = new System.Windows.Forms.PictureBox();
            this.panelWprowadzenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSzubienica)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(61, 39);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(125, 38);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxWzorzec
            // 
            this.textBoxWzorzec.Enabled = false;
            this.textBoxWzorzec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWzorzec.Location = new System.Drawing.Point(57, 424);
            this.textBoxWzorzec.Name = "textBoxWzorzec";
            this.textBoxWzorzec.Size = new System.Drawing.Size(229, 29);
            this.textBoxWzorzec.TabIndex = 2;
            this.textBoxWzorzec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelWprowadzenie
            // 
            this.panelWprowadzenie.Controls.Add(this.buttonWyslij);
            this.panelWprowadzenie.Controls.Add(this.textBoxLitera);
            this.panelWprowadzenie.Controls.Add(this.label1);
            this.panelWprowadzenie.Location = new System.Drawing.Point(61, 476);
            this.panelWprowadzenie.Name = "panelWprowadzenie";
            this.panelWprowadzenie.Size = new System.Drawing.Size(199, 56);
            this.panelWprowadzenie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj literę";
            // 
            // textBoxLitera
            // 
            this.textBoxLitera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLitera.Location = new System.Drawing.Point(68, 22);
            this.textBoxLitera.MaxLength = 1;
            this.textBoxLitera.Name = "textBoxLitera";
            this.textBoxLitera.Size = new System.Drawing.Size(19, 20);
            this.textBoxLitera.TabIndex = 1;
            // 
            // buttonWyslij
            // 
            this.buttonWyslij.Location = new System.Drawing.Point(109, 20);
            this.buttonWyslij.Name = "buttonWyslij";
            this.buttonWyslij.Size = new System.Drawing.Size(75, 23);
            this.buttonWyslij.TabIndex = 2;
            this.buttonWyslij.Text = "Wyślij";
            this.buttonWyslij.UseVisualStyleBackColor = true;
            this.buttonWyslij.Click += new System.EventHandler(this.buttonWyslij_Click);
            // 
            // labelWzorzec
            // 
            this.labelWzorzec.AutoSize = true;
            this.labelWzorzec.Location = new System.Drawing.Point(2, 435);
            this.labelWzorzec.Name = "labelWzorzec";
            this.labelWzorzec.Size = new System.Drawing.Size(49, 13);
            this.labelWzorzec.TabIndex = 9;
            this.labelWzorzec.Text = "Wzorzec";
            // 
            // buttonPoddaj
            // 
            this.buttonPoddaj.Location = new System.Drawing.Point(413, 39);
            this.buttonPoddaj.Name = "buttonPoddaj";
            this.buttonPoddaj.Size = new System.Drawing.Size(83, 27);
            this.buttonPoddaj.TabIndex = 10;
            this.buttonPoddaj.Text = "Poddaj się";
            this.buttonPoddaj.UseVisualStyleBackColor = true;
            this.buttonPoddaj.Click += new System.EventHandler(this.buttonPoddaj_Click);
            // 
            // pictureBoxSzubienica
            // 
            this.pictureBoxSzubienica.Image = global::WindowsFormsAppWisielec.Properties.Resources.Szubienica;
            this.pictureBoxSzubienica.InitialImage = global::WindowsFormsAppWisielec.Properties.Resources.Szubienica;
            this.pictureBoxSzubienica.Location = new System.Drawing.Point(61, 100);
            this.pictureBoxSzubienica.Name = "pictureBoxSzubienica";
            this.pictureBoxSzubienica.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxSzubienica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSzubienica.TabIndex = 1;
            this.pictureBoxSzubienica.TabStop = false;
            // 
            // FormGra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 661);
            this.Controls.Add(this.buttonPoddaj);
            this.Controls.Add(this.labelWzorzec);
            this.Controls.Add(this.panelWprowadzenie);
            this.Controls.Add(this.textBoxWzorzec);
            this.Controls.Add(this.pictureBoxSzubienica);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "FormGra";
            this.Text = "Wisielec";
            this.panelWprowadzenie.ResumeLayout(false);
            this.panelWprowadzenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSzubienica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.PictureBox pictureBoxSzubienica;
        private System.Windows.Forms.TextBox textBoxWzorzec;
        private System.Windows.Forms.Panel panelWprowadzenie;
        private System.Windows.Forms.Button buttonWyslij;
        private System.Windows.Forms.TextBox textBoxLitera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWzorzec;
        private System.Windows.Forms.Button buttonPoddaj;
    }
}

