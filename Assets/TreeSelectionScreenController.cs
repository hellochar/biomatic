using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TreeSelectionScreenController : MonoBehaviour
{
    UIDocument document;
    // Start is called before the first frame update
    void Start()
    {
        document = GetComponent<UIDocument>();
        document.rootVisualElement.style.display = DisplayStyle.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show() {
        document.rootVisualElement.style.display = DisplayStyle.Flex;
    }
}
