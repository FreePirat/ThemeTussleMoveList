namespace ThemeTussleMoveList
{
    partial class CharacterSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelect));
            pictureBox1 = new PictureBox();
            NinaBtn = new PictureBox();
            SuzieBtn = new PictureBox();
            LeoBtn = new PictureBox();
            CharlieBtn = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NinaBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuzieBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeoBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CharlieBtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1182, 644);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // NinaBtn
            // 
            NinaBtn.BackgroundImage = (Image)resources.GetObject("NinaBtn.BackgroundImage");
            NinaBtn.BackgroundImageLayout = ImageLayout.Stretch;
            NinaBtn.BorderStyle = BorderStyle.FixedSingle;
            NinaBtn.Cursor = Cursors.Hand;
            NinaBtn.Location = new Point(40, 400);
            NinaBtn.Name = "NinaBtn";
            NinaBtn.Size = new Size(207, 160);
            NinaBtn.TabIndex = 1;
            NinaBtn.TabStop = false;
            NinaBtn.Click += NinaBtn_Click;
            // 
            // SuzieBtn
            // 
            SuzieBtn.BackgroundImage = (Image)resources.GetObject("SuzieBtn.BackgroundImage");
            SuzieBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SuzieBtn.BorderStyle = BorderStyle.FixedSingle;
            SuzieBtn.Cursor = Cursors.Hand;
            SuzieBtn.Location = new Point(340, 400);
            SuzieBtn.Name = "SuzieBtn";
            SuzieBtn.Size = new Size(207, 160);
            SuzieBtn.TabIndex = 2;
            SuzieBtn.TabStop = false;
            SuzieBtn.Click += SuzieBtn_Click;
            // 
            // LeoBtn
            // 
            LeoBtn.BackgroundImage = (Image)resources.GetObject("LeoBtn.BackgroundImage");
            LeoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LeoBtn.BorderStyle = BorderStyle.FixedSingle;
            LeoBtn.Cursor = Cursors.Hand;
            LeoBtn.Location = new Point(640, 400);
            LeoBtn.Name = "LeoBtn";
            LeoBtn.Size = new Size(207, 160);
            LeoBtn.TabIndex = 3;
            LeoBtn.TabStop = false;
            LeoBtn.Click += LeoBtn_Click;
            // 
            // CharlieBtn
            // 
            CharlieBtn.BackgroundImage = (Image)resources.GetObject("CharlieBtn.BackgroundImage");
            CharlieBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CharlieBtn.BorderStyle = BorderStyle.FixedSingle;
            CharlieBtn.Cursor = Cursors.Hand;
            CharlieBtn.Location = new Point(940, 400);
            CharlieBtn.Name = "CharlieBtn";
            CharlieBtn.Size = new Size(207, 160);
            CharlieBtn.TabIndex = 4;
            CharlieBtn.TabStop = false;
            CharlieBtn.Click += CharlieBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(80, 129);
            label1.Name = "label1";
            label1.Size = new Size(1027, 95);
            label1.TabIndex = 5;
            label1.Text = "SELECT YOUR CHARACTER";
            // 
            // CharacterSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(label1);
            Controls.Add(CharlieBtn);
            Controls.Add(LeoBtn);
            Controls.Add(SuzieBtn);
            Controls.Add(NinaBtn);
            Controls.Add(pictureBox1);
            Name = "CharacterSelect";
            Text = "CharacterSelect";
            Load += CharacterSelect_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NinaBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuzieBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeoBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CharlieBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox NinaBtn;
        private PictureBox SuzieBtn;
        private PictureBox LeoBtn;
        private PictureBox CharlieBtn;
        private Label label1;
    }
}