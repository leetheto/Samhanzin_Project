using UnityEngine;

public class ResourceNode : MonoBehaviour
{
    public string resourceType;
    public int amount;

    public void Gather(int quantity)
    {
        amount -= quantity;
        if (amount <= 0)
            Destroy(gameObject);
    }
}
