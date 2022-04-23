
namespace Emtehan_Akhar
{
    partial class OrderForm
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
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_afzoodan = new System.Windows.Forms.Button();
            this.btn_jadid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_order
            // 
            this.dgv_order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_order.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.TotalAmount});
            this.dgv_order.Location = new System.Drawing.Point(12, 12);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_order.RowTemplate.Height = 25;
            this.dgv_order.Size = new System.Drawing.Size(776, 379);
            this.dgv_order.TabIndex = 2;
            this.dgv_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "شماره سفارش";
            this.Id.Name = "Id";
            // 
            // Description
            // 
            this.Description.HeaderText = "شرح سفارش";
            this.Description.Name = "Description";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "مبلغ نهایی";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exit.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Location = new System.Drawing.Point(12, 397);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(151, 41);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_afzoodan
            // 
            this.btn_afzoodan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_afzoodan.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_afzoodan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_afzoodan.Location = new System.Drawing.Point(324, 397);
            this.btn_afzoodan.Name = "btn_afzoodan";
            this.btn_afzoodan.Size = new System.Drawing.Size(151, 41);
            this.btn_afzoodan.TabIndex = 4;
            this.btn_afzoodan.Text = "افزودن غذا";
            this.btn_afzoodan.UseVisualStyleBackColor = false;
            this.btn_afzoodan.Click += new System.EventHandler(this.btn_afzoodan_Click);
            // 
            // btn_jadid
            // 
            this.btn_jadid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_jadid.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_jadid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_jadid.Location = new System.Drawing.Point(637, 397);
            this.btn_jadid.Name = "btn_jadid";
            this.btn_jadid.Size = new System.Drawing.Size(151, 41);
            this.btn_jadid.TabIndex = 5;
            this.btn_jadid.Text = "جدید";
            this.btn_jadid.UseVisualStyleBackColor = false;
            this.btn_jadid.Click += new System.EventHandler(this.btn_jadid_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_jadid);
            this.Controls.Add(this.btn_afzoodan);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgv_order);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_afzoodan;
        private System.Windows.Forms.Button btn_jadid;
    }
}