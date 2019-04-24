namespace The365People.DynamicsExtensionManager.Core
{
    public enum DynamicsServiceState : int
    {
        Empty = 0,
        Stopped = 1,
        Running = 2,
        Paused = 3,
        StartPending = 4,
        StopPending = 5,
        ContinuePending = 6
    }

    public static class DynamicsServiceStateToolkit
    {
        public static DynamicsServiceState Parse(string pText)
        {
            pText = string.IsNullOrEmpty(pText) ? string.Empty : pText.Trim().ToLower();
            DynamicsServiceState lValue = DynamicsServiceState.Empty;
            switch (pText)
            {
                case "stopped":
                    lValue = DynamicsServiceState.Stopped;
                    break;
                case "running":
                    lValue = DynamicsServiceState.Running;
                    break;
                case "paused":
                    lValue = DynamicsServiceState.Paused;
                    break;
                case "startpending":
                    lValue = DynamicsServiceState.StartPending;
                    break;
                case "stoppending":
                    lValue = DynamicsServiceState.StopPending;
                    break;
                case "continuepending":
                    lValue = DynamicsServiceState.ContinuePending;
                    break;
            }
            return lValue;
        }
    }
}
