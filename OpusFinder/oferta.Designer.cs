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
            ((System.ComponentModel.ISupportInitialize)empleogrid).BeginInit();
            SuspendLayout();
            // 
            // empleogrid
            // 
            empleogrid.AllowUserToAddRows = false;
            empleogrid.AllowUserToDeleteRows = false;
            empleogrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empleogrid.Location = new Point(12, 34);
            empleogrid.Name = "empleogrid";
            empleogrid.Size = new Size(637, 145);
            empleogrid.TabIndex = 0;
            empleogrid.CellContentClick += empleogrid_CellContentClick;
            // 
            // oferta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 452);
            Controls.Add(empleogrid);
            Name = "oferta";
            Text = "oferta";
            Load += oferta_Load;
            ((System.ComponentModel.ISupportInitialize)empleogrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView empleogrid;
    }
}