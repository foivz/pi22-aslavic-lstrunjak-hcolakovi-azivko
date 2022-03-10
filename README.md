# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa nastavnicima ili u sklopu WBL-a je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Aplikacija za rezervaciju autobusne karte


## Projektni tim

Ime i prezime   | E-mail adresa (FOI) | JMBAG      | Github korisničko ime
------------    | ------------------- | -----      | ---------------------
Andrija Slavić  | aslavic@foi.hr      | 0016143295 |    weis25
Luka Strunjak   | lstrunjak@foi.hr    | 0016145718 |    strule23
Hasan Čolaković | hcolakovi@foi.hr    | 0016145973 |    HasanColakovic99
Andrija Živko   | azivko@foi.hr       | 0016143755 |    Z1V3


## Opis domene
Aplikacija će omogućiti korisniku da rezevira autobusnu kartu za traženo odredište. Također, omogućiti će adminu da briše i dodaje nove autobusne relacije te korisniku omogućuje pretraživanje i sortiranje autobusnih linija te prikazuje popuste koje korisnik ostvaruje (ako zadovoljava određene uvjete). Isto tako korisniku će biti dostupna često postavljana pitanja koja će mu pomoći pri korištenju aplikacije.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Za pristupanje aplikaciji u svojstvu korisnika/admina | Hasan Čolaković
F02 | Spajanje na bazu podataka | Spajanje sa bazom podataka gdje će biti dostupne sve informacije o autobusnim linijama | Luka Strunjak
F03 | Profil korisnika | Pristupanje/kreiranje profila korsnika ili admina | Andrija Živko
F04 | Pregled vožnje | Informacije o rasporedu vožnje | Andrija Slavić
F05 | Rezervacija karte | Odabir sjedala i rezervacija karte za određenu liniju | Andrija Slavić
F06 | Filtriranje | Filtriranje po određenim karakteristikama (relacija, odredište, cijena karte...) | Andrija Živko
F07 | Uređivanje unesenih podataka | Uređivanje već postojećih podataka u slučaju nekih promjena (promjena voznog reda) | Hasan Čolaković
F08 | Unos novih linija prijevoza | Unos novih linija koje nisu do sada postojale | Hasan Čolaković
F09 | Ograničenja | Obavijest korisniku u slučaju popunjenosti autobusa ili nekih drugih izvanrednih situacija | Luka Strunjak
F10 | Popusti | Informacije o popustima ako korisnik zadovoljava određene uvjete (studenti, umirovljenici, učenici, invalidi) | Luka Strunjak
F11 | Recenzija | Povratne informacije korisnika o aplikaciji | Andrija Živko
F12 | FAQ | Pomoć korisnicima u korištenju aplikacije (često postavljana pitanja) | Andrija Slavić
## Tehnologije i oprema
Tehnologije koje ćemo koristiti su: Visual Studio 2019/2022, Github, MySQL DBMS, MySQL Workbench, Microsoft Word.
