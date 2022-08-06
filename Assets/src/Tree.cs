using UnityEngine;

public class Tree {
  public enum TreeType {
    TREE_OF_LIFE
  }

  private TreeType treeType;
  private Vector2Int position;

  public Tree(TreeType _type, Vector2Int _position) {
    treeType = _type;
    position = _position;
  }
}