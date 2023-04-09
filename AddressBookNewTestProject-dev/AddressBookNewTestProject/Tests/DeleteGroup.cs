using NUnit.Framework;
using System.Collections.Generic;

namespace AddressBookNewTestProject
{
    [TestFixture]
    class DeleteGroup : AuthTestBase
    {
        [Test]
        public void DeleteGroupTest()
        {
            List<GroupData> OldGroups = app.Group.GetGroupList();

            app.Group.Remove(0);

            List<GroupData> NewGroups = app.Group.GetGroupList();
            GroupData toBeRemoved = OldGroups[0];
            OldGroups.RemoveAt(0);

            Assert.AreEqual(OldGroups, NewGroups);

            foreach (GroupData group in NewGroups)
            {
                Assert.AreNotEqual(group.Id, toBeRemoved.Id);
            }
        }
    }
}
