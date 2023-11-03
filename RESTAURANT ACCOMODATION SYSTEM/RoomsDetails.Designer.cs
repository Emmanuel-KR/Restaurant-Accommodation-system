
namespace RESTAURANT_ACCOMODATION_SYSTEM
{
    partial class RoomsDetails
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
            this.components = new System.ComponentModel.Container();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.comboBed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddRoombtn = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsDetailsDataSet = new RESTAURANT_ACCOMODATION_SYSTEM.roomsDetailsDataSet();
            this.roomsDetailsTableAdapter = new RESTAURANT_ACCOMODATION_SYSTEM.roomsDetailsDataSetTableAdapters.roomsDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDetailsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(948, 165);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(401, 26);
            this.txtRoom.TabIndex = 0;
            // 
            // comboBed
            // 
            this.comboBed.FormattingEnabled = true;
            this.comboBed.Items.AddRange(new object[] {
            "SINGLE",
            "DOUBLE",
            "TRIPLE"});
            this.comboBed.Location = new System.Drawing.Point(948, 379);
            this.comboBed.Name = "comboBed";
            this.comboBed.Size = new System.Drawing.Size(401, 28);
            this.comboBed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADD NEW ROOM";
            // 
            // AddRoombtn
            // 
            this.AddRoombtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoombtn.Location = new System.Drawing.Point(1157, 589);
            this.AddRoombtn.Name = "AddRoombtn";
            this.AddRoombtn.Size = new System.Drawing.Size(161, 67);
            this.AddRoombtn.TabIndex = 3;
            this.AddRoombtn.Text = "ADD ROOM";
            this.AddRoombtn.UseVisualStyleBackColor = true;
            this.AddRoombtn.Click += new System.EventHandler(this.AddRoombtn_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(948, 498);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(401, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // comboRoom
            // 
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Items.AddRange(new object[] {
            "CLASS A",
            "CLASS B"});
            this.comboRoom.Location = new System.Drawing.Point(948, 284);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(401, 28);
            this.comboRoom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(943, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "ROOM NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(943, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "ROOM TYPE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(943, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "BED TYPE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(943, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "PRICE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNODataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.bedTypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomsDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(98, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(716, 362);
            this.dataGridView1.TabIndex = 11;
            // 
            // roomNODataGridViewTextBoxColumn
            // 
            this.roomNODataGridViewTextBoxColumn.DataPropertyName = "Room NO";
            this.roomNODataGridViewTextBoxColumn.HeaderText = "Room NO";
            this.roomNODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomNODataGridViewTextBoxColumn.Name = "roomNODataGridViewTextBoxColumn";
            this.roomNODataGridViewTextBoxColumn.Width = 150;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room Type";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.roomTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // bedTypeDataGridViewTextBoxColumn
            // 
            this.bedTypeDataGridViewTextBoxColumn.DataPropertyName = "Bed Type";
            this.bedTypeDataGridViewTextBoxColumn.HeaderText = "Bed Type";
            this.bedTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bedTypeDataGridViewTextBoxColumn.Name = "bedTypeDataGridViewTextBoxColumn";
            this.bedTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomsDetailsBindingSource
            // 
            this.roomsDetailsBindingSource.DataMember = "roomsDetails";
            this.roomsDetailsBindingSource.DataSource = this.roomsDetailsDataSet;
            // 
            // roomsDetailsDataSet
            // 
            this.roomsDetailsDataSet.DataSetName = "roomsDetailsDataSet";
            this.roomsDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsDetailsTableAdapter
            // 
            this.roomsDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // RoomsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1433, 679);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.AddRoombtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBed);
            this.Controls.Add(this.txtRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RoomsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomsDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RoomsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDetailsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.ComboBox comboBed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddRoombtn;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private roomsDetailsDataSet roomsDetailsDataSet;
        private System.Windows.Forms.BindingSource roomsDetailsBindingSource;
        private roomsDetailsDataSetTableAdapters.roomsDetailsTableAdapter roomsDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}