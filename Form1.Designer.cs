namespace BurgerKiosk
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.Maroon;
            radioButton1.Location = new Point(23, 71);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(159, 41);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "햄버거";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Maroon;
            radioButton2.Location = new Point(23, 188);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(233, 41);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "불고기버거";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.Maroon;
            radioButton3.Location = new Point(23, 309);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(196, 41);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "치킨버거";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Maroon;
            checkBox1.Location = new Point(24, 56);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(197, 41);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "감자튀김";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = SystemColors.Control;
            checkBox2.ForeColor = Color.Maroon;
            checkBox2.Location = new Point(24, 141);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(123, 41);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "콜라";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = Color.Maroon;
            checkBox3.Location = new Point(24, 232);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(197, 41);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "치즈추가";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = Color.Maroon;
            checkBox4.Location = new Point(24, 325);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(197, 41);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "소스추가";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("굴림", 13.875F);
            button1.Location = new Point(750, 607);
            button1.Name = "button1";
            button1.Size = new Size(217, 61);
            button1.TabIndex = 7;
            button1.Text = "주문하기";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("굴림", 13.875F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(989, 607);
            button2.Name = "button2";
            button2.Size = new Size(217, 61);
            button2.TabIndex = 8;
            button2.Text = "초기화";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("굴림", 13.875F);
            groupBox1.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox1.Location = new Point(613, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 394);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "추가옵션";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("굴림", 13.875F);
            groupBox2.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox2.Location = new Point(89, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(486, 394);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "메뉴선택";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox3.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox3.Location = new Point(903, 165);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(303, 394);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문내역";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(80, 35);
            label1.Name = "label1";
            label1.Size = new Size(694, 100);
            label1.TabIndex = 12;
            label1.Text = "버거 주문 키오스크";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("굴림", 13.875F);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(19, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(275, 226);
            listBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(20, 309);
            label2.Name = "label2";
            label2.Size = new Size(180, 50);
            label2.TabIndex = 1;
            label2.Text = "총 금액 : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(277, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(277, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(366, 430);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(176, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 734);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.Maroon;
            Name = "Form1";
            Text = "Buger Kiosk";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}
