using Microsoft.Maui.Controls;
namespace SmartmanApps.Controls;
public class TestImagePage :ContentPage
{
public TestImagePage() {
    Label newLabel=new Label{
        Text="TestImagePage",
        };
    Image dotnetBotImage=new Image{
        Source="dotnet_bot.png",
//        Source="dropboxicon.png",
        HeightRequest=200,
        HorizontalOptions=LayoutOptions.Center,
        };
    Image dropboxImage=new Image{
        Source="dropboxicon.png",
//        Source="dotnet_bot.png",
        HeightRequest=200,
        HorizontalOptions=LayoutOptions.Center,
        };
//    Content=newLabel;
//    Content=dotnetBotImage;
    Content=dropboxImage;
    }
}
