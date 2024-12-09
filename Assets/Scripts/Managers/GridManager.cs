using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static GridManager Instance;
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _grassTile, _mountainTile;
    [SerializeField] private Transform _cam;

    private Dictionary<Vector2, Tile> _tiles = new();

    void Awake()
    {
        Instance = this;
    }

    Tile GetRandomTile()
    {
        var randomTile = Random.Range(0, 6) == 3 ? _mountainTile : _grassTile;
        return randomTile;
    }

    public void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var spawnedTile = Instantiate(GetRandomTile(), new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                spawnedTile.Init(x, y);

                _tiles[new Vector2(x, y)] = spawnedTile;
            }
        }

        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);

        GameManager.Instance.ChangeState(GameState.SpawnHeroes);
    }

    public Tile GetTileAtPosition(Vector2 position)
    {
        if (_tiles.TryGetValue(position, out var tile))
        {
            return tile;
        }
        return null;
    }

    void Start()
    {
    }

    void Update()
    {

    }
}
