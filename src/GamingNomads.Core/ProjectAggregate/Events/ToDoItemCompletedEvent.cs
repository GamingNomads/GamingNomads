using GamingNomads.Core.ProjectAggregate;
using GamingNomads.SharedKernel;

namespace GamingNomads.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : BaseDomainEvent
{
  public ToDoItem CompletedItem { get; set; }

  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }
}
