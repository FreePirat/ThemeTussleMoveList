namespace ThemeTussleMoveList
{
    partial class Suzie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suzie));
            btnFirst = new Button();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            charImg = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDesc = new TextBox();
            txtHurtBoxSize = new TextBox();
            txtHurtBoxPos = new TextBox();
            txtHitBoxPos = new TextBox();
            txtHitBoxSize = new TextBox();
            txtBlock = new TextBox();
            txtRecovery = new TextBox();
            txtActive = new TextBox();
            txtStartup = new TextBox();
            txtDmg = new TextBox();
            txtName = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)charImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.DarkRed;
            btnFirst.BackgroundImageLayout = ImageLayout.Stretch;
            btnFirst.Font = new Font("Roboto Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirst.ForeColor = Color.White;
            btnFirst.Location = new Point(259, 584);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(140, 70);
            btnFirst.TabIndex = 79;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += Navigation_Handler;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.DarkRed;
            btnLast.BackgroundImageLayout = ImageLayout.Stretch;
            btnLast.Font = new Font("Roboto Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnLast.ForeColor = Color.White;
            btnLast.Location = new Point(739, 584);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(140, 70);
            btnLast.TabIndex = 78;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += Navigation_Handler;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.DarkRed;
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.Font = new Font("Roboto Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(579, 584);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 70);
            btnNext.TabIndex = 77;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += Navigation_Handler;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.DarkRed;
            btnPrevious.BackgroundImage = (Image)resources.GetObject("btnPrevious.BackgroundImage");
            btnPrevious.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrevious.Font = new Font("Roboto Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.Location = new Point(419, 584);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(140, 70);
            btnPrevious.TabIndex = 76;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += Navigation_Handler;
            // 
            // charImg
            // 
            charImg.BackgroundImage = (Image)resources.GetObject("charImg.BackgroundImage");
            charImg.BackgroundImageLayout = ImageLayout.Stretch;
            charImg.BorderStyle = BorderStyle.FixedSingle;
            charImg.Location = new Point(410, 39);
            charImg.Name = "charImg";
            charImg.Size = new Size(341, 532);
            charImg.TabIndex = 75;
            charImg.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(779, 399);
            label11.Name = "label11";
            label11.Size = new Size(235, 40);
            label11.TabIndex = 74;
            label11.Text = "Description";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(779, 309);
            label10.Name = "label10";
            label10.Size = new Size(339, 40);
            label10.TabIndex = 73;
            label10.Text = "HurtBox Position";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(779, 219);
            label9.Name = "label9";
            label9.Size = new Size(255, 40);
            label9.TabIndex = 72;
            label9.Text = "HurtBox Size";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(779, 129);
            label8.Name = "label8";
            label8.Size = new Size(305, 40);
            label8.TabIndex = 71;
            label8.Text = "HitBox Position";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(779, 39);
            label7.Name = "label7";
            label7.Size = new Size(221, 40);
            label7.TabIndex = 70;
            label7.Text = "HitBox Size";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(9, 489);
            label6.Name = "label6";
            label6.Size = new Size(179, 40);
            label6.TabIndex = 69;
            label6.Text = "On Block";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 399);
            label5.Name = "label5";
            label5.Size = new Size(327, 40);
            label5.TabIndex = 68;
            label5.Text = "Recovery Frames";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 309);
            label4.Name = "label4";
            label4.Size = new Size(271, 40);
            label4.TabIndex = 67;
            label4.Text = "Active Frames";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 219);
            label3.Name = "label3";
            label3.Size = new Size(305, 40);
            label3.TabIndex = 66;
            label3.Text = "Startup Frames";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 129);
            label2.Name = "label2";
            label2.Size = new Size(149, 40);
            label2.TabIndex = 65;
            label2.Text = "Damage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 39);
            label1.Name = "label1";
            label1.Size = new Size(218, 40);
            label1.TabIndex = 64;
            label1.Text = "Input Name";
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDesc.Location = new Point(779, 449);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new Size(365, 122);
            txtDesc.TabIndex = 63;
            // 
            // txtHurtBoxSize
            // 
            txtHurtBoxSize.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHurtBoxSize.Location = new Point(779, 269);
            txtHurtBoxSize.Name = "txtHurtBoxSize";
            txtHurtBoxSize.ReadOnly = true;
            txtHurtBoxSize.Size = new Size(365, 32);
            txtHurtBoxSize.TabIndex = 62;
            // 
            // txtHurtBoxPos
            // 
            txtHurtBoxPos.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHurtBoxPos.Location = new Point(779, 359);
            txtHurtBoxPos.Name = "txtHurtBoxPos";
            txtHurtBoxPos.ReadOnly = true;
            txtHurtBoxPos.Size = new Size(365, 32);
            txtHurtBoxPos.TabIndex = 61;
            // 
            // txtHitBoxPos
            // 
            txtHitBoxPos.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHitBoxPos.Location = new Point(779, 179);
            txtHitBoxPos.Name = "txtHitBoxPos";
            txtHitBoxPos.ReadOnly = true;
            txtHitBoxPos.Size = new Size(365, 32);
            txtHitBoxPos.TabIndex = 60;
            // 
            // txtHitBoxSize
            // 
            txtHitBoxSize.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHitBoxSize.Location = new Point(779, 89);
            txtHitBoxSize.Name = "txtHitBoxSize";
            txtHitBoxSize.ReadOnly = true;
            txtHitBoxSize.Size = new Size(365, 32);
            txtHitBoxSize.TabIndex = 59;
            // 
            // txtBlock
            // 
            txtBlock.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBlock.Location = new Point(9, 539);
            txtBlock.Name = "txtBlock";
            txtBlock.ReadOnly = true;
            txtBlock.Size = new Size(365, 32);
            txtBlock.TabIndex = 58;
            // 
            // txtRecovery
            // 
            txtRecovery.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecovery.Location = new Point(9, 449);
            txtRecovery.Name = "txtRecovery";
            txtRecovery.ReadOnly = true;
            txtRecovery.Size = new Size(365, 32);
            txtRecovery.TabIndex = 57;
            // 
            // txtActive
            // 
            txtActive.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtActive.Location = new Point(11, 359);
            txtActive.Name = "txtActive";
            txtActive.ReadOnly = true;
            txtActive.Size = new Size(365, 32);
            txtActive.TabIndex = 56;
            // 
            // txtStartup
            // 
            txtStartup.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartup.Location = new Point(9, 269);
            txtStartup.Name = "txtStartup";
            txtStartup.ReadOnly = true;
            txtStartup.Size = new Size(365, 32);
            txtStartup.TabIndex = 55;
            // 
            // txtDmg
            // 
            txtDmg.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDmg.Location = new Point(9, 179);
            txtDmg.Name = "txtDmg";
            txtDmg.ReadOnly = true;
            txtDmg.Size = new Size(365, 32);
            txtDmg.TabIndex = 54;
            // 
            // txtName
            // 
            txtName.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(9, 89);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(365, 32);
            txtName.TabIndex = 53;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1185, 652);
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // Suzie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(btnFirst);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(charImg);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDesc);
            Controls.Add(txtHurtBoxSize);
            Controls.Add(txtHurtBoxPos);
            Controls.Add(txtHitBoxPos);
            Controls.Add(txtHitBoxSize);
            Controls.Add(txtBlock);
            Controls.Add(txtRecovery);
            Controls.Add(txtActive);
            Controls.Add(txtStartup);
            Controls.Add(txtDmg);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            Name = "Suzie";
            Text = "Suzie";
            Load += Suzie_Load;
            ((System.ComponentModel.ISupportInitialize)charImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFirst;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private PictureBox charImg;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDesc;
        private TextBox txtHurtBoxSize;
        private TextBox txtHurtBoxPos;
        private TextBox txtHitBoxPos;
        private TextBox txtHitBoxSize;
        private TextBox txtBlock;
        private TextBox txtRecovery;
        private TextBox txtActive;
        private TextBox txtStartup;
        private TextBox txtDmg;
        private TextBox txtName;
        private PictureBox pictureBox1;
    }
}