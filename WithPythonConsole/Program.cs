using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace WithPythonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Script engine.
            ScriptEngine engine = Python.CreateEngine();
            //Create Script scope
            ScriptScope scope = engine.CreateScope();

            //Set variable in scope
            scope.SetVariable("n", "박상현");
            scope.SetVariable("p", "010-123-4566");

            //Create scriptsouce
            ScriptSource source = engine.CreateScriptSourceFromString(
                @"
class NameCard :
    name = ''
    phone = ''

    def __init__(self, name, phone) : 
        self.name = name 
        self.phone = phone

    def printNameCard(self) : 
        print self.name + ', ' + self.phone

NameCard(n, p)
");
            dynamic result = source.Execute(scope);
            result.printNameCard();

            Console.WriteLine("{0}, {1}", result.name, result.phone);
        }
    }
}
