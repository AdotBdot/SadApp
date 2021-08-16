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
            CornerRadius = new CornerRadius(9f, 9f, 9f, 9f);

            _FormNameLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };

            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };

            _PointsToGetLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };

            _FormNameLabel.SetAppThemeColor(Label.TextColorProperty, Color.White, Color.Black);
            _LessonLabel.SetAppThemeColor(Label.TextColorProperty, Color.White, Color.Black);
            _PointsToGetLabel.SetAppThemeColor(Label.TextColorProperty, Color.White, Color.Black);

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

    public class GradeFrame : PancakeView
    {
        private Label _FormNameLabel;
        private Label _PointsGotLabel;
        private Label _LessonLabel;

        public GradeFrame()
        {
            CornerRadius = new CornerRadius(9);

            _FormNameLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };

            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };

            _PointsGotLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };

            _FormNameLabel.SetAppThemeColor(Label.TextColorProperty, Color.White, Color.Black);
            _LessonLabel.SetAppThemeColor(Label.TextColorProperty, Color.White, Color.Black);
            _PointsGotLabel.SetAppThemeColor(Label.TextColorProperty, Color.White, Color.Black);

            Content = new StackLayout()
            {
                Children =
                {
                    _FormNameLabel,
                    _PointsGotLabel,
                    _LessonLabel
                }
            };
        }

        public string FormName
        {
            set => _FormNameLabel.Text = value;
        }

        public string PointsGot
        {
            set => _PointsGotLabel.Text = value;
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
                _PointsGotLabel.TextColor = value;
                _LessonLabel.TextColor = value;
            }
        }
    }

    public class LessonFrame : PancakeView
    {
        private Label _LessonLabel;
        private Label _TeacherLabel;
        private Label _ClassroomLabel;

        public LessonFrame()
        {
            CornerRadius = new CornerRadius(9);

            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };

            _TeacherLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };

            _ClassroomLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };

            _LessonLabel.SetAppThemeColor(Label.TextColorProperty, Color.White, Color.Black);
            _TeacherLabel.SetAppThemeColor(Label.TextColorProperty, Color.White, Color.Black);
            _ClassroomLabel.SetAppThemeColor(Label.TextColorProperty, Color.White, Color.Black);

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

        public string Lesson
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
                _LessonLabel.TextColor = value;
            }
        }
    }

    public class LessonGrades : PancakeView
    {
        private Label _LessonLabel; //Lesson Course  (f.e. Math 101)

        public LessonGrades()
        {
            CornerRadius = new CornerRadius(9);

            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold
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