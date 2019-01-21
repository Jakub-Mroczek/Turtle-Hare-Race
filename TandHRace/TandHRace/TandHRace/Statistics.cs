using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using IronPython.Runtime;

namespace TandHRace
{
    class Statistics
    {
        public int HareWins;
        public int TurtleWins;
        public int Draws;

        public Statistics()
        {
            HareWins = 0;
            TurtleWins = 0;
            Draws = 0;
        }
        public void SaveStatistics()
        {
            //Run the python file
            #region
            ScriptRuntimeSetup setup = Python.CreateRuntimeSetup(null);
            ScriptRuntime runtime = new ScriptRuntime(setup);
            ScriptEngine engine = Python.GetEngine(runtime);
            ScriptSource source = engine.CreateScriptSourceFromFile("savestats.py");
            ScriptScope scope = engine.CreateScope();
            List<String> argv = new List<String>();
            #endregion
            argv.Add(HareWins.ToString());
            argv.Add(TurtleWins.ToString());
            argv.Add(Draws.ToString());
            engine.GetSysModule().SetVariable("argv", argv);
            source.Execute(scope);
        }
        public Dictionary<string, int>Display()
        {
            Dictionary<string, int> Stats = new Dictionary<string, int>
            {
                ["HARE WIN"] = HareWins,
                ["TURTLE WIN"] = TurtleWins,
                ["DRAWS"] = Draws
            };
            return Stats;
        }
    }
}
