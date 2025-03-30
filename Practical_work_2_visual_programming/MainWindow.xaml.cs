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
using System.Windows.Threading;

namespace Practical_work_2_visual_programming;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private RotateTransform3D myYRotate, myZRotate, myYRotate2, myZRotate2;
    private AxisAngleRotation3D myYAxis, myZAxis, myYAxis2, myZAxis2;

    private Transform3DGroup myTransform1, myTransform2;
    private DispatcherTimer MyTimer;
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        myYRotate = new RotateTransform3D();
        myYAxis = new AxisAngleRotation3D();
        myYAxis.Axis = new Vector3D(0, 1, 0);
        myYAxis.Angle = 0;
        myYRotate.Rotation = myYAxis;

        myTransform1 = new Transform3DGroup();
        myModel.Transform = myTransform1;

        myZRotate = new RotateTransform3D();
        myZAxis = new AxisAngleRotation3D();
        myZAxis.Axis = new Vector3D(0, 0, 1);
        myZAxis.Angle = 0;
        myZRotate.Rotation = myZAxis;

        myTransform1.Children.Add(myYRotate);
        myTransform1.Children.Add(myZRotate);

        myYRotate2 = new RotateTransform3D();
        myYAxis2 = new AxisAngleRotation3D();
        myYAxis2.Axis = new Vector3D(0, 1, 0);
        myYAxis2.Angle = 0;
        myYRotate2.Rotation = myYAxis2;
        myZRotate2 = new RotateTransform3D();
        myZAxis2 = new AxisAngleRotation3D();
        myZAxis2.Axis = new Vector3D(0, 0, 1);
        myZAxis2.Angle = 0;
        myZRotate2.Rotation = myZAxis2;
        myTransform2 = new Transform3DGroup();
        MyModel2.Transform = myTransform2;

        myTransform2.Children.Add(myYRotate2);
        myTransform2.Children.Add(myZRotate2);

        MyTimer = new DispatcherTimer();
        MyTimer.Tick += new EventHandler(My_Timer_tick);
        MyTimer.Interval = new TimeSpan(100000);
    }
    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        MyTimer.Stop();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        MyTimer.Start();
    }
    private void My_Timer_tick(object sender, EventArgs e)
    {
        myYAxis.Angle += 1;
        myZAxis.Angle += 1;
        myYAxis2.Angle -= 2;
        myZAxis2.Angle -= 2;
    }
    public MainWindow()
    {
        InitializeComponent();
    }
}