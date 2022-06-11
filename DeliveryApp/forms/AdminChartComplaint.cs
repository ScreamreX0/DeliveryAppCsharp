using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DeliveryApp
{
    public partial class AdminChartComplaint : Form
    {
        private users _user;
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;
        private SeriesChartType _chartType = SeriesChartType.Column;
        public AdminChartComplaint(users user)
        {
            InitializeComponent();

            this._user = user;

            init();

            loadChart(DateType.AllTime);
            fillInfoTextBox();
        }

        private void init()
        {
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Enabled = false;
            buttonComplaints.Enabled = false;
        }

        // reload chart
        private void loadChart(DateType dateType)
        {
            int complaintType = getComplaintType();

            if (complaintType == -1)
            {
                MessageBox.Show("Ошибка в базе данных. Не найден соответствующий тип жалобы");
                return;
            }

            // setting chart
            chartComplaints.Series.Clear();
            chartComplaints.Series.Add("Жалобы");
            chartComplaints.Series["Жалобы"].ChartType = _chartType;
            chartComplaints.Series["Жалобы"].IsValueShownAsLabel = false;
            chartComplaints.Series["Жалобы"].EmptyPointStyle.IsVisibleInLegend = false;

            if (_chartType == SeriesChartType.Pie) 
            {
                chartComplaints.Series["Жалобы"].IsVisibleInLegend = !radioButtonMonth.Checked;
            }
            else
            {   
                chartComplaints.Series["Жалобы"].IsVisibleInLegend = false;
            }

            if (dateType == DateType.Year)
            {
                // applicationsList filling
                List<applications> applicationsList = _deliveryEntities
                    .applications
                    .ToList()
                    .FindAll(param => param.type == complaintType
                        && param.date.Value.Year == dateTimePicker.Value.Year);

                // info filling
                List<string> months = new List<string>
                {
                    "Январь",
                    "Февраль",
                    "Март",
                    "Апрель",
                    "Май",
                    "Июнь",
                    "Июль",
                    "Август",
                    "Сентябрь",
                    "Октябрь",
                    "Ноябрь",
                    "Декабрь"
                };
                List<ChartObject> filteredApplications = getGroupedApplications(applicationsList, DateType.Year);
                for (int i = 0; i < months.Count; i++)
                {
                    ChartObject chartObject = null;
                    foreach (ChartObject chartObj in filteredApplications)
                    {
                        if (chartObj.Key - 1 == i)
                        {
                            chartObject = chartObj;
                            break;
                        }
                    }

                    // month is empty (no applications)
                    if (chartObject == null)
                    {
                        chartComplaints.Series["Жалобы"].Points.AddXY(months[i], 0);
                        continue;
                    }

                    chartComplaints
                        .Series["Жалобы"]
                        .Points
                        .AddXY(months[i], chartObject.Value);
                }
            }
            else if (dateType == DateType.Month)
            {
                // applicationsList filling
                List<applications> applicationsList = _deliveryEntities
                    .applications
                    .ToList()
                    .FindAll(param => param.type == complaintType
                        && param.date.Value.Year == dateTimePicker.Value.Year
                        && param.date.Value.Month == dateTimePicker.Value.Month);

                // info filling
                List<ChartObject> filteredApplications = getGroupedApplications(applicationsList, DateType.Month);
                int daysInSelectedMonth = DateTime.DaysInMonth(dateTimePicker.Value.Year, dateTimePicker.Value.Month);
                for (int i = 0; i < daysInSelectedMonth; i++)
                {
                    ChartObject chartObject = null;
                    foreach (ChartObject chartObj in filteredApplications)
                    {
                        if (chartObj.Key - 1 == i)
                        {
                            chartObject = chartObj;
                            break;
                        }
                    }

                    // month is empty (no applications)
                    if (chartObject == null)
                    {
                        chartComplaints.Series["Жалобы"].Points.AddXY(i, 0);
                        continue;
                    }

                    chartComplaints
                        .Series["Жалобы"]
                        .Points
                        .AddXY(i, chartObject.Value);
                }
            }
            else
            {
                // applicationsList filling
                List<applications> applicationsList = _deliveryEntities
                    .applications
                    .ToList();

                // info filling
                List<ChartObject> filteredApplications = getGroupedApplications(applicationsList, DateType.AllTime);
                for (int i = 0; i < filteredApplications.Count; i++)
                {
                    chartComplaints
                        .Series["Жалобы"]
                        .Points
                        .AddXY(filteredApplications[i].Key, filteredApplications[i].Value);
                }
            }
        }

        // getting grouped applications
        private List<ChartObject> getGroupedApplications(List<applications> applicationsList, DateType dateType)
        {
            if (dateType == DateType.Year)
            {
                return applicationsList
                    .GroupBy(param => param.date.Value.Month)
                    .Select(param => new ChartObject(param.Key, param.Count()))
                    .ToList();
            }
            else if (dateType == DateType.Month)
            {
                return applicationsList
                    .GroupBy(param => param.date.Value.Day)
                    .Select(param => new ChartObject(param.Key, param.Count()))
                    .ToList();
            }

            return applicationsList
                    .GroupBy(param => param.date.Value.Year)
                    .Select(param => new ChartObject(param.Key, param.Count()))
                    .ToList();
        }

        // getting complaint type from 'application_types' table
        private int getComplaintType()
        {
            try
            {
                return _deliveryEntities
                    .application_types
                    .FirstOrDefault(param => param.name.Equals("complaint"))
                    .id;
            } 
            catch (NullReferenceException ignore)
            {
                return -1;
            }
        } 

        // year radio batton
        private void radioButtonYear_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "yyyy";
            loadChart(DateType.Year);
            dateTimePicker.Enabled = true;
            fillInfoTextBox();
        }

        // month radio batton
        private void radioButtonMonth_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "yyyy-MM";
            loadChart(DateType.Month);
            dateTimePicker.Enabled = true;
            fillInfoTextBox();
        }

        // all time radio batton
        private void radioButtonAllTime_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = false;
            loadChart(DateType.AllTime);
        }

        // dateTimePicker changed
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (radioButtonAllTime.Checked)
            {
                loadChart(DateType.AllTime);
            }
            else if (radioButtonMonth.Checked)
            {
                loadChart(DateType.Month);
            }
            else if (radioButtonYear.Checked)
            {
                loadChart(DateType.Year);
            }
            fillInfoTextBox();
        }

        // button left
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            moveDate(-1);
        }

        // button right
        private void buttonRight_Click(object sender, EventArgs e)
        {
            moveDate(1);
        }

        // incr/decr date
        private void moveDate(int direction)
        {
            if (radioButtonYear.Checked)
            {
                dateTimePicker.Value = dateTimePicker.Value.AddYears(direction);
                loadChart(DateType.Year);
                fillInfoTextBox();
            }
            else if (radioButtonMonth.Checked)
            {
                dateTimePicker.Value = dateTimePicker.Value.AddMonths(direction);
                loadChart(DateType.Month);
                fillInfoTextBox();
            }
        }

        // update chart
        private void updateChart()
        {
            if (radioButtonYear.Checked)
            {
                loadChart(DateType.Year);
            }
            else if (radioButtonMonth.Checked)
            {
                loadChart(DateType.Month);
            }
            else
            {
                loadChart(DateType.AllTime);
            }
        }

        // change diagram type to 'column'
        private void buttonColumn_Click(object sender, EventArgs e)
        {
            changeDiagramType(SeriesChartType.Column);
        }

        // change diagram type to 'graph'
        private void buttonGraph_Click(object sender, EventArgs e)
        {
            changeDiagramType(SeriesChartType.Spline);
        }

        // change diagram type to 'pie'
        private void buttonPie_Click(object sender, EventArgs e)
        {
            changeDiagramType(SeriesChartType.Pie);
        }

        // change diagram type
        private void changeDiagramType(SeriesChartType type)
        {
            _chartType = type;
            updateChart();
        }

        // fill info text box
        private void fillInfoTextBox()
        {
            string content = "";
            List<applications> applicationsList = _deliveryEntities.applications.ToList();

            content += $"Все время: {applicationsList.Count()}\n";

            // current year
            int currentYearCount = applicationsList
                .FindAll(param => param.date.Value.Year == DateTime.Now.Year)
                .Count;
            content += $"Текущий год: {currentYearCount}\n";

            // current month
            int currentMonthCount = applicationsList
                .FindAll(param => param.date.Value.Year == DateTime.Now.Year
                    && param.date.Value.Month == DateTime.Now.Month)
                .Count;
            content += $"Текущий месяц: {currentMonthCount}\n";

            // current day
            int currentDayCount = applicationsList
                .FindAll(param => param.date.Value.Year == DateTime.Now.Year
                    && param.date.Value.Month == DateTime.Now.Month
                    && param.date.Value.Day == DateTime.Now.Day)
                .Count;
            content += $"Сегодняшний день: {currentDayCount}\n";

            if (!radioButtonAllTime.Checked)
            {
                // selected year
                int selectedYearCount = applicationsList
                    .FindAll(param => param.date.Value.Year == dateTimePicker.Value.Year)
                    .Count;
                content += $"Выбранный год: {selectedYearCount}\n";

                // selected month
                int selectedMonthCount = applicationsList
                    .FindAll(param => param.date.Value.Year == dateTimePicker.Value.Year
                        && param.date.Value.Month == dateTimePicker.Value.Month)
                    .Count;
                content += $"Выбранный месяц: {selectedMonthCount}\n";
            }

            infoTextBox.Text = content;
        }

        // back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(_user));
        }

        // orders button
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminChartOrders(_user));
        }

        // couriers button
        private void buttonCouriers_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminChartUsers(_user));
        }

        private enum DateType
        {
            AllTime,
            Year,
            Month
        }

        private class ChartObject
        {
            private int _key;
            private int _value;

            public ChartObject(int key, int value)
            {
                _key = key;
                _value = value;
            }

            public int Value { get => _value; }
            public int Key { get => _key; }
        }
    }
}
