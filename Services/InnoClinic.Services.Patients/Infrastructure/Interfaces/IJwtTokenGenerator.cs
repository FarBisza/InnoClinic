using InnoClinic.Services.Patients.Domain.Entities;

namespace InnoClinic.Services.Patients.Infrastructure.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateJwtToken(Patient patient);
    }
}