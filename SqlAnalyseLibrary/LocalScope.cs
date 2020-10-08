using System;
using System.Collections.Generic;
using System.Text;

namespace SqlAnalyseLibrary {
    public class LocalScope : BaseScope {
        public LocalScope(LocalScope parent)
        {
            this.Parent = parent;
        }
        public LocalScope Parent { get; }
    }
}
