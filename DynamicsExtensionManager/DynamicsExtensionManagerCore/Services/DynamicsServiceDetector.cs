using Microsoft.Dynamics.Nav.Management;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using The365People.SerialisationLibrary;

namespace The365People.DynamicsExtensionManager.Core
{
    public static class DynamicsServiceDetector
    {
        public class ServerInstance
        {
            [XmlAttribute("ServerInstance")]
            public string TheServerInstance { get; set; }
            [XmlAttribute]
            public string DisplayName { get; set; }
            [XmlAttribute]
            public string State { get; set; }
            [XmlAttribute]
            public string ServiceAccount { get; set; }
            [XmlAttribute]
            public string Version { get; set; }
            [XmlAttribute]
            public string Default { get; set; }

            public ServerInstance()
            {
                this.TheServerInstance = string.Empty;
                this.DisplayName = string.Empty;
                this.State = string.Empty;
                this.ServiceAccount = string.Empty;
                this.Version = string.Empty;
                this.Default = string.Empty;
            }

            public DynamicsService ToDynamicsService()
            {
                DynamicsService lDynamicsService = new DynamicsService() 
                { 
                    FullName = this.TheServerInstance, 
                    Description = this.DisplayName,
                    State = DynamicsServiceStateToolkit.Parse(this.State),
                    Account = this.ServiceAccount,
                    Version = System.Version.Parse(this.Version),
                    Default = Boolean.Parse(this.Default)
                };
                return lDynamicsService;
            }
        }

        [XmlType("Instances")]
        public class ServerInstances : List<ServerInstance>
        {
        }

        public static DynamicsService[] GetServices()
        {
            List<DynamicsService> lServices = new List<DynamicsService>();
            string lServerInstancesText = ServerInstanceHelper.GetServerInstances(string.Empty).CreateNavigator().OuterXml;
            ServerInstances lServerInstances = XmlSerialiser<ServerInstances>.Deserialise(lServerInstancesText, Encoding.Default);
            foreach (ServerInstance lServerInstance in lServerInstances)
            {
                DynamicsService lService = lServerInstance.ToDynamicsService();
                lService.Name = ServerInstanceHelper.GetShortInstanceName(lService.FullName);
                lServices.Add(lService);
            }
            return lServices.ToArray();
        }
    }
}
