using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class PlayerInfoEditor : EditorWindow
{
    [MenuItem("Window/UI Toolkit/PlayerInfoEditor")]
    public static void ShowExample()
    {
        PlayerInfoEditor wnd = GetWindow<PlayerInfoEditor>();
        wnd.titleContent = new GUIContent("PlayerInfoEditor");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/PlayerInfoEditor.uxml");
        VisualElement labelFromUXML = visualTree.Instantiate();
        root.Add(labelFromUXML);

        // A stylesheet can be added to a VisualElement.
        // The style will be applied to the VisualElement and all of its children.
        var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/PlayerInfoEditor.uss");
        root.styleSheets.Add(styleSheet);
    }
}