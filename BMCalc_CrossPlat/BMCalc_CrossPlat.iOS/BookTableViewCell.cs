using Foundation;
using System;
using UIKit;

namespace BMCalc_CrossPlat.iOS
{
    public partial class BookTableViewCell : UITableViewCell
    {
        private Book bookData;
        public Book BookData
        {
            get { return bookData; }
            set {
                bookData = value;
                lblBookAuthor.Text = bookData.Author;
                lblBookName.Text = bookData.Name;
                lblBookYear.Text = bookData.Year.ToString();
            }
        }
        public BookTableViewCell (IntPtr handle) : base (handle)
        {

        }
    }
}