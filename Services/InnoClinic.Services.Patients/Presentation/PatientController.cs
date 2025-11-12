using InnoClinic.Services.Patients.Infrastructure.Persistence;
using InnoClinic.Services.Patients.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using InnoClinic.Services.Patients.Application.DTO;
using AutoMapper;


namespace InnoClinic.Services.Patients.Presentation
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDTO _responseDTO;
        private IMapper _mapper;
        public PatientController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _responseDTO = new ResponseDTO();
        }

        [HttpGet]
        public ResponseDTO Get()
        {
            try
            {
                IEnumerable<Patient> objList = _db.Patients.ToList();
                _responseDTO.Result = _mapper.Map<IEnumerable<PatientDTO>>(objList);
            }
            catch (System.Exception ex)
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = ex.Message;
            }
            return _responseDTO;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDTO Get(int id)
        {
            try
            {
                Patient obj = _db.Patients.First(x => x.Id == id);
                _responseDTO.Result = _mapper.Map<PatientDTO>(obj);

            }
            catch (System.Exception ex)
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = ex.Message;
            }
            return _responseDTO;
        }

        [HttpGet]
        [Route("Patient/{name}")]
        public ResponseDTO GetName(string name)
        {
            try
            {
                Patient obj = _db.Patients.First(x => x.FirstName.ToLower() == name.ToLower());
                _responseDTO.Result = _mapper.Map<PatientDTO>(obj);

            }
            catch (System.Exception ex)
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = ex.Message;
            }
            return _responseDTO;
        }

        [HttpPost]
        public ResponseDTO CreatePatient([FromBody] PatientDTO patientDTO)
        {
            try
            {
                Patient obj = _mapper.Map<Patient>(patientDTO);
                _db.Patients.Add(obj);
                _db.SaveChanges();

            }
            catch (System.Exception ex)
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = ex.Message;
            }
            return _responseDTO;
        }

        [HttpPut]
        public ResponseDTO UpdatePatient([FromBody] PatientDTO patientDTO)
        {
            try
            {
                Patient obj = _mapper.Map<Patient>(patientDTO);
                _db.Patients.Update(obj);
                _db.SaveChanges();

            }
            catch (System.Exception ex)
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = ex.Message;
            }
            return _responseDTO;
        }
        
        [HttpDelete]
        public ResponseDTO DeletePatient(int id)
        {
            try
            {
                Patient obj = _db.Patients.First(x => x.Id == id);
                _db.Patients.Remove(obj);
                _db.SaveChanges();
                
            }
            catch (System.Exception ex)
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = ex.Message;
            }
            return _responseDTO;
        }
    }

}