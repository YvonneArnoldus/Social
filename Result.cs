using System;

namespace Social
{
	public class Result
	{
		public string Id { get; set; }

		public SocialKind SocialKind { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string Url { get; set; }

		public string Author { get; set; }

		public string AuthorUrl { get; set; }

		public string ThumbnailUrl { get; set; }

		public DateTime PublishedOn { get; set; }
	}
}
