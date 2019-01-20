using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rondAlgo
{
    public class Calculation
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<Rond> Calculate(int length, int width, int radius, int minTopDistance, int minLeftDistance, int minMiddleDistance)
        {
            //višino in širino zmanjšamo za odmik od robov; zamika se upošteva pri zapisu koordinat
            int _length = length - 2 * minLeftDistance;
            int _width = width - 2 * minTopDistance;

            //izračun postavitve po  
            List<Rond> allRondRectangular = new List<Rond>();
            List<Rond> allRondTriangular = new List<Rond>();

            #region Rectangular Pattern
            //Rectangular Pattern - postavitev ena ob drugi

            int freeSpaceX = radius * 2;
            int freeSpaceY = radius * 2;
            int[] rowAndPosition = { 0, 0 };

            //z while zanko zlagamo rondelice po vrstah od spodaj navzgor dokler je dovolj prostora
            while (freeSpaceY <= _width)
            {
                rowAndPosition[0] += 1;
                while (freeSpaceX <= _length)
                {
                    rowAndPosition[1] += 1;
                    allRondRectangular.Add(new Rond(freeSpaceX - radius + minLeftDistance, freeSpaceY - radius + minTopDistance, rowAndPosition[0], rowAndPosition[1])); //shranimo x koordinate
                    freeSpaceX = freeSpaceX + minMiddleDistance + radius * 2;
                }
                rowAndPosition[1] = 0;
                freeSpaceX = radius * 2;
                freeSpaceY = freeSpaceY + minMiddleDistance + radius * 2;
            }

            #endregion

            #region Triangular Pattern
            //Triangular Pattern - postavitev ena ob drugi, lihe vrste zamaknjene

            List<int> allRond2 = new List<int>();

            freeSpaceX = radius * 2;
            freeSpaceY = radius * 2;
            rowAndPosition = new int[] { 0, 0 };

            //razdalja mora biti deljiva z 2, da pomaknemo drugo vrsto na sredino
            int minMiddleDistanceX = minMiddleDistance;
            if (minMiddleDistanceX % 2 == 1)
                minMiddleDistanceX += 1;

            //izračun razdalje med vrstami v y smeri, zaokrožimo na mm navzgor
            int MiddleDistanceY = Convert.ToInt32(Math.Ceiling(Math.Sqrt(3) * (radius + minMiddleDistanceX / 2)));

            //z while zanko zlagamo rondelice po vrstah od spodaj navzgor dokler je dovolj prostora, lihe vrste so zamaknjene na sredino spodnjih
            int row = 0;
            while (freeSpaceY <= _width)
            {
                rowAndPosition[0] += 1;
                while (freeSpaceX <= _length)
                {
                    rowAndPosition[1] += 1;
                    allRondTriangular.Add(new Rond(freeSpaceX - radius + minLeftDistance, freeSpaceY - radius + minTopDistance, rowAndPosition[0], rowAndPosition[1])); //shranimo x koordinate
                    freeSpaceX = freeSpaceX + minMiddleDistanceX + radius * 2;
                }
                rowAndPosition[1] = 0;
                freeSpaceY = freeSpaceY + MiddleDistanceY;

                //korekcija zamika v x lihe vrste
                if (rowAndPosition[0] % 2 != 0)  //korekcija zamika v x lihe vrste
                    freeSpaceX = radius * 3 + minMiddleDistanceX / 2;
                else
                    freeSpaceX = radius * 2;
            }

            #endregion

            //vrne optimalno opcijo od izbranih dveh
            log.Info("Rezultat po RondRectangular opciji: " + allRondRectangular.Count());
            log.Info("Rezultat po RondTriangular opciji: " + allRondTriangular.Count());
            if (allRondRectangular.Count() >= allRondTriangular.Count())
            { 
                log.Info("RondRectangular vrnjena kot optimalna");
                return allRondRectangular;
            }
            else
            {
                log.Info("RondTriangular vrnjena kot optimalna");
                return allRondTriangular;
            }
        }
    }
}
