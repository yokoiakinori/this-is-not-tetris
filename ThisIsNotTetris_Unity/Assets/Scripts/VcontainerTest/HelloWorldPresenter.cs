using VContainer.Unity;

namespace VcontainerTest
{
    public class HelloWorldPresenter: IStartable
    {
        readonly HelloWorldService _helloWorldService;
        readonly HelloWorldScreen _helloWorldScreen;

        public HelloWorldPresenter(
            HelloWorldService helloWorldService,
            HelloWorldScreen helloWorldScreen)
        {
            _helloWorldService = helloWorldService;
            _helloWorldScreen = helloWorldScreen;
        }

        void IStartable.Start()
        {
            _helloWorldScreen.sendButton.onClick.AddListener(() => _helloWorldService.Hello());
        }
    }
}