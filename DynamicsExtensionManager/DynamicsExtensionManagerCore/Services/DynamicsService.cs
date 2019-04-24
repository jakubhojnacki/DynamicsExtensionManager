using System;

namespace The365People.DynamicsExtensionManager.Core
{
    public class DynamicsService
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public DynamicsServiceState State { get; set; }
        public string Account { get; set; }
        public Version Version { get; set; }
        public bool Default { get; set; }

        public DynamicsService()
        {
            this.Name = string.Empty;
            this.FullName = string.Empty;
            this.Description = string.Empty;
            this.State = DynamicsServiceState.Empty;
            this.Account = string.Empty;
            this.Version = new Version();
            this.Default = false;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
