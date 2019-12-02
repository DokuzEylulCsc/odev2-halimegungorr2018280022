using System;

namespace roma_rakamını_sayıya_çevirme
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            {
                int yuzler = 0, onlar = 0, birler = 0, veri;

                string sonuc = "";
                Console.Write("Roma Rakamına Çevirmek İstediğiniz Sayıyı Giriniz => ");

                veri = Convert.ToInt32(Console.ReadLine());

                if (veri <= 1 || veri >= 3999)
                {
                    Console.WriteLine(" Lütfen 1 ile 3999 arasında bir sayı giriniz.");
                }

                if (veri > 99)
                {
                    yuzler = veri / 100;

                    if (veri - yuzler * 100 == 0)
                    {
                        goto ifSonu;
                    }

                    onlar = (veri - yuzler * 100) / 10;

                    birler = veri - (yuzler * 100 + onlar * 10);
                }
                else if (veri > 9)
                {
                    onlar = veri / 10;

                    birler = veri - onlar * 10;
                }
                else
                {
                    birler = veri;
                }


            ifSonu:

                if (yuzler > 0)
                {
                    switch (yuzler)
                    {
                        case 1:
                            sonuc = "C";
                            break;

                        case 2:
                            sonuc = "CC";
                            break;

                        case 3:
                            sonuc = "CCC";
                            break;

                        case 4:
                            sonuc = "CD";
                            break;

                        case 5:
                            sonuc = "D";
                            break;

                        case 6:
                            sonuc = "DC";
                            break;

                        case 7:
                            sonuc = "DCC";
                            break;

                        case 8:
                            sonuc = "DCC";
                            break;

                        case 9:
                            sonuc = "CM";
                            break;
                    }
                }
                if (onlar > 0)
                {
                    switch (onlar)
                    {
                        case 1:
                            sonuc = sonuc + "X";
                            break;

                        case 2:
                            sonuc = sonuc + "XX";
                            break;

                        case 3:
                            sonuc = sonuc + "XXX";
                            break;

                        case 4:
                            sonuc = sonuc + "XL";
                            break;

                        case 5:
                            sonuc = sonuc + "L";
                            break;

                        case 6:
                            sonuc = sonuc + "LX";
                            break;

                        case 7:
                            sonuc = sonuc + "LXX";
                            break;

                        case 8:
                            sonuc = sonuc + "LXXX";
                            break;

                        case 9:
                            sonuc = sonuc + "XC";
                            break;
                    }
                }

                if (birler > 0)
                {
                    switch (birler)
                    {
                        case 1:
                            sonuc = sonuc + "I";
                            break;

                        case 2:
                            sonuc = sonuc + "II";
                            break;

                        case 3:
                            sonuc = sonuc + "III";
                            break;

                        case 4:
                            sonuc = sonuc + "IV";
                            break;

                        case 5:
                            sonuc = sonuc + "V";
                            break;

                        case 6:
                            sonuc = sonuc + "VI";
                            break;

                        case 7:
                            sonuc = sonuc + "VII";
                            break;

                        case 8:
                            sonuc = sonuc + "VIII";
                            break;

                        case 9:
                            sonuc = sonuc + "IX";
                            break;
                    }
                }
                Console.WriteLine(sonuc.ToString());
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            }
        }
    }
}
     //kaynaklar
     //https://www.yazilimbilisim.net/c-sharp/c-console-ile-girilen-sayiyi-roma-rakamina-cevirme/
     //http://www.gorselprogramlama.com/klavyeden-girilen-bir-sayiyi-roma-rakamina-ceviren-program-c-console/


     //Halime Güngör-2018280022
