using System;

using UIKit;

namespace BMCalc_CrossPlat.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

            btnCalculateBMI.TouchUpInside += BtnCalculateBMI_TouchUpInside;

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate {
				var title = string.Format ("{0} clicks!", count++);
				Button.SetTitle (title, UIControlState.Normal);
			};
		}

        private void BtnCalculateBMI_TouchUpInside(object sender, EventArgs e)
        {
            float height = float.Parse(txtHeight.Text);
            float weight = float.Parse(txtWeight.Text);
            float bmiResult = weight / (height * height);

            lblBMI.Text = bmiResult.ToString();
        }

        public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

