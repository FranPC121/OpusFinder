namespace OpusFinder
{
    partial class Form1
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
            logo = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            región = new ComboBox();
            rubro = new ComboBox();
            modalidad = new ComboBox();
            lblregion = new Label();
            lblmodalidad = new Label();
            lblrubro = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = SystemColors.Window;
            logo.Image = Properties.Resources.OF;
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(83, 76);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 1;
            logo.TabStop = false;
            
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.cv;
            pictureBox1.Location = new Point(766, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Video_Script_Docs_Banner_in_Indigo_Pink_Bold_Style;
            pictureBox2.Location = new Point(152, -18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(579, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // región
            // 
            región.BackColor = SystemColors.Window;
            región.DropDownStyle = ComboBoxStyle.DropDownList;
            región.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            región.ForeColor = Color.Black;
            región.FormattingEnabled = true;
            región.Items.AddRange(new object[] { "Ahuachapán", "Chalatenango", "Santa Ana", "Sonsonate", "San Salvador", "La Libertad", "Cuscatlán", "Cabañas", "La Paz", "San Vicente", "Morazán", "San Miguel", "La Unión", "Usulután", "Cualquier región" });
            región.Location = new Point(424, 35);
            región.Name = "región";
            región.Size = new Size(104, 24);
            región.TabIndex = 12;
            // 
            // rubro
            // 
            rubro.DropDownStyle = ComboBoxStyle.DropDownList;
            rubro.FormattingEnabled = true;
            rubro.Items.AddRange(new object[] { "Comercial", "Industrial", "Informática", "Educación", "Construcción", "Cualquier rubro" });
            rubro.Location = new Point(687, 36);
            rubro.Name = "rubro";
            rubro.Size = new Size(95, 23);
            rubro.TabIndex = 13;
            // 
            // modalidad
            // 
            modalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            modalidad.FormattingEnabled = true;
            modalidad.Items.AddRange(new object[] { "Tiempo completo (office)", "Tiempo completo (remoto)", "Tiempo parcial", "Cualquier modalidad" });
            modalidad.Location = new Point(534, 36);
            modalidad.Name = "modalidad";
            modalidad.Size = new Size(147, 23);
            modalidad.TabIndex = 14;
            // 
            // lblregion
            // 
            lblregion.AutoSize = true;
            lblregion.Location = new Point(454, 17);
            lblregion.Name = "lblregion";
            lblregion.Size = new Size(44, 15);
            lblregion.TabIndex = 15;
            lblregion.Text = "Región";
            // 
            // lblmodalidad
            // 
            lblmodalidad.AutoSize = true;
            lblmodalidad.Location = new Point(574, 17);
            lblmodalidad.Name = "lblmodalidad";
            lblmodalidad.Size = new Size(64, 15);
            lblmodalidad.TabIndex = 16;
            lblmodalidad.Text = "Modalidad";
            // 
            // lblrubro
            // 
            lblrubro.AutoSize = true;
            lblrubro.Location = new Point(711, 17);
            lblrubro.Name = "lblrubro";
            lblrubro.Size = new Size(39, 15);
            lblrubro.TabIndex = 17;
            lblrubro.Text = "Rubro";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.flt;
            pictureBox3.Location = new Point(788, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblrubro);
            panel1.Controls.Add(lblmodalidad);
            panel1.Controls.Add(lblregion);
            panel1.Controls.Add(modalidad);
            panel1.Controls.Add(rubro);
            panel1.Controls.Add(región);
            panel1.Location = new Point(0, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 379);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(844, 528);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(logo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox logo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox región;
        private ComboBox rubro;
        private ComboBox modalidad;
        private Label lblregion;
        private Label lblmodalidad;
        private Label lblrubro;
        private PictureBox pictureBox3;
        private Panel panel1;
    }
}
