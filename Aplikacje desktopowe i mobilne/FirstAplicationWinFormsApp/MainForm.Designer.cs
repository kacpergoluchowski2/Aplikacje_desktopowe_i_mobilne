namespace FirstAplicationWinFormsApp
{
    partial class MainForm
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
            buttonFirst = new Button();
            SuspendLayout();
            // 
            // buttonFirst
            // 
            buttonFirst.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonFirst.Location = new Point(149, 111);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(228, 94);
            buttonFirst.TabIndex = 0;
            buttonFirst.Text = "Pierwszy przycisk";
            buttonFirst.UseVisualStyleBackColor = true;
            buttonFirst.Click += buttonFirst_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(603, 410);
            Controls.Add(buttonFirst);
            Name = "MainForm";
            Text = "Pierwsza aplikacja";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFirst;
    }
}
