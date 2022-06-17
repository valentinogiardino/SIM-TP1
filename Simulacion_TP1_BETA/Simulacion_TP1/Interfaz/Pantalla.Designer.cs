
namespace Simulacion_TP1
{
    partial class Pantalla
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
            this.lblSemilla = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnAsistido = new System.Windows.Forms.RadioButton();
            this.btnLibre = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecomendaciones = new System.Windows.Forms.Label();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.txtC = new System.Windows.Forms.MaskedTextBox();
            this.txtG = new System.Windows.Forms.MaskedTextBox();
            this.txtK = new System.Windows.Forms.MaskedTextBox();
            this.txtSemilla = new System.Windows.Forms.MaskedTextBox();
            this.txtCantidadNumeros = new System.Windows.Forms.MaskedTextBox();
            this.lblDecimales = new System.Windows.Forms.Label();
            this.txtDecimales = new System.Windows.Forms.MaskedTextBox();
            this.lblCantidadGenerar = new System.Windows.Forms.Label();
            this.btnMultiplicativo = new System.Windows.Forms.RadioButton();
            this.btnLineal = new System.Windows.Forms.RadioButton();
            this.btnRandomLenguaje = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Location = new System.Drawing.Point(132, 155);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(43, 13);
            this.lblSemilla.TabIndex = 0;
            this.lblSemilla.Text = "Semilla:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(158, 269);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(16, 13);
            this.lblC.TabIndex = 1;
            this.lblC.Text = "c:";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(158, 229);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(16, 13);
            this.lblG.TabIndex = 2;
            this.lblG.Text = "g:";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(158, 198);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(17, 13);
            this.lblK.TabIndex = 3;
            this.lblK.Text = "K:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Location = new System.Drawing.Point(448, 240);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(101, 46);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnAsistido
            // 
            this.btnAsistido.AutoSize = true;
            this.btnAsistido.Checked = true;
            this.btnAsistido.Location = new System.Drawing.Point(16, 16);
            this.btnAsistido.Name = "btnAsistido";
            this.btnAsistido.Size = new System.Drawing.Size(91, 17);
            this.btnAsistido.TabIndex = 1;
            this.btnAsistido.TabStop = true;
            this.btnAsistido.Text = "Modo Asistido";
            this.btnAsistido.UseVisualStyleBackColor = true;
            // 
            // btnLibre
            // 
            this.btnLibre.AutoSize = true;
            this.btnLibre.Location = new System.Drawing.Point(140, 16);
            this.btnLibre.Name = "btnLibre";
            this.btnLibre.Size = new System.Drawing.Size(78, 17);
            this.btnLibre.TabIndex = 2;
            this.btnLibre.Text = "Modo Libre";
            this.btnLibre.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLibre);
            this.panel1.Controls.Add(this.btnAsistido);
            this.panel1.Location = new System.Drawing.Point(43, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 54);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRandomLenguaje);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lblIntervalos);
            this.panel2.Controls.Add(this.cmbIntervalos);
            this.panel2.Controls.Add(this.txtC);
            this.panel2.Controls.Add(this.txtG);
            this.panel2.Controls.Add(this.txtK);
            this.panel2.Controls.Add(this.txtSemilla);
            this.panel2.Controls.Add(this.txtCantidadNumeros);
            this.panel2.Controls.Add(this.lblDecimales);
            this.panel2.Controls.Add(this.txtDecimales);
            this.panel2.Controls.Add(this.lblCantidadGenerar);
            this.panel2.Controls.Add(this.btnMultiplicativo);
            this.panel2.Controls.Add(this.btnLineal);
            this.panel2.Controls.Add(this.lblSemilla);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Controls.Add(this.lblC);
            this.panel2.Controls.Add(this.lblG);
            this.panel2.Controls.Add(this.lblK);
            this.panel2.Location = new System.Drawing.Point(43, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 491);
            this.panel2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecomendaciones);
            this.groupBox1.Location = new System.Drawing.Point(91, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recomendaciones";
            // 
            // lblRecomendaciones
            // 
            this.lblRecomendaciones.AutoSize = true;
            this.lblRecomendaciones.Location = new System.Drawing.Point(6, 23);
            this.lblRecomendaciones.Name = "lblRecomendaciones";
            this.lblRecomendaciones.Size = new System.Drawing.Size(35, 13);
            this.lblRecomendaciones.TabIndex = 0;
            this.lblRecomendaciones.Text = "label1";
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(368, 158);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(116, 13);
            this.lblIntervalos.TabIndex = 13;
            this.lblIntervalos.Text = "Cantidad de Intervalos:";
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.ItemHeight = 13;
            this.cmbIntervalos.Location = new System.Drawing.Point(487, 155);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(62, 21);
            this.cmbIntervalos.TabIndex = 12;
            this.cmbIntervalos.SelectedIndexChanged += new System.EventHandler(this.cmbIntervalos_SelectedIndexChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(191, 266);
            this.txtC.Mask = "99999999";
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 9;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(191, 229);
            this.txtG.Mask = "99999999";
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 20);
            this.txtG.TabIndex = 8;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(191, 191);
            this.txtK.Mask = "99999999";
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 7;
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(191, 148);
            this.txtSemilla.Mask = "99999999";
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(100, 20);
            this.txtSemilla.TabIndex = 6;
            // 
            // txtCantidadNumeros
            // 
            this.txtCantidadNumeros.Location = new System.Drawing.Point(191, 103);
            this.txtCantidadNumeros.Mask = "99999999";
            this.txtCantidadNumeros.Name = "txtCantidadNumeros";
            this.txtCantidadNumeros.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadNumeros.TabIndex = 5;
            this.txtCantidadNumeros.ValidatingType = typeof(int);
            // 
            // lblDecimales
            // 
            this.lblDecimales.AutoSize = true;
            this.lblDecimales.Location = new System.Drawing.Point(376, 110);
            this.lblDecimales.Name = "lblDecimales";
            this.lblDecimales.Size = new System.Drawing.Size(105, 13);
            this.lblDecimales.TabIndex = 11;
            this.lblDecimales.Text = "Precisión Decimales:";
            // 
            // txtDecimales
            // 
            this.txtDecimales.Location = new System.Drawing.Point(487, 107);
            this.txtDecimales.Mask = "99";
            this.txtDecimales.Name = "txtDecimales";
            this.txtDecimales.Size = new System.Drawing.Size(62, 20);
            this.txtDecimales.TabIndex = 10;
            this.txtDecimales.ValidatingType = typeof(int);
            // 
            // lblCantidadGenerar
            // 
            this.lblCantidadGenerar.AutoSize = true;
            this.lblCantidadGenerar.Location = new System.Drawing.Point(69, 110);
            this.lblCantidadGenerar.Name = "lblCantidadGenerar";
            this.lblCantidadGenerar.Size = new System.Drawing.Size(110, 13);
            this.lblCantidadGenerar.TabIndex = 9;
            this.lblCantidadGenerar.Text = "Cantidad de números:";
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.AutoSize = true;
            this.btnMultiplicativo.Location = new System.Drawing.Point(71, 59);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(190, 17);
            this.btnMultiplicativo.TabIndex = 4;
            this.btnMultiplicativo.Text = "Método Congruencial Multiplicativo";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMultiplicativo.CheckedChanged += new System.EventHandler(this.btnMultiplicativo_CheckedChanged);
            // 
            // btnLineal
            // 
            this.btnLineal.AutoSize = true;
            this.btnLineal.Checked = true;
            this.btnLineal.Location = new System.Drawing.Point(71, 24);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(157, 17);
            this.btnLineal.TabIndex = 3;
            this.btnLineal.TabStop = true;
            this.btnLineal.Text = "Método Congruencial Lineal";
            this.btnLineal.UseVisualStyleBackColor = true;
            this.btnLineal.CheckedChanged += new System.EventHandler(this.btnLineal_CheckedChanged);
            // 
            // btnRandomLenguaje
            // 
            this.btnRandomLenguaje.AutoSize = true;
            this.btnRandomLenguaje.Location = new System.Drawing.Point(290, 24);
            this.btnRandomLenguaje.Name = "btnRandomLenguaje";
            this.btnRandomLenguaje.Size = new System.Drawing.Size(163, 17);
            this.btnRandomLenguaje.TabIndex = 16;
            this.btnRandomLenguaje.TabStop = true;
            this.btnRandomLenguaje.Text = "Metodo Creado por Lenguaje";
            this.btnRandomLenguaje.UseVisualStyleBackColor = true;
            this.btnRandomLenguaje.CheckedChanged += new System.EventHandler(this.btnRandomLenguaje_CheckedChanged);
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Números Pseudoaleatorios";
            this.Load += new System.EventHandler(this.Pantalla_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RadioButton btnAsistido;
        private System.Windows.Forms.RadioButton btnLibre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton btnMultiplicativo;
        private System.Windows.Forms.RadioButton btnLineal;
        private System.Windows.Forms.Label lblDecimales;
        private System.Windows.Forms.MaskedTextBox txtDecimales;
        private System.Windows.Forms.Label lblCantidadGenerar;
        private System.Windows.Forms.MaskedTextBox txtC;
        private System.Windows.Forms.MaskedTextBox txtG;
        private System.Windows.Forms.MaskedTextBox txtK;
        private System.Windows.Forms.MaskedTextBox txtSemilla;
        private System.Windows.Forms.MaskedTextBox txtCantidadNumeros;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecomendaciones;
        private System.Windows.Forms.RadioButton btnRandomLenguaje;
    }
}

