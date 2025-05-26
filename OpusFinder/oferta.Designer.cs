namespace OpusFinder
{
    partial class oferta
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
            empleogrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)empleogrid).BeginInit();
            SuspendLayout();
            // 
            // empleogrid
            // 
            empleogrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empleogrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            empleogrid.Location = new Point(12, 21);
            empleogrid.Name = "empleogrid";
            empleogrid.Size = new Size(637, 203);
            empleogrid.TabIndex = 0;
            empleogrid.CellContentClick += empleogrid_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "título";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Empresa";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Modalidad";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "modalidad";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Descripción";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Requerimentos";
            Column6.Name = "Column6";
            // 
            // oferta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 452);
            Controls.Add(empleogrid);
            Name = "oferta";
            Text = "oferta";
            ((System.ComponentModel.ISupportInitialize)empleogrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView empleogrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}