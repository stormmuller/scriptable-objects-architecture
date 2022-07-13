using ScriptableObjects.Variables;
using TMPro;
using UnityEngine;

public class NumberDisplay : MonoBehaviour
{
    [SerializeField] private IntegerVariable totalBlocksCollected;

    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text.text = totalBlocksCollected.CurrentValue.ToString();            
    }
}
