using DynamicObjectListing.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.InstantiationManager
{
    public static class InstanceMapperToModels
    {
        public static IBaseModel MapInstanceToModel(string objectType) 
        {
            var types = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => t.IsClass && t.Namespace == "DynamicObjectListing.InstantiationManager")
                    .ToList();

            foreach (var type in types)
            {
                if (type.GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(ICreator<>)))
                {
                    //var newInstance = Activator.CreateInstance(type);
                    var newInstance = Activator.CreateInstance(type);

                    var canHandleMethod = type.GetMethod(nameof(AthleteCreator.CanHandle));

                    bool canHandleResult = (bool)canHandleMethod.Invoke(newInstance, new object[] { objectType });

                    if (canHandleResult)
                    {
                        var createMethod = type.GetMethod(nameof(AthleteCreator.Create));
                        var objectToDisplay = (IBaseModel)createMethod.Invoke(newInstance, new object[] { });

                        return objectToDisplay;
                    }
                }
            }

            return null;
        }

        public static List<string> GetAllCurrentlyAvailableObjectTypes()
        {
            var currentlyAvailableObjectTypes = new List<string>();

            var types = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => t.IsClass && t.Namespace == "DynamicObjectListing.InstantiationManager")
                    .ToList();

            foreach (var type in types)
            {
                if (type.GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(ICreator<>)))
                {
                    var newInstance = Activator.CreateInstance(type);

                    var createMethod = type.GetMethod(nameof(AthleteCreator.Create));
                    var currentObject = (IBaseModel)createMethod.Invoke(newInstance, new object[] { });
                    currentlyAvailableObjectTypes.Add(currentObject.GetType().Name);
                }
            }

            return currentlyAvailableObjectTypes;
        }
    }
}
