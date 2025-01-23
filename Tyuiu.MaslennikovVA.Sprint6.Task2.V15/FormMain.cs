using Tyuiu.MaslennikovVA.Sprint6.Task2.V15.Lib;
namespace Tyuiu.MaslennikovVA.Sprint6.Task2.V15
{
    public partial class Form1 : Form
    {
        public Form1()
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

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_MVA.Titles.Add("График функции");

                this.chartFunction_MVA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_MVA.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewOut_MVA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_MVA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFAQ_MVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-2 Масленников Владислав Александрович");
        }
    }
}
