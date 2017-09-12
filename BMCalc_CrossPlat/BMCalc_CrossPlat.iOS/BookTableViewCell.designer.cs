// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BMCalc_CrossPlat.iOS
{
    [Register ("BookTableViewCell")]
    partial class BookTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblBookAuthor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblBookName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblBookYear { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblBookAuthor != null) {
                lblBookAuthor.Dispose ();
                lblBookAuthor = null;
            }

            if (lblBookName != null) {
                lblBookName.Dispose ();
                lblBookName = null;
            }

            if (lblBookYear != null) {
                lblBookYear.Dispose ();
                lblBookYear = null;
            }
        }
    }
}