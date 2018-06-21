namespace WFView
{
    partial class DBForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.QueryButton = new System.Windows.Forms.Button();
            this.PowerModeGridView = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectButton = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PowerModeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryButton
            // 
            this.QueryButton.Location = new System.Drawing.Point(397, 12);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(75, 23);
            this.QueryButton.TabIndex = 0;
            this.QueryButton.Text = "query";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // PowerModeGridView
            // 
            this.PowerModeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PowerModeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.seq,
            this.startDateTime,
            this.endDateTime,
            this.status});
            this.PowerModeGridView.Location = new System.Drawing.Point(12, 41);
            this.PowerModeGridView.Name = "PowerModeGridView";
            this.PowerModeGridView.RowTemplate.Height = 21;
            this.PowerModeGridView.Size = new System.Drawing.Size(576, 402);
            this.PowerModeGridView.TabIndex = 1;
            // 
            // select
            // 
            this.select.HeaderText = "select";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // seq
            // 
            this.seq.DataPropertyName = "seq";
            this.seq.HeaderText = "seq";
            this.seq.Name = "seq";
            // 
            // startDateTime
            // 
            this.startDateTime.DataPropertyName = "startDateTime";
            this.startDateTime.HeaderText = "startDateTime";
            this.startDateTime.Name = "startDateTime";
            // 
            // endDateTime
            // 
            this.endDateTime.DataPropertyName = "endDateTime";
            this.endDateTime.HeaderText = "endDateTime";
            this.endDateTime.Name = "endDateTime";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(12, 12);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(154, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(235, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(316, 12);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 455);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.PowerModeGridView);
            this.Controls.Add(this.QueryButton);
            this.Name = "DBForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PowerModeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.DataGridView PowerModeGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}

