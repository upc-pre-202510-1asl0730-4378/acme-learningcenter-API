using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregates;

public partial class Tutorial
{
   public int Id { get; }
   public string Title { get; private set; }
   public string Summary { get; private set; }
   
   public Category Category { get; internal set; }
   public int CategoryId { get; private set; }

   public Tutorial(string title, string summary, int categoryId) {
      Title = title;
      Summary = summary;
      CategoryId = categoryId;
   }
   
   /// <summary>
   /// This is another way to define a constructor since the command needs the same parameters as the constructor above.
   /// </summary>
   /// <param name="command"></param>
   public Tutorial(CreateTutorialCommand command) :
      this(command.Title, command.Summary, command.CategoryId) {}
}