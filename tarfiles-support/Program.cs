using System.Formats.Tar;


public static class Program
{

    const string SOURCE = "../../../Source";
    const string TARFILEPATH = "../../../Destination/sample.tar";
    const string DECOMPRESSFOLDER = "../../../DecompressSource";

    public async static Task Main(string[] args)
    {
        await CompressTar();
        await DeCompressTar();
    }

    public static async Task CompressTar()
    {
        if (!File.Exists(TARFILEPATH))
        {
            await TarFile.CreateFromDirectoryAsync(SOURCE, TARFILEPATH, false, default).ConfigureAwait(false);
            Console.WriteLine("compressed succcessfully.");
        }

    }

    public static async Task DeCompressTar()
    {
        await TarFile.ExtractToDirectoryAsync(TARFILEPATH, DECOMPRESSFOLDER, false, default).ConfigureAwait(false);
        Console.WriteLine("decompressed succcessfully.");
    }
}


