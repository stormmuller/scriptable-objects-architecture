using ScriptableObjects.Variables;
using TMPro;
using UnityEngine;

public class GameCompletetionDisplay : MonoBehaviour
{
    [SerializeField] private IntegerVariable totalBlocksCollected;
    [SerializeField] private IntegerVariable requiredBlocks;

    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();

        SetBlockColectedText(requiredBlocks);
    }

    public void OnBlockCollected()
    {
        var blocksLeft = requiredBlocks - totalBlocksCollected;

        SetBlockColectedText(blocksLeft);
    }

    private void SetBlockColectedText(int blocksLeft)
    {
        if (blocksLeft <= 0)
        {
            text.text = "Level Complete";
            return;
        }

        text.text = $"Collect {blocksLeft} to finish the level";
    }
}
