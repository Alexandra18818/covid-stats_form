namespace _1st_try
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.countrygeninfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.covidData_dbDataSet1 = new _1st_try.CovidData_dbDataSet1();
            this.country_gen_infoTableAdapter = new _1st_try.CovidData_dbDataSet1TableAdapters.Country_gen_infoTableAdapter();
            this.covidData_dbDataSet = new _1st_try.CovidData_dbDataSet();
            this.coviddataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.covid_dataTableAdapter = new _1st_try.CovidData_dbDataSetTableAdapters.Covid_dataTableAdapter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxTari = new System.Windows.Forms.ComboBox();
            this.dbDataSet = new _1st_try.dbDataSet();
            this.datecovidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_covidTableAdapter = new _1st_try.dbDataSetTableAdapters.date_covidTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countrygeninfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidData_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidData_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coviddataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datecovidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            this.SuspendLayout();
            // 
            // countrygeninfoBindingSource
            // 
            this.countrygeninfoBindingSource.DataMember = "Country_gen_info";
            this.countrygeninfoBindingSource.DataSource = this.covidData_dbDataSet1;
            // 
            // covidData_dbDataSet1
            // 
            this.covidData_dbDataSet1.DataSetName = "CovidData_dbDataSet1";
            this.covidData_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // country_gen_infoTableAdapter
            // 
            this.country_gen_infoTableAdapter.ClearBeforeFill = true;
            // 
            // covidData_dbDataSet
            // 
            this.covidData_dbDataSet.DataSetName = "CovidData_dbDataSet";
            this.covidData_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coviddataBindingSource
            // 
            this.coviddataBindingSource.DataMember = "Covid_data";
            this.coviddataBindingSource.DataSource = this.covidData_dbDataSet;
            // 
            // covid_dataTableAdapter
            // 
            this.covid_dataTableAdapter.ClearBeforeFill = true;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(12, 506);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Cazuri";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(649, 401);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generate chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxTari
            // 
            this.comboBoxTari.FormattingEnabled = true;
            this.comboBoxTari.Items.AddRange(new object[] {
            "Romania",
            "Germania",
            "Franta"});
            this.comboBoxTari.Location = new System.Drawing.Point(732, 578);
            this.comboBoxTari.Name = "comboBoxTari";
            this.comboBoxTari.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTari.TabIndex = 10;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datecovidBindingSource
            // 
            this.datecovidBindingSource.DataMember = "date_covid";
            this.datecovidBindingSource.DataSource = this.dbDataSet;
            // 
            // date_covidTableAdapter
            // 
            this.date_covidTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Country:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(485, 99);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "PieSeries";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(362, 318);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Load Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(25, 99);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "PieSeries2";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(362, 318);
            this.chart3.TabIndex = 14;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(974, 99);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "PieSeries3";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(362, 318);
            this.chart4.TabIndex = 15;
            this.chart4.Text = "chart4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "Romania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "Germania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1121, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Franta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(492, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 39);
            this.label5.TabIndex = 19;
            this.label5.Text = "Death-Recovery Ratio";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(667, 462);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(623, 66);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 705);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 22;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(667, 611);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(603, 29);
            this.richTextBox2.TabIndex = 23;
            this.richTextBox2.Text = "Additionally, you can also identify the day with the highest number of new cases";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 643);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(344, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Here you can see the highest number of confirmed cases";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chart5
            // 
            chartArea5.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart5.Legends.Add(legend5);
            this.chart5.Location = new System.Drawing.Point(667, 662);
            this.chart5.Name = "chart5";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart5.Series.Add(series5);
            this.chart5.Size = new System.Drawing.Size(623, 245);
            this.chart5.TabIndex = 25;
            this.chart5.Text = "chart5";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1261, 636);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Foresight";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(732, 546);
            this.StartTime.MaxDate = new System.DateTime(2022, 2, 26, 0, 0, 0, 0);
            this.StartTime.MinDate = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(200, 22);
            this.StartTime.TabIndex = 27;
            this.StartTime.Value = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(974, 546);
            this.EndTime.MaxDate = new System.DateTime(2022, 2, 26, 0, 0, 0, 0);
            this.EndTime.MinDate = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(200, 22);
            this.EndTime.TabIndex = 28;
            this.EndTime.Value = new System.DateTime(2022, 2, 26, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 1055);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chart5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countrygeninfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidData_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidData_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coviddataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datecovidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CovidData_dbDataSet1 covidData_dbDataSet1;
        private System.Windows.Forms.BindingSource countrygeninfoBindingSource;
        private CovidData_dbDataSet1TableAdapters.Country_gen_infoTableAdapter country_gen_infoTableAdapter;
        private CovidData_dbDataSet covidData_dbDataSet;
        private System.Windows.Forms.BindingSource coviddataBindingSource;
        private CovidData_dbDataSetTableAdapters.Covid_dataTableAdapter covid_dataTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxTari;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource datecovidBindingSource;
        private dbDataSetTableAdapters.date_covidTableAdapter date_covidTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.Label label8;
    }
}

