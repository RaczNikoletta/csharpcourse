using System;
static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
                if(speed==0) return 0;
        else if(speed>0 && speed<5) return 1;
        else if (speed>4 && speed <9) return 0.9;
        else if(speed==9) return 0.8;
        else if(speed==10) return 0.77;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }
    public static int WorkingItemsPerMinute(int speed)
    {
        return Convert.ToInt32(ProductionRatePerHour(speed))/60;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
