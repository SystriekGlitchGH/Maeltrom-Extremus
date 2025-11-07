using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardMovement : MonoBehaviour
{
    public MagicStats mStats;
    void Awake()
    {
        
    }
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        GetComponent<Tilemap>().WorldToCell(Input.mousePosition);
        mStats.position = Input.mousePosition;
    }
}
