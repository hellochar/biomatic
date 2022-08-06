using UnityEngine;

public class World {
  private TileType[,] tiles;
  public Player player;

  public World() {
    tiles = new TileType[36, 11];
    player = new Player(new Vector2Int(0, 5));
  }

  public bool takeTurn() {
    bool showPlantSelector = false;

    player.age += 1;
    if (player.age == Player.MAX_AGE) {
      player.Die();
      showPlantSelector = true;      
    }

    return showPlantSelector;
  }

  public bool canTimePass() {
    return player.age < Player.MAX_AGE;
  }
}
