using Mino;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using VcontainerTest;

public class GameLifetimeScope : LifetimeScope
{
    [SerializeField] MinoView minoView;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.UseEntryPoints(Lifetime.Singleton, entryPoints =>
        {
            entryPoints.Add<MinoPresenter>();
        });
        
        // Mino
        builder.Register<MinoService>(Lifetime.Singleton);
        builder.RegisterComponent(minoView);
    }
}
