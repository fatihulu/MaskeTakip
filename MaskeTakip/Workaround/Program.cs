//Degiskenler();

//Vatandas vatandas = new();
using Business.Concrete;
using Entities.Concrete;

SelamVer("Fatih");
SelamVer();

//--------------------------------------------------------------

int sonuc = Topla(3, 5);

//--------------------------------------------------------------

//Diziler / Arrays
string[] ogrenciler = new string[2];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Fatih";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

//---------------------------------------------------------------

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Konya";
Console.WriteLine(sehirler2[0]);//Konya

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//----------------------------------------------------------------

List<string> yeniSehirler1 = new List<string> { "Van", "Adana", "Trabzon" };
yeniSehirler1.Add("Konya");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

//----------------------------------------------------------------

Person person = new Person();
person.NationalIdentity = 12345678910;
person.FirstName = "FATİH";
person.LastName = "ULU";
person.DateOfBirthYear = 1994;
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);

Console.ReadLine();

static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}

static void Degiskenler()
{
    string mesaj = "Selam";
    double tutar = 100000;
    double kdv = 1.18;

    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Fatih";
    string soyad = "Ulu";
    int dogumYili = 1994;
    long tcNo = 12345678910;

    Console.WriteLine(mesaj);
    Console.WriteLine(tutar * kdv);
}


public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}
