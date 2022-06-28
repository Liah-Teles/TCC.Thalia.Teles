using System.Globalization;
using System.Text.RegularExpressions;

namespace TCC.Thalia.Teles.App;

static class Program
{
    [STAThread]
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginTela());
    }
}