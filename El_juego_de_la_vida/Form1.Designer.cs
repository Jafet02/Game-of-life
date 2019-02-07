namespace El_juego_de_la_vida
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ngen = new System.Windows.Forms.Button();
            this.buttonreinicio = new System.Windows.Forms.Button();
            this.ButtonSucesivas = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.salir = new System.Windows.Forms.Button();
            this.buttonpase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(742, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el estado inicial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_ngen
            // 
            this.button_ngen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ngen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ngen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ngen.Location = new System.Drawing.Point(774, 177);
            this.button_ngen.Name = "button_ngen";
            this.button_ngen.Size = new System.Drawing.Size(102, 41);
            this.button_ngen.TabIndex = 2;
            this.button_ngen.Text = "Nueva generacion";
            this.button_ngen.UseVisualStyleBackColor = false;
            this.button_ngen.Click += new System.EventHandler(this.button_ngen_Click);
            // 
            // buttonreinicio
            // 
            this.buttonreinicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonreinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonreinicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonreinicio.Location = new System.Drawing.Point(774, 407);
            this.buttonreinicio.Name = "buttonreinicio";
            this.buttonreinicio.Size = new System.Drawing.Size(102, 40);
            this.buttonreinicio.TabIndex = 3;
            this.buttonreinicio.Text = "Reiniciar";
            this.buttonreinicio.UseVisualStyleBackColor = false;
            this.buttonreinicio.Click += new System.EventHandler(this.buttonreinicio_Click);
            // 
            // ButtonSucesivas
            // 
            this.ButtonSucesivas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSucesivas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSucesivas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSucesivas.Location = new System.Drawing.Point(774, 259);
            this.ButtonSucesivas.Name = "ButtonSucesivas";
            this.ButtonSucesivas.Size = new System.Drawing.Size(102, 42);
            this.ButtonSucesivas.TabIndex = 4;
            this.ButtonSucesivas.Text = "Generaciones sucesivas";
            this.ButtonSucesivas.UseVisualStyleBackColor = false;
            this.ButtonSucesivas.Click += new System.EventHandler(this.ButtonSucesivas_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salir.Location = new System.Drawing.Point(802, 573);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(102, 42);
            this.salir.TabIndex = 5;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // buttonpase
            // 
            this.buttonpase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonpase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonpase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonpase.Location = new System.Drawing.Point(790, 307);
            this.buttonpase.Name = "buttonpase";
            this.buttonpase.Size = new System.Drawing.Size(75, 32);
            this.buttonpase.TabIndex = 6;
            this.buttonpase.Text = "Pausar";
            this.buttonpase.UseVisualStyleBackColor = false;
            this.buttonpase.Click += new System.EventHandler(this.buttonpase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(924, 677);
            this.Controls.Add(this.buttonpase);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.ButtonSucesivas);
            this.Controls.Add(this.buttonreinicio);
            this.Controls.Add(this.button_ngen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El juego de la vida";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ngen;
        private System.Windows.Forms.Button buttonreinicio;
        private System.Windows.Forms.Button ButtonSucesivas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button buttonpase;
    }
}

