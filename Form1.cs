namespace BurgerKiosk
{
    public partial class burger : Form
    {

        public burger()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderList();
        }
        int totalCost = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Text = "메뉴를 선택하세요";
                return;
            }

            int totalCost = 0;

            if (rdoHamBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Blue;
                totalCost += 5000;

                if (chkPotato.Checked)
                {
                    totalCost += 3500;

                }
                if (chkCola.Checked)
                {
                    totalCost += 2500;

                }
                if (chkCheese.Checked)
                {
                    totalCost += 1500;

                }
                if (chkSauce.Checked)
                {
                    totalCost += 500;

                }
                
            }
            else if (rdoBulgogiBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Blue;
                totalCost += 4000;

                if (chkPotato.Checked)
                {
                    totalCost += 3500;

                }
                if (chkCola.Checked)
                {
                    totalCost += 2500;

                }
                if (chkCheese.Checked)
                {
                    totalCost += 1500;

                }
                if (chkSauce.Checked)
                {
                    totalCost += 500;

                }
                
            }
            else if (rdoChickenBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Blue;
                totalCost += 3000;

                if (chkPotato.Checked)
                {
                    totalCost += 3500;

                }
                if (chkCola.Checked)
                {
                    totalCost += 2500;

                }
                if (chkCheese.Checked)
                {
                    totalCost += 1500;

                }
                if (chkSauce.Checked)
                {
                    totalCost += 500;

                }
                
            }
            lblTotalCost.Text = "총금액: " + totalCost.ToString("N0") + "원";

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

        private void chkSauce_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        private void rdoBulgogiBurger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        // 84번줄 외에도 다른 줄에서 비슷한 오류(rdoChickenBurger 등)가 난다면 아래도 추가하세요.
        private void rdoChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        private void chkPotato_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        private void btnOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // 이 키 입력을 여기서 끝내고 버튼으로 전달하지 않음
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // 이 키 입력을 여기서 끝내고 버튼으로 전달하지 않음
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnOrder_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                // 스페이스바가 눌렸다는 신호를 여기서 증발시킵니다.
            }
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                // 스페이스바가 눌렸다는 신호를 여기서 증발시킵니다.
            }
        }
        private void UpdateOrderList()
        {
            // 1. 기존 내역과 합계 초기화
            lstOrder.Items.Clear();
            int currentTotal = 0;

            // 2. 버거 선택 확인 및 가격 추가
            if (rdoHamBurger.Checked)
            {
                lstOrder.Items.Add("햄버거 : 5,000원");
                currentTotal += 5000;

            }
            else if (rdoBulgogiBurger.Checked)
            {
                lstOrder.Items.Add("불고기버거 : 4,000원");
                currentTotal += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                currentTotal += 3000;
                lstOrder.Items.Add("치킨버거 : 3,000원");
            }
            lblTotalCost.Text = "총금액: " + currentTotal.ToString("N0") + "원";

            // 메뉴가 선택된 경우에만 옵션 계산
            if (currentTotal > 0)
            {
                lblTotalCost.ForeColor = Color.Blue; // 다시 파란색으로

                if (chkPotato.Checked)
                {
                    currentTotal += 3500;
                    lstOrder.Items.Add("감자튀김 : 3,500원");
                }
                if (chkCola.Checked)
                {
                    currentTotal += 2500;
                    lstOrder.Items.Add("콜라 추가 : 2,500원");
                }
                if (chkCheese.Checked)
                {
                    currentTotal += 1500;
                    lstOrder.Items.Add("치즈 추가 : 1,500원");
                }
                if (chkSauce.Checked)
                {
                    currentTotal += 500;
                    lstOrder.Items.Add("소스 : 500원");
                }
                lblTotalCost.Text = "총금액: " + currentTotal.ToString("N0") + "원";

            }
            else
            {
                lblTotalCost.Text = "메뉴를 선택하세요";
            }
        }
    }
    
}