using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private GameObject statusPanel;
    [SerializeField] private Button statusButton;
    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI criticalText;
    
    public GameObject StatusPanel => statusPanel;
    public Button StatusButton => statusButton;
    
    private void Start()
    {
        statusButton.onClick.AddListener(UIManager.Instance.MainMenu.OpenStatus);
    }

    private void OnEnable()
    {
        SetStatusUI();
    }

    private void SetStatusUI()
    {
        attackText.SetText($"Attack +{GameManager.Instance.Player.AttackPower}");
        defenseText.SetText($"Defence +{GameManager.Instance.Player.DefencePower}");
        healthText.SetText($"Health +{GameManager.Instance.Player.Health}");
        criticalText.SetText($"Critical +{GameManager.Instance.Player.Critical}");
    }
}
