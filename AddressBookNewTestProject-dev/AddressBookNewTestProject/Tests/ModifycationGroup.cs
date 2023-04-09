using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookNewTestProject
{
    [TestFixture]
    public class ModifycationGroup : AuthTestBase
    {
        [Test]
        public void ModifycationGroupTest()
        {
            List<GroupData> oldGroups = app.Group.GetGroupList();

            GroupData oldData = oldGroups[0];

            GroupData newData = new GroupData("New name", null, null);
            app.Group.Modify(0, newData);

            List<GroupData> newGroups = app.Group.GetGroupList();
            oldGroups[0].Name = newData.Name;
            Assert.AreEqual(oldGroups.OrderBy(group => group.Name), newGroups.OrderBy(group => group.Name));

            foreach (GroupData group in newGroups)
            {
                if (group.Id == oldData.Id)
                {
                    Assert.AreEqual(newData.Name, group.Name);
                }
            }
        }
    }
}
