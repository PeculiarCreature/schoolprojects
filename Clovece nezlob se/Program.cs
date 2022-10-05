// See https://aka.ms/new-console-template for more information

using CloveceNezlobSe;

HraciDeska hraciDeska = new LinearniHraciDeska(pocetPolicek: 10);
Hra hra = new Hra(hraciDeska);

Hrac hracMaky = new Hrac("Maky");
Hrac hracTom = new Hrac("Tom");
Hrac hracVera = new Hrac("Vera");

hra.PridejHrace(hracMaky);
hra.PridejHrace(hracTom);
hra.PridejHrace(hracVera);

hra.Start();