namespace ShapesApp.Library {
    public interface IShape { //Default is Internal but then it will only be accessiblee in ShapeApp.Library and not ShapeApp.App
        int Dimensions { get; }
        int Sides { get; }
        double Area { get; }
        double GetPerimeter();
        
    }
}