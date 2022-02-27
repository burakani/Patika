using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler
            string degisken1 = "Burak";     //Text, cümle değişkenleri
            int degisken2 = 1;              //Sayı, değer değişkenleri
            long degisken7 = 5;             //Daha büyük değer alabilecek sayılarda long kullanılır.
            float degisken8 = 5;            //Reel ve tam sayı tutabilir.
            double degisken9 = 5.0;         //Ondalıklı, reel sayılar tutabilir.
            decimal degisken10 = 5;         //Reel sayılar.
            char degisken11 = 'A';          //Karakter.
            bool degisken12 = false;        //True ve false değer alabilir. Boolean.
            DateTime degisken13 = DateTime.Now; //Tarihi ve saati tutmak için kullanılır.
            object degisken14 = 5;          //Her değeri tutabilir, string, int, decimal vs.
            var degisken15 = "Burak";       //Her değişken tipine uygulanabilir.

            byte degisken3 = 5;             //0-255 arası bellekte 1 byte yer kaplar.
            sbyte degisken4 = 6;            //-128-127 arası bellekte 1 byte yer kaplar.
            short degisken5 = 7;            //-32768 - 32768 arası değer alabilir 2 byte yer kaplar.
            ushort degisken6 = 8;           //0-32768 arası değer alabilir.
        }
    }
}
