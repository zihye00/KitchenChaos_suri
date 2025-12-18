using UnityEngine;

public class TrashCounter : BaseCounter
{
    public override void Interact(Player player)
    {
        if (player.HasKitchenOobject())
        {
            player.GetKitchenObject().DestroySelf();
        }
    }
}
