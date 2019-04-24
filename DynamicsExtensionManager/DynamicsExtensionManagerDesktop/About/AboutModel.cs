using The365People.SystemLibrary;

namespace The365People.DynamicsExtensionManager.Desktop
{
	public class AboutModel
	{
		public string Title { get; private set; }
		public string Description { get; private set; }
		public string Version { get; private set; }
		public string Copyright { get; private set; }
        public string WebSite { get; set; }
        public string Author { get; set; }

        public AboutModel()
		{
            this.Title = AssemblyProperties.Title;
			this.Description = AssemblyProperties.Description;
			this.Version = AssemblyProperties.Version;
			this.Copyright = AssemblyProperties.Copyright;
            this.WebSite = "http://www.the365people.com";
            this.Author = "Jakub Hojnacki";
		}
	}
}
