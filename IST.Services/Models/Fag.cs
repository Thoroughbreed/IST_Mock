namespace IST.Services;

public class Fag
{
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
}