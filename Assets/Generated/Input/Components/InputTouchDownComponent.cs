//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public _1010C.Components.Input.TouchDownComponent touchDown { get { return (_1010C.Components.Input.TouchDownComponent)GetComponent(InputComponentsLookup.TouchDown); } }
    public bool hasTouchDown { get { return HasComponent(InputComponentsLookup.TouchDown); } }

    public void AddTouchDown(UnityEngine.Vector2 newValue) {
        var index = InputComponentsLookup.TouchDown;
        var component = (_1010C.Components.Input.TouchDownComponent)CreateComponent(index, typeof(_1010C.Components.Input.TouchDownComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTouchDown(UnityEngine.Vector2 newValue) {
        var index = InputComponentsLookup.TouchDown;
        var component = (_1010C.Components.Input.TouchDownComponent)CreateComponent(index, typeof(_1010C.Components.Input.TouchDownComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTouchDown() {
        RemoveComponent(InputComponentsLookup.TouchDown);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherTouchDown;

    public static Entitas.IMatcher<InputEntity> TouchDown {
        get {
            if (_matcherTouchDown == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.TouchDown);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherTouchDown = matcher;
            }

            return _matcherTouchDown;
        }
    }
}
