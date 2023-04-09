using LinqToDB.Mapping;
using System;

namespace AddressBookNewTestProject
{
    [Table(Name = "group_list")]
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {

        public GroupData(string name, string header, string footer)
        {
            Name = name;
            Header = header;
            Footer = footer;
        }

        public GroupData(string name)
        {
            Name = name;
        }
        public GroupData()
        {
        }
        [Column(Name = "group_name")]
        public string Name { get; set; }
        [Column(Name = "group_header")]
        public string Header { get; set; }
        [Column(Name = "group_footer")]
        public string Footer { get; set; }
        [Column(Name = "group_id"),PrimaryKey, Identity]
        public string Id { get; set; }


        public bool Equals(GroupData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name;
        }

        override public int GetHashCode()
        {
            return Name.GetHashCode();
        }

        override public string ToString()
        {
            return "name = " + Name;
        }

        public int CompareTo(GroupData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return other.Name.CompareTo(other.Name);
        }
    }
}
