using System;

namespace The365People.DynamicsExtensionManager.Core
{
	public class HistoryEntry
	{
		public string Version { get; set; }
		public DateTime Date { get; set; }
		public string Description { get; set; }

		public HistoryEntry()
		{
			this.Version = string.Empty;
			this.Date = DateTime.MinValue;
			this.Description = string.Empty;
		}

		public HistoryEntry(string pVersion, DateTime pDate, string pDescription) : this()
		{
			this.Version = pVersion;
			this.Date = pDate;
			this.Description = pDescription;
		}
	}
}
