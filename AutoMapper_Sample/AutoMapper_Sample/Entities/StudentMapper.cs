using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace AutoMapper_Sample.Entities
{
    public class StudentMapper : Profile
    {
        public StudentMapper()
        {
            CreateMap<StudentServiceEntity,StudentBusinessEntity>();
            CreateMap<StudentBusinessEntity,  StudentServiceEntity>();
        }

        public StudentServiceEntity MapBusinessToService(StudentBusinessEntity studentBusinessEntity)
        {
            return new StudentServiceEntity()
            {
                Name = studentBusinessEntity.Name,
                Age = studentBusinessEntity.Age,
                City = studentBusinessEntity.City
            };
        }
        public StudentBusinessEntity MapServiceToBusiness(StudentServiceEntity studentServiceEntity)
        {
            return new StudentBusinessEntity()
            {
                Name = studentServiceEntity.Name,
                Age = studentServiceEntity.Age,
                City = studentServiceEntity.City
            };
        }
    }
}
