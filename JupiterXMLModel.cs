using System.Xml.Serialization;

namespace JupiterBroadcastingAudio
{
	[XmlType(AnonymousType = true)]
	[XmlRoot(Namespace = "", IsNullable = false)]
	public partial class rss
	{
		public rssChannel channel { get; set; }

		[XmlAttribute()]
		public decimal version { get; set; }
	}

	
	[XmlType(AnonymousType = true)]
	public partial class rssChannel
	{
		
		public string title { get; set; }
			
		public string link { get; set; }

		public string description { get; set; }
		
		public string generator { get; set; }

		public string docs { get; set; }

		public string language { get; set; }

		public string pubDate { get; set; }

		public string lastBuildDate { get; set; }

		public rssChannelImage image { get; set; }

		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string author { get; set; }

		[XmlElement("image", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public image image1 { get; set; }

		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string @explicit { get; set; }

		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string block { get; set; }

		[XmlElement("link", Namespace = "http://www.w3.org/2005/Atom")]
		public link1 feedLink { get; set; }

		[XmlElement(Namespace = "http://rssnamespace.org/feedburner/ext/1.0")]
		public info info { get; set; }

		[XmlElement(Namespace = "http://www.w3.org/2005/Atom")]
		public link2 advertisementLink { get; set; }

		[XmlElement(Namespace = "http://search.yahoo.com/mrss/")]
		public string copyright { get; set; }

		[XmlElement(Namespace = "http://search.yahoo.com/mrss/")]
		public urlAttribute thumbnail { get; set; }

		[XmlElement("keywords", Namespace = "http://search.yahoo.com/mrss/")]
		public string keywords1 { get; set; }

		[XmlElement("category", Namespace = "http://search.yahoo.com/mrss/")]
		public string[] mediaCategory { get; set; }

		[XmlElement("owner", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public owner itunesOwner { get; set; }

		[XmlElement("keywords", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string keywords2 { get; set; }

		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string subtitle { get; set; }

		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string summary { get; set; }

		[XmlElement("category", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public category[] category1 { get; set; }

		[XmlElement("item")]
		public rssChannelItem[] item { get; set; }

		[XmlElement("copyright", Namespace = "http://www.w3.org/2005/Atom")] 
		public string copyright2 { get; set; }

		[XmlElement("author", Namespace = "http://search.yahoo.com/mrss/")]
		public credit author2 { get; set; }

		[XmlElement(Namespace = "http://search.yahoo.com/mrss/")]
		public string rating { get; set; }

		[XmlElement("description", Namespace = "http://search.yahoo.com/mrss/")]
		public mediaDescription descript { get; set; }
	}

	
	[XmlType(AnonymousType = true)]
	public partial class rssChannelImage
	{
		public string link { get; set; }

		public string url { get; set; }

		public string title { get; set; }
	}
		
	[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
	[XmlRoot(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
	public partial class link1
	{
		[XmlAttribute("atom10")]
		public string atom10 { get; set; }

		[XmlAttribute()]
		public string rel { get; set; }

		[XmlAttribute()]
		public string type { get; set; }

		[XmlAttribute()]
		public string href { get; set; }
	}

	[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
	[XmlRoot(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
	public partial class link2
	{
		[XmlAttribute("atom10")]
		public string atom10 { get; set; }

		[XmlAttribute()]
		public string rel { get; set; }

		[XmlAttribute()]
		public string href { get; set; }
	}

	[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
	[XmlRoot(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
	public partial class info
	{
		[XmlAttribute()]
		public string uri { get; set; }
	}

	[XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
	[XmlRoot(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
	public partial class urlAttribute
	{
		[XmlAttribute()]
		public string url { get; set; }
	}

	public partial class category
	{
		[XmlAttribute()]
		public string scheme { get; set; }
	}

	[XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
	[XmlRoot(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
	public partial class owner
	{
		public string name { get; set; }

		public string email { get; set; }
	}

	
	[XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
	[XmlRoot(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
	public partial class image
	{
		
		[XmlAttribute()]
		public string href { get; set; }
	}

	
	[XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
	[XmlRoot(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
	public partial class category
	{
		
		[XmlElement("category")]
		public categoryCategory category1 { get; set; }
		
		[XmlAttribute()]
		public string text { get; set; }
	}

	
	[XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
	public partial class categoryCategory
	{
		
		[XmlAttribute()]
		public string text { get; set; }
	}

	
	[XmlType(AnonymousType = true)]
	public partial class rssChannelItem
	{
		
		public string title { get; set; }

		public string link { get; set; }

		public string description { get; set; }

		public string pubDate { get; set; }

		public rssChannelItemEnclosure enclosure { get; set; }

		public rssChannelItemGuid guid { get; set; }

		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string author { get; set; }

		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string subtitle { get; set; }

		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string summary { get; set; }
		
		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string @explicit { get; set; }

		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string duration { get; set; }

		[XmlElement(Namespace = "http://search.yahoo.com/mrss/")]
		public urlAttribute thumbnail { get; set; }

		[XmlElement("author")]
		public string author2 { get; set; }

		[XmlElement(Namespace = "http://search.yahoo.com/mrss/")]
		public content content { get; set; }

		[XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
		public string keywords { get; set;}

		[XmlElement(Namespace = "http://rssnamespace.org/feedburner/ext/1.0")]
		public string origLink { get; set; }
	}
		
	[XmlType(AnonymousType = true)]
	public partial class rssChannelItemGuid
	{
		[XmlAttribute()]
		public bool isPermaLink { get; set; }
	}
	
	[XmlType(AnonymousType = true)]
	public partial class rssChannelItemEnclosure
	{
		[XmlAttribute()]
		public string url { get; set; }
		
		[XmlAttribute()]
		public long length { get; set; }
		
		[XmlAttribute()]
		public string type { get; set; }
	}

	
	[XmlType(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
	[XmlRoot(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false)]
	public partial class content
	{		
		[XmlAttribute()]
		public string url { get; set; }

		[XmlAttribute()]
		public string fileSize { get; set; }

		[XmlAttribute()]
		public string type { get; set; }
	}

	[XmlType(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
	[XmlRoot(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false)]
	public partial class credit
	{
		[XmlAttribute()]
		public string role { get; set; }
	}

	[XmlType(AnonymousType = true, Namespace = "http://search.yahoo.com/mrss/")]
	[XmlRoot(Namespace = "http://search.yahoo.com/mrss/", IsNullable = false)]
	public partial class mediaDescription
	{
		[XmlAttribute()]
		public string type { get; set; }
	}
}