using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public enum WidgetArguments
        {
            IsShowCase,
            IsOfficeStandard,
            IsCobroke,
            SubmitSmartLeads,
            PropertyStatus
        };

        private class A
        {
        }

        class B : A
        {
            public class C
            {
            }

            public static string getname<T>()
            {
                return typeof (T).FullName;
            }
        }

        public class D
        {
            public int b;
            public int c;
        }

        private static IEnumerable<FieldInfo> GetPublicFields(Type type)
        {
            var findMembers = type.FindMembers(MemberTypes.Field, BindingFlags.Public | BindingFlags.Instance, (info, criteria) => true, null);
            var publicFields = findMembers.Cast<FieldInfo>();
            return publicFields;
        }

        static void Main(string[] args)
        {
            Trace.WriteLine("");

            var f = GetPublicFields(typeof(D));
            foreach (var ff in f)
            {
                if (f.GetType() is int)
                { }
            }
            Trace.WriteLine(B.getname<B.C>());
            Trace.WriteLine("");
        }
    }
}
