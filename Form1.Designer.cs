namespace Simon
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timerApagador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.Location = new System.Drawing.Point(217, 42);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(176, 112);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.TabStop = false;
            this.buttonUp.UseVisualStyleBackColor = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonLeft.FlatAppearance.BorderSize = 0;
            this.buttonLeft.Location = new System.Drawing.Point(35, 152);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(176, 112);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.TabStop = false;
            this.buttonLeft.UseVisualStyleBackColor = false;
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDown.FlatAppearance.BorderSize = 0;
            this.buttonDown.Location = new System.Drawing.Point(217, 262);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(176, 112);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.TabStop = false;
            this.buttonDown.UseVisualStyleBackColor = false;
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRight.FlatAppearance.BorderSize = 0;
            this.buttonRight.Location = new System.Drawing.Point(399, 152);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(176, 112);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.TabStop = false;
            this.buttonRight.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 600;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerApagador
            // 
            this.timerApagador.Interval = 500;
            this.timerApagador.Tick += new System.EventHandler(this.timerApagador_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C#imon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerApagador;
    }
}

