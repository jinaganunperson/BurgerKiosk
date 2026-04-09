namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        int totalCost = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked) {
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Text = "메뉴를 선택하세요";
                return; 
            }

            int totalCost = 0;

            if (rdoHamBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Blue;
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 : 5,000원");
                if (chkPotato.Checked)
                {
                    totalCost += 3500;
                    lstOrder.Items.Add("감자튀김 : 3,500원");
                }
                if (chkCola.Checked)
                {
                    totalCost += 2500;
                    lstOrder.Items.Add("콜라 추가 : 2,500원");
                }
                if (chkCheese.Checked)
                {
                    totalCost += 1500;
                    lstOrder.Items.Add("치즈 추가 : 1,500원");
                }
                if (chkSauce.Checked)
                {
                    totalCost += 500;
                    lstOrder.Items.Add("소스 : 500원");
                }
                lblTotalCost.Text = "총금액: " + totalCost.ToString("N0") + "원";
            }
            else if (rdoBulgogiBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Blue;
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 : 4,000원");
                if (chkPotato.Checked)
                {
                    totalCost += 3500;
                    lstOrder.Items.Add("감자튀김 : 3,500원");
                }
                if (chkCola.Checked)
                {
                    totalCost += 2500;
                    lstOrder.Items.Add("콜라 추가 : 2,500원");
                }
                if (chkCheese.Checked)
                {
                    totalCost += 1500;
                    lstOrder.Items.Add("치즈 추가 : 1,500원");
                }
                if (chkSauce.Checked)
                {
                    totalCost += 500;
                    lstOrder.Items.Add("소스 : 500원");
                }
                lblTotalCost.Text = "총금액: " + totalCost.ToString("N0") + "원";
            }
            else if (rdoChickenBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Blue;
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 : 3,000원");
                if (chkPotato.Checked)
                {
                    totalCost += 3500;
                    lstOrder.Items.Add("감자튀김 : 3,500원");
                }
                if (chkCola.Checked)
                {
                    totalCost += 2500;
                    lstOrder.Items.Add("콜라 추가 : 2,500원");
                }
                if (chkCheese.Checked)
                {
                    totalCost += 1500;
                    lstOrder.Items.Add("치즈 추가 : 1,500원");
                }
                if (chkSauce.Checked)
                {
                    totalCost += 500;
                    lstOrder.Items.Add("소스 : 500원");
                }
                lblTotalCost.Text = "총금액: " + totalCost.ToString("N0") + "원";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear(); lblTotalCost.Text = "";
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Text = "총 합계 : 000원";
        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }
    }
}
