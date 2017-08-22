namespace MRULibTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class CoreTests
    {
        /// <summary>
        /// Do a core test on creating the collection of MRU file references
        /// and finding a particular reference.
        /// 
        /// Expectation: File references should be found.
        /// </summary>
        [TestMethod]
        public void FindEntryBaseTest()
        {
            var testColl = GenerateTestData.CreateTestData();

            var entry = testColl.FindEntry(testColl.Entries[0].Key);
            Assert.AreNotEqual(entry, null);

            entry = null;
            entry = testColl.FindEntry(testColl.Entries[testColl.Entries.Count-1].Key);
            Assert.AreNotEqual(entry, null);
        }

        /// <summary>
        /// Do a core test on creating the collection of MRU file references
        /// and updating a particular reference.
        /// 
        /// Expectation: LastUpdate should be up-to-date.
        /// </summary>
        [TestMethod]
        public void UpdateEntryBaseTest()
        {
            var testColl = GenerateTestData.CreateTestData();

            var entry = testColl.FindEntry(testColl.Entries[testColl.Entries.Count - 1].Key);

            var lastupdate = entry.LastUpdate;

            // LastUpdate should be changed here - method returns true
            Assert.AreEqual(testColl.UpdateEntry(entry.PathFileName), true);

            // LastUpdate change can be verified via the property of entry
            Assert.AreEqual((entry.LastUpdate > lastupdate), true);
        }

        /// <summary>
        /// Find all pinned entries and unpin them.
        /// </summary>
        [TestMethod]
        public void FindPinnedEntryBaseTest()
        {
            var testColl = GenerateTestData.CreateTestData();

            var entries = testColl.FindEntries(MRULib.MRU.Enums.GroupType.IsPinned);

            int iCount = 0;
            foreach (var item in entries)
            {
              testColl.PinUnpinEntry(false, item.Key);   // Unpin all entries found
              iCount++;
            }

            // There should have been pinned entries in the standard test set
            Assert.AreEqual((iCount > 0), true);

            entries = testColl.FindEntries(MRULib.MRU.Enums.GroupType.IsPinned);

            iCount=0;
            foreach (var item in entries)
                iCount++;

            // There should be any pinned entries left since we unpinned them all
            Assert.AreEqual((iCount == 0), true);
        }

        /// <summary>
        /// Tests if all netries pinned or unpinned are removed as expected.
        /// </summary>
        [TestMethod]
        public void RemoveAllButPinnedEntriesBaseTest()
        {
            var testColl = GenerateTestData.CreateTestData();

            // method returns true on removal of unpinned entries
            Assert.AreEqual(testColl.RemovePinnedEntries(false), true);

            var entries = testColl.FindEntries(MRULib.MRU.Enums.GroupType.IsPinned);

            int iCount = 0;
            foreach (var item in entries)
                iCount++;

            // There should only be pinned entries left since we removed all unpinned entries
            Assert.AreEqual((iCount == testColl.Entries.Count), true);
        }

        /// <summary>
        /// Sets the maximum number of allowed entries below the number of pinned entries.
        /// 
        /// Expectation: The number of allowed entries is shortend by removing
        /// the last recent entries.
        /// </summary>
        [TestMethod]
        public void ResetMaxCountBaseTest()
        {
            var testColl = GenerateTestData.CreateTestData();

            List<string> keys = new List<string>();

            var todaysEntries = testColl.FindEntries(MRULib.MRU.Enums.GroupType.IsPinned);
            foreach (var item in todaysEntries)
                keys.Add(item.Key);

            todaysEntries = testColl.FindEntries(MRULib.MRU.Enums.GroupType.Today);
            foreach (var item in todaysEntries)
                keys.Add(item.Key);

            todaysEntries = testColl.FindEntries(MRULib.MRU.Enums.GroupType.Yesterday);
            foreach (var item in todaysEntries)
                keys.Add(item.Key);

            todaysEntries = testColl.FindEntries(MRULib.MRU.Enums.GroupType.ThisWeek);
            foreach (var item in todaysEntries)
                keys.Add(item.Key);

            int iCount = 0;
            foreach (var item in keys)
            {
                testColl.PinUnpinEntry(true, testColl.FindEntry(item)); // Pin these entries
                testColl.UpdateEntry(item);                            // and update them for today
                iCount++;
            }

            Assert.AreEqual(iCount == 14, true);

            iCount = 0;
            todaysEntries = testColl.FindEntries(MRULib.MRU.Enums.GroupType.Today);
            foreach (var item in todaysEntries)
                iCount++;

            Assert.AreEqual(iCount == 0, true);

            iCount = 0;
            todaysEntries = testColl.FindEntries(MRULib.MRU.Enums.GroupType.IsPinned);
            foreach (var item in todaysEntries)
                iCount++;

            Assert.AreEqual(iCount == 14, true);

            //
            // Here we reset items, and therfore, shorten the list of MRU entries
            //
            int newMaxCount = 8;
            testColl.ResetMaxMruEntryCount(newMaxCount);

            // only 10 of the newest entries is left in the collection
            Assert.AreEqual(testColl.Entries.Count == newMaxCount, true);

            iCount = 0;
            foreach (var item in testColl.FindEntries(MRULib.MRU.Enums.GroupType.Today))
                iCount++;

            Assert.AreEqual(iCount == 0, true);
        }

        [TestMethod]
        public void ResetMaxCountBaseTest_1()
        {
            var testColl = GenerateTestData.CreateTestData();

            List<string> keys = new List<string>();

            // count pinnned entries
            int iCountIsPinned1 = testColl.FindEntries(MRULib.MRU.Enums.GroupType.IsPinned).ToList().Count;

            int newMaxCount = 8;

            // For this test important: There should be more items to limit to
            // than there pinned items
            Assert.AreEqual(newMaxCount > iCountIsPinned1, true);

            //
            // Here we reset items, and therfore, shorten the list of MRU entries
            //
            testColl.ResetMaxMruEntryCount(newMaxCount);

            int iCountIsPinned2 = testColl.FindEntries(MRULib.MRU.Enums.GroupType.IsPinned).ToList().Count;

            // Number of pinned entries should not change
            Assert.AreEqual(iCountIsPinned1 == iCountIsPinned2, true);

            // The maximum number should be the requested one
            Assert.AreEqual(newMaxCount == testColl.Entries.Count, true);
        }
    }
}
