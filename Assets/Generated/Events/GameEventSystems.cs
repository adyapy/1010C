//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameEventSystems : Feature {

    public GameEventSystems(Contexts contexts) {
        Add(new AnyBoardSizeEventSystem(contexts)); // priority: 0
        Add(new ColorEventSystem(contexts)); // priority: 0
        Add(new CubePlacedEventSystem(contexts)); // priority: 0
        Add(new CubeRemovedEventSystem(contexts)); // priority: 0
        Add(new DestroyedEventSystem(contexts)); // priority: 0
        Add(new DragEventSystem(contexts)); // priority: 0
        Add(new DragRemovedEventSystem(contexts)); // priority: 0
        Add(new GridPositionEventSystem(contexts)); // priority: 0
        Add(new PositionEventSystem(contexts)); // priority: 0
        Add(new AnyScoreEventSystem(contexts)); // priority: 0
    }
}
