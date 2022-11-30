using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_Sample.Entities
{
    public class Address
    {
        public string Door_No { get; set; }
        public string Street_Locality { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }

        //public Address GetClone(bool IsClone)
        //{
        //    if(IsClone == true)
        //    {
        //        return (Address)this.MemberwiseClone();
        //    }
        //    else
        //    {
        //        return this;
        //    }
           
        //}
    }
}
