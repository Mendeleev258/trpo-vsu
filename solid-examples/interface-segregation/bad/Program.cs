using Bad.Models;

Console.WriteLine("JDM-гараж");

var rx7 = new MazdaRx7();
rx7.Drive();
rx7.Drift();

var hiAce = new ToyotaHiAce();
hiAce.Drive();
hiAce.LoadCargo();

var stagea = new NissanStagea260Rs();
stagea.Drive();
stagea.Drift();
stagea.LoadCargo();
