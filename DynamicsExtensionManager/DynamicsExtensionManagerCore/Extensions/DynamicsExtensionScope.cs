using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The365People.DynamicsExtensionManager.Core
{
    public enum DynamicsExtensionScope : int
    {
        Empty = 0,
        Global = 1,
        Tenant = 2
    }

    public static class DynamicsExtensionScopeToolkit
    {
        public static DynamicsExtensionScope Parse(string pText)
        {
            pText = string.IsNullOrEmpty(pText) ? string.Empty : pText.Trim().ToLower();
            DynamicsExtensionScope lValue = DynamicsExtensionScope.Empty;
            switch (pText)
            {
                case "global":
                    lValue = DynamicsExtensionScope.Global;
                    break;
                case "tenant":
                    lValue = DynamicsExtensionScope.Tenant;
                    break;
            }
            return lValue;
        }
    }
}
