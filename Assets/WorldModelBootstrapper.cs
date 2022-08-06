using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldModelBootstrapper : MonoBehaviour
{
    public GameObject objectToClone;
    private World world => World.Main;

    void Awake() {
        World.Main = new World();

        foreach (Tile tile in world.tiles) {
            Vector3 position = new Vector3(tile.Coordinate.x, tile.Coordinate.y, 0);
            GameObject tileObj = Instantiate(objectToClone, position, Quaternion.identity);
        }
    }
}
