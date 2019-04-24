namespace The365People.DynamicsExtensionManager.Desktop
{
	public class AboutViewModel
	{
		private AboutModel Model { get; set; }

		public string Title { get { return this.Model.Title; } }
		public string Description { get { return this.Model.Description; } }
		public string Version { get { return this.Model.Version; } }
		public string Copyright { get { return this.Model.Copyright; } }
        public string WebSite { get { return this.Model.WebSite; } }
        public string Author { get { return this.Model.Author; } }

        public AboutViewModel(AboutModel pModel)
		{
			this.Model = pModel;
		}
	}
}
