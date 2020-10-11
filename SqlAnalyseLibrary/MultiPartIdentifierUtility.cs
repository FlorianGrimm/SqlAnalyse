using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Collections.Generic;
using System.Linq;

namespace SqlAnalyseLibrary {
    public static class MultiPartIdentifierUtility {
        public static (MultiPartIdentifier? rest, Identifier? last) SplitLast(MultiPartIdentifier? multiPartIdentifier) {
            if (multiPartIdentifier is object) {
                var identifiers = multiPartIdentifier.Identifiers;
                if (identifiers.Count >= 1) {
                    var last = identifiers[identifiers.Count - 1];
                    if (identifiers.Count == 1) {
                        return (null, last);
                    } else { 
                        var rest = new MultiPartIdentifier();
                        for (int idx = 0; idx < identifiers.Count - 1; idx++) {
                            rest.Identifiers.Add(identifiers[idx]);
                        }
                        return (rest, last);
                    }
                } 
            }
            return (null,null);
        }
    }
}