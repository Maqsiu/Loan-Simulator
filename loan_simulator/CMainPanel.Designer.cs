using System.Windows.Forms.DataVisualization.Charting;

namespace loan_simulator
{
    partial class CMainPanel
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.loanAmountBox = new System.Windows.Forms.TextBox();
            this.repPeriodBox = new System.Windows.Forms.TextBox();
            this.insRateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthRadioBtn = new System.Windows.Forms.RadioButton();
            this.quartRadioBtn = new System.Windows.Forms.RadioButton();
            this.yearRadioBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.capitalIns = new System.Windows.Forms.RadioButton();
            this.totalIns = new System.Windows.Forms.RadioButton();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.installmmnentGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bottomRadioBtn = new System.Windows.Forms.RadioButton();
            this.topRadioBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calc1Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.calc2Label = new System.Windows.Forms.Label();
            this.reasultSecLabel = new System.Windows.Forms.Label();
            this.addCalculateBtn = new System.Windows.Forms.Button();
            this.SaveCalcuculationBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.installmmnentGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanAmountBox
            // 
            this.loanAmountBox.Location = new System.Drawing.Point(33, 28);
            this.loanAmountBox.Name = "loanAmountBox";
            this.loanAmountBox.Size = new System.Drawing.Size(191, 20);
            this.loanAmountBox.TabIndex = 0;
            // 
            // repPeriodBox
            // 
            this.repPeriodBox.Location = new System.Drawing.Point(33, 72);
            this.repPeriodBox.Name = "repPeriodBox";
            this.repPeriodBox.Size = new System.Drawing.Size(191, 20);
            this.repPeriodBox.TabIndex = 1;
            // 
            // insRateBox
            // 
            this.insRateBox.Enabled = false;
            this.insRateBox.Location = new System.Drawing.Point(33, 114);
            this.insRateBox.Name = "insRateBox";
            this.insRateBox.Size = new System.Drawing.Size(191, 20);
            this.insRateBox.TabIndex = 2;
            this.insRateBox.Text = "0.01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loan amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repayment period (number of years):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(33, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Interest rate:";
            // 
            // monthRadioBtn
            // 
            this.monthRadioBtn.AutoSize = true;
            this.monthRadioBtn.Location = new System.Drawing.Point(4, 26);
            this.monthRadioBtn.Name = "monthRadioBtn";
            this.monthRadioBtn.Size = new System.Drawing.Size(61, 17);
            this.monthRadioBtn.TabIndex = 9;
            this.monthRadioBtn.Text = "monthly";
            this.monthRadioBtn.UseVisualStyleBackColor = true;
            // 
            // quartRadioBtn
            // 
            this.quartRadioBtn.AutoSize = true;
            this.quartRadioBtn.Location = new System.Drawing.Point(4, 50);
            this.quartRadioBtn.Name = "quartRadioBtn";
            this.quartRadioBtn.Size = new System.Drawing.Size(65, 17);
            this.quartRadioBtn.TabIndex = 10;
            this.quartRadioBtn.Text = "quarterly";
            this.quartRadioBtn.UseVisualStyleBackColor = true;
            // 
            // yearRadioBtn
            // 
            this.yearRadioBtn.AutoSize = true;
            this.yearRadioBtn.Location = new System.Drawing.Point(4, 72);
            this.yearRadioBtn.Name = "yearRadioBtn";
            this.yearRadioBtn.Size = new System.Drawing.Size(57, 17);
            this.yearRadioBtn.TabIndex = 11;
            this.yearRadioBtn.Text = "annual";
            this.yearRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(251, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loan calculation:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(25, 33);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 13;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(254, 25);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(781, 197);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // capitalIns
            // 
            this.capitalIns.AutoSize = true;
            this.capitalIns.Location = new System.Drawing.Point(5, 23);
            this.capitalIns.Name = "capitalIns";
            this.capitalIns.Size = new System.Drawing.Size(142, 17);
            this.capitalIns.TabIndex = 16;
            this.capitalIns.Text = "equal capital installments";
            this.capitalIns.UseVisualStyleBackColor = true;
            // 
            // totalIns
            // 
            this.totalIns.AutoSize = true;
            this.totalIns.Location = new System.Drawing.Point(5, 46);
            this.totalIns.Name = "totalIns";
            this.totalIns.Size = new System.Drawing.Size(131, 17);
            this.totalIns.TabIndex = 17;
            this.totalIns.Text = "equal total installments";
            this.totalIns.UseVisualStyleBackColor = true;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(29, 476);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(195, 43);
            this.calculateBtn.TabIndex = 18;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(29, 630);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(195, 26);
            this.resetBtn.TabIndex = 19;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(6, 45);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 20;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.installmmnentGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.installmmnentGroupBox.Controls.Add(this.monthRadioBtn);
            this.installmmnentGroupBox.Controls.Add(this.quartRadioBtn);
            this.installmmnentGroupBox.Controls.Add(this.yearRadioBtn);
            this.installmmnentGroupBox.Location = new System.Drawing.Point(29, 153);
            this.installmmnentGroupBox.Name = "groupBox1";
            this.installmmnentGroupBox.Size = new System.Drawing.Size(195, 103);
            this.installmmnentGroupBox.TabIndex = 21;
            this.installmmnentGroupBox.TabStop = false;
            this.installmmnentGroupBox.Text = "Installment";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.capitalIns);
            this.groupBox2.Controls.Add(this.totalIns);
            this.groupBox2.Location = new System.Drawing.Point(29, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 99);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Repayment type";
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(6, 16);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(75, 23);
            this.logInBtn.TabIndex = 23;
            this.logInBtn.Text = "Log in";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.logInBtn);
            this.groupBox3.Controls.Add(this.closeBtn);
            this.groupBox3.Location = new System.Drawing.Point(1041, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(92, 79);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Panel";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.bottomRadioBtn);
            this.groupBox4.Controls.Add(this.topRadioBtn);
            this.groupBox4.Location = new System.Drawing.Point(29, 266);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(195, 81);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type of interest calculation";
            // 
            // bottomRadioBtn
            // 
            this.bottomRadioBtn.AutoSize = true;
            this.bottomRadioBtn.Location = new System.Drawing.Point(5, 40);
            this.bottomRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bottomRadioBtn.Name = "bottomRadioBtn";
            this.bottomRadioBtn.Size = new System.Drawing.Size(68, 17);
            this.bottomRadioBtn.TabIndex = 1;
            this.bottomRadioBtn.TabStop = true;
            this.bottomRadioBtn.Text = "in arrears";
            this.bottomRadioBtn.UseVisualStyleBackColor = true;
            this.bottomRadioBtn.CheckedChanged += new System.EventHandler(this.bottomRadioBtnCheckedChanged);
            // 
            // topRadioBtn
            // 
            this.topRadioBtn.AutoSize = true;
            this.topRadioBtn.Location = new System.Drawing.Point(5, 18);
            this.topRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.topRadioBtn.Name = "topRadioBtn";
            this.topRadioBtn.Size = new System.Drawing.Size(81, 17);
            this.topRadioBtn.TabIndex = 0;
            this.topRadioBtn.TabStop = true;
            this.topRadioBtn.Text = " in advance";
            this.topRadioBtn.UseVisualStyleBackColor = true;
            this.topRadioBtn.CheckedChanged += new System.EventHandler(this.topRadioBtnCheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.calc1Label);
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Location = new System.Drawing.Point(242, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 349);
            this.panel1.TabIndex = 27;
            // 
            // calc1Label
            // 
            this.calc1Label.AutoSize = true;
            this.calc1Label.BackColor = System.Drawing.Color.Transparent;
            this.calc1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calc1Label.Location = new System.Drawing.Point(8, 5);
            this.calc1Label.Name = "calc1Label";
            this.calc1Label.Size = new System.Drawing.Size(93, 17);
            this.calc1Label.TabIndex = 14;
            this.calc1Label.Text = "Calculation 1:";
            this.calc1Label.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.calc2Label);
            this.panel2.Controls.Add(this.reasultSecLabel);
            this.panel2.Location = new System.Drawing.Point(701, 266);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 349);
            this.panel2.TabIndex = 28;
            // 
            // calc2Label
            // 
            this.calc2Label.AutoSize = true;
            this.calc2Label.BackColor = System.Drawing.Color.Transparent;
            this.calc2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calc2Label.Location = new System.Drawing.Point(10, 5);
            this.calc2Label.Name = "calc2Label";
            this.calc2Label.Size = new System.Drawing.Size(93, 17);
            this.calc2Label.TabIndex = 14;
            this.calc2Label.Text = "Calculation 2:";
            this.calc2Label.Visible = false;
            // 
            // reasultSecLabel
            // 
            this.reasultSecLabel.AutoSize = true;
            this.reasultSecLabel.Location = new System.Drawing.Point(27, 33);
            this.reasultSecLabel.Name = "reasultSecLabel";
            this.reasultSecLabel.Size = new System.Drawing.Size(0, 13);
            this.reasultSecLabel.TabIndex = 13;
            // 
            // addCalculateBtn
            // 
            this.addCalculateBtn.Location = new System.Drawing.Point(29, 524);
            this.addCalculateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addCalculateBtn.Name = "addCalculateBtn";
            this.addCalculateBtn.Size = new System.Drawing.Size(195, 42);
            this.addCalculateBtn.TabIndex = 29;
            this.addCalculateBtn.Text = "Add calculations";
            this.addCalculateBtn.UseVisualStyleBackColor = true;
            this.addCalculateBtn.Click += new System.EventHandler(this.btn_addCalculation_Click);
            // 
            // SaveCalcuculationBtn
            // 
            this.SaveCalcuculationBtn.Location = new System.Drawing.Point(438, 640);
            this.SaveCalcuculationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveCalcuculationBtn.Name = "SaveCalcuculationBtn";
            this.SaveCalcuculationBtn.Size = new System.Drawing.Size(495, 27);
            this.SaveCalcuculationBtn.TabIndex = 30;
            this.SaveCalcuculationBtn.Text = "Save calculation";
            this.SaveCalcuculationBtn.UseVisualStyleBackColor = true;
            this.SaveCalcuculationBtn.Click += new System.EventHandler(this.btn_saveCalc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(420, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Chart of interest paid in individual installments:";
            // 
            // CMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1157, 678);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveCalcuculationBtn);
            this.Controls.Add(this.addCalculateBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.installmmnentGroupBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insRateBox);
            this.Controls.Add(this.repPeriodBox);
            this.Controls.Add(this.loanAmountBox);
            this.Name = "CMainPanel";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.installmmnentGroupBox.ResumeLayout(false);
            this.installmmnentGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loanAmountBox;
        private System.Windows.Forms.TextBox repPeriodBox;
        private System.Windows.Forms.TextBox insRateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton monthRadioBtn;
        private System.Windows.Forms.RadioButton quartRadioBtn;
        private System.Windows.Forms.RadioButton yearRadioBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton capitalIns;
        private System.Windows.Forms.RadioButton totalIns;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox installmmnentGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton bottomRadioBtn;
        private System.Windows.Forms.RadioButton topRadioBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label reasultSecLabel;
        private System.Windows.Forms.Button addCalculateBtn;
        private System.Windows.Forms.Button SaveCalcuculationBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label calc1Label;
        private System.Windows.Forms.Label calc2Label;
    }
}

