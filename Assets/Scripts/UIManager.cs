using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public static UIManager instance { get; set; } = null;

    public Text _timerText = null;
    private Text timerText { get { return _timerText; } }

    public Text _goldText = null;
    private Text goldText { get { return _goldText; } }

    private void Awake()
    {
        instance = this;
    }
    private void Start()    
    {
        
    }

    private void Update()
    {
        
    }
    public void SetTimer (float timer)
    {
        timerText.text = "Timer:" + timer.ToString("F1");
    }

    public void SetGold(int gold)
    {
        goldText.text = "Gold :" + gold;
    }
}
