using UnityEngine;

public class Tile {
  public TileType Type;
  public Vector2Int Coordinate;

  public Tile(TileType type, Vector2Int coordinate) {
    Type = type;
    Coordinate = coordinate;
  }
}