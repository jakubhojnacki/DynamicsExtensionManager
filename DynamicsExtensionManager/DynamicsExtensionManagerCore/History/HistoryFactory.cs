using System;

namespace The365People.DynamicsExtensionManager.Core
{
	public static class HistoryFactory
	{
		public static HistoryEntryCollection MakeHistory()
		{
			HistoryEntryCollection lCollection = new HistoryEntryCollection();
			lCollection.Add("13.0.1.0", new DateTime(2019, 04, 24), "First version based on PowerShell script concept");
			return lCollection;
		}
	}
}
