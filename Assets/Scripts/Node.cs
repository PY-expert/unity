using UnityEngine;

public class Node : MonoBehaviour
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
