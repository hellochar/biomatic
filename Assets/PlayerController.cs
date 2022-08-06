using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour {
    public TreeSelectionScreenController TreeSelectionScreen;

    private World world => World.Main;

    void Start() {
        transform.position = new Vector3(world.player.position.x, world.player.position.y, transform.position.z);
    }

    void Update() {
        if (world.canTimePass()) {
            world.QueueAction(getPlayerInput());

            if (world.ShouldTakeTurn()) {
                if (world.TakeTurn()) {
                    ShowPlantSelector();
                }
            }
        }

        
        Vector3 newPos = new Vector3(world.player.position.x, world.player.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPos, 0.25f);
    }

    void ShowPlantSelector() {
        TreeSelectionScreen.Show();
    }

    private Vector2Int getPlayerInput() {
        Vector2Int inputValues = new Vector2Int(0, 0);

        if (Input.GetButtonDown("Horizontal")) {
            float value = Input.GetAxis("Horizontal");
            if (value < 0) {
                inputValues.x = -1;
            } else {
                inputValues.x = 1;
            }
        }

        if (Input.GetButtonDown("Vertical")) {
            float value = Input.GetAxis("Vertical");
            if (value < 0) {
                inputValues.y = -1;
            } else {
                inputValues.y = 1;
            }
        }

        return inputValues;
    }
}
