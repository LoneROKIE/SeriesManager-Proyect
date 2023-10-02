namespace SeriesManagerView
{
    partial class ListarPeliculas
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
            dataGridViewListaPeliculas = new DataGridView();
            label1 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaPeliculas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaPeliculas
            // 
            dataGridViewListaPeliculas.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewListaPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaPeliculas.Location = new Point(12, 110);
            dataGridViewListaPeliculas.Name = "dataGridViewListaPeliculas";
            dataGridViewListaPeliculas.RowHeadersWidth = 51;
            dataGridViewListaPeliculas.RowTemplate.Height = 29;
            dataGridViewListaPeliculas.Size = new Size(558, 334);
            dataGridViewListaPeliculas.TabIndex = 0;
            dataGridViewListaPeliculas.CellContentClick += dataGridViewListaPeliculas_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("GohuFont 11 Nerd Font Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 24);
            label1.TabIndex = 1;
            label1.Text = "Lista Peliculas";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("GohuFont 11 Nerd Font Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(14, 62);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("GohuFont 11 Nerd Font Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(170, 62);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // ListarPeliculas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(582, 456);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(dataGridViewListaPeliculas);
            Name = "ListarPeliculas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarPeliculas";
            TopMost = true;
            Load += ListarPeliculas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListaPeliculas;
        private Label label1;
        private Button btnEditar;
        private Button btnEliminar;
    }
}