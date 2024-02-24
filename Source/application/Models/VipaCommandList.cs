using helpers;
using System.Collections.ObjectModel;
using XO.Requests;

namespace VipaStateMachine.Models
{
    public class VipaCommandList : ObservableCollection<string>
    {
        public VipaCommandList()
        {
            Array values = Enum.GetValues(typeof(Requests));

            foreach (object? value in values)
            {
                Add(StringValueAttribute.GetStringValue((Requests)value));
            }
        }
    }
}