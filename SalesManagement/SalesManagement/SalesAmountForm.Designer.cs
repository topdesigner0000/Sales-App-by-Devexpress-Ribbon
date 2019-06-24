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
            this.month_control = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_amount_save = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.month_control.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // month_control
            // 
            this.month_control.Location = new System.Drawing.Point(103, 63);
            this.month_control.Name = "month_control";
            this.month_control.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.month_control.Properties.Appearance.Options.UseBackColor = true;
            this.month_control.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.month_control.Size = new System.Drawing.Size(100, 20);
            this.month_control.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Month";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(923, 419);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_amount_save
            // 
            this.btn_amount_save.Appearance.Font = new System.Drawing.Font("Tekton Pro Ext", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_amount_save.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_amount_save.Appearance.Options.UseFont = true;
            this.btn_amount_save.Appearance.Options.UseForeColor = true;
            this.btn_amount_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_amount_save.Location = new System.Drawing.Point(859, 78);
            this.btn_amount_save.Name = "btn_amount_save";
            this.btn_amount_save.Size = new System.Drawing.Size(75, 23);
            this.btn_amount_save.TabIndex = 3;
            this.btn_amount_save.Text = "Save";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sales Amount";
            // 
            // SalesAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_amount_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.month_control);
            this.Name = "SalesAmountForm";
            this.Text = "SalesAmount";
            this.Load += new System.EventHandler(this.SalesAmountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.month_control.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.UI.MonthEdit month_control;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_amount_save;
        private System.Windows.Forms.Label label1;
    }
}