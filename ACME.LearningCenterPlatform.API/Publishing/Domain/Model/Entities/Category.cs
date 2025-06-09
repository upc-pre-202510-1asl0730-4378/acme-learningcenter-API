using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

public class Category
{
   public Category()
   {
      Name = string.Empty;
   }

   public Category(string name)
   {
      Name = name;
   }
   public int Id { get; set; }
   public string Name { get; set; }

   /// <summary>
   /// This is another way to define a constructor since the command needs the same parameters as the constructor above.
   /// </summary>
   /// <param name="command"></param>
   public Category(CreateCategoryCommand command) : 
      this(command.Name) { }
}