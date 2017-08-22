namespace MRULibTest
{
    using MRULib;
    using MRULib.MRU.Interfaces;
    using System;

    /// <summary>
    /// Implements a simple test generating procedure that simulates adding
    /// multiple MRU entries over time.
    /// </summary>
    internal static class GenerateTestData
    {
        internal static IMRUListViewModel CreateTestData()
        {
            var retList = MRU_Service.Create_List();

            var now = DateTime.Now;

            retList.UpdateEntry(MRU_Service.Create_Entry(@"C:tmp\t0_now.txt", false));

            // This should be shown yesterday if update and grouping work correctly
            retList.UpdateEntry(MRU_Service.Create_Entry(@"C:tmp\t15_yesterday.txt", now.Add(new TimeSpan(-20, 0, 0, 0)), false));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:\tmp\t15_yesterday.txt", now.Add(new TimeSpan(-1, 0, 0, 0)), false));

            retList.UpdateEntry(MRU_Service.Create_Entry(@"f:tmp\t1_today.txt", now.Add(new TimeSpan(-1, 0, 0, 0)), true));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"f:tmp\Readme.txt", now.Add(new TimeSpan(-1, 0, 0, 0)), true));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\t2_today.txt", now.Add(new TimeSpan(0, -1, 0, 0)), false));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\t3_today.txt", now.Add(new TimeSpan(0, -10, 0, 0)), false));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\t4_today.txt", now.Add(new TimeSpan(0, 0, -1, 0)), false));

            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\t5_today.txt", now.Add(new TimeSpan(0, -20, 0, 0)), false));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\t5_today.txt", now.Add(new TimeSpan(0, -20, 0, 0)), false));

            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\t6_today.txt", now.Add(new TimeSpan(0, -44, 0, 0)), false));

            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\directory1\directory2\directory3\t7_today.txt", now.Add(new TimeSpan(-30, 0, 0, 0)), true));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\directory1\directory2\directory3\t8_today.txt", now.Add(new TimeSpan(-25, 0, 0, 0)), false));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\directory1\directory2\directory3\t9_today.txt", now.Add(new TimeSpan(-20, 0, 0, 0)), false));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\directory1\directory2\directory3\t10_today.txt", now.Add(new TimeSpan(-10, 0, 0, 0)), false));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\directory1\directory2\directory3\t11_today.txt", now.Add(new TimeSpan(-5, 0, 0, 0)), false));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\directory1\directory2\directory3\t12_today.txt", now.Add(new TimeSpan(-4, 0, 0, 0)), false));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\directory1\directory2\directory3\t13_today.txt", now.Add(new TimeSpan(-3, 0, 0, 0)), false));
            retList.UpdateEntry(MRU_Service.Create_Entry(@"c:tmp\directory1\directory2\directory3\t14_today.txt", now.Add(new TimeSpan(-2, 0, 0, 0)), false));

            return retList;
        }
    }
}

