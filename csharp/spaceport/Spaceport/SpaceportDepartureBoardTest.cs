using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class SpaceportDepartureBoardTest
    {
        
        //TODO - Use the Stub Recipe to test that launches are sorted correctly
        [Test]
        public void LaunchListCreatesWithSingleLaunch()
        {
            // 1. Create LaunchInfoProviderStub (that implements ISpacelineLaunchInfoProvider)

            // 2/3. Create SUT - SpaceportDepartureBoard, using Constructor Injection

            // 4. Exercise the SUT

            // 5. Verify the results are sorted correctly
            ISpacelineLaunchInfoProvider fakeProvider = new LaunchInfoProviderStub();
            SpaceportDepartureBoard board = new SpaceportDepartureBoard(fakeProvider);
            LaunchInfo newInfo = new LaunchInfo();
            newInfo.Destination = "Mars";
            board.OnNext(newInfo);

            Assert.IsNotEmpty(board.LaunchList);
            Assert.AreEqual(1, board.LaunchList.Count);
            Assert.AreEqual("Mars", board.LaunchList[0].Destination);
        }

        [Test]
        public void LaunchListSortsTwoLaunches()
        {
            // 1. Create LaunchInfoProviderStub (that implements ISpacelineLaunchInfoProvider)

            // 2/3. Create SUT - SpaceportDepartureBoard, using Constructor Injection

            // 4. Exercise the SUT

            // 5. Verify the results are sorted correctly
            LaunchInfoProviderStub fakeProvider = new LaunchInfoProviderStub();

            LaunchInfo newInfo = new LaunchInfo();
            newInfo.Destination = "Saturn";
            fakeProvider.launchInfoList.Add(newInfo);

            newInfo = new LaunchInfo();
            newInfo.Destination = "Neptune";
            fakeProvider.launchInfoList.Add(newInfo);

            SpaceportDepartureBoard board = new SpaceportDepartureBoard(fakeProvider);


            Assert.IsNotEmpty(board.LaunchList);
            Assert.AreEqual(2, board.LaunchList.Count);
            Assert.AreEqual("Neptune", board.LaunchList[0].Destination);
            Assert.AreEqual("Saturn", board.LaunchList[1].Destination);
        }

    }
}