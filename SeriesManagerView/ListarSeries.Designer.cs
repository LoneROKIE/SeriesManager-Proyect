namespace SeriesManagerView
{
    partial class ListarSeries
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
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(529, 275);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("GohuFont 11 Nerd Font Mono", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(12, 75);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(104, 29);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("GohuFont 11 Nerd Font Mono", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(131, 75);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 2;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("GohuFont 11 Nerd Font Mono", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 3;
            label1.Text = "Series";
            // 
            // ListarSeries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 407);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnEditar);
            Controls.Add(dataGridView1);
            Name = "ListarSeries";
            Text = "ListarSeries";
            Load += ListarSeries_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEditar;
        private Button button1;
        private Label label1;
    }
}