﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Entities
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }

        public DbSet<ToDoClass> ToDos { get;set; }

        public void Adding(ToDoClass toDoClass)
        {
            ToDos.Add(toDoClass);
            this.SaveChanges();
        }

        public void UpVoting(int ID)
        {
            ToDos.Find(ID).Votes++;
            this.SaveChanges();
        }

        public void DownVoting(int ID)
        {
            ToDos.Find(ID).Votes--;
            this.SaveChanges();
        }

        //public void Sort()
        //{
        //    ToDos = ToDos.OrderBy(todo => todo.Votes);
        //    this.SaveChanges();
        //}

        public void Deleting(ToDoClass toDoClass)
        {
            ToDos.Remove(toDoClass);
            this.SaveChanges();
        }
    }
}
