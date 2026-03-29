class Program
{
    static void Main(string[] args)
    {
        HaloGeneric hg = new HaloGeneric();
        hg.SapaUser<string>("nuraini");

        DataGeneric<string> dataUser = new DataGeneric<string>("103022400072");
        dataUser.PrintData();
    }
}