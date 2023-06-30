﻿using AppTask.Models;
using AppTask.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Task.Repositories
{
    internal class TaskModelRepository : ITaskModelRepository
    {
        private AppTaskContext _db;
        public TaskModelRepository()
        {
            _db = new AppTaskContext();

        }
        public IList<TaskModel> GetAll()
        {
            return _db.Tasks.OrderByDescending(a => a.PrevisionDate).ToList();
        }

        public TaskModel GetById(int id)
        {
            return _db.Tasks.Include(a => a.SubTasks).FirstOrDefault(a => a.Id == id);
        }
        
        public void Add(TaskModel task)
        {
            _db.Tasks.Add(task);
            //salva cadastros, atualizações e edições
            _db.SaveChanges();
        }

        public void Delete(TaskModel task)
        {
            task = GetById(task.Id);
            foreach (var subtask in task.SubTasks)
            {
                _db.Remove(subtask);
            }

            _db.Remove(task);
            _db.SaveChanges();
        }

        public void Update(TaskModel task)
        {
            _db.Tasks.Update(task);
            _db.SaveChanges();
        }
    }
}
