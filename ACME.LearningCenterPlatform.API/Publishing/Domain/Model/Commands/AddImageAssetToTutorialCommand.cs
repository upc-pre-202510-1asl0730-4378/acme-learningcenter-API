namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;

public record AddImageAssetToTutorialCommand(int TutorialId, string ImageUrl);