namespace SS001
{
    partial class GenLib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenLib));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libretaAnual = new System.Windows.Forms.Button();
            this.libretaParcial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 74);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generador de Libreta Estudiantil\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // libretaAnual
            // 
            this.libretaAnual.Image = ((System.Drawing.Image)(resources.GetObject("libretaAnual.Image")));
            this.libretaAnual.Location = new System.Drawing.Point(69, 190);
            this.libretaAnual.Name = "libretaAnual";
            this.libretaAnual.Size = new System.Drawing.Size(123, 120);
            this.libretaAnual.TabIndex = 4;
            this.libretaAnual.UseVisualStyleBackColor = true;
            this.libretaAnual.Click += new System.EventHandler(this.libretaAnual_Click);
            // 
            // libretaParcial
            // 
            this.libretaParcial.Image = ((System.Drawing.Image)(resources.GetObject("libretaParcial.Image")));
            this.libretaParcial.Location = new System.Drawing.Point(324, 190);
            this.libretaParcial.Name = "libretaParcial";
            this.libretaParcial.Size = new System.Drawing.Size(123, 120);
            this.libretaParcial.TabIndex = 5;
            this.libretaParcial.UseVisualStyleBackColor = true;
            this.libretaParcial.Click += new System.EventHandler(this.libretaParcial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Libreta Anual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Libreta por Parcial";
            // 
            // GenLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.libretaParcial);
            this.Controls.Add(this.libretaAnual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GenLib";
            this.Text = "Generador de Libretas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button libretaAnual;
        private System.Windows.Forms.Button libretaParcial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}