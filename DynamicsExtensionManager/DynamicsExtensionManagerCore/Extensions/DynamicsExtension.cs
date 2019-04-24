using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The365People.DynamicsExtensionManager.Core
{
    public class DynamicsExtension
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brief { get; set; }
        public string Description { get; set; }
        public Version Version { get; set; }
        public Version DataVersion { get; set; }
        public string Publisher { get; set; }
        public DynamicsExtensionScope Scope { get; set; }
        public bool IsPublished { get; set; }
        public bool IsSynchronised { get; set; }
        public bool IsUpgraded { get; set; }
        public bool IsInstalled { get; set; }
        public bool FileExists { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public List<DynamicsExtension> Dependencies { get; private set; }

        public DynamicsExtension()
        {
            this.Id = Guid.Empty;
            this.Name = string.Empty;
            this.Brief = string.Empty;
            this.Description = string.Empty;
            this.Version = new Version();
            this.DataVersion = new Version();
            this.Publisher = string.Empty;
            this.Scope = DynamicsExtensionScope.Empty;
            this.IsPublished = false;
            this.IsSynchronised = false;
            this.IsUpgraded = false;
            this.IsInstalled = false;
            this.FileExists = false;
            this.FilePath = string.Empty;
            this.FileName = string.Empty;
            this.Dependencies = new List<DynamicsExtension>();
        }
    }
}
