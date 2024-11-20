var todos = new List<string>();
var exit = false;


while (!exit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var option = Console.ReadLine();
    Console.WriteLine();

    switch (option)
    {
        case "S":
        case "s":
            SeeAllTodos();
            break;

        case "A":
        case "a":
            AddTodo();
            break;

        case "R":
        case "r":
            RemoveToDo();
            break;

        case "E":
        case "e":
            exit = true;
            break;
    }
}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter a new TODO description:");
        description = Console.ReadLine();

    } while (!IsDescriptionValid(description));
    todos.Add(description);
}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }
    else if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }
    return true;
}

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}

void ShowNoTodosMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}

void RemoveToDo()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    int index;
    do
    {
        Console.WriteLine("Select the index of TODO you want to remove: ");
        SeeAllTodos();
    } while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);
}

void RemoveTodoAtIndex(int index)
{
    var indexOfTodo = index - 1;
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine();
        return false;
    }
    if (int.TryParse(userInput, out index) &&
        index >= 1 &&
        index <= todos.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid.");
    return false;
}