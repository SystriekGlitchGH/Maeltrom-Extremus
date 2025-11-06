using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardMovement : MonoBehaviour
{
    void Awake()
    {
        
    }
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        GetComponent<Tilemap>().WorldToCell(Input.mousePosition);
    }
}
