namespace SalesManagement
{
    partial class SalesAmountForm
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
            this.btn_amount_save = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.choose_month = new DevExpress.XtraEditors.Controls.CalendarControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choose_month.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1012, 380);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_amount_save
            // 
            this.btn_amount_save.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_amount_save.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_amount_save.Appearance.Options.UseFont = true;
            this.btn_amount_save.Appearance.Options.UseForeColor = true;
            this.btn_amount_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_amount_save.Location = new System.Drawing.Point(12, 157);
            this.btn_amount_save.Name = "btn_amount_save";
            this.btn_amount_save.Size = new System.Drawing.Size(75, 32);
            this.btn_amount_save.TabIndex = 3;
            this.btn_amount_save.Text = "Save";
            this.btn_amount_save.Click += new System.EventHandler(this.btn_amount_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sales Amount";
            // 
            // choose_month
            // 
            this.choose_month.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.choose_month.Location = new System.Drawing.Point(782, 1);
            this.choose_month.Name = "choose_month";
            this.choose_month.ShowFooter = false;
            this.choose_month.ShowTodayButton = false;
            this.choose_month.ShowToolTips = false;
            this.choose_month.Size = new System.Drawing.Size(232, 202);
            this.choose_month.TabIndex = 5;
            this.choose_month.SelectionChanged += new System.EventHandler(this.choose_month_ValueChanged);
            // 
            // SalesAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 584);
            this.Controls.Add(this.choose_month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_amount_save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SalesAmountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesAmount";
            this.Load += new System.EventHandler(this.SalesAmountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choose_month.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_amount_save;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.Controls.CalendarControl choose_month;
    }
}