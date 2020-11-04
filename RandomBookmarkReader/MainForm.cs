using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshFoldersButton_Click(object sender, EventArgs e)
        {
            BookmarkManager.BookmarkManager manager = new BookmarkManager.BookmarkManager();
            ProcessResult<Dictionary<string, BrowserBookmarks>> readerResult = manager.GetBookmarksFromAllBrowsers();
            if (readerResult.Success)
            {
                foreach (BrowserBookmarks browser in readerResult.Result.Values)
                {
                    TreeNode browserNode = FoldersTreeView.Nodes.Add(browser.BrowserName);
                    AddChildFoldersToBookmarksTreeView(browser.RootFolder, browserNode);
                }
            }
            else
            {
                MessageBox.Show(readerResult.ErrorMessage);
            }
        }

        private void AddChildFoldersToBookmarksTreeView(BookmarkFolder parentFolder, TreeNode parentNode)
        {
            foreach (BookmarkFolder childFolder in parentFolder.SubFolders)
            {
                TreeNode childNode = parentNode.Nodes.Add(childFolder.FolderName);
                AddChildFoldersToBookmarksTreeView(childFolder, childNode);
            }
        }
    }
}
