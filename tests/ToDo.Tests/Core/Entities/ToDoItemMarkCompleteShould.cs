﻿using ToDo.Core.Events;
using System.Linq;
using Xunit;

namespace ToDo.Tests.Core.Entities
{
    public class ToDoItemMarkCompleteShould
    {
        [Fact]
        public void SetIsDoneToTrue()
        {
            var item = new ToDoItemBuilder().Build();

            item.MarkComplete();

            Assert.True(item.IsDone);
        }

        [Fact]
        public void RaiseToDoItemCompletedEvent()
        {
            var item = new ToDoItemBuilder().Build();

            item.MarkComplete();

            Assert.Single(item.Events);
            Assert.IsType<ToDoItemCompletedEvent>(item.Events.First());
        }
    }
}
