using System.ComponentModel.Design;
using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        //Query 1
        // Console.WriteLine("Query 1");
        // File.ReadAllLines("data.csv")
        // .Where(t=>t.Contains("Iran")&& t.Contains("Healthy life expectancy (HALE) at birth (years)")
        // && t.Contains("Both"))
        // .Select(y=>{
        //     //string[]splits = y.Split(',');
        //     //int year = int.Parse(y);
        //     //double rated = double.Parse(splits[6]);
        //     //double values = double.Parse(splits[5]);
        //     //string countery= splits[2];
        //     //string coninent = splits[3];
        //     //return (Continents:coninent,countery: countery, Year:year, rates: rated, Values:values);
        //     var x=Data.Parse(y);
        //     return x;
        // }).OrderBy(v=>v.Value).ToList().
        // ForEach(l=>System.Console.WriteLine(l));
        //
        //
        Console.WriteLine();
        Console.WriteLine("Query 2");

        //Query 2
        var x =File.ReadAllLines("data.csv");
        x
        .Where(t=>t.Contains("Iran")&& t.Contains("Healthy life expectancy (HALE) at birth (years)")
        && t.Contains("Both"))
        .Select(y=>{
            Data x=Data.Parse(y);
            return x;
        });

        //x.Join(x,
        //(datas)=>(datas.Country,datas.Value),
        //(d5)=>(d5.Country,d5.Value),
        //(datas,d3)=>(country:datas.Country,r1 : datas.Value, r2:d3.Value, year1:datas.Year, year2:d3.Year)).
        //GroupBy(y=>y.country).
        //Select(t=>{
        //    var xx = t.MaxBy(g=>Math.Abs(g.r2-g.r1));
        //    return (country: t.Key, y: xx.year1,y2:xx.year2,different : Math.Abs(xx.r2 - xx.r1));
        //}).ToList().ForEach(f=>System.Console.WriteLine(f));
        //
        //
        Console.WriteLine();

        //Query 3
        Console.WriteLine("Query 3");
        //
        x.Skip(1).Where(u=>u.Contains("Healthy life expectancy (HALE) at birth (years)")&&
        u.Contains("Both")).Select(t=>{
            var xx = t.Split(',');
            return (country: xx[3].ToLower(), Year: int.Parse(xx[1]), value: double.Parse(xx[5]));

        });
        //هیچ یک از اون قسمت های فایلی که  joinمصحح گرامی اینجا توی 
        //کنم اینارو؟؟ joinباید میخوند رو نمیاره .خب من باید چه طوری 
        
        //read.Join(read);
        
        //
        Console.WriteLine();

        //Query 4
        Console.WriteLine("Query 4");
        //
        //
        Console.WriteLine();

    }
}
