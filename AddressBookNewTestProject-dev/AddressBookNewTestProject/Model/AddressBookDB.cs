using LinqToDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookNewTestProject
{
    public class AddressBookDB : LinqToDB.Data.DataConnection
    {
        public AddressBookDB() : base(LinqToDB.ProviderName.MySql, "Server=localhost;Port:3306;Database=addressbook;Uid=root;Pwd=;charset=utf8;Trusted_Connection=True;Enlist=False;") { }

        public ITable<GroupData> Groups { get { return this.GetTable<GroupData>(); } }

        public ITable<ContactData> Contacts { get { return this.GetTable<ContactData>(); } }
    }


}
