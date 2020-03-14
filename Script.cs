using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    public class Script
    {
        private static List<ScriptItem> _script = new List<ScriptItem>();

        public static List<ScriptItem> GetScript()
        {
            return _script;
        }

        public static void AddToScript(ScriptItem scriptItem)
        {
            _script.Add(scriptItem);
        }
    }
    public class ScriptItem
    {
        public string input { get; set; }
        public DateTimeOffset delay { get; set; }
        public string keycode { get; set; }
        public uint repeat { get; set; }
        public int[] position { get; set; }
    }
}
