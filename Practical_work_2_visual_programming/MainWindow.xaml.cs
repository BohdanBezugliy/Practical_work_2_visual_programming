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

public partial class MainWindow : Window
{

    private RotateTransform3D myRotate1;
    private AxisAngleRotation3D myAxis1;
    private TranslateTransform3D myTranslate1;
    private Transform3DGroup myTransform1;

    private RotateTransform3D myRotate2;
    private AxisAngleRotation3D myAxis2;
    private TranslateTransform3D myTranslate2;
    private Transform3DGroup myTransform2;

    private RotateTransform3D myRotate3;
    private AxisAngleRotation3D myAxis3;
    private TranslateTransform3D myTranslate3;
    private Transform3DGroup myTransform3;


    private DispatcherTimer MyTimer;
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        myAxis1 = new AxisAngleRotation3D(new Vector3D(0, 1, 0), 12);
        myRotate1 = new RotateTransform3D(myAxis1);
        myTranslate1 = new TranslateTransform3D(0, 0, 0);
        myTransform1 = new Transform3DGroup();
        Cube.Transform = myTransform1;
        myTransform1.Children.Add(myTranslate1);
        myTransform1.Children.Add(myRotate1);

        myAxis2 = new AxisAngleRotation3D(new Vector3D(0, 1, 0), 2);
        myRotate2 = new RotateTransform3D(myAxis2);
        myTranslate2 = new TranslateTransform3D(0, 0, 0);
        myTransform2 = new Transform3DGroup();
        Pyramid.Transform = myTransform2;
        myTransform2.Children.Add(myTranslate2);
        myTransform2.Children.Add(myRotate2);

        myAxis3 = new AxisAngleRotation3D(new Vector3D(0, 1, 0), 50);
        myRotate3 = new RotateTransform3D(myAxis3);
        myTranslate3 = new TranslateTransform3D(0, 0, 0);
        myTransform3 = new Transform3DGroup();
        Triangle.Transform = myTransform3;
        myTransform3.Children.Add(myTranslate3);
        myTransform3.Children.Add(myRotate3);

        MyTimer = new DispatcherTimer();
        MyTimer.Tick += new EventHandler(My_Timer_tick);
        MyTimer.Interval = new TimeSpan(100000);
        MyTimer.Start();
    }
    private void My_Timer_tick(object sender, EventArgs e)
    {
        myAxis1.Angle += 0.03;
        myAxis2.Angle -= 0.04;
        myAxis3.Angle -= 0.08;
        myTranslate1.OffsetZ += 0.00005;
        myTranslate2.OffsetZ += 0.00005;
        myTranslate3.OffsetZ += 0.00005;
    }
    public MainWindow()
    {
        InitializeComponent();
    }
}