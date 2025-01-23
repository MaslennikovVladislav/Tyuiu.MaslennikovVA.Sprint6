using Tyuiu.MaslennikovVA.Sprint6.Task1.V18.Lib;
namespace Tyuiu.MaslennikovVA.Sprint6.Task1.V18
{
    public partial class FormMain_MVA : Form
    {
        public FormMain_MVA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonGo_MVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_MVA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_MVA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray =
                 ds.GetMassFunction(startStep, stopStep);
                textBoxOutput_MVA.Text = "";
                textBoxOutput_MVA.AppendText("+----------+-------------+" + Environment.NewLine);
                textBoxOutput_MVA.AppendText("|    X     |   f(x)      |" + Environment.NewLine);
                textBoxOutput_MVA.AppendText("+----------+-------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |   {1, 6:f2}    | ", startStep, valueArray[i]);
                    textBoxOutput_MVA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxOutput_MVA.AppendText("+----------+-------------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFAQ_MVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-2 Масленников Владислав Александрович");
        }
    }
}
