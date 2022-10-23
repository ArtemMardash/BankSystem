namespace BankSystem
{
    public partial class Form1 : Form
    {
        int percent;
        double finalPersent;
        string answer = "";
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Open Form2 when button1 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double allPay = 0;
            double remainder = Convert.ToDouble(textBox1.Text);
            int time = trackBar1.Value;
            double sum = 0;
            /// Count Annuity payment
            double Ap = (Convert.ToDouble(textBox1.Text) * (finalPersent / 1200)) / (1 - Math.Pow((1 + finalPersent / 1200), -time));
            /// Count Differentiated payment
            double dp = ((finalPersent / 100)) * ((time + 1) / 2) * Convert.ToDouble(textBox1.Text);
            double bp = Convert.ToDouble(textBox1.Text) + dp;
       
            answer = " Annuity payment = " + Ap + Environment.NewLine + "Differentiated payment: overpayments = " + dp + Environment.NewLine + "all payment = " + bp;
            Form2 form2 = new Form2(this, answer);
            form2.ShowDialog();
        }
        /// <summary>
        /// persent for Credit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e, int sale)
        {
            if(trackBar1.Value <= 12)
            {
                percent = 25;
            }
            if(trackBar1.Value > 12 && trackBar1.Value <= 36)
            {
                percent = 20;
            }
            if(trackBar1.Value > 36 && trackBar1.Value <= trackBar1.Maximum)
            {
                percent = 17;
            }
            finalPersent = percent + sale;
            label4.Text = finalPersent.ToString();
        }
        /// <summary>
        /// Create variable sale to count sale 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int sale = ChoiseCheckBox();
            trackBar1_Scroll(sender, e, sale);
        }
        /// <summary>
        /// Count sale
        /// </summary>
        /// <returns></returns>
        private int ChoiseCheckBox()
        {
            int student;
            int parent;
            int old;
            int sale;
            if(checkBox1.Checked)
            {
                student = -1;
            }
            else
            {
                student = 0;
            }
            if(checkBox2.Checked)
            {
                parent = -3;
            }
            else
            {
                parent = 0;
            }
            if(checkBox3.Checked)
            {
                old = -5;
            }
            else
            {
                old = 0;
            }

            sale = student + parent + old;
            return sale;
        }
        /// <summary>
        /// If checkBox1 checked sale increase 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int sale = ChoiseCheckBox();
            trackBar1_Scroll(sender, e, sale);
        }
        /// <summary>
        /// If checkBox2 checked sale increase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int sale = ChoiseCheckBox();
            trackBar1_Scroll(sender, e, sale);
        }
        /// <summary>
        /// If checkBox3 checked sale increase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int sale = ChoiseCheckBox();
            trackBar1_Scroll(sender, e, sale);
        }
    }
}