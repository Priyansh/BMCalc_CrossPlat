using Foundation;
using System;
using UIKit;

namespace BMCalc_CrossPlat.iOS
{
    public partial class DetailViewController : UIViewController
    {
        public float bmi = 21.5f;
        public DetailViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            EvaluateBMI();
        }

        public void EvaluateBMI()
        {
            string result = string.Empty;
            if (bmi <= 16)
                result = "Very Low";
            else if (bmi < 18.5)
                result = "Low";
            else if (bmi < 25)
                result = "Normal";
            else if (bmi < 30)
                result = "High";
            else
                result = "Too High";

            lblResult.Text = result;
        }
    }
}