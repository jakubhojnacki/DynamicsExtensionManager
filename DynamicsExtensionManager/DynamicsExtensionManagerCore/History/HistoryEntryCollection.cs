using System;
using System.Collections.ObjectModel;

namespace The365People.DynamicsExtensionManager.Core
{
	public class HistoryEntryCollection : ObservableCollection<HistoryEntry>
	{
		public void Add(string pVersion, DateTime pDate, string pDescription)
		{
			this.Add(new HistoryEntry(pVersion, pDate, pDescription));
		}
	}
}
