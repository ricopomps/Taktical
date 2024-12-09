using UnityEngine;

public class GrassTile : Tile
{
    [SerializeField] private Color _baseColor, _offsetColor;
    public override void Init(int x, int y)
    {
        var isOffset = (x + y) % 2 == 1;

        _rendered.color = isOffset ? _offsetColor : _baseColor;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
