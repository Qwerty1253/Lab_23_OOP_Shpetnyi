namespace Lab23
{
    partial class Form1
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxTMin;
        private System.Windows.Forms.TextBox textBoxTMax;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelTMin;
        private System.Windows.Forms.Label labelTMax;

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxTMin = new System.Windows.Forms.TextBox();
            this.textBoxTMax = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelTMin = new System.Windows.Forms.Label();
            this.labelTMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 537);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(800, 50);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxTMin
            // 
            this.textBoxTMin.Location = new System.Drawing.Point(800, 100);
            this.textBoxTMin.Name = "textBoxTMin";
            this.textBoxTMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxTMin.TabIndex = 2;
            // 
            // textBoxTMax
            // 
            this.textBoxTMax.Location = new System.Drawing.Point(800, 150);
            this.textBoxTMax.Name = "textBoxTMax";
            this.textBoxTMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxTMax.TabIndex = 3;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(800, 200);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(100, 30);
            this.buttonDraw.TabIndex = 4;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(800, 30);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(73, 17);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "Введіть a:";
            // 
            // labelTMin
            // 
            this.labelTMin.AutoSize = true;
            this.labelTMin.Location = new System.Drawing.Point(800, 80);
            this.labelTMin.Name = "labelTMin";
            this.labelTMin.Size = new System.Drawing.Size(84, 17);
            this.labelTMin.TabIndex = 6;
            this.labelTMin.Text = "Введіть tMin:";
            // 
            // labelTMax
            // 
            this.labelTMax.AutoSize = true;
            this.labelTMax.Location = new System.Drawing.Point(800, 130);
            this.labelTMax.Name = "labelTMax";
            this.labelTMax.Size = new System.Drawing.Size(88, 17);
            this.labelTMax.TabIndex = 7;
            this.labelTMax.Text = "Введіть tMax:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.labelTMax);
            this.Controls.Add(this.labelTMin);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.textBoxTMax);
            this.Controls.Add(this.textBoxTMin);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
