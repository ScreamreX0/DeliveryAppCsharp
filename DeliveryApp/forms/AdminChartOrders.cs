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
    public partial class AdminChartOrders : Form
    {
        private users _user;
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;
        private SeriesChartType _chartType = SeriesChartType.Column;
        public AdminChartOrders(users _user)
        {
            InitializeComponent();

            this._user = _user;

            init();

            loadChart(DateType.Day);
            fillInfoTextBox();
        }

        private void init() 
        { 
            buttonOrders.Enabled = false;
        }

        private void loadChart(DateType dateType)
        {
            List<OrderHistoryObject> ordersHistoryList = getOrdersHistory();
            List<OrderHistoryObject> filteredOrders = new List<OrderHistoryObject>();

            // setting chart
            chartOrders.Series.Clear();
            chartOrders.Series.Add("Заказы");
            chartOrders.Series["Заказы"].ChartType = _chartType;
            chartOrders.Series["Заказы"].IsValueShownAsLabel = false;
            chartOrders.Series["Заказы"].EmptyPointStyle.IsVisibleInLegend = false;

            if (dateType == DateType.AllTime)
            {
                fillChart(getGroupedOrders(ordersHistoryList, dateType));
                return;
            }

            if (dateType == DateType.Year)
            {
                foreach (OrderHistoryObject orderHistory in ordersHistoryList)
                {
                    if (orderHistory.time.Value.Year == dateTimePicker.Value.Year)
                    {
                        filteredOrders.Add(orderHistory);
                    }
                }
            } 
            else if (dateType == DateType.Month)
            {
                foreach (OrderHistoryObject orderHistory in ordersHistoryList)
                {
                    if (orderHistory.time.Value.Year == dateTimePicker.Value.Year
                        && orderHistory.time.Value.Month == dateTimePicker.Value.Month)
                    {
                        filteredOrders.Add(orderHistory);
                    }
                }
            } 
            else if (dateType == DateType.Day)
            {
                foreach (OrderHistoryObject orderHistory in ordersHistoryList)
                {
                    if (orderHistory.time.Value.Year == dateTimePicker.Value.Year
                        && orderHistory.time.Value.Month == dateTimePicker.Value.Month
                        && orderHistory.time.Value.Day == dateTimePicker.Value.Day)
                    {
                        filteredOrders.Add(orderHistory);
                    }
                }
            }

            fillChart(getGroupedOrders(filteredOrders, dateType));
        }

        private void fillInfoTextBox()
        {

        }

        private void fillChart(List<OrderHistoryGroupedObject> groupedOrders)
        {
            foreach (OrderHistoryGroupedObject orderHistory in groupedOrders)
            {
                chartOrders
                    .Series["Заказы"]
                    .Points
                    .AddXY(orderHistory.Key, orderHistory.Value);
            }
        }

        private List<OrderHistoryGroupedObject> getGroupedOrders(
            List<OrderHistoryObject> ordersList,
            DateType dateType)
        {
            if (dateType == DateType.Year)
            {
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
                return ordersList
                    .GroupBy(param => param.time.Value.Month)
                    .Select(param => new OrderHistoryGroupedObject(months[param.Key], param.Count()))
                    .ToList();
            }
            else if (dateType == DateType.Month)
            {
                return ordersList
                    .GroupBy(param => param.time.Value.Day)
                    .Select(param => new OrderHistoryGroupedObject(param.Key.ToString(), param.Count()))
                    .ToList();
            }
            else if (dateType == DateType.Day)
            {
                return ordersList
                    .GroupBy(param => param.time.Value.Hour)
                    .Select(param => new OrderHistoryGroupedObject(param.Key.ToString(), param.Count()))
                    .ToList();
            }

            return ordersList
                    .GroupBy(param => param.time.Value.Year)
                    .Select(param => new OrderHistoryGroupedObject(param.Key.ToString(), param.Count()))
                    .ToList();
        }

        private List<OrderHistoryObject> getOrdersHistory()
        {
            List<OrderHistoryObject> ordersHistoryList = new List<OrderHistoryObject>();

            foreach (orders_history order_history in _deliveryEntities.orders_history)
            {
                ordersHistoryList.Add(new OrderHistoryObject(
                    order_history.id,
                    order_history.taken_orders.orders.customer_id,
                    order_history.taken_orders.courier_id,
                    order_history.taken_orders.orders.issue_point,
                    order_history.taken_orders.orders.time,
                    order_history.taken_orders.taken_date,
                    order_history.taken_orders.arrive_date,
                    order_history.taken_orders.orders.comment,
                    order_history.taken_orders.orders.payment_method,
                    order_history.taken_orders.orders.card_id,
                    order_history.transport_id,
                    order_history.total_sum,
                    order_history.rating));
            }

            return ordersHistoryList;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(_user));
        }

        private void buttonComplaints_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminChartComplaint(_user));
        }

        private void buttonCouriers_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminChartUsers(_user));
        }

        private enum DateType
        {
            AllTime,
            Year,
            Month,
            Day
        }

        private class OrderHistoryObject
        {
            public int orderHistoryId { get; }
            public int customerId { get; }
            public int? courierId { get; }
            public int? issuePoint { get; }

            public DateTime? time { get; }
            public DateTime? takenDate { get; }
            public DateTime? arriveDate { get; }

            public string comment { get; }
            public string paymentMethod { get; }

            public int? cartId { get; }
            public int? transportId { get; }
            public double? totalSum { get; }
            public double? rating { get; }

            public OrderHistoryObject(
                int orderHistoryId,
                int customerId, 
                int? courierId, 
                int? issuePoint, 
                DateTime? time, 
                DateTime? takenDate, 
                DateTime? arriveDate, 
                string comment, 
                string paymentMethod, 
                int? cartId, 
                int? transportId, 
                double? totalSum, 
                double? rating)
            {
                this.orderHistoryId = orderHistoryId;
                this.customerId = customerId;
                this.courierId = courierId;
                this.issuePoint = issuePoint;
                this.time = time;
                this.takenDate = takenDate;
                this.arriveDate = arriveDate;
                this.comment = comment;
                this.paymentMethod = paymentMethod;
                this.cartId = cartId;
                this.transportId = transportId;
                this.totalSum = totalSum;
                this.rating = rating;
            }
        }

        private class OrderHistoryGroupedObject
        {
            private string _key;
            private int _value;

            public OrderHistoryGroupedObject(string key, int value)
            {
                _key = key;
                _value = value;
            }

            public int Value { get => _value; }
            public string Key { get => _key; }
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

        private void radioButtonDay_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
            loadChart(DateType.Day);
            dateTimePicker.Enabled = true;
            fillInfoTextBox();
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
            else if (radioButtonDay.Checked)
            {
                loadChart(DateType.Day);
            }
            fillInfoTextBox();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            moveDate(-1);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            moveDate(1);
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
            else if (radioButtonDay.Checked)
            {
                dateTimePicker.Value = dateTimePicker.Value.AddDays(direction);
                loadChart(DateType.Day);
                fillInfoTextBox();
            }
        }
    }
}
