
namespace XML
{
    partial class XML
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XML));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Shops = new System.Windows.Forms.TabPage();
            this.ShopsdataGridView = new System.Windows.Forms.DataGridView();
            this.Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Snumofworkingplaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kindofshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workers = new System.Windows.Forms.TabPage();
            this.WdataGridView = new System.Windows.Forms.DataGridView();
            this.Positions = new System.Windows.Forms.TabPage();
            this.PdataGridView = new System.Windows.Forms.DataGridView();
            this.Pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WSname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workingplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Shops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopsdataGridView)).BeginInit();
            this.Workers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WdataGridView)).BeginInit();
            this.Positions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Shops);
            this.tabControl1.Controls.Add(this.Workers);
            this.tabControl1.Controls.Add(this.Positions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 682);
            this.tabControl1.TabIndex = 0;
            // 
            // Shops
            // 
            this.Shops.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Shops.Controls.Add(this.ShopsdataGridView);
            this.Shops.Location = new System.Drawing.Point(4, 25);
            this.Shops.Name = "Shops";
            this.Shops.Padding = new System.Windows.Forms.Padding(3);
            this.Shops.Size = new System.Drawing.Size(1054, 653);
            this.Shops.TabIndex = 0;
            this.Shops.Text = "Магазины";
            // 
            // ShopsdataGridView
            // 
            this.ShopsdataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShopsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sname,
            this.Snumofworkingplaces,
            this.Kindofshop});
            this.ShopsdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShopsdataGridView.Location = new System.Drawing.Point(3, 3);
            this.ShopsdataGridView.Name = "ShopsdataGridView";
            this.ShopsdataGridView.RowHeadersWidth = 51;
            this.ShopsdataGridView.RowTemplate.Height = 24;
            this.ShopsdataGridView.Size = new System.Drawing.Size(1048, 647);
            this.ShopsdataGridView.TabIndex = 0;
            // 
            // Sname
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sname.DefaultCellStyle = dataGridViewCellStyle1;
            this.Sname.HeaderText = "Название";
            this.Sname.MinimumWidth = 6;
            this.Sname.Name = "Sname";
            this.Sname.Width = 335;
            // 
            // Snumofworkingplaces
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Snumofworkingplaces.DefaultCellStyle = dataGridViewCellStyle2;
            this.Snumofworkingplaces.HeaderText = "Кол-во рабочих мест ";
            this.Snumofworkingplaces.MinimumWidth = 6;
            this.Snumofworkingplaces.Name = "Snumofworkingplaces";
            this.Snumofworkingplaces.Width = 330;
            // 
            // Kindofshop
            // 
            this.Kindofshop.HeaderText = "Вид магазина";
            this.Kindofshop.MinimumWidth = 6;
            this.Kindofshop.Name = "Kindofshop";
            this.Kindofshop.Width = 330;
            // 
            // Workers
            // 
            this.Workers.BackColor = System.Drawing.Color.LemonChiffon;
            this.Workers.Controls.Add(this.WdataGridView);
            this.Workers.Location = new System.Drawing.Point(4, 25);
            this.Workers.Name = "Workers";
            this.Workers.Padding = new System.Windows.Forms.Padding(3);
            this.Workers.Size = new System.Drawing.Size(1054, 653);
            this.Workers.TabIndex = 1;
            this.Workers.Text = "Работники";
            // 
            // WdataGridView
            // 
            this.WdataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.WdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WSname,
            this.Sex,
            this.Age,
            this.Workingplace,
            this.Wposit});
            this.WdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WdataGridView.Location = new System.Drawing.Point(3, 3);
            this.WdataGridView.Name = "WdataGridView";
            this.WdataGridView.RowHeadersWidth = 51;
            this.WdataGridView.RowTemplate.Height = 24;
            this.WdataGridView.Size = new System.Drawing.Size(1048, 647);
            this.WdataGridView.TabIndex = 0;
            // 
            // Positions
            // 
            this.Positions.BackColor = System.Drawing.Color.DarkKhaki;
            this.Positions.Controls.Add(this.PdataGridView);
            this.Positions.Location = new System.Drawing.Point(4, 25);
            this.Positions.Name = "Positions";
            this.Positions.Padding = new System.Windows.Forms.Padding(3);
            this.Positions.Size = new System.Drawing.Size(1054, 653);
            this.Positions.TabIndex = 2;
            this.Positions.Text = "Должности";
            // 
            // PdataGridView
            // 
            this.PdataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.PdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pname,
            this.Duties,
            this.Payment});
            this.PdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PdataGridView.Location = new System.Drawing.Point(3, 3);
            this.PdataGridView.Name = "PdataGridView";
            this.PdataGridView.RowHeadersWidth = 51;
            this.PdataGridView.RowTemplate.Height = 24;
            this.PdataGridView.Size = new System.Drawing.Size(1048, 647);
            this.PdataGridView.TabIndex = 0;
            // 
            // Pname
            // 
            this.Pname.HeaderText = "Название";
            this.Pname.MinimumWidth = 6;
            this.Pname.Name = "Pname";
            this.Pname.Width = 325;
            // 
            // Duties
            // 
            this.Duties.HeaderText = "Обязанности";
            this.Duties.MinimumWidth = 6;
            this.Duties.Name = "Duties";
            this.Duties.Width = 350;
            // 
            // Payment
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Payment.DefaultCellStyle = dataGridViewCellStyle6;
            this.Payment.HeaderText = "Оплата";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            this.Payment.Width = 325;
            // 
            // WSname
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WSname.DefaultCellStyle = dataGridViewCellStyle3;
            this.WSname.HeaderText = "ФИО";
            this.WSname.MinimumWidth = 6;
            this.WSname.Name = "WSname";
            this.WSname.Width = 275;
            // 
            // Sex
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sex.DefaultCellStyle = dataGridViewCellStyle4;
            this.Sex.HeaderText = "Пол";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.Width = 250;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            // 
            // Workingplace
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Workingplace.DefaultCellStyle = dataGridViewCellStyle5;
            this.Workingplace.HeaderText = "Место работы";
            this.Workingplace.MinimumWidth = 6;
            this.Workingplace.Name = "Workingplace";
            this.Workingplace.Width = 220;
            // 
            // Wposit
            // 
            this.Wposit.HeaderText = "Должность";
            this.Wposit.MinimumWidth = 6;
            this.Wposit.Name = "Wposit";
            this.Wposit.Width = 250;
            // 
            // XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 682);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "XML";
            this.Text = "XML";
            this.tabControl1.ResumeLayout(false);
            this.Shops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShopsdataGridView)).EndInit();
            this.Workers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WdataGridView)).EndInit();
            this.Positions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Shops;
        private System.Windows.Forms.TabPage Workers;
        private System.Windows.Forms.TabPage Positions;
        private System.Windows.Forms.DataGridView ShopsdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Snumofworkingplaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kindofshop;
        private System.Windows.Forms.DataGridView WdataGridView;
        private System.Windows.Forms.DataGridView PdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duties;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn WSname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workingplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wposit;
    }
}

