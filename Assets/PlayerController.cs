using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour {
    private World world;
    // Start is called before the first frame update
    void Start() {
        world = new World();
    }

    // Update is called once per frame
    void Update() {
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

        world.player.position += inputValues;
        transform.position = new Vector3(world.player.position.x, world.player.position.y, transform.position.z);
    }
}
