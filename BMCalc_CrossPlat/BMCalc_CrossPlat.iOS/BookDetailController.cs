using Foundation;
using System;
using UIKit;

namespace BMCalc_CrossPlat.iOS
{
    public partial class BookDetailController : UIViewController
    {
        public Book SelectedBook = new Book();
        public BookDetailController (IntPtr handle) : base (handle)
        {

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            lblSelectedBookName.Text = SelectedBook.Name;
            imgBookImage.Image = UIImage.FromFile(SelectedBook.ImagePath);
        }
    }
}