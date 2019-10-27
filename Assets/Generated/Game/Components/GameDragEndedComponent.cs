//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly _1010C.Scripts.Components.Piece.DragEndedComponent dragEndedComponent = new _1010C.Scripts.Components.Piece.DragEndedComponent();

    public bool isDragEnded {
        get { return HasComponent(GameComponentsLookup.DragEnded); }
        set {
            if (value != isDragEnded) {
                var index = GameComponentsLookup.DragEnded;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : dragEndedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDragEnded;

    public static Entitas.IMatcher<GameEntity> DragEnded {
        get {
            if (_matcherDragEnded == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DragEnded);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDragEnded = matcher;
            }

            return _matcherDragEnded;
        }
    }
}