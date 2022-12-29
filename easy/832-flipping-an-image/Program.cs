public class Solution 
{
    public int[][] FlipAndInvertImage(int[][] image) 
    {
        for (int i = 0; i < image.Length; ++i)
        {
            for (int j = 0; j <= (image[i].Length - 1) / 2; ++j)
            {
                int temp = image[i][j];
                image[i][j] = image[i][image[i].Length - 1 - j] ^ 1;

                image[i][image[i].Length - 1 - j] = temp ^ 1;
            }
        }

        return image;
    }
}
