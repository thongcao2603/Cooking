
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private Transform tomatoPrefab;
    [SerializeField] private Transform counterTopPoint;
    public void Interact()
    {
        Debug.Log("interact");
        Instantiate(tomatoPrefab, counterTopPoint);

    }
}
