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
            init();

            this._user = _user;

            loadChart(DateType.Day);
        }

        private void init() 
        { 
            buttonOrders.Enabled = false;
            dateTimePicker.Value = DateTime.Now;
        }

        // Major
        private void loadChart(DateType dateType)
        {
            List<OrderHistoryObject> ordersHistoryList = getOrdersHistory();
            List<OrderHistoryObject> filteredOrders = new List<OrderHistoryObject>();

            // chart settings
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

        
        // Chart filling helper
        private void fillChart(List<OrderHistoryGroupedObject> groupedOrders)
        {
            foreach (OrderHistoryGroupedObject orderHistory in groupedOrders)
            {
                chartOrders.Series["Заказы"].Points.AddXY(orderHistory.Key, orderHistory.Value);
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
                    "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                    "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
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

        // couriers btn clicked
        private void buttonCouriers_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminChartUsers(_user));
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

        // day rb
        private void radioButtonDay_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
            loadChart(DateType.Day);
            dateTimePicker.Enabled = true;
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
            else if (radioButtonDay.Checked)
            {
                loadChart(DateType.Day);
            }
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
            else if (radioButtonDay.Checked)
            {
                dateTimePicker.Value = dateTimePicker.Value.AddDays(direction);
                loadChart(DateType.Day);
            }
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
    }
}
