//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DragListenerComponent dragListener { get { return (DragListenerComponent)GetComponent(GameComponentsLookup.DragListener); } }
    public bool hasDragListener { get { return HasComponent(GameComponentsLookup.DragListener); } }

    public void AddDragListener(System.Collections.Generic.List<IDragListener> newValue) {
        var index = GameComponentsLookup.DragListener;
        var component = (DragListenerComponent)CreateComponent(index, typeof(DragListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDragListener(System.Collections.Generic.List<IDragListener> newValue) {
        var index = GameComponentsLookup.DragListener;
        var component = (DragListenerComponent)CreateComponent(index, typeof(DragListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDragListener() {
        RemoveComponent(GameComponentsLookup.DragListener);
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

    static Entitas.IMatcher<GameEntity> _matcherDragListener;

    public static Entitas.IMatcher<GameEntity> DragListener {
        get {
            if (_matcherDragListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DragListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDragListener = matcher;
            }

            return _matcherDragListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddDragListener(IDragListener value) {
        var listeners = hasDragListener
            ? dragListener.value
            : new System.Collections.Generic.List<IDragListener>();
        listeners.Add(value);
        ReplaceDragListener(listeners);
    }

    public void RemoveDragListener(IDragListener value, bool removeComponentWhenEmpty = true) {
        var listeners = dragListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveDragListener();
        } else {
            ReplaceDragListener(listeners);
        }
    }
}
