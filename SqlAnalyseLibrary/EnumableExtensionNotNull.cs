using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace System.Linq {
    public static class EnumableExtensionNotNull {
        public static IEnumerable<R> SelectNotNull<T, R>(
            this IEnumerable<T?>? source,
            Func<T, R?> project)
            where T : class
            where R : class {
            if (source is object) {
                foreach (var t in source) {
                    if (t is object) {
                        var r = project(t);
                        if (r is object) {
                            yield return r;
                        }
                    }
                }
            }
        }
    }
}
