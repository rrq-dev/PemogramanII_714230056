namespace P6_1_714230056
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vButton = new System.Windows.Forms.Button();
            this.csButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Super Senior", 18F);
            this.label1.Location = new System.Drawing.Point(103, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you think is better, Visual basic or C#?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // vButton
            // 
            this.vButton.ForeColor = System.Drawing.Color.Red;
            this.vButton.Location = new System.Drawing.Point(259, 192);
            this.vButton.Name = "vButton";
            this.vButton.Size = new System.Drawing.Size(75, 23);
            this.vButton.TabIndex = 2;
            this.vButton.Text = "Visual";
            this.vButton.UseVisualStyleBackColor = true;
            this.vButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vButton_MouseMove);
            // 
            // csButton
            // 
            this.csButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.csButton.Location = new System.Drawing.Point(445, 192);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(75, 23);
            this.csButton.TabIndex = 3;
            this.csButton.Text = "C#";
            this.csButton.UseVisualStyleBackColor = true;
            this.csButton.Click += new System.EventHandler(this.csButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.ForeColor = System.Drawing.Color.Cyan;
            this.closeButton.Location = new System.Drawing.Point(108, 380);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.vButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button vButton;
        private System.Windows.Forms.Button csButton;
        private System.Windows.Forms.Button closeButton;
    }
}

