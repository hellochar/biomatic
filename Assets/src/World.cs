using UnityEngine;

public class World {
  private TileType[,] tiles;
  public Player player;
  private Vector2Int queuedAction;

  public World() {
    tiles = new TileType[36, 11];
    player = new Player(new Vector2Int(0, 5));
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
