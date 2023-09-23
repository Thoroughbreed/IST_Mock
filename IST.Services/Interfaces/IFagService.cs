using IST.Services.Models;

namespace IST.Services.Interfaces;

public interface IFagService
{
    public ICollection<Fag> GetFagFromSchool(int limit, int offset, int instId);
    // ReSharper disable once InconsistentNaming
    public bool CheckInstitutionID(int instId);
}