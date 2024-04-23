namespace formsquare
{
    partial class square
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.download;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(428, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 289);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 14.25F);
            button1.Location = new Point(201, 166);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 1;
            button1.Text = "<<CALCULAR>>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 14.25F);
            button2.Location = new Point(201, 318);
            button2.Name = "button2";
            button2.Size = new Size(142, 34);
            button2.TabIndex = 2;
            button2.Text = "<<LIMPAR>>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 14.25F);
            button3.Location = new Point(567, 382);
            button3.Name = "button3";
            button3.Size = new Size(142, 34);
            button3.TabIndex = 3;
            button3.Text = "<<FECHAR>>";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 14.25F);
            textBox1.Location = new Point(157, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 34);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Comic Sans MS", 14.25F);
            textBox3.Location = new Point(157, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 34);
            textBox3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F);
            label1.Location = new Point(83, 105);
            label1.Name = "label1";
            label1.Size = new Size(53, 26);
            label1.TabIndex = 8;
            label1.Text = "Lado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F);
            label3.Location = new Point(82, 252);
            label3.Name = "label3";
            label3.Size = new Size(54, 26);
            label3.TabIndex = 10;
            label3.Text = "Area";
            // 
            // square
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 446);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "square";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
        private Label label3;
    }
}
