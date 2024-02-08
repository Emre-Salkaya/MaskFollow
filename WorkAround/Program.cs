using Business.Concrete;
using Entities.Concrete;


static void SelamVer(string isim = "İsimsiz") // buralarda parantez içlerinde yazılan değerlere parametre denir. 
{ //Default parametre dediğimiz olan bu isimsiz kısmıdır. herhangi bir parametre girilmez ise isimsiz parametresinikullanacak
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 9)
{
    int sonuc  = sayi1 + sayi2; // sonuc = local değişkendir ve lokal değişkenler yalnızca tanımlandığı blok içerisinde geçerlidir.
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc; // return ün açıklaması atanan referansa değeri götür diyebiliriz.
}

SelamVer();
SelamVer("Emre");
SelamVer("Eren");
SelamVer("Hazal");
Topla(3, 5);
Topla(3);
Topla();

string[] ogrenciler = new string[] {"ali","ayşe","fatma"};
string[] ogrenciler2 = new string[] { "mahmut", "sıla", "atakan" };
ogrenciler2 = ogrenciler;
ogrenciler[0] = "emre";
Console.WriteLine(ogrenciler2[0]); // --> emredir çünkü referans tip olduğu için değeri heapa yolanıyor oradan okuyor

//Array, Class, İnterface, Abstract ---> referans tiplerdir ve stack heap dediğimiz arkaplan çalışmalarında stack e karşı bir heap atanır.

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
// => sayi 2 = ??
//burada sayı 2 değeri 10 dur çünkü int ler değer tiptir ve stack heap kısımlarında referanslar gibi atama yapılmaksınız yalnızca stack kısmını kullanırlar. ve değerler bir seferde atanır . o yüzden daha sonradan olan değişiklikler heap kısmına yazılmaığı için birbirilerini etkilemeyecektir.
// int, double, bool --> Değer tiplerdir ve yalnızca stack kısmında değer alırlar.

List<string> sehirler = new List<string> {"Ankara","İstanbul","İzmir","Yozgat","çorum"};

Ekleme ekleme = new Ekleme();
ekleme.EklemeList(sehirler, "fransa");

foreach (string s in sehirler)
{
    Console.WriteLine(s);
}

Person person1 = new Person {FirstName = "Emre", LastName = "Salkaya", Id = 123456789, DateOfBirthYear = 01/01/2024 };
Person person2 = new Person {FirstName = "Sinan", LastName = "Engin", Id = 987654321, DateOfBirthYear = 29/29/2024 };

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);





public class Ekleme // list kodu için add yerine geçebilecek ekleme metodu.
{
    public List<string> EklemeList(List<string> liste, string yeniEleman)
    {
        int ListeSayisi = 1;
        foreach (string list in liste)
        {
            ListeSayisi = ListeSayisi + 1;
        }

        List<string> newList = new List<string>();
        newList = liste;
        newList.EnsureCapacity(ListeSayisi);
        ListeSayisi = ListeSayisi - 1;
        newList.Insert(ListeSayisi, yeniEleman);

        return newList;
    }
}

