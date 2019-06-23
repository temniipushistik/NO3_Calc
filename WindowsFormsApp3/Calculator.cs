using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public  class Calculator 
    {

        private decimal NO3;
        private decimal SO4;
        private decimal Hard;
        private bool V250;
        private decimal bypass;
        private decimal salt;
        private decimal fullVolume;
        private decimal sumSalt;
        private decimal volumeTC007;
        private decimal volumeA202;


        public void SetData(decimal NO3, decimal SO4, decimal Hard, bool V250, decimal fullVolume)
        {
            this.NO3 = NO3;
            this.SO4 = SO4;
            this.Hard = Hard;
            this.V250 = V250;
            this.fullVolume = fullVolume;

        }

        


        /// <summary>
        /// Емкость одного литра катионита
        /// </summary>
        /// <returns></returns>
        public decimal CationCapasityL()
        {
            return 1.2M / this.Hard;
        }
        public decimal SumAnion()
        {
            return this.NO3 + this.SO4;
        }




        /// <summary>
        /// Счиаем линейную скорость на анионе
        /// </summary>
        /// <returns>скорость на анионе </returns>
        /// 
        public int VAnion()
        {

            if (SumAnion() <= 50M)
            {
                return 25;
            }
            else if (SumAnion() > 50M && SumAnion() <= 100M)
            {
                return 20;
            }
            else if (SumAnion() > 100M && SumAnion() <= 150M)
            {
                return 15;
            }
            else if (SumAnion() > 150M && SumAnion() <= 200M)
            {
                return 12;
            }
            else
            {
                return 10;
            }

        }
        /// <summary>
        /// Счиаем линейную скорость на катионе
        /// </summary>
        /// <returns>скорость на катионе </returns>
        /// 
        public int VCation()
        {
            //катионы по жесткости
            if (this.Hard <= 5)
            {
                return 25; //назначаем линейные скорости
            }
            else if (this.Hard > 5 & this.Hard <= 10)
            {
                return 20;
            }
            else if (this.Hard > 10 & this.Hard <= 14)
            {
                return 15;
            }
            else if (this.Hard > 14 & this.Hard <= 18)
            {
                return 12;
            }
            else
            {
                return 10;
            }
        }

        /// <summary>
        /// выбираем реальную линейную скорость по наименьшей 
        /// </summary>
        /// <returns>получаем реальную линейную скорость </returns>
        public int VReal()
        {
            return Math.Min(VCation(), VAnion());

        }


        /// <summary>
        /// считаем отношение нитратов к сумме сульфатом и нитратов в мг-экв/л
        /// </summary>
        /// <returns>отношение в мг-экв/л</returns>
        /// 
        public decimal DevideNO3SO4()
        {
            return (this.NO3 / 62) / (this.NO3 / 62 + this.SO4 / 48);

        }

        /// <summary>
        /// определяем по графику проскок по нитратам для 125г NaCl на л
        /// </summary>
        /// <returns>процент по проскоку </returns>
        public decimal Bypass125()
        {
                       
            if (DevideNO3SO4() > 0.8M && DevideNO3SO4() <= 1.0M)
            {
                return (-5M * DevideNO3SO4() + 17M) * this.NO3 * 0.01M;
            }

            else if (DevideNO3SO4() > 0.6M && DevideNO3SO4() <= 0.8M)
            {
                return (-22.5M * DevideNO3SO4() + 31M) * this.NO3 * 0.01M;
            }


            else if (DevideNO3SO4() > 0.5M && DevideNO3SO4() <= 0.6M)
            {
                return (-35M * DevideNO3SO4() + 38.5M) * this.NO3 * 0.01M;
            }


            else if (DevideNO3SO4() > 0.4M && DevideNO3SO4() <= 0.5M)
            {
                return (-39M * DevideNO3SO4() + 40M) * this.NO3 * 0.01M;
            }



            else if (DevideNO3SO4() > 0.3M && DevideNO3SO4() <= 0.4M)
            {
                return (-47M * DevideNO3SO4() + 43.6M) * this.NO3 * 0.01M;
            }


            else if (DevideNO3SO4() > 0.2M && DevideNO3SO4() <= 0.3M)
            {
                return (-65M * DevideNO3SO4() + 49M) * this.NO3 * 0.01M;
            }


            else if (DevideNO3SO4() > 0M && DevideNO3SO4() <= 0.2M)
            {
                return (-100M * DevideNO3SO4() + 56M) * this.NO3 * 0.01M;
            }
            else
            {
                return this.NO3;
            }
        }


        /// <summary>
        /// определяем по графику проскок по нитратам для 250г NaCl на л
        /// </summary>
        /// <returns>процент по проскоку </returns>

        public decimal Bypass250()
        {

            if (DevideNO3SO4() > 0.8M && DevideNO3SO4() <= 1.0M)
            {
                return (-2.5M * DevideNO3SO4() + 11.5M) * this.NO3 * 0.01M;
            }
            else if (DevideNO3SO4() > 0.6M && DevideNO3SO4() <= 0.8M)
            {
                return (-7.5M * DevideNO3SO4() + 15.5M) * this.NO3 * 0.01M;
            }
            else if (DevideNO3SO4() > 0.4M && DevideNO3SO4() <= 0.6M)
            {
                return (-25M * DevideNO3SO4() + 26M) * this.NO3 * 0.01M;
            }
            else if (DevideNO3SO4() > 0.2M && DevideNO3SO4() <= 0.4M)
            {
                return (-45M * DevideNO3SO4() + 34M) * this.NO3 * 0.01M;
            }
            else if (DevideNO3SO4() > 0M && DevideNO3SO4() <= 0.2M)
            {
                return (-75M * DevideNO3SO4() + 40M) * this.NO3 * 0.01M;
            }
            else
            {
                return this.NO3;
            }

        }

        /// <summary>
        /// Считаем емкость смолы в мг-экв/л при 125г/л
        /// </summary>
        /// <returns>емкость при 125г/л</returns>

        public decimal AnionCapasity125()
        {

            if (DevideNO3SO4() > 0.8M && DevideNO3SO4() <= 1.0M)
            {
                return (0.6M * DevideNO3SO4() + 0.01M);
            }
            else if (DevideNO3SO4() > 0.6M && DevideNO3SO4() <= 0.8M)
            {
                return (0.5M * DevideNO3SO4() + 0.1M);
            }
            else if (DevideNO3SO4() > 0.4M && DevideNO3SO4() <= 0.6M)
            {
                return (0.3M * DevideNO3SO4() + 0.23M);
            }


            else if (DevideNO3SO4() > 0.2M && DevideNO3SO4() <= 0.4M)
            {
                return (0.2M * DevideNO3SO4() + 0.26M);
            }

            else if (DevideNO3SO4() > 0.1M && DevideNO3SO4() <= 0.2M)
            {
                return (0.1M * DevideNO3SO4() + 0.28M);
            }

            else if (DevideNO3SO4() > 0M && DevideNO3SO4() <= 0.1M)
            {
                return 0.29M;
            }


            else
            {
                return 0;
            }
            
        }


        public decimal AnionCapasity250()
        {


            if (DevideNO3SO4() > 0.8M && DevideNO3SO4() <= 1.0M)
            {
                return (0.65M * DevideNO3SO4() + 0.03M);
            }
            else if (DevideNO3SO4() > 0.6M && DevideNO3SO4() <= 0.8M)
            {
                return (0.3M * DevideNO3SO4() + 0.32M);
            }
            else if (DevideNO3SO4() > 0.4M && DevideNO3SO4() <= 0.6M)
            {
                return (0.25M * DevideNO3SO4() + 0.35M);
            }

            else if (DevideNO3SO4() > 0.1M && DevideNO3SO4() <= 0.4M)
            {
                return (0.1M * DevideNO3SO4() + 0.4M);
            }

            else if (DevideNO3SO4() > 0M && DevideNO3SO4() <= 0.1M)
            {
                return (0.05M * DevideNO3SO4() + 0.415M);
            }

            
            else
            {
                return 0;
            }

        }



        /// <summary>
        /// работаем с выбором 125 или 250
        /// </summary>
        /// <returns>возвращаем емкость смолы взависимости от проскока</returns>

        public decimal AnionCapasitySelected()

        //работаем с выбором 125 или 250
        {
            if (V250 == false)
            {
                bypass = Bypass125();
                salt = 0.125M;
                
                                
                return (AnionCapasity125() * 0.9M) / ((this.NO3 - bypass) / 62);

            }
            else
            {
                bypass = Bypass250();
                salt = 0.250M;
               
                
                return (AnionCapasity250() * 0.9M) / ((this.NO3 - bypass) / 62);
            }
            
        }


        /// <summary>
        /// Считаем емкость смеси смол, получаем фильтроцикл смеси смол.
        /// sumSalt определяет сколько кг соли нужно на регенерацию смеси смол
        /// 
        /// </summary>
        public decimal Capacity()
        {

            volumeTC007 = Math.Floor((AnionCapasitySelected() * fullVolume) / (AnionCapasitySelected() + CationCapasityL()));//объем смолы 007
            volumeA202 = fullVolume - volumeTC007; //объем смолы 202

            // MessageBox.Show($"катионит {volumeTC007} , анионит {volumeA202}", "Объемы смол");

            //В составе смеси смол не может быть меньше, чем 30% одной из составляющих:

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
            

            decimal anionCapasityFull = AnionCapasitySelected() * volumeA202; //емкость всего объема анионита
            decimal cationCapasityFull = CationCapasityL() * volumeTC007; //емкость всего объема катионита

            
            sumSalt = (salt * volumeA202) + (0.12M * volumeTC007);

            return Math.Min(cationCapasityFull, anionCapasityFull);
            


        }
        public decimal GetSumSalt()
        {
            return sumSalt;
        }

        public decimal GetBypass()
        {
            return bypass;
        }

        public decimal GetVolumeA202()
        {
            return volumeA202;
        }

        public decimal GetVolumeTC007()
        {
            return volumeTC007;
        }


    }
}
