namespace TF_POO_Grupo_Discordia_0908
{
    partial class Frm1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxB1 = new System.Windows.Forms.TextBox();
            this.TxB2 = new System.Windows.Forms.TextBox();
            this.BT1 = new System.Windows.Forms.Button();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxB1
            // 
            this.TxB1.Location = new System.Drawing.Point(12, 42);
            this.TxB1.Name = "TxB1";
            this.TxB1.Size = new System.Drawing.Size(100, 20);
            this.TxB1.TabIndex = 0;
            this.TxB1.Text = "0";
            // 
            // TxB2
            // 
            this.TxB2.Location = new System.Drawing.Point(211, 43);
            this.TxB2.Name = "TxB2";
            this.TxB2.Size = new System.Drawing.Size(100, 20);
            this.TxB2.TabIndex = 1;
            this.TxB2.Text = "0";
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(12, 141);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(75, 23);
            this.BT1.TabIndex = 2;
            this.BT1.Text = "Accionar";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Checked = true;
            this.RB1.Location = new System.Drawing.Point(12, 69);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(72, 17);
            this.RB1.TabIndex = 3;
            this.RB1.TabStop = true;
            this.RB1.Text = "Multiplicar";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(12, 92);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(65, 17);
            this.RB2.TabIndex = 4;
            this.RB2.Text = "Factorial";
            this.RB2.UseVisualStyleBackColor = true;
            
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Location = new System.Drawing.Point(12, 115);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(116, 17);
            this.RB3.TabIndex = 5;
            this.RB3.Text = "Tabla de multiplicar";
            this.RB3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "(Solo para el N1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "(Solo para el N1)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "N1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "N2";
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.Location = new System.Drawing.Point(211, 69);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(120, 95);
            this.LB1.TabIndex = 10;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 237);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RB3);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.RB1);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.TxB2);
            this.Controls.Add(this.TxB1);
            this.Name = "Frm1";
            this.Text = "Practica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxB1;
        private System.Windows.Forms.TextBox TxB2;
        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LB1;
    }
}

