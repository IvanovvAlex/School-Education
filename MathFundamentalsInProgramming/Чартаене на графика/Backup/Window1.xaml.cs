using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.CodeDom.Compiler;
using System.Reflection;

namespace howto_wpf_graph_user_equation
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        // Prepare values for perform transformations.
        private Matrix WtoDMatrix, DtoWMatrix;
        private void PrepareTransformations(
            double wxmin, double wxmax, double wymin, double wymax,
            double dxmin, double dxmax, double dymin, double dymax)
        {
            // Make WtoD.
            WtoDMatrix = Matrix.Identity;
            WtoDMatrix.Translate(-wxmin, -wymin);

            double xscale = (dxmax - dxmin) / (wxmax - wxmin);
            double yscale = (dymax - dymin) / (wymax - wymin);
            WtoDMatrix.Scale(xscale, yscale);

            WtoDMatrix.Translate(dxmin, dymin);

            // Make DtoW.
            DtoWMatrix = WtoDMatrix;
            DtoWMatrix.Invert();
        }

        // Transform a point from world to device coordinates.
        private Point WtoD(Point point)
        {
            return WtoDMatrix.Transform(point);
        }

        // Transform a point from device to world coordinates.
        private Point DtoW(Point point)
        {
            return DtoWMatrix.Transform(point);
        }

        // Draw the graph.
        private void btnGraph_Click(object sender, RoutedEventArgs e)
        {
            DrawGraph();
        }
        private void DrawGraph()
        {
            // Clear any previous drawing.
            canGraph.Children.Clear();

            // Get the parameters.
            double wxmin = double.Parse(txtXmin.Text);
            double wxmax = double.Parse(txtXmax.Text);
            double wymin = double.Parse(txtYmin.Text);
            double wymax = double.Parse(txtYmax.Text);
            string equation = txtEquation.Text;

            // Prepare the transformation.
            double dxmax = canGraph.ActualWidth;
            double dymax = canGraph.ActualHeight;
            PrepareTransformations(wxmin, wxmax, wymin, wymax,
                0, dxmax, dymax, 0);

            // Draw the axes.
            DrawAxes(canGraph, wxmin, wxmax, wymin, wymax);

            // Draw the curve.
            DrawCurve(canGraph, wxmin, wxmax, wymin, wymax, equation);
        }

        private void DrawCurve(Canvas canvas,
            double xmin, double xmax,
            double ymin, double ymax, string equation)
        {
            // Turn the equation into a function.
            string function_text =
                "using System;" +
                "public static class Evaluator" +
                "{" +
                "    public static double Evaluate(double x)" +
                "    {" +
                "        return " + equation + ";" +
                "    }" +
                "}";

            // Compile the function.
            CodeDomProvider code_provider =
                CodeDomProvider.CreateProvider("C#");

            // Generate a non-executable assembly in memory.
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateInMemory = true;
            parameters.GenerateExecutable = false;

            // Compile the code.
            CompilerResults results =
                code_provider.CompileAssemblyFromSource(parameters,
                    function_text);

            // If there are errors, display them.
            if (results.Errors.Count > 0)
            {
                string msg = "Error compiling the expression.";
                foreach (CompilerError compiler_error in results.Errors)
                {
                    msg += "\n" + compiler_error.ErrorText;
                }
                MessageBox.Show(msg, "Expression Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                // Get the Evaluator class type.
                Type evaluator_type =
                    results.CompiledAssembly.GetType("Evaluator");

                // Get a MethodInfo object describing the Evaluate method.
                MethodInfo method_info =
                    evaluator_type.GetMethod("Evaluate");

                // See how big 1 pixel is in world coordinates.
                Point p0 = DtoW(new Point(0, 0));
                Point p1 = DtoW(new Point(1, 1));
                double dx = p1.X - p0.X;

                // Loop over x values to generate points.
                List<Point> points = new List<Point>();
                bool last_point_in_bounds = false;
                for (double x = xmin; x <= xmax; x += dx)
                {
                    bool point_in_bounds = false;
                    try
                    {
                        // Get the next point.
                        object[] method_params =
                            new object[] { x };
                        double y =
                            (double)method_info.Invoke(null, method_params);

                        // See if the point lies within the drawing area.
                        if (double.IsNaN(y))
                        {
                            // The value is undefined. Don't save it.
                        }
                        else
                        {
                            if (y < ymin)
                                y = ymin;
                            else if (y > ymax)
                                y = ymax;
                            else
                                point_in_bounds = true;

                            // Save the point.
                            points.Add(new Point(x, y));
                        }

                        // Draw the polyline if we should.
                        if (!point_in_bounds)
                        {
                            if (last_point_in_bounds)
                            {
                                // Draw whatever we have saved.
                                MakePolyline(canGraph, points);
                                points.Clear();
                            }
                            else
                            {
                                // Delete the previous invalid first point.
                                if (points.Count > 1) points.RemoveAt(0);
                            }
                        }

                        last_point_in_bounds = point_in_bounds;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

                // Draw any remaining points.
                if (points.Count > 1) MakePolyline(canvas, points);
            }
        }

        // Draw a simple graph.
        private void DrawAxes(Canvas canvas, double xmin, double xmax, double ymin, double ymax)
        {
            const double tic_wid = 0.5;

            // Make the X axis.
            double xstart = (int)xmin;
            if (xstart == xmin) xstart++;
            double xstop = (int)xmax;
            if (xstop == xmax) xstop--;

            Point p = new Point(0, 0);
            Point origin = WtoD(p);
            GeometryGroup xaxis_geom = new GeometryGroup();
            xaxis_geom.Children.Add(new LineGeometry(
                new Point(0, origin.Y),
                new Point(canvas.ActualWidth, origin.Y)));
            double y1 = -tic_wid / 2;
            double y2 = tic_wid / 2;
            for (double x = xstart; x <= xstop; x++)
            {
                Point p1 = new Point(x, y1);
                Point p2 = new Point(x, y2);
                xaxis_geom.Children.Add(
                    new LineGeometry(WtoD(p1), WtoD(p2)));
            }

            Path xaxis_path = new Path();
            xaxis_path.StrokeThickness = 1;
            xaxis_path.Stroke = Brushes.Black;
            xaxis_path.Data = xaxis_geom;

            canvas.Children.Add(xaxis_path);

            // Make the Y ayis.
            double ystart = (int)ymin;
            if (ystart == ymin) ystart++;
            double ystop = (int)ymax;
            if (ystop == ymax) ystop--;

            GeometryGroup yaxis_geom = new GeometryGroup();
            yaxis_geom.Children.Add(new LineGeometry(
                new Point(origin.X, 0),
                new Point(origin.X, canvas.ActualHeight)));
            double x1 = -tic_wid / 2;
            double x2 = tic_wid / 2;
            for (double y = ystart; y <= ystop; y++)
            {
                Point p1 = new Point(x1, y);
                Point p2 = new Point(x2, y);
                yaxis_geom.Children.Add(
                    new LineGeometry(WtoD(p1), WtoD(p2)));
            }

            Path yaxis_path = new Path();
            yaxis_path.StrokeThickness = 1;
            yaxis_path.Stroke = Brushes.Black;
            yaxis_path.Data = yaxis_geom;

            canvas.Children.Add(yaxis_path);
        }

        // Make a polyline connecting the points.
        private void MakePolyline(Canvas canvas, List<Point> points)
        {
            // Convert the points into device coordinates
            // and add them to a PointCollection.
            PointCollection point_collection =
                new PointCollection(points.Count);
            foreach (Point point in points)
                point_collection.Add(WtoD(point));

            // Make a Polyline that uses the PointCollection.
            Polyline polyline = new Polyline();
            polyline.Points = point_collection;
            polyline.StrokeThickness = 1;
            polyline.Stroke = Brushes.Red;
            canvas.Children.Add(polyline);
        }

        // Fill in an interesting equation.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int equation = 2;
            switch (equation)
            {
                case 1:
                    txtEquation.Text = "10 * Math.Sin(x) / x";
                    txtXmin.Text = "-20";
                    txtXmax.Text = "20";
                    txtYmin.Text = "-5";
                    txtYmax.Text = "20";
                    break;
                case 2:
                    txtEquation.Text = "x * x / (x * x - 1)";
                    txtXmin.Text = "-6";
                    txtXmax.Text = "6";
                    txtYmin.Text = "-3";
                    txtYmax.Text = "5";
                    break;
                case 3:
                    txtEquation.Text = "5 * Math.Sin(x)";
                    txtXmin.Text = "-6";
                    txtXmax.Text = "6";
                    txtYmin.Text = "-4";
                    txtYmax.Text = "4";
                    break;
                case 4:
                    txtEquation.Text = "Math.Abs(x) / x / 2";
                    txtXmin.Text = "-3";
                    txtXmax.Text = "3";
                    txtYmin.Text = "-2";
                    txtYmax.Text = "2";
                    break;
            }
        }
    }
}