using KoshkinSoft.DenoiserNative;

namespace ApplicationDenoiser.Console
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var denoiser = new Denoiser())
                denoiser.Denoise(args[0]);
        }
    }
}