using System;
using System.Net.Mime;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SadApp
{
    public class FormFrame : Frame
    {
        private Label _FormNameLabel;
        private Label _LessonLabel;
        private Label _PointsToGetLabel;

        public FormFrame()
        {
            BindingContext = this;
            BackgroundColor = (Color) Application.Current.Resources["Prim"];
            CornerRadius = 9;
            HasShadow = true;
            Margin = new Thickness(0, 7, 0, 0);

            _FormNameLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
                TextColor = Color.FromHex("#FFFFFF"),
            };

            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                TextColor = Color.FromHex("#FFFFFF")
            };

            _PointsToGetLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                TextColor = Color.FromHex("#FFFFFF")
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
            get => _FormNameLabel.Text ?? string.Empty;
            set => _FormNameLabel.Text = value;
        }

        public string PointsToGet
        {
            get => _PointsToGetLabel.Text ?? string.Empty;
            set => _PointsToGetLabel.Text = value;
        }

        public string Lesson
        {
            get => _LessonLabel.Text ?? string.Empty;
            set => _LessonLabel.Text = value;
        }
    }

    public class GradeFrame : Frame
    {
        private Label _FormNameLabel;
        private Label _PointsGotLabel;
        private Label _LessonLabel;

        public GradeFrame()
        {
            BindingContext = this;
            BackgroundColor = (Color) Application.Current.Resources["Prim"];
            CornerRadius = 9;
            HasShadow = true;
            Margin = new Thickness(0, 7, 0, 0);

            _FormNameLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
                TextColor = Color.FromHex("#FFFFFF"),
            };

            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                TextColor = Color.FromHex("#FFFFFF")
            };

            _PointsGotLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                TextColor = Color.FromHex("#FFFFFF")
            };

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
            get => _FormNameLabel.Text ?? string.Empty;
            set => _FormNameLabel.Text = value;
        }

        public string PointsGot
        {
            get => _PointsGotLabel.Text ?? string.Empty;
            set => _PointsGotLabel.Text = value;
        }

        public string Lesson
        {
            get => _LessonLabel.Text ?? string.Empty;
            set => _LessonLabel.Text = value;
        }
    }

    public class LessonFrame : Frame
    {
        private Label _LessonLabel;
        private Label _TeacherLabel;
        private Label _ClassroomLabel;

        public LessonFrame()
        {
            BindingContext = this;
            BackgroundColor = (Color) Application.Current.Resources["Prim"];
            CornerRadius = 9;
            HasShadow = true;
            Margin = new Thickness(0, 7, 0, 0);

            _LessonLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
                TextColor = Color.FromHex("#FFFFFF"),
            };

            _TeacherLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                TextColor = Color.FromHex("#FFFFFF")
            };

            _ClassroomLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                TextColor = Color.FromHex("#FFFFFF")
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


        public string Lesson
        {
            get => _LessonLabel.Text ?? string.Empty;
            set => _LessonLabel.Text = value;
        }

        public string Teacher
        {
            get => _TeacherLabel.Text ?? string.Empty;
            set => _TeacherLabel.Text = value;
        }

        public string Classroom
        {
            get => _ClassroomLabel.Text ?? string.Empty;
            set => _ClassroomLabel.Text = value;
        }
    }
}