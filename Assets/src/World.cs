using UnityEngine;

public class World {
  private TileType[,] tiles;
  public Player player;

  public World() {
    tiles = new TileType[36, 11];
    player = new Player(new Vector2Int(0, 5));
  }
}
