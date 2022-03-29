
namespace Triangles
{
    partial class Print
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CutA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CutB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CutC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perimeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TType,
            this.SideA,
            this.SideB,
            this.SideC,
            this.CutA,
            this.CutB,
            this.CutC,
            this.Perimeter,
            this.Square});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(810, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // TType
            // 
            this.TType.HeaderText = "Тип трикутника";
            this.TType.Name = "TType";
            this.TType.Width = 120;
            // 
            // SideA
            // 
            this.SideA.HeaderText = "Сторона А";
            this.SideA.Name = "SideA";
            this.SideA.ReadOnly = true;
            this.SideA.Width = 90;
            // 
            // SideB
            // 
            this.SideB.HeaderText = "Сторона В";
            this.SideB.Name = "SideB";
            this.SideB.ReadOnly = true;
            this.SideB.Width = 90;
            // 
            // SideC
            // 
            this.SideC.HeaderText = "Сторона C";
            this.SideC.Name = "SideC";
            this.SideC.ReadOnly = true;
            this.SideC.Width = 90;
            // 
            // CutA
            // 
            this.CutA.HeaderText = "Кут А";
            this.CutA.Name = "CutA";
            this.CutA.ReadOnly = true;
            this.CutA.Width = 65;
            // 
            // CutB
            // 
            this.CutB.HeaderText = "Кут B";
            this.CutB.Name = "CutB";
            this.CutB.ReadOnly = true;
            this.CutB.Width = 65;
            // 
            // CutC
            // 
            this.CutC.HeaderText = "Кут C";
            this.CutC.Name = "CutC";
            this.CutC.ReadOnly = true;
            this.CutC.Width = 65;
            // 
            // Perimeter
            // 
            this.Perimeter.HeaderText = "Периметр";
            this.Perimeter.Name = "Perimeter";
            this.Perimeter.ReadOnly = true;
            this.Perimeter.Width = 90;
            // 
            // Square
            // 
            this.Square.HeaderText = "Площа";
            this.Square.Name = "Square";
            this.Square.ReadOnly = true;
            this.Square.Width = 75;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Різносторонній";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.change);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(123, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Рівнобедрений";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.change);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фільтр:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(84, 510);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(466, 33);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(238, 6);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox3.Size = new System.Drawing.Size(112, 19);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Рівносторонній";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.change);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(356, 6);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 19);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Прямокутний";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.change);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 510);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Основне завдання";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Print";
            this.Text = "Вивід трикутників";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SideA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SideB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SideC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CutA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CutB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CutC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perimeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Square;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
    }
}