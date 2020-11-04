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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 325);
            this.Controls.Add(this.FoldersTreeView);
            this.Controls.Add(this.RefreshFoldersButton);
            this.Name = "MainForm";
            this.Text = "Random Bookmark Reader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RefreshFoldersButton;
        private System.Windows.Forms.TreeView FoldersTreeView;
    }
}

