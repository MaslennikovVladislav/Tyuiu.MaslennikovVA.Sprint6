namespace Tyuiu.MaslennikovVA.Sprint6.Task2.V15
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_MVA = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBoxOutput_MVA = new GroupBox();
            chartFunction_MVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewOut_MVA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            labelResult = new Label();
            groupBoxInput_MVA = new GroupBox();
            labelEnd_MVA = new Label();
            labelstart_MVA = new Label();
            textBoxStartStep_MVA = new TextBox();
            textBoxStopStep_MVA = new TextBox();
            buttonFAQ_MVA = new Button();
            buttonGo_MVA = new Button();
            groupBoxTask_MVA.SuspendLayout();
            groupBoxOutput_MVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MVA).BeginInit();
            groupBoxInput_MVA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MVA
            // 
            groupBoxTask_MVA.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxTask_MVA.Controls.Add(label2);
            groupBoxTask_MVA.Controls.Add(label1);
            groupBoxTask_MVA.Location = new Point(-8, 18);
            groupBoxTask_MVA.Name = "groupBoxTask_MVA";
            groupBoxTask_MVA.Size = new Size(566, 326);
            groupBoxTask_MVA.TabIndex = 4;
            groupBoxTask_MVA.TabStop = false;
            groupBoxTask_MVA.Text = "Условие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(359, 15);
            label2.TabIndex = 8;
            label2.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(322, 15);
            label1.TabIndex = 7;
            label1.Text = "Протабулировать функцию  F(x) на заданном диапозоне.";
            // 
            // groupBoxOutput_MVA
            // 
            groupBoxOutput_MVA.Controls.Add(chartFunction_MVA);
            groupBoxOutput_MVA.Controls.Add(dataGridViewOut_MVA);
            groupBoxOutput_MVA.Controls.Add(labelResult);
            groupBoxOutput_MVA.Location = new Point(564, 18);
            groupBoxOutput_MVA.Name = "groupBoxOutput_MVA";
            groupBoxOutput_MVA.Size = new Size(596, 426);
            groupBoxOutput_MVA.TabIndex = 6;
            groupBoxOutput_MVA.TabStop = false;
            groupBoxOutput_MVA.Text = "Вывод данных";
            // 
            // chartFunction_MVA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_MVA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_MVA.Legends.Add(legend1);
            chartFunction_MVA.Location = new Point(124, 44);
            chartFunction_MVA.Name = "chartFunction_MVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_MVA.Series.Add(series1);
            chartFunction_MVA.Size = new Size(466, 376);
            chartFunction_MVA.TabIndex = 3;
            chartFunction_MVA.Text = "chart1";
            // 
            // dataGridViewOut_MVA
            // 
            dataGridViewOut_MVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_MVA.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewOut_MVA.Location = new Point(6, 44);
            dataGridViewOut_MVA.Name = "dataGridViewOut_MVA";
            dataGridViewOut_MVA.RowHeadersVisible = false;
            dataGridViewOut_MVA.Size = new Size(112, 377);
            dataGridViewOut_MVA.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F(x)";
            F.Name = "F";
            F.Width = 50;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 26);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 15);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат:";
            // 
            // groupBoxInput_MVA
            // 
            groupBoxInput_MVA.Controls.Add(labelEnd_MVA);
            groupBoxInput_MVA.Controls.Add(labelstart_MVA);
            groupBoxInput_MVA.Controls.Add(textBoxStartStep_MVA);
            groupBoxInput_MVA.Controls.Add(textBoxStopStep_MVA);
            groupBoxInput_MVA.Location = new Point(-8, 350);
            groupBoxInput_MVA.Name = "groupBoxInput_MVA";
            groupBoxInput_MVA.Size = new Size(282, 94);
            groupBoxInput_MVA.TabIndex = 5;
            groupBoxInput_MVA.TabStop = false;
            groupBoxInput_MVA.Text = "Ввод данных";
            // 
            // labelEnd_MVA
            // 
            labelEnd_MVA.AutoSize = true;
            labelEnd_MVA.Location = new Point(149, 31);
            labelEnd_MVA.Name = "labelEnd_MVA";
            labelEnd_MVA.Size = new Size(75, 15);
            labelEnd_MVA.TabIndex = 6;
            labelEnd_MVA.Text = "Конец шага:";
            // 
            // labelstart_MVA
            // 
            labelstart_MVA.AutoSize = true;
            labelstart_MVA.Location = new Point(12, 31);
            labelstart_MVA.Name = "labelstart_MVA";
            labelstart_MVA.Size = new Size(72, 15);
            labelstart_MVA.TabIndex = 2;
            labelstart_MVA.Text = "Старт шага:";
            // 
            // textBoxStartStep_MVA
            // 
            textBoxStartStep_MVA.Location = new Point(12, 49);
            textBoxStartStep_MVA.Name = "textBoxStartStep_MVA";
            textBoxStartStep_MVA.Size = new Size(131, 23);
            textBoxStartStep_MVA.TabIndex = 5;
            // 
            // textBoxStopStep_MVA
            // 
            textBoxStopStep_MVA.Location = new Point(149, 49);
            textBoxStopStep_MVA.Name = "textBoxStopStep_MVA";
            textBoxStopStep_MVA.Size = new Size(127, 23);
            textBoxStopStep_MVA.TabIndex = 4;
            // 
            // buttonFAQ_MVA
            // 
            buttonFAQ_MVA.BackColor = SystemColors.MenuHighlight;
            buttonFAQ_MVA.Location = new Point(280, 350);
            buttonFAQ_MVA.Name = "buttonFAQ_MVA";
            buttonFAQ_MVA.Size = new Size(124, 94);
            buttonFAQ_MVA.TabIndex = 7;
            buttonFAQ_MVA.Text = "Справка";
            buttonFAQ_MVA.UseVisualStyleBackColor = false;
            buttonFAQ_MVA.Click += buttonFAQ_MVA_Click;
            // 
            // buttonGo_MVA
            // 
            buttonGo_MVA.BackColor = Color.Green;
            buttonGo_MVA.Location = new Point(410, 350);
            buttonGo_MVA.Name = "buttonGo_MVA";
            buttonGo_MVA.Size = new Size(148, 94);
            buttonGo_MVA.TabIndex = 8;
            buttonGo_MVA.Text = "Выполнить";
            buttonGo_MVA.UseVisualStyleBackColor = false;
            buttonGo_MVA.Click += buttonGo_MVA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 451);
            Controls.Add(groupBoxTask_MVA);
            Controls.Add(groupBoxOutput_MVA);
            Controls.Add(groupBoxInput_MVA);
            Controls.Add(buttonFAQ_MVA);
            Controls.Add(buttonGo_MVA);
            Name = "Form1";
            Text = "Form1";
            groupBoxTask_MVA.ResumeLayout(false);
            groupBoxTask_MVA.PerformLayout();
            groupBoxOutput_MVA.ResumeLayout(false);
            groupBoxOutput_MVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MVA).EndInit();
            groupBoxInput_MVA.ResumeLayout(false);
            groupBoxInput_MVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MVA;
        private Label label2;
        private Label label1;
        private GroupBox groupBoxOutput_MVA;
        private Label labelResult;
        private GroupBox groupBoxInput_MVA;
        private Label labelEnd_MVA;
        private Label labelstart_MVA;
        private TextBox textBoxStartStep_MVA;
        private TextBox textBoxStopStep_MVA;
        private Button buttonFAQ_MVA;
        private Button buttonGo_MVA;
        private DataGridView dataGridViewOut_MVA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MVA;
    }
}
