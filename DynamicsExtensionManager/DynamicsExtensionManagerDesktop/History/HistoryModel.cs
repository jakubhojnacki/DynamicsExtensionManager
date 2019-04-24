using The365People.DynamicsExtensionManager.Core;

namespace The365People.DynamicsExtensionManager.Desktop
{
	public class HistoryModel
	{
		public HistoryEntryCollection Entries { get; set; }

		public HistoryModel()
		{
			this.Entries = HistoryFactory.MakeHistory();
		}
	}
}
