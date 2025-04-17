namespace TriBibliv2.view
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            pictureBox1 = new PictureBox();
            btnCloseAbout = new Button();
            linkGithub = new LinkLabel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(66, 227);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 44);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCloseAbout
            // 
            btnCloseAbout.Location = new Point(119, 320);
            btnCloseAbout.Name = "btnCloseAbout";
            btnCloseAbout.Size = new Size(76, 30);
            btnCloseAbout.TabIndex = 1;
            btnCloseAbout.Text = "OK";
            btnCloseAbout.UseVisualStyleBackColor = true;
            // 
            // linkGithub
            // 
            linkGithub.AutoSize = true;
            linkGithub.Location = new Point(47, 281);
            linkGithub.Name = "linkGithub";
            linkGithub.Size = new Size(226, 21);
            linkGithub.TabIndex = 2;
            linkGithub.TabStop = true;
            linkGithub.Text = "Visiter la page Github du projet";
            linkGithub.LinkClicked += linkGithub_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 111);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 3;
            label1.Text = "TriBibli 1.0";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(113, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 76);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 136);
            label2.Name = "label2";
            label2.Size = new Size(232, 21);
            label2.TabIndex = 5;
            label2.Text = "Un gestionnaire de bibliothèque";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 193);
            label4.Name = "label4";
            label4.Size = new Size(199, 21);
            label4.TabIndex = 7;
            label4.Text = "Une application fournie par";
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 362);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(linkGithub);
            Controls.Add(btnCloseAbout);
            Controls.Add(pictureBox1);
            Name = "FrmAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "A propos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCloseAbout;
        private LinkLabel linkGithub;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label4;
    }
}