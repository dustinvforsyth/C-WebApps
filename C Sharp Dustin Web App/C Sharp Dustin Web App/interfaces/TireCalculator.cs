using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C_Sharp_Dustin_Web_App.interfaces
{

    public interface ICalcTireSize
    {
        double[] tireSizeCalc(string tireWidth, string aspectRatio, string rimSize);
        double sidewallHeight(double inchSize, double aspectRatio);
        double circumferenceTire(double inchSize);
        double revolutionsPerMile(double circumtire);

    }

    public interface ICompareTire
    {
        double differenceInTires(double tireNew, double tireOld);
        double percentChangeInTires(double currentRevPerMile, double changedRevPerMile);
        double mphChangeInTires(double currentRevPerMile, double changedRevPerMile);
        double changedOdometer(double currentTireDiameter, double newTireDiameter);

    }
    abstract public class TireCalcReq
    {
        public double ConvertmmToInches (string width)
        {
            int Width;
            if (Int32.TryParse(width, out Width));
            double inchConversionWidth = Width / 25.4;
            return inchConversionWidth;
        }
        public double convertToAspectRatio (string aspect)
        {
            int A;
            if (Int32.TryParse(aspect, out A));
            double aspectRatio = A / (100.00);
            return aspectRatio;
        }
        public double SectionHeight (double inchConversionWidth, double aspectRatio)
        {
            double sectionHeight = inchConversionWidth * aspectRatio;
            return sectionHeight;
        }
        public double outsideDiameter (double sectionHeight, string rimSize)
        {
            int RimSize;
            if (Int32.TryParse(rimSize, out RimSize)) ;
            double tireDiameter = (sectionHeight * 2) + RimSize;
            return tireDiameter;
        }
        public double rimSize (string rimSize)
        {
            double RimSize;
            if (double.TryParse(rimSize, out RimSize));
            return RimSize;
        }
        public double circumference (double outsideDiameter)
        {
            double sidewallHeight = outsideDiameter * Math.PI;
            return sidewallHeight;
        }
        public double revolutionPerMile (double circumTire)
        {
            double revPerMile = (5278.8 * 12) / circumTire;
            return revPerMile;
        }


    }

    abstract public class comparingTires
    {
        public double differences (double tireOld, double tireNew)
        {
            double tireDifferences = tireNew - tireOld;
            return tireDifferences;
        }
        public double percentChange (double currentRevPerMile, double changedRevPerMile)
        {
            double percentChange = currentRevPerMile / changedRevPerMile;
            return percentChange;
        }
        public double MilesPerHour(double currentRevPerMile, double changedRevPerMile, int currentMph)
        {
            double mph = (currentRevPerMile / changedRevPerMile) * currentMph;
            return mph;
        }
        public double correctingMiles(double currentTireDiameter, double newTireDiameter)
        {
            int miles = 200;
            double changedPercent = newTireDiameter / currentTireDiameter;
            double correctedMiles = changedPercent * miles;
            return correctedMiles;
        }
    }

    public class TireCalculator : TireCalcReq, ICalcTireSize
    {
        double[] ICalcTireSize.tireSizeCalc(string tireWidth, string aspectRatio, string rimSize)
        {
            double[] totalTireSize = new double[3];
            double calcAspectRatio = base.convertToAspectRatio(aspectRatio);
            totalTireSize[1] = base.ConvertmmToInches(tireWidth);
            double calcSectionHeight = base.SectionHeight(totalTireSize[1], calcAspectRatio);
            totalTireSize[0] = base.outsideDiameter(calcSectionHeight, rimSize);
            totalTireSize[2] = base.rimSize(rimSize);
            return totalTireSize;
            throw new NotImplementedException();
        }

        double ICalcTireSize.sidewallHeight(double inchSize, double aspectRatio)
        {
            Double totalSidewallHeight = 0;
            totalSidewallHeight = base.SectionHeight(inchSize, aspectRatio);
            return totalSidewallHeight;
            throw new NotImplementedException();
        }

        double ICalcTireSize.circumferenceTire(double inchSize)
        {
            double totalCircum = 0;
            totalCircum = base.circumference(inchSize);
            return totalCircum;
            throw new NotImplementedException();
        }

        double ICalcTireSize.revolutionsPerMile(double circumtire)
        {
            double totalRevPerMile = 0;
            totalRevPerMile = base.revolutionPerMile(circumtire);
            return totalRevPerMile;
            throw new NotImplementedException();
        }
    }

    public class CompareTires : comparingTires, ICompareTire
    {
        double ICompareTire.changedOdometer(double currentTireDiameter, double newTireDiameter)
        {
            double changedOdometer = 0;
            changedOdometer = base.correctingMiles(currentTireDiameter, newTireDiameter);
            return changedOdometer;
            throw new NotImplementedException();
        }

        double ICompareTire.differenceInTires(double tireOld, double tireNew)
        {
            double differenceInTires = 0;
            differenceInTires = base.differences(tireOld, tireNew);
            return differenceInTires;
            throw new NotImplementedException();
        }

        double ICompareTire.mphChangeInTires(double currentRevPerMile, double changedRevPerMile)
        {
            int ddlCurrentMph = 65;
            double mphChangeInTires = base.MilesPerHour(currentRevPerMile, changedRevPerMile, ddlCurrentMph);
            return mphChangeInTires;
            throw new NotImplementedException();
        }

        double ICompareTire.percentChangeInTires(double currentRevPerMile, double changedRevPerMile)
        {
            double percentChangerInTires = base.percentChange(currentRevPerMile, changedRevPerMile);
            return percentChangerInTires;
            throw new NotImplementedException();
        }
    }
}