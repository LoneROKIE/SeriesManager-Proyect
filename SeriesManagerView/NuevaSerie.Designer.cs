namespace SeriesManagerView
{
    partial class NuevaSerie
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
            components = new System.ComponentModel.Container();
            label3 = new Label();
            checkBox1 = new CheckBox();
            textBoxTitulo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnGuardar = new Button();
            bindingSource1 = new BindingSource(components);
            numericUpDownTemporada = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            numericUpDownCapitulo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemporada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapitulo).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("ProggyCleanSZ Nerd Font Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 9);
            label3.Name = "label3";
            label3.Size = new Size(238, 23);
            label3.TabIndex = 14;
            label3.Text = "Agregar Nueva Serie";
            label3.UseWaitCursor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(21, 269);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(220, 22);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Ya la terminastes ?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.UseWaitCursor = true;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitulo.Location = new Point(149, 77);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(148, 26);
            textBoxTitulo.TabIndex = 12;
            textBoxTitulo.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 11;
            label2.Text = "Genero";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 85);
            label1.Name = "label1";
            label1.Size = new Size(128, 18);
            label1.TabIndex = 10;
            label1.Text = "Titulo Serie";
            label1.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 125);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 26);
            comboBox1.TabIndex = 9;
            comboBox1.UseWaitCursor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(117, 324);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.UseWaitCursor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numericUpDownTemporada
            // 
            numericUpDownTemporada.Location = new Point(118, 176);
            numericUpDownTemporada.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownTemporada.Name = "numericUpDownTemporada";
            numericUpDownTemporada.Size = new Size(93, 27);
            numericUpDownTemporada.TabIndex = 15;
            numericUpDownTemporada.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(98, 18);
            label4.TabIndex = 16;
            label4.Text = "Temporada";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("ProggyCleanSZ Nerd Font Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 232);
            label5.Name = "label5";
            label5.Size = new Size(88, 18);
            label5.TabIndex = 18;
            label5.Text = "Capitulo";
            label5.UseWaitCursor = true;
            // 
            // numericUpDownCapitulo
            // 
            numericUpDownCapitulo.Location = new Point(117, 223);
            numericUpDownCapitulo.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownCapitulo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCapitulo.Name = "numericUpDownCapitulo";
            numericUpDownCapitulo.Size = new Size(94, 27);
            numericUpDownCapitulo.TabIndex = 17;
            numericUpDownCapitulo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NuevaSerie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 365);
            Controls.Add(label5);
            Controls.Add(numericUpDownCapitulo);
            Controls.Add(label4);
            Controls.Add(numericUpDownTemporada);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(textBoxTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnGuardar);
            Name = "NuevaSerie";
            Text = "NuevaSerie";
            Load += NuevaSerie_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTemporada).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapitulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private CheckBox checkBox1;
        private TextBox textBoxTitulo;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Button btnGuardar;
        private BindingSource bindingSource1;
        private NumericUpDown numericUpDownTemporada;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownCapitulo;
    }
}