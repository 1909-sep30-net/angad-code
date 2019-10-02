using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sequences.Library {
    public class StringSequence {

        private readonly List<String> _list = new List<string>();

        public void Add(string item) {
            _list.Add(item);
        }

        public void Remove(string item) {
            _list.Remove(item);
        }

        public string this[int index] {
            get => _list[index];
            set => _list[index] = value;
        }

        public string LongestString() {
            string a;
            int b = 0;
            for(int i = 1; i < _list.Count; i++) {
                if(_list[i].Length > _list[i-1].Length) {
                    a = _list[i];
                    b = i;
                }
            }
            return _list[b];
            //Can rather be done with foreach or LINQ

            /*var maxLength = _list.Max(s => s.Length);
            return _list.First(s => s.Length == maxLength);*/

        }

    }
}
