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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.field_man_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.field_man_Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.field_man_Gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.field_man_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.field_man_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.field_man_team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_man_save = new System.Windows.Forms.Button();
            this.btn_man_delete = new System.Windows.Forms.Button();
            this.btn_man_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.field_man_ID,
            this.field_man_Fname,
            this.field_man_Gname,
            this.field_man_email,
            this.field_man_time,
            this.field_man_team});
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 466);
            this.dataGridView1.TabIndex = 0;
            // 
            // field_man_ID
            // 
            this.field_man_ID.HeaderText = "ID";
            this.field_man_ID.Name = "field_man_ID";
            this.field_man_ID.Width = 50;
            // 
            // field_man_Fname
            // 
            this.field_man_Fname.HeaderText = "Family Name";
            this.field_man_Fname.Name = "field_man_Fname";
            // 
            // field_man_Gname
            // 
            this.field_man_Gname.HeaderText = "Given Name";
            this.field_man_Gname.Name = "field_man_Gname";
            // 
            // field_man_email
            // 
            this.field_man_email.HeaderText = "E-mail";
            this.field_man_email.Name = "field_man_email";
            // 
            // field_man_time
            // 
            this.field_man_time.HeaderText = "Time";
            this.field_man_time.Name = "field_man_time";
            // 
            // field_man_team
            // 
            this.field_man_team.HeaderText = "Team";
            this.field_man_team.Name = "field_man_team";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_man_save);
            this.groupBox1.Controls.Add(this.btn_man_delete);
            this.groupBox1.Controls.Add(this.btn_man_add);
            this.groupBox1.Location = new System.Drawing.Point(421, 67);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
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
            this.ClientSize = new System.Drawing.Size(615, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManForm";
            this.Text = "SalesMan Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn field_man_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn field_man_Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn field_man_Gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn field_man_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn field_man_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn field_man_team;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_man_save;
        private System.Windows.Forms.Button btn_man_delete;
        private System.Windows.Forms.Button btn_man_add;
        private System.Windows.Forms.Label label1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}