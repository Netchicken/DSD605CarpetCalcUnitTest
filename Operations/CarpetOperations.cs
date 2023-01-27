using Dsd601CarpetCalcAsp.Model;

namespace Dsd601CarpetCalcAsp.Operations

{
    //  carpet.RoomArea = carpet.RoomWidth* carpet.RoomLength;
    //carpet.FinalCost = carpetOperations.TotalInstallCost(carpet);
    //  carpet.Results = "Room area " + carpet.RoomArea + "sqm $" + carpet.FinalCost;


    public class CarpetOperations
    {




        public float CalcRoomArea(float roomWidth, float roomLength)
        {

            float RoomArea = roomWidth * roomLength;

            return RoomArea;
        }

        public string RoomAreaResults(float roomArea, float finalCost)
        {
            string RoomArea = "Room area " + roomArea + "sqm $" + finalCost;
            return RoomArea;
        }


        public Single TotalInstallCost(Carpet carpet)
        {

            carpet.FinalCost += (carpet.CarpetType * carpet.RoomArea);


            if (carpet.HasInstallation)
            {
                carpet.FinalCost += (carpet.InstallationCost * carpet.RoomArea);
            }

            if (carpet.HasUnderlay)
            {
                carpet.FinalCost += (carpet.UnderlayCost * carpet.RoomArea);
            }

            return carpet.FinalCost;
        }

    }
}
