using Syncfusion.Maui.Expander;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        StackLayout stack;
        SfExpander expander1, expander2;

        public MainPage()
        {
            InitializeComponent();

            stack = new StackLayout();
            // Expander 1
            expander1 = new SfExpander();
            // Expander header view
            var header1 = new Grid()
            {
                HeightRequest = 40
            };
            var headerLabel = new Label()
            {
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                Text = "Veg Pizza",

            };
            header1.Children.Add(headerLabel);
            expander1.Header = header1;

            // Expander content view
            var content1 = new Grid()
            {
                HeightRequest = 60
            };

            var contentLabel = new Label()
            {
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                HeightRequest = 60,
                Text = "Veg pizza is prepared with the items that meet vegetarian standards by not including any meat or animal tissue products.",
            };

            content1.Children.Add(contentLabel);
            expander1.Content = content1;

            // Expander 2
            expander2 = new SfExpander();
            // Expander header view
            var header2 = new Grid()
            {
                HeightRequest = 40
            };
            var headerLabel2 = new Label()
            {
                Text = "Non- Veg Pizza",
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
            };
            header2.Children.Add(headerLabel2);
            expander2!.Header = header2;

            // Expander content view
            var content2 = new Grid()
            {
                HeightRequest = 60
            };

            var contentLabel2 = new Label()
            {
                HeightRequest = 60,
                Text = "Non-veg pizza is prepared by including the meat and animal tissue products.",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
            };
            content2.Children.Add(contentLabel2);
            expander2!.Content = content2;

            stack.Children.Add(expander1);
            stack.Children.Add(expander2);
            this.Content = stack;
        }
    }
}
