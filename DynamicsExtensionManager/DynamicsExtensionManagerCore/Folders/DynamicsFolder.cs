namespace The365People.DynamicsExtensionManager.Core
{
    public class DynamicsFolder
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public DynamicsFolder()
        {
            this.Name = string.Empty;
            this.Path = string.Empty;
        }

        public DynamicsFolder(string pPath) : this()
        {
            this.Path = pPath;
            this.Name = System.IO.Path.GetDirectoryName(this.Path);
        }

        public override string ToString()
        {
            return this.Path;
        }
    }
}
