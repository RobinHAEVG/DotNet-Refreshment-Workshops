using System;
using System.Collections.Generic;

namespace CustomMVVMImplementationExample.MVVM
{
    public static class ServiceContainer
    {
        private static Dictionary<Type, object> instances = new Dictionary<Type, object>();

        public static void Register<T>() where T : class
        {
            var type = typeof(T);
            if (instances.TryGetValue(type, out object value))
                throw new Exception("class already registered");

            instances.Add(type, Activator.CreateInstance<T>());
        }

        public static T GetInstance<T>() where T : class
        {
            var type = typeof(T);
            if (!instances.TryGetValue(type, out object value))
                throw new Exception("class is not registered");

            return (T) value;
        }
    }

}
