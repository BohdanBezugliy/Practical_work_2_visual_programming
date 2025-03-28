using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practical_work_2_visual_programming;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        myYRotate = new RotateTransform3D();
        myYAxis = new AxisAngleRotation3D();
        myYAxis.Axis = new Vector3D(0, 1, 0);
        myYAxis.Angle = 7;
        myYRotate.Rotation = myYAxis;

        myXRotate = new RotateTransform3D();
        myXAxis = new AxisAngleRotation3D();
        myXAxis.Axis = new Vector3D(1, 0, 0);
        myXAxis.Angle = 7;
        myXRotate.Rotation = myXAxis;

        myTransform1 = new Transform3DGroup();
        myTransform2 = new Transform3DGroup();

        MyModel.Transform = myTransform1;
        MyModel2.Transform = myTransform2;
    }
    private RotateTransform3D myXRotate, myYRotate;
    private AxisAngleRotation3D myXAxis, myYAxis;
    private Transform3DGroup myTransform1, myTransform2;
    private void button1_Click(object sender, RoutedEventArgs e)
    {
        myTransform1.Children.Add(myYRotate);
    }

    private void button2_Click(object sender, RoutedEventArgs e)
    {
        myTransform2.Children.Add(myXRotate);
    }

    private void button3_Click(object sender, RoutedEventArgs e)
    {
        myTransform1.Children.Add(myXRotate);
    }
}