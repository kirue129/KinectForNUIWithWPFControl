using Microsoft.Kinect.Toolkit.Input;
using Microsoft.Kinect.Wpf.Controls;
using System.Windows.Controls;

namespace KinectForNUIWithWPFControl
{
    class DragDropDecorator : Decorator, IKinectControl
    {
        public bool IsManipulatable
        {
            get
            {
                return true;
            }
        }
        public bool IsPressable
        {
            get
            {
                return false;
            }
        }
        public IKinectController CreateController(IInputModel inputModel, KinectRegion kinectRegion)
        {
            return new DragDropDecoratorController(inputModel, kinectRegion);

        }
    }
}
