namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

/// <summary>
/// Represents a content item in the 
/// </summary>
/// <param name="Type">
/// The content type, it could be and "Image", "Video" or "ReadOnly"
/// </param>
/// <param name="Content"></param>
public record ContentItem(string Type, string Content);