using Aspose.Words.Drawing.Charts;
using Aspose.Words.Tables;
using Npgsql;
using System;
using MathNet.Numerics.LinearRegression;
using MathNet.Numerics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Accord.Statistics.Models.Regression.Linear;
using System.Runtime.InteropServices.ComTypes;

namespace _1st_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.date_covid' table. You can move, or remove it, as needed.
            this.date_covidTableAdapter.Fill(this.dbDataSet.date_covid);
            // TODO: This line of code loads data into the 'covidData_dbDataSet.Covid_data' table. You can move, or remove it, as needed.
            this.covid_dataTableAdapter.Fill(this.covidData_dbDataSet.Covid_data);
            // TODO: This line of code loads data into the 'covidData_dbDataSet1.Country_gen_info' table. You can move, or remove it, as needed.
            this.country_gen_infoTableAdapter.Fill(this.covidData_dbDataSet1.Country_gen_info);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\alexa\\source\\repos\\1st try\\1st try\\db.mdf\";Integrated Security=True");
                DataTable dt = new DataTable();
                con.Open();
                string selectedCountry = comboBoxTari.SelectedItem.ToString();
                MessageBox.Show("Țara selectată: " + selectedCountry);
                DateTime startDate = StartTime.Value;
                DateTime endDate = EndTime.Value;
                // Comandă SQL parametrizată
                string sqlQuery = "SELECT data, nrcazuri FROM date_covid WHERE numeTara = @NumeTara  AND data BETWEEN @StartDate AND @EndDate";

                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
                da.SelectCommand.Parameters.AddWithValue("@NumeTara", selectedCountry);
                da.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                da.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                da.Fill(dt);
                con.Close();
                dt.Columns.Add("dataS", typeof(DateTime)); // Adăugați coloana pentru data în formatul DateTime
                dt.Columns.Add("dataString", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    string dataString = row["data"].ToString(); // Obțineți data sub forma de șir
                    DateTime data = DateTime.ParseExact(dataString, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture); // Conversie în tipul DateTime

                    row["dataString"] = data; // Salvați data sub forma de tip DateTime
                }
               
                
                chart2.DataSource = dt;
                chart2.Series["Cazuri"].XValueMember = "dataString"; // Utilizați noua coloană "dataString"
                chart2.Series["Cazuri"].YValueMembers = "nrcazuri";

                // Setarea formatarea datelor pe axa X
                chart2.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yyyy";
                foreach (DataRow row in dt.Rows)
                {
                    DateTime data = (DateTime)row["data"]; // Obțineți data sub forma de tip DateTime

                    // Formatați data pentru a elimina ora
                    string dataString = data.ToString("dd.MM.yyyy"); // Conversie în formatul "dd.MM.yyyy"

                    row["dataString"] = dataString; // Salvați data sub forma de șir formatat
                }
                chart2.Titles.Add("Daily new cases in " + selectedCountry);
                
                int maxCases = 0;
                DateTime dayWithMostCases = DateTime.MinValue;

                foreach (DataRow row in dt.Rows)
                {
                    int cases = (int)row["nrcazuri"];
                    DateTime data = (DateTime)row["data"];

                    if (cases > maxCases)
                    {
                        maxCases = cases;
                        dayWithMostCases = data;
                    }
                }

                // Actualizați label-ul cu ziua cu cele mai multe cazuri
                label7.Text = "Ziua cu cele mai multe cazuri: " + dayWithMostCases.ToString("dd.MM.yyyy")+ " in care s-au inregistrat "+ maxCases+" de cazuri noi";
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            // Conectați-vă la baza de date și obțineți datele pentru România
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\alexa\\source\\repos\\1st try\\1st try\\db.mdf\";Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT deaths_no, healed_no FROM total_data WHERE country_name = 'Romania'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int deaths_no = reader.GetInt32(0);
                        int healed_no = reader.GetInt32(1);

                        // Configurați chart
                        chart1.Series.Clear();
                        chart1.Series.Add("PieSeries");
                        chart1.Series["PieSeries"].Points.AddXY("Decese", deaths_no);
                        chart1.Series["PieSeries"].Points.AddXY("Vindecări", healed_no);
                        chart1.Series["PieSeries"].IsValueShownAsLabel = true;
                        chart1.Series["PieSeries"].LabelFormat = "#,0";
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    }
                    chart1.Series["PieSeries"].ChartType = SeriesChartType.Pie;
                    chart1.Titles.Add("Total Deaths and Recovered Ratio in Romania");
                }
                using (SqlConnection connection2 = new SqlConnection(connectionString))
                {
                    connection2.Open();
                    string sqlQuery1 = "SELECT deaths_no, healed_no FROM total_data WHERE country_name = 'Germania'";
                    using (SqlCommand command = new SqlCommand(sqlQuery1, connection2))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int deaths_no = reader.GetInt32(0);
                            int healed_no = reader.GetInt32(1);

                            // Configurați chart
                            chart3.Series.Clear();
                            chart3.Series.Add("PieSeries1");
                            chart3.Series["PieSeries1"].Points.AddXY("Decese", deaths_no);
                            chart3.Series["PieSeries1"].Points.AddXY("Vindecări", healed_no);
                            chart3.Series["PieSeries1"].IsValueShownAsLabel = true;
                            chart3.Series["PieSeries1"].LabelFormat = "#,0";
                            chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                        }
                        chart3.Series["PieSeries1"].ChartType = SeriesChartType.Pie;
                        chart3.Titles.Add("Total Deaths and Recovered Ratio in Germania ");
                    }
                    using (SqlConnection connection3 = new SqlConnection(connectionString))
                    {
                        connection3.Open();
                        string sqlQuery2 = "SELECT deaths_no, healed_no FROM total_data WHERE country_name = 'Franta'";
                        using (SqlCommand command = new SqlCommand(sqlQuery2, connection3))
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int deaths_no = reader.GetInt32(0);
                                int healed_no = reader.GetInt32(1);

                                // Configurați chart
                                chart4.Series.Clear();
                                chart4.Series.Add("PieSeries2");
                                chart4.Series["PieSeries2"].Points.AddXY("Decese", deaths_no);
                                chart4.Series["PieSeries2"].Points.AddXY("Vindecări", healed_no);
                                chart4.Series["PieSeries2"].IsValueShownAsLabel = true;
                                chart4.Series["PieSeries2"].LabelFormat = "#,0";
                                chart4.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                            }
                            chart4.Series["PieSeries2"].ChartType = SeriesChartType.Pie;
                            chart4.Titles.Add("Total Deaths and Recovered Ratio in Franta ");
                        }
                    }
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\alexa\\source\\repos\\1st try\\1st try\\db.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            // Obțineți datele din baza de date pentru țara și intervalul dorit
            string selectedCountry = "Romania"; // Înlocuiți cu țara dorită
            DateTime startDate = new DateTime(2023, 5, 1); // Data de început a intervalului
            DateTime endDate = new DateTime(2023, 10, 31); // Data de sfârșit a intervalului

            string sqlQuery = "SELECT data, nrcazuri FROM date_covid WHERE numeTara = @NumeTara " +
                "AND data BETWEEN @StartDate AND @EndDate";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@NumeTara", selectedCountry);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            // Adăugați datele din DataTable în Chart5
            
            dt.Columns.Add("dataS", typeof(DateTime)); // Adăugați coloana pentru data în formatul DateTime
            dt.Columns.Add("dataString", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                string dataString = row["data"].ToString(); // Obțineți data sub forma de șir
                DateTime data = DateTime.ParseExact(dataString, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture); // Conversie în tipul DateTime

                row["dataString"] = data; // Salvați data sub forma de tip DateTime
            }

            chart5.DataSource = dt;
            chart5.Series["Series1"].XValueMember = "dataString";
            chart5.Series["Series1"].YValueMembers = "nrcazuri";

            // Setarea formatarea datelor pe axa X
            chart5.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yyyy";
            foreach (DataRow row in dt.Rows)
            {
                DateTime data = (DateTime)row["data"]; // Obțineți data sub forma de tip DateTime

                // Formatați data pentru a elimina ora
                string dataString = data.ToString("dd.MM.yyyy"); // Conversie în formatul "dd.MM.yyyy"

                row["dataString"] = dataString; // Salvați data sub forma de șir formatat
            }

            // Realizați prognoza folosind regresia liniară
            double[] x = dt.AsEnumerable().Select(row => row.Field<DateTime>("data").ToOADate()).ToArray();
            double[] y = dt.AsEnumerable().Select(row => (double)row.Field<int>("nrcazuri")).ToArray();

            // Calculați coeficienții pentru regresia liniară
            double sumX = x.Sum();
            double sumY = y.Sum();
            double sumX2 = x.Select(xi => xi * xi).Sum();
            double sumXY = x.Zip(y, (xi, yi) => xi * yi).Sum();
            int n = x.Length;
            double a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            double b = (sumY - a * sumX) / n;

            // Prognoza pentru următoarele 90 de zile
            List<DateTime> futureDates = new List<DateTime>();
            List<double> predictedCases = new List<double>();
            DateTime lastDate = DateTime.FromOADate(x.Max());
            for (int i = 1; i <= 90; i++)
            {
                DateTime futureDate = lastDate.AddDays(i);
                double predictedCase = a * futureDate.ToOADate() + b;

                futureDates.Add(futureDate);
                predictedCases.Add(predictedCase);
            }

            // Adăugați prognoza în grafic
            for (int i = 0; i < futureDates.Count; i++)
            {
                chart5.Series["Series1"].Points.AddXY(futureDates[i], predictedCases[i]);
            }
        }
    }
}
