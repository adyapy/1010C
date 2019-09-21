//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _1010C.Components.Reserve.ReserveSlotStateComponent reserveSlotState { get { return (_1010C.Components.Reserve.ReserveSlotStateComponent)GetComponent(GameComponentsLookup.ReserveSlotState); } }
    public bool hasReserveSlotState { get { return HasComponent(GameComponentsLookup.ReserveSlotState); } }

    public void AddReserveSlotState(_1010C.Components.Reserve.ReserveSlotState newValue) {
        var index = GameComponentsLookup.ReserveSlotState;
        var component = (_1010C.Components.Reserve.ReserveSlotStateComponent)CreateComponent(index, typeof(_1010C.Components.Reserve.ReserveSlotStateComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceReserveSlotState(_1010C.Components.Reserve.ReserveSlotState newValue) {
        var index = GameComponentsLookup.ReserveSlotState;
        var component = (_1010C.Components.Reserve.ReserveSlotStateComponent)CreateComponent(index, typeof(_1010C.Components.Reserve.ReserveSlotStateComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveReserveSlotState() {
        RemoveComponent(GameComponentsLookup.ReserveSlotState);
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

    static Entitas.IMatcher<GameEntity> _matcherReserveSlotState;

    public static Entitas.IMatcher<GameEntity> ReserveSlotState {
        get {
            if (_matcherReserveSlotState == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ReserveSlotState);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherReserveSlotState = matcher;
            }

            return _matcherReserveSlotState;
        }
    }
}
