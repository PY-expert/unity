using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Node cameFrom;
    public list<Node> connections;

    public float gScore;
    public float hScore;

    public float FSscore()
    {
        return gScore + hScore;
    }
}
