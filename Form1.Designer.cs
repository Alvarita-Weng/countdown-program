namespace 倒數計時器
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
            start = new Button();
            count = new Label();
            SuspendLayout();
            // 
            // start
            // 
            start.BackColor = SystemColors.ActiveCaption;
            start.Font = new Font("MV Boli", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.Location = new Point(237, 307);
            start.Name = "start";
            start.Size = new Size(323, 117);
            start.TabIndex = 0;
            start.Text = "start\r\n";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // count
            // 
            count.AutoSize = true;
            count.Cursor = Cursors.No;
            count.Font = new Font("Old English Text MT", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            count.ForeColor = SystemColors.Highlight;
            count.Location = new Point(237, 93);
            count.Name = "count";
            count.RightToLeft = RightToLeft.No;
            count.Size = new Size(294, 171);
            count.TabIndex = 1;
            count.Text = "100";
            count.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(count);
            Controls.Add(start);
            Name = "Form1";
            Text = "倒數計時器 by翁欣惠";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private Label count;
    }
}
