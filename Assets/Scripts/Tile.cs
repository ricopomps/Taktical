using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _rendered;
    [SerializeField] private GameObject _highlight;

    public void Init(bool isOffset)
    {
        _rendered.color = isOffset ? _offsetColor : _baseColor;
    }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }
    void OnMouseExit()
    {
        _highlight.SetActive(false);
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
