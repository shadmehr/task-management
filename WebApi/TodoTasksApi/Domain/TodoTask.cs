﻿namespace CBC.TaskManagement.WebApi.Domain
{ 
    using System.ComponentModel.DataAnnotations;

    public class TodoTask
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public TodoTaskStatus Status { get; set; }

        public bool IsComplete { get { return this.Status == TodoTaskStatus.Done; } }

        //public Category Category { get; private set; }
    }
}
