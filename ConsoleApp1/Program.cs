using System;
using Scriban;
using Scriban.Runtime;

namespace ConsoleApp1
{
    public class MyObjectHasIndexer 
    {
        public string this[string key]
        {
            get
            {
                if (key == "xxx")
                    return "found";

                return null;
            }
        }
    }
    
    class Program
    {
        public static void TestIndexerOnNETwithIndex()
        {
            var myobject = new MyObjectHasIndexer();
            var expected = myobject["xxx"];
            var result = Template.Parse("{{obj['xxx']}}").Render(new ScriptObject() {{"obj", myobject}});
        }
        
        static void Main(string[] args)
        {
            TestIndexerOnNETwithIndex();
            Console.WriteLine("Hello World!");
        }
    }
}