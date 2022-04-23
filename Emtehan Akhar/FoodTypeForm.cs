using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DA.DA;
using DA.ContextandRepository;

namespace Emtehan_Akhar
{
    public partial class FoodTypeForm : Form
    {
        private readonly FoodType_Repository foodType_Repository = new FoodType_Repository();
        public FoodTypeForm()
        {
            InitializeComponent();
             var foodtype = this.foodType_Repository.Gets();
            foodtype.ForEach(foodtype => dgv_foodtype.Rows.Add(foodtype.Id, foodtype.Name, foodtype.Price));

        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_sabt_Click(object sender, EventArgs e)
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
            if (txt_nam.Text == "")
                throw new Exception("نام غذا را وارد نمایید");
            else if (numeric_price.Value == 0)
                    throw new Exception("قیمت  را وارد نمایید");
            }
        private void Submitsabt()
        {
            var foodtype= new FoodType(txt_nam.Text,numeric_price.Value);
            foodType_Repository.Add(foodtype);
            dgv_foodtype.Rows.Add(foodtype.Id,foodtype.Name,foodtype.Price);
        }

    }
    }

