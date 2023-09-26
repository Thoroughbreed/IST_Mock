using System.Globalization;
using IST.Services.Models;

namespace IST.Services.Services;

public static class DataSeeding
{
    public static List<Fag> SeedData()
    {
        var list = new List<Fag>
        {
            new Fag
            {
                betegnelse = "Et fag",
                fag = "Embedded II",
                fag_arves = false,
                fag_id = "h3sk134z",
                fag_slutdato = DateTime.Now.AddDays(30),
                fag_startdato = DateTime.Now,
                fjernundervisning = false,
                foregaar_undervisning_paa_virksomhed = false,
                fuld_justeret_pris = 10000.50,
                gennemfoerende_skole = 1,
                godkendt_skole = true,
                justeret_pris = 12000,
                kort_betegnelse = "Emb. II",
                lms = "lms",
                niveau = 3,
                norm_varighed = 3,
                perioder = new Periode
                {
                    fag_periode_id = 1,
                    fag_periode_slut = DateTime.Now.AddDays(30),
                    fag_periode_start = DateTime.Now,
                    lokation = "51.244",
                    lokation_betegnelse = "Sibirien",
                    norm_varighed_dage = 10,
                    periode_varighed = 2,
                    timer_pr_dag = 7.24,
                    tmk = "tmk"
                },
                plan_varighed = 2,
                timer_pr_dag = 7.24,
                uddannelse = "Datatekniker Prog"
            },
            new Fag
            {
                betegnelse = "Et andet fag",
                fag = "Embedded III",
                fag_arves = false,
                fag_id = "h3sk134y",
                fag_slutdato = DateTime.Now.AddDays(60),
                fag_startdato = DateTime.Now.AddDays(30),
                fjernundervisning = true,
                foregaar_undervisning_paa_virksomhed = false,
                fuld_justeret_pris = 11234.55,
                gennemfoerende_skole = 1,
                godkendt_skole = true,
                justeret_pris = 22500.76,
                kort_betegnelse = "Emb. III",
                lms = "lms",
                niveau = 5,
                norm_varighed = 2,
                perioder = new Periode
                {
                    fag_periode_id = 1,
                    fag_periode_slut = DateTime.Now.AddDays(60),
                    fag_periode_start = DateTime.Now.AddDays(30),
                    lokation = "51.244",
                    lokation_betegnelse = "Sibirien",
                    norm_varighed_dage = 10,
                    periode_varighed = 2,
                    timer_pr_dag = 7.24,
                    tmk = "tmk"
                },
                plan_varighed = 2,
                timer_pr_dag = 7.24,
                uddannelse = "Datatekniker Prog"
            }
        };


        return list;
    }
}