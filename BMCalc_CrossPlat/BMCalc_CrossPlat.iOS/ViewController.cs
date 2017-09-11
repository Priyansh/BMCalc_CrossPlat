using System;
using Foundation;
using UIKit;

namespace BMCalc_CrossPlat.iOS
{
	public partial class ViewController : UIViewController
	{
        float bmi = 21.5f;
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

            // Perform any additional setup after loading the view, typically from a nib.
            //btnHello.AccessibilityIdentifier = "myButton";
            //btnHello.TouchUpInside += delegate {
            //	var title = string.Format ("{0} clicks!", count++);
            //	btnHello.SetTitle (title, UIControlState.Normal);
            //};

            //btnShowDetails click event
            btnCalculateBMI.TouchUpInside += BtnCalculateBMI_TouchUpInside;
        }

        private void BtnCalculateBMI_TouchUpInside(object sender, EventArgs e)
        {
            if(txtHeight.Text.Length > 0 && txtWeight.Text.Length > 0)
            {
                float height = float.Parse(txtHeight.Text);
                float weight = float.Parse(txtWeight.Text);
                bmi = weight / (height * height);
                lblBMI.Text = bmi.ToString();
            }
        }

        public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);
            this.View.EndEditing(true);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            var detailViewController = segue.DestinationViewController as DetailViewController;
            detailViewController.bmi = this.bmi;
        }
    }
}

