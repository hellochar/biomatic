using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInfoController : MonoBehaviour {
    private Label currentAgeLabel;

    void Start() {}

    private void OnEnable() {
        var uiDoc = GetComponent<UIDocument>();
        currentAgeLabel = uiDoc.rootVisualElement.Q<Label>();
    }

    void Update() {
        currentAgeLabel.text = $"You are {World.Main.player.age * 10} years old";
    }
}
