using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private BookmarkManagerClass BookmarkManager { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshFoldersButton_Click(object sender, EventArgs e)
        {
            BookmarkManager = new BookmarkManagerClass();
            ProcessResult<Dictionary<string, BrowserBookmarks>> readerResult = BookmarkManager.GetBookmarksFromAllBrowsers();
            if (readerResult.Success)
            {
                foreach (BrowserBookmarks browser in readerResult.Result.Values)
                {
                    TreeNode browserNode = FoldersTreeView.Nodes.Add(browser.RootFolder.FolderId, browser.BrowserName);
                    AddChildFoldersToBookmarksTreeView(browser, browser.RootFolder, browserNode);
                }
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
    }
}
