

namespace AspCourse.Console.Tests
{
    public class ConcreteIteratorTests
    {
        [Fact]
        public void Test1()
        {
            string[] expected = new string[]
            {
                "To Kill a Mockingbird",
                "1984",
                "The Great Gatsby",
                "Pride and Prejudice",
                "The Catcher in the Rye",
                "One Hundred Years of Solitude",
                "Brave New World",
                "The Lord of the Rings",
                "Animal Farm",
                "The Brothers Karamazov",
                "Crime and Punishment",
                "The Picture of Dorian Gray",
                "The Count of Monte Cristo",
            };

            Iterator iterator = new ConcreteIterator(expected);
            int index = 0;

            while (!iterator.IsDone())
            {
                Assert.Equal(expected[index], iterator.Current());
                iterator.MoveNext();
                index++;
            }
        }  
    }

    public abstract class Iterator
    {
        public abstract object MoveNext();
        public abstract bool IsDone();
        public abstract object Current();
    }

    public class ConcreteIterator : Iterator
    {

        private readonly object[] _objects;
        private int current;

        public ConcreteIterator(object[] objects)
        {
            this._objects = objects;
        }

        public override object Current() => _objects[current];

        public override bool IsDone() => current >= _objects.Count();

        public override object MoveNext() => ++current < _objects.Count() ? _objects[current] : null;

    }

}