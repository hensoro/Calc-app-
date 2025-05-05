namespace Calc_app_
{
    public partial class Form1 : Form
    {
         string opperator;  
        int Val1;
        int Val2;
        public Form1()
        {
            InitializeComponent();
            AnsTxt.Text = "0";
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (AnsTxt.Text == "0") 
            {
                AnsTxt.Clear();
                AnsTxt.Text = btn.Text;
            }
            else
            {
                AnsTxt.Text = AnsTxt.Text + btn.Text;
            }

        }

        private void BtnExit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Val1=0;
            Val2 = 0;
            AnsTxt.Clear();
            AnsTxt.Text = "0";
            opperator = null;
        }

        private void BtnOp_click(object sender, EventArgs e)
        {
            if (opperator != null)
            {
                switch (opperator)
                {
                    case "+":
                        if (Val2 == 0) { Val2 = Convert.ToInt32(AnsTxt.Text); }
                        AnsTxt.Text = Convert.ToString(Val1 + Val2);
                        break;

                    case "-":
                        if (Val2 == 0) { Val2 = Convert.ToInt32(AnsTxt.Text); }
                        AnsTxt.Text = Convert.ToString(Val1 - Val2);
                        break;

                    case "*":
                        if (Val2 == 0) { Val2 = Convert.ToInt32(AnsTxt.Text); }
                        AnsTxt.Text = Convert.ToString(Val1 * Val2);
                        break;

                    case "/":
                        if (Val2 == 0) { Val2 = Convert.ToInt32(AnsTxt.Text); }
                        AnsTxt.Text = Convert.ToString(Val1 / Val2);
                        break;

                }
                opperator = null;

            }
            else
            {
                Button btn = (Button)sender;
                if (Val1 == 0) { Val1 = Convert.ToInt32(AnsTxt.Text); }
                else { Val2 = Convert.ToInt32(AnsTxt.Text); }
                opperator = btn.Text;
                AnsTxt.Clear();
                AnsTxt.Text = "0";
            }
            

        }

        private void BtnEqual_click(object sender, EventArgs e)
        {
            switch (opperator)
            {
                case "+":
                    if (Val2 == 0) { Val2=Convert.ToInt32(AnsTxt.Text); }
                    AnsTxt.Text = Convert.ToString(Val1 + Val2);
                    break;

                case "-":
                    if (Val2 == 0) { Val2 = Convert.ToInt32(AnsTxt.Text); }
                    AnsTxt.Text = Convert.ToString(Val1 - Val2);
                    break;

                case "*":
                    if (Val2 == 0) { Val2 = Convert.ToInt32(AnsTxt.Text); }
                    AnsTxt.Text = Convert.ToString(Val1 * Val2);
                    break;

                case "/":
                    if (Val2 == 0) { Val2 = Convert.ToInt32(AnsTxt.Text); }
                    AnsTxt.Text = Convert.ToString(Val1 / Val2);
                    break;

                   
            }
            Val1 = 0;
            Val2 = 0;
            opperator = null;
        }
    }
}
