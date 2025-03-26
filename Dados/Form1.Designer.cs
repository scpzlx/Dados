namespace Dados
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
            this.BtnDado1 = new System.Windows.Forms.Button();
            this.dado1 = new System.Windows.Forms.PictureBox();
            this.dado2 = new System.Windows.Forms.PictureBox();
            this.Dados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDado1
            // 
            this.BtnDado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(85)))), ((int)(((byte)(153)))));
            this.BtnDado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDado1.ForeColor = System.Drawing.Color.Transparent;
            this.BtnDado1.Location = new System.Drawing.Point(253, 323);
            this.BtnDado1.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDado1.Name = "BtnDado1";
            this.BtnDado1.Size = new System.Drawing.Size(156, 42);
            this.BtnDado1.TabIndex = 0;
            this.BtnDado1.Text = "Tirar Dados";
            this.BtnDado1.UseVisualStyleBackColor = false;
            this.BtnDado1.Click += new System.EventHandler(this.BtnDado1_Click_1);
            // 
            // dado1
            // 
            this.dado1.Location = new System.Drawing.Point(162, 114);
            this.dado1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dado1.Name = "dado1";
            this.dado1.Size = new System.Drawing.Size(154, 140);
            this.dado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dado1.TabIndex = 1;
            this.dado1.TabStop = false;
            // 
            // dado2
            // 
            this.dado2.Location = new System.Drawing.Point(333, 114);
            this.dado2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dado2.Name = "dado2";
            this.dado2.Size = new System.Drawing.Size(154, 140);
            this.dado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dado2.TabIndex = 2;
            this.dado2.TabStop = false;
            // 
            // Dados
            // 
            this.Dados.HeaderText = "Numeros";
            this.Dados.MinimumWidth = 6;
            this.Dados.Name = "Dados";
            this.Dados.Width = 125;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dados});
            this.dataGridViewResultados.Location = new System.Drawing.Point(565, 114);
            this.dataGridViewResultados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.RowHeadersWidth = 51;
            this.dataGridViewResultados.RowTemplate.Height = 24;
            this.dataGridViewResultados.Size = new System.Drawing.Size(127, 266);
            this.dataGridViewResultados.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(806, 504);
            this.Controls.Add(this.dataGridViewResultados);
            this.Controls.Add(this.dado2);
            this.Controls.Add(this.dado1);
            this.Controls.Add(this.BtnDado1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Dados";
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDado1;
        private System.Windows.Forms.PictureBox dado1;
        private System.Windows.Forms.PictureBox dado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dados;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
    }
}

