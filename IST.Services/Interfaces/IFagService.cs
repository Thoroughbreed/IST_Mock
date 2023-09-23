namespace IST.Services.Interfaces;

public interface IFagService
{
    public ICollection<Fag> GetFagFromSchool(int limit, int offset, int instId);
    public bool CheckInstitutionID(int instId);
}