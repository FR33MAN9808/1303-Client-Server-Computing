using System;

namespace ClntSrvrWk1.Lessons.Week3.AbstractClasses
{
    public abstract class Duck
    {
        private int id;
        private string name;
        protected int age;

        public Duck(int id, string name)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "id should be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "name cannot be null or whitespace.");
            }

            this.id = id;
            this.name = name;
        }

        public int GetId()
        {
            return id;
        }

        public string GetInfo()
        {
            return $"duck: {name} - {id}";
        }

        /// <summary>
        /// a virtual function can be overriden by subclasses.
        /// </summary>
        public virtual void Fly()
        {
            Console.WriteLine($"{this.id} - {this.name} flying ...");
        }

        public abstract int FieldId { get; }
    }
}
