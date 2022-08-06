using UnityEngine;

public class World {
  public static World Main;

  public Tile[,] tiles;
  public Player player;
  private Vector2Int queuedAction;

  public int Width => tiles.GetLength(0);
  public int Height => tiles.GetLength(1);

  public World() {
    player = new Player(new Vector2Int(0, 5));

    tiles = new Tile[36, 11];
    for (int x = 0; x < this.Width; x++) {
      for (int y = 0; y < this.Height; y++) {
        tiles[x, y] = new Tile(TileType.GROUND, new Vector2Int(x, y));
      }
    }
  }

  public bool TakeTurn() {
    player.position += queuedAction;
    queuedAction.Set(0, 0);

    bool showPlantSelector = false;

    player.age += 1;
    if (player.age == Player.MAX_AGE) {
      player.Die();
      showPlantSelector = true;      
    }

    return showPlantSelector;
  }

  public void QueueAction(Vector2Int movement) {
    queuedAction = movement;
  }

  public bool ShouldTakeTurn() {
    return queuedAction.x != 0 || queuedAction.y != 0;
  }

  public bool canTimePass() {
    return player.age < Player.MAX_AGE;
  }
}
