using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Marcware.RandomBookmarkReader.BookmarkContainerClasses;
using Marcware.RandomBookmarkReader.BookmarkManager;
using Marcware.RandomBookmarkReader.GeneralClasses;

namespace Marcware.RandomBookmarkReader
{
    public partial class MainForm : Form
    {
        private class FolderTreeNode
        {
            public FolderTreeNode(TreeNode node)
            {
                string result = string.Empty;
                string[] parts = node.Name.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 1)
                {
                    Browser = parts[0];
                    FolderId = parts[1];
                }
                else
                {
                    Browser = node.Name;
                }
            }

            public static string GetTreeNodeKey(BrowserBookmarks browser, BookmarkFolder folder)
            {
                return $"{browser.BrowserName}|{folder.FolderId}";
            }

            public string Browser { get; set; }

            public string FolderId { get; set; }
        }

        private static class ShortlistUrlGridColumns
        {
            public const string Selected = "SelectedColumn";
            public const string UrlName = "NameColumn";
            public const string Url = "UrlColumn";
        }

        private enum FormStatusTypes { Initialising, SelectingFolderOptions, SelectingFromShortlist }

        private BookmarkManagerClass BookmarkManager { get; set; }

        public MainForm()
        {
            InitializeComponent();
            SetFormStatus(FormStatusTypes.Initialising);
        }

        private void RefreshFoldersButton_Click(object sender, EventArgs e)
        {
            BookmarkManager = new BookmarkManagerClass();
            ProcessResult<Dictionary<string, BrowserBookmarks>> readerResult = BookmarkManager.GetBookmarksFromAllBrowsers();
            FoldersTreeView.Nodes.Clear();
            ShortlistOfUrlsGrid.DataSource = null;
            if (readerResult.Success)
            {
                foreach (BrowserBookmarks browser in readerResult.Result.Values)
                {
                    TreeNode browserNode = FoldersTreeView.Nodes.Add(browser.RootFolder.FolderId, browser.BrowserName);
                    AddChildFoldersToBookmarksTreeView(browser, browser.RootFolder, browserNode);
                }
                SetFormStatus(FormStatusTypes.SelectingFolderOptions);
            }
            else
            {
                MessageBox.Show(readerResult.ErrorMessage);
            }
        }

        private void AddChildFoldersToBookmarksTreeView(BrowserBookmarks browser, BookmarkFolder parentFolder, TreeNode parentNode)
        {
            foreach (BookmarkFolder childFolder in parentFolder.SubFolders)
            {
                TreeNode childNode = parentNode.Nodes.Add(FolderTreeNode.GetTreeNodeKey(browser, childFolder), childFolder.FolderName);
                AddChildFoldersToBookmarksTreeView(browser, childFolder, childNode);
            }
        }

        private void GetRandomItemsButton_Click(object sender, EventArgs e)
        {
            if (FoldersTreeView.SelectedNode != null)
            {
                FolderTreeNode treeNode = new FolderTreeNode(FoldersTreeView.SelectedNode);
                if (!string.IsNullOrEmpty(treeNode.FolderId))
                {
                    ProcessResult<List<BookmarkUrl>> randomUrlsResult = BookmarkManager.GetRandomUrlsFromFolder(treeNode.Browser, treeNode.FolderId, IncludesSubFoldersCheckbox.Checked, (int)TotalItemsPicker.Value);
                    if (randomUrlsResult.Success)
                    {
                        ShortlistOfUrlsGrid.AutoGenerateColumns = false;
                        ShortlistOfUrlsGrid.DataSource = randomUrlsResult.Result;
                        foreach (DataGridViewRow row in ShortlistOfUrlsGrid.Rows.Cast<DataGridViewRow>())
                        {
                            row.Cells[ShortlistUrlGridColumns.Selected].Value = true;
                        }
                        SetFormStatus(FormStatusTypes.SelectingFromShortlist);
                    }
                    else
                    {
                        MessageBox.Show(randomUrlsResult.ErrorMessage);
                    }
                }
                else
                {
                    MessageBox.Show("This is not a valid node to show random items from");
                }
            }
            else
            {
                MessageBox.Show("No folder has been selected");
            }
        }

        private void DisplayUrlsButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ShortlistOfUrlsGrid.Rows.Cast<DataGridViewRow>())
            {
                DataGridViewCheckBoxCell selectedColumn = (DataGridViewCheckBoxCell)row.Cells[ShortlistUrlGridColumns.Selected];
                if ((bool)selectedColumn.Value)
                {
                    string url = row.Cells[ShortlistUrlGridColumns.Url].Value.ToString();
                    Process.Start(url);
                }
            }
        }

        private void SetFormStatus(FormStatusTypes formStatus)
        {
            switch (formStatus)
            {
                case FormStatusTypes.Initialising:                    
                    IncludesSubFoldersCheckbox.Enabled = false;
                    TotalItemsPicker.Enabled = false;                                        
                    SetEnabled(false, FoldersTreeView);
                    SetEnabled(false, ShortlistOfUrlsGrid);
                    SetEnabled(false, GetRandomItemsButton, DisplayUrlsButton);
                    break;
                case FormStatusTypes.SelectingFolderOptions:
                    IncludesSubFoldersCheckbox.Enabled = true;
                    TotalItemsPicker.Enabled = true;
                    SetEnabled(true, FoldersTreeView);
                    SetEnabled(true, GetRandomItemsButton);
                    SetEnabled(false, ShortlistOfUrlsGrid);
                    SetEnabled(false, DisplayUrlsButton);
                    break;
                case FormStatusTypes.SelectingFromShortlist:                    
                    IncludesSubFoldersCheckbox.Enabled = true;
                    TotalItemsPicker.Enabled = true;
                    SetEnabled(true, FoldersTreeView);
                    SetEnabled(true, ShortlistOfUrlsGrid);
                    SetEnabled(true, GetRandomItemsButton, DisplayUrlsButton);
                    break;
            }
        }

        private void SetEnabled(bool enabled, params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                if (enabled)
                    button.BackColor = Color.Black;
                else
                    button.BackColor = Color.Silver;
                button.Enabled = enabled;
            }
        }

        private void SetEnabled(bool enabled, params TreeView[] treeViews)
        {
            foreach (TreeView treeView in treeViews)
            {
                if (enabled)
                    treeView.BackColor = Color.FromArgb(255, 255, 128);
                else
                    treeView.BackColor = Color.FromArgb(255, 255, 192);
                treeView.Enabled = enabled;
            }
        }

        private void SetEnabled(bool enabled, params DataGridView[] gridViews)
        {
            foreach (DataGridView gridView in gridViews)
            {
                if (enabled)
                {
                    gridView.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128);
                    gridView.BackgroundColor = Color.FromArgb(255, 255, 128);
                }
                else
                {
                    gridView.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
                    gridView.BackgroundColor = Color.FromArgb(255, 255, 192);
                }
                gridView.Enabled = enabled;
            }
        }
    }
}
