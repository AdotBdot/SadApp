using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace SadApp
{
    public class Gradient : LinearGradientBrush
    {
        protected Color _StartColor;
        protected Color _EndColor;

        public Gradient()
        {
            StartPoint = Point.Zero;
            EndPoint = new Point(1, 1);

            _StartColor = Color.FromHex("#4adede");
            _EndColor = Color.FromHex("#1f2f98");

            GradientStops = new Xamarin.Forms.GradientStopCollection()
            {
                new Xamarin.Forms.GradientStop(_StartColor, 0.1f),
                new Xamarin.Forms.GradientStop(_EndColor, 1.0f)
            };
        }

        public Color StartColor
        {
            get => _StartColor;
            set
            {
                _StartColor = value;
                GradientStops.First().Color = value;
            }
        }

        public Color EndColor
        {
            get => _EndColor;
            set
            {
                _EndColor = value;
                GradientStops.Last().Color = value;
            }
        }
    }

    public class Form : PancakeView
    {
        private Label _FormNameLabel;
        private Label _LessonLabel;
        private Label _PointsToGetLabel;

        public Form()
        {
            CornerRadius = new CornerRadius(9);
            Padding = new Thickness(9);
            Shadow = new DropShadow()
            {
                Opacity = 1,
                Offset = new Point(9, 9)
            };

            _FormNameLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                Text = "Nazwa formy"
            };
            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                Text = "Lekcja"
            };
            _PointsToGetLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                Text = "Max punktów do zdobycia"
            };

            Content = new StackLayout()
            {
                Children =
                {
                    _FormNameLabel,
                    _PointsToGetLabel,
                    _LessonLabel
                }
            };
        }

        public string FormName
        {
            set => _FormNameLabel.Text = value;
        }

        public string PointsToGet
        {
            set => _PointsToGetLabel.Text = value;
        }

        public string Lesson
        {
            set => _LessonLabel.Text = value;
        }

        public Color TextColor
        {
            set
            {
                _FormNameLabel.TextColor = value;
                _PointsToGetLabel.TextColor = value;
                _LessonLabel.TextColor = value;
            }
        }
    }

    public class Grade : PancakeView
    {
        private Label _FormNameLabel;
        private Label _PointsLabel;
        private Label _LessonLabel;

        public Grade()
        {
            CornerRadius = new CornerRadius(9);
            Padding = new Thickness(9);
            Shadow = new DropShadow()
            {
                Opacity = 1,
                Offset = new Point(9, 9)
            };

            _FormNameLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                Text = "Nazwa formy"
            };
            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                Text = "Lekcja"
            };
            _PointsLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                Text = "Punkty Zdobyte/Max Punktów"
            };

            Content = new StackLayout()
            {
                Children =
                {
                    _FormNameLabel,
                    _PointsLabel,
                    _LessonLabel
                }
            };
        }

        public string FormName
        {
            set => _FormNameLabel.Text = value;
        }

        public string Points
        {
            set => _PointsLabel.Text = value;
        }

        public string Lesson
        {
            set => _LessonLabel.Text = value;
        }

        public Color TextColor
        {
            set
            {
                _FormNameLabel.TextColor = value;
                _PointsLabel.TextColor = value;
                _LessonLabel.TextColor = value;
            }
        }
    }

    public class Lesson : PancakeView
    {
        private Label _LessonLabel;
        private Label _TeacherLabel;
        private Label _ClassroomLabel;

        public Lesson()
        {
            CornerRadius = new CornerRadius(9);
            Padding = new Thickness(9);
            Shadow = new DropShadow()
            {
                Opacity = 1,
                Offset = new Point(9, 9)
            };

            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                Text = "Lekcja"
            };

            _TeacherLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                Text = "Nauczyciel"
            };

            _ClassroomLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                Text = "Sala lekcyjna"
            };

            Content = new StackLayout()
            {
                Children =
                {
                    _LessonLabel,
                    _TeacherLabel,
                    _ClassroomLabel
                }
            };
        }

        public string Name
        {
            set => _LessonLabel.Text = value;
        }

        public string Teacher
        {
            set => _TeacherLabel.Text = value;
        }

        public string Classroom
        {
            set => _ClassroomLabel.Text = value;
        }

        public Color TextColor
        {
            set
            {
                _LessonLabel.TextColor = value;
                _TeacherLabel.TextColor = value;
                _ClassroomLabel.TextColor = value;
            }
        }
    }

    public class LessonGrades : PancakeView
    {
        private Label _LessonLabel; //Lesson Course  (f.e. Math 101)

        public LessonGrades()
        {
            CornerRadius = new CornerRadius(9);
            Padding = new Thickness(9);
            Shadow = new DropShadow()
            {
                Opacity = 1,
                Offset = new Point(9, 9)
            };

            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                Text = "Lekcja"
            };

            Content = new StackLayout()
            {
                Children =
                {
                    _LessonLabel,
                    new Label()
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                        Text = "Example Form 1: 00/100"
                    },
                    new Label()
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                        Text = "Example Form 2: 00/100"
                    },
                    new Label()
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                        Text = "Example Form 3: 00/100"
                    }
                }
            };
        }

        public string Lesson
        {
            set => _LessonLabel.Text = value;
        }

        public Color TextColor
        {
            set {_LessonLabel.TextColor = value;}
        }
    }
}