using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace BMCalc_CrossPlat.iOS
{
    public partial class BooksTableviewController : UITableViewController
    {
        List<Book> bookList;
        public BooksTableviewController (IntPtr handle) : base (handle)
        {
            bookList = new List<Book>();
            bookList.Add(new Book()
            {
                Author = "Priyansh Shah",
                Name = "My Life & My Journey",
                Year = 1995,
                ImagePath = "Images/CTop.jpg"
            });
            bookList.Add(new Book()
            {
                Author = "Mansi Shah",
                Name = "Guelph Journey begins",
                Year = 2000,
                ImagePath="Images/Green.jpg"
            });
            bookList.Add(new Book()
            {
                Author = "Nancy Shah",
                Name = "Toronto Journey begins",
                Year = 2002,
                ImagePath="Images/Range.gif"
            });
            bookList.Add(new Book()
            {
                Author = "Rahul Shah",
                Name = "My story My Life",
                Year = 2009,
                ImagePath="Images/Sink.gif"
            });

        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return bookList.Count;
        }
        
        //Used for reusing cell
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Book") as BookTableViewCell;
            var data = bookList[indexPath.Row];
            cell.BookData = data;
            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            if(segue.Identifier == "DetailsSegue")
            {
                var navigationController = segue.DestinationViewController as BookDetailController;
                if(navigationController != null)
                {
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var selectedData = bookList[rowPath.Row];
                    navigationController.SelectedBook = selectedData;
                }
            }
        }
    }
    public class Book
    {
        public string Name;
        public string Author;
        public int Year;
        public string ImagePath;
    }
}