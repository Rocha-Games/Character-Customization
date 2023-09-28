using System;
using System.Collections.Generic;

namespace CharacterCustomization.Controllers {
    public interface ILocalizableByLocator {

    }

    public static class SystemLocator {
        private static readonly IDictionary<Type, object> Services = new Dictionary<Type, System.Object>();

        public static void Register<T>(T locatorElement) where T : ILocalizableByLocator {
            if (!Services.ContainsKey(typeof(T))) {
                Services[typeof(T)] = locatorElement;
            }
            else {
                throw new ApplicationException("System already registered");
            }
        }

        public static T Resolve<T>() where T : ILocalizableByLocator {
            try {
                return (T)Services[typeof(T)];
            }
            catch {
                throw new ApplicationException("System not found.");
            }
        }

        public static void UnRegister<T>(T locatorElement) where T : ILocalizableByLocator {
            if (Services.ContainsKey(typeof(T))) {
                Services.Remove(typeof(T));
            }
            else {
                throw new ApplicationException("System not yet registered");
            }
        }
    }
}
