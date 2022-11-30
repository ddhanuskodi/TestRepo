using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_Sample.Entities
{
    public class StudentServiceEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public Address address { get; set; }

        //public StudentServiceEntity GetClone(bool IsClone)
        //{
        //    StudentServiceEntity studentServiceEntity = new StudentServiceEntity();//(StudentServiceEntity)this.MemberwiseClone();
        //    studentServiceEntity.address = address.GetClone(IsClone);
        //    return studentServiceEntity;
        //}
    }
}
