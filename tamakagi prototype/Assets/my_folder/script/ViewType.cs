using UniRx;

public enum ViewType
{
    Menu,
    ViewA,
    ViewB,
    ViewC
}

[System.Serializable]
public class ViewTypeReactiveProperty : ReactiveProperty<ViewType>
{
    public ViewTypeReactiveProperty ()
    {

    }
}

#if UNITY_EDITOR
[UnityEditor.CustomPropertyDrawer(typeof(ViewTypeReactiveProperty))]
public class ViewTypeReactivePropertyDrawer : InspectorDisplayDrawer { }
#endif