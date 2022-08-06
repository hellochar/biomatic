using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class TreeSelectionMenu : EditorWindow
{
    [MenuItem("Window/UI Toolkit/TreeSelectionMenu")]
    public static void ShowExample()
    {
        TreeSelectionMenu wnd = GetWindow<TreeSelectionMenu>();
        wnd.titleContent = new GUIContent("TreeSelectionMenu");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/TreeSelectionMenu.uxml");
        VisualElement labelFromUXML = visualTree.Instantiate();
        root.Add(labelFromUXML);
    }
}