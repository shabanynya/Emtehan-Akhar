
namespace Emtehan_Akhar
{
    partial class OrderDatailForm
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
            this.btn_sabtnahaee = new System.Windows.Forms.Button();
            this.btn_afzoodanorderdatail = new System.Windows.Forms.Button();
            this.dgv_orderdatails = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foodtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_ghaza = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_tedad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderdatails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_tedad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sabtnahaee
            // 
            this.btn_sabtnahaee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sabtnahaee.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_sabtnahaee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sabtnahaee.Location = new System.Drawing.Point(324, 397);
            this.btn_sabtnahaee.Name = "btn_sabtnahaee";
            this.btn_sabtnahaee.Size = new System.Drawing.Size(151, 41);
            this.btn_sabtnahaee.TabIndex = 5;
            this.btn_sabtnahaee.Text = "ثبت نهایی سفارش";
            this.btn_sabtnahaee.UseVisualStyleBackColor = false;
            this.btn_sabtnahaee.Click += new System.EventHandler(this.btn_sabtnahaee_Click);
            // 
            // btn_afzoodanorderdatail
            // 
            this.btn_afzoodanorderdatail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_afzoodanorderdatail.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_afzoodanorderdatail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_afzoodanorderdatail.Location = new System.Drawing.Point(667, 109);
            this.btn_afzoodanorderdatail.Name = "btn_afzoodanorderdatail";
            this.btn_afzoodanorderdatail.Size = new System.Drawing.Size(121, 41);
            this.btn_afzoodanorderdatail.TabIndex = 6;
            this.btn_afzoodanorderdatail.Text = "افزودن";
            this.btn_afzoodanorderdatail.UseVisualStyleBackColor = false;
            this.btn_afzoodanorderdatail.Click += new System.EventHandler(this.btn_afzoodanorderdatail_Click);
            // 
            // dgv_orderdatails
            // 
            this.dgv_orderdatails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_orderdatails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_orderdatails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderdatails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Foodtype,
            this.Count});
            this.dgv_orderdatails.Location = new System.Drawing.Point(12, 12);
            this.dgv_orderdatails.Name = "dgv_orderdatails";
            this.dgv_orderdatails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_orderdatails.RowTemplate.Height = 25;
            this.dgv_orderdatails.Size = new System.Drawing.Size(649, 379);
            this.dgv_orderdatails.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Foodtype
            // 
            this.Foodtype.HeaderText = "نوع غذا";
            this.Foodtype.Name = "Foodtype";
            // 
            // Count
            // 
            this.Count.HeaderText = "تعداد";
            this.Count.Name = "Count";
            // 
            // cmb_ghaza
            // 
            this.cmb_ghaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_ghaza.DisplayMember = "Name";
            this.cmb_ghaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ghaza.FormattingEnabled = true;
            this.cmb_ghaza.Location = new System.Drawing.Point(667, 30);
            this.cmb_ghaza.Name = "cmb_ghaza";
            this.cmb_ghaza.Size = new System.Drawing.Size(121, 23);
            this.cmb_ghaza.TabIndex = 8;
            this.cmb_ghaza.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(745, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "نوع غدا";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(748, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "تعداد";
            // 
            // numeric_tedad
            // 
            this.numeric_tedad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric_tedad.Location = new System.Drawing.Point(668, 80);
            this.numeric_tedad.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.numeric_tedad.Name = "numeric_tedad";
            this.numeric_tedad.Size = new System.Drawing.Size(120, 23);
            this.numeric_tedad.TabIndex = 11;
            // 
            // OrderDatailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numeric_tedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ghaza);
            this.Controls.Add(this.dgv_orderdatails);
            this.Controls.Add(this.btn_afzoodanorderdatail);
            this.Controls.Add(this.btn_sabtnahaee);
            this.Name = "OrderDatailForm";
            this.Text = "OrderDatailForm";
            this.Load += new System.EventHandler(this.OrderDatailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderdatails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_tedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sabtnahaee;
        private System.Windows.Forms.Button btn_afzoodanorderdatail;
        private System.Windows.Forms.DataGridView dgv_orderdatails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foodtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.ComboBox cmb_ghaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_tedad;
    }
}