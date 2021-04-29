﻿using OrderApp;
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
    public partial class FormEdit : Form
    {
        private OrderService orderService;
        private bool editModel;

        public Order CurrentOrder { get; set; }
        public Action<FormEdit> CloseEditFrom { get; set; }
        public FormEdit(Order order, bool model, OrderService orderService)
        {
            InitializeComponent();
            bdsCustomers.Add(new Customer("1", "li"));
            bdsCustomers.Add(new Customer("2", "zhang"));
            this.orderService = orderService;
            this.editModel = model;

            //TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
            this.CurrentOrder = order;
            bdsOrders.DataSource = CurrentOrder;

            txtOrderId.Enabled = !model;
            if (!model)
            {
                 CurrentOrder.Customer = (Customer)bdsCustomers.Current;
            }
        }

        private void btnDeleteItems_Click(object sender, EventArgs e)
        {
            OrderDetail detail = bdsDetails.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            CurrentOrder.RemoveDetail(detail);
            bdsDetails.ResetBindings(false);
        }
        private void EditDetail()
        {
            OrderDetail detail = bdsDetails.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            FormDetailEdit formDetailEdit = new FormDetailEdit(detail);
            if (formDetailEdit.ShowDialog() == DialogResult.OK)
            {
                bdsDetails.ResetBindings(false);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.editModel)
                {
                    orderService.UpdateOrder(CurrentOrder);
                }
                else
                {
                    orderService.AddOrder(CurrentOrder);
                }
                CloseEditFrom(this);
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FormDetailEdit formItemEdit = new FormDetailEdit(new OrderDetail());
            try
            {
                if (formItemEdit.ShowDialog() == DialogResult.OK)
                {
                    uint index = 0;
                    if (CurrentOrder.Details.Count != 0)
                    {
                        index = CurrentOrder.Details.Max(i => i.Index) + 1;
                    }
                    formItemEdit.Detail.Index = index;
                    CurrentOrder.AddItem(formItemEdit.Detail);
                    bdsDetails.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            EditDetail();
        }
    }
}
