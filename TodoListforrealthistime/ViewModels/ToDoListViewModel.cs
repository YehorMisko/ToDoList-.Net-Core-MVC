using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TodoListforrealthistime.Models;
using Dapper;
using TodoList.Helpers;

namespace TodoListforrealthistime.ViewModels
{
    public class TodoListViewModel
    {
        public TodoListViewModel()
        {
            using (var db = DbHelper.GetConnection())
            {
                this.EditableItem = new TodoListItem();
                this.TodoItems = db.Query<TodoListItem>("SELECT * FROM TodoListItems ORDER BY AddDate DESC").ToList();
            }
        }

        public List<TodoListItem> TodoItems { get; set; }

        public TodoListItem EditableItem { get; set; }
    }
}