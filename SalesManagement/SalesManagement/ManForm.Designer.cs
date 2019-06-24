namespace SalesManagement
{
    partial class ManForm
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
            this.grid_employees = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_man_save = new System.Windows.Forms.Button();
            this.btn_man_delete = new System.Windows.Forms.Button();
            this.btn_man_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_employees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_employees
            // 
            this.grid_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_employees.Location = new System.Drawing.Point(3, 87);
            this.grid_employees.Name = "grid_employees";
            this.grid_employees.Size = new System.Drawing.Size(734, 466);
            this.grid_employees.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_man_save);
            this.groupBox1.Controls.Add(this.btn_man_delete);
            this.groupBox1.Controls.Add(this.btn_man_add);
            this.groupBox1.Location = new System.Drawing.Point(555, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // btn_man_save
            // 
            this.btn_man_save.Location = new System.Drawing.Point(124, 16);
            this.btn_man_save.Name = "btn_man_save";
            this.btn_man_save.Size = new System.Drawing.Size(56, 23);
            this.btn_man_save.TabIndex = 2;
            this.btn_man_save.Text = "Save";
            this.btn_man_save.UseVisualStyleBackColor = true;
            // 
            // btn_man_delete
            // 
            this.btn_man_delete.Location = new System.Drawing.Point(62, 16);
            this.btn_man_delete.Name = "btn_man_delete";
            this.btn_man_delete.Size = new System.Drawing.Size(56, 23);
            this.btn_man_delete.TabIndex = 1;
            this.btn_man_delete.Text = "Delete";
            this.btn_man_delete.UseVisualStyleBackColor = true;
            // 
            // btn_man_add
            // 
            this.btn_man_add.Location = new System.Drawing.Point(0, 16);
            this.btn_man_add.Name = "btn_man_add";
            this.btn_man_add.Size = new System.Drawing.Size(56, 23);
            this.btn_man_add.TabIndex = 0;
            this.btn_man_add.Text = "Add";
            this.btn_man_add.UseVisualStyleBackColor = true;
            this.btn_man_add.Click += new System.EventHandler(this.btn_man_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "SalesMen";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Dark";
            // 
            // ManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_employees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManForm";
            this.Text = "SalesMan Management";
            this.Load += new System.EventHandler(this.ManForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_employees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_employees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_man_save;
        private System.Windows.Forms.Button btn_man_delete;
        private System.Windows.Forms.Button btn_man_add;
        private System.Windows.Forms.Label label1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}