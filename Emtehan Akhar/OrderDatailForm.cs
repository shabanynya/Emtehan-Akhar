using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DA.DA;
using DA.ContextandRepository;
using Microsoft.EntityFrameworkCore;
namespace Emtehan_Akhar
{
    public partial class OrderDatailForm : Form
    {
        private readonly OrderRepository orderRepository = new OrderRepository();
        private readonly FoodType_Repository foodType_Repository = new FoodType_Repository();
        private List<OrderDetail> orderDetails = new List<OrderDetail>();
        public OrderDatailForm()
        {
            InitializeComponent();
            var foodtypes = this.foodType_Repository.Gets();
            foodtypes.ForEach(p => cmb_ghaza.Items.Add(p));
        }

        private void OrderDatailForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_afzoodanorderdatail_Click(object sender, EventArgs e)
        {
            string showMassege = " ";
            try
            {
                Validationsabt();
                Submitsabt();

                showMassege = "ثبت شد";
            }
            catch (Exception ex)
            {
                showMassege = ex.Message;
            }
            finally
            {
                MessageBox.Show(showMassege);
            }
        }
        private void Validationsabt()
        {

            if (numeric_tedad.Value == 0)
                throw new Exception("تعداد غذا را وارد کنید");
        }
        private void Submitsabt()
        {
            var count = Convert.ToInt32(numeric_tedad.Value);
            var foodtype = (FoodType)cmb_ghaza.SelectedItem;
            var orderdetail = new OrderDetail(foodtype, count);
            dgv_orderdatails.Rows.Add(orderdetail.Id, foodtype.Name, orderdetail.Count);
            orderDetails.Add(orderdetail);
 
        }

        private void btn_sabtnahaee_Click(object sender, EventArgs e)
        {
            var order = new Order(orderDetails);
            orderRepository.Add(order);
            this.Close();
        }
       
    }
}

