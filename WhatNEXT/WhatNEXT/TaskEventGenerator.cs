﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatNEXT
{
    public class TaskEventGenerator : ITaskListWithEvents
    {
        private ITaskList taskList;//why private - outside world should not know. proxy attendance cannot given public
        public event AddTaskEventHandler Add;
        private List<TaskItem> taskItems = new List<TaskItem>();

        public List<TaskItem> TaskItems
        {
            get { return taskItems; }
        }

        public TaskEventGenerator(ITaskList taskList)
        {
            this.taskList = taskList;

            Console.WriteLine("from TaskEventGenerator added");
        }
        // Invoke the Changed event; called whenever list changes
        protected virtual void OnAdd(TaskAddEventArgs e)
        {
            if (Add != null)
            {
                Add(this, e);
            }

        }
        public void AddTask(TaskItem taskItem)
        {

            if (taskItem == null || null != FindTaskByID(taskItem.ID))
            {
                throw new ApplicationException("");
            }
            TaskItems.Add(taskItem);
            OnAdd(new TaskAddEventArgs(taskItem.ID));

        }
        public void UpdateTask(TaskItem taskItem)
        {
            throw new NotImplementedException();
        }

        public TaskItem FindTaskByID(long taskID)
        {
            return TaskItems.Find((t) => t.ID == taskID);
        }

        public long GetCount()
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(TaskItem taskItem)
        {
            throw new NotImplementedException();
        }

        public byte[] ExportTask(List<TaskItem> taskList, Enumerations.ContentType contentType)
        {
            throw new NotImplementedException();
        }

        public List<TaskItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public static void Main()
        {
            ITaskList t = TaskListFactory.GetInstance().CreateList();

            ConsoleTaskEventNotifier.TaskEventNotifier(t);

            t.AddTask(new TaskItem() { ID = 1 });

            System.Threading.Thread.Sleep(10000);

        }
    }
}
