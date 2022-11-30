using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper_Sample.Entities;

namespace StudentMapperSample.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: api/<controller>  
        [HttpGet]
        public StudentBusinessEntity Get()
        {
            Address address1 = new Address()
            {
                City = "Chennai",
                Door_No = "149",
                Street_Locality = "5th Cross Street",
                Pincode = "600116"
            };

            StudentServiceEntity studentDTO = new StudentServiceEntity()
            {
                Name = "Student 1",
                Age = 25,
                City = "New York",
                address = address1
            };

            return _mapper.Map<StudentBusinessEntity>(studentDTO);
        }

        [HttpGet]
        public void GetHis()
        {
            
        }
    }
}
