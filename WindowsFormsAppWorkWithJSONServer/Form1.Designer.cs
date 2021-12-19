
namespace WindowsFormsAppWorkWithJSONServer
{
    partial class Form1
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
            this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGetOnePost = new System.Windows.Forms.Button();
            this.textBoxPostId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetListPosts = new System.Windows.Forms.Button();
            this.buttonInsertOnePost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPosts
            // 
            this.dataGridViewPosts.AllowUserToAddRows = false;
            this.dataGridViewPosts.AllowUserToDeleteRows = false;
            this.dataGridViewPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewPosts.Location = new System.Drawing.Point(16, 24);
            this.dataGridViewPosts.Name = "dataGridViewPosts";
            this.dataGridViewPosts.ReadOnly = true;
            this.dataGridViewPosts.Size = new System.Drawing.Size(656, 168);
            this.dataGridViewPosts.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "userId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "title";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "body";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // buttonGetOnePost
            // 
            this.buttonGetOnePost.Location = new System.Drawing.Point(16, 256);
            this.buttonGetOnePost.Name = "buttonGetOnePost";
            this.buttonGetOnePost.Size = new System.Drawing.Size(168, 23);
            this.buttonGetOnePost.TabIndex = 1;
            this.buttonGetOnePost.Text = "GetOnePost";
            this.buttonGetOnePost.UseVisualStyleBackColor = true;
            this.buttonGetOnePost.Click += new System.EventHandler(this.buttonGetOnePost_Click);
            // 
            // textBoxPostId
            // 
            this.textBoxPostId.Location = new System.Drawing.Point(16, 232);
            this.textBoxPostId.Name = "textBoxPostId";
            this.textBoxPostId.Size = new System.Drawing.Size(168, 20);
            this.textBoxPostId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "post id";
            // 
            // buttonGetListPosts
            // 
            this.buttonGetListPosts.Location = new System.Drawing.Point(256, 256);
            this.buttonGetListPosts.Name = "buttonGetListPosts";
            this.buttonGetListPosts.Size = new System.Drawing.Size(144, 23);
            this.buttonGetListPosts.TabIndex = 4;
            this.buttonGetListPosts.Text = "GetListPosts";
            this.buttonGetListPosts.UseVisualStyleBackColor = true;
            this.buttonGetListPosts.Click += new System.EventHandler(this.buttonGetListPosts_Click);
            // 
            // buttonInsertOnePost
            // 
            this.buttonInsertOnePost.Location = new System.Drawing.Point(448, 256);
            this.buttonInsertOnePost.Name = "buttonInsertOnePost";
            this.buttonInsertOnePost.Size = new System.Drawing.Size(112, 23);
            this.buttonInsertOnePost.TabIndex = 5;
            this.buttonInsertOnePost.Text = "InsertOnePost";
            this.buttonInsertOnePost.UseVisualStyleBackColor = true;
            this.buttonInsertOnePost.Click += new System.EventHandler(this.buttonInsertOnePost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 549);
            this.Controls.Add(this.buttonInsertOnePost);
            this.Controls.Add(this.buttonGetListPosts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPostId);
            this.Controls.Add(this.buttonGetOnePost);
            this.Controls.Add(this.dataGridViewPosts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonGetOnePost;
        private System.Windows.Forms.TextBox textBoxPostId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetListPosts;
        private System.Windows.Forms.Button buttonInsertOnePost;
    }
}

