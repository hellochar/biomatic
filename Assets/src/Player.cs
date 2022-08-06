using UnityEngine;

public class Player {
  public static readonly int MAX_AGE = 10;
  public Vector2Int position;
  public int age;

  public Player(Vector2Int initialPosition) {
    position = initialPosition;
    age = 7;
  }

  public void Die() {

  }
}
