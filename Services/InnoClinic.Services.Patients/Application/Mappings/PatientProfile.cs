using AutoMapper;
using InnoClinic.Services.Patients.Application.DTO;
using InnoClinic.Services.Patients.Domain.Entities;

namespace InnoClinic.Services.Patients.Application.Mappings
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<PatientDTO, Patient>();
            CreateMap<Patient, PatientDTO>();
        }
    }
}