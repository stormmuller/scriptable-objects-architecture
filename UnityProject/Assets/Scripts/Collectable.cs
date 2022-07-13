using ScriptableObjects.Variables;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private IntegerVariable totalBlocksCollected;

    private void OnTriggerEnter(Collider other)
    {
        totalBlocksCollected.CurrentValue += 1;

        print(totalBlocksCollected.CurrentValue);

        Destroy(this.gameObject);
    }
}
