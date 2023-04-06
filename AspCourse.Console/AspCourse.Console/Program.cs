using AspCourse.Console;

string[] fictionBooks = new string[]
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

Iterator iterator = new ConcreteIterator(fictionBooks);

while (!iterator.IsDone())
{
    Console.WriteLine(iterator.Current());
    iterator.MoveNext();
}

