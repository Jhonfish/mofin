namespace MOFIN_Lib
{
    partial class OpcionGroup_JF
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Opc_Base = new System.Windows.Forms.GroupBox();
            this.Opc1 = new System.Windows.Forms.RadioButton();
            this.Opc2 = new System.Windows.Forms.RadioButton();
            this.Opc3 = new System.Windows.Forms.RadioButton();
            this.Opc4 = new System.Windows.Forms.RadioButton();
            this.Opc_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // Opc_Base
            // 
            this.Opc_Base.Controls.Add(this.Opc4);
            this.Opc_Base.Controls.Add(this.Opc3);
            this.Opc_Base.Controls.Add(this.Opc2);
            this.Opc_Base.Controls.Add(this.Opc1);
            this.Opc_Base.Location = new System.Drawing.Point(0, 0);
            this.Opc_Base.Name = "Opc_Base";
            this.Opc_Base.Size = new System.Drawing.Size(147, 121);
            this.Opc_Base.TabIndex = 0;
            this.Opc_Base.TabStop = false;
            this.Opc_Base.Text = "OpcionBase";
            // 
            // Opc1
            // 
            this.Opc1.AutoSize = true;
            this.Opc1.Location = new System.Drawing.Point(23, 19);
            this.Opc1.Name = "Opc1";
            this.Opc1.Size = new System.Drawing.Size(65, 17);
            this.Opc1.TabIndex = 0;
            this.Opc1.TabStop = true;
            this.Opc1.Tag = "1";
            this.Opc1.Text = "Opcion1";
            this.Opc1.UseVisualStyleBackColor = true;
            this.Opc1.CheckedChanged += new System.EventHandler(this.Opc1_CheckedChanged);
            // 
            // Opc2
            // 
            this.Opc2.AutoSize = true;
            this.Opc2.Location = new System.Drawing.Point(23, 42);
            this.Opc2.Name = "Opc2";
            this.Opc2.Size = new System.Drawing.Size(65, 17);
            this.Opc2.TabIndex = 1;
            this.Opc2.TabStop = true;
            this.Opc2.Tag = "2";
            this.Opc2.Text = "Opcion2";
            this.Opc2.UseVisualStyleBackColor = true;
            this.Opc2.CheckedChanged += new System.EventHandler(this.Opc2_CheckedChanged);
            // 
            // Opc3
            // 
            this.Opc3.AutoSize = true;
            this.Opc3.Location = new System.Drawing.Point(23, 65);
            this.Opc3.Name = "Opc3";
            this.Opc3.Size = new System.Drawing.Size(65, 17);
            this.Opc3.TabIndex = 2;
            this.Opc3.TabStop = true;
            this.Opc3.Tag = "3";
            this.Opc3.Text = "Opcion3";
            this.Opc3.UseVisualStyleBackColor = true;
            this.Opc3.CheckedChanged += new System.EventHandler(this.Opc3_CheckedChanged);
            // 
            // Opc4
            // 
            this.Opc4.AutoSize = true;
            this.Opc4.Location = new System.Drawing.Point(23, 88);
            this.Opc4.Name = "Opc4";
            this.Opc4.Size = new System.Drawing.Size(65, 17);
            this.Opc4.TabIndex = 3;
            this.Opc4.TabStop = true;
            this.Opc4.Tag = "4";
            this.Opc4.Text = "Opcion4";
            this.Opc4.UseVisualStyleBackColor = true;
            this.Opc4.CheckedChanged += new System.EventHandler(this.Opc4_CheckedChanged);
            // 
            // OpcionGroup_JF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Opc_Base);
            this.Name = "OpcionGroup_JF";
            this.Size = new System.Drawing.Size(150, 128);
            this.Opc_Base.ResumeLayout(false);
            this.Opc_Base.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox Opc_Base;
        protected System.Windows.Forms.RadioButton Opc2;
        protected System.Windows.Forms.RadioButton Opc1;
        protected System.Windows.Forms.RadioButton Opc4;
        protected System.Windows.Forms.RadioButton Opc3;
    }
}
