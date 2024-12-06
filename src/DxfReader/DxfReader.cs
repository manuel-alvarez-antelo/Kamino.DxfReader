using DxfReader.Contexts;
using DxfReader.Readers;

namespace DxfReader
{
    public class DxfReader
    {
        public void Read(Stream dxfStream, IGraphicsContext graphicsContext)
        {
            var lines = new StreamReader(dxfStream).ReadToEnd().Split('\n').ToList();

            // Lógica para leer el HEADER
            var headerReader = new HeaderReader();
            var header = headerReader.Read(lines);

            graphicsContext.Begin();

            // Lógica para leer las entidades
            var entityReader = new EntityReader();
            var entities = entityReader.Read(lines);

            foreach (var entity in entities)
            {
                switch (entity)
                {
                    case DxfLine line:
                        graphicsContext.DrawLine(line.StartPoint.X, line.StartPoint.Y, line.EndPoint.X, line.EndPoint.Y);
                        break;

                    case DxfCircle circle:
                        graphicsContext.DrawCircle(circle.Center.X, circle.Center.Y, circle.Radius);
                        break;

                        // Agregar más casos para diferentes entidades
                }
            }

            graphicsContext.End();
        }
    }
}
