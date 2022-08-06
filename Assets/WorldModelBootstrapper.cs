using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldModelBootstrapper : MonoBehaviour
{
    void Awake() {
        World.Main = new World();
    }
}
