using System;
using System.Collections.Generic;
using System.Linq;

namespace Marcware.RandomBookmarkReader.BookmarkContainerClasses
{
    /// <summary>
    /// Class containing information about a bookmark folder
    /// </summary>
    internal class BookmarkFolder
    {
        #region Constructor
        public BookmarkFolder(string folderName)
        {
            FolderName = folderName;
            FolderId = Guid.NewGuid().ToString();
        } 
        #endregion

        #region Public properties
        /// <summary>
        /// Name of the bookmarks folder
        /// </summary>
        public string FolderName { get; private set; }

        /// <summary>
        /// Unique id of the folder
        /// </summary>
        public string FolderId { get; set; }

        /// <summary>
        /// Subfolders contained within this folder
        /// </summary>
        public List<BookmarkFolder> SubFolders { get; set; } = new List<BookmarkFolder>();

        /// <summary>
        /// Urls contained within this folder
        /// </summary>
        public List<BookmarkUrl> Urls { get; set; } = new List<BookmarkUrl>();
        #endregion

        #region Helper methods
        /// <summary>
        /// Returns a folder with the id specified
        /// </summary>
        /// <param name="folderId"></param>
        /// <returns>Folder with the id specified.  If no folder with the id is found, returns null.</returns>
        public BookmarkFolder FindBookmarkFolder(string folderId)
        {
            BookmarkFolder result = null;

            if (FolderId == folderId)
            {
                result = this;
            }
            else
            {
                foreach (BookmarkFolder subFolder in SubFolders.TakeWhile(f => result == null))
                {
                    result = subFolder.FindBookmarkFolder(folderId);
                }
            }

            return result;
        }

        /// <summary>
        /// Returns a collection of URLs from this folder
        /// </summary>
        /// <param name="includeSubfolders">Include URLs from all sub-folder?</param>
        /// <returns></returns>
        public List<BookmarkUrl> GetAllUrls(bool includeSubfolders)
        {
            List<BookmarkUrl> result = new List<BookmarkUrl>();
            CopyUrlsToCollection(this, result, includeSubfolders);            
            return result;
        }   
        
        private void CopyUrlsToCollection(BookmarkFolder folder, List<BookmarkUrl> bookmarkCollection, bool doCopyAllSubFolders)
        {
            bookmarkCollection.AddRange(folder.Urls);
            if (doCopyAllSubFolders)
            {
                foreach (BookmarkFolder subFolder in folder.SubFolders)
                {
                    CopyUrlsToCollection(subFolder, bookmarkCollection, doCopyAllSubFolders);
                }
            }
        }
        #endregion
    }
}
