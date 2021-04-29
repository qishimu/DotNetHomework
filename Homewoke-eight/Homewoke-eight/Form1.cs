
using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homewoke_eight
{
    public partial class Form1 : Form
    {
        OrderService orderService;
        BindingSource bdsFields = new BindingSource();
        public Action<FormEdit> ShowEditForm { get; set; }
        public String Keyword { get; set; }
        public Form1()
        {
            InitializeComponent();
            orderService = new OrderService();
            //初始化一些订单的信息
            Order order = new Order(1, new Customer("1", "li"), new List<OrderDetail>());
            order.AddItem(new OrderDetail(1, new Goods("1", "apple", 100.0), 10));
            order.AddItem(new OrderDetail(2, new Goods("2", "egg", 50.0), 61));
            orderService.AddOrder(order);
            Order order2 = new Order(2, new Customer("2", "zhang"), new List<OrderDetail>());
            order2.AddItem(new OrderDetail(1, new Goods("2", "egg", 200.0), 10));
            orderService.AddOrder(order2);
            bdsOrders.DataSource = orderService.Orders;
            cbxField.SelectedIndex = 0;
            txtKeyword.DataBindings.Add("Text", this, "Keyword");
        }

        public void QueryAll()
        {
            bdsOrders.DataSource = orderService.Orders;
            //使绑定到 BindingSource 的控件重新读取列表中的所有项，并刷新这些项的显示值
            //如果数据架构已更改，则为 true；如果只有值发生了更改，则为 false
            bdsOrders.ResetBindings(false);
        }
        //增加订单 弹出订单编辑界面
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit(new Order(), false, orderService);
            formEdit.Show();
            //未将对象引用设置到对象的实例。
            //ShowEditForm(formEdit);
        }
        //修改订单
        private void btnModify_Click(object sender, EventArgs e)
        {
            EditOrder();
        }
        // 发现如果只是绑定数据客户的选择上面不会显示出姓名只会显示OrderApp.Cuetomer
        // 但是数目会保持不变
        private void EditOrder()
        {
            Order order = bdsOrders.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            FormEdit form2 = new FormEdit(order, true, orderService);
            form2.Show();
        }
        // 导出订单 saveFileDialog的用法
        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }
        //订单删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // BindingSource的Current属性返回DataRowView类型的对象
            //（就像DataView是对 DataTable的封装一样，DataRowView是对DataRow的封装）
            // 它是对当前数据项的封装，可以通过类型转换变成你想要的对象
            Order order = bdsOrders.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            orderService.RemoveOrder(order.OrderId);
            QueryAll();
        }
        //
        //comboBox的使用 
        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbxField.SelectedIndex)
            {
                case 0://所有订单
                    bdsOrders.DataSource = orderService.Orders;
                    break;
                case 1://根据ID查询
                    int.TryParse(Keyword, out int id);
                    Order order = orderService.GetOrder(id);
                    List<Order> result = new List<Order>();
                    if (order != null) result.Add(order);
                    bdsOrders.DataSource = result;
                    break;
                case 2://根据客户查询
                    bdsOrders.DataSource = orderService.QueryOrdersByCustomerName(Keyword);
                    break;
                case 3://根据货物查询
                    bdsOrders.DataSource = orderService.QueryOrdersByGoodsName(Keyword);
                    break;
                case 4://根据总价格查询（大于某个总价）
                    float.TryParse(Keyword, out float totalPrice);
                    bdsOrders.DataSource =
                           orderService.QueryByTotalAmount(totalPrice);
                    break;
            }
            bdsOrders.ResetBindings(false);
        }

    }
}
