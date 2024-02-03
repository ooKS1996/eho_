
// See https://aka.ms/new-console-template for more information
using eho.Services;
using System;

DateTime now = DateTime.Now;
int year = now.Year;
string[] cmds = Array.Empty<string>();
if (args.Length > 0)
{
    cmds = Environment.GetCommandLineArgs();
}


string option = "NONE";
string eho = "恵方の取得に失敗しました。";
EhoController ehoAnalyzer = new EhoController();

if (cmds != null && cmds.Length >= 1)
{


    for(int i = 1; i < cmds.Length; i++)
    {
        string cmd = cmds[i];
        if (int.TryParse(cmd, out int num))
        {
            year = num;
        }
        else
        {
            option = cmd.Replace('/', '_');
        }
    }

}
//Console.WriteLine(year);
//Console.WriteLine(option);
Console.WriteLine(ehoAnalyzer.GetEho(year,option));



