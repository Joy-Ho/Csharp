var todos = new List<string>();
var exit = false;


while(!exit)
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
    bool isValidDescription = false;

    while(!isValidDescription)
    {    
        Console.WriteLine("Enter a new TODO description:");
        var description = Console.ReadLine();
        if (description == "")
        {
            Console.WriteLine("The description cannot be empty.");
        }
        else if (todos.Contains(description))
        {
            Console.WriteLine("The description must be unique.");
        }
        else
        {
            todos.Add(description);
            isValidDescription = true;
        }
    }
}


void SeeAllTodos()
{
    if(todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
    }
    else
    {
        for (int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i+1}. {todos[i]}");
        }
    }
}

void RemoveToDo()
{
    if(todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    bool isIndexValid = false;
    while(!isIndexValid)
    {    
        Console.WriteLine("Select the index of TODO you want to remove: ");
        SeeAllTodos();
        var userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.WriteLine();
            continue;
        }
        if(int.TryParse(userInput, out int index) &&
            index >= 1 &&
            index <= todos.Count)
        {
            var indexOfTodo = index - 1;
            var todoToBeRemoved = todos[indexOfTodo];
            todos.RemoveAt(indexOfTodo);
            isIndexValid = true;
            Console.WriteLine("TODO removed: " + todoToBeRemoved);
        }
        else
        {
            Console.WriteLine("The given index is not valid.");
        }
    }

}