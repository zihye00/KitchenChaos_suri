using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private ClearCounter clearCounter;
    [SerializeField] private GameObject visualGameObject;

    //awake�� ���� �� instance�� ��� ������ �� ��.
    //�ʱ�ȭ�� awake. �������� ���� start
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
