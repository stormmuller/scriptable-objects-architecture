using ScriptableObjects.GameEvents;
using ScriptableObjects.Variables;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private IntegerVariable totalBlocksCollected;
    [SerializeField] private GameEvent onBlockCollectedEvent;

    private void OnTriggerEnter(Collider other)
    {
        totalBlocksCollected.CurrentValue += 1;

        onBlockCollectedEvent.Raise();

        Destroy(this.gameObject);
    }
}
