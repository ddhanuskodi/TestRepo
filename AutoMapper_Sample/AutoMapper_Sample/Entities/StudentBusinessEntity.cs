using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_Sample.Entities
{
    public class StudentBusinessEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Address address { get; set; }

        //public StudentBusinessEntity GetClone(bool IsClone)
        //{
        //    StudentBusinessEntity studentBusinessEntity = new StudentBusinessEntity();// (StudentBusinessEntity)this.MemberwiseClone();
        //    studentBusinessEntity.address = address.GetClone(IsClone);
        //    return studentBusinessEntity;
        //}
    }
}
