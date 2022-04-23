using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DA.ContextandRepository;

namespace Emtehan_Akhar
{
    public partial class OrderForm : Form
    {
        private readonly OrderRepository orderRepository = new OrderRepository();
       
        public OrderForm()
        {
            InitializeComponent();
            var order = this.orderRepository.Gets();
            order.ForEach(order => dgv_order.Rows.Add(order.Id, order.Description, order.TotalAmount));
        }

        private void btn_afzoodan_Click(object sender, EventArgs e)
        {
            FoodTypeForm foodTypeForm = new FoodTypeForm();
            foodTypeForm.ShowDialog();
        }

        private void btn_jadid_Click(object sender, EventArgs e)
        {
            OrderDatailForm orderDatailForm = new OrderDatailForm();
            orderDatailForm.ShowDialog();
            dgv_order.Rows.Clear();
            var order = this.orderRepository.Gets();
            order.ForEach(order => dgv_order.Rows.Add(order.Id, order.Description, order.TotalAmount));

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgv_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
