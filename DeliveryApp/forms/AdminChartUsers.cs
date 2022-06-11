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

            this._user = _user;

            init();
            loadChart(DateType.AllTime);
            fillInfoTextBox();
        }

        private void init()
        {
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Enabled = false;
            buttonUsers.Enabled = false;
        }

        private void loadChart(DateType dateType)
        {
            // setting chart
            chartUsers.Series.Clear();
            chartUsers.Series.Add("Пользователи");
            chartUsers.Series["Пользователи"].ChartType = _chartType;
            chartUsers.Series["Пользователи"].IsValueShownAsLabel = false;
            chartUsers.Series["Пользователи"].EmptyPointStyle.IsVisibleInLegend = false;

            if (_chartType == SeriesChartType.Pie)
            {
                chartUsers.Series["Пользователи"].IsVisibleInLegend = !radioButtonMonth.Checked;
            }
            else
            {
                chartUsers.Series["Пользователи"].IsVisibleInLegend = false;
            }

            if (dateType == DateType.Year)
            {
                // usersList filling
                List<users> usersList = _deliveryEntities
                    .users
                    .ToList()
                    .FindAll(param => param.registration_date.Value.Year == dateTimePicker.Value.Year);

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
            else if (dateType == DateType.Month)
            {
                // usersList filling
                List<users> usersList = _deliveryEntities
                    .users
                    .ToList()
                    .FindAll(param => param.registration_date.Value.Year == dateTimePicker.Value.Year
                        && param.registration_date.Value.Month == dateTimePicker.Value.Month);

                // info filling
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
            else
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
        }

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(_user));
        }

        private void buttonComplaints_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminChartComplaint(_user));
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminChartOrders(_user));
        }

        private void radioButtonAllTime_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = false;
            loadChart(DateType.AllTime);
        }

        private void radioButtonYear_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "yyyy";
            loadChart(DateType.Year);
            dateTimePicker.Enabled = true;
            fillInfoTextBox();
        }

        private void radioButtonMonth_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "yyyy-MM";
            loadChart(DateType.Month);
            dateTimePicker.Enabled = true;
            fillInfoTextBox();
        }

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

        private void fillInfoTextBox()
        {
            /*string content = "";
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

            infoTextBox.Text = content;*/
        }

        enum DateType
        {
            AllTime,
            Year,
            Month
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            moveDate(-1);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            moveDate(1);
        }

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
