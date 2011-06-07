using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
=======
using System.IO;
>>>>>>> upstream/master

namespace WhatNEXT
{
    public interface ITaskList
    {
<<<<<<< HEAD
         void AddTask(TaskItem taskItem);
         void UpdateTask(TaskItem taskItem);
         TaskItem FindTaskByID(string taskID);
         long GetCount();

=======
        void AddTask(TaskItem taskItem);
        void UpdateTask(TaskItem taskItem);
        TaskItem FindTaskByID(Int64 taskID);
        Int64 GetCount();
        void DeleteTask(TaskItem taskItem);
        byte[] ExportTask(List<TaskItem> taskItems, Enumerations.ContentType contentType);
        List<TaskItem> GetAll();
>>>>>>> upstream/master
    }
}
