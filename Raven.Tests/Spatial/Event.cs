//-----------------------------------------------------------------------
// <copyright file="Event.cs" company="Hibernating Rhinos LTD">
//     Copyright (c) Hibernating Rhinos LTD. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace Raven.Tests.Spatial
{
	public class Event
	{
		public Event() { }

		public Event(string venue, double lat, double lng)
		{
			this.Venue = venue;
			this.Latitude = lat;
			this.Longitude = lng;
		}

		public Event(string venue, double lat, double lng, DateTimeOffset date)
		{
			this.Venue = venue;
			this.Latitude = lat;
			this.Longitude = lng;
			Date = date;
		}

		public string Venue { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public DateTimeOffset Date { get; set; }
	}
}