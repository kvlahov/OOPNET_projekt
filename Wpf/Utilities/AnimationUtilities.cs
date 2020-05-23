using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Wpf.Utilities
{
    static class AnimationUtilities
    {
        private static Storyboard storyBoard = new Storyboard();
        public static void AnimateProperty(double from, double to, DependencyObject target, object property, float duration)
        {
            var doubleAnimation = new DoubleAnimation
            {
                From = from,
                To = to,
                EasingFunction = new BackEase(),
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                
            };

            storyBoard.Children.Add(doubleAnimation);
            Storyboard.SetTarget(doubleAnimation, target);
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(property));

            storyBoard.Begin();

        }

        public static AnimationTimeline PrepareAnimation(double from, double to, DependencyObject target, object property, float duration)
        {
            var doubleAnimation = new DoubleAnimation
            {
                From = from,
                To = to,
                EasingFunction = new CircleEase(),
                Duration = new Duration(TimeSpan.FromSeconds(duration)),

            };

            Storyboard.SetTarget(doubleAnimation, target);
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(property));

            return doubleAnimation;

        }
    }
}
