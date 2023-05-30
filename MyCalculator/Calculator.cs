namespace MyCalculator
{
    public partial class formCalculator : Form
    {
        //font
        Font biggerLabel = new Font("Lucida Console", 20);
        Font normalLabel = new Font("Lucida Console", 11);

        //variable
        double num1 = 0;
        double result = 0;
        string op = "";
        bool isOperationPerformed = false;

        public formCalculator()
        {
            InitializeComponent();
            LayoutInitialization();
            txtResult.Text = "0";
        }
        //---------number button method----------
        //all the number buttons
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((txtResult.Text == "0") || (isOperationPerformed == true))
            {
                txtResult.Clear();
            }            
            txtResult.Text += button.Text;
            isOperationPerformed = false;
        }
        //point button
        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }
            //txtResult.Text = Convert.ToString(txtResult.Text);
        }
        //-----------functional button method----------
        //plus minus button
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("-"))
            {
                if(txtResult.Text != "0")
                {
                    txtResult.Text = "-" + txtResult.Text;
                }
                else
                {
                    txtResult.Text = "-";
                }
            }
            else
            {
                txtResult.Text = txtResult.Text.Remove(0, 1);
            }
        }
        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            num1 = 0;
            result = 0;
            op = "";
            isOperationPerformed = false;
            lblStep.Text = "";
        }
        //BS button
        private void btnBS_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }
        //-----------Calculator button method-----------
        private void btnBasicCal_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                btnEqual.PerformClick();
                op = $"{button.Text}";
                lblStep.Text = Convert.ToString(result) + " " + op;
                isOperationPerformed = true;
            }
            else
            {
                op = $"{button.Text}";
                result = Convert.ToDouble(txtResult.Text);
                lblStep.Text = Convert.ToString(result) + " " + op;
                isOperationPerformed = true;
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    num1 = Convert.ToDouble(txtResult.Text);
                    result += num1;
                    txtResult.Text = result.ToString();
                    break;
                case "-":
                    num1 = Convert.ToDouble(txtResult.Text);
                    result -= num1;
                    txtResult.Text = result.ToString();
                    break;
                case "*":
                    num1 = Convert.ToDouble(txtResult.Text);
                    result *= num1;
                    txtResult.Text = result.ToString();
                    break;
                case "/":                    
                    num1 = Convert.ToDouble(txtResult.Text);
                    if (num1 == 0)
                    {
                        txtResult.Text = "---Error---";
                        break;
                    }
                    result /= num1;
                    txtResult.Text = result.ToString();
                    break;
                case "^":
                    num1 = Convert.ToDouble(txtResult.Text);
                    result = Math.Pow(result, num1);                    
                    txtResult.Text = result.ToString();
                    break;
            }
            isOperationPerformed = true;
        }
        //square root
        private void btnRoot_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResult.Text);
            result = Math.Sqrt(num1);
            txtResult.Text = result.ToString();
        }
        //1/x function
        private void btn1x_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResult.Text);
            result = 1 / num1;
            txtResult.Text = result.ToString();
        }
        //square
        private void btnSquare_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResult.Text);
            result = num1 * num1;
            txtResult.Text = result.ToString();
        }
        //factorial x!
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResult.Text);
            result = 1;
            while(num1 > 0)
            {
                result *= num1;
                num1--;
            }
            txtResult.Text = result.ToString();
        }
        //sine
        private void btnSine_Click(object sender, EventArgs e)
        {
            result = Math.Sin(Convert.ToDouble(txtResult.Text));
            txtResult.Text = result.ToString();
        }
        //cos
        private void btnCos_Click(object sender, EventArgs e)
        {
            result = Math.Cos(Convert.ToDouble(txtResult.Text));
            txtResult.Text = result.ToString();
        }
        //tan
        private void btnTan_Click(object sender, EventArgs e)
        {
            result = Math.Tan(Convert.ToDouble(txtResult.Text));
            txtResult.Text = result.ToString();
        }
        //pi
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToString(Math.PI);
        }

        //---------layout Method----------
        //scientific
        private void rdoScientfic_CheckedChanged(object sender, EventArgs e)
        {
            //form size
            Size = new Size(648, 500);
            //result text bar
            txtResult.Size = new Size(602, 50);
            //label
            lblModel.Location = new Point(460, 101);
            lblModel.Font = biggerLabel;
            lblModel.Text = "HAL 10000";
            //display the scientific part
            DisplayScientificPart(true);
        }
        //standard
        private void rdoStandard_CheckedChanged(object sender, EventArgs e)
        {
            //form size
            Size = new Size(470, 500);
            //result text bar
            txtResult.Size = new Size(419, 50);
            //label
            lblModel.Location = new Point(348, 87);
            lblModel.Font = normalLabel;
            lblModel.Text = "HAL 9000";
            //hide the scientific part
            DisplayScientificPart(false);
        }
        //dark mode
        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            //checked
            if (chkDarkMode.Checked)
            {
                txtResult.BackColor = Color.DarkGray;
                BackColor = Color.DarkGray;
                tpCalculator.BackColor = Color.DarkGray;
                ButtonBackColor(Color.LightGray);
            }
            //unchecked
            else
            {
                txtResult.BackColor = SystemColors.Window;
                BackColor = SystemColors.Window;
                tpCalculator.BackColor = Color.Transparent;
                ButtonBackColor(Color.DarkOrange, Color.LightSeaGreen);
            }
        }
        //reset layout -> standard mode, non dark mode
        private void LayoutInitialization()
        {
            rdoStandard.Checked = true;
            chkDarkMode.Checked = false;
        }        
        //determine does scientifi part button display -> using aurgment
        private void DisplayScientificPart(bool isDisplayed)
        {
            btnSquare.Visible = isDisplayed;
            btnFactorial.Visible = isDisplayed;
            btnSine.Visible = isDisplayed;
            btnCos.Visible = isDisplayed;
            btnTan.Visible = isDisplayed;
            btnXSquareY.Visible = isDisplayed;
            btnPi.Visible = isDisplayed;
            btnLuckyNum.Visible = isDisplayed;
        }

        //overload method, one for dark mode, one for normal mode
        private void ButtonBackColor(Color color, Color color2)
        {
            //normal part
            btnAdd.BackColor = color;
            btnMultiply.BackColor = color;
            btnSubtract.BackColor = color;
            btnDivide.BackColor = color;
            //scientific part
            btnSquare.BackColor = color2;
            btnFactorial.BackColor = color2;
            btnSine.BackColor = color2;
            btnCos.BackColor = color2;
            btnTan.BackColor = color2;
            btnXSquareY.BackColor = color2;
            btnPi.BackColor = color2;
            btnLuckyNum.BackColor = color2;
        }
        private void ButtonBackColor(Color color)
        {
            //normal part
            btnAdd.BackColor = color;
            btnMultiply.BackColor = color;
            btnSubtract.BackColor = color;
            btnDivide.BackColor = color;
            //scientific part
            btnSquare.BackColor = color;
            btnFactorial.BackColor = color;
            btnSine.BackColor = color;
            btnCos.BackColor = color;
            btnTan.BackColor = color;
            btnXSquareY.BackColor = color;
            btnPi.BackColor = color;
            btnLuckyNum.BackColor = color;
        }        
        //---------About Me-----------
        //select summer picture
        private void rdoSummer_CheckedChanged(object sender, EventArgs e)
        {
            picWinter.Visible = false;
            picSummer.Visible = true;
        }
        //select winter picture
        private void rdoWinter_CheckedChanged(object sender, EventArgs e)
        {
            picWinter.Visible = true;
            picSummer.Visible = false;
        }
        //select About Me page
        private void AboutMe_Click(object sender, EventArgs e)
        {
            
            LayoutInitialization();
            picWinter.Visible = false;
            picSummer.Visible = false;            
        }
        //FOR FUN
        //hidden function, clicking the modal name
        private void lblModel_Click(object sender, EventArgs e)
        {
            if (rdoScientfic.Checked)
            {
                txtResult.Text = "I'm HAL10000 computer";

            }
            else
            {
                txtResult.Text = "I'm HAL9000 computer";

            }
        }
        //lucky number
        private void btnLuckyNum_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> randomList = new List<int>();
            while (randomList.Count < 7)
            {
                int randNum = random.Next(1, 50);
                if (!randomList.Contains(randNum))
                {
                    randomList.Add(randNum);
                }
            }
            txtResult.Text = string.Join(", ", randomList);
        }        
    }
}