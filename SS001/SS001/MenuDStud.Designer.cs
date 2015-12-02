namespace SS001
{
    partial class MenuDStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDStud));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crearAlumno = new System.Windows.Forms.Button();
            this.alumnoExistente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 74);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos Alumnos";
            // 
            // crearAlumno
            // 
            this.crearAlumno.Image = ((System.Drawing.Image)(resources.GetObject("crearAlumno.Image")));
            this.crearAlumno.Location = new System.Drawing.Point(71, 203);
            this.crearAlumno.Name = "crearAlumno";
            this.crearAlumno.Size = new System.Drawing.Size(123, 120);
            this.crearAlumno.TabIndex = 5;
            this.crearAlumno.UseVisualStyleBackColor = true;
            this.crearAlumno.Click += new System.EventHandler(this.crearAlumno_Click);
            // 
            // alumnoExistente
            // 
            this.alumnoExistente.Image = ((System.Drawing.Image)(resources.GetObject("alumnoExistente.Image")));
            this.alumnoExistente.Location = new System.Drawing.Point(354, 203);
            this.alumnoExistente.Name = "alumnoExistente";
            this.alumnoExistente.Size = new System.Drawing.Size(123, 120);
            this.alumnoExistente.TabIndex = 6;
            this.alumnoExistente.UseVisualStyleBackColor = true;
            this.alumnoExistente.Click += new System.EventHandler(this.alumnoExistente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Añadir Alumno";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Editar Alumno";
            // 
            // MenuDStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alumnoExistente);
            this.Controls.Add(this.crearAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuDStud";
            this.Text = "Datos Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button crearAlumno;
        private System.Windows.Forms.Button alumnoExistente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}