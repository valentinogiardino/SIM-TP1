
namespace Simulacion_TP1
{
    partial class Histograma
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
            this.reporteChiCuadrado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gdrNumeroGenerados = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChiCuadrado = new System.Windows.Forms.Label();
            this.lblEstadistico = new System.Windows.Forms.Label();
            this.lblValorTabulado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrNumeroGenerados)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteChiCuadrado
            // 
            this.reporteChiCuadrado.LocalReport.ReportEmbeddedResource = "Simulacion_TP1.Informe.rdlc";
            this.reporteChiCuadrado.Location = new System.Drawing.Point(269, 64);
            this.reporteChiCuadrado.Name = "reporteChiCuadrado";
            this.reporteChiCuadrado.ServerReport.BearerToken = null;
            this.reporteChiCuadrado.Size = new System.Drawing.Size(992, 587);
            this.reporteChiCuadrado.TabIndex = 0;
            // 
            // gdrNumeroGenerados
            // 
            this.gdrNumeroGenerados.AllowUserToAddRows = false;
            this.gdrNumeroGenerados.AllowUserToDeleteRows = false;
            this.gdrNumeroGenerados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrNumeroGenerados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Rnd});
            this.gdrNumeroGenerados.Location = new System.Drawing.Point(12, 64);
            this.gdrNumeroGenerados.Name = "gdrNumeroGenerados";
            this.gdrNumeroGenerados.ReadOnly = true;
            this.gdrNumeroGenerados.Size = new System.Drawing.Size(251, 587);
            this.gdrNumeroGenerados.TabIndex = 1;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.ReadOnly = true;
            // 
            // Rnd
            // 
            this.Rnd.HeaderText = "Rnd";
            this.Rnd.Name = "Rnd";
            this.Rnd.ReadOnly = true;
            // 
            // lblChiCuadrado
            // 
            this.lblChiCuadrado.AutoSize = true;
            this.lblChiCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiCuadrado.Location = new System.Drawing.Point(279, 26);
            this.lblChiCuadrado.Name = "lblChiCuadrado";
            this.lblChiCuadrado.Size = new System.Drawing.Size(146, 17);
            this.lblChiCuadrado.TabIndex = 2;
            this.lblChiCuadrado.Text = "label chi_cuadrado";
            // 
            // lblEstadistico
            // 
            this.lblEstadistico.AutoSize = true;
            this.lblEstadistico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadistico.Location = new System.Drawing.Point(954, 14);
            this.lblEstadistico.Name = "lblEstadistico";
            this.lblEstadistico.Size = new System.Drawing.Size(47, 15);
            this.lblEstadistico.TabIndex = 3;
            this.lblEstadistico.Text = "label1";
            // 
            // lblValorTabulado
            // 
            this.lblValorTabulado.AutoSize = true;
            this.lblValorTabulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTabulado.Location = new System.Drawing.Point(954, 37);
            this.lblValorTabulado.Name = "lblValorTabulado";
            this.lblValorTabulado.Size = new System.Drawing.Size(47, 15);
            this.lblValorTabulado.TabIndex = 4;
            this.lblValorTabulado.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(797, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estadístico de Prueba:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(797, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor Crítico Tabulado:";
            // 
            // Histograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorTabulado);
            this.Controls.Add(this.lblEstadistico);
            this.Controls.Add(this.lblChiCuadrado);
            this.Controls.Add(this.gdrNumeroGenerados);
            this.Controls.Add(this.reporteChiCuadrado);
            this.Name = "Histograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histograma";
            this.Load += new System.EventHandler(this.Histograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrNumeroGenerados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteChiCuadrado;
        private System.Windows.Forms.DataGridView gdrNumeroGenerados;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rnd;
        private System.Windows.Forms.Label lblChiCuadrado;
        private System.Windows.Forms.Label lblEstadistico;
        private System.Windows.Forms.Label lblValorTabulado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}