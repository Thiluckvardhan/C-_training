using System;
using Day5;
using MathsLib;
using ScienceLib;
class Program
{
    static void Main()
    {
        // Day5  
        // Day5 is about class Libraries so i have created a ClassLib folder outside MYCONSOLEAPP Folder 
        // To reffernce the MathsLib.csproj and ScienceLib.csproj first add those csproj files to the MYCONSOLE.sln file. To do that
        // use  the following commands 
        // dotnet sln MYCONSOLEAPP/MYCONSOLEAPP.sln add ClassLib/MathsLib/MathsLib.csproj
        // dotnet sln MYCONSOLEAPP/MYCONSOLEAPP.sln add ClassLib/ScienceLib/ScienceLib.csproj

        // then click on MYCONSOLEAPP.csproj and click add new reffernce and add the two files

        // Calling The MathsLib file
        Maths math=new Maths();
        math.add(5,8);

        // Abstraction Example
        // IndianEmployee inemp=new IndianEmployee();
        // inemp.CalcTax();
        // USEmployee usemp=new USEmployee();
        // usemp.CalcTax();
        
    }
}

