namespace _2doParcial_Fierro_POO
{
    partial class FormAltaCapataz
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtPeonesACargo = new System.Windows.Forms.TextBox();
            this.btnCARGAR_CAPATAZ = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtLegajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.dataGridCapataz = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCapataz)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtPeonesACargo);
            this.groupBox4.Controls.Add(this.btnCARGAR_CAPATAZ);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(286, 502);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cargar un Capataz nuevo:";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // TxtPeonesACargo
            // 
            this.TxtPeonesACargo.Location = new System.Drawing.Point(136, 234);
            this.TxtPeonesACargo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPeonesACargo.Name = "TxtPeonesACargo";
            this.TxtPeonesACargo.Size = new System.Drawing.Size(81, 22);
            this.TxtPeonesACargo.TabIndex = 9;
            // 
            // btnCARGAR_CAPATAZ
            // 
            this.btnCARGAR_CAPATAZ.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCARGAR_CAPATAZ.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCARGAR_CAPATAZ.Location = new System.Drawing.Point(13, 288);
            this.btnCARGAR_CAPATAZ.Margin = new System.Windows.Forms.Padding(4);
            this.btnCARGAR_CAPATAZ.Name = "btnCARGAR_CAPATAZ";
            this.btnCARGAR_CAPATAZ.Size = new System.Drawing.Size(235, 39);
            this.btnCARGAR_CAPATAZ.TabIndex = 35;
            this.btnCARGAR_CAPATAZ.Text = "CARGAR CAPATAZ";
            this.btnCARGAR_CAPATAZ.UseVisualStyleBackColor = false;
            this.btnCARGAR_CAPATAZ.Click += new System.EventHandler(this.btnCARGAR_EMPLEADO_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Peones a Cargo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtLegajo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Controls.Add(this.TxtApellido);
            this.groupBox2.Controls.Add(this.TxtEdad);
            this.groupBox2.Location = new System.Drawing.Point(8, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(240, 203);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Completar datos personales de Capataz";
            // 
            // TxtLegajo
            // 
            this.TxtLegajo.Location = new System.Drawing.Point(77, 48);
            this.TxtLegajo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLegajo.Name = "TxtLegajo";
            this.TxtLegajo.Size = new System.Drawing.Size(132, 22);
            this.TxtLegajo.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Legajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Edad";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(77, 91);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(132, 22);
            this.TxtNombre.TabIndex = 25;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(77, 132);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(132, 22);
            this.TxtApellido.TabIndex = 26;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(77, 169);
            this.TxtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(132, 22);
            this.TxtEdad.TabIndex = 27;
            // 
            // dataGridCapataz
            // 
            this.dataGridCapataz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCapataz.Location = new System.Drawing.Point(307, 23);
            this.dataGridCapataz.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCapataz.Name = "dataGridCapataz";
            this.dataGridCapataz.RowHeadersWidth = 51;
            this.dataGridCapataz.Size = new System.Drawing.Size(630, 327);
            this.dataGridCapataz.TabIndex = 33;
            // 
            // FormAltaCapataz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 354);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridCapataz);
            this.Name = "FormAltaCapataz";
            this.Text = "Alta Capataz";
            this.Load += new System.EventHandler(this.FormAltaCapataz_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCapataz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtPeonesACargo;
        private System.Windows.Forms.Button btnCARGAR_CAPATAZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.DataGridView dataGridCapataz;
    }
}