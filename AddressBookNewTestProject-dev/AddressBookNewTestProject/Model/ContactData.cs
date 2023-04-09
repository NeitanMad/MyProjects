using System;

namespace AddressBookNewTestProject
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        //public string allPhones;

        public ContactData(string firstName, string secondName, string address, string homePhone)
        {
            FirstName = firstName;
            LastName = secondName;
            Address = address;
            HomePhone = homePhone;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }

        //public string MobilePhone { get; set; }
        //public string WorkPhone { get; set; }
        //public string AllPhones
        //{
        //    get
        //    {
        //        if (allPhones != null)
        //        {
        //            return allPhones;
        //        }
        //        else
        //        {
        //            return (ClenUp(HomePhone) + ClenUp(MobilePhone) + ClenUp(WorkPhone)).Trim();
        //        }
        //    }
        //    set
        //    {
        //        allPhones = value;
        //    } 
        //}

        //public string ClenUp(string phone)
        //{
        //    if (phone == null || phone == "")
        //    {
        //        return "";
        //    }
        //    return phone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "") + "\r\n";  
        //}

        public int CompareTo(ContactData other)
        {
            if (ReferenceEquals(other, null))
            {
                return 1;
            }
            int result = LastName.CompareTo(other.LastName);
            if (result != 0)
            {
                return result;
            }
            else
            {
                return FirstName.CompareTo(other.FirstName);
            }
        }

        public bool Equals(ContactData other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return FirstName == other.FirstName && LastName == other.LastName;
        }

        public override int GetHashCode()
        {
            return (FirstName + " " + LastName).GetHashCode();
        }

        public override string ToString()
        {
            return (FirstName + " " + LastName).ToString();
        }
    }
}
