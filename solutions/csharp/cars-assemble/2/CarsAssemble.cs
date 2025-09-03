static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
      if (speed >= 10)
      {
          return 0.77;
      }
      if (speed >= 9)
      {
          return 0.80;
      }
      if (speed >= 5)
      {
          return 0.90;
      }
      if (speed >= 1)
      {
          return 1.00;
      }

      return 0.0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int carsPerHour = 221 * speed;
        return SuccessRate(speed) * carsPerHour;
    }

    public static int WorkingItemsPerMinute(int speed)
    {

        double carsPerMinuteInt = ProductionRatePerHour(speed) / 60;
        
        return  (int)carsPerMinuteInt;
    }
}
