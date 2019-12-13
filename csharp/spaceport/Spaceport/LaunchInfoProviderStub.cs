using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    class LaunchInfoProviderStub : ISpacelineLaunchInfoProvider
    {
        public List<LaunchInfo> launchInfoList = new List<LaunchInfo>();

        public List<LaunchInfo> GetCurrentLaunches()
        {
            return launchInfoList;
        }

        public IDisposable Subscribe(IObserver<LaunchInfo> observer)
        {
            return null;
        }

    }
}
