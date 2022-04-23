
namespace Emtehan_Akhar
{
    partial class FoodTypeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_sabt = new System.Windows.Forms.Button();
            this.dgv_foodtype = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.numeric_price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foodtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sabt
            // 
            this.btn_sabt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sabt.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_sabt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sabt.Location = new System.Drawing.Point(264, 397);
            this.btn_sabt.Name = "btn_sabt";
            this.btn_sabt.Size = new System.Drawing.Size(151, 41);
            this.btn_sabt.TabIndex = 0;
            this.btn_sabt.Text = "ثبت";
            this.btn_sabt.UseVisualStyleBackColor = false;
            this.btn_sabt.Click += new System.EventHandler(this.btn_sabt_Click);
            // 
            // dgv_foodtype
            // 
            this.dgv_foodtype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_foodtype.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_foodtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_foodtype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Price});
            this.dgv_foodtype.Location = new System.Drawing.Point(12, 12);
            this.dgv_foodtype.Name = "dgv_foodtype";
            this.dgv_foodtype.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_foodtype.RowTemplate.Height = 25;
            this.dgv_foodtype.Size = new System.Drawing.Size(652, 379);
            this.dgv_foodtype.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "نام";
            this.Name.Name = "Name";
            // 
            // Price
            // 
            this.Price.HeaderText = "قیمت";
            this.Price.Name = "Price";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(750, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام غذا";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(736, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "قیمت غذا";
            // 
            // txt_nam
            // 
            this.txt_nam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nam.BackColor = System.Drawing.SystemColors.Info;
            this.txt_nam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_nam.Location = new System.Drawing.Point(690, 27);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(100, 23);
            this.txt_nam.TabIndex = 4;
            // 
            // numeric_price
            // 
            this.numeric_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric_price.Location = new System.Drawing.Point(670, 71);
            this.numeric_price.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.numeric_price.Name = "numeric_price";
            this.numeric_price.Size = new System.Drawing.Size(120, 23);
            this.numeric_price.TabIndex = 5;
            // 
            // FoodTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numeric_price);
            this.Controls.Add(this.txt_nam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_foodtype);
            this.Controls.Add(this.btn_sabt);
          //  this.Name = "FoodTypeForm";
            this.Text = "FoodTypeeForm";
            this.Load += new System.EventHandler(this.OrderDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foodtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sabt;
        private System.Windows.Forms.DataGridView dgv_foodtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.NumericUpDown numeric_price;
    }
}