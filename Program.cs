var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var todos = new List<TodoItem>();

// GET: /todos
app.MapGet("/todos", () =>
{
    return Results.Ok(todos);
});

// GET: /todos/{id}
app.MapGet("/todos/{id}", (int id) =>
{
    var todo = todos.FirstOrDefault(t => t.Id == id);
    return todo is null ? Results.NotFound() : Results.Ok(todo);
});

// POST: /todos
app.MapPost("/todos", (TodoItem todo) =>
{
    todos.Add(todo);
    return Results.Created($"/todos/{todo.Id}", todo);
});

// PUT: /todos/{id}
app.MapPut("/todos/{id}", (int id, TodoItem input) =>
{
    var todo = todos.FirstOrDefault(t => t.Id == id);
    if (todo is null) return Results.NotFound();

    todo.Title = input.Title;
    todo.Done = input.Done;

    return Results.Ok(todo);
});

// DELETE: /todos/{id}
app.MapDelete("/todos/{id}", (int id) =>
{
    var todo = todos.FirstOrDefault(t => t.Id == id);
    if (todo is null) return Results.NotFound();

    todos.Remove(todo);
    return Results.NoContent();
});

app.Run();

// classe corrigida
class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Done { get; set; }
}
