using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private ClearCounter clearCounter;
    [SerializeField] private GameObject visualGameObject;

    //awake에 했을 시 instance가 없어서 에러가 날 것.
    //초기화는 awake. 기져오는 것은 start
    private void Start()
    {
        Player.Instance.OnselectedCounterChanged += Player_OnselectedCounterChanged;
    }

    private void Player_OnselectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == clearCounter)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Show() { visualGameObject.SetActive(true); }
    private void Hide() { visualGameObject.SetActive(false); }
}
