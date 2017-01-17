namespace ShipBattleTraining
{
    public static class Functions
    {
        public static ShotTarget SelectShotCoordinates(FieldData[][] battleField, ShotTarget[] previousTargets)
        {

            for (int i = 0; i <10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (FieldData.StatusUnknonw == battleField[i][j])
                    {
                        return new ShotTarget { X = i, Y = j };
                    }
                   
                }
            }

            return new ShotTarget { X = 0, Y = 0 };
        }
    }
}