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
                fag_arves = "false",
                fag_id = "h3sk134z",
                fag_slutdato = DateTime.Now.AddDays(30).ToString(CultureInfo.InvariantCulture),
                fag_startdato = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                fjernundervisning = "false",
                foregaar_undervisning_paa_virksomhed = "false",
                fuld_justeret_pris = "10.000,00",
                gennemfoerende_skole = "1",
                godkendt_skole = "true",
                justeret_pris = "12.000,00",
                kort_betegnelse = "Emb. II",
                lms = "lms",
                niveau = "3",
                norm_varighed = "2",
                perioder = new FagPeriode
                {
                    fag_periode_id = "1",
                    fag_periode_slut = DateTime.Now.AddDays(30).ToString(CultureInfo.InvariantCulture),
                    fag_periode_start = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                    lokation = "51.244",
                    lokation_betegnelse = "Sibirien",
                    norm_varighed_dage = "14",
                    periode_varighed = "2",
                    timer_pr_dag = "7,24",
                    tmk = "tmk"
                },
                plan_varighed = "2",
                timer_pr_dag = "7,24",
                uddannelse = "Datatekniker Prog"
            },
            new Fag
            {
                betegnelse = "Et andet fag",
                fag = "Embedded III",
                fag_arves = "false",
                fag_id = "h3sk134y",
                fag_slutdato = DateTime.Now.AddDays(60).ToString(CultureInfo.InvariantCulture),
                fag_startdato = DateTime.Now.AddDays(30).ToString(CultureInfo.InvariantCulture),
                fjernundervisning = "false",
                foregaar_undervisning_paa_virksomhed = "false",
                fuld_justeret_pris = "11.000,00",
                gennemfoerende_skole = "1",
                godkendt_skole = "true",
                justeret_pris = "19.000,00",
                kort_betegnelse = "Emb. III",
                lms = "lms",
                niveau = "5",
                norm_varighed = "2",
                perioder = new FagPeriode
                {
                    fag_periode_id = "1",
                    fag_periode_slut = DateTime.Now.AddDays(60).ToString(CultureInfo.InvariantCulture),
                    fag_periode_start = DateTime.Now.AddDays(30).ToString(CultureInfo.InvariantCulture),
                    lokation = "51.244",
                    lokation_betegnelse = "Sibirien",
                    norm_varighed_dage = "14",
                    periode_varighed = "2",
                    timer_pr_dag = "7,24",
                    tmk = "tmk"
                },
                plan_varighed = "2",
                timer_pr_dag = "7,24",
                uddannelse = "Datatekniker Prog"
            }
        };


        return list;
    }
}