using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;

public record AddReadableContentAssetToTutorialCommand(int TutorialId, string ReadableContent);