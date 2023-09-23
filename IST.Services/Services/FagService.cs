using System.Globalization;
using IST.Services.Interfaces;

namespace IST.Services.Services;

public class FagService : IFagService
{
    private List<Fag> _fags;

    public FagService()
    {
        _fags = new List<Fag>();
        var seedData = DataSeeding.SeedData();
        for (var i = 0; i <= 10; i++)
        {
            foreach (var fag in seedData)
            {
                _fags.Add(fag);
            }
        }
    }
    
    public ICollection<Fag> GetFagFromSchool(int limit, int offset, int instId)
    {
        return GetRandomFag(limit, offset, instId);
    }

    public bool CheckInstitutionID(int instId)
    {
        return instId == 1;
    }

    private ICollection<Fag> GetRandomFag(int limit, int offset, int instId)
    {
        var fagList = _fags.AsQueryable()
            .Where(f => f.gennemfoerende_skole == instId.ToString())
            .Skip(offset)
            .Take(limit);
        return fagList.ToList();
    }
}