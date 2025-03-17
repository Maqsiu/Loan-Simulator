using System;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace loan_simulator
{
    public partial class CMainPanel : Form
    {
        public float insRate;

        // Constructor with interest rate parameter
        public CMainPanel(float insRate)
        {
            InitializeComponent();
            this.insRate = insRate;
            insRateBox.Text = this.insRate.ToString();
            this.Text = "Calculation";
            ConfigureChart();             
        }

        // Default constructor
        public CMainPanel()
        {
            InitializeComponent();
            ConfigureChart();
            this.DoubleBuffered = true;
            this.Text = "Calculation";
        }

        // Constructor with option to unlock input field
        public CMainPanel(bool unlockBtn)
        {
            InitializeComponent();
            ConfigureChart();
            insRateBox.Enabled = unlockBtn;
            this.Text = "Calculation";

        }

        // Custom background paint with gradient effect
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, 
                Color.White,          
                Color.LightGray,           
                LinearGradientMode.Vertical)) 
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        // Configures the chart with default settings
        private void ConfigureChart()
        {

            var series1 = new Series("Calculation 1");
            series1.ChartType = SeriesChartType.Column;
            series1.Color = System.Drawing.Color.Blue;
            chart1.Series.Add(series1);
            chart1.Legends[0].Enabled = false;


            chart1.ChartAreas[0].AxisX.Title = "Period";
            chart1.ChartAreas[0].AxisY.Title = "Loan installment[PLN]";

            chart1.Legends[0].BackColor = Color.Transparent;

            addDataToChart();

        }

        // Adds empty data points to the chart
        public void addDataToChart()
        {
            for (int i = 1; i < 30; i++)
                chart1.Series[0].Points.AddXY(i, 0);
        }

        // Closes the form
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Handles the loan calculation process
        private void btn_Calculate_Click(object sender, EventArgs e)
        {


            calc1Label.Visible = true;
            chart1.Series[0].Points.Clear();
            chart1.Legends[0].Enabled = true;
            CalculateLoan(chart1.Series[0], resultLabel);
        }

        // Adds a second calculation series to the chart
        private void btn_addCalculation_Click(object sender, EventArgs e)
        {

            if (chart1.Series.IndexOf("Calculation 2") != -1)
            {
                chart1.Series["Calculation 2"].Points.Clear();
                MessageBox.Show("Your calculation number 2 has been cleared and will be updated.");
            }
            else
            {
                var series2 = new Series("Calculation 2")
                {
                    ChartType = SeriesChartType.Column,
                    Color = System.Drawing.Color.Red
                };
                chart1.Series.Add(series2);
            }


            CalculateLoan(chart1.Series[1], reasultSecLabel);
        }

        // Switches to the login screen
        private void btn_logIn_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                Application.Run(new CLogScreen());


            });
            this.Close();
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        // Disables insurance options when top radio button is selected
        private void topRadioBtnCheckedChanged(object sender, EventArgs e)
        {
            capitalIns.Enabled = false;
            totalIns.Enabled = false;
            capitalIns.Checked = false;
            totalIns.Checked = false;
        }

        // Enables insurance options when bottom radio button is selected
        private void bottomRadioBtnCheckedChanged(object sender, EventArgs e)
        {
            capitalIns.Enabled = true;
            totalIns.Enabled = true;
        }


        // Saves calculation results to text and image files
        private void btn_saveCalc_Click(object sender, EventArgs e)
        {
            string pngFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "loan_chart.png");

            using (Bitmap bitmap = new Bitmap(chart1.Width, chart1.Height))
            {
                chart1.DrawToBitmap(bitmap, new Rectangle(0, 0, chart1.Width, chart1.Height));

               
                bitmap.Save(pngFilePath, System.Drawing.Imaging.ImageFormat.Png);
            }

            string textToSave = resultLabel.Text + "\n\n\n\n\n" + reasultSecLabel.Text;

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "loan_raport.txt");


            try
            {     
                File.WriteAllText(filePath, textToSave);
                MessageBox.Show($"Text saved to file: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            MessageBox.Show($"Chart saved to PNG file: {pngFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Resets all inputs and calculations
        private void btn_reset_Click(object sender, EventArgs e)
        {
            resultLabel.Text = string.Empty;
            reasultSecLabel.Text = string.Empty;
            loanAmountBox.Text = string.Empty ;
            repPeriodBox.Text = string.Empty ;

            bottomRadioBtn.Checked = false;
            topRadioBtn.Checked = false;

            capitalIns.Checked = false;
            totalIns.Checked = false;

            ConfigureChart();
            addDataToChart();
        }

        // Performs the loan calculation
        private void CalculateLoan(Series chartSeries, Label outputLabel)
        {
            installmmnentGroupBox.Enabled = false;
            outputLabel.Text = string.Empty;
            float loanAmount = 0, repPeriod = 0, insRate = 0;
            try
            {

                loanAmount = float.Parse(loanAmountBox.Text);
                repPeriod = float.Parse(repPeriodBox.Text);
                insRate = float.Parse(insRateBox.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter yput data!\n" + ex);
            }

            float insRateSec = 0, insAmount = 0, fullAmount = 0, insAmountSec = 0, repPeriodSec = 0;

            if (monthRadioBtn.Checked) { insRateSec = insRate / 12; repPeriodSec = repPeriod * 12; }
            else if (quartRadioBtn.Checked) { insRateSec = insRate / 4; repPeriodSec = repPeriod * 4;  }
            else if (yearRadioBtn.Checked) { insRateSec = insRate; repPeriodSec = repPeriod;  }

            if (topRadioBtn.Checked)
            {
                fullAmount = loanAmount * insRate;
                loanAmount += fullAmount;
                float totalCost = loanAmount;
                insAmountSec = loanAmount / repPeriodSec;
                fullAmount /= (repPeriod * 12);

                for (int i = 0; i < repPeriodSec; i++)
                {
                    loanAmount -= insAmountSec;
                    chartSeries.Points.AddXY(i, fullAmount);
                    outputLabel.Text += formatOutput(fullAmount, insAmountSec, loanAmount);
                }
                outputLabel.Text += "\nTotal loan cost: " + totalCost.ToString("F2") + " PLN";
            }
            else if (bottomRadioBtn.Checked)
            {
                float totalCost = 0;
                if (capitalIns.Checked)
                {
                    insAmount = loanAmount / repPeriodSec;
                    for (int i = 0; i < repPeriodSec; i++)
                    {
                        fullAmount = loanAmount * insRateSec;
                        insAmountSec = fullAmount + insAmount;
                        loanAmount = (i == repPeriodSec - 1) ? 0 : loanAmount - insAmount;
                        totalCost += insAmountSec;
                        chartSeries.Points.AddXY(i, fullAmount);
                        outputLabel.Text += formatOutput(fullAmount, insAmountSec, loanAmount);
                    }
                }
                else if (totalIns.Checked)
                {
                    insAmountSec = (float)(loanAmount * insRateSec * Math.Pow((1 + insRateSec), repPeriodSec) / (Math.Pow((1 + insRateSec), repPeriodSec) - 1));
                    for (int i = 0; i < repPeriodSec; i++)
                    {
                        fullAmount = loanAmount * insRateSec;
                        insAmount = insAmountSec - fullAmount;
                        loanAmount -= insAmount;
                        totalCost += insAmountSec;
                        chartSeries.Points.AddXY(i, fullAmount);
                        outputLabel.Text += formatOutput(fullAmount, insAmountSec, loanAmount);
                    }
                }
                outputLabel.Text += "\nTotal loan cost: " + totalCost.ToString("F2") + " PLN";

            }
        }

        // Formats output text for calculation results
        private string formatOutput(float interest, float totalPayment, float remaining)
        {
            return $"Interest: {interest:F2} PLN Total installment: {totalPayment:F2} PLN Remaining amount: {remaining:F2} zł \n";
        }


    }
}
