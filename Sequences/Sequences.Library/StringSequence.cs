using System;
using System.Collections.Generic;
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
            return null;
        }

    }
}
