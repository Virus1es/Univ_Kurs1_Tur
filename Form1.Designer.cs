namespace Kursavaya
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOne = new System.Windows.Forms.TabPage();
            this.chartForOne = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBoxForOne = new System.Windows.Forms.RichTextBox();
            this.tabPageMany = new System.Windows.Forms.TabPage();
            this.chartForMany = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBoxMany = new System.Windows.Forms.RichTextBox();
            this.buttonGoMany = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPageOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartForOne)).BeginInit();
            this.tabPageMany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartForMany)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запустить МТ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "L = {a^i b^j c^k; 1≤i=k & j≥1 & i != j}";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOne);
            this.tabControl1.Controls.Add(this.tabPageMany);
            this.tabControl1.Location = new System.Drawing.Point(12, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 580);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageOne
            // 
            this.tabPageOne.Controls.Add(this.chartForOne);
            this.tabPageOne.Controls.Add(this.richTextBoxForOne);
            this.tabPageOne.Controls.Add(this.button1);
            this.tabPageOne.Location = new System.Drawing.Point(4, 25);
            this.tabPageOne.Name = "tabPageOne";
            this.tabPageOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOne.Size = new System.Drawing.Size(1059, 551);
            this.tabPageOne.TabIndex = 0;
            this.tabPageOne.Text = "Одноленточная";
            this.tabPageOne.UseVisualStyleBackColor = true;
            // 
            // chartForOne
            // 
            chartArea3.Name = "ChartArea1";
            this.chartForOne.ChartAreas.Add(chartArea3);
            this.chartForOne.Cursor = System.Windows.Forms.Cursors.No;
            legend3.Name = "Legend1";
            this.chartForOne.Legends.Add(legend3);
            this.chartForOne.Location = new System.Drawing.Point(516, 6);
            this.chartForOne.Name = "chartForOne";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.LabelBorderWidth = 3;
            series3.Legend = "Legend1";
            series3.LegendText = "Сложность";
            series3.Name = "Series1";
            this.chartForOne.Series.Add(series3);
            this.chartForOne.Size = new System.Drawing.Size(537, 507);
            this.chartForOne.TabIndex = 2;
            this.chartForOne.Text = "chart1";
            // 
            // richTextBoxForOne
            // 
            this.richTextBoxForOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxForOne.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxForOne.Name = "richTextBoxForOne";
            this.richTextBoxForOne.Size = new System.Drawing.Size(489, 507);
            this.richTextBoxForOne.TabIndex = 1;
            this.richTextBoxForOne.Text = "";
            // 
            // tabPageMany
            // 
            this.tabPageMany.Controls.Add(this.chartForMany);
            this.tabPageMany.Controls.Add(this.richTextBoxMany);
            this.tabPageMany.Controls.Add(this.buttonGoMany);
            this.tabPageMany.Location = new System.Drawing.Point(4, 25);
            this.tabPageMany.Name = "tabPageMany";
            this.tabPageMany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMany.Size = new System.Drawing.Size(1059, 551);
            this.tabPageMany.TabIndex = 1;
            this.tabPageMany.Text = "Многоленточная";
            this.tabPageMany.UseVisualStyleBackColor = true;
            // 
            // chartForMany
            // 
            chartArea4.Name = "ChartArea1";
            this.chartForMany.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartForMany.Legends.Add(legend4);
            this.chartForMany.Location = new System.Drawing.Point(517, 6);
            this.chartForMany.Name = "chartForMany";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.LabelBorderWidth = 3;
            series4.Legend = "Legend1";
            series4.LegendText = "Сложность";
            series4.Name = "Series1";
            this.chartForMany.Series.Add(series4);
            this.chartForMany.Size = new System.Drawing.Size(536, 507);
            this.chartForMany.TabIndex = 5;
            this.chartForMany.Text = "chart1";
            // 
            // richTextBoxMany
            // 
            this.richTextBoxMany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxMany.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxMany.Name = "richTextBoxMany";
            this.richTextBoxMany.Size = new System.Drawing.Size(489, 507);
            this.richTextBoxMany.TabIndex = 3;
            this.richTextBoxMany.Text = "";
            // 
            // buttonGoMany
            // 
            this.buttonGoMany.Location = new System.Drawing.Point(187, 519);
            this.buttonGoMany.Name = "buttonGoMany";
            this.buttonGoMany.Size = new System.Drawing.Size(191, 23);
            this.buttonGoMany.TabIndex = 2;
            this.buttonGoMany.Text = "Запустить МТ";
            this.buttonGoMany.UseVisualStyleBackColor = true;
            this.buttonGoMany.Click += new System.EventHandler(this.buttonGoMany_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(792, 86);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(170, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистить графики";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(582, 86);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(183, 23);
            this.buttonBuild.TabIndex = 8;
            this.buttonBuild.Text = "Построить графики";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(80, 53);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(203, 22);
            this.textBoxWord.TabIndex = 3;
            this.textBoxWord.Text = "aabcc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Слово:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 685);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсавая работа Якубенко Вадим группа ПИ-21в";
            this.tabControl1.ResumeLayout(false);
            this.tabPageOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartForOne)).EndInit();
            this.tabPageMany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartForMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOne;
        private System.Windows.Forms.TabPage tabPageMany;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxForOne;
        private System.Windows.Forms.RichTextBox richTextBoxMany;
        private System.Windows.Forms.Button buttonGoMany;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForOne;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForMany;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBuild;
    }
}

