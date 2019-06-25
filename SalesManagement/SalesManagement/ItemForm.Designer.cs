namespace SalesManagement
{
    partial class ItemForm
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
            this.grid_items = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_item_save = new System.Windows.Forms.Button();
            this.btn_item_del = new System.Windows.Forms.Button();
            this.btn_item_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_items)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_items
            // 
            this.grid_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_items.Location = new System.Drawing.Point(4, 101);
            this.grid_items.Name = "grid_items";
            this.grid_items.Size = new System.Drawing.Size(533, 422);
            this.grid_items.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_item_save);
            this.groupBox1.Controls.Add(this.btn_item_del);
            this.groupBox1.Controls.Add(this.btn_item_add);
            this.groupBox1.Location = new System.Drawing.Point(337, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // btn_item_save
            // 
            this.btn_item_save.Location = new System.Drawing.Point(135, 21);
            this.btn_item_save.Name = "btn_item_save";
            this.btn_item_save.Size = new System.Drawing.Size(57, 23);
            this.btn_item_save.TabIndex = 2;
            this.btn_item_save.Text = "Save";
            this.btn_item_save.UseVisualStyleBackColor = true;
            this.btn_item_save.Click += new System.EventHandler(this.btn_item_save_Click);
            // 
            // btn_item_del
            // 
            this.btn_item_del.Location = new System.Drawing.Point(72, 21);
            this.btn_item_del.Name = "btn_item_del";
            this.btn_item_del.Size = new System.Drawing.Size(57, 23);
            this.btn_item_del.TabIndex = 1;
            this.btn_item_del.Text = "Delete";
            this.btn_item_del.UseVisualStyleBackColor = true;
            this.btn_item_del.Click += new System.EventHandler(this.btn_item_del_Click);
            // 
            // btn_item_add
            // 
            this.btn_item_add.Location = new System.Drawing.Point(6, 21);
            this.btn_item_add.Name = "btn_item_add";
            this.btn_item_add.Size = new System.Drawing.Size(57, 23);
            this.btn_item_add.TabIndex = 0;
            this.btn_item_add.Text = "Add";
            this.btn_item_add.UseVisualStyleBackColor = true;
            this.btn_item_add.Click += new System.EventHandler(this.btn_item_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Products";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Management";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_items)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_items;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_item_save;
        private System.Windows.Forms.Button btn_item_del;
        private System.Windows.Forms.Button btn_item_add;
        private System.Windows.Forms.Label label1;
    }
}