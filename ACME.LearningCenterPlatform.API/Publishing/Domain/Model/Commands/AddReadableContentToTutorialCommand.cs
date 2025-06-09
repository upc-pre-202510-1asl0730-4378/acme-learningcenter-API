using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;

public record AddReadableContentToTutorialCommand(int TutorialId, string ReadableContent);