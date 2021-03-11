using System;
using System.Collections.Generic;

namespace CustomMVVMImplementationExample.MVVM
{
    public class Messenger
    {
        private static Dictionary<Type, Action<object>> recipients = 
            new Dictionary<Type, Action<object>>();

        public static void Register<T>(Action<object> receiveMethod) where T : class
        {
            if (!recipients.TryAdd(typeof(T), receiveMethod))
                throw new Exception($"could not register for type '{typeof(T)}'");
        }

        public static void Send<T>(T message) where T : class
        {
            if (recipients.TryGetValue(typeof(T), out Action<object> method))
                method(message);
        }
    }
}
