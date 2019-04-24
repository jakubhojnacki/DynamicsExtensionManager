using System;
using System.Globalization;
using System.Windows.Data;
using The365People.DynamicsExtensionManager.Core;

namespace The365People.DynamicsExtensionManager.Desktop
{
    public class ServiceImageConverter : IValueConverter
    {
        public object Convert(object pValue, Type pTargetType, object pParameter, CultureInfo culture)
        {
            string lResult = string.Empty;
            if (pValue is DynamicsServiceState)
            {
                DynamicsServiceState lDynamicsServiceState = (DynamicsServiceState)pValue;
                lResult = string.Format("/Resources/DynamicsServiceStates/{0}32.png", lDynamicsServiceState);
            }
            return lResult;
        }

        public object ConvertBack(object pValue, Type pTargetType, object pParameter, CultureInfo pCulture)
        {
            throw new NotImplementedException();
        }
    }
}
