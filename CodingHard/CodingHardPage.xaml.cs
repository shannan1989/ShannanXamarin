using Xamarin.Forms;

namespace CodingHard
{
	public partial class CodingHardPage : TabbedPage
	{
		int count = 0;
		public CodingHardPage()
		{
			InitializeComponent();
		}
		private void Button_Clicked(object sender, System.EventArgs e)
		{
			count++;
			(sender as Button).Text = string.Format("{0} click{1}!",count,count==1?"":"s");
		}
	}
}

