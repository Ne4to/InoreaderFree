namespace Inoreader.Domain.Models
{
	public class SubscriptionItem : SubscriptionItemBase
	{
		public string Url { get; set; }
		public string HtmlUrl { get; set; }
		public string IconUrl { get; set; }
		public long FirstItemMsec { get; set; }
	}
}