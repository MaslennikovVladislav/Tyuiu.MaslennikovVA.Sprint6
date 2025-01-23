namespace Tyuiu.MaslennikovVA.Sprint6.Task0.V1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_MVA = new GroupBox();
            textBoxTask_MVA = new TextBox();
            pictureBoxForm_MVA = new PictureBox();
            textBoxInput_MVA = new TextBox();
            textBoxResult_MVA = new TextBox();
            groupBoxIn_MVA = new GroupBox();
            labelIn_MVA = new Label();
            groupBoxOut_MVA = new GroupBox();
            labelRes_MVA = new Label();
            buttonDone_MVA = new Button();
            buttonFAQ_MVA = new Button();
            groupBoxTask_MVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForm_MVA).BeginInit();
            groupBoxIn_MVA.SuspendLayout();
            groupBoxOut_MVA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MVA
            // 
            groupBoxTask_MVA.Controls.Add(textBoxTask_MVA);
            groupBoxTask_MVA.Controls.Add(pictureBoxForm_MVA);
            groupBoxTask_MVA.Location = new Point(12, 12);
            groupBoxTask_MVA.Name = "groupBoxTask_MVA";
            groupBoxTask_MVA.Size = new Size(577, 229);
            groupBoxTask_MVA.TabIndex = 0;
            groupBoxTask_MVA.TabStop = false;
            groupBoxTask_MVA.Text = "Условие";
            // 
            // textBoxTask_MVA
            // 
            textBoxTask_MVA.Enabled = false;
            textBoxTask_MVA.Location = new Point(6, 22);
            textBoxTask_MVA.Multiline = true;
            textBoxTask_MVA.Name = "textBoxTask_MVA";
            textBoxTask_MVA.Size = new Size(415, 201);
            textBoxTask_MVA.TabIndex = 0;
            textBoxTask_MVA.Text = "Вычислить выражение по формуле";
          
            // 
            // pictureBoxForm_MVA
            // 
            pictureBoxForm_MVA.Image = (Image)resources.GetObject("pictureBoxForm_MVA.Image");
            pictureBoxForm_MVA.Location = new Point(423, 22);
            pictureBoxForm_MVA.Name = "pictureBoxForm_MVA";
            pictureBoxForm_MVA.Size = new Size(148, 91);
            pictureBoxForm_MVA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxForm_MVA.TabIndex = 1;
            pictureBoxForm_MVA.TabStop = false;
            // 
            // textBoxInput_MVA
            // 
            textBoxInput_MVA.Location = new Point(6, 58);
            textBoxInput_MVA.Name = "textBoxInput_MVA";
            textBoxInput_MVA.Size = new Size(100, 23);
            textBoxInput_MVA.TabIndex = 2;
            textBoxInput_MVA.Text = " ";
            textBoxInput_MVA.KeyPress += textBoxInput_MVA_KeyPress;
            // 
            // textBoxResult_MVA
            // 
            textBoxResult_MVA.Location = new Point(6, 58);
            textBoxResult_MVA.Name = "textBoxResult_MVA";
            textBoxResult_MVA.ReadOnly = true;
            textBoxResult_MVA.Size = new Size(188, 23);
            textBoxResult_MVA.TabIndex = 3;
            // 
            // groupBoxIn_MVA
            // 
            groupBoxIn_MVA.Controls.Add(labelIn_MVA);
            groupBoxIn_MVA.Controls.Add(textBoxInput_MVA);
            groupBoxIn_MVA.Location = new Point(12, 247);
            groupBoxIn_MVA.Name = "groupBoxIn_MVA";
            groupBoxIn_MVA.Size = new Size(371, 100);
            groupBoxIn_MVA.TabIndex = 2;
            groupBoxIn_MVA.TabStop = false;
            groupBoxIn_MVA.Text = "Ввод данных";
            // 
            // labelIn_MVA
            // 
            labelIn_MVA.AutoSize = true;
            labelIn_MVA.Location = new Point(6, 40);
            labelIn_MVA.Name = "labelIn_MVA";
            labelIn_MVA.Size = new Size(86, 15);
            labelIn_MVA.TabIndex = 5;
            labelIn_MVA.Text = "Переменная X";
            // 
            // groupBoxOut_MVA
            // 
            groupBoxOut_MVA.Controls.Add(labelRes_MVA);
            groupBoxOut_MVA.Controls.Add(textBoxResult_MVA);
            groupBoxOut_MVA.Location = new Point(389, 247);
            groupBoxOut_MVA.Name = "groupBoxOut_MVA";
            groupBoxOut_MVA.Size = new Size(200, 100);
            groupBoxOut_MVA.TabIndex = 0;
            groupBoxOut_MVA.TabStop = false;
            groupBoxOut_MVA.Text = "Вывод данных";
            // 
            // labelRes_MVA
            // 
            labelRes_MVA.AutoSize = true;
            labelRes_MVA.Location = new Point(6, 40);
            labelRes_MVA.Name = "labelRes_MVA";
            labelRes_MVA.Size = new Size(60, 15);
            labelRes_MVA.TabIndex = 4;
            labelRes_MVA.Text = "Результат";
            // 
            // buttonDone_MVA
            // 
            buttonDone_MVA.Location = new Point(435, 347);
            buttonDone_MVA.Name = "buttonDone_MVA";
            buttonDone_MVA.Size = new Size(154, 42);
            buttonDone_MVA.TabIndex = 3;
            buttonDone_MVA.Text = "Выполнить";
            buttonDone_MVA.UseVisualStyleBackColor = true;
            buttonDone_MVA.Click += buttonDone_MVA_Click;
            // 
            // buttonFAQ_MVA
            // 
            buttonFAQ_MVA.Location = new Point(389, 347);
            buttonFAQ_MVA.Name = "buttonFAQ_MVA";
            buttonFAQ_MVA.Size = new Size(44, 42);
            buttonFAQ_MVA.TabIndex = 6;
            buttonFAQ_MVA.Text = "?";
            buttonFAQ_MVA.UseVisualStyleBackColor = true;
            buttonFAQ_MVA.Click += buttonFAQ_MVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 401);
            Controls.Add(buttonFAQ_MVA);
            Controls.Add(buttonDone_MVA);
            Controls.Add(groupBoxTask_MVA);
            Controls.Add(groupBoxIn_MVA);
            Controls.Add(groupBoxOut_MVA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 1 | Масленников В. А.";
            groupBoxTask_MVA.ResumeLayout(false);
            groupBoxTask_MVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForm_MVA).EndInit();
            groupBoxIn_MVA.ResumeLayout(false);
            groupBoxIn_MVA.PerformLayout();
            groupBoxOut_MVA.ResumeLayout(false);
            groupBoxOut_MVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MVA;
        private TextBox textBoxTask_MVA;
        private PictureBox pictureBoxForm_MVA;
        private TextBox textBoxInput_MVA;
        private TextBox textBoxResult_MVA;
        private GroupBox groupBoxIn_MVA;
        private Label labelIn_MVA;
        private GroupBox groupBoxOut_MVA;
        private Label labelRes_MVA;
        private Button buttonDone_MVA;
        private Button buttonFAQ_MVA;
    }
}
