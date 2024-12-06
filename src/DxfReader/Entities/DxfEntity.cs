using DxfReader.Contexts;

namespace DxfReader.Entities
{
    public abstract class DxfEntity
    {
        public required string Layer { get; set; }
        public abstract void Draw(IGraphicsContext graphicsContext);
    }
}
