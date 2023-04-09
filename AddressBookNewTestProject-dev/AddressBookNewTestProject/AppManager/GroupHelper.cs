using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookNewTestProject
{
    public class GroupHelper : HelperBase
    {

        public GroupHelper(ApplicationManager manager) : base(manager)
        {
        }

        public GroupHelper Create(GroupData groupData)
        {
            manager.Navigation.OpenGroupPage();
            InitNewGroup();
            FildForm(groupData);
            Accept();
            manager.Navigation.ReturnGroupPage();
            return this;
        }

        public int GetGroupCount()
        {
            return driver.FindElements(By.CssSelector("span.group")).Count;
        }

        private List<GroupData> groupCash = null;

        public List<GroupData> GetGroupList()
        {
            if (groupCash == null)
            {
                groupCash = new List<GroupData>();
                manager.Navigation.OpenGroupPage();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
                foreach (IWebElement element in elements)
                {
                    groupCash.Add(new GroupData()
                    {
                        Id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });
                }

                string allGroupNames = driver.FindElement(By.CssSelector("div#content form")).Text;
                string[] parts = allGroupNames.Split("\n");
                int shift = groupCash.Count - parts.Length;
                for (int i = 0; i < groupCash.Count; i++)
                {
                    if (i < shift)
                    {
                        groupCash[i].Name = "";
                    }
                    else
                    {
                        groupCash[i].Name = parts[i - shift].Trim();
                    }
                    
                }
            }
            //List<GroupData> groups = new List<GroupData>();
            //manager.Navigation.OpenGroupPage();
            //ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
            //foreach (IWebElement element in elements)
            //{
            //    groups.Add(new GroupData(element.Text));
            //}

            return new List<GroupData>(groupCash);
        }

        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navigation.OpenGroupPage();
            SelectedGroup(v);
            InitModificationGroup();
            FildForm(newData);
            AcceptGroupModification();
            manager.Navigation.ReturnGroupPage();
            return this;
        }

        private GroupHelper AcceptGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            groupCash = null;

            return this;
        }

        private GroupHelper InitModificationGroup()
        {
            driver.FindElement(By.Name("edit")).Click();

            return this;
        }

        internal GroupHelper Remove(int v)
        {
            manager.Navigation.OpenGroupPage();
            SelectedGroup(v);
            Delete();
            manager.Navigation.ReturnGroupPage();
            return this;
        }

        public GroupHelper Delete()
        {
            driver.FindElement(By.Name("delete")).Click();
            groupCash = null;
            return this;
        }

        public GroupHelper SelectedGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'][" + index + 1 + "])")).Click();
            return this;
        }


        public GroupHelper Accept()
        {
            driver.FindElement(By.Name("submit")).Click();
            groupCash = null;
            return this;
        }

        public GroupHelper FildForm(GroupData groupData)
        {
            Type(By.Name("group_name"), groupData.Name);
            Type(By.Name("group_header"), groupData.Header);
            Type(By.Name("group_footer"), groupData.Footer);

            return this;
        }

        public GroupHelper InitNewGroup()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
    }
}
