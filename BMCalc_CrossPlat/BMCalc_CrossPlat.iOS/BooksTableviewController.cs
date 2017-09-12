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
                Year = 1995
            });
            bookList.Add(new Book()
            {
                Author = "Mansi Shah",
                Name = "Guelph Journey begins",
                Year = 2000
            });
            bookList.Add(new Book()
            {
                Author = "Nancy Shah",
                Name = "Toronto Journey begins",
                Year = 2002
            });
            bookList.Add(new Book()
            {
                Author = "Rahul Shah",
                Name = "My story My Life",
                Year = 2009
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
            var cell = tableView.DequeueReusableCell("Book");
            var data = bookList[indexPath.Row];
            cell.TextLabel.Text = data.Name;
            return cell;
        }
    }
    public class Book
    {
        public string Name;
        public string Author;
        public int Year;
    }
}