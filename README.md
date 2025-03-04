Feladatleírás

1. xampp
2. MySql adatbazis (ehhez kell a pomelo csomag)
3. package manager
   - dotnet tool install --global dotnet-ef
   - dotnet ef dbcontext scaffold "Data Source=Database\DATABASE.db" Microsoft.EntityFrameworkCore.Sqlite -o Models (-f a végére ha forceolni kell)

**Classroom**
Cél a 
Nappali 13.b; 2,14b számára ismétlő gyakorlás!
Nappali 13.c számára gyakorlás!
Esti 2. évfolyam számára előre tanulás (lásd előző bejegyzés) és gyakorlás!


Link: feladatok az elvp2-n:
 - Egy táblás - Vásárló feladat - VasarloKonzolFeladat.docx (A konzol)
 - Egy táblás - Játékos feladat - JatékosFeladatKonzol.docx (A rész, csak modell réteg)
 - Egy táblás - Játékos feladat - NyerőÉsVesztőJátékos-Model.docx - (teljes feladat)

Feltöltendő a Program.cs és az osztály (Customer.cs vagy Player.cs), és csak ezek, nem tömörítve, nem kell a teljes projekt!
13.b -> Nyerő és vesztő játékos
13.c ->
  - Átnézni az órai jegyzetet (előző bejegyzés, vásárló),
  - Játékos vagy nyerő és vesztő játékos
  - 2/14b (nappali) -> Nyerő és vesztő játékos

Kérem határidőre feltölteni a feladatot! Ha nem tölt fel semmit, akkor úgy tekintem, hogy nem foglalkozott vele és 1-est írhatok be!
Ha valami nem világos kérem írjanak itt a classroomban a feladatnál!

**elvp2**
https://elvp2.vasvari.hu/mod/folder/view.php?id=5627

//  dotnet-ef telepítés:

﻿dotnet tool install --global dotnet-ef

//Sqlite

dotnet ef dbcontext scaffold "Data Source=Database\DATABASE.db" Microsoft.EntityFrameworkCore.Sqlite -o Models
dotnet ef dbcontext scaffold "Data Source=Database\DATABASE.db" Microsoft.EntityFrameworkCore.Sqlite -o Models -f

//MySQL

dotnet ef dbcontext scaffold "Server=localhost;Database=DATABASE;User=root;Password=;" Pomelo.EntityFrameworkCore.MySql -o Models
dotnet ef dbcontext scaffold "Server=localhost;Database=DATABASE;User=root;Password=;" Pomelo.EntityFrameworkCore.MySql -o Models -f

// Szükséges csomagok

<PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite.Core" Version="8.0.12" />
<PackageReference Include="SQLitePCLRaw.core" Version="2.1.10" />
<PackageReference Include="SQLitePCLRaw.bundle_e_sqlite3" Version="2.1.10" />
<PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="8.0.2" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.12"/>
