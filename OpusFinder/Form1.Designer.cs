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
            cv1 = new Button();
            SuspendLayout();
            // 
            // cv1
            // 
            cv1.BackgroundImageLayout = ImageLayout.Zoom;
            cv1.Location = new Point(736, 12);
            cv1.Name = "cv1";
            cv1.Size = new Size(96, 28);
            cv1.TabIndex = 0;
            cv1.Text = "Crear CV";
            cv1.UseVisualStyleBackColor = true;
            cv1.Click += cv1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 528);
            Controls.Add(cv1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button cv1;
    }
}
