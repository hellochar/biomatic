using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TreeSelectionScreenController : MonoBehaviour
{
    public GameObject treeToClone;
    UIDocument document;
    private Button selectButton;

    void Start() {
        document = GetComponent<UIDocument>();
        document.rootVisualElement.style.display = DisplayStyle.None;
        selectButton = document.rootVisualElement.Q<Button>();
        selectButton.RegisterCallback<ClickEvent>(ev => SelectButtonPressed());
    }

    void SelectButtonPressed() {
        Vector2Int treePosition = World.Main.ReviveWith(Tree.TreeType.TREE_OF_LIFE);
        Instantiate(treeToClone, new Vector3(treePosition.x, treePosition.y, 1), Quaternion.identity);
        document.rootVisualElement.style.display = DisplayStyle.None;
    }

    public void Show() {
        document.rootVisualElement.style.display = DisplayStyle.Flex;
    }
}
