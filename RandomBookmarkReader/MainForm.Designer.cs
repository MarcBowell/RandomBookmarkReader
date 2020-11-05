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
            this.RefreshFoldersButton.Location = new System.Drawing.Point(1, 3);
            this.RefreshFoldersButton.Name = "RefreshFoldersButton";
            this.RefreshFoldersButton.Size = new System.Drawing.Size(543, 45);
            this.RefreshFoldersButton.TabIndex = 0;
            this.RefreshFoldersButton.Text = "Refresh folders";
            this.RefreshFoldersButton.UseVisualStyleBackColor = true;
            this.RefreshFoldersButton.Click += new System.EventHandler(this.RefreshFoldersButton_Click);
            // 
            // FoldersTreeView
            // 
            this.FoldersTreeView.Location = new System.Drawing.Point(1, 50);
            this.FoldersTreeView.Name = "FoldersTreeView";
            this.FoldersTreeView.Size = new System.Drawing.Size(543, 267);
            this.FoldersTreeView.TabIndex = 1;
            // 
            // IncludesSubFoldersCheckbox
            // 
            this.IncludesSubFoldersCheckbox.AutoSize = true;
            this.IncludesSubFoldersCheckbox.Checked = true;
            this.IncludesSubFoldersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludesSubFoldersCheckbox.Location = new System.Drawing.Point(1, 324);
            this.IncludesSubFoldersCheckbox.Name = "IncludesSubFoldersCheckbox";
            this.IncludesSubFoldersCheckbox.Size = new System.Drawing.Size(121, 17);
            this.IncludesSubFoldersCheckbox.TabIndex = 2;
            this.IncludesSubFoldersCheckbox.Text = "Include sub folders?";
            this.IncludesSubFoldersCheckbox.UseVisualStyleBackColor = true;
            // 
            // TotalItemsPicker
            // 
            this.TotalItemsPicker.Location = new System.Drawing.Point(505, 320);
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
            this.TotalItemsPicker.Size = new System.Drawing.Size(39, 20);
            this.TotalItemsPicker.TabIndex = 3;
            this.TotalItemsPicker.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.Location = new System.Drawing.Point(419, 322);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(58, 13);
            this.TotalItemsLabel.TabIndex = 4;
            this.TotalItemsLabel.Text = "Total items";
            // 
            // GetRandomItemsButton
            // 
            this.GetRandomItemsButton.Location = new System.Drawing.Point(1, 365);
            this.GetRandomItemsButton.Name = "GetRandomItemsButton";
            this.GetRandomItemsButton.Size = new System.Drawing.Size(543, 38);
            this.GetRandomItemsButton.TabIndex = 5;
            this.GetRandomItemsButton.Text = "Get random items";
            this.GetRandomItemsButton.UseVisualStyleBackColor = true;
            this.GetRandomItemsButton.Click += new System.EventHandler(this.GetRandomItemsButton_Click);
            // 
            // ShortlistOfUrlsGrid
            // 
            this.ShortlistOfUrlsGrid.AllowUserToAddRows = false;
            this.ShortlistOfUrlsGrid.AllowUserToDeleteRows = false;
            this.ShortlistOfUrlsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShortlistOfUrlsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedColumn,
            this.NameColumn,
            this.UrlColumn});
            this.ShortlistOfUrlsGrid.Location = new System.Drawing.Point(1, 421);
            this.ShortlistOfUrlsGrid.Name = "ShortlistOfUrlsGrid";
            this.ShortlistOfUrlsGrid.RowHeadersVisible = false;
            this.ShortlistOfUrlsGrid.Size = new System.Drawing.Size(543, 150);
            this.ShortlistOfUrlsGrid.TabIndex = 6;
            // 
            // DisplayUrlsButton
            // 
            this.DisplayUrlsButton.Location = new System.Drawing.Point(1, 578);
            this.DisplayUrlsButton.Name = "DisplayUrlsButton";
            this.DisplayUrlsButton.Size = new System.Drawing.Size(543, 51);
            this.DisplayUrlsButton.TabIndex = 7;
            this.DisplayUrlsButton.Text = "Display web pages";
            this.DisplayUrlsButton.UseVisualStyleBackColor = true;
            this.DisplayUrlsButton.Click += new System.EventHandler(this.DisplayUrlsButton_Click);
            // 
            // SelectedColumn
            // 
            this.SelectedColumn.HeaderText = "Select";
            this.SelectedColumn.Name = "SelectedColumn";
            this.SelectedColumn.Width = 50;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "UrlName";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 200;
            // 
            // UrlColumn
            // 
            this.UrlColumn.DataPropertyName = "Url";
            this.UrlColumn.HeaderText = "URL";
            this.UrlColumn.Name = "UrlColumn";
            this.UrlColumn.ReadOnly = true;
            this.UrlColumn.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 641);
            this.Controls.Add(this.DisplayUrlsButton);
            this.Controls.Add(this.ShortlistOfUrlsGrid);
            this.Controls.Add(this.GetRandomItemsButton);
            this.Controls.Add(this.TotalItemsLabel);
            this.Controls.Add(this.TotalItemsPicker);
            this.Controls.Add(this.IncludesSubFoldersCheckbox);
            this.Controls.Add(this.FoldersTreeView);
            this.Controls.Add(this.RefreshFoldersButton);
            this.Name = "MainForm";
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

