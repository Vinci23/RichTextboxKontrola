namespace RichTextboxKontrola
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
            this.buttonCitaj = new System.Windows.Forms.Button();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonCitaj
            // 
            this.buttonCitaj.Location = new System.Drawing.Point(55, 49);
            this.buttonCitaj.Name = "buttonCitaj";
            this.buttonCitaj.Size = new System.Drawing.Size(104, 44);
            this.buttonCitaj.TabIndex = 0;
            this.buttonCitaj.Text = "Citaj";
            this.buttonCitaj.UseVisualStyleBackColor = true;
            this.buttonCitaj.Click += new System.EventHandler(this.buttonCitaj_Click);
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(422, 49);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(101, 44);
            this.buttonBrisi.TabIndex = 1;
            this.buttonBrisi.Text = "Brisi";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            this.buttonBrisi.Click += new System.EventHandler(this.buttonBrisi_Click);
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(55, 356);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(128, 46);
            this.buttonSpremi.TabIndex = 2;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 224);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.buttonCitaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCitaj;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

