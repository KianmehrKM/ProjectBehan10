using System;

namespace HoghoogheKargar
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, m, sal, fsal, tax, bim, mas;
            // N = Padash
            // M = Kasre mablaghi ke dade shode baraye maliat va gheire.
            // SAL = Hoghoogh
            // FSAL = Hoghooghe nahayi
            // TAX = Maliat
            // BIM = Haghe bimeh
            // MAS = Haghe maskan

            Console.Write("Hoghoogh ra vared konid: ");
            sal = float.Parse(Console.ReadLine());
            // Inja hoghoogh ra migire
            // Hoghoogh dar moteghayere "SAL" vared mishe
            
            // !!!!!
            // NOKTEH!
            // Agar adadi ke dar miad, be soorate adade elmi mibashad
            // Manande "1.176E+07"
            // Mitavanid sefr hayi ke naveshte shode dar barnameh ra pak konnid
            // Va bejash adad koochek tar bezarid
            // Mesal:
            // 2000000 = 2
            // Vali karbar bayad adade koochek vared kone va na bozorg
            // Chon barnameh momkene fekr kone ke shoma hoghooghe bishtar az 15 melion ra vared mikonid.
            // !!!!!
            
            // Agar kamtar az 2 melion bood, chap mikone ke maliat nadare va 1 milion padash mide
            // Adad va payam chap shode ra mitavan taghir dad.
            if (sal <= 2000000)
            {
                Console.WriteLine("Maliat nadarad.");

                fsal = sal + 1000000;

                Console.WriteLine("Hoghooghe nahayi: " + fsal);
            }

            // Agar beine 2 melion ta 6 melion bood
            // Az karbar darkhast mikone ke padashe ra vared kone, in ghesmat mitoone hazf beshe
            // Agar padash hazf shod, hatman moteghayere "n" hazf shavad.
            // Hoghooghe nahayi ro ba padashi ke karbar taain karde ezafe mikone va chap mikone.
            else if ((sal > 2000000) && (sal <= 6000000))
            {
                Console.WriteLine("Padash ra vared konid: ");
                n = float.Parse(Console.ReadLine());

                fsal = sal + n;
                Console.WriteLine("Hoghooghe nahayi: " + fsal);
            }

            // Agar beine 6 melion ta 10 melion bood
            // Maliat kam mikone (Ghabele taghir ast)
            // Maliat mitoone hazf beshe, agar dar inja hazf shod va dar jayi dige hazf nashod, lazem be hazfe moteghayer nist.
            // Agar maliat dar hame ja hazf shod, moteghayere "TAX" hazf shavad.
            // Darsade maliat ra mishe taghir dad
            // Vaghti maliat hesab shod, az hoghooghesh kam mikone va ba payam chap mikone.
            else if ((sal > 6000000) && (sal <= 10000000))
            {
                tax = sal * 1 / 100;
                fsal = sal - tax;

                Console.WriteLine("Hoghooghe nahayi: " + fsal);
            }

            // Agar beine 10 melion ta 15 melion bood
            // 6 melion az hoghoogh ro sarfe hesab kardane maliat va haghe maskan mikone
            // Agar 6 melion toman mikhast hazf beshe dar inja va na dar jaye dige, mitoonid moteghayer ra negah darid
            // Agar 6 melion dar hame ja hazf shod, bayad moteghayere "M" ra hazf kard.
            // Maliat va haghe maskan ra mitavan hazf kard.
            // Agar maliat va haghe maskan dar inja hazf shod, lazem be hazf kardane moteghayer nist
            // Agar dar hame ja hazf shod, moteghayer haye "TAX" va "MAS" hazf shavad.
            // Dar nahayat bade hesab kardan maliat va haghe maskan, az hoghoogh kam mikonad va hoghooghe nahayi ra chap mikonad.
            else if ((sal > 10000000) && (sal <= 15000000))
            {
                m = sal - 6000000;

                tax = m * 3 / 100;
                mas = m * 1 / 100;

                fsal = sal - tax - mas;
                Console.WriteLine("Hoghooghe nahayi: " + fsal);
            }

            // Agar bishtar az 15 melion bood
            // Azash 10 melion kam mikone va mizare tooye "M"
            // Az 10 melion, maliat, haghe bimeh va haghe maskan ra kam mikone
            // Agar maliat va haghe maskan faghat dar inja hazf shod, lazem be hazf kardane moteghayer nist.
            // Chon haghe bimeh faghat dar inja neveshte shode, va agar hazf shod, bayad moteghayer ba aan paak shavad.
            // Vali agar haghe bimeh dar jayi dige neveshte shode bood va faghat az inja paak shode bood, lazem be paak kardane moteghayer nist.
            // Maliat. haghe bimeh va haghe maskan ra az hoghoogh kam karde va dar akhar chap karde.
            else if (sal >= 15000000)
            {
                m = sal - 10000000;

                tax = m * 4 / 100;
                bim = m * 2 / 100;
                mas = m * 1 / 100;

                fsal = sal - tax - bim - mas;
                Console.WriteLine("Hoghooghe nahayi: " + fsal);
            }

            // Inja baraye inke barnameh be payan reside va sari baste nashe, in dastoor gozashte mishe
            // In dastoor, sabr mikone ta karbar yek kilide keyboardo bezane va az barname kharej beshe.
            // [EKHTIYARI] Baraye goftan payane barnameh, mitavan in dastoor ra nevesht:
            // [EKHTIYARI] Console.WriteLine("Payane barnameh");
            // Va baad az inke karbar yek kilid ra zad, barname kharej khahad shod.
            Console.ReadKey();

            // Payane barnameh.
        }
    }
}
