namespace BurgerKiosk
{
    partial class burger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(burger));
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            btnOrder = new Button();
            btnreset = new Button();
            grpoption = new GroupBox();
            grpmenu = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            grborder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            lblkiosk = new Label();
            pictureBox3 = new PictureBox();
            grpoption.SuspendLayout();
            grpmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grborder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            rdoHamBurger.ForeColor = Color.Maroon;
            rdoHamBurger.Location = new Point(23, 71);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(162, 41);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            rdoHamBurger.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            rdoBulgogiBurger.ForeColor = Color.Maroon;
            rdoBulgogiBurger.Location = new Point(23, 188);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(238, 41);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += rdoBulgogiBurger_CheckedChanged;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            rdoChickenBurger.ForeColor = Color.Maroon;
            rdoChickenBurger.Location = new Point(23, 309);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(200, 41);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += rdoChickenBurger_CheckedChanged;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            chkPotato.ForeColor = Color.Maroon;
            chkPotato.Location = new Point(24, 56);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(201, 41);
            chkPotato.TabIndex = 3;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            chkPotato.CheckedChanged += chkPotato_CheckedChanged;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.BackColor = SystemColors.Control;
            chkCola.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            chkCola.ForeColor = Color.Maroon;
            chkCola.Location = new Point(24, 135);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(125, 41);
            chkCola.TabIndex = 4;
            chkCola.TabStop = false;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = false;
            chkCola.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            chkCheese.ForeColor = Color.Maroon;
            chkCheese.Location = new Point(24, 232);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(201, 41);
            chkCheese.TabIndex = 5;
            chkCheese.TabStop = false;
            chkCheese.Text = "치즈추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            chkSauce.ForeColor = Color.Maroon;
            chkSauce.Location = new Point(24, 325);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(201, 41);
            chkSauce.TabIndex = 6;
            chkSauce.TabStop = false;
            chkSauce.Text = "소스추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += chkSauce_CheckedChanged;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            btnOrder.ForeColor = Color.Black;
            btnOrder.Location = new Point(750, 607);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(217, 61);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += button1_Click;
            btnOrder.KeyDown += btnOrder_KeyDown;
            btnOrder.KeyUp += btnOrder_KeyUp;
            // 
            // btnreset
            // 
            btnreset.BackColor = Color.Red;
            btnreset.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            btnreset.ForeColor = Color.Black;
            btnreset.Location = new Point(989, 607);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(217, 61);
            btnreset.TabIndex = 5;
            btnreset.Text = "초기화";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += button2_Click;
            btnreset.KeyDown += button2_KeyDown;
            btnreset.KeyUp += button2_KeyUp;
            // 
            // grpoption
            // 
            grpoption.Controls.Add(chkSauce);
            grpoption.Controls.Add(chkCheese);
            grpoption.Controls.Add(chkCola);
            grpoption.Controls.Add(chkPotato);
            grpoption.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            grpoption.ForeColor = Color.FromArgb(192, 0, 0);
            grpoption.Location = new Point(542, 165);
            grpoption.Name = "grpoption";
            grpoption.Size = new Size(266, 394);
            grpoption.TabIndex = 2;
            grpoption.TabStop = false;
            grpoption.Text = "추가옵션";
            // 
            // grpmenu
            // 
            grpmenu.Controls.Add(pictureBox2);
            grpmenu.Controls.Add(pictureBox1);
            grpmenu.Controls.Add(rdoChickenBurger);
            grpmenu.Controls.Add(rdoBulgogiBurger);
            grpmenu.Controls.Add(rdoHamBurger);
            grpmenu.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            grpmenu.ForeColor = Color.FromArgb(192, 0, 0);
            grpmenu.Location = new Point(26, 167);
            grpmenu.Name = "grpmenu";
            grpmenu.Size = new Size(498, 394);
            grpmenu.TabIndex = 1;
            grpmenu.TabStop = false;
            grpmenu.Text = "메뉴선택";
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
            // grborder
            // 
            grborder.Controls.Add(lblTotalCost);
            grborder.Controls.Add(lstOrder);
            grborder.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            grborder.ForeColor = Color.FromArgb(192, 0, 0);
            grborder.Location = new Point(825, 165);
            grborder.Name = "grborder";
            grborder.Size = new Size(440, 394);
            grborder.TabIndex = 3;
            grborder.TabStop = false;
            grborder.Text = "주문내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.BackColor = Color.Transparent;
            lblTotalCost.Font = new Font("굴림", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(32, 311);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(183, 37);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 합계 : ";
            lblTotalCost.Click += lblTotalCost_Click;
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("굴림", 13.875F, FontStyle.Bold);
            lstOrder.ForeColor = Color.Blue;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(19, 56);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(415, 226);
            lstOrder.TabIndex = 0;
            lstOrder.TabStop = false;
            // 
            // lblkiosk
            // 
            lblkiosk.AutoSize = true;
            lblkiosk.Font = new Font("맑은 고딕", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblkiosk.ForeColor = Color.Blue;
            lblkiosk.Location = new Point(80, 35);
            lblkiosk.Name = "lblkiosk";
            lblkiosk.Size = new Size(694, 100);
            lblkiosk.TabIndex = 0;
            lblkiosk.Text = "버거 주문 키오스크";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(303, 430);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(176, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // burger
            // 
            AutoScaleDimensions = new SizeF(15F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 734);
            Controls.Add(pictureBox3);
            Controls.Add(lblkiosk);
            Controls.Add(grborder);
            Controls.Add(grpmenu);
            Controls.Add(grpoption);
            Controls.Add(btnreset);
            Controls.Add(btnOrder);
            ForeColor = Color.Maroon;
            Name = "burger";
            Text = "Buger Kiosk";
            grpoption.ResumeLayout(false);
            grpoption.PerformLayout();
            grpmenu.ResumeLayout(false);
            grpmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grborder.ResumeLayout(false);
            grborder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private Button btnreset;
        private Button btnOrder;
        private GroupBox grpoption;
        private GroupBox grpmenu;
        private GroupBox grborder;
        private Label lblkiosk;
        
        private ListBox lstOrder;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label lblTotalCost;
    }
}
