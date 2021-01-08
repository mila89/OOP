using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            IDrawable rectangle = new Rectangle();
            IDrawable circle = new Circle();
            GraphicEditor graphicEditor =new GraphicEditor();
            graphicEditor.DrawShape(circle);
            graphicEditor.DrawShape(rectangle);
        }
    }
}
