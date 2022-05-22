public class Solution 
{
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        Sort(boxTypes);
        
        int truckLoad = 0;
        int truckBoxes = 0;
        bool truckIsLoaded = false;
        for (int i = 0; i < boxTypes.Length; ++i)
        {
            for (int j = 0; j < boxTypes[i][0]; ++j)
            {
                if (truckBoxes < truckSize)
                {
                    truckLoad += boxTypes[i][1];
                    truckBoxes++;
                }
                else
                {
                    break;
                    truckIsLoaded = true;
                }
            }
            
            if (truckIsLoaded)
            {
                return truckLoad;
            }
        }
        
        return truckLoad;
    }
    
    private void Sort(int[][] boxTypes)
    {
        for (int i = 1; i < boxTypes.Length; ++i)
        {
            for (int j = i - 1; j >= 0; --j)
            {
                if (boxTypes[j][1] < boxTypes[j + 1][1])
                {
                    var tmp = boxTypes[j];
                    boxTypes[j] = boxTypes[j + 1];
                    boxTypes[j + 1] = tmp;
                }
                else
                {
                    break;
                }
            }
        }
    }
}