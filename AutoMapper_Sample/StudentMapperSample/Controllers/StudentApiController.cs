using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper_Sample.Entities;
using AutoMapper_Sample;

namespace StudentMapperSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {

        private readonly IMapper _mapper;

        public StudentApiController(IMapper mapper)
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
            Address address2 = new Address()
            {
                City = "Bangalore",
                Door_No = "204",
                Street_Locality = "4th Main Ring Road",
                Pincode = "560104"
            };
            StudentServiceEntity studentDTO = new StudentServiceEntity()
            {
                Name = "Student 1",
                Age = 25,
                City = "New York",
                address = address1
            };

            StudentServiceEntity studentDTO2 = studentDTO.GetClone(true);

            studentDTO2.Name = "Ramachandran";
            studentDTO2.Age = 26;
            studentDTO2.City = "Massechussets";
            studentDTO2.address = address2;

            var NewObject = _mapper.Map<StudentBusinessEntity>(studentDTO);

            NewObject.Name = "Anandha";
            NewObject.address.City = "Hyderabad";

            return null;
        }

        [HttpGet]
        public HisClass GetHis()
        {
            return new HisClass() 
            {
                hisname = "Michel Portar",
                startdate = DateTime.Today.Date,
                GetStatus = HisStatus.started
            };
        }

        [HttpGet]
        public HisDetails GetHisDetails()
        {
            return new HisDetails()
            {
                email = "MichelPortar@altimetrik.com",
                hisaddress = "Massechusetts USA",
                hisname = "Michel Portar"
            };
        }
    }

    public class Age
    {
        public int _Age;

        public Age(int id)
        {
            this._Age = id;
        }
    }

    public class studentServiceNtt
    {
        public int age;
        public string name;
        public Age ID;

        public studentServiceNtt DeepCopy()
        {
            studentServiceNtt temp = (studentServiceNtt)this.MemberwiseClone();
            temp.ID = new Age(this.ID._Age);
            temp.name = this.name;
            return temp;
        }
    }
}
