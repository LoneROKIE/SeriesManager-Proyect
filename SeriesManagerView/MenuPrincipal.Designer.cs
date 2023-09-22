namespace SeriesManagerView
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            label1 = new Label();
            btnPeliculas = new Button();
            btnSeries = new Button();
            panel1 = new Panel();
            btnNuevaSerie = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(76, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Añadir Pelicula";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 33);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 4;
            label1.Text = "MAIN MENU";
            // 
            // btnPeliculas
            // 
            btnPeliculas.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeliculas.Location = new Point(64, 215);
            btnPeliculas.Name = "btnPeliculas";
            btnPeliculas.Size = new Size(183, 29);
            btnPeliculas.TabIndex = 5;
            btnPeliculas.Text = "Lista Peliculas";
            btnPeliculas.UseVisualStyleBackColor = true;
            btnPeliculas.Click += btnPeliculas_Click;
            // 
            // btnSeries
            // 
            btnSeries.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeries.Location = new Point(64, 265);
            btnSeries.Name = "btnSeries";
            btnSeries.Size = new Size(183, 29);
            btnSeries.TabIndex = 6;
            btnSeries.Text = "Lista Series";
            btnSeries.UseVisualStyleBackColor = true;
            btnSeries.Click += btnSeries_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnNuevaSerie);
            panel1.Controls.Add(btnSeries);
            panel1.Controls.Add(btnPeliculas);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 384);
            panel1.TabIndex = 7;
            // 
            // btnNuevaSerie
            // 
            btnNuevaSerie.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevaSerie.Location = new Point(76, 168);
            btnNuevaSerie.Name = "btnNuevaSerie";
            btnNuevaSerie.Size = new Size(171, 29);
            btnNuevaSerie.TabIndex = 7;
            btnNuevaSerie.Text = "Añadir Serie";
            btnNuevaSerie.UseVisualStyleBackColor = true;
            btnNuevaSerie.Click += btnNuevaSerie_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 333);
            Controls.Add(panel1);
            Name = "MenuPrincipal";
            Text = "Series Manager";
            Load += MenuPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Label label1;
        private Button btnPeliculas;
        private Button btnSeries;
        private Panel panel1;
        private Button btnNuevaSerie;

    }
}