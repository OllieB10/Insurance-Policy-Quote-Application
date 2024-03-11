
using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public class DriverAgeTable : IDriverAgeTable
    {
        #region Driver Age Table

        public Dictionary<string, decimal> GetDriverAge()
        {
            Dictionary<string, decimal> driverAgeTable = new Dictionary<string, decimal>
            {
               {$"{NCB.Zero}{DriverAges.TwentyFiveToTwentyNine}", 1.20M},
               {$"{NCB.Zero}{DriverAges.ThirtyToThirtyFour}", 1.20M},
               {$"{NCB.Zero}{DriverAges.ThirtyFiveToThirtyNine}", 1.20M},
               {$"{NCB.Zero}{DriverAges.FortyToFortyFour}", 1.20M},
               {$"{NCB.Zero}{DriverAges.FortyFiveToFortyNine}", 1.20M},
               {$"{NCB.Zero}{DriverAges.FiftyToSixtyNine}", 1.20M},
               {$"{NCB.Zero}{DriverAges.SeventyPlus}", 1.20M},
               {$"{NCB.One}{DriverAges.TwentyFiveToTwentyNine}", 1.20M},
               {$"{NCB.One}{DriverAges.ThirtyToThirtyFour}", 1.20M},
               {$"{NCB.One}{DriverAges.ThirtyFiveToThirtyNine}", 1.20M},
               {$"{NCB.One}{DriverAges.FortyToFortyFour}", 1.20M},
               {$"{NCB.One}{DriverAges.FortyFiveToFortyNine}", 1.20M},
               {$"{NCB.One}{DriverAges.FiftyToSixtyNine}", 1.20M},
               {$"{NCB.One}{DriverAges.SeventyPlus}", 1.20M},
               {$"{NCB.Two}{DriverAges.TwentyFiveToTwentyNine}", 1.20M},
               {$"{NCB.Two}{DriverAges.ThirtyToThirtyFour}", 1.20M},
               {$"{NCB.Two}{DriverAges.ThirtyFiveToThirtyNine}", 1.20M},
               {$"{NCB.Two}{DriverAges.FortyToFortyFour}", 1.20M},
               {$"{NCB.Two}{DriverAges.FortyFiveToFortyNine}", 1.20M},
               {$"{NCB.Two}{DriverAges.FiftyToSixtyNine}", 1.20M},
               {$"{NCB.Two}{DriverAges.SeventyPlus}", 1.20M},
               {$"{NCB.Three}{DriverAges.TwentyFiveToTwentyNine}", 1.20M},
               {$"{NCB.Three}{DriverAges.ThirtyToThirtyFour}", 1.20M},
               {$"{NCB.Three}{DriverAges.ThirtyFiveToThirtyNine}", 1.20M},
               {$"{NCB.Three}{DriverAges.FortyToFortyFour}", 1.20M},
               {$"{NCB.Three}{DriverAges.FortyFiveToFortyNine}", 1.20M},
               {$"{NCB.Three}{DriverAges.FiftyToSixtyNine}", 1.20M},
               {$"{NCB.Three}{DriverAges.SeventyPlus}", 1.20M},
               {$"{NCB.Four}{DriverAges.TwentyFiveToTwentyNine}", 1.20M},
               {$"{NCB.Four}{DriverAges.ThirtyToThirtyFour}", 1.20M},
               {$"{NCB.Four}{DriverAges.ThirtyFiveToThirtyNine}", 1.20M},
               {$"{NCB.Four}{DriverAges.FortyToFortyFour}", 1.20M},
               {$"{NCB.Four}{DriverAges.FortyFiveToFortyNine}", 1.20M},
               {$"{NCB.Four}{DriverAges.FiftyToSixtyNine}", 1.20M},
               {$"{NCB.Four}{DriverAges.SeventyPlus}", 1.20M},
               {$"{NCB.Five}{DriverAges.TwentyFiveToTwentyNine}", 1.20M},
               {$"{NCB.Five}{DriverAges.ThirtyToThirtyFour}", 1.20M},
               {$"{NCB.Five}{DriverAges.ThirtyFiveToThirtyNine}", 1.20M},
               {$"{NCB.Five}{DriverAges.FortyToFortyFour}", 1.20M},
               {$"{NCB.Five}{DriverAges.FortyFiveToFortyNine}", 1.20M},
               {$"{NCB.Five}{DriverAges.FiftyToSixtyNine}", 1.20M},
               {$"{NCB.Five}{DriverAges.SeventyPlus}", 1.20M},
               {$"{NCB.SixPlus}{DriverAges.TwentyFiveToTwentyNine}", 1.20M},
               {$"{NCB.SixPlus}{DriverAges.ThirtyToThirtyFour}", 1.20M},
               {$"{NCB.SixPlus}{DriverAges.ThirtyFiveToThirtyNine}", 1.20M},
               {$"{NCB.SixPlus}{DriverAges.FortyToFortyFour}", 1.20M},
               {$"{NCB.SixPlus}{DriverAges.FortyFiveToFortyNine}", 1.20M},
               {$"{NCB.SixPlus}{DriverAges.FiftyToSixtyNine}", 1.20M},
               {$"{NCB.SixPlus}{DriverAges.SeventyPlus}", 1.20M},
               {$"{NCB.NewBadge}{DriverAges.TwentyFiveToTwentyNine}", 1.20M},
               {$"{NCB.NewBadge}{DriverAges.ThirtyToThirtyFour}", 1.20M},
               {$"{NCB.NewBadge}{DriverAges.ThirtyFiveToThirtyNine}", 1.20M},
               {$"{NCB.NewBadge}{DriverAges.FortyToFortyFour}", 1.20M},
               {$"{NCB.NewBadge}{DriverAges.FortyFiveToFortyNine}", 1.20M},
               {$"{NCB.NewBadge}{DriverAges.FiftyToSixtyNine}", 1.20M},
               {$"{NCB.NewBadge}{DriverAges.SeventyPlus}", 1.20M},
            };

            return driverAgeTable;
        }

        #endregion
    }
}
