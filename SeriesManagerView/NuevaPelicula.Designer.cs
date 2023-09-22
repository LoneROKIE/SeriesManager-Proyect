namespace SeriesManagerView
{
    partial class NuevaPelicula
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
            btnGuardar = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxTitulo = new TextBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(100, 252);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.UseWaitCursor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 26);
            comboBox1.TabIndex = 1;
            comboBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(158, 18);
            label1.TabIndex = 2;
            label1.Text = "Titulo Pelicula";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 3;
            label2.Text = "Genero";
            label2.UseWaitCursor = true;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitulo.Location = new Point(176, 80);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(148, 26);
            textBoxTitulo.TabIndex = 4;
            textBoxTitulo.UseWaitCursor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(100, 196);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 22);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Ya la vistes ?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("ProggyCleanSZ Nerd Font Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(69, 9);
            label3.Name = "label3";
            label3.Size = new Size(274, 23);
            label3.TabIndex = 7;
            label3.Text = "Agregar Nueva Pelicula";
            label3.UseWaitCursor = true;
            // 
            // NuevaPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 365);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(textBoxTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnGuardar);
            Name = "NuevaPelicula";
            Text = "NuevaPelicula";
            TopMost = true;
            UseWaitCursor = true;
            Load += NuevaPelicula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxTitulo;
        private CheckBox checkBox1;
        private Label label3;
    }
}