namespace DxfReader.Contexts
{
    public interface IGraphicsContext
    {
        void Begin();
        void DrawLine(double x1, double y1, double x2, double y2, string color = "black", double width = 1);
        void DrawCircle(double cx, double cy, double radius, string color = "black", double width = 1);
        void DrawRectangle(double x, double y, double width, double height, string color = "black", double lineWidth = 1);
        void FillText(string text, double x, double y, string color = "black", string font = "Arial", double size = 12);
        string End();
    }

}
