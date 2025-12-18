using UnityEngine;

public interface IKitchenObjectParent
{
    public Transform GetKichenObjectFollowTransform();

    public void SetKitchenObject(KitchenObject kitchenObject);

    public KitchenObject GetKitchenObject();

    public void ClearKitchenObject();

    public bool HasKitchenOobject();
}
