using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroMoney.Utils
{
    /// <summary>
    /// https://stackoverflow.com/questions/7252186/switch-case-on-type-c-sharp
    /// </summary>
    public class TypeSwitch
    {
        Dictionary<Type, Action<object>> matches = new Dictionary<Type, Action<object>>();
        public TypeSwitch Case<T>(Action<T> action) { matches.Add(typeof(T), (x) => action((T)x)); return this; } 
        public void Switch(object x) { matches[x.GetType()](x); }
    }
}