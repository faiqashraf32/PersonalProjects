using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using variables;
using System.Collections.Generic;

namespace variables
{
    class vars
    { 
        public static string upc;
        public static string x = "D://Program Files(x86)//Sell-listinggenerator//save//";
        //public static string y = "C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//";

            //CHANGE
        public static string y = "C://Users//Faiq//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save";
        //"C://Users//Faiq//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//"  
        //"D:\\Program Files(x86)\\Sell-listinggenerator//save"

        //CHANGE
        StreamWriter loco = new StreamWriter(@"C://Users//Faiq//Documents//Visual Studio 2017//Projects//Sell-listinggenerator//SAVELOCATION.txt//");
        //System.Diagnostics.Process.Start(@loco);
        //File.WriteLine(variables.vars.y);
        //File.Close();
        //File.WriteLine(@"C:Users//Faiq//Documents//Visual Studio 2017//Projects//Sell-listinggenerator//SAVELOCATION.txt");
        
    }
}

