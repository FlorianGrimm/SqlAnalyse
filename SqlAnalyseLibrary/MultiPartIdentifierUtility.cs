using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SqlAnalyseLibrary {
    public static class MultiPartIdentifierUtility {
        public static MultiPartIdentifier Create(params string[] names) {
            var result = new MultiPartIdentifier();
            foreach (var name in names) {
                result.Identifiers.Add(new Identifier() { Value = name, QuoteType = QuoteType.SquareBracket });
            }
            return result;
        }

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
            return (null, null);
        }

        public static string ConvertToDebugString(MultiPartIdentifier? name) 
            =>(name is null || name.Count==0) ? string.Empty : string.Join("/", name.Identifiers.Select(i => i.Value));

        public static bool IsEqual(MultiPartIdentifier nameA, MultiPartIdentifier nameB) {
            if (nameA.Count == nameB.Count) {
                for (int idx = 0; idx < nameA.Count; idx++) {
                    if (string.Equals(nameA.Identifiers[idx].Value, nameB.Identifiers[idx].Value, System.StringComparison.OrdinalIgnoreCase)) {
                        // may be equal
                    } else {
                        // not equal
                        return false;
                    }
                }
                // finally equal
                return true;
            } else {
                // not equal
                return false;
            }
        }

        public static bool IsEqual(MultiPartIdentifier nameA, MultiPartIdentifier nameB, MultiPartIdentifier nameBase) {
            var countA = nameA.Count;
            var countB = nameB.Count;
            var countBase = nameBase.Count;
            if (countA <= (countB + countBase)) {
                var offsetB = System.Math.Max(0, countA - countB);
                for (int idx = 0; idx < countA; idx++) {
                    var valueA = nameA.Identifiers[idx].Value;
                    var valueB = (idx <= offsetB)
                        ? nameBase.Identifiers[idx].Value
                        : nameB.Identifiers[idx - offsetB].Value;
                    if (string.Equals(valueA, valueB, System.StringComparison.OrdinalIgnoreCase)) {
                        // may be equal
                    } else {
                        // not equal
                        return false;
                    }
                }
                // finally equal
                return true;
            } else {
                return false;
            }
        }
    }
}