namespace Ruby_Cafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            moneyLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            payButton = new Button();
            cardListBox = new ListBox();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            hamburgerPictureBox = new PictureBox();
            coffePictureBox = new PictureBox();
            beerPictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hamburgerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)beerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(moneyLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 450);
            panel1.TabIndex = 0;
            // 
            // moneyLabel
            // 
            moneyLabel.Dock = DockStyle.Bottom;
            moneyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            moneyLabel.ForeColor = Color.Lime;
            moneyLabel.Location = new Point(0, 427);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(175, 23);
            moneyLabel.TabIndex = 1;
            moneyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(0, 88);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 0;
            label1.Text = "Ruby Cafe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.store_icon_icons_com_54371;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(payButton);
            panel2.Controls.Add(cardListBox);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(625, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 450);
            panel2.TabIndex = 1;
            // 
            // payButton
            // 
            payButton.BackColor = Color.FromArgb(128, 255, 128);
            payButton.Dock = DockStyle.Bottom;
            payButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            payButton.ForeColor = Color.FromArgb(0, 64, 0);
            payButton.Location = new Point(0, 404);
            payButton.Name = "payButton";
            payButton.Size = new Size(175, 46);
            payButton.TabIndex = 4;
            payButton.Text = "Pay";
            payButton.UseVisualStyleBackColor = false;
            payButton.Click += payButton_Click;
            // 
            // cardListBox
            // 
            cardListBox.BorderStyle = BorderStyle.None;
            cardListBox.Dock = DockStyle.Top;
            cardListBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardListBox.FormattingEnabled = true;
            cardListBox.ItemHeight = 21;
            cardListBox.Location = new Point(0, 23);
            cardListBox.Name = "cardListBox";
            cardListBox.Size = new Size(175, 357);
            cardListBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 23);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(pictureBox9);
            panel3.Controls.Add(pictureBox10);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(hamburgerPictureBox);
            panel3.Controls.Add(coffePictureBox);
            panel3.Controls.Add(beerPictureBox);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(175, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 450);
            panel3.TabIndex = 2;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(164, 327);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(122, 111);
            pictureBox8.TabIndex = 12;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(328, 327);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(122, 111);
            pictureBox9.TabIndex = 11;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(0, 327);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(122, 111);
            pictureBox10.TabIndex = 10;
            pictureBox10.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(164, 170);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(122, 111);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(328, 170);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(122, 111);
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(0, 170);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(122, 111);
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // hamburgerPictureBox
            // 
            hamburgerPictureBox.Cursor = Cursors.Hand;
            hamburgerPictureBox.Image = Properties.Resources._32382hamburger_98925;
            hamburgerPictureBox.Location = new Point(164, 0);
            hamburgerPictureBox.Name = "hamburgerPictureBox";
            hamburgerPictureBox.Size = new Size(122, 111);
            hamburgerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            hamburgerPictureBox.TabIndex = 6;
            hamburgerPictureBox.TabStop = false;
            hamburgerPictureBox.Click += hamburgerPictureBox_Click;
            // 
            // coffePictureBox
            // 
            coffePictureBox.Cursor = Cursors.Hand;
            coffePictureBox.Image = Properties.Resources._coffee_container_89755;
            coffePictureBox.Location = new Point(328, 0);
            coffePictureBox.Name = "coffePictureBox";
            coffePictureBox.Size = new Size(122, 111);
            coffePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            coffePictureBox.TabIndex = 5;
            coffePictureBox.TabStop = false;
            coffePictureBox.Click += coffePictureBox_Click;
            // 
            // beerPictureBox
            // 
            beerPictureBox.Cursor = Cursors.Hand;
            beerPictureBox.Image = Properties.Resources.Beer_Bottle_icon_icons_com_68782;
            beerPictureBox.Location = new Point(0, 0);
            beerPictureBox.Name = "beerPictureBox";
            beerPictureBox.Size = new Size(122, 111);
            beerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            beerPictureBox.TabIndex = 4;
            beerPictureBox.TabStop = false;
            beerPictureBox.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ruby Cafe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)hamburgerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)beerPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private Label moneyLabel;
        private PictureBox beerPictureBox;
        private ListBox cardListBox;
        private Label label2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox hamburgerPictureBox;
        private PictureBox coffePictureBox;
        private Button payButton;
    }
}
