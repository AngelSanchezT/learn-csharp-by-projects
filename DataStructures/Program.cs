/*
 * EXERCISE:
 * - Show examples of creating all the data structures supported by default in your language.
 * - Use insertion, deletion, update, and sorting operations.
 *
 * EXTRA DIFFICULTY (optional):
 * Create a contact agenda in the terminal.
 * - You must implement search, insertion, update, and deletion functionalities for contacts.
 * - Each contact must have a name and a phone number.
 * - The program first asks which operation you want to perform, and then
 *   the necessary data to carry it out.
 * - The program must not allow entering non-numeric phone numbers or numbers with more than 11 digits.
 *   (or the number of digits you want)
 * - There must also be an option to finish the program.
 */

class Program
{
    static void Main()
    {
        // ARRAYS
        int[] numbers = { 1, 2, 3, 4, 5, 6 }; // Insertion

        numbers[0] = 7; // Update
                        // Deletion is not supported by Arrays.
        Array.Sort(numbers); // Sorting

        foreach (int number in numbers)
        {
            Console.WriteLine(number + " ");
        }

        // LISTS
        List<string> countries = new();

        countries.Add("Spain"); // Insertion
        countries.Add("Canada");
        countries.Add("Dominican Republic");
        countries.Remove("Canada"); // Deletion
        countries[0] = "Italy"; // Update
        countries.Sort(); // Sorting

        foreach (var country in countries)
        {
            Console.WriteLine(country + " ");
        }

        // DICTIONARY
        Dictionary<string, int> employees = new Dictionary<string, int>
        {
            { "Esmil", 4 },
            { "Ana", 2 },
            { "Maria", 5 }
        };

        employees.Add("Alex", 11); // Insertion
        employees.Remove("Esmil"); // Deletion
        employees["Ana"] = 43; // Update
                               // No direct sorting, must be done by key or value

        foreach (var employee in employees)
        {
            Console.WriteLine(employee + "");
        }

        // HASHSET
        HashSet<int> set = new HashSet<int> { 1, 2, 3 };

        set.Add(5); // Insertion
        set.Remove(1); // Deletion

        set.Remove(2); // Update (Remove and Add)
        set.Add(4);

        List<int> sortedSet = set.ToList();
        sortedSet.Sort(); // Sorting (Must convert to List)

        foreach (var s in sortedSet)
        {
            Console.WriteLine(s + "");
        }

        // QUEUE
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(5); // Insertion
        queue.Enqueue(2);
        queue.Enqueue(8);
        queue.Enqueue(1);
        queue.Enqueue(3);

        Console.WriteLine($"Removed Queue Element: {queue.Dequeue()}"); // Deletion

        // Update (cannot be done directly, must rebuild the queue)
        Queue<int> updatedQueue = new Queue<int>(queue.Select(x => x == 2 ? 4 : x));

        List<int> sortedQueue = updatedQueue.ToList(); // Sorting (Must convert to list)
        sortedQueue.Sort();

        foreach (var item in sortedQueue)
        {
            Console.Write(item + " ");
        }

        // STACK
        Stack<int> stack = new Stack<int>();

        stack.Push(5); // Insertion
        stack.Push(2);
        stack.Push(8);
        stack.Push(1);
        stack.Push(3);

        // Eliminar y retornar el último elemento insertado en la pila (LIFO - Last In, First Out)
        stack.Pop(); // Deletion

        // Update (cannot be done directly, must rebuild the stack)
        Stack<int> updatedStack = new Stack<int>(stack.Select(x => x == 8 ? 9 : x));

        List<int> sortedStack = updatedStack.ToList();
        sortedStack.Sort(); // Sorting (Must convert to list)

        foreach (var item in sortedStack)
        {
            Console.Write(item + " ");
        }

        // LINKEDLIST
        LinkedList<int> linkedList = new LinkedList<int>();

        linkedList.AddLast(5); // Insertion
        linkedList.AddLast(2);
        linkedList.AddLast(8);
        linkedList.AddLast(1);
        linkedList.AddLast(3);
        linkedList.AddLast(7);

        linkedList.Remove(8); // Deletion

        // Update (not direct, must be handled with nodes)
        LinkedListNode<int>? node = linkedList.Find(2);
        if (node != null)
        {
            node.Value = 4;
        }

        List<int> sortedLinkedList = linkedList.ToList();
        sortedLinkedList.Sort(); // Sorting (Must convert to list)

        foreach (var item in sortedLinkedList)
        {
            Console.Write(item + " ");
        }

        // EXTRA EXERCISE: CONTACT AGENDA
        ContactAgenda.Start();

    }
}

public class ContactAgenda
{
    static Dictionary<string, string> agenda = new Dictionary<string, string>();


    public static void Start()
    {
        while (true)
        {
            Console.WriteLine("------ Agenda ------");
            Console.WriteLine("");
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Insert contact");
            Console.WriteLine("2. Search contact");
            Console.WriteLine("3. Update contact");
            Console.WriteLine("4. Delete contact");
            Console.WriteLine("5. End program");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    InsertContact();
                    break;
                case "2":
                    SearchContact();
                    break;
                case "3":
                    UpdateContact();
                    break;
                case "4":
                    DeleteContact();
                    break;
                case "5":
                    Console.WriteLine("Ending Program...");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again!");
                    break;
            }


        }
    }

    public static void InsertContact()
    {
        Console.WriteLine("Enter the contact's name: ");
        var name = Console.ReadLine();

        Console.WriteLine("Enter the contact's phone number: ");
        var phone = Console.ReadLine();

        if (name == null)
        {
            Console.WriteLine("Invalid name, please try again");
            return;
        }

        if (phone?.Length > 11 || !long.TryParse(phone, out _) || phone == null)
        {
            Console.WriteLine("Invalid phone number, please try again");
            return;
        }

        if (agenda.ContainsKey(name))
        {
            Console.WriteLine("The name already exists in the agenda!");
            return;
        }

        agenda[name] = phone;
    }

    public static void SearchContact()
    {
        Console.Write("Enter the contact's name:");
        var name = Console.ReadLine();

        if (name == null)
        {
            Console.WriteLine("Invalid name!");
            return;
        }

        if (agenda.ContainsKey(name))
        {
            Console.WriteLine($"Name: {name}, Phone: {agenda[name]}");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
    }

    public static void UpdateContact()
    {
        Console.Write("Enter the contact's name: ");
        var name = Console.ReadLine();

        if (name == null)
        {
            Console.WriteLine("Invalid name!");
            return;
        }

        if (agenda.ContainsKey(name))
        {
            Console.Write("Enter the new phone number (max 11 digits): ");
            string? phone = Console.ReadLine();

            if (phone?.Length > 11 || !long.TryParse(phone, out _) || phone == null)
            {
                Console.WriteLine("Invalid phone number.");
                return;
            }

            agenda[name] = phone;
            Console.WriteLine("Contact updated successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    public static void DeleteContact()
    {
        Console.Write("Enter the contact's name: ");
        var name = Console.ReadLine();

        if (name == null)
        {
            Console.WriteLine("Invalid name!");
            return;
        }

        if (agenda.ContainsKey(name))
        {
            agenda.Remove(name);
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}