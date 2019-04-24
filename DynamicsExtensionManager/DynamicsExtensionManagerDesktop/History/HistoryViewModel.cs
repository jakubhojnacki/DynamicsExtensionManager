using The365People.DynamicsExtensionManager.Core;

namespace The365People.DynamicsExtensionManager.Desktop
{
	public class HistoryViewModel
	{
		private HistoryModel Model { get; set; }

		public HistoryEntryCollection Entries { get { return this.Model.Entries; } }

		public HistoryViewModel()
		{
			this.Model = new HistoryModel();
		}

        public HistoryViewModel(HistoryModel pModel)
        {
            this.Model = pModel;
        }
    }
}
