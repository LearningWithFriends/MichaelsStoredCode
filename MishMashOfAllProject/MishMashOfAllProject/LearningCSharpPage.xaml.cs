using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using System.Threading;
using MishMashOfAllProject;


namespace MishMashOfAllProject
{
    /// <summary>
    /// Interaction logic for LearningCSharpPage.xaml
    /// </summary>
    public partial class LearningCSharpPage : Window
    {
        public LearningCSharpPage()
        {
            #region Don't Change This

            InitializeComponent();
            this.WindowState = WindowState.Minimized;
            #endregion
            // Add logic here to use 
            MyTimer t = new MyTimer();
            t.ATimer(new CoffeMaker());
            t.ATimer(new Toaster());
        }

    }
    public class MyTimer
    {

        public void ATimer(IPluggable pluggable)
        {
            Console.WriteLine(pluggable.Grounded);
            Console.WriteLine(pluggable.Voltage);
            return;
        }

    }

}
public class TuplesShit
{
    private string _value;
    public string name
    {
        get { return _value; }
        set { _value = value; }
    }

    char offsite = 'X';
    int jobnum = 17116;
    int hours = 8;

    //var previous = new Tuple<char, int, int>(offsite, jobnum, hours);
    //Console.WriteLine(previous.Item1);
    //    Console.WriteLine(previous.Item2);
    //    Console.WriteLine(previous.Item3);
}

public class Stuffs : IWriter, IMyInterfaceLearning
{
    public void TextWriter(string s)
    {
        Console.WriteLine(s);
    }
    public string TextReader(string s)
    {
        string m = Console.ReadLine();
        return m;
    }
    public void Stuff() { return; }
    public void CWWriter(string s)
    {
        Console.WriteLine(s);
    }



}
public interface IPluggable

{
    int Voltage { get; }
    string PlugType { get; }
    bool Grounded { get; }

}
public class CoffeMaker : IPluggable
{
    private int _Voltage = 120;
    private string _PlugType = "NEMA20";
    private bool _Grounded = true;
    public int Voltage { get { return this._Voltage; } }
    public string PlugType { get { return this._PlugType; } }
    public bool Grounded { get { return this._Grounded; } }
}
public class Toaster : IPluggable
{
    private int _Voltage = 15;
    private string _PlugType = "ungrounded Nema";
    private bool _Grounded = false;
    public int Voltage { get { return this._Voltage; } }
    public string PlugType { get { return this._PlugType; } }
    public bool Grounded { get { return this._Grounded; } }
}



