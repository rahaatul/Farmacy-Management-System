
namespace Pharmacy_Management_System.Presentation_Layer
{
    partial class CategoryManagement
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
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.updateCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.deleteCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 517);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 27);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.updateCategoryNameTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.searchButton);
            this.groupBox4.Controls.Add(this.updateButton);
            this.groupBox4.Controls.Add(this.searchCategoryIdTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(-5, 304);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(315, 164);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Category";
            // 
            // updateCategoryNameTextBox
            // 
            this.updateCategoryNameTextBox.Location = new System.Drawing.Point(132, 75);
            this.updateCategoryNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.updateCategoryNameTextBox.Name = "updateCategoryNameTextBox";
            this.updateCategoryNameTextBox.Size = new System.Drawing.Size(157, 22);
            this.updateCategoryNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(195, 30);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 27);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(132, 114);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(159, 32);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // searchCategoryIdTextBox
            // 
            this.searchCategoryIdTextBox.Location = new System.Drawing.Point(132, 32);
            this.searchCategoryIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchCategoryIdTextBox.Name = "searchCategoryIdTextBox";
            this.searchCategoryIdTextBox.Size = new System.Drawing.Size(53, 22);
            this.searchCategoryIdTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteCategoryButton);
            this.groupBox3.Controls.Add(this.deleteCategoryIdTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(-5, 168);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(315, 112);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Category";
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(132, 64);
            this.deleteCategoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(159, 32);
            this.deleteCategoryButton.TabIndex = 2;
            this.deleteCategoryButton.Text = "Delete";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            // 
            // deleteCategoryIdTextBox
            // 
            this.deleteCategoryIdTextBox.Location = new System.Drawing.Point(132, 32);
            this.deleteCategoryIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.deleteCategoryIdTextBox.Name = "deleteCategoryIdTextBox";
            this.deleteCategoryIdTextBox.Size = new System.Drawing.Size(157, 22);
            this.deleteCategoryIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addCategoryButton);
            this.groupBox2.Controls.Add(this.addCategoryNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(-5, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(315, 112);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Category";
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(132, 64);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(159, 32);
            this.addCategoryButton.TabIndex = 2;
            this.addCategoryButton.Text = "Add";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            // 
            // addCategoryNameTextBox
            // 
            this.addCategoryNameTextBox.Location = new System.Drawing.Point(132, 32);
            this.addCategoryNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addCategoryNameTextBox.Name = "addCategoryNameTextBox";
            this.addCategoryNameTextBox.Size = new System.Drawing.Size(157, 22);
            this.addCategoryNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoryListDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(366, 144);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(441, 213);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category List";
            // 
            // categoryListDataGridView
            // 
            this.categoryListDataGridView.AllowUserToAddRows = false;
            this.categoryListDataGridView.AllowUserToDeleteRows = false;
            this.categoryListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryListDataGridView.Location = new System.Drawing.Point(28, 26);
            this.categoryListDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.categoryListDataGridView.Name = "categoryListDataGridView";
            this.categoryListDataGridView.ReadOnly = true;
            this.categoryListDataGridView.RowHeadersWidth = 51;
            this.categoryListDataGridView.Size = new System.Drawing.Size(395, 170);
            this.categoryListDataGridView.TabIndex = 0;
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 556);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryManagement_FormClosing);
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox updateCategoryNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox searchCategoryIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.TextBox deleteCategoryIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.TextBox addCategoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView categoryListDataGridView;
    }
}