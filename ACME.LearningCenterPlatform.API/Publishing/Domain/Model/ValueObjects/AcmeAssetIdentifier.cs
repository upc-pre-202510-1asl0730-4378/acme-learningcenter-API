namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

/// <summary>
/// Represents a unique identifier for an asset in the Learning Center Platform
/// </summary>
/// <param name="Identifier">
/// The unique identifier for the asset, typically a GUID
/// </param>
public record AcmeAssetIdentifier(Guid Identifier)
{  
   /// <summary>
   /// Initializes the AcmeAssetIdentifier
   /// </summary>
   public AcmeAssetIdentifier() : this(Guid.NewGuid())
   {
      
   }
}