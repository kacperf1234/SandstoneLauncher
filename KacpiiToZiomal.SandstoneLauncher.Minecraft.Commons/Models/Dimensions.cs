namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models
{
    public class Dimensions
    {
        public Dimensions()
        {
        }

        public Dimensions(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}