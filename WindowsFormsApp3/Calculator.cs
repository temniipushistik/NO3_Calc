using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Calculator
    {
        public decimal Hard;
        public decimal NO3;
        public decimal SO4;
        public decimal sColumn;

        public decimal bypassNO3;//проскок нитратов
        public decimal volumeA202;//объем смолы 202
        public decimal volumeTC007;//объем смолы 007
        public decimal averageFlow;//производительность системы
        public decimal filtroCycle;
        public decimal anionCapasityL;//емкость одного литра анионита
        public decimal cationCapasityL;//емкость одного литра катионита
        public decimal anionCapasityFull;//емкость всего объема анионита
        public decimal cationCapasityFull;//емкость всего объема катионита
        public decimal sumAnion;
        public int VAnion;
        public int VCation;
        public string devideNO3SO4Text;
        public string workCapacityText;
        public string bypassNO3Text;
        public string typeColumn;
        
        decimal fullVolume;//полный объем смолы
        const decimal k = 0.785M;

        public Calculator()
        {

        }

        public void fillDatas(String NO3, String SO4, String Hard, String sColumn)
        {
            this.NO3 = decimal.Parse(NO3);
            this.SO4 = decimal.Parse(SO4);
            this.Hard = decimal.Parse(Hard);
            this.sColumn = decimal.Parse(sColumn);
        }

        public decimal calculateNO3SO4()
        {
            return (NO3 / 62) / (NO3 / 62 + SO4 / 48); 
        }

        public decimal calculateAnionCapasityL()
        {
            decimal devideNO3SO4 = calculateNO3SO4();
            return 0.28M * devideNO3SO4 * devideNO3SO4 + 0.4M;
        }

        public decimal calculateBypassNO3()
        {
            decimal devideNO3SO4 = calculateNO3SO4();
 
            //определяем по графику проскок по нитратам:
            if (devideNO3SO4 > 0.8M && devideNO3SO4 <= 1.0M)
            {
                bypassNO3 = (-2.5M * devideNO3SO4 + 11.5M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0.6M && devideNO3SO4 <= 0.8M)
            {
                bypassNO3 = (-7.5M * devideNO3SO4 + 15.5M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0.4M && devideNO3SO4 <= 0.6M)
            {
                bypassNO3 = (-25M * devideNO3SO4 + 26M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0.2M && devideNO3SO4 <= 0.4M)
            {
                bypassNO3 = (-45M * devideNO3SO4 + 34M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0M && devideNO3SO4 <= 0.2M)
            {
                bypassNO3 = (-75M * devideNO3SO4 + 40M) * NO3 * 0.01M;
            }
            else
            {
                bypassNO3 = NO3;
            }

            return bypassNO3;
        }

        public decimal calculateSumAnion()
        {
            return sumAnion = NO3 + SO4;

        }

        public decimal getVAnion()
        {
            decimal sumAnion = calculateSumAnion();
            int range = (int)((sumAnion) / 50M);// автоприведение типа в инт
                                                // выделяем целую часть через инт и используем ее в качесте проверки. Если 0 получается, то первое условие и т.д. 
            switch (range)
            {
                case 0:
                    return 25;
                case 1:
                    return 20;
                case 2:
                    return 15;
                case 3:
                    return 12;
                default:
                    return 10;
            }
        }

        public decimal getVCation()
        {
            int range = (Hard <= 5) ? 0 : ((Hard <= 10) ? 1 : ((Hard <= 14) ? 2 : ((Hard <= 18) ? 3 : 4)));
            switch (range)
            {
                case 0:
                    return 25;
                case 1:
                    return 20;
                case 2:
                    return 15;
                case 3:
                    return 12;
                default:
                    return 10;
            }
        }

        public void CommonСalc(string typeColumn)
        { 
            //Выбираем меньшее:

            decimal VReal = Math.Min(getVCation(), getVAnion());

            SColumnClass(typeColumn);
            averageFlow = VReal * sColumn;


        }




        public void SColumnClass(string typeColumn)
        {
            if (typeColumn == "8x44 или кабинет")
            {
                sColumn = k * (0.205M * 0.205M);
                fullVolume = 20M;
            }
            else if (typeColumn == "10х44")
            {
                sColumn = k * (0.257M * 0.257M);
                fullVolume = 25M;
            }
            else if (typeColumn == "10х54")
            {
                sColumn = k * (0.257M * 0.257M);
                fullVolume = 37.5M;
            }

            else if (typeColumn == "12х52")
            {
                sColumn = k * (0.307M * 0.307M);
                fullVolume = 50M;
            }

            else if (typeColumn == "13х54")
            {
                sColumn = k * (0.335M * 0.335M);
                fullVolume = 50M;
            }
            else if (typeColumn == "14х65")
            {
                sColumn = k * (0.366M * 0.366M);
                fullVolume = 75M;
            }
            else if (typeColumn == "16х65")
            {
                sColumn = k * (0.411M * 0.411M);
                fullVolume = 113M;
            }
            else if (typeColumn == "18х65")
            {
                sColumn = k * (0.491M * 0.491M);
                fullVolume = 150M;
            }
            else if (typeColumn == "21х62")
            {
                sColumn = k * (0.555M * 0.555M);
                fullVolume = 188M;
            }
            else if (typeColumn == "24х72")
            {
                sColumn = k * (0.611M * 0.611M);
                fullVolume = 275M;
            }
            else if (typeColumn == "30х72")
            {
                sColumn = k * (0.781M * 0.781M);
                fullVolume = 425M;
            }
            else if (typeColumn == "36х72")
            {
                sColumn = k * (0.934M * 0.934M);
                fullVolume = 625M;
            }
            else if (typeColumn == "42х72")
            {
                sColumn = k * (1.09M * 1.09M);
                fullVolume = 850M;
            }
            else if (typeColumn == "48х72")
            {
                sColumn = k * (1.235M * 1.235M);
                fullVolume = 1050M;
            }
            else
            {
                sColumn = k * (1.6M * 1.6M);
                fullVolume = 1200M;
            }

        }

        public decimal calculateCationCapacityL()
        {
            return 1.2M / Hard;
        }

        public decimal calculateVolumeTC007()
        {
            decimal anionCapasityL = calculateAnionCapasityL();
            decimal cationCapasityL = calculateCationCapacityL();
            return Math.Floor((anionCapasityL * fullVolume) / (anionCapasityL + cationCapasityL));
        }

        public decimal calculateVolumeA202()
        {
            decimal volumeTC007 = calculateVolumeTC007();
            return fullVolume - volumeTC007;
        }

        public decimal calculateFiltroCycle()
        {
            anionCapasityFull = calculateAnionCapasityL() * calculateVolumeA202();
            cationCapasityFull = calculateCationCapacityL() * calculateVolumeTC007();
            return Math.Min(cationCapasityFull, anionCapasityFull);
        }

        public void Capacity()
        {
            // volumeA202 = Math.Floor(0.25M * fullVolume);
            // volumeTC007 = fullVolume - volumeA202;

            cationCapasityL = 1.2M / Hard;

            volumeTC007 = Math.Floor((anionCapasityL * fullVolume) / (anionCapasityL + cationCapasityL));
            volumeA202 = fullVolume - volumeTC007;

            

            if (volumeA202 > 0.7M * fullVolume)
            {
                volumeA202 = Math.Floor(0.7M * fullVolume);
                volumeTC007 = fullVolume - volumeA202;
            }
            else if (volumeTC007 > 0.7M * fullVolume)
            {
                volumeTC007 = Math.Floor(0.7M * fullVolume);
                volumeA202 = fullVolume - volumeTC007;
            }

            anionCapasityFull = anionCapasityL * volumeA202;
            cationCapasityFull = cationCapasityL * volumeTC007;

            filtroCycle = Math.Min(cationCapasityFull, anionCapasityFull);




        }



    }
}
