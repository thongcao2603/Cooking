
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    public void Interact()
    {
        Debug.Log("interact");
        Transform s = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        s.localPosition = new Vector3(0, 0, 0);
        Debug.Log(s.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
