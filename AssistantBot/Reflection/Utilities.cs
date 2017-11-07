using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistantBot.Reflection
{
    public class Utilities
    {
        public static void CopyDto<Source, Destination>(Source source, Destination destination)
            where Source : class
            where Destination : class
        {
            var properties = source.GetType().GetProperties();

            properties.ToList().ForEach(property =>
            {
                //Check whether that property is present in derived class
                var destinationProperty = destination.GetType().GetProperty(property.Name, property.PropertyType);
                if (destinationProperty != null)
                {
                    //If present get the value and map it
                    var value = source.GetType().GetProperty(property.Name, property.PropertyType).GetValue(source, null);
                    destinationProperty.SetValue(destination, value, null);
                }
            });
        }
    }
}
