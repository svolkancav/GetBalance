using GetBalance.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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

        public static int BazalMetabolizmaHesapla(int boy, int kilo, int yas, ActivityLevel activityLevel, string cinsiyet)
        {
            int hesaplama;
            int sonuc;
            if (cinsiyet == "kadın")
            {
                hesaplama = (447593 + ((9247 * kilo) + (3098 * boy) - (4330 * yas))) / 1000;
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
            else
            {
                hesaplama = (88362 + ((13397 * kilo) + (4799 * boy) - (5677 * yas))) / 1000;
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

        public static decimal IdealKiloHesapla(int height, string cinsiyet)
        {
            decimal idealKilo;
            if (cinsiyet == "erkek")
            {
                idealKilo = Convert.ToDecimal(50 + (2.3 * ((height / 2.54) - 60)));

            }
            else
            {
                idealKilo = Convert.ToDecimal(45.5 + 2.3 * ((height / 2.54) - 60));
            }
            return Math.Round(idealKilo, 2);


        }

        public static decimal VücutYağOraniHesapla(int bel, int boyun, int kalca, int boy, string cinsiyet)
        {
            decimal VücutYağOrani;
            if (cinsiyet == "erkek")
            {
                //VücutYağOrani = Convert.ToDecimal((495 / ((1.0324 - 0.19077) * (Math.Log10(bel - boyun) + (0.15456 * Math.Log10(boy))))) - 450);

                VücutYağOrani = Convert.ToDecimal(495 / (1.0324 - 0.19077 * Math.Log10(bel - boyun) + 0.15456 * Math.Log10(boy)) - 450);
            }
            else
            {
                //VücutYağOrani = Convert.ToDecimal((495 / ((1.29579 - 0.35004) * (Math.Log10(bel + kalca - boyun) + (0.22100 * Math.Log10(boy))))) - 450);
                VücutYağOrani = Convert.ToDecimal(495 / (1.29579 - 0.35004 * Math.Log10(bel + kalca - boyun) + 0.22100 * Math.Log10(boy)) - 450);
            }
            return Math.Round(VücutYağOrani, 2);


        }


        public static decimal BMRHesapla(int boy, int kilo,int yas, string cinsiyet)
        {
            decimal bmr;
            if (cinsiyet == "erkek")
            {
                bmr = Convert.ToInt32(88.362 + (13.397 * kilo) +(4.799 * boy) - (5.677 * yas));
            }
            else
            {
                bmr = Convert.ToInt32(447.593 + (9.247 * kilo) + (3.098 * boy) - (4.330 * yas));
            }
            return bmr;
        }

    }
}
