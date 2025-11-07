using UnityEngine;

public class MagicStats : MonoBehaviour
{
    [SerializeField] Transform mTransform;
    public Vector3 position;
    void Awake()
    {
        position = transform.position;
    }
    void Update()
    {
        
    }
}
