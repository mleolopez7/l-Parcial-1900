namespace Tarea1
{
    partial class Tarea1
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
            this.buttonvali = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblposi = new System.Windows.Forms.Label();
            this.lblnega = new System.Windows.Forms.Label();
            this.lblpar = new System.Windows.Forms.Label();
            this.lblimp = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonvali
            // 
            this.buttonvali.Location = new System.Drawing.Point(138, 141);
            this.buttonvali.Name = "buttonvali";
            this.buttonvali.Size = new System.Drawing.Size(110, 38);
            this.buttonvali.TabIndex = 0;
            this.buttonvali.Text = "Validar";
            this.buttonvali.UseVisualStyleBackColor = true;
            this.buttonvali.Click += new System.EventHandler(this.buttonvali_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por favor ingrese un numero entero";
            // 
            // lblposi
            // 
            this.lblposi.AutoSize = true;
            this.lblposi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposi.Location = new System.Drawing.Point(188, 217);
            this.lblposi.Name = "lblposi";
            this.lblposi.Size = new System.Drawing.Size(0, 16);
            this.lblposi.TabIndex = 2;
            // 
            // lblnega
            // 
            this.lblnega.AutoSize = true;
            this.lblnega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnega.Location = new System.Drawing.Point(188, 259);
            this.lblnega.Name = "lblnega";
            this.lblnega.Size = new System.Drawing.Size(0, 16);
            this.lblnega.TabIndex = 3;
            // 
            // lblpar
            // 
            this.lblpar.AutoSize = true;
            this.lblpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpar.Location = new System.Drawing.Point(188, 300);
            this.lblpar.Name = "lblpar";
            this.lblpar.Size = new System.Drawing.Size(0, 16);
            this.lblpar.TabIndex = 4;
            // 
            // lblimp
            // 
            this.lblimp.AutoSize = true;
            this.lblimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimp.Location = new System.Drawing.Point(188, 338);
            this.lblimp.Name = "lblimp";
            this.lblimp.Size = new System.Drawing.Size(0, 16);
            this.lblimp.TabIndex = 5;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(191, 97);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(133, 20);
            this.txtnum.TabIndex = 6;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(254, 141);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(110, 38);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Tarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblimp);
            this.Controls.Add(this.lblpar);
            this.Controls.Add(this.lblnega);
            this.Controls.Add(this.lblposi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonvali);
            this.Name = "Tarea1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonvali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblposi;
        private System.Windows.Forms.Label lblnega;
        private System.Windows.Forms.Label lblpar;
        private System.Windows.Forms.Label lblimp;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

