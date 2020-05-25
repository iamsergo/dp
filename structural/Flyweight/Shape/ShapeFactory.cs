using System.Collections;

namespace Flyweight
{
  // Фабрика фигур - приспособленец, легковес
  class ShapeFactory
  {
    private Hashtable shapes;
    public ShapeFactory()
    {
      this.shapes = new Hashtable();
    }
    // Экземпляр класса создается один раз
    public IShape GetShape(string name)
    {
      IShape shape = shapes[name] as IShape;
      if(shape == null)
      {
        switch (name)
        {
          case "rectangle" : shape = new Rectangle(); break;
          case "circle"    : shape = new Circle(); break;
        }
        shapes.Add(name, shape);
      }
      return shape;
    }
  }
}