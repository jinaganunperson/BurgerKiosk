namespace BurgerKiosk

{

    public partial class burger : Form

    {



        int waitingNumber = 1;





        public burger()

        {

            InitializeComponent();
            nudHam.ValueChanged += (s, e) => UpdateOrderList();
            nudbul.ValueChanged += (s, e) => UpdateOrderList();
            nudchick.ValueChanged += (s, e) => UpdateOrderList();

            nudPotato.ValueChanged += (s, e) => UpdateOrderList();
            nudCola.ValueChanged += (s, e) => UpdateOrderList();
            nudCheese.ValueChanged += (s, e) => UpdateOrderList();
            nudSauce.ValueChanged += (s, e) => UpdateOrderList();
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

            string finalResult = lblTotalCost.Text;
            MessageBox.Show($"{finalResult}\n주문이 완료되었습니다!\n대기번호: {waitingNumber}번", "주문 접수");

            waitingNumber++;



            button2_Click(sender, e);

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

            rdoHamBurger.TabStop = true;

            nudHam.Value = 1;
            nudbul.Value = 1;
            nudchick.Value = 1;
            nudPotato.Value = 1; 
            nudCola.Value = 1; 
            nudCheese.Value = 1; 
            nudSauce.Value = 1;

            lstOrder.Items.Clear(); lblTotalCost.Text = "";

            lblTotalCost.ForeColor = Color.Blue;

            lblTotalCost.Text = "총 합계 :";

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
            lstOrder.Items.Clear();
            int currentTotal = 0;

            // 1. 버거 계산 (기존 코드 유지)
            if (rdoHamBurger.Checked)
            {
                int qty = (int)nudHam.Value;
                int price = 5000 * qty;
                lstOrder.Items.Add($"햄버거 x {qty} : {price:N0}원");
                currentTotal += price;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                int qty = (int)nudbul.Value;
                int price = 4000 * qty;
                lstOrder.Items.Add($"불고기버거 x {qty} : {price:N0}원");
                currentTotal += price;
            }
            else if (rdoChickenBurger.Checked)
            {
                int qty = (int)nudchick.Value;
                int price = 3000 * qty;
                lstOrder.Items.Add($"치킨버거 x {qty} : {price:N0}원");
                currentTotal += price;
            }

            // 2. 추가 옵션 계산 (수량 반영)
            if (currentTotal > 0)
            {
                lblTotalCost.ForeColor = Color.Blue;

                // 감자튀김
                if (chkPotato.Checked)
                {
                    int qty = (int)nudPotato.Value;
                    int price = 3500 * qty;
                    lstOrder.Items.Add($"감자튀김 x {qty} : {price:N0}원");
                    currentTotal += price;
                }
                // 콜라
                if (chkCola.Checked)
                {
                    int qty = (int)nudCola.Value;
                    int price = 2500 * qty;
                    lstOrder.Items.Add($"콜라 x {qty} : {price:N0}원");
                    currentTotal += price;
                }
                // 치즈
                if (chkCheese.Checked)
                {
                    int qty = (int)nudCheese.Value;
                    int price = 1500 * qty;
                    lstOrder.Items.Add($"치즈 추가 x {qty} : {price:N0}원");
                    currentTotal += price;
                }
                // 소스
                if (chkSauce.Checked)
                {
                    int qty = (int)nudSauce.Value;
                    int price = 500 * qty;
                    lstOrder.Items.Add($"소스 x {qty} : {price:N0}원");
                    currentTotal += price;
                }

                if (chkPotato.Checked && chkCola.Checked)
                {
                    // 1. 현재 선택된 버거의 수량 파악
                    int burgerQty = 0;
                    if (rdoHamBurger.Checked) burgerQty = (int)nudHam.Value;
                    else if (rdoBulgogiBurger.Checked) burgerQty = (int)nudbul.Value;
                    else if (rdoChickenBurger.Checked) burgerQty = (int)nudchick.Value;

                    // 2. 버거, 감자튀김, 콜라의 수량 가져오기
                    int potatoQty = (int)nudPotato.Value;
                    int colaQty = (int)nudCola.Value;

                    // 3. 세 가지 중 가장 작은 값이 '완성된 세트의 개수'입니다.
                    // Math.Min을 중첩해서 세 값 중 최소값을 찾습니다.
                    int setQuantity = Math.Min(burgerQty, Math.Min(potatoQty, colaQty));

                    // 4. 세트가 1개 이상일 때만 할인 적용
                    if (setQuantity > 0)
                    {
                        int totalDiscount = setQuantity * 1000; // 세트당 1,000원 할인
                        currentTotal -= totalDiscount;

                        lstOrder.Items.Add($"세트 할인 X {setQuantity} : -{totalDiscount:N0}원");
                    }
                }

                // 최종 합계 출력 (이미 차감된 currentTotal이 반영됨)
                lblTotalCost.Text = "총금액: " + currentTotal.ToString("N0") + "원";
            }
            else
            {
                lblTotalCost.Text = "메뉴를 선택하세요";
            }

            // 조작 시 제한 시간 리셋
            timeLeft = 100;
        }

        private void nudHam_ValueChanged(object sender, EventArgs e) => UpdateOrderList();
        private void nudbul_ValueChanged(object sender, EventArgs e) => UpdateOrderList();
        private void nudchick_ValueChanged(object sender, EventArgs e) => UpdateOrderList();

        private void nudHam_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        private void nudbul_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        private void nudchick_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        int timeLeft = 100;

        private void timerLimit_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimer.Text = $"{timeLeft}초"; // 시간 표시용 라벨

                // 10초 남았을 때 빨간색으로 경고
                if (timeLeft <= 10) lblTimer.ForeColor = Color.Red;
                else lblTimer.ForeColor = Color.Black;
            }
            else
            {
                // 0초가 되면 실행될 로직
                timerLimit.Stop(); // 잠시 멈춤
                MessageBox.Show("주문 시간이 초과되었습니다. 처음부터 다시 시작해주세요.", "시간 초과");
                button2_Click(sender, e); // 모든 선택 초기화
                timeLeft = 100; // 시간 리셋
                timerLimit.Start(); // 다시 시작
            }
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }

}