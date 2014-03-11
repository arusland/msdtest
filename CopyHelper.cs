using System;
using System.Linq;
using System.Reflection;

namespace MsDynamicsTest
{
    static public class CopyHelper
    {
        #region Methods

        #region Public

        /// <summary>
        /// Copies all public properties from one object to another.
        /// </summary>
        public static void Copy(object from, object to, bool throwIfProperty = true)
        {
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            var toProps = to.GetType().GetProperties(flags).Where(p => p.GetSetMethod() != null).ToList();

            foreach (var piFrom in from.GetType().GetProperties(flags).Where(p => p.GetSetMethod() != null))
            {
                var piTo = toProps.FirstOrDefault(p => p.Name == piFrom.Name);

                if (piTo == null)
                {
                    if (throwIfProperty)
                    {
                        throw new InvalidOperationException(String.Format("Cannot find property {0}.{1} of type {2}.",
                            to.GetType().FullName, piFrom.Name, piFrom.PropertyType.FullName));
                    }

                    continue;
                }

                var value = piFrom.GetValue(from, null);
                piTo.SetValue(to, value, null);
            }
        }

        /// <summary>
        /// Creates instance of type T and copies public properties from 'from' object.
        /// </summary>
        public static T CreateCopied<T>(object from, bool throwIfProperty = true)
        {
            var result = (T)typeof(T).Assembly.CreateInstance(typeof(T).FullName);

            Copy(from, result, throwIfProperty);

            return result;
        }


        #endregion

        #endregion
    }
}
