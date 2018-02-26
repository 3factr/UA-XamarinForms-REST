﻿using Newtonsoft.Json;

namespace FindMyBeer.Models
{
	public class Labels
	{
		[JsonProperty("icon")]
		public string Icon { get; set; }

		[JsonProperty("medium")]
		public string Medium { get; set; }

		[JsonProperty("large")]
		public string Large { get; set; }
	}
}