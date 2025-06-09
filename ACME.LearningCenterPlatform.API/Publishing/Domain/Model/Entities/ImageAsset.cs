using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

public class ImageAsset : Asset
{
   public Uri? ImageUri { get; }
   
   public ImageAsset() : base(EAssetType.Image)
   {
      
   }

   public ImageAsset(string imageUri) : base(EAssetType.Image)
   {
      ImageUri = new Uri(imageUri);
   }

   public override bool Readable => false;
   
   public override bool Viewable => true;

   public override string GetContent()
   {
      return ImageUri != null ? ImageUri.AbsoluteUri : string.Empty;
   }
}