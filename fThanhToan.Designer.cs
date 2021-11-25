
namespace BTLQuanLyQuanCafe
{
    partial class fThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxhd = new System.Windows.Forms.GroupBox();
            this.dg_monan_ofban = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttongtien = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxhd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_monan_ofban)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxhd
            // 
            this.groupBoxhd.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxhd.Controls.Add(this.dg_monan_ofban);
            this.groupBoxhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxhd.ForeColor = System.Drawing.Color.Red;
            this.groupBoxhd.Location = new System.Drawing.Point(12, 12);
            this.groupBoxhd.Name = "groupBoxhd";
            this.groupBoxhd.Size = new System.Drawing.Size(644, 273);
            this.groupBoxhd.TabIndex = 2;
            this.groupBoxhd.TabStop = false;
            this.groupBoxhd.Text = "Hóa đơn";
            // 
            // dg_monan_ofban
            // 
            this.dg_monan_ofban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_monan_ofban.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_monan_ofban.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dg_monan_ofban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_monan_ofban.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg_monan_ofban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_monan_ofban.EnableHeadersVisualStyles = false;
            this.dg_monan_ofban.Location = new System.Drawing.Point(3, 20);
            this.dg_monan_ofban.Name = "dg_monan_ofban";
            this.dg_monan_ofban.Size = new System.Drawing.Size(638, 250);
            this.dg_monan_ofban.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txttongtien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(15, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng Tiền (VNĐ)";
            // 
            // txttongtien
            // 
            this.txttongtien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txttongtien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttongtien.Location = new System.Drawing.Point(3, 20);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttongtien.Size = new System.Drawing.Size(523, 61);
            this.txttongtien.TabIndex = 1;
            this.txttongtien.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxhd);
            this.Name = "fThanhToan";
            this.Text = "fThanhToan";
            this.groupBoxhd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_monan_ofban)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxhd;
        private System.Windows.Forms.DataGridView dg_monan_ofban;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txttongtien;
        private System.Windows.Forms.Button button1;
    }
}