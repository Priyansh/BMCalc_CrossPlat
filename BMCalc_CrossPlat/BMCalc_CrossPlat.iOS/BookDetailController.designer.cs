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
    [Register ("BookDetailController")]
    partial class BookDetailController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnContacts { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgBookImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSelectedBookName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnContacts != null) {
                btnContacts.Dispose ();
                btnContacts = null;
            }

            if (imgBookImage != null) {
                imgBookImage.Dispose ();
                imgBookImage = null;
            }

            if (lblSelectedBookName != null) {
                lblSelectedBookName.Dispose ();
                lblSelectedBookName = null;
            }
        }
    }
}