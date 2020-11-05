namespace Marcware.RandomBookmarkReader
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RefreshFoldersButton = new System.Windows.Forms.Button();
            this.FoldersTreeView = new System.Windows.Forms.TreeView();
            this.IncludesSubFoldersCheckbox = new System.Windows.Forms.CheckBox();
            this.TotalItemsPicker = new System.Windows.Forms.NumericUpDown();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            this.GetRandomItemsButton = new System.Windows.Forms.Button();
            this.ShortlistOfUrlsGrid = new System.Windows.Forms.DataGridView();
            this.DisplayUrlsButton = new System.Windows.Forms.Button();
            this.SelectedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TotalItemsPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortlistOfUrlsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshFoldersButton
            // 
            this.RefreshFoldersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshFoldersButton.BackColor = System.Drawing.Color.Black;
            this.RefreshFoldersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshFoldersButton.ForeColor = System.Drawing.Color.White;
            this.RefreshFoldersButton.Location = new System.Drawing.Point(1, -1);
            this.RefreshFoldersButton.Name = "RefreshFoldersButton";
            this.RefreshFoldersButton.Size = new System.Drawing.Size(733, 45);
            this.RefreshFoldersButton.TabIndex = 0;
            this.RefreshFoldersButton.Text = "Refresh folders";
            this.RefreshFoldersButton.UseVisualStyleBackColor = false;
            this.RefreshFoldersButton.Click += new System.EventHandler(this.RefreshFoldersButton_Click);
            // 
            // FoldersTreeView
            // 
            this.FoldersTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoldersTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FoldersTreeView.Enabled = false;
            this.FoldersTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoldersTreeView.Location = new System.Drawing.Point(1, 43);
            this.FoldersTreeView.Name = "FoldersTreeView";
            this.FoldersTreeView.Size = new System.Drawing.Size(733, 267);
            this.FoldersTreeView.TabIndex = 1;
            // 
            // IncludesSubFoldersCheckbox
            // 
            this.IncludesSubFoldersCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IncludesSubFoldersCheckbox.AutoSize = true;
            this.IncludesSubFoldersCheckbox.Checked = true;
            this.IncludesSubFoldersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludesSubFoldersCheckbox.Enabled = false;
            this.IncludesSubFoldersCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludesSubFoldersCheckbox.Location = new System.Drawing.Point(1, 313);
            this.IncludesSubFoldersCheckbox.Name = "IncludesSubFoldersCheckbox";
            this.IncludesSubFoldersCheckbox.Size = new System.Drawing.Size(191, 24);
            this.IncludesSubFoldersCheckbox.TabIndex = 2;
            this.IncludesSubFoldersCheckbox.Text = "Include sub folders?";
            this.IncludesSubFoldersCheckbox.UseVisualStyleBackColor = true;
            // 
            // TotalItemsPicker
            // 
            this.TotalItemsPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalItemsPicker.Enabled = false;
            this.TotalItemsPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsPicker.Location = new System.Drawing.Point(695, 311);
            this.TotalItemsPicker.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TotalItemsPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TotalItemsPicker.Name = "TotalItemsPicker";
            this.TotalItemsPicker.Size = new System.Drawing.Size(39, 26);
            this.TotalItemsPicker.TabIndex = 3;
            this.TotalItemsPicker.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.Enabled = false;
            this.TotalItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsLabel.Location = new System.Drawing.Point(550, 313);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(97, 20);
            this.TotalItemsLabel.TabIndex = 4;
            this.TotalItemsLabel.Text = "Total items";
            // 
            // GetRandomItemsButton
            // 
            this.GetRandomItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetRandomItemsButton.BackColor = System.Drawing.Color.Black;
            this.GetRandomItemsButton.Enabled = false;
            this.GetRandomItemsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetRandomItemsButton.ForeColor = System.Drawing.Color.White;
            this.GetRandomItemsButton.Location = new System.Drawing.Point(1, 346);
            this.GetRandomItemsButton.Name = "GetRandomItemsButton";
            this.GetRandomItemsButton.Size = new System.Drawing.Size(733, 45);
            this.GetRandomItemsButton.TabIndex = 5;
            this.GetRandomItemsButton.Text = "Get random items";
            this.GetRandomItemsButton.UseVisualStyleBackColor = false;
            this.GetRandomItemsButton.Click += new System.EventHandler(this.GetRandomItemsButton_Click);
            // 
            // ShortlistOfUrlsGrid
            // 
            this.ShortlistOfUrlsGrid.AllowUserToAddRows = false;
            this.ShortlistOfUrlsGrid.AllowUserToDeleteRows = false;
            this.ShortlistOfUrlsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortlistOfUrlsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ShortlistOfUrlsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShortlistOfUrlsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ShortlistOfUrlsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShortlistOfUrlsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedColumn,
            this.NameColumn,
            this.UrlColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShortlistOfUrlsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShortlistOfUrlsGrid.Enabled = false;
            this.ShortlistOfUrlsGrid.EnableHeadersVisualStyles = false;
            this.ShortlistOfUrlsGrid.Location = new System.Drawing.Point(1, 397);
            this.ShortlistOfUrlsGrid.Name = "ShortlistOfUrlsGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShortlistOfUrlsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ShortlistOfUrlsGrid.RowHeadersVisible = false;
            this.ShortlistOfUrlsGrid.Size = new System.Drawing.Size(733, 180);
            this.ShortlistOfUrlsGrid.TabIndex = 6;
            // 
            // DisplayUrlsButton
            // 
            this.DisplayUrlsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayUrlsButton.BackColor = System.Drawing.Color.Black;
            this.DisplayUrlsButton.Enabled = false;
            this.DisplayUrlsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayUrlsButton.ForeColor = System.Drawing.Color.White;
            this.DisplayUrlsButton.Location = new System.Drawing.Point(1, 580);
            this.DisplayUrlsButton.Name = "DisplayUrlsButton";
            this.DisplayUrlsButton.Size = new System.Drawing.Size(733, 45);
            this.DisplayUrlsButton.TabIndex = 7;
            this.DisplayUrlsButton.Text = "Display web pages";
            this.DisplayUrlsButton.UseVisualStyleBackColor = false;
            this.DisplayUrlsButton.Click += new System.EventHandler(this.DisplayUrlsButton_Click);
            // 
            // SelectedColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = false;
            this.SelectedColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SelectedColumn.HeaderText = "Select";
            this.SelectedColumn.Name = "SelectedColumn";
            this.SelectedColumn.Width = 80;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "UrlName";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 300;
            // 
            // UrlColumn
            // 
            this.UrlColumn.DataPropertyName = "Url";
            this.UrlColumn.HeaderText = "URL";
            this.UrlColumn.Name = "UrlColumn";
            this.UrlColumn.ReadOnly = true;
            this.UrlColumn.Width = 340;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(738, 628);
            this.Controls.Add(this.DisplayUrlsButton);
            this.Controls.Add(this.ShortlistOfUrlsGrid);
            this.Controls.Add(this.GetRandomItemsButton);
            this.Controls.Add(this.TotalItemsLabel);
            this.Controls.Add(this.TotalItemsPicker);
            this.Controls.Add(this.IncludesSubFoldersCheckbox);
            this.Controls.Add(this.FoldersTreeView);
            this.Controls.Add(this.RefreshFoldersButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Bookmark Reader";
            ((System.ComponentModel.ISupportInitialize)(this.TotalItemsPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortlistOfUrlsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshFoldersButton;
        private System.Windows.Forms.TreeView FoldersTreeView;
        private System.Windows.Forms.CheckBox IncludesSubFoldersCheckbox;
        private System.Windows.Forms.NumericUpDown TotalItemsPicker;
        private System.Windows.Forms.Label TotalItemsLabel;
        private System.Windows.Forms.Button GetRandomItemsButton;
        private System.Windows.Forms.DataGridView ShortlistOfUrlsGrid;
        private System.Windows.Forms.Button DisplayUrlsButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlColumn;
    }
}

