namespace FirstFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int answer = 0;
            char operationchar;

    
            num1 = Int32.Parse(form_num1.Text);
            num2 = Int32.Parse(form_num2.Text);
            operationchar = Char.Parse(form_operation.Text);


            if (operationchar.Equals('+'))
                answer = num1 + num2;
                form_answer.Text = Convert.ToString(answer);

            if (operationchar.Equals('-'))
                answer = num1 - num2;
                form_answer.Text = Convert.ToString(answer);

            if (operationchar.Equals('*'))
                answer = num1 * num2;
                form_answer.Text = Convert.ToString(answer);

        }
    }
}