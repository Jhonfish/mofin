namespace MOFIN
{
    partial class Prueba
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
            this.BS_Idiomas = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pan_Prueba = new System.Windows.Forms.Panel();
            this.Opc_Opcion3 = new System.Windows.Forms.RadioButton();
            this.Opc_Opcion2 = new System.Windows.Forms.RadioButton();
            this.Opc_Opcion1 = new System.Windows.Forms.RadioButton();
            this.NUD_Valor = new System.Windows.Forms.NumericUpDown();
            this.NUD_Ano = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_Resultado = new System.Windows.Forms.TextBox();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Idiomas)).BeginInit();
            this.Pan_Prueba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Ano)).BeginInit();
            this.SuspendLayout();
            // 
            // BS_Idiomas
            // 
            this.BS_Idiomas.DataSource = typeof(MofinModeloEntorno.Idiomas);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // Pan_Prueba
            // 
            this.Pan_Prueba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pan_Prueba.Controls.Add(this.Opc_Opcion3);
            this.Pan_Prueba.Controls.Add(this.Opc_Opcion2);
            this.Pan_Prueba.Controls.Add(this.Opc_Opcion1);
            this.Pan_Prueba.Location = new System.Drawing.Point(100, 12);
            this.Pan_Prueba.Name = "Pan_Prueba";
            this.Pan_Prueba.Size = new System.Drawing.Size(146, 113);
            this.Pan_Prueba.TabIndex = 5;
            this.Pan_Prueba.Tag = "1";
            this.Pan_Prueba.Paint += new System.Windows.Forms.PaintEventHandler(this.Pan_Prueba_Paint);
            this.Pan_Prueba.Leave += new System.EventHandler(this.Pan_Prueba_Leave);
            // 
            // Opc_Opcion3
            // 
            this.Opc_Opcion3.AutoSize = true;
            this.Opc_Opcion3.Location = new System.Drawing.Point(21, 76);
            this.Opc_Opcion3.Name = "Opc_Opcion3";
            this.Opc_Opcion3.Size = new System.Drawing.Size(85, 17);
            this.Opc_Opcion3.TabIndex = 2;
            this.Opc_Opcion3.TabStop = true;
            this.Opc_Opcion3.Text = "radioButton3";
            this.Opc_Opcion3.UseVisualStyleBackColor = true;
            // 
            // Opc_Opcion2
            // 
            this.Opc_Opcion2.AutoSize = true;
            this.Opc_Opcion2.Location = new System.Drawing.Point(20, 49);
            this.Opc_Opcion2.Name = "Opc_Opcion2";
            this.Opc_Opcion2.Size = new System.Drawing.Size(85, 17);
            this.Opc_Opcion2.TabIndex = 1;
            this.Opc_Opcion2.TabStop = true;
            this.Opc_Opcion2.Text = "radioButton2";
            this.Opc_Opcion2.UseVisualStyleBackColor = true;
            // 
            // Opc_Opcion1
            // 
            this.Opc_Opcion1.AutoSize = true;
            this.Opc_Opcion1.Location = new System.Drawing.Point(19, 20);
            this.Opc_Opcion1.Name = "Opc_Opcion1";
            this.Opc_Opcion1.Size = new System.Drawing.Size(85, 17);
            this.Opc_Opcion1.TabIndex = 0;
            this.Opc_Opcion1.TabStop = true;
            this.Opc_Opcion1.Text = "radioButton1";
            this.Opc_Opcion1.UseVisualStyleBackColor = true;
            // 
            // NUD_Valor
            // 
            this.NUD_Valor.Location = new System.Drawing.Point(36, 25);
            this.NUD_Valor.Name = "NUD_Valor";
            this.NUD_Valor.Size = new System.Drawing.Size(58, 20);
            this.NUD_Valor.TabIndex = 6;
            this.NUD_Valor.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUD_Valor.ValueChanged += new System.EventHandler(this.NUD_Valor_ValueChanged);
            // 
            // NUD_Ano
            // 
            this.NUD_Ano.Location = new System.Drawing.Point(409, 189);
            this.NUD_Ano.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NUD_Ano.Name = "NUD_Ano";
            this.NUD_Ano.Size = new System.Drawing.Size(71, 20);
            this.NUD_Ano.TabIndex = 7;
            this.NUD_Ano.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Txt_Resultado
            // 
            this.Txt_Resultado.Location = new System.Drawing.Point(585, 193);
            this.Txt_Resultado.Name = "Txt_Resultado";
            this.Txt_Resultado.Size = new System.Drawing.Size(100, 20);
            this.Txt_Resultado.TabIndex = 9;
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Location = new System.Drawing.Point(361, 150);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(200, 20);
            this.DTP_Fecha.TabIndex = 10;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.Txt_Resultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NUD_Ano);
            this.Controls.Add(this.NUD_Valor);
            this.Controls.Add(this.Pan_Prueba);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BS_Idiomas)).EndInit();
            this.Pan_Prueba.ResumeLayout(false);
            this.Pan_Prueba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Ano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource BS_Idiomas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Pan_Prueba;
        private System.Windows.Forms.RadioButton Opc_Opcion3;
        private System.Windows.Forms.RadioButton Opc_Opcion2;
        private System.Windows.Forms.RadioButton Opc_Opcion1;
        private System.Windows.Forms.NumericUpDown NUD_Valor;
        private System.Windows.Forms.NumericUpDown NUD_Ano;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_Resultado;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
    }
}