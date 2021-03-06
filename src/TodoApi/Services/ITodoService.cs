using TodoApi.Models;

namespace TodoApi.Services;

public interface ITodoService
{
    IEnumerable<TodoItem> GetTodos();
    TodoItem GetTodo(int id);
    TodoItem AddTodo(TodoItem todoItem);
    int UpdateTodo(TodoItem todoItem);
    void DeleteTodo(TodoItem todoItem);
}
