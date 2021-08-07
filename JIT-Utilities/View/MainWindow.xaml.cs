using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JIT_Utilities
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
         * Instance variables
         */
        private Point? posOld = null;
        private Point? posNew = null;

        /*
         * Main Window Constructor
         */
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the left mouse button is pressed, record the current mouse position. The position of the mouse is relative to the window, not the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            posOld = Mouse.GetPosition(this);
        }

        /// <summary>
        /// Move the window from the initial start point, to the current mouse location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (posOld != null)
            {
                posNew = Mouse.GetPosition(this);
                // adding the absolute difference between the first and second mouse points to the x and y coordinates of the window
                Left += posNew.Value.X - posOld.Value.X;
                Top += posNew.Value.Y - posOld.Value.Y;
            }
        }

        /// <summary>
        /// Reset all Window Moving dependent variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            posOld = null;
            posNew = null;
        }
    }
}
