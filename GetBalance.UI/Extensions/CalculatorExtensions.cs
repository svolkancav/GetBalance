using GetBalance.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.UI.Extensions
{
    public static class CalculatorExtensions
    {
        public static decimal VKİHesapla(int weight, int height)
        {
            decimal boy, kilo;
            boy = height;
            kilo = weight;
            decimal sonuc = kilo / (boy * boy / 10000);
            return Math.Round(sonuc, 2);
        }

        public static int BazalMetabolimaHesapla(int boy,int kilo,int yas, ActivityLevel activityLevel,string cinsiyet)
        {
            int hesaplama;
            int sonuc;
            if (cinsiyet =="kadın")
            {
                hesaplama = (447593 + ((9247 * kilo) + (3098 * boy) - (4330 * yas)))/1000;
                switch (activityLevel)
                {
                    case ActivityLevel.Sedentary:
                        sonuc = (hesaplama * 12)/10;
                        break;
                    case ActivityLevel.LightlyActive:
                        sonuc = (hesaplama * 1375) / 1000;
                        break;
                    case ActivityLevel.ModeratelyActive:
                        sonuc = (hesaplama * 155) / 100;
                        break;
                    case ActivityLevel.HighlyActive:
                        sonuc = (hesaplama * 1725) / 1000;
                        break;
                    case ActivityLevel.ExtremelyActive:
                        sonuc = (hesaplama * 19) / 10;
                        break;
                    default:
                        sonuc = (hesaplama * 12) / 10;
                        break;
                }
            }
            else
            {
                hesaplama = (88362 + ((13397 * kilo) + (4799 * boy) - (5677 * yas)))/1000;
                switch (activityLevel)
                {
                    case ActivityLevel.Sedentary:
                        sonuc = (hesaplama * 12) / 10;
                        break;
                    case ActivityLevel.LightlyActive:
                        sonuc = (hesaplama * 1375) / 1000;
                        break;
                    case ActivityLevel.ModeratelyActive:
                        sonuc = (hesaplama * 155) / 100;
                        break;
                    case ActivityLevel.HighlyActive:
                        sonuc = (hesaplama * 1725) / 1000;
                        break;
                    case ActivityLevel.ExtremelyActive:
                        sonuc = (hesaplama * 19) / 10;
                        break;
                    default:
                        sonuc = (hesaplama * 12) / 10;
                        break;
                }
            }
            return sonuc;
        }
    }
}
