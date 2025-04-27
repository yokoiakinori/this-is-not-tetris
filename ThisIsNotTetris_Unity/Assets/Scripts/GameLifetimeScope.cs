using UnityEngine;
using VContainer;
using VContainer.Unity;
using VcontainerTest;

public class GameLifetimeScope : LifetimeScope
{
    [SerializeField] HelloWorldScreen helloWorldScreen;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<HelloWorldService>(Lifetime.Singleton);
        builder.RegisterEntryPoint<HelloWorldPresenter>();
        builder.RegisterComponent(helloWorldScreen);
    }
}
