// ReSharper disable InconsistentNaming
// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace IST.Services.Models;

public class Fag
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public string betegnelse { get; set; }
    public string fag { get; set; }
    public string fag_arves { get; set; }
    public string fag_id { get; set; }
    public string fag_slutdato { get; set; }
    public string fag_startdato { get; set; }
    public string fjernundervisning { get; set; }
    public string foregaar_undervisning_paa_virksomhed { get; set; }
    public string fuld_justeret_pris { get; set; }
    public string gennemfoerende_skole { get; set; }
    public string godkendt_skole { get; set; }
    public string justeret_pris { get; set; }
    public string kort_betegnelse { get; set; }
    public string lms { get; set; }
    public string niveau { get; set; }
    public string norm_varighed { get; set; }
    public FagPeriode perioder { get; set; }
    public string plan_varighed { get; set; }
    public string timer_pr_dag { get; set; }
    public string uddannelse { get; set; }
    
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}