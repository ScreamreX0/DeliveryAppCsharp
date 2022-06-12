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
    public partial class AdminChartUsers : Form
    {
        private users _user;
        private SeriesChartType _chartType = SeriesChartType.Column;
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;
        public AdminChartUsers(users _user)
        {
            InitializeComponent();
            init();

            this._user = _user;
            
            loadChart(DateType.AllTime);
        }

        private void init()
        {
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Enabled = false;
            buttonUsers.Enabled = false;
        }

        // Major
        private void loadChart(DateType dateType)
        {
            chartUsers.Series.Clear();
            chartUsers.Series.Add("Пользователи");
            chartUsers.Series["Пользователи"].ChartType = _chartType;
            chartUsers.Series["Пользователи"].EmptyPointStyle.IsVisibleInLegend = false;

            if (dateType == DateType.Year)
            {
                chartSetYear();
            }
            else if (dateType == DateType.Month)
            {
                chartSetMonth();
            }
            else
            {
                chartSetAllTime();
            }
        }


        // Chart sets
        private void chartSetAllTime()
        {
            // usersList filling
            List<users> usersList = _deliveryEntities
                .users
                .ToList();

            // info filling
            List<ChartObject> filteredUsers = getGroupedUsers(usersList, DateType.AllTime);
            for (int i = 0; i < filteredUsers.Count; i++)
            {
                chartUsers
                    .Series["Пользователи"]
                    .Points
                    .AddXY(filteredUsers[i].Key, filteredUsers[i].Value);
            }
        }

        private void chartSetYear()
        {
            List<users> usersList = _deliveryEntities.users.ToList().FindAll(
                param => param.registration_date.Value.Year == dateTimePicker.Value.Year);

            List<string> months = new List<string>
            {
                "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };

            List<ChartObject> filteredUsers = getGroupedUsers(usersList, DateType.Year);
            for (int i = 0; i < months.Count; i++)
            {
                ChartObject chartObject = null;
                foreach (ChartObject chartObj in filteredUsers)
                {
                    if (chartObj.Key - 1 == i)
                    {
                        chartObject = chartObj;
                        break;
                    }
                }

                // month is empty (no users)
                if (chartObject == null)
                {
                    chartUsers.Series["Пользователи"].Points.AddXY(months[i], 0);
                    continue;
                }

                chartUsers
                    .Series["Пользователи"]
                    .Points
                    .AddXY(months[i], chartObject.Value);
            }
        }

        private void chartSetMonth()
        {
            List<users> usersList = _deliveryEntities.users.ToList().FindAll(
                param => param.registration_date.Value.Year == dateTimePicker.Value.Year
                && param.registration_date.Value.Month == dateTimePicker.Value.Month);

            List<ChartObject> filteredUsers = getGroupedUsers(usersList, DateType.Month);
            int daysInSelectedMonth = DateTime.DaysInMonth(dateTimePicker.Value.Year, dateTimePicker.Value.Month);
            for (int i = 0; i < daysInSelectedMonth; i++)
            {
                ChartObject chartObject = null;
                foreach (ChartObject chartObj in filteredUsers)
                {
                    if (chartObj.Key - 1 == i)
                    {
                        chartObject = chartObj;
                        break;
                    }
                }

                // month is empty (no users)
                if (chartObject == null)
                {
                    chartUsers.Series["Пользователи"].Points.AddXY(i, 0);
                    continue;
                }

                chartUsers
                    .Series["Пользователи"]
                    .Points
                    .AddXY(i, chartObject.Value);
            }
        }


        // Chart sets helper
        private List<ChartObject> getGroupedUsers(List<users> usersList, DateType dateType)
        {
            if (dateType == DateType.Year)
            {
                return usersList
                    .GroupBy(param => param.registration_date.Value.Month)
                    .Select(param => new ChartObject(param.Key, param.Count()))
                    .ToList();
            }
            else if (dateType == DateType.Month)
            {
                return usersList
                    .GroupBy(param => param.registration_date.Value.Day)
                    .Select(param => new ChartObject(param.Key, param.Count()))
                    .ToList();
            }

            return usersList
                    .GroupBy(param => param.registration_date.Value.Year)
                    .Select(param => new ChartObject(param.Key, param.Count()))
                    .ToList();
        }


        // UI
        // back btn clicked
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(_user));
        }

        // complaints btn clicked
        private void buttonComplaints_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminChartComplaint(_user));
        }

        // orders btn clicked
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminChartOrders(_user));
        }

        // all time rb
        private void radioButtonAllTime_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = false;
            loadChart(DateType.AllTime);
        }

        // year rb
        private void radioButtonYear_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "yyyy";
            loadChart(DateType.Year);
            dateTimePicker.Enabled = true;
        }

        // month rb
        private void radioButtonMonth_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "yyyy-MM";
            loadChart(DateType.Month);
            dateTimePicker.Enabled = true;
        }

        // left btn clicked
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            moveDate(-1);
        }

        // right btn clicked
        private void buttonRight_Click(object sender, EventArgs e)
        {
            moveDate(1);
        }

        // time pckr changed
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
        }

        private void buttonColumn_Click(object sender, EventArgs e)
        {
            changeDiagramType(SeriesChartType.Column);
            updateChart();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            changeDiagramType(SeriesChartType.Area);
            updateChart();
        }

        private void buttonSpline_Click(object sender, EventArgs e)
        {
            changeDiagramType(SeriesChartType.SplineArea);
            updateChart();
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            changeDiagramType(SeriesChartType.Point);
            updateChart();
        }

        // UI helper
        private void moveDate(int direction)
        {
            if (radioButtonYear.Checked)
            {
                dateTimePicker.Value = dateTimePicker.Value.AddYears(direction);
                loadChart(DateType.Year);
            }
            else if (radioButtonMonth.Checked)
            {
                dateTimePicker.Value = dateTimePicker.Value.AddMonths(direction);
                loadChart(DateType.Month);
            }
        }

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

        // change diagram type
        private void changeDiagramType(SeriesChartType type)
        {
            _chartType = type;
            updateChart();
        }


        enum DateType
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
