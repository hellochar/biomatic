using UnityEngine;
using System.Collections.Generic;

public class World {
  public static World Main;

  public Tile[,] tiles;
  public Player player;
  private Vector2Int queuedAction;

  private List<Tree> trees;

  public int Width => tiles.GetLength(0);
  public int Height => tiles.GetLength(1);

  public World() {
    trees = new List<Tree>();
    player = new Player(new Vector2Int(0, 5));

    tiles = new Tile[36, 11];
    for (int x = 0; x < this.Width; x++) {
      for (int y = 0; y < this.Height; y++) {
        tiles[x, y] = new Tile(TileType.GROUND, new Vector2Int(x, y));
      }
    }
  }

  public bool ShouldTakeTurn() {
    return queuedAction.x != 0 || queuedAction.y != 0;
  }

  public bool TakeTurn() {
    Vector2Int proposedPosition = player.position + queuedAction;
    foreach (Tree t in trees) {
      if (t.position == proposedPosition) {
        return false;
      }
    }

    player.position = proposedPosition;
    queuedAction.Set(0, 0);

    bool showPlantSelector = false;

    player.age += 1;
    if (player.age == Player.MAX_AGE) {
      player.Die();
      showPlantSelector = true;      
    }

    return showPlantSelector;
  }

  public Vector2Int ReviveWith(Tree.TreeType treeType) {
    Vector2Int treePosition = new Vector2Int(player.position.x, player.position.y);
    Tree newTree = new Tree(treeType, treePosition);
    trees.Add(newTree);
    
    player.age = 0;
    player.position.x = treePosition.x;
    player.position.y = treePosition.y;

    return treePosition;
  }

  public void QueueAction(Vector2Int movement) {
    queuedAction = movement;
  }

  public bool CanTimePass() {
    return player.age < Player.MAX_AGE;
  }
}
