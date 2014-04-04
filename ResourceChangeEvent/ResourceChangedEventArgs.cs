using System;

namespace Itschwabing.Libraries.ResourceChangeEvent
{
    public class ResourceChangedEventArgs : EventArgs
    {
        public object OldValue { get; private set; }
        public object NewValue { get; private set; }

        public ResourceChangedEventArgs(object oldValue, object newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}