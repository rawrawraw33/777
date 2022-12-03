using System;

using LinkedListImplementation.Contracts;

namespace LinkedListImplementation
{
    public class LinkedListItem<T> : ILinkedListItem<T>
    {
        private ILinkedListItem<T> nextItem;
        private T value;

        public LinkedListItem(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            this.value = value;
        }

        public T Value
        {
            get { return this.value; }
        }

        public ILinkedListItem<T> NextItem
        {
            get { return this.nextItem; }
            set { this.nextItem = value; }
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
